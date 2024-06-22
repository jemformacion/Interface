using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    [Serializable]
    public  class CLSCuentaCorriente:CLSCuenta
    {
		private decimal _descubierto;

		public decimal Descubierto
		{
			get { return _descubierto; }
			set { _descubierto = value; }
		}

	}
}
