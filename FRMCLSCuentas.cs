using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Interface
{
    public partial class FRMCLSCuentas : Form
    {
        private TextBox Titular;
        Label lcod = new Label();
        CLSArchivos archi=new CLSArchivos();
        public FRMCLSCuentas()
        {
            InitializeComponent();
        }

        private void FRMCLSCuentas_Load(object sender, EventArgs e)
        {

            CLSCuentaCorrienteDinamica cc = new CLSCuentaCorrienteDinamica();
            var propiedades=typeof(CLSCuenta).GetProperties();
            int posx = 30, posy = 30;

            for(int i = 0; i < propiedades.Length; i++)
            {
                posx = 30;
                Label label = new Label();
                label.Text = propiedades[i].Name;
                label.Left = posx;
                label.Top = posy;
                label.Enabled = true;
                label.Font= new Font(label.Font.FontFamily,14);
                posx += 100;

                Controls.Add(label);

                if (propiedades[i].Name == "Titular")
                {
                    Titular = new TextBox();
                    Titular.Left = posx + 25;
                    Titular.Top = posy;
                    Titular.Enabled = true;
                    Titular.Font = new Font(Titular.Font.FontFamily, 14);
                    Titular.Width = 150;
                    Controls.Add(Titular);
                }
                else
                {
                    TextBox text = new TextBox();
                    text.Name = propiedades[i].Name;
                    text.Left = posx + 25;
                    text.Top = posy;
                    text.Enabled = true;
                    text.Font = new Font(text.Font.FontFamily, 14);
                    text.Width = 150;
                    Controls.Add(text);
                }
                posy += 30;
            }
            posx = 30;
            DataGridView d1=new DataGridView();
            d1.Width = 400;
            d1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;;  
            d1.Left = posx;
            d1.Top = posy;

            IEnumerable<CLSCuenta> cuen = cc.Lista();
            d1.DataSource = cuen;

            Controls.Add(d1 );

            Button BTit=new Button();
            BTit.Text = "Ver Titular";
            BTit.Name = "btnTit";
            BTit.Font = new Font(BTit.Font.FontFamily, 14);
            BTit.Click += new EventHandler(BTit_Click); // Llama al método
            BTit.Left = 350;
            BTit.Top = 30;
            Controls.Add( BTit );
        
        }

        private void BTit_Click(object sender, EventArgs e)
        {
            if(this.Titular.Text!="")
            {
                CLSArchivos arc = new CLSArchivos();
                var listaTit = arc.lee("Clientes.txt");

                string[] Vt = new string[0];
               foreach( string item in listaTit )
                {
                    Vt = item.Split(';');
                    string dato = Vt[0];
                    dato=dato.Trim();
                    if (dato == Titular.Text)
                    {
                        int posx = 450;
                        int posy = 100;

                     
                        lcod.Width = 250;
                       lcod.Font = new Font(lcod.Font.FontFamily, 18);

                        lcod.Text = "Titular: " + Vt[1] + ", " +Vt[2];
                        lcod.Location=new Point(posx, posy);
                        
                        Controls.Add(lcod);
                    }
                }

            }

        }
    }
}
