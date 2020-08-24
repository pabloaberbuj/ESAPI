using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VMS.TPS.Common.Model.Types;
using VMS.TPS.Common.Model.API;

namespace ExploracionPlanes
{
    public static class Chequeos
    {
        public static string camilla(PlanSetup plan)
        {
            bool noHayCamilla = true;
            string texto = "";
            foreach (Structure estructura in plan.StructureSet.Structures)
            {
                if (estructura.DicomType == "SUPPORT")
                {
                    noHayCamilla = false;
                    if (!coincidenciaCamillas(estructura.Name, plan.Beams.First().TreatmentUnit.Id, plan))
                    {
                        texto += "\nLa camilla no es la adecuada para el equipo elegido";
                        break;
                    }
                }
            }
            if (noHayCamilla)
            {
                texto += "\nNo tiene camilla";
            }
            return texto;
        }

        public static string origen(PlanSetup plan)
        {
            string texto = "";
            if (plan.StructureSet.Image.UserOrigin.Equals(new VVector(0, 0, 0)))
            {
                texto += "\nRevisar las coordenadas de la referencia";
            }
            return texto;
        }

        public static string isoCercaDeOrigen(PlanSetup plan)
        {
            string texto = "";
            double distanciaChica = 20;
            if (distanciaMaxima(plan.StructureSet.Image.UserOrigin, plan.Beams.First().IsocenterPosition) > 0.001 &&
                distanciaMaxima(plan.StructureSet.Image.UserOrigin, plan.Beams.First().IsocenterPosition) < distanciaChica)
            {
                texto += "\nEl isocentro está muy cerca de la referencia. Evaluar la posibilidad de planificar en referencia";
            }
            return texto;
        }


        public static string referencePointTieneLocalizacion(PlanSetup plan)
        {
            string texto = "";
            foreach (FieldReferencePoint punto in plan.Beams.First().FieldReferencePoints)
            {
                if (punto.IsPrimaryReferencePoint)
                {
                    if (!double.IsNaN(punto.RefPointLocation.x) && !double.IsNaN(punto.RefPointLocation.y) && !double.IsNaN(punto.RefPointLocation.z))
                    {
                        texto += "\nEl punto de referencia tiene ubicación física";
                    }
                }
            }
            return texto;
        }
        public static string merge(PlanSetup plan)
        {
            bool fusionables = false;
            string texto = "";
            {
                foreach (Beam campo1 in plan.Beams)
                {
                    if (campo1.MLCPlanType != MLCPlanType.VMAT && campo1.MLCPlanType != MLCPlanType.ArcDynamic && !campo1.IsSetupField && campo1.Wedges.Count() == 0 && campo1.Applicator == null)
                    {
                        foreach (Beam campo2 in plan.Beams)
                        {
                            if (campo2.MLCPlanType != MLCPlanType.VMAT && campo2.MLCPlanType != MLCPlanType.ArcDynamic && !campo2.IsSetupField && campo2.Wedges.Count() == 0 && campo2.Applicator == null)
                            {
                                if (campo1.Id != campo2.Id && camposFusionables(campo1, campo2))
                                {
                                    fusionables = true;
                                }
                            }
                        }
                    }

                }
            }
            if (fusionables)
            {
                texto += "\nEs posible que se puedan fusionar algunos campos";
            }
            return texto;
        }

        public static string comparaIsosPlanSuma(PlanSum planSuma)
        {
            string texto = "";
            foreach (PlanSetup etapaA in planSuma.PlanSetups)
            {
                foreach (PlanSetup etapaB in planSuma.PlanSetups)
                {
                    if (isosDiferentes(etapaA, etapaB))
                    {
                        texto += "\nLos planes " + etapaA.Id + " y " + etapaB.Id + " tienen isos similares.\nEvaluar la utilización de un mismo iso";
                    }
                }
            }
            return texto;
        }

