using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Interface
{
    [Serializable]
    public class CLSClienteDinámico : IABM<CLSCliente>,IXML<CLSCliente>
    {
        CLSListas Listas=new CLSListas();
        List<CLSCliente> lista=new List<CLSCliente>();
        public void Actualiza(params object[] args)
        {
            
        }

        public void Agregar(params object[] args)
        {
            CLSArchivos arc = new CLSArchivos();
            CLSCliente nuevo= new CLSCliente();
            var propiedades = typeof(CLSCliente).GetProperties();

            for(int i =1;  i < args.Length; i++)
            {

                propiedades[i].SetValue(nuevo, args[i]);

            }
            List<string> L= arc.lee("Clientes.txt");
            if (L.Count != 0)
            {
                string[] Vl = L.Last().ToString().Split(';');
                int cod = Convert.ToInt32(Vl[0]) + 1;
                nuevo.Cod_Cliente = cod;
          //      nuevo.Estado = "Activo";
            }
            else
            {
                int cod =  1;
                nuevo.Cod_Cliente = cod;
               // nuevo.Estado = "Activo";
               
            }
            arc.escribe("Clientes.txt", nuevo.ToString());
            Listas.agregaCliente(nuevo);
        }

        public void Eliminar(object cual)
        {
            throw new NotImplementedException();
        }

        public void exportaaXML(List<CLSCliente> lista, string archi)
        {
            XmlSerializer NuevoXML=new XmlSerializer(typeof(List<CLSCliente>));
            using (TextWriter TW = new StreamWriter(archi)) 
            {
                NuevoXML.Serialize(TW, lista);
            }
        }

        public IEnumerable<CLSCliente> Lista()
        {

            CLSListas Lp = new CLSListas();

            List<string> lista = new List<string>();
            List<CLSCliente> Lc = new List<CLSCliente>();

            CLSArchivos arc = new CLSArchivos();
            var lineas = arc.lee("Clientes.txt");
            foreach (var linea in lineas)
            {
                CLSCliente cu = new CLSCliente();
                string[] Vcu = linea.Split(';');
                cu.Cod_Cliente =Int32.Parse( Vcu[0]);
                cu.Apellido = Vcu[1];
                cu.Nombre = Vcu[2];
                cu.Estado= Vcu[3];
                Lc.Add(cu);
                Lp.agregaCliente( cu );
            }

            return Lc;



           // List<CLSCliente> Lis = new List<CLSCliente>();
           
           //Lis =CLSListas.listp();

           // return Lis;
        }

        public List<CLSCliente> ListaObj(string archi)
        {
            return null;
        }
    }
}
