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
    public partial class ventaDiaria : Form
    {
        public ventaDiaria()
        {
            InitializeComponent();
            lblFecha.Text = dtmFechaVenta.Text;        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Datos.DAOventas objV = new Datos.DAOventas();
            lblFecha.Text = dtmFechaVenta.Text;
            txtTotal.Text = objV.totalDia(DateTime.Parse(dtmFechaVenta.Text)).ToString();
        }
    }
}
