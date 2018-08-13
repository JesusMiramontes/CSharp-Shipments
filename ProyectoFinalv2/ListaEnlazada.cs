using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalv2
{
    class ListaEnlazada<t>
    {
        Nodo Primero; //Nodo cabeza
        Nodo Actual; 
        public ListaEnlazada()
            { }

        public bool ListaVacia()
        {
            return (Primero == null) ? true : false; //Verifica si "Primero" es nulo, lo que significaría lista vacía
        }

        public void Primer()
        {   Actual = this.Primero; } 

        public void Siguiente()  //Regresa el nodo siguiente al actual
        { 
            if(Actual != null)
                Actual = Actual.Sig;
        }   

        public void Ultimo() //Recorre todos los nodos hasta que el siguiente al actual regrese null
        {
            Primer();
            if (!ListaVacia())
                while (Actual.Sig != null)
                    Siguiente();
        }


        public void Insertar(int Valor) //Inserta valores de menor a mayor
            {
                Nodo Anterior; 
                if (ListaVacia() || Primero.Valor > Valor) //Sí la lista está vacia ó el primer valor es mayor al actual ingresa el valor en el primer lugar. 
                    Primero = new Nodo(Valor, Primero); //Se redefine el nodo primero, el nuevo nodo "Primero" recibe el valor a ingresar y apunta al que antes era el primero
                else //Si la lista no está vacia y el valor a ingresar es menor que el primero
                {
                    Anterior = Primero; 
                    while (Anterior.Sig != null && Anterior.Sig.Valor <= Valor) //Recorre todos los nodos mientras el siguiente al "Actual"(anterior) no sea nulo y el valor sea menor o igual al recibido
                        Anterior = Anterior.Sig;
                    Anterior.Sig = new Nodo(Valor, Anterior.Sig);
                }                   
            }

        public void Mostrar()
        {
            Nodo Aux;
            Aux = Primero;
            while (Aux != null)
            {
                Console.Write(Aux.Valor + "->");
                Aux = Aux.Sig;
            }
            Console.Write("   null \n");
        }

        public bool Borrar(int Valor)
        {
            Nodo Anterior, Nodo;
            Nodo = Primero;
            Anterior = null;
            while (Nodo != null && Nodo.Valor < Valor)
            {
                Anterior = Nodo;
                Nodo = Nodo.Sig;
            }
            if (Nodo == null || Nodo.Valor != Valor)
                return false;
            else
            {
                if (Anterior == null)
                    Primero = Nodo.Sig;
                else
                    Anterior.Sig = Nodo.Sig;
            }
            return true;
        }




    }
}