        public static string comparaIsosEnUnPlan(PlanSetup plan)
        {
            string texto = "";
            foreach (Beam campo in plan.Beams)
            {
                if (distanciaMaxima(plan.Beams.First().IsocenterPosition, campo.IsocenterPosition) > 0.01)
                {
                    texto += "\nEl plan tiene más de un isocentro";
                    if (campo.TreatmentUnit.Id == "D-2300CD" || campo.TreatmentUnit.Id == "Equipo1")
                    {
                        texto += ". No será posible realizar el 2D/2D match en el equipo. Se sugiere separar en dos planes";
                    }
                    break;
                }
            }
            return texto;
        }

        public static string hayTratamientoAprobado(PlanSetup planActual)
        {
            string texto = "";
            Patient paciente = planActual.Course.Patient;
            foreach (Course curso in paciente.Courses)
            {
                foreach (PlanSetup plan in curso.PlanSetups)
                {
                    if (plan.ApprovalStatus == PlanSetupApprovalStatus.TreatmentApproved)
                    {
                        texto += "\n" + curso.Id + " - " + plan.Id + ": el plan tiene el tratamiento aprobado";
                    }
                }
            }
            return texto;
        }

        public static string tomografiaVieja(PlanSetup plan)
        {
            string texto = "";
            if (plan.Series.Study.CreationDateTime != null)
            {
                DateTime fechaTomo = (DateTime)plan.Series.Study.CreationDateTime;
                if ((DateTime.Today - fechaTomo).Days - 30 > 0)
                {
                    texto += "\nEl estudio tomográfico tiene más de 1 mes. Revisar si es el correcto";
                }
            }
            return texto;
        }


        public static string estructuraNombreCursoCorrecta(PlanSetup plan)
        {
            string texto = "";
            Regex estructura = new Regex(@"^C[0-9]_[a-zA-Z]{3}[0-9]{2}$");
            {
                if (!estructura.IsMatch(plan.Course.Id))
                {
                    texto += "\nRevisar el formato de nombre del curso (por ejemplo C0_Sep19)";
                }
            }
            return texto;
        }

        public static string UMporGrado(Beam campo)
        {
            string texto = "";
            if (campo.Technique.Id == "ARC" && campo.MLCPlanType != MLCPlanType.VMAT) //solo arcos conformados, no vmat
            {
                if (campo.Meterset.Value / campo.ArcLength >= 20)
                {
                    texto += "\n" + campo.Id + ": UM/longitud de arco es mayor a 20 (" + (campo.Meterset.Value / campo.ArcLength).ToString() + ")";
                }
                else if ((campo.ArcLength * campo.DoseRate) / (campo.Meterset.Value * 60) >= 4.2)
                {
                    texto += "\n" + campo.Id + ": pocas UMs para esa longitud de arco y Dose Rate";
                }
            }
            return texto;
        }

        public static string doseRate(Beam campo)
        {
            string texto = "";
            if (campo.TreatmentUnit.Id == "2100CMLC")
            {

                if (campo.DoseRate != 240)
                {

                    {
                        texto += "\n" + campo.Id + ": el DoseRate no es el indicado";
                    }
                }
            }

            else if (campo.EnergyModeDisplayName == "6X-SRS")
            {
                if (campo.DoseRate != 1000)
                {
                    texto += "\n" + campo.Id + ": el DoseRate no es el indicado";
                }
            }
            else if (campo.MLCPlanType.Equals(MLCPlanType.VMAT))
            {
                if (campo.DoseRate != 600)
                {
                    texto += "\n" + campo.Id + ": el DoseRate no es el indicado";
                }
            }
            else
            {
                if (campo.DoseRate != 400)
                {
                    texto += "\n" + campo.Id + ": el DoseRate no es el indicado";
                }
            }
            return texto;
        }

