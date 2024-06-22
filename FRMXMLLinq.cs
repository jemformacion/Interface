using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;


namespace Interface
{
    public partial class FRMXMLLinq : Form
    {
        public FRMXMLLinq()
        {
            InitializeComponent();
        }

        private void FRMXMLLinq_Load(object sender, EventArgs e)
        {
            CLSClienteDinámico CD=new CLSClienteDinámico();
            CD.exportaaXML(CLSListas.listp(), "ClientesXML.xml");
        }

        private void txtXML_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
