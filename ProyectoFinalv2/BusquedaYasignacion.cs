using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalv2
{
    class BusquedaYasignacion
    {

        public int Ui { get; set; } //Ubicación i (x)
        public int Uj { get; set; } //Ubicacion j (y)


        public void InsertarHash(Paquete pq)
        {
            int TD1 = Master.Paquetes.GetLength(0); //Tamaño dimensión 1
            int TD2 = Master.Paquetes.GetLength(1); //Tamaño dimensión 2

            int i = pq.ID % TD2;
            int j = pq.ID % TD1;
            int VInicial1 = i;
            int VInicial2 = j;
            while (true)
            {
                if (Master.Paquetes[i % TD1, j % TD2].ID == 0)
                {
                    Master.Paquetes[i % TD1, j % TD2] = pq;
                    Master.Paquetes[i % TD1, j % TD2].Estante = i;
                    Master.Paquetes[i % TD1, j % TD2].Nivel = j;
                    Ui = i % TD1;
                    Uj = j % TD2;
                    return;
                }
                else
                    j++;
                if (j % TD2 == VInicial2)
                {
                    i++;
                    if (i % TD1 == VInicial1)
                        throw new Exception("Oh, no! No hay espacio para almacenar el paquete. Quizas es tiempo de ampliar nuestros almacenes.");
                }
            }
        }

        public int[] MostrarHash(int idBuscado)
        {
            int TD1 = Master.Paquetes.GetLength(0);
            int TD2 = Master.Paquetes.GetLength(1);

            int i = idBuscado % TD2;
            int j = idBuscado % TD1;
            int VInicial1 = i;
            int VInicial2 = j;
            while (true)
            {
                if (Master.Paquetes[i % TD1, j % TD2].ID == idBuscado)
                {
                    return new int[] {i, j};
                }
                else
                    j++;
                if (j % TD2 == VInicial2)
                {
                    i++;
                    if (i % TD1 == VInicial1)
                        throw new Exception("No se ha encontrado.");
                }
            }
        }


        static public void ShakerA(ref List<Paquete> vec)
        {
            int mov = 1;
            Paquete aux = new ProyectoFinalv2.Paquete();

            int a = 0, b = vec.Count - 1;
            while(mov == 1)
            {
                mov = 0;
                for(int i = a, j = b; j > i; j--)
                {
                    if(vec[j].ID < vec[j - 1].ID)
                    {
                        aux = vec[j];
                        vec[j] = vec[j - 1];
                        vec[j - 1] = aux;
                        a = j;
                        mov = 1;
                    }
                }
                for(int i = a, j = b; i < j; i++)
                {
                    if(vec[i].ID > vec[i + 1].ID)
                    {
                        aux = vec[i];
                        vec[i] = vec[i + 1];
                        vec[i + 1] = aux;
                        b = i;
                        mov = 1;
                    }
                }
            }
        }


        static public int Binaria(int x)
        {
            int i = Master.PaquetesFueraAlmacen.Count / 2;
            int UbicacionEnLista = -1;

            if (Master.PaquetesFueraAlmacen[i].ID == x)
            {
                return UbicacionEnLista = i;
            }
            else if (Master.PaquetesFueraAlmacen[i].ID < x)
            {
                for (int j = i + 1; j < Master.PaquetesFueraAlmacen.Count; j++)
                {
                    if (Master.PaquetesFueraAlmacen[i].ID == x)
                    {
                        return UbicacionEnLista = j;
                    }
                }
                return UbicacionEnLista = -1;
            }
            else if (Master.PaquetesFueraAlmacen[i].ID > x)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Master.PaquetesFueraAlmacen[j].ID == x)
                    {
                        return UbicacionEnLista = j;
                    }
                }
                return UbicacionEnLista = -1;
            }
            else {
                    throw new Exception("No se ha encontrado.");
                }
        }


        static public int Binaria(int x, List<Paquete> lista)
        {
            int i = lista.Count / 2;
            int UbicacionEnLista = -1;

            if (lista[i].ID == x)
            {
                return UbicacionEnLista = i;
            }
            else if (lista[i].ID < x)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (lista[i].ID == x)
                    {
                        return UbicacionEnLista = j;
                    }
                }
                return UbicacionEnLista = -1;
            }
            else if (lista[i].ID > x)
            {
                for (int j = 0; j < i; j++)
                {
                    if (lista[j].ID == x)
                    {
                        return UbicacionEnLista = j;
                    }
                }
                return UbicacionEnLista = -1;
            }
            else {
                throw new Exception("No se ha encontrado.");
            }
        }



    }
}
