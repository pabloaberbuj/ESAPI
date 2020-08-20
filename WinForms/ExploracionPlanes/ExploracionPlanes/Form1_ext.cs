using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ExploracionPlanes
{
    public partial class Form1_ext : Form
    {

        BindingList<IRestriccion> listaRestricciones = new BindingList<IRestriccion>();
        List<IRestriccion> listaRestriccionesAsociadas = new List<IRestriccion>();
        BindingList<Condicion> listaCondicionesNumFracc = new BindingList<Condicion>();
        BindingList<Condicion> listaCondicionesVolPTV = new BindingList<Condicion>();
        bool editaRestriccion = false;
        bool editaPlantilla = false;
        Main main = new Main();



        public Form1_ext(Main _main, bool _editaPlantilla)
        {

            InitializeComponent();
            GB_NuevaRestriccion.Enabled = false;

            CB_MenorOMayor.SelectedIndex = 0;
            CB_TipoRestriccion.SelectedIndex = 0;
            LB_listaRestricciones.DataSource = listaRestricciones;
            LB_listaRestricciones.DisplayMember = "etiqueta";
            editaPlantilla = _editaPlantilla;
            main = _main;
            if (_editaPlantilla)
            {
                main.plantillaSeleccionada().editar(TB_NombrePlantilla, CHB_esParaExtraccion, listaRestricciones, TB_NotaPlantilla, listaCondicionesNumFracc, listaCondicionesVolPTV);
            }
            cargarListBoxTipo();
            cargarComboBoxOperador();
            CB_cond1.SelectedIndex = 0;
        }

        private void cargarListBoxTipo()
        {
            LB_Condiciones.Items.Add(Tipo.SinCondicion);
            LB_Condiciones.Items.Add(Tipo.NumFx);
            LB_Condiciones.Items.Add(Tipo.VolPTV);
            LB_Condiciones.SelectedIndex = 0;
        }

        private void cargarComboBoxOperador()
        {
            CB_cond1.Items.Add(Operador.igual_a);
            CB_cond1.Items.Add(Operador.menor_a);
            CB_cond1.Items.Add(Operador.entre);
            CB_cond1.Items.Add(Operador.mayor_a);
            CB_cond1.SelectedIndex = 0;
        }

        private Estructura estructura()
        {
            return Estructura.crear(CB_Estructura.Text, estructuraNombresAlt());
        }

        private string notaRestriccion()
        {
            return TB_NotaRestriccion.Text;
        }

        private List<string> estructuraNombresAlt()
        {
            if (!string.IsNullOrEmpty(TB_EstructuraNombresAlt.Text))
            {
                return Regex.Split(TB_EstructuraNombresAlt.Text, "\r\n").ToList<string>();
            }
            else
            {
                return new List<string>();
            }
        }
        private double valorCorrespondiente()
        {
            if (!string.IsNullOrEmpty(TB_CorrespA.Text))
            {
                return Metodos.validarYConvertirADouble(TB_CorrespA.Text);
            }
            else
            {
                return Double.NaN;
            }
        }

        private string nombrePlantilla()
        {
            return TB_NombrePlantilla.Text;
        }

        private bool esParaExtraccion()
        {
            return CHB_esParaExtraccion.Checked;
        }

        private string notaPlantilla()
        {
            return TB_NotaPlantilla.Text;
        }

        private Plantilla plantillaActual()
        {
            return Plantilla.crear(nombrePlantilla(), esParaExtraccion(), listaRestricciones, notaPlantilla());
        }

        private double valorEsperado(int columna)
        {
            if (!String.IsNullOrEmpty((string)DGV_restricciones.Rows[0].Cells[columna].Value))
            {
                return Metodos.validarYConvertirADouble((string)DGV_restricciones.Rows[0].Cells[columna].Value);
            }
            else
            {
                return Double.NaN;
            }
        }

        private double valorTolerado(int columna)
        {
            if (!String.IsNullOrEmpty((string)DGV_restricciones.Rows[1].Cells[columna].Value))
            {
                return Metodos.validarYConvertirADouble((string)DGV_restricciones.Rows[1].Cells[columna].Value);
            }
            else
            {
                return Double.NaN;
            }
        }
        private string unidadValor()
        {
            return CB_ValorEsperadoUnidades.Text;
        }

        private string unidadCorrespondiente()
        {
            return CB_CorrespAUnidades.Text;
        }

        private bool esRestriccionDosis()
        {
            return CB_TipoRestriccion.SelectedIndex == 0;
        }

        private bool esRestriccionDmedia()
        {
            return CB_TipoRestriccion.SelectedIndex == 1;
        }

        private bool esRestriccionDmax()
        {
            return CB_TipoRestriccion.SelectedIndex == 2;
        }

        private bool esRestriccionVolumen()
        {
            return CB_TipoRestriccion.SelectedIndex == 3;
        }


        private bool esRestriccionIndiceConformidad()
        {
            return CB_TipoRestriccion.SelectedIndex == 4;
        }

        private bool esMenorQue()
        {
            return CB_MenorOMayor.SelectedIndex == 0;
        }

        private void cargarUnidadesDosis(ComboBox cb)
        {
            cb.Items.Clear();
            cb.Items.Add("Gy");
            cb.Items.Add("%");
        }

        private void cargarUnidadesVolumen(ComboBox cb)
        {
            cb.Items.Clear();
            cb.Items.Add("%");
            cb.Items.Add("cm3");
        }
        private void BT_AgregarALista_Click(object sender, EventArgs e)
        {
            if (editaRestriccion)
            {
                int ubicacion = LB_listaRestricciones.SelectedIndex;
                //listaRestricciones.Remove((IRestriccion)LB_listaRestricciones.SelectedItem);
                //listaRestricciones.Insert(ubicacion, restriccionesActuales());
                foreach (IRestriccion restriccion in listaRestriccionesAsociadas)
                {
                    listaRestricciones.Remove(restriccion);
                }
                int i = 0;
                foreach (IRestriccion restriccion in restriccionesActuales())
                {
                    listaRestricciones.Insert(ubicacion + i, restriccion);
                    i++;
                }

                editaRestriccion = false;
                LB_listaRestricciones.Enabled = true;
                LB_listaRestricciones.ClearSelected();
                LB_listaRestricciones.SelectedIndex = ubicacion;
            }
            else
            {
                foreach (IRestriccion restriccion in restriccionesActuales())
                {
                    restriccion.agregarALista(listaRestricciones);
                    LB_listaRestricciones.ClearSelected();
                }
            }
            limpiarPrescripcion();
            if (!CB_Estructura.Items.Contains(estructura().nombre))
            {
                CB_Estructura.Items.Add(estructura().nombre);
            }
            fijarEsParaExtraccion();
        }

        private void actualizarPorRestriccion()
        {
            if (esRestriccionDosis())
            {
                L_CorrespA.Text = "correspondiente a \nun volumen de: ";
                L_CorrespA.Visible = true;
                TB_CorrespA.Visible = true;
                CB_CorrespAUnidades.Visible = true;
                cargarUnidadesDosis(CB_ValorEsperadoUnidades);
                cargarUnidadesVolumen(CB_CorrespAUnidades);
                CB_ValorEsperadoUnidades.SelectedIndex = 0;
                CB_CorrespAUnidades.SelectedIndex = 0;
                CB_ValorEsperadoUnidades.Visible = true;
            }
            else if (esRestriccionDmedia() || esRestriccionDmax())
            {
                L_CorrespA.Visible = false;
                TB_CorrespA.Visible = false;
                CB_CorrespAUnidades.Visible = false;
                cargarUnidadesDosis(CB_ValorEsperadoUnidades);
                CB_ValorEsperadoUnidades.SelectedIndex = 0;
                CB_ValorEsperadoUnidades.Visible = true;
            }
            else if (esRestriccionVolumen())
            {
                L_CorrespA.Text = "correspondiente a \nuna dosis de: ";
                L_CorrespA.Visible = true;
                TB_CorrespA.Visible = true;
                CB_CorrespAUnidades.Visible = true;
                cargarUnidadesDosis(CB_CorrespAUnidades);
                cargarUnidadesVolumen(CB_ValorEsperadoUnidades);
                CB_ValorEsperadoUnidades.SelectedIndex = 0;
                CB_CorrespAUnidades.SelectedIndex = 0;
                CB_ValorEsperadoUnidades.Visible = true;
            }

            else //esRestriccionIndiceConformidad
            {
                L_CorrespA.Text = "definido para \nla curva del: ";
                L_CorrespA.Visible = true;
                TB_CorrespA.Visible = true;
                CB_CorrespAUnidades.Visible = true;
                cargarUnidadesDosis(CB_CorrespAUnidades);
                CB_CorrespAUnidades.Enabled = false;
                CB_CorrespAUnidades.SelectedIndex = 1;
                CB_ValorEsperadoUnidades.Visible = false;
            }
        }
        private List<IRestriccion> restriccionesActuales()
        {
            List<IRestriccion> listaRestricciones = new List<IRestriccion>();
            List<Condicion> condiciones = null;
            if (tipoCondicionActual() == Tipo.NumFx)
            {
                condiciones = listaCondicionesNumFracc.ToList();
            }
            else if (tipoCondicionActual() == Tipo.VolPTV)
            {
                condiciones = listaCondicionesVolPTV.ToList();
            }
            for (int i = 1; i < DGV_restricciones.ColumnCount; i++)
            {
                if (!Double.IsNaN(valorEsperado(i)))
                {
                    Condicion condicion = null;
                    if (condiciones != null)
                    {
                        condicion = condiciones[i - 1];
                    }

                    if (esRestriccionDosis())
                    {
                        listaRestricciones.Add(new RestriccionDosis().crear(estructura(), unidadValor(), unidadCorrespondiente(), esMenorQue(), valorEsperado(i), valorTolerado(i), valorCorrespondiente(), notaRestriccion(), condicion));
                    }
                    else if (esRestriccionDmedia())
                    {
                        listaRestricciones.Add(new RestriccionDosisMedia().crear(estructura(), unidadValor(), unidadCorrespondiente(), esMenorQue(), valorEsperado(i), valorTolerado(i), valorCorrespondiente(), notaRestriccion(), condicion));
                    }
                    else if (esRestriccionDmax())
                    {
                        listaRestricciones.Add(new RestriccionDosisMax().crear(estructura(), unidadValor(), unidadCorrespondiente(), esMenorQue(), valorEsperado(i), valorTolerado(i), valorCorrespondiente(), notaRestriccion(), condicion));
                    }
                    else if (esRestriccionVolumen())
                    {
                        listaRestricciones.Add(new RestriccionVolumen().crear(estructura(), unidadValor(), unidadCorrespondiente(), esMenorQue(), valorEsperado(i), valorTolerado(i), valorCorrespondiente(), notaRestriccion(), condicion));
                    }
                    else //esRestriccionIndiceConformidad
                    {
                        listaRestricciones.Add(new RestriccionIndiceConformidad().crear(estructura(), unidadValor(), unidadCorrespondiente(), esMenorQue(), valorEsperado(i), valorTolerado(i), valorCorrespondiente(), notaRestriccion(), condicion));
                    }
                }

            }
            return listaRestricciones;

        }

        private void CB_TipoRestriccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarPorRestriccion();
        }

        private void limpiarPrescripcion()
        {
            TB_CorrespA.Clear();
            //TB_ValorEsperado.Clear();
            //TB_ValorTolerado.Clear();
            CB_MenorOMayor.SelectedIndex = 0;
            CB_TipoRestriccion.SelectedIndex = 0;
            CB_CorrespAUnidades.SelectedIndex = 0;
            CB_ValorEsperadoUnidades.SelectedIndex = 0;
            TB_NotaRestriccion.Clear();
            foreach (DataGridViewRow row in DGV_restricciones.Rows)
            {
                for (int i = 1; i < DGV_restricciones.ColumnCount; i++)
                {
                    row.Cells[i].Value = "";
                }
            }

        }

        private void limpiarPlantilla()
        {
            limpiarPrescripcion();
            CB_Estructura.Items.Clear();
            listaRestricciones.Clear();
            LB_listaRestricciones.DataSource = listaRestricciones;
            TB_NombrePlantilla.Clear();
            fijarEsParaExtraccion();
            TB_NotaPlantilla.Clear();
        }
        private void BT_GuardarPlantilla_Click(object sender, EventArgs e)
        {
            plantillaActual().guardar(editaPlantilla, main.plantillaSeleccionada());
            limpiarPlantilla();
            main.leerPlantillas();
            editaPlantilla = false;
            Close();
        }

        private void BT_EliminarRestriccion_Click(object sender, EventArgs e)
        {
            List<IRestriccion> listaAEliminar = LB_listaRestricciones.SelectedItems.OfType<IRestriccion>().ToList();
            foreach (IRestriccion item in listaAEliminar)
            {
                listaRestricciones.Remove(item);
            }
            fijarEsParaExtraccion();
        }

        private void CB_Estructura_TextChanged(object sender, EventArgs e)
        {
            TB_EstructuraNombresAlt.Clear();
            actualizarBotones(sender, e);
        }

        private void CHB_esParaExtraccion_CheckedChanged(object sender, EventArgs e)
        {
            if (esParaExtraccion())
            {
                Panel_esMenorque.Visible = false;
            }
            else
            {
                Panel_esMenorque.Visible = true;
            }
            actualizarBotones(sender, e);
        }

        private void fijarEsParaExtraccion()
        {
            if (LB_listaRestricciones.Items.Count > 0)
            {
                CHB_esParaExtraccion.Enabled = false;
            }
            else
            {
                CHB_esParaExtraccion.Enabled = true;
            }
        }

        private void BT_EditarRestriccion_Click(object sender, EventArgs e)
        {
            GB_NuevaRestriccion.Enabled = true;
            prepararDGVRestricciones();
            listaRestriccionesAsociadas = restriccionesAsociadas((IRestriccion)LB_listaRestricciones.SelectedItem, plantillaActual());
            LB_listaRestricciones.Enabled = false;
            ((IRestriccion)(LB_listaRestricciones.SelectedItem)).editarGrupo(listaRestriccionesAsociadas, DGV_restricciones, CB_Estructura, TB_EstructuraNombresAlt, CB_TipoRestriccion, TB_CorrespA,
                CB_CorrespAUnidades, CB_MenorOMayor, CB_ValorEsperadoUnidades, TB_NotaRestriccion, LB_Condiciones, LB_ListaCondiciones);
            BT_AgregarALista.Text = "Guardar";
            editaRestriccion = true;
        }




        private void actualizarBotones(object sender, EventArgs e)
        {
            Metodos.habilitarBoton(LB_listaRestricciones.SelectedItems.Count > 0, BT_EliminarRestriccion);
            Metodos.habilitarBoton(LB_listaRestricciones.SelectedItems.Count == 1, BT_EditarRestriccion);
            Metodos.habilitarBoton(estaParaGrabarRestriccion(), BT_AgregarALista);
            Metodos.habilitarBoton(!string.IsNullOrEmpty(TB_NombrePlantilla.Text) && LB_listaRestricciones.Items.Count > 0, BT_GuardarPlantilla);
            Metodos.habilitarBoton(LB_listaRestricciones.SelectedItems.Count == 1 && LB_listaRestricciones.SelectedIndex != 0, BT_RestriccionArriba);
            Metodos.habilitarBoton(LB_listaRestricciones.SelectedItems.Count == 1 && LB_listaRestricciones.SelectedIndex != LB_listaRestricciones.Items.Count - 1, BT_RestriccionAbajo);
        }

        private bool estaParaGrabarRestriccion()
        {
            /*return !string.IsNullOrEmpty(CB_Estructura.Text) && CB_TipoRestriccion.SelectedIndex != -1 &&
              (esParaExtraccion() || (CB_MenorOMayor.SelectedIndex != -1 && !string.IsNullOrEmpty(TB_ValorEsperado.Text)));*/
            return true;
        }



        private void BT_RestriccionArriba_Click(object sender, EventArgs e)
        {
            int indice = LB_listaRestricciones.SelectedIndex;
            IRestriccion item = (IRestriccion)LB_listaRestricciones.SelectedItem;
            listaRestricciones.Remove(item);
            listaRestricciones.Insert(indice - 1, item);
            LB_listaRestricciones.ClearSelected();
            LB_listaRestricciones.SelectedIndex = indice - 1;
        }

        private void BT_RestriccionAbajo_Click(object sender, EventArgs e)
        {
            int indice = LB_listaRestricciones.SelectedIndex;
            IRestriccion item = (IRestriccion)LB_listaRestricciones.SelectedItem;
            listaRestricciones.Remove(item);
            listaRestricciones.Insert(indice + 1, item);
            LB_listaRestricciones.ClearSelected();
            LB_listaRestricciones.SelectedIndex = indice + 1;
        }

        private void Form1_ext_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listaRestricciones.Count > 0 && MessageBox.Show("Hay restricciones que no han sido guardadas \n ¿Desea salir sin guardar?", "Salir", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void CB_cond1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_cond1.SelectedIndex != -1 && (Operador)CB_cond1.SelectedItem == Operador.entre)
            {
                TB_Cond2.Enabled = true;
            }
            else
            {
                TB_Cond2.Enabled = false;
            }
        }

        private void BT_AgregarCondicion_Click(object sender, EventArgs e)
        {

            Condicion condicion = valorCondicionActual();
            if (condicion.tipo == Tipo.NumFx)
            {
                listaCondicionesNumFracc.Add(condicion);
            }
            else if (condicion.tipo == Tipo.VolPTV)
            {
                listaCondicionesVolPTV.Add(condicion);
            }


        }

        private void LB_Condiciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Tipo)LB_Condiciones.SelectedItem == Tipo.SinCondicion)
            {
                conOSinCondiciones(false);
                LB_ListaCondiciones.DataSource = null;
                L_VolPTVcc.Visible = false;
            }
            if ((Tipo)LB_Condiciones.SelectedItem == Tipo.NumFx)
            {
                LB_ListaCondiciones.DataSource = null;
                LB_ListaCondiciones.DataSource = listaCondicionesNumFracc;
                LB_ListaCondiciones.DisplayMember = "id";
                conOSinCondiciones(true);
                L_VolPTVcc.Visible = false;
            }
            else if ((Tipo)LB_Condiciones.SelectedItem == Tipo.VolPTV)
            {
                LB_ListaCondiciones.DataSource = null;
                LB_ListaCondiciones.DataSource = listaCondicionesVolPTV;
                LB_ListaCondiciones.DisplayMember = "id";
                conOSinCondiciones(true);
                L_VolPTVcc.Visible = true;
            }
            CB_cond1_SelectedIndexChanged(sender, e);
        }

        private void conOSinCondiciones(bool booleano)
        {
            CB_cond1.Enabled = booleano;
            TB_Cond1.Enabled = booleano;
            TB_Cond2.Enabled = booleano;
            BT_AgregarCondicion.Enabled = booleano;
            LB_ListaCondiciones.Enabled = booleano;
        }

        private Tipo tipoCondicionActual()
        {
            return (Tipo)LB_Condiciones.SelectedItem;
        }

        private Condicion valorCondicionActual()
        {
            if (tipoCondicionActual() == Tipo.SinCondicion)
            {
                return null;
            }
            else
            {
                double ValorEsperado2 = double.NaN;

                if ((Operador)CB_cond1.SelectedItem == Operador.entre)
                {
                    ValorEsperado2 = Metodos.validarYConvertirADouble(TB_Cond2.Text);
                }
                Condicion condicion = Condicion.crear((Tipo)LB_Condiciones.SelectedItem, (Operador)CB_cond1.SelectedItem, Metodos.validarYConvertirADouble(TB_Cond1.Text), ValorEsperado2);
                return condicion;
            }
        }

        private void prepararDGVRestricciones()
        {
            DGV_restricciones.Rows.Clear();
            DGV_restricciones.Columns.Clear();
            DGV_restricciones.Refresh();
            DGV_restricciones.Columns.Add("Encabezado", "");
            DGV_restricciones.Rows.Add(2);
            DGV_restricciones.Rows[0].Cells[0].Value = "Ópt";
            DGV_restricciones.Rows[1].Cells[0].Value = "Tol";
        }

        private void BT_IniciarCargaRestricciones_Click(object sender, EventArgs e)
        {
            if (tipoCondicionActual() != Tipo.SinCondicion && LB_ListaCondiciones.Items.Count == 0)
            {
                MessageBox.Show("Debe ingresar valores para la condición elegida");
            }
            else
            {
                BT_IniciarCargaRestricciones.Enabled = false;
                BT_FinalizarCargaRestricciones.Enabled = true;
                prepararDGVRestricciones();
                GB_Condiciones.Enabled = false;
                GB_NuevaRestriccion.Enabled = true;

                if (tipoCondicionActual() == Tipo.SinCondicion)
                {
                    DGV_restricciones.Columns.Add("Valores", "Valores");
                }
                else
                {
                    foreach (Condicion valor in LB_ListaCondiciones.Items)
                    {
                        DGV_restricciones.Columns.Add(valor.id, valor.id);
                    }
                }
                DGV_restricciones.Columns[0].ReadOnly = true;
                DGV_restricciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                DGV_restricciones.RowHeadersVisible = false;
            }

        }

        private void BT_FinalizarCargaRestricciones_Click(object sender, EventArgs e)
        {
            BT_IniciarCargaRestricciones.Enabled = true;
            BT_FinalizarCargaRestricciones.Enabled = false;
            GB_Condiciones.Enabled = true;
            GB_NuevaRestriccion.Enabled = false;
        }

        private List<IRestriccion> restriccionesAsociadas(IRestriccion restriccionSeleccionada, Plantilla plantillaActual)
        {
            List<IRestriccion> lista = new List<IRestriccion>();

            foreach (IRestriccion restriccion in plantillaActual.listaRestricciones)
            {
                if (restriccion.etiquetaInicio == restriccionSeleccionada.etiquetaInicio && restriccion.condicion.tipo == restriccionSeleccionada.condicion.tipo)
                {
                    lista.Add(restriccion);
                }
            }
            return lista;
        }

        private void BT_EliminarCondicion_Click(object sender, EventArgs e)
        {
            if (tipoCondicionActual() == Tipo.NumFx)
            {
                listaCondicionesNumFracc.Remove((Condicion)LB_ListaCondiciones.SelectedItem);
            }
            else if (tipoCondicionActual() == Tipo.VolPTV)
            {
                listaCondicionesVolPTV.Remove((Condicion)LB_ListaCondiciones.SelectedItem);
            }
        }

        private void LB_ListaCondiciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            BT_EliminarCondicion.Enabled = LB_ListaCondiciones.SelectedItems.Count == 1;
        }

        private void BT_CargarDesdePaciente_Click(object sender, EventArgs e)
        {
            ImportarNombresEstructuras importarNombresEstructuras = new ImportarNombresEstructuras();
            importarNombresEstructuras.ShowDialog();
            foreach (string nombre in importarNombresEstructuras.nombresEstructurasSeleccionadas)
            {
                CB_Estructura.Items.Add(nombre);
            }
        }
    }
}
