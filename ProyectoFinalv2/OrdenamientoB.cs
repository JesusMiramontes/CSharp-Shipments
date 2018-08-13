using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalv2
    {
    class OrdenamientoB
        {
            static public DataGridView BurbujaConSeñalA(DataGridView vec)
            {

            int mov = 1;
            DataGridViewRow aux, aux2;
            //aux = (DataGridViewRow)vec.Rows[0].Clone();
            for (int i = 0; i < vec.RowCount && mov == 1; i++)
            {
                mov = 0;
                for (int j = vec.RowCount - 1; j > i; j--)
                {
                    if (( vec[5, j].Value.ToString() ).CompareTo( vec[5, j-1].Value.ToString())  < 0   )//vec[j] < vec[j - 1])
                    {
                        aux = (DataGridViewRow)vec.Rows[j].Clone();
                        for (Int32 index = 0; index < vec.Rows[j].Cells.Count; index++)
                        {
                            aux.Cells[index].Value = vec.Rows[j].Cells[index].Value;
                        }
                        //vec[j] = vec[j - 1];
                        aux2 = (DataGridViewRow)vec.Rows[j-1].Clone();
                        for (Int32 index = 0; index < vec.Rows[j-1].Cells.Count; index++)
                        {
                            aux.Cells[index].Value = vec.Rows[j-1].Cells[index].Value;
                        }

                        vec.Rows.Insert(j,aux2);
                        //vec[j - 1] = aux;
                        vec.Rows.Insert(j-1,aux);
                        mov = 1;
                    }
                }
            }
            return vec;

            //int mov = 1;
            //string[] aux = new string[10];
            //string[] aux2 = new string[10];
            //for (int i = 0; i < vec.RowCount && mov == 1; i++)
            //{
            //    mov = 0;
            //    for (int j = vec.RowCount - 1; j > i; j--)
            //    {
            //        if (  ( vec[5, j].Value.ToString() ).CompareTo( vec[5, j-1].Value.ToString())  < 0   )//vec[j] < vec[j - 1])
            //        {

            //            aux2 = aux = new string[vec.ColumnCount];

            //            for ( int x = 0 ; x < vec.ColumnCount ; x++ )
            //                {
            //                    aux[x] = vec.Rows[j].Cells[x].Value.ToString();
            //                }

            //            for ( int y = 0 ; y < vec.ColumnCount ; y++ )
            //                {
            //                    aux2[y] = vec.Rows[j-1].Cells[y].Value.ToString();
            //                }

            //            //vec[j] = vec[j - 1];

            //            for ( int l = 0 ; l < aux2.Length ; l++ )
            //                {
            //                    vec.Rows[j].Cells[l].Value = aux2[j];
            //                }

            //            for ( int ll = 0 ; ll < aux2.Length ; ll++ )
            //                {
            //                    vec.Rows[j-1].Cells[ll].Value = aux[j];
            //                }

            //           // vec[j - 1] = aux;
            //            mov = 1;
            //        }
            //    }
            //}
            //return vec;


            ////for ( int i = 0 ; i < vec.RowCount ; i++ )
            ////    {
            ////        if(   ( vec.Rows[i].Cells[5].ToString() ).CompareTo( vec[ )   )
            ////    }    

            }

        }
    }
