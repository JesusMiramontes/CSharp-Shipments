using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalv2
{
    class Nodo
    {
        public int Valor;
        public Nodo Sig;
        public Nodo(int V, Nodo S = null) //V = Valor, S = Siguiente (Referencia)
        {
            Valor = V;
            Sig = S;
        }
    }
}
