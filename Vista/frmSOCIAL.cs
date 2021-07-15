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
    public partial class frmSOCIAL : Form
    {

        private Modelo.Personal oPersonal;
        private Modelo.Agenda oAgenda;


        public frmSOCIAL()
        {
            InitializeComponent();
            oAgenda = Modelo.Agenda.Listado();
            if(oAgenda.listaPersonales.Count > 0)
            {
                GRILLA();
            }

        }

        private void GRILLA()
        {
            dgwLISTASOCIAL.DataSource = null;
            dgwLISTASOCIAL.DataSource = oAgenda.listaPersonales;
        }

        

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            oPersonal = new Modelo.Personal();

            DateTime ingreso = dtpINGRESO.Value;
            string nombre = tbxNOMBRE.Text;
            DateTime vencimiento = dtpVENCIMIENTO.Value;
            bool estaPendiente = cbxPENDIENTE.Checked;
            string lugar = tbxLUGAR.Text;

            oPersonal.ingreso = ingreso;
            if(nombre == "")
            {
                MessageBox.Show("Ingrese un nombre valido");
                return;
            } else
            {
                oPersonal.nombre = nombre;
            }
            oPersonal.vencimiento = vencimiento;
            oPersonal.pendiente = estaPendiente;
            if(lugar == "")
            {
                MessageBox.Show("Ingrese un lugar valido");
                return;
            } else
            {
                oPersonal.lugar = lugar;
            }
            oAgenda.listaPersonales.Add(oPersonal);

            GRILLA();
           

        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            oPersonal = (Modelo.Personal)dgwLISTASOCIAL.CurrentRow.DataBoundItem;
            oAgenda.listaPersonales.Remove(oPersonal);
            GRILLA();
        }
        
        


        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            oPersonal = (Modelo.Personal)dgwLISTASOCIAL.CurrentRow.DataBoundItem;



            oPersonal.ingreso = dtpINGRESO.Value;
            if(tbxNOMBRE.Text == "")
            {
                MessageBox.Show("Ingrese un nombre valido");
                return;
            } else
            {
                oPersonal.nombre = tbxNOMBRE.Text;
            }
            oPersonal.vencimiento = dtpVENCIMIENTO.Value;
            oPersonal.pendiente = cbxPENDIENTE.Checked;
            if(tbxLUGAR.Text == "")
            {
                MessageBox.Show("Ingrese un lugar valido");
                return;
            } else
            {
                oPersonal.lugar = tbxLUGAR.Text;
            }
            

            GRILLA();
        }

    }
}