        public static string UMporSubField(Beam campo)
        {
            string texto = "";
            if (campo.ControlPoints.Count < 10)
            {
                for (int i = 1; i < campo.ControlPoints.Count; i++)
                {
                    if (Math.Round(campo.ControlPoints[i].MetersetWeight - campo.ControlPoints[i - 1].MetersetWeight, 5) != 0 &&
                        Math.Round(campo.Meterset.Value * (campo.ControlPoints[i].MetersetWeight - campo.ControlPoints[i - 1].MetersetWeight), 0) < 10)

                    {
                        texto += "\n" + campo.Id + ": el campo o uno de sus subcampos tiene menos de 10UM";
                        break;
                    }
                }
            }
            return texto;

        }

        public static string UMminimaParaCuna(Beam campo)
        {
            string texto = "";
            if (campo.Wedges.Count() > 0 && Math.Round(campo.Meterset.Value, 0) < 20)
            {
                texto += "\n" + campo.Id + ": las UM son insuficientes para tener cuña dinámica";
            }
            return texto;

        }

        public static string tamanoXenVMAT(Beam campo)
        {
            string texto = "";
            if (campo.MLCPlanType == MLCPlanType.VMAT && (-campo.ControlPoints.First().JawPositions.X1 + campo.ControlPoints.First().JawPositions.X2) > 180)
            {
                texto += "\n" + campo.Id + ": X es mayor a 18cm";
            }
            return texto;
        }

        public static string isoEnVMAT(Beam campo, PlanSetup planCorrespondiente)
        {
            bool origen = planCorrespondiente.StructureSet.Image.UserOrigin.Equals(new VVector(0, 0, 0));
            string texto = "";
            if (!origen && campo.MLCPlanType == MLCPlanType.VMAT && (Math.Abs(campo.IsocenterPosition.x - planCorrespondiente.StructureSet.Image.UserOrigin.x) >= 30.5))
            {
                texto += "\n" + campo.Id + ": el iso está desplazado más de 3cm lateralmente respecto de la referencia";
            }
            return texto;
        }

        public static string tamanoCampoMinimo(Beam campo)
        {
            string texto = "";
            if (campo.EnergyModeDisplayName != "6X-SRS")
            {
                if ((-campo.ControlPoints.First().JawPositions.X1 + campo.ControlPoints.First().JawPositions.X2) < 30 || (-campo.ControlPoints.First().JawPositions.Y1 + campo.ControlPoints.First().JawPositions.Y2) < 30)
                {
                    texto += "\n" + campo.Id + ": el campo es menor a 3cm";
                }
            }
            return texto;
        }

        #region chequeos nuevos

        public static string planNoAprobado(PlanSetup plan)
        {
            string texto = "";
            if (plan.Id.Contains("CI"))
            {
                foreach (PlanSetup planAp in plan.Course.PlanSetups)
                {
                    if (planAp.ApprovalStatus == PlanSetupApprovalStatus.PlanningApproved)
                    {
                        return texto;
                    }
                }
                texto += "\nEn el curso no hay ningún plan aprobado";
                return texto;

            }
            else if (plan.ApprovalStatus != PlanSetupApprovalStatus.PlanningApproved && plan.ApprovalStatus != PlanSetupApprovalStatus.TreatmentApproved)
            {
                texto += "\n" + plan.Id + ": el plan no está aprobado";
            }
            return texto;
        }


        public static string planesEnDiferenteEquipo(PlanSum planSum)
        {
            string texto = "";
            string IdEquipo = planSum.PlanSetups.First().Beams.First().TreatmentUnit.Id;
            foreach (PlanSetup plan in planSum.PlanSetups)
            {
                foreach (Beam campo in plan.Beams)
                {
                    if (!campo.TreatmentUnit.Id.Equals(IdEquipo))
                    {
                        texto += "\nEl plan suma contiene campos en diferentes equipos de tratamiento";
                        return texto;
                    }
                }
            }
            return texto;
        }

        public static string campoConCunaFisica(Beam campo)
        {
            string texto = "";
            if (campo.Wedges.Count() > 0)
            {
                foreach (Wedge cuna in campo.Wedges)
                {
                    if (!cuna.Id.Contains("EDW"))
                    {
                        texto += "\n" + campo.Id + " contiene una cuña física";
                    }
                }
            }
            return texto;
        }

