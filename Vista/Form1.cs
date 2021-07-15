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
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();

            
        }

        private void tareasSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSOCIAL social = new frmSOCIAL();
            social.Show();
        }

        private void tareasFinancierasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFINACIAS financias = new frmFINACIAS();
            financias.Show();
        }
    }
}
