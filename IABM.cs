using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IABM<T> 
    {
        void Agregar(params object[] args);
        void Eliminar(object cual);
        void Actualiza(params object[] args);
        IEnumerable<T> Lista();
    }
}
