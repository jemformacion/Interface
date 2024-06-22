using System;
using System.Collections.Generic;

namespace Interface
{
    [Serializable]
    public class CLSCuentaCorrienteDinamica : IABM<CLSCuenta>
    {
        public void Actualiza(params object[] args)
        {
            throw new System.NotImplementedException();
        }

        public void Agregar(params object[] args)
        {
            throw new System.NotImplementedException();
        }

        public void Eliminar(object cual)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CLSCuenta> Lista()
        {
            List<string> lista = new List<string>();
            List<CLSCuenta> Lc = new List<CLSCuenta>();
           
            CLSArchivos arc  = new CLSArchivos();
            var lineas= arc.lee("Cuentas.txt");
            foreach ( var linea in lineas )
            {
                CLSCuentaCorriente cu=new CLSCuentaCorriente();
                string[] Vcu = linea.Split(';');
                cu.Cod_cuenta = Vcu[0];
                cu.Titular =int.Parse( Vcu[1]);
                cu.Descripcion = Vcu[2];
                cu.Saldo= int.Parse(Vcu[3]);
                Lc.Add(cu);
            }

            return Lc;

        }
    }
}