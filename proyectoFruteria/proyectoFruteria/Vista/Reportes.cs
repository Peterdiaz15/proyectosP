using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace proyectoFruteria.Vista
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }
        private void Reportes_Load(object sender, EventArgs e)
        {
            lbProducto.Visible = false;
            txtNombreProducto.Visible = false;
            //cargar los datos para el autocomplete del textbox
            txtNombreProducto.AutoCompleteCustomSource = Autocomplete();
            txtNombreProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNombreProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

        private void rbUno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUno.Checked == true) {

                lbProducto.Visible = true;
                txtNombreProducto.Visible = true;
            }
            else
            {
                lbProducto.Visible = false;
                txtNombreProducto.Visible = false;

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            VerReporte form = new VerReporte();
            ReportDocument oRep = new ReportDocument();
            ParameterField pf1 = new ParameterField();
            ParameterDiscreteValue pdv1 = new ParameterDiscreteValue();
            ParameterField pf2 = new ParameterField();
            ParameterDiscreteValue pdv2 = new ParameterDiscreteValue();
            ParameterField pf3 = new ParameterField();
            ParameterDiscreteValue pdv3 = new ParameterDiscreteValue();
            ParameterFields pfs = new ParameterFields();

            Datos.DAOproducto obj = new Datos.DAOproducto();

            if (rbUno.Checked == true)
            {
                if (obj.buscarExistencia(txtNombreProducto.Text)) {
                    pf1.Name = "idPro";
                    pdv1.Value = ob.traeridProducto(txtNombreProducto.Text);
                    pf1.CurrentValues.Add(pdv1);
                    pfs.Add(pf1);

                    pf2.Name = "fechIni";
                    pdv2.Value = dtmFechaI.Text;
                    pf2.CurrentValues.Add(pdv2);
                    pfs.Add(pf2);

                    pf3.Name = "fechFin";
                    pdv3.Value = dtmFechaF.Text;
                    pf3.CurrentValues.Add(pdv3);
                    pfs.Add(pf3);


                    form.crystalReportViewer1.ParameterFieldInfo = pfs;
                    oRep.Load(@"C:\Program Files\TOSHIBA\Inst\Reportes\reportProducto.rpt");
                    //oRep.Load(@"C:\Users\sandra\Desktop\v26\proyectoFruteria\proyectoFruteria\Vista\reportProducto.rpt");
                    form.crystalReportViewer1.ReportSource = oRep;
                    form.Show();
                }else
                {
                    MessageBox.Show("El producto no existe", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //MessageBox.Show(""+ DateTime.Parse(dtmFechaI.Text)+" "+ dtmFechaI.Text, "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pf2.Name = "fechIni";
                //pdv2.Value = DateTime.Parse(dtmFechaI.Text);
                pdv2.Value =dtmFechaI.Text;
                pf2.CurrentValues.Add(pdv2);
                pfs.Add(pf2);

                pf3.Name = "fechFin";
                //pdv3.Value = DateTime.Parse(dtmFechaF.Text);
                pdv3.Value = dtmFechaF.Text;
                pf3.CurrentValues.Add(pdv3);
                pfs.Add(pf3);


                form.crystalReportViewer1.ParameterFieldInfo = pfs;
                oRep.Load(@"C:\Program Files\TOSHIBA\Inst\Reportes\reportProductosT.rpt");
                //oRep.Load(@"C:\Users\sandra\Desktop\v26\proyectoFruteria\proyectoFruteria\Vista\reportProductosT.rpt");
                form.crystalReportViewer1.ReportSource = oRep;
                form.Show();

            }
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Datos.validar.SoloLetras(e);
        }
    }
}
