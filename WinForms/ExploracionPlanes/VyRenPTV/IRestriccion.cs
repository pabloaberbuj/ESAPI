﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace ExploracionPlanes
{
    public interface IRestriccion
    {
        Estructura estructura { get; set; }
        string etiqueta { get; set; }
        string etiquetaInicio { get; set; }
        bool esMenorQue { get; set; }
        double valorMedido { get; set; }
        double valorEsperado { get; set; }
        double valorTolerado { get; set; }
        double valorCorrespondiente { get; set; }
        double prescripcionEstructura { get; set; }
        string unidadValor { get; set; }
        string unidadCorrespondiente { get; set; }
        bool dosisEstaEnPorcentaje();
        void agregarALista(BindingList<IRestriccion> lista);
        void crearEtiquetaInicio();
        void crearEtiqueta();
        int cumple();
        void analizarPlanEstructura(PlanSetup plan, Structure estructura);
        IRestriccion crear(Estructura _estructura, string _unidadValor, string _unidadCorrespondiente, bool _esMenorQue,
            double _valorEsperado, double _valorTolerado, double _valorCorrespondiente);
        bool chequearSamplingCoverage(PlanSetup plan, Structure estructura);

        void editar(ComboBox CB_Estructura, TextBox TB_nombresAlt, ComboBox CB_TipoRestr, TextBox TB_valorCorrespondiente,
            ComboBox CB_UnidadesCorresp, ComboBox CB_EsMenorQue, TextBox TB_ValorEsperado, TextBox TB_ValorTolerado, ComboBox CB_UnidadesValor);

    }
}
