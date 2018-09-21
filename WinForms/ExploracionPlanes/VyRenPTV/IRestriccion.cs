using System;
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
        double valorMedido { get; set; }
        double valorEsperado { get; set; }
        double valorTolerado { get; set; }
        double valorCorrespondiente { get; set; }
        void agregarALista(BindingList<IRestriccion> lista);
        void crearEtiqueta();
        int cumple();
        void analizarPlanEstructura(PlanSetup plan, Structure estructura);
        //int analizarPlan(PlanSetup plan);
        //IRestriccion crear();
        /*/void editar(IRestriccion restriccion, string Estructura, List<string> nombresAlt, int tipoRest,
            double valorCorresp, bool esMenor, double valorEsperado, double valorTolerado,
            string unidadCorresp, string unidadEsperado);*/
    }
}
