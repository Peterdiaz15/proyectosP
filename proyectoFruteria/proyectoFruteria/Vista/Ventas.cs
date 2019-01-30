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
	public partial class Ventas : Form
	{
		public int id;


		public Ventas()
		{
			InitializeComponent();
            llenar();
            traerId();
        }
        
        public void traerId()
		{
			Datos.DAOventas buscar = new Datos.DAOventas();
            Datos.DAOVentaProducto objconec = new Datos.DAOVentaProducto();
            id = buscar.buscarId();
			id += 1;
			txId.Text = "" + id;
		}
		private void btnAgregar_Click(object sender, EventArgs e)
		{
			MasProductos objm = new MasProductos();
			objm.ShowDialog();
			llenar();
		}
		public void llenar()
		{
			Datos.DAOVentaProducto objconec = new Datos.DAOVentaProducto();
			dtgV.DataSource = objconec.llenar(Int32.Parse(txId.Text));
			lblPrecio.Text = objconec.traerTotal(id) + "";
		}

		private void btnAceptarVenta_Click(object sender, EventArgs e)
		{
			Pojos.VarVentas objVariables = new Pojos.VarVentas();
			Datos.DAOventas objConexion = new Datos.DAOventas();

			objVariables.ID = Int32.Parse(txId.Text);
			objVariables.Fecha = DateTime.Parse(dtmFechaVenta.Text);
			objVariables.TotalPagar = Double.Parse(lblPrecio.Text);
			objConexion.AgregarVenta(objVariables);
			//MessageBox.Show("Venta Registrada", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Pojos.VarVentas objVariables = new Pojos.VarVentas();
			Datos.DAOventas objConexion = new Datos.DAOventas();
            Datos.DAOproducto objp = new Datos.DAOproducto();

            objVariables.ID = Int32.Parse(txId.Text);
			objVariables.Fecha = DateTime.Parse(dtmFechaVenta.Text);
			objVariables.TotalPagar = Double.Parse(lblPrecio.Text);

            foreach (DataGridViewRow fila in dtgV.Rows)
            {
               // MessageBox.Show("cantidad "+ double.Parse(fila.Cells[1].Value.ToString())+" \nid "+ objp.traeridProducto(fila.Cells[0].Value.ToString()), "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objp.descontar(double.Parse(fila.Cells[1].Value.ToString()),objp.traeridProducto(fila.Cells[0].Value.ToString()));
            }
            objConexion.AgregarVenta(objVariables);
			MessageBox.Show("Venta Registrada", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

		private void dtmFechaVenta_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
			{
				MasProductos objm = new MasProductos();
				objm.ShowDialog();
				llenar();
			}
            if (e.KeyData== Keys.I)
            {
                imprimir();    
            
        }
		}

        private void button1_Click(object sender, EventArgs e)
        {
            imprimir();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Pojos.agregarProducto objVariables = new Pojos.agregarProducto();
            Datos.DAOVentaProducto objConexion = new Datos.DAOVentaProducto();
            try
            {
                if (dtgV.Rows.Count==0)
                {
                    this.Close();
                }
                else
                {
                    objVariables.idVenta = Int16.Parse(txId.Text);
                    objVariables.Nombres = dtgV.Rows[dtgV.SelectedRows[0].Index].Cells[0].Value.ToString();
                    if (MessageBox.Show("Seguro que desea eliminar el producto: " +
                  objVariables.Nombres, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes)
                    {
                        objConexion.EliminarPro(objVariables);
                        MessageBox.Show("Se Eliminado");
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            llenar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Pojos.agregarProducto objVariables = new Pojos.agregarProducto();
            Datos.DAOVentaProducto objConexion = new Datos.DAOVentaProducto();
            
                objVariables.idVenta = Int16.Parse(txId.Text);
                if (MessageBox.Show("Seguro que desea cancelar la venta" ,
                    "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes)
                {
                    objConexion.EliminarTodo(objVariables);
                    this.Close();
                }
           
        }

        private void Ventas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.I)
            {
                imprimir();
            }
        }
        public void imprimir()
        {
            Datos.CrearTicket ticket = new Datos.CrearTicket();
            //ticket.AbreCajon();

            //Datos de la cabezera del Ticket
            ticket.Textocentro("FRUTERIA LA HUERTA");
            ticket.Textocentro("Del campo a tu mesa");
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("Av. Miguel Hidalgo 60");
            ticket.TextoIzquierda("Zona Centro,38980 Uriangato,Gto.");
            ticket.lineasAsteriscos();

            //Sub cabecera
            ticket.textoExtremos("FECHA " + DateTime.Now.ToShortDateString(), "HORA" + DateTime.Now.ToShortTimeString());
            ticket.lineasAsteriscos();

            //Articulos a vender
            ticket.Ecabezado();
            ticket.lineasAsteriscos();
            foreach (DataGridViewRow fila in dtgV.Rows)
            {
                ticket.AgregarArticulo(decimal.Parse(fila.Cells[1].Value.ToString()), fila.Cells[0].Value.ToString(),
                    decimal.Parse(fila.Cells[2].Value.ToString()), decimal.Parse(fila.Cells[3].Value.ToString()));
            }

            //Resumen de la Veta

            ticket.lineasIgual();
            ticket.AgregarTotales("TOTAL......$", decimal.Parse(lblPrecio.Text));

            //Texto final
            ticket.TextoIzquierda("");
            ticket.Textocentro("Servicio a domicilio");
            ticket.Textocentro("445 103 80 48");
            ticket.TextoIzquierda("");
            ticket.Textocentro("!GRACIAS POR SU COMPRA!");
            ticket.TextoIzquierda("");
            ticket.Textocentro("VUELVA PRONTO");

            //Descomentas esto 
            //ticket.cortaTicket();

            //aqui es donde pones el nombre de la impresora 
            ticket.ImprimirTicket("POS-58");

        }
        private void Ventas_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Pojos.agregarProducto objVariables = new Pojos.agregarProducto();
            Datos.DAOVentaProducto objConexion = new Datos.DAOVentaProducto();
            
                if (dtgV.Rows.Count == 0)
                {
                    MessageBox.Show("Cerrar");
                }
                else
                {
                    objConexion.EliminarTodo(objVariables);
                }    
        }
    }
}
