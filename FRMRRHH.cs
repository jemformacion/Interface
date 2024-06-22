using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class FRMRRHH : Form
    {
        public FRMRRHH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMClientes fc= new FRMClientes();
            fc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRMCLSCuentas fRMCLSCuentas = new FRMCLSCuentas();
            fRMCLSCuentas.Show();
        }
    }
}
