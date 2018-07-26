using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Text;
using System.Threading.Tasks;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;


namespace VMS.TPS
{
    class Script
    {

        public Script()
        {

        }
        public void Execute(ScriptContext context)
        {
            List<string> texto = new List<string>();
            List<double[,]> pc = new List<double[,]>();
            try
            {
                context.PlanSetup.DoseValuePresentation = DoseValuePresentation.Absolute;
                texto.Add(context.Patient.Name);
                texto.Add(context.PlanSetup.Id);
                texto.Add("Dosis plan en ISO: " + dosisPlanEnIso(context.PlanSetup).ToString());
                texto.Add("suma pesos: " + sumaPesosPlan(context.PlanSetup));
                foreach (Beam campo in context.PlanSetup.Beams)
                {
                    texto.Add(campo.Id);
                    texto.Add("Dosis campo en ISO:" + dosisCampoEnIso(context.PlanSetup, campo).ToString());
                    texto.Add("factor de campo: " + factorCampo(campo));
                    texto.Add("UM Eclipse: " + Math.Round(campo.Meterset.Value, 0).ToString() + campo.Meterset.Unit.ToString());
                    texto.Add("UM Calculadas: " + um(context.PlanSetup, campo));
                    texto.Add("Diferencia: " + difUM(context.PlanSetup, campo));
                    pc.Add(puntoDeControl(campo));
                }
                File.WriteAllLines("salida.txt", texto);
                using (StreamWriter sr = new StreamWriter("salida2.txt"))
                {
                    foreach (var item in pc)
                    {
                        sr.WriteLine(item);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public static double ladoCampoEquivalente(Beam campo) //formula
        {
            double tamX = Math.Abs(campo.ControlPoints[0].JawPositions.X1) / 10 + Math.Abs(campo.ControlPoints[0].JawPositions.X2) / 10;

            double tamY = Math.Abs(campo.ControlPoints[0].JawPositions.Y1) / 10 + Math.Abs(campo.ControlPoints[0].JawPositions.Y2) / 10;

            return Math.Round(2 * (tamX * tamY) / (tamX + tamY), 0); //en cm para interpolar

        }


        public static double factorCuña(Beam campo)
        {
            double factorCuña = 1;
            if (campo.Wedges.Count() == 0)
            {
            }
            else
            {
                foreach (Wedge cuña in campo.Wedges)
                {
                    if (cuña.WedgeAngle == 15)
                    {
                        factorCuña *= 0.7078;
                    }
                    else if (cuña.WedgeAngle == 30)
                    {
                        factorCuña *= 0.545;
                    }
                    else if (cuña.WedgeAngle == 45)
                    {
                        factorCuña *= 0.4942;
                    }
                    else if (cuña.WedgeAngle == 60)
                    {
                        factorCuña *= 0.4080;
                    }
                    else
                    {
                        MessageBox.Show("No se reconoce el angulo" + cuña.WedgeAngle.ToString());
                    }
                }
            }
            return factorCuña;
        }
        public static double tpr(Beam campo)
        {
            double profundidad = Math.Round(100 - campo.SSD / 10, 0);
            double tamX = Math.Abs(campo.ControlPoints[0].JawPositions.X1) + Math.Abs(campo.ControlPoints[0].JawPositions.X2);
            double tamY = Math.Abs(campo.ControlPoints[0].JawPositions.Y1) + Math.Abs(campo.ControlPoints[0].JawPositions.Y2);
            double ladoEquivalente = Math.Round(ladoCampoEquivalente(campo), 0);
            string[] fid = cargar(tabla_TPRs);
            double[] tamañosTabla = extraerDoubleArray(fid, 0);
            double[] profundidadesTabla = extraerDoubleArray(fid, 1);
            double[,] tablaTPRs = extraerMatriz(fid, 3, 62, tamañosTabla.Count(), profundidadesTabla.Count());
            return buscatabla(ladoEquivalente, profundidad, tamañosTabla, profundidadesTabla, tablaTPRs);
        }

        public static double rendimientoIso()
        {
            return 0.922;
        }
        public static double factorCampo(Beam campo)
        {
            double ladoEquivalente = ladoCampoEquivalente(campo);
            string[] fid = cargar(tabla_factoresCampos);
            double[] etiquetasCampos = extraerDoubleArray(fid, 0);
            double[] factores = extraerDoubleArray(fid, 1);
            return factores[Array.IndexOf(etiquetasCampos, ladoEquivalente)];


        }
        public static double factorConformacion(Beam campo)
        {
            return 1;
        }
        public static double dosisCampoEnRef(Beam campo)
        {
            return campo.FieldReferencePoints.ElementAt(0).FieldDose.Dose;
        }

        public static double dosisPlanEnIso(PlanSetup plan)
        {
            VVector isocentro = plan.Beams.ElementAt(0).IsocenterPosition;
            return plan.Dose.GetDoseToPoint(isocentro).Dose;
        }

        public static double dosisCampoEnIso(PlanSetup plan, Beam campo)
        {
            VVector isocentro = campo.IsocenterPosition;
            return plan.Dose.GetDoseToPoint(isocentro).Dose * campo.WeightFactor / sumaPesosPlan(plan);
        }

        public static double um(PlanSetup plan, Beam campo)
        {
            int fracciones = Convert.ToInt32(plan.UniqueFractionation.NumberOfFractions);
            double tasaDeDosis = rendimientoIso() * tpr(campo) / 100 * factorCampo(campo) * factorConformacion(campo) * factorCuña(campo);
            return Math.Round(dosisCampoEnIso(plan, campo) / tasaDeDosis / fracciones, 0);
        }

        public static double difUM(PlanSetup plan, Beam campo)
        {
            double UMplan = Math.Round(campo.Meterset.Value, 0);
            double UMcalc = um(plan, campo);
            return (UMcalc - UMplan) / UMplan * 100;
        }

        public static double sumaPesosPlan(PlanSetup plan)
        {
            double pesos = 0;
            foreach (Beam campo in plan.Beams)
            {
                pesos += campo.WeightFactor;
            }
            return pesos;
        }

        public static double[,] puntoDeControl(Beam campo)
        {
            return campo.ControlPoints[0].LeafPositions;
        }


        #region Metodos

        public static string tabla_TPRs = "tabla_TPRs.txt";
        //public static string tabla_camposEquivalentes = @"..\..\tabla_camposEquivalentes.txt";
        public static string tabla_factoresCampos = "tabla_factoresCampos.txt";
        //public static string tabla_factoresCuña = @"..\..\tabla_factoresCuña.txt";
        public static string[] cargar(string archivo)
        {
            return File.ReadAllLines(archivo);
        }

        public static string[] extraerStringArray(string[] fid, int linea, char sepHeader = '=', char separador = '\t')
        {
            string aux = fid[linea]; string aux2 = aux.Split(sepHeader)[1];
            return aux2.Split(separador);
        }

        public static double[] extraerDoubleArray(string[] fid, int linea, char sepHeader = '=', char separador = '\t')
        {
            return extraerStringArray(fid, linea, sepHeader, separador).Select(s => double.Parse(s, CultureInfo.InvariantCulture)).ToArray();
        }

        public static double[,] extraerMatriz(string[] fid, int lineaI, int lineaF, int Tam1, int Tam2)
        {
            double[,] M = new double[Tam1, Tam2];
            for (int i = 0; i < Tam2; i++)
            {
                string[] stringLinea = fid[lineaI + i].Split('\t');
                double[] aux1 = stringLinea.Select(s => double.Parse(s, CultureInfo.InvariantCulture)).ToArray();
                for (int j = 0; j < Tam1; j++)
                {
                    M[j, i] = aux1[j];
                }
            }
            return M;
        }

        public static double buscatabla(double X, double Y, double[] etiquetasX, double[] etiquetasY, double[,] valores)
        {
            int iX = Array.IndexOf(etiquetasX, X);
            int iY = Array.IndexOf(etiquetasY, Y);
            double XY = valores[iX, iY]; //ver que es así y no al revés
            return XY;
        }

        #endregion
    }


}
