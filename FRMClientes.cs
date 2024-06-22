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
    public partial class FRMClientes : Form
    {
        CLSClienteDinámico CD;
        public FRMClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtApe.Text != "" && txtNom.Text != ""&& cmbEst.SelectedIndex.ToString()!="-1")
            {
                CD = new CLSClienteDinámico();
                string[] parametros = new string[4];
                parametros[0] = "";
                parametros[1] = txtApe.Text;
                parametros[2] = txtNom.Text;
                parametros[3] = cmbEst.SelectedItem.ToString();

                CD.Agregar(parametros);
            }
        }

        private void FRMClientes_Load(object sender, EventArgs e)
        {
            CD = new CLSClienteDinámico();
            dgv1.DataSource = CD.Lista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CD.exportaaXML(CLSListas.listp(), "ClientesXML.xml");
        }
    }
}
