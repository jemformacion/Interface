using System;

namespace Interface
{
    [Serializable]
    public abstract class CLSCuenta
    {
     
        public CLSCuenta()
        {

        }
        private string _cod_cuenta;

        public string Cod_cuenta
        {
            get { return _cod_cuenta; }
            set { _cod_cuenta = value; }
        }

        private int _Titular;

        public int Titular
        {
            get { return _Titular; }
            set { _Titular = value; }
        }
        private string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        private decimal _saldo;

        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        public override string ToString()
        {
            return Cod_cuenta+";"+Descripcion+";"+Saldo.ToString();
        }
    }
}