using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace production_activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPO_Click(object sender, EventArgs e)
        {
            frmPO frmPO = new frmPO();
            frmPO.ShowDialog();
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            frmMR frmMR = new frmMR();
            frmMR.ShowDialog(); 
        }

        private void btnBOM_Click(object sender, EventArgs e)
        {
            frmBOM frmBOM = new frmBOM();
            frmBOM.ShowDialog();
        }
    }
}
