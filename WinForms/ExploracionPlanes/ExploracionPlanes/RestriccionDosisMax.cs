﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace ExploracionPlanes
{
    public class RestriccionDosisMax : IRestriccion
    {
        public Estructura estructura { get; set; }
        public string unidadValor { get; set; }
        public string unidadCorrespondiente { get; set; }
        public bool esMenorQue { get; set; }
        public double valorMedido { get; set; }
        public double valorEsperado { get; set; }
        public double valorTolerado { get; set; }
        public double valorCorrespondiente { get; set; }
        public static double volumenDosisMaxima = Configuracion.volDosisMaxima();
        public double prescripcionEstructura { get; set; }
        public string etiquetaInicio { get; set; }
        public string etiqueta { get; set; }

        public int cumple()
        {
            if (esMenorQue)
            {
                if (valorMedido <= valorEsperado)
                {
                    return 0;
                }
                else if (!Double.IsNaN(valorTolerado) && valorMedido <= valorTolerado)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                if (valorMedido >= valorEsperado)
                {
                    return 0;
                }
                else if (!Double.IsNaN(valorTolerado) && valorMedido >= valorTolerado)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        

        public IRestriccion crear(Estructura _estructura, string _unidadValor, string _unidadCorrespondiente, bool _esMenorQue,
    double _valorEsperado, double _valorTolerable, double _valorCorrespondiente)
        {
            RestriccionDosisMax restriccion = new RestriccionDosisMax()
            {
                estructura = _estructura,
                unidadValor = _unidadValor,
                esMenorQue = _esMenorQue,
                valorEsperado = _valorEsperado,
                valorTolerado = _valorTolerable,
            };
            restriccion.crearEtiquetaInicio();
            restriccion.crearEtiqueta();
            return restriccion;
        }

        public void crearEtiquetaInicio()
        {
            etiquetaInicio = estructura.nombre + ": Dmax";
        }
        public void crearEtiqueta()
        {
            etiqueta = etiquetaInicio;
            if (!Double.IsNaN(valorEsperado))
            {
                if (esMenorQue)
                {
                    etiqueta += " < ";
                }
                else
                {
                    etiqueta += " > ";
                }
                etiqueta += valorEsperado.ToString();
                if (!Double.IsNaN(valorTolerado))
                {
                    etiqueta += " (" + valorTolerado.ToString() + ") ";
                }
                etiqueta += unidadValor;
            }

        }



        

        public void analizarPlanEstructura(PlanningItem plan, Structure estructura) //Ver cuál sirve
        {
            
            DoseValuePresentation doseValuePresentation = DoseValuePresentation.Absolute;
            if (plan.GetType() == typeof(PlanSetup))
            {
                valorMedido = Math.Round(((PlanSetup)plan).GetDoseAtVolume(estructura, volumenDosisMaxima, VolumePresentation.AbsoluteCm3, doseValuePresentation).Dose / 100, 2);
            }
            else
            {
                DVHPoint[] curveData = ((PlanSum)plan).GetDVHCumulativeData(estructura, doseValuePresentation, VolumePresentation.AbsoluteCm3, 0.01).CurveData;
                valorMedido = Math.Round(DVHDataExtensions_ESAPIX.GetDoseAtVolume(curveData, volumenDosisMaxima).Dose / 100, 2);
            }
            if (unidadValor == "%")
            {
                valorMedido = Math.Round(valorMedido / prescripcionEstructura * 100,2); //extraigo en Gy y paso a porcentaje
            }
        }

        public void analizarPlanEstructura(PlanningItem plan, Structure estructura, double volumenDosisMaximaOVR) //Ver cuál sirve
        {

            DoseValuePresentation doseValuePresentation = DoseValuePresentation.Absolute;
            if (plan.GetType() == typeof(PlanSetup))
            {
                valorMedido = Math.Round(((PlanSetup)plan).GetDoseAtVolume(estructura, volumenDosisMaximaOVR, VolumePresentation.AbsoluteCm3, doseValuePresentation).Dose / 100, 2);
            }
            else
            {
                DVHPoint[] curveData = ((PlanSum)plan).GetDVHCumulativeData(estructura, doseValuePresentation, VolumePresentation.AbsoluteCm3, 0.01).CurveData;
                valorMedido = Math.Round(DVHDataExtensions_ESAPIX.GetDoseAtVolume(curveData, volumenDosisMaximaOVR).Dose / 100, 2);
            }
            if (unidadValor == "%")
            {
                valorMedido = Math.Round(valorMedido / prescripcionEstructura * 100, 2); //extraigo en Gy y paso a porcentaje
            }
        }

        public bool chequearSamplingCoverage(PlanningItem plan, Structure estructura)
        {
            if (Double.IsNaN(valorMedido))
            {
                if (plan.GetDVHCumulativeData(estructura, DoseValuePresentation.Absolute, VolumePresentation.Relative, 0.01).SamplingCoverage < 0.9)
                {
                    return true;
                }
            }
            return false;
        }

        public void agregarALista(BindingList<IRestriccion> lista)
        {
            lista.Add(this);
        }

        public bool dosisEstaEnPorcentaje()
        {
            if (unidadValor == "%")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void editar(ComboBox CB_Estructura, TextBox TB_nombresAlt, ComboBox CB_TipoRestr, TextBox TB_valorCorrespondiente,
        ComboBox CB_UnidadesCorresp, ComboBox CB_EsMenorQue, TextBox TB_ValorEsperado, TextBox TB_ValorTolerado, ComboBox CB_UnidadesValor)
        {
            CB_Estructura.Text = estructura.nombre;
            for (int i = 1; i < estructura.nombresPosibles.Count; i++)
            {
                TB_nombresAlt.Text += "\r\n" + estructura.nombresPosibles[i];
            }
            CB_TipoRestr.SelectedIndex = 2; //cambiar en cada restriccion
            //TB_valorCorrespondiente.Text = Metodos.validarYConvertirAString(valorCorrespondiente);
            if (esMenorQue)
            {
                CB_EsMenorQue.SelectedIndex = 0;
            }
            else
            {
                CB_EsMenorQue.SelectedIndex = 1;
            }
            TB_ValorEsperado.Text = Metodos.validarYConvertirAString(valorEsperado);
            TB_ValorTolerado.Text = Metodos.validarYConvertirAString(valorTolerado);
            CB_UnidadesValor.SelectedItem = unidadValor;
            CB_UnidadesCorresp.SelectedItem = unidadCorrespondiente;
        }

    }

}

