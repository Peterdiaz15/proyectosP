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

namespace proyectoFruteria.Vista
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
            LlenarCombo();
        }
        public void LlenarCombo()
        {
            Datos.DAOcategoria objConexion = new Datos.DAOcategoria();
            cmbCategoria.DataSource = objConexion.LlenarCategoria();
            cmbCategoria.DisplayMember = "NOMBRE";
            cmbCategoria.ValueMember = "CODIGO";
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text.Trim() != "" && txtPrecioAd.Text.Trim() != ""&& txtPrecioVenta.Text.Trim() != "" && txtCantidad.Text.Trim() != "")
            {
                Pojos.VarProducto objVariables = new Pojos.VarProducto();
            Datos.DAOproducto objConexion = new Datos.DAOproducto();

            objVariables.nombreCompleto = txtNombreProducto.Text;
            objVariables.precioAdquirido = Convert.ToDouble(txtPrecioAd.Text, CultureInfo.InvariantCulture);
            objVariables.precioVendido = Convert.ToDouble(txtPrecioVenta.Text, CultureInfo.InvariantCulture);
            objVariables.cantidad = Convert.ToDouble(txtCantidad.Text, CultureInfo.InvariantCulture);
        
            objVariables.nombrecategoria = "" + Convert.ToInt32(cmbCategoria.SelectedValue);
            objVariables.fechaAdquirido = DateTime.Parse(dtmFechaAdquirido.Text);

            
                if (objConexion.buscarExistencia(objVariables.nombreCompleto))
                {
                    MessageBox.Show("El producto ya existe", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    objConexion.AgregarPro(objVariables);
                    MessageBox.Show("Producto Registrado", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }else
            {
                MessageBox.Show("Campo vacio", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Datos.validar.SoloLetras(e);
        }

        private void txtPrecioAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            Datos.validar.NumerosConPunto(e);
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Datos.validar.NumerosConPunto(e);

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Datos.validar.NumerosConPunto(e);
        }

        private void txtNombreProducto_Validated(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text.Trim() == "")
            {
                errorCampoVacio.SetError(txtNombreProducto, "Campo vacio");
                txtNombreProducto.Focus();
            }else
            {
                errorCampoVacio.Clear();
            }
        }

        private void txtPrecioAd_Validated(object sender, EventArgs e)
        {
            if (txtPrecioAd.Text.Trim() == "")
            {
                errorCampoVacio.SetError(txtPrecioAd, "Campo vacio");
                txtPrecioAd.Focus();
            }
            else
            {
                errorCampoVacio.Clear();
            }
        }

        private void txtPrecioVenta_Validated(object sender, EventArgs e)
        {
            if (txtPrecioVenta.Text.Trim() == "")
            {
                errorCampoVacio.SetError(txtPrecioVenta, "Campo vacio");
                txtPrecioVenta.Focus();
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
