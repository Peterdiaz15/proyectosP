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
    public partial class frmCatalogo : Form
    {
        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Vista.CatalogoProductos objPro = new Vista.CatalogoProductos();
            //objPro.MdiParent = this;
            objPro.ShowDialog();
        }

        private void btnCuentasDeUsuario_Click(object sender, EventArgs e)
        {
           Vista.Ventas objPro = new Vista.Ventas();
            //objPro.MdiParent = this;
            objPro.ShowDialog();
        }

        private void grpCatalogo_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Vista.Reportes objPro = new Vista.Reportes();
            //objPro.MdiParent = this;
            objPro.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            Vista.ventaDiaria objVd = new ventaDiaria();
            objVd.ShowDialog();
        }
    }
}
