using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Interface
{
    public  class CLSArchivos
    {
        public void escribe( string archi, string linea)
        {
            FileStream FS = new FileStream(archi, FileMode.Append, FileAccess.Write);
            StreamWriter SR = new StreamWriter(FS);
            SR.WriteLine(linea);
            SR.Close();
            FS.Close();
        }
        public List<string> lee(string archi)
        {
            List<string> lista = new List<string>();
            FileStream FS = new FileStream(archi, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader     SR = new StreamReader(FS);
            
            string linea = SR.ReadLine();
            string[] Vlinea=new string[0];
             while(linea!=null)
            {
                
                lista.Add(linea);
                linea = SR.ReadLine();
   
            }
            
            
            SR.Close();
            FS.Close();
            return lista;
        }
        public void modifica(string linea, string archi)
        {


        }

        
    }
}
