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
    public class RestriccionDosisMedia: IRestriccion
    {
        public Condicion condicion { get; set; }
        public Estructura estructura { get; set; }
        public string unidadValor { get; set; }
        public string unidadCorrespondiente { get; set; }
        public bool esMenorQue { get; set; }
        public double valorMedido { get; set; }
        public double valorEsperado { get; set; }
        public double valorTolerado { get; set; }
        public double valorCorrespondiente { get; set; }
        public double prescripcionEstructura { get; set; }
        public string etiquetaInicio { get; set; }
        public string etiqueta { get; set; }
        public string nota { get; set; }

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
            double _valorEsperado, double _valorTolerado, double _valorCorrespondiente,string _nota, Condicion _condicion = null)
        {
            RestriccionDosisMedia restriccion = new RestriccionDosisMedia()
            {
                estructura = _estructura,
                unidadValor = _unidadValor,
                esMenorQue = _esMenorQue,
                valorEsperado = _valorEsperado,
                valorTolerado = _valorTolerado,
                nota = _nota,
                condicion = _condicion,
            };
            restriccion.crearEtiquetaInicio();
            restriccion.crearEtiqueta();
            return restriccion;
        }

        public void crearEtiquetaInicio()
        {
            etiquetaInicio = estructura.nombre + ": Dmedia";
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
            if (condicion != null)
            {
                etiqueta += " (" + condicion.id + ")";
            }

        }



        public void analizarPlanEstructura(PlanningItem plan, Structure estructura)
        {
            DoseValuePresentation doseValuePresentation = DoseValuePresentation.Absolute;
            //plan.GetDVHCumulativeData(estructura, doseValuePresentation, VolumePresentation.Relative, 0.1).SamplingCoverage
            valorMedido = Math.Round(plan.GetDVHCumulativeData(estructura, doseValuePresentation, VolumePresentation.Relative, 0.01).MeanDose.Dose / 100, 1);
            if (unidadValor == "%")
            {
                valorMedido = Math.Round(valorMedido / prescripcionEstructura * 100,1); //extraigo en Gy y paso a porcentaje
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
        ComboBox CB_UnidadesCorresp, ComboBox CB_EsMenorQue, TextBox TB_ValorEsperado, TextBox TB_ValorTolerado, ComboBox CB_UnidadesValor, TextBox TB_nota)
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
            TB_nota.Text = nota;
        }

        public void editarGrupo(List<IRestriccion> lista, DataGridView tabla, ComboBox CB_Estructura, TextBox TB_nombresAlt, ComboBox CB_TipoRestr, TextBox TB_valorCorrespondiente,
ComboBox CB_UnidadesCorresp, ComboBox CB_EsMenorQue, ComboBox CB_UnidadesValor, TextBox TB_nota,ListBox LB_TipoCondicion, ListBox LB_ListaCondiciones)
        {
            CB_Estructura.Text = estructura.nombre;
            for (int i = 1; i < estructura.nombresPosibles.Count; i++)
            {
                if (i > 1)
                {
                    TB_nombresAlt.Text += "\r\n";
                }
                TB_nombresAlt.Text += estructura.nombresPosibles[i];
            }
            CB_TipoRestr.SelectedIndex = 2; //cambiar en cada restriccion
            TB_valorCorrespondiente.Text = Metodos.validarYConvertirAString(valorCorrespondiente);
            if (esMenorQue)
            {
                CB_EsMenorQue.SelectedIndex = 0;
            }
            else
            {
                CB_EsMenorQue.SelectedIndex = 1;
            }
            foreach (IRestriccion restriccion in lista)
            {

                int indice = tabla.Columns.Add(restriccion.condicion.id, restriccion.condicion.id);
                tabla.Rows[0].Cells[indice].Value = Metodos.validarYConvertirAString(restriccion.valorEsperado);
                tabla.Rows[1].Cells[indice].Value = Metodos.validarYConvertirAString(restriccion.valorTolerado);
            }
            CB_UnidadesValor.SelectedItem = unidadValor;
            CB_UnidadesCorresp.SelectedItem = unidadCorrespondiente;
            TB_nota.Text = nota;
            LB_TipoCondicion.SelectedItem = condicion.tipo;
        }

        public string metrica()
        {
            return etiquetaInicio.Split(':')[1];
        }

        public bool cumpleCondicion(PlanningItem plan)
        {
            if (condicion == null)
            {
                return true;
            }
            else
            {
                return condicion.CumpleCondicion(plan);
            }
        }
    }
}
