using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmFINACIAS : Form
    {

        private Modelo.Financiera oFinaciera;
        private Modelo.Agenda oAgenda;


        public frmFINACIAS()
        {
            InitializeComponent();
            oAgenda = Modelo.Agenda.Listado();
            if(oAgenda.listaFinancieras.Count > 0)
            {
                GRILLA();
            }
            

        }

        private void GRILLA()
        {
            dgwLISTAFINANCIAS.DataSource = null;
            dgwLISTAFINANCIAS.DataSource = oAgenda.listaFinancieras;
        }

        private void btnGUARDAR_Click_1(object sender, EventArgs e)
        {
            oFinaciera = new Modelo.Financiera();

            DateTime ingreso = dtpINGRESO.Value;
            string nombre = tbxNOMBRE.Text;
            DateTime vencimiento = dtpVENCIMIENTO.Value;
            bool estaPendiente = cbxPENDIENTE.Checked;
            Decimal importe = nudIMPORTE.Value;

            oFinaciera.ingreso = ingreso;
            if (nombre == "")
            {
                MessageBox.Show("Ingrese un nombre valido");
                return;
            }
            else
            {
                oFinaciera.nombre = nombre;
            }
            oFinaciera.vencimiento = vencimiento;
            oFinaciera.pendiente = estaPendiente;
            if (importe <= 0)
            {
                MessageBox.Show("Ingrese un importe valido");
                return;
            }
            else
            {
                oFinaciera.importe = importe;
            }
            oAgenda.listaFinancieras.Add(oFinaciera);

            GRILLA();


        }

        private void btnMODIFICAR_Click_1(object sender, EventArgs e)
        {
            oFinaciera = (Modelo.Financiera)dgwLISTAFINANCIAS.CurrentRow.DataBoundItem;



            oFinaciera.ingreso = dtpINGRESO.Value;
            if (tbxNOMBRE.Text == "")
            {
                MessageBox.Show("Ingrese un nombre valido");
                return;
            }
            else
            {
                oFinaciera.nombre = tbxNOMBRE.Text;
            }
            oFinaciera.vencimiento = dtpVENCIMIENTO.Value;
            oFinaciera.pendiente = cbxPENDIENTE.Checked;
            if (nudIMPORTE.Value <= 0)
            {
                MessageBox.Show("Ingrese un importe valido");
                return;
            }
            else
            {
                oFinaciera.importe = nudIMPORTE.Value;
            }


            GRILLA();
        }

        private void btnELIMINAR_Click_1(object sender, EventArgs e)
        {
            oFinaciera = (Modelo.Financiera)dgwLISTAFINANCIAS.CurrentRow.DataBoundItem;
            oAgenda.listaFinancieras.Remove(oFinaciera);
            GRILLA();
        }

        private void btnSALIR_Click_1(object sender, EventArgs e)
        {
                this.Close();
        }


    }
}
