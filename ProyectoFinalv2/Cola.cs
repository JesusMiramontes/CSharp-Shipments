using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalv2
{
    public class Cola<T>
    {
        T[] vec;
        int n, p, u;

        public Cola(int n = 5)
        {
            this.n = n;
            p = u = -1;
            vec = new T[n];
        }

        public bool EstaVacia()
        {
            return p == -1;
        }

        public bool EstaLlena()
        {
            return (p == 0 && u == n - 1) || u + 1 == p;
        }

        public bool Insertar(T elemento)
        {
            if(EstaLlena())
            {
                return false;
            }
            else
            {
                if (u == n - 1)
                {
                    u = 0;
                }   
                else
                {
                    u++;
                }
                if (p == -1)
                    p = 0;
                vec[u] = elemento;
                return true;
            }
        }

        public T Extraer()
        {
            if (EstaVacia())
            {
                throw new Exception("UNDERFLOW");
            }
            else
            {
                T aux = vec[p];
                if (p == u)
                {
                    p = u = -1;
                }
                else
                {
                    if (p == n - 1)
                    {
                        p = 0;
                    }
                    else
                    {
                        p++;
                    }
                }
                return aux;
            }
        }

        public bool Eliminar(ref T dato, T x)
        {
            if (p == -1)
                return false;
            dato = vec[p];
            if (p == u)
                p = u = -1;
            else if (p == n - 1)
            {
                vec[p] = x;
                p = 0;
            }
            else
            {
                vec[p] = x;
                p++;
            }
            return true;
        }
    }
}
