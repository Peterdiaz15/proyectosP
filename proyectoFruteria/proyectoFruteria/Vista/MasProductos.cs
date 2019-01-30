using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFruteria
{
    public partial class MasProductos : Form
    {
		public double precioTotal=0;
        public MasProductos()
        {
            InitializeComponent();
        }
		Vista.Ventas objv = new Vista.Ventas();

		private void button2_Click(object sender, EventArgs e)
        {
			this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

		private void button1_Click(object sender, EventArgs e)
		{
            //try{
                if (txtNp.Text.Trim() != "" && txtCantidad.Text.Trim() != "")
            {
                Pojos.agregarProducto objVariables = new Pojos.agregarProducto();
			Datos.DAOproducto objp = new Datos.DAOproducto();
			Datos.DAOVentaProducto objvp = new Datos.DAOVentaProducto();
			

			objVariables.idVenta = objv.id;
			objVariables.idProductos = objp.traeridProducto(txtNp.Text);
			objVariables.Nombres = txtNp.Text;
                
                if (objp.buscarExistencia(objVariables.Nombres)) { 
                    double cant = objvp.CambiarCantidad(objVariables.idVenta, objVariables.Nombres);
                    if (cant!=-1)
                    {
                        objVariables.Cantidad = Convert.ToDouble(txtCantidad.Text, CultureInfo.InvariantCulture)+ cant;
                        if (objp.ProductoExistencia(objVariables.Cantidad, objVariables.Nombres)>= 0) { 
                            objVariables.Total = (Convert.ToDouble(objVariables.Cantidad, CultureInfo.InvariantCulture) * Convert.ToDouble(objp.traerPrecio(txtNp.Text)));
                            precioTotal += (Convert.ToDouble(objVariables.Cantidad, CultureInfo.InvariantCulture) * objp.traerPrecio(txtNp.Text));
                            objVariables.Precio = Convert.ToDouble(objp.traerPrecio(txtNp.Text));
                            objvp.EditarPro(objVariables);
                            this.Close();
                            objv.lblPrecio.Text = precioTotal + "";
                         }else{
                            MessageBox.Show("No tines los suficientes productos\npara realizar la venta", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }else {
                        objVariables.Cantidad = Convert.ToDouble(txtCantidad.Text, CultureInfo.InvariantCulture);
                        if (objp.ProductoExistencia(objVariables.Cantidad, objVariables.Nombres) >= 0){
                            objVariables.Total = (Convert.ToDouble(objVariables.Cantidad, CultureInfo.InvariantCulture) * Convert.ToDouble(objp.traerPrecio(txtNp.Text)));
                            precioTotal += (Convert.ToDouble(objVariables.Cantidad, CultureInfo.InvariantCulture) * objp.traerPrecio(txtNp.Text));
                            objVariables.Precio = Convert.ToDouble(objp.traerPrecio(txtNp.Text));
                            objvp.AgregarPro(objVariables);
                            this.Close();
                            objv.lblPrecio.Text = precioTotal + "";
                         }else{
                            MessageBox.Show("No tines los suficientes productos\npara realizar la venta", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtCantidad.Text = "";
                            }
                    }
                }else {
                    MessageBox.Show("El producto no existe", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCantidad.Text = "";
                }
              }else{
                MessageBox.Show("Campo vacio", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            /*}catch (Exception ex)
            {

                MessageBox.Show("Formato incorreco en cantidad", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
		private void textBox2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
			{
				objv.Show();
				this.Hide();
			}

		}

		private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData==Keys.Enter)
			{
                //try{
                if (txtNp.Text.Trim() != "" && txtCantidad.Text.Trim() != "")
                {
                    Pojos.agregarProducto objVariables = new Pojos.agregarProducto();
                    Datos.DAOproducto objp = new Datos.DAOproducto();
                    Datos.DAOVentaProducto objvp = new Datos.DAOVentaProducto();


                    objVariables.idVenta = objv.id;
                    objVariables.idProductos = objp.traeridProducto(txtNp.Text);
                    objVariables.Nombres = txtNp.Text;

                    if (objp.buscarExistencia(objVariables.Nombres))
                    {
                        double cant = objvp.CambiarCantidad(objVariables.idVenta, objVariables.Nombres);
                        if (cant != -1)
                        {
                            objVariables.Cantidad = Convert.ToDouble(txtCantidad.Text, CultureInfo.InvariantCulture) + cant;
                            if (objp.ProductoExistencia(objVariables.Cantidad, objVariables.Nombres) >= 0)
                            {
                                objVariables.Total = (Convert.ToDouble(objVariables.Cantidad, CultureInfo.InvariantCulture) * Convert.ToDouble(objp.traerPrecio(txtNp.Text)));
                                precioTotal += (Convert.ToDouble(objVariables.Cantidad, CultureInfo.InvariantCulture) * objp.traerPrecio(txtNp.Text));
                                objVariables.Precio = Convert.ToDouble(objp.traerPrecio(txtNp.Text));
                                objvp.EditarPro(objVariables);
                                this.Close();
                                objv.lblPrecio.Text = precioTotal + "";
                            }
                            else
                            {
                                MessageBox.Show("No tines los suficientes productos\npara realizar la venta", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            objVariables.Cantidad = Convert.ToDouble(txtCantidad.Text, CultureInfo.InvariantCulture);
                            if (objp.ProductoExistencia(objVariables.Cantidad, objVariables.Nombres) >= 0)
                            {
                                objVariables.Total = (Convert.ToDouble(objVariables.Cantidad, CultureInfo.InvariantCulture) * Convert.ToDouble(objp.traerPrecio(txtNp.Text)));
                                precioTotal += (Convert.ToDouble(objVariables.Cantidad, CultureInfo.InvariantCulture) * objp.traerPrecio(txtNp.Text));
                                objVariables.Precio = Convert.ToDouble(objp.traerPrecio(txtNp.Text));
                                objvp.AgregarPro(objVariables);
                                this.Close();
                                objv.lblPrecio.Text = precioTotal + "";
                            }
                            else
                            {
                                MessageBox.Show("No tines los suficientes productos\npara realizar la venta", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtCantidad.Text = "";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El producto no existe", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCantidad.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Campo vacio", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                /*}catch (Exception ex)
                {

                    MessageBox.Show("Formato incorreco en cantidad", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }*/
            }
        }

        private void MasProductos_Load(object sender, EventArgs e)
        {
            //cargar los datos para el autocomplete del textbox
            txtNp.AutoCompleteCustomSource = Autocomplete();
            txtNp.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNp.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

        private void txtNp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Datos.validar.SoloLetras(e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Datos.validar.NumerosConPunto(e);
        }

        private void txtNp_Validated(object sender, EventArgs e)
        {
            if (txtNp.Text.Trim() == "")
            {
                errorCampoVacio.SetError(txtNp, "Campo vacio");
                txtNp.Focus();
            }
            else
            {
                errorCampoVacio.Clear();
            }
        }

        private void txtCantidad_Validated(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Trim() == "")
            {
                errorCampoVacio.SetError(txtCantidad, "Campo vacio");
                txtCantidad.Focus();
            }
            else
            {
                errorCampoVacio.Clear();
            }
        }
    }
}
