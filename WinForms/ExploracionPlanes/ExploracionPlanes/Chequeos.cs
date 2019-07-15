using System;
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
                    if (!coincidenciaCamillas(estructura.Name, plan.Beams.First().TreatmentUnit.Id))
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
                    foreach (Beam campo2 in plan.Beams)
                    {
                        if (campo1.Id != campo2.Id && camposFusionables(campo1, campo2))
                        {
                            fusionables = true;
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
                    if (isosDiferentes(etapaA,etapaB))
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
            foreach(Beam campo in plan.Beams)
            {
                if (distanciaMaxima(plan.Beams.First().IsocenterPosition, campo.IsocenterPosition) > 0.001)
                {
                    texto += "\nEl plan tiene más de un isocentro";
                    break;
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
                    texto += campo.Id + ": UM/longitud de arco es mayor a 20";
                }
                else if ((campo.ArcLength * campo.DoseRate) / (campo.Meterset.Value * 60) >= 4.2)
                {
                    texto += campo.Id + ": pocas UMs para esa longitud de arco y Dose Rate";
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

        public static string tamanoXenVMAT(Beam campo)
        {
            string texto = "";
            if (campo.MLCPlanType == MLCPlanType.VMAT && (-campo.ControlPoints.First().JawPositions.X1+ campo.ControlPoints.First().JawPositions.X2)>180)
            {
                texto+= "\n" + campo.Id + ": X es mayor a 18cm";
            }
            return texto;
        }

        public static string isoEnVMAT(Beam campo, PlanSetup planCorrespondiente)
        {
            string texto = "";
            if (campo.MLCPlanType == MLCPlanType.VMAT && (campo.IsocenterPosition.x-planCorrespondiente.StructureSet.Image.UserOrigin.x>30))
            {
                texto += "\n" + campo.Id + ": el iso está desplazado más de 3cm lateralmente respecto de la referencia";
            }
            return texto;
        }

        public static string chequeosPorCampo(PlanSetup plan)
        {
            string texto = "";
            foreach (Beam campo in plan.Beams)
            {
                if (!campo.IsSetupField)
                {
                    texto += UMporGrado(campo);
                    texto += doseRate(campo);
                    texto += tamanoXenVMAT(campo);
                    texto += isoEnVMAT(campo, plan);
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
            }
            else
            {
                texto += camilla(((PlanSum)plan).PlanSetups.First());
                texto += origen(((PlanSum)plan).PlanSetups.First());
                foreach (PlanSetup etapa in ((PlanSum)plan).PlanSetups)
                {
                    string aux = "";
                    aux += isoCercaDeOrigen(etapa);
                    aux += referencePointTieneLocalizacion(etapa);
                    aux += merge(etapa);
                    aux += chequeosPorCampo(etapa);
                    aux += comparaIsosEnUnPlan(etapa);
                    if (aux!="")
                    {
                        texto += "\n" + etapa.Id + ": " + aux + "\n";
                    }
                }
                texto += comparaIsosPlanSuma((PlanSum)plan);
            }

            return texto;

        }

        #region metodos auxiliares
        public static bool coincidenciaCamillas(string camilla, string equipo)
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
                return true;
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
            if (distanciaMaxima(plan1.Beams.First().IsocenterPosition,plan2.Beams.First().IsocenterPosition)>0.001 &&
                distanciaMaxima(plan1.Beams.First().IsocenterPosition, plan2.Beams.First().IsocenterPosition)<20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        # endregion
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

    public static string llevaCuna(PlanSetup plan)
        {
            string texto = "";
            foreach (Beam campo in plan.Beams)
            {
                if (campo.Wedges.Count()>0)
                {
                    texto += "\n" + campo.Id + ": " + campo.Wedges.First().Id;
                }
                else
                {
                    texto += "\n" + campo.Id + ": no lleva cuña";
                }
            }
            return texto;
        }

        public static string longitudArco(PlanSetup plan)
        {
            string texto = "";
            foreach (Beam campo in plan.Beams)
            {
                texto += "\n" + campo.Id + ": " + campo.ArcLength.ToString();
            }
            return texto;
        }
 */
