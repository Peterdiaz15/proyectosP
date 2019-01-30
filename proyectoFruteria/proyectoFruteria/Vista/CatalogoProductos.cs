using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFruteria.Vista
{
    public partial class CatalogoProductos : Form
    {
        public CatalogoProductos()
        {
            InitializeComponent();
            llenar();
        }
        public void llenar()
        {
            Datos.DAOproducto objconec = new Datos.DAOproducto();
            dtgDatos.DataSource = objconec.llenar();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Vista.AgregarProducto objAgr = new Vista.AgregarProducto();
            objAgr.ShowDialog();
            llenar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Pojos.VarProducto objVariables = new Pojos.VarProducto();
            Datos.DAOproducto objConexion = new Datos.DAOproducto();
            try
            {
                objVariables.idProductos = Int32.Parse(dtgDatos.Rows[dtgDatos.SelectedRows[0].Index].Cells[0].Value.ToString());

                if (MessageBox.Show("Seguro que desea eliminar al Producto con codigo " +
              objVariables.idProductos, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes)
                {
                    objConexion.EliminarPro(objVariables);
                   //MessageBox.Show("Se Eliminado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar el producto.");
                //Console.WriteLine(ex.ToString());
            }
            llenar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Vista.EditarProducto obj = new Vista.EditarProducto();
            Pojos.VarProducto objVariables = new Pojos.VarProducto();
            //Datos.DAOproducto objConexion = new Datos.DAOproducto();

            try
            {
                objVariables.idProductos = Int32.Parse(dtgDatos.CurrentRow.Cells[0].Value.ToString());
                objVariables.nombreCompleto= dtgDatos.CurrentRow.Cells[1].Value.ToString();
                objVariables.precioAdquirido =Double.Parse( dtgDatos.CurrentRow.Cells[2].Value.ToString());
                objVariables.precioVendido = Double.Parse(dtgDatos.CurrentRow.Cells[3].Value.ToString());
                objVariables.cantidad = Double.Parse(dtgDatos.CurrentRow.Cells[4].Value.ToString());
                objVariables.fechaAdquirido = DateTime.Parse(dtgDatos.CurrentRow.Cells[5].Value.ToString());
                objVariables.nombrecategoria = dtgDatos.CurrentRow.Cells[6].Value.ToString();



                obj.txtId.Text = objVariables.idProductos+"";
                obj.txtNombreProducto.Text = objVariables.nombreCompleto;
                obj.txtPrecioAd.Text = objVariables.precioAdquirido+"";
                obj.txtPrecioVenta.Text = objVariables.precioVendido+"";
                obj.txtCantidad.Text = objVariables.cantidad+"";
                obj.dtmFecha.Text = ""+objVariables.fechaAdquirido;
                obj.cmbCategoria.Text = objVariables.nombrecategoria;


                obj.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            llenar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CatalogoProductos_Load(object sender, EventArgs e)
        {
            //cargar los datos para el autocomplete del textbox
            txtBuscar.AutoCompleteCustomSource = Autocomplete();
            txtBuscar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        Datos.DAOproducto ob = new Datos.DAOproducto();

        //metodo para cargar la coleccion de datos para el autocomplete
        public AutoCompleteStringCollection Autocomplete()
        {
            DataTable dt = ob.DatosProductos();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["nombreCompleto"]));
            }

            return coleccion;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string bus = txtBuscar.Text;
            dtgDatos.DataSource = ob.Buscar(bus);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Datos.validar.SoloLetras(e);
        }
    }
}
