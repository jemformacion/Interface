using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class CLSListas
    {
        static  List<CLSPersona> listaPersona = new List<CLSPersona>(); 
        static List<CLSCliente> listaCli = new List<CLSCliente>();
        static List<CLSCuenta> listaCue=new List<CLSCuenta>();

        public void agregaCliente(CLSCliente cliente)
        {
            listaCli.Add(cliente);
        }
        public void AgregaCuenta(CLSCuenta cuenta)
        {
            listaCue.Add(cuenta);
        }

        public static List<CLSCliente> listp()
        { 
            return listaCli; 
        }    
        public static List<CLSCuenta> Listc()
        {
            return listaCue;
        }
    }
}
