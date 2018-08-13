using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalv2
{
    class Pila<T>
    {
        T []vec;
        int tope;
        bool vacia;
        bool llena;

        //public int Tamaño { get; set; }

        public Pila(int n = 1)
        {
            vec = new T[n];
            tope = 0;
            vacia = true;
            llena = false;
        }

        public void push(T valor)
        {
            vacia = false;

            if (!llena)
		        vec[tope++] = valor;

            if(tope == vec.Length)
                llena = true;
        }

        public T pop()
        {
            if(--tope == 0)
                vacia = true;
            llena = false;
            return vec[tope];
        }


        public bool Llena
        {
            get { return llena; }
        }

        public bool Vacia
        {
            get { return vacia; }
        }




    }
}