        public static string dynamicMLC(Beam campo)
        {
            if (campo.ControlPoints.Count > 2)
            {
                float[] valores = new float[campo.ControlPoints.Count()];
                for (int i = 0; i < 60; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        for (int cp = 0; cp < campo.ControlPoints.Count(); cp++)
                        {
                            valores[cp] = Math.Abs(campo.ControlPoints[cp].LeafPositions[j, i]);
                        }
                        var max = valores.Max();
                        var min = valores.Min();
                        if (max - min >= 1)
                        {
                            return "";
                        }
                    }
                }
                return "\n" + campo.Id + " el movimiento en todas las láminas es menor a 1mm";
            }
            return "";
        }
        #endregion




        public static string chequeosPorCampo(PlanSetup plan)
        {
            string texto = "";
            foreach (Beam campo in plan.Beams)
            {
                if (!campo.IsSetupField)
                {
                    texto += UMporGrado(campo);
                    texto += doseRate(campo);
                    texto += UMporSubField(campo);
                    texto += UMminimaParaCuna(campo);
                    texto += tamanoXenVMAT(campo);
                    texto += isoEnVMAT(campo, plan);
                    texto += tamanoCampoMinimo(campo);
                    texto += campoConCunaFisica(campo);
                    texto += dynamicMLC(campo);
                }
            }
            return texto;
        }

        public static string chequeos(PlanningItem plan, bool esPlanSuma)
        {
            string texto = "";
            if (!esPlanSuma)
            {
                texto += camilla((PlanSetup)plan);
                texto += origen((PlanSetup)plan);
                texto += isoCercaDeOrigen((PlanSetup)plan);
                texto += referencePointTieneLocalizacion((PlanSetup)plan);
                texto += merge((PlanSetup)plan);
                texto += chequeosPorCampo((PlanSetup)plan);
                texto += comparaIsosEnUnPlan((PlanSetup)plan);
                texto += estructuraNombreCursoCorrecta((PlanSetup)plan);
                texto += tomografiaVieja((PlanSetup)plan);
                texto += hayTratamientoAprobado((PlanSetup)plan);
            }
            else
            {
                //chequeos que hay que hacer para todos los planes
                foreach (PlanSetup etapa in ((PlanSum)plan).PlanSetups)
                {
                    string aux = "";
                    aux += isoCercaDeOrigen(etapa);
                    aux += referencePointTieneLocalizacion(etapa);
                    aux += merge(etapa);
                    aux += chequeosPorCampo(etapa);
                    aux += comparaIsosEnUnPlan(etapa);
                    if (aux != "")
                    {
                        texto += "\n" + etapa.Id + ": " + aux + "\n";
                    }
                }
                //chequeos que hay que hacer una vez sola
                PlanSetup primerPlan = ((PlanSum)plan).PlanSetups.First();
                texto += camilla(primerPlan);
                texto += origen(primerPlan);
                texto += estructuraNombreCursoCorrecta(primerPlan);
                texto += tomografiaVieja(primerPlan);
                texto += hayTratamientoAprobado(primerPlan);
                
				//chequeos en el plan Suma
                texto += comparaIsosPlanSuma((PlanSum)plan);
                texto += planesEnDiferenteEquipo((PlanSum)plan);
            }

            return texto;

        }

