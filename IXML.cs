using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IXML<T>
    {
        void exportaaXML(List<T> lista, string archi);
        List<T> ListaObj(string archi);
    }
}
