using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    [Serializable]
    public class CLSCliente:CLSPersona 
    {
     //   public CLSCliente(string A, string N, bool E) : base(A, N, E) 
    //    {
            
   //     }
        private int _CodCliente;

		public int Cod_Cliente
		{
			get { return _CodCliente; }
			set { _CodCliente = value; }
		}
        public override string ToString()
        {
            return  Cod_Cliente.ToString() + " ;" +base.ToString();
        }
    }
}