        #region metodos auxiliares
        public static bool coincidenciaCamillas(string camilla, string equipo, PlanSetup plan)
        {
            if (camilla.Contains("Unipanel") && equipo == "PBA_6EX_730")
            {
                return true;
            }
            else if (camilla.Contains("Unipanel") && equipo == "6EX Viamonte")
            {
                return true;
            }
            else if (camilla.Contains("IGRT") && equipo == "Equipo1")
            {
                return true;
            }
            else if (camilla.Contains("IGRT") && equipo == "2100CMLC")
            {
                return true;
            }
            else if (camilla.Contains("BrainLAB") && equipo == "D-2300CD")
            {
                if (esRadioCirugia(plan))
                {
                    if (camilla.Contains("H&N Extension"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (camilla.Contains("H&N Extension"))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }

            }
            else
            {
                return false;
            }

        }

        public static bool camposFusionables(Beam campo1, Beam campo2)
        {
            if (campo1.ControlPoints.First().GantryAngle != campo2.ControlPoints.First().GantryAngle)
            {
                return false;
            }
            else if (campo1.ControlPoints.First().CollimatorAngle != campo2.ControlPoints.First().CollimatorAngle)
            {
                return false;
            }
            else if (campo1.ControlPoints.First().PatientSupportAngle != campo2.ControlPoints.First().PatientSupportAngle)
            {
                return false;
            }
            else if (campo1.ControlPoints.First().JawPositions.X1 != campo2.ControlPoints.First().JawPositions.X1)
            {
                return false;
            }
            else if (campo1.ControlPoints.First().JawPositions.X2 != campo2.ControlPoints.First().JawPositions.X2)
            {
                return false;
            }
            else if (campo1.ControlPoints.First().JawPositions.Y1 != campo2.ControlPoints.First().JawPositions.Y1)
            {
                return false;
            }
            else if (campo1.ControlPoints.First().JawPositions.Y2 != campo2.ControlPoints.First().JawPositions.Y2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static double distanciaMaxima(VVector punto1, VVector punto2)
        {
            double difX = Math.Abs(punto1.x - punto2.x);
            double difY = Math.Abs(punto1.y - punto2.y);
            double difZ = Math.Abs(punto1.z - punto2.z);
            return Math.Max(difX, Math.Max(difY, difZ));
        }

        public static bool isosDiferentes(PlanSetup plan1, PlanSetup plan2)
        {
            if (distanciaMaxima(plan1.Beams.First().IsocenterPosition, plan2.Beams.First().IsocenterPosition) > 0.01 &&
                distanciaMaxima(plan1.Beams.First().IsocenterPosition, plan2.Beams.First().IsocenterPosition) < 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

		public static bool esRadioCirugia(PlanSetup plan)
        {
            if (plan.Beams.First().TreatmentUnit.Id == "D-2300CD" && plan.StructureSet.Image.UserOrigin.Equals(new VVector(0, 0, 0))) //es en el equipo4
            {
                if (plan.Beams.First().EnergyModeDisplayName == "6X-SRS") //haz SRS
                {
                    return true;
                }
                else if (plan.Beams.First().MLCPlanType == MLCPlanType.VMAT && plan.UniqueFractionation.PrescribedDosePerFraction.Dose > 390) //es VMAt y el origen es dicom y la dosis prescripta es >390cGy
                {
                    if (plan.StructureSet.Structures.Any(s => s.Id.Contains("Brain")) || plan.StructureSet.Structures.Any(s => s.Id.Contains("Cerebro"))) //hay alguna estructura que contiene Brain o cerebro
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        #endregion
    }


}
/*
 
- UM mínimas para cuñas dinámicas (habría que ver bien cuáles son los constraints, ver si está en la documentación o probar)

- En VMAT el x del Iso está a más de 3cm LISTO
- RefTiene Ubicacion física LISTO
- Limite de referencePoint vs Prescripcion
- Muchos isos en un plan LISTO
- VMAT x>18cm LISTO


    BEAMS:
    - Límite UM/deg para arcos LISTO
    - El dose rate es el correcto para ese equipo y técnica? LISTO

    - El iso de plan1 y boost son diferentes? LISTO
    - ¿Tiene camilla? ¿Es la correcta? LISTO
- Puso el origen en referencia? (creo que se puede hacer, tengo que probarlo) LISTO
- El iso está muy cerca de la ref? LISTO
- ¿Falta hacer merge de campos? LISTO

    FALTA (06-09-19)
    - orden de campo (Rafa)
    - El plan está aprobado (para chequeo de armado)
    - Prescripción y restricción del reference point

    */
