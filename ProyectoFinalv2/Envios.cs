using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalv2
    {
    public partial class Envios : Form
        {

        //int idActual = 1;
        //Paquete pq;
        BusquedaYasignacion hs = new BusquedaYasignacion();
        //Paquete[,] Paquetes = Master.Paquetes;
        int segundos = 0;
        //string ruta = "";

        public Envios()
            {
                //Carga la forma.
                InitializeComponent();

                //Carga los paquetes de Paquetes[,] en el dgv
                for ( int i = 0 ; i < Master.Paquetes.GetLength(0) ; i++ )
                    {
                        for ( int j = 0 ; j < Master.Paquetes.GetLength(1) ; j++ )
                            {
                                if(Master.Paquetes[i, j].ID != 0)
                                    dgv_envios.Rows.Add(Master.Paquetes[i,j].ID, false, Master.Paquetes[i, j].RutaAsignada, Master.Paquetes[i, j].Peso, Master.Paquetes[i, j].Destinatario,
                                        Master.Paquetes[i,j].DireccionDestinatario, Master.Paquetes[i,j].FechaEnvio.ToShortDateString(), Master.Paquetes[i,j].Estante, Master.Paquetes[i, j].Nivel);
                            }
                    }

            }

        //--------------- INICIO MOVER FORMA ---------------
            private bool mouseDown;
            private Point lastLocation;

            private void TopBar_MouseDown(object sender, MouseEventArgs e)
                {
                    mouseDown = true;
                    lastLocation = e.Location;
                }

            private void TopBar_MouseMove(object sender, MouseEventArgs e)
                {
                    if(mouseDown)
                        {
                            this.Location = new Point(
                                (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                            this.Update();
                        }
                }

            private void TopBar_MouseUp(object sender, MouseEventArgs e)
                {
                    mouseDown = false;
                }

        //--------------- FIN MOVER FORMA ---------------

        private void CloseButton_Click(object sender , EventArgs e)
            {
                this.Close();
            }

        private void MinimizeButton_Click(object sender , EventArgs e)
            {
                this.WindowState = FormWindowState.Minimized;
            }

        private void Envios_Load(object sender , EventArgs e)
            {
                
            }

        private void btnAgregar_Click(object sender , EventArgs e)
            {
                
            }

        private void btnAgregar_MouseEnter(object sender , EventArgs e)
            {

            }

        private void btnAgregar_MouseLeave(object sender , EventArgs e)
            {

            }

        private void button1_Click(object sender , EventArgs e)
            {
                
            }

        private void btnElegirL_env_Click(object sender , EventArgs e)
            {
                
            }

        private void btnAsignar_env_Click(object sender , EventArgs e)
            {
                
                //Progressbar
                try //Si no se tiene ningun valor y se presiona finalizar el maximum de progressbar = 10
                    {
                        pb_env.Maximum = dgv_envios.RowCount;
                    }
                catch ( Exception )
                    {
                        pb_env.Maximum = 10;
                    }
                bool perfomstep = false; //Variable que verifica qe almenos se haya realizado una accion.
                
                for ( int i = 0 ; i < dgv_envios.RowCount ; i++ )
                {
                    if(Convert.ToBoolean(dgv_envios[1,i].Value)) //Busca en el dgv los campos que tengan el check.
                    {
                        perfomstep = true; //Se ejecutó una acción.
                        dgv_envios[1,i].Value = false; //Borra el check.

                        int x = int.Parse(dgv_envios[7, i].Value.ToString()); //Estante
                        int y = int.Parse(dgv_envios[8, i].Value.ToString()); //Nivel

                        //Le asigna la ruta al paquete (propiedad).
                        Master.Paquetes[x, y].RutaAsignada = cbRuta_env.Text;
                        
                        //Actualiza el estatus a 1 = ruta asignada
                        Master.Paquetes[x, y].Status = 1;

                        //Actualiza el campo de ruta asignada en dgv
                        dgv_envios[2,i].Value = cbRuta_env.Text;

                        //Agrega evento al historial del paquete.
                        Master.Paquetes[x,y].Historial.Push(DateTime.Now.ToString() + " : Ruta asignada.");
                    }

                    //Si ejecutó almenos una accion, .PerformStep en progressbar.
                    if(perfomstep)
                        pb_env.PerformStep();
                }

                //Si al final de verificar todo el dgv y se ejecutó almenos una accion hacer 100% el ProgressBar.
                if(perfomstep)
                    pb_env.Value = pb_env.Maximum;

                //Espera unos segundos para hacer 0 de nuevo el ProgressBar.
                timer1.Enabled = true;
                timer1.Start();
            }

        private void btnEnviarACamion_env_Click(object sender , EventArgs e)
            {
                List<int> Encontrados = new List<int>();
                
                //Progressbar
                try //Si no se tiene ningun valor y se presiona finalizar el maximum de progressbar = 10
                    {
                        pb_env.Maximum = dgv_envios.RowCount;
                    }
                catch ( Exception )
                    {
                        pb_env.Maximum = 10;
                    }

            //Variable que verifica qe almenos se haya realizado una accion.
            bool perfomstep = false;

            //Recorre todo el datagridview en busca de coincidencia con ruta seleccionada para envio.
            for ( int i = 0 ; i < dgv_envios.RowCount ; i++  )
                {
                    int x = int.Parse(dgv_envios[7, i].Value.ToString());
                    int y = int.Parse(dgv_envios[8, i].Value.ToString());
                    
                    if(dgv_envios[2,i].Value.ToString() == cbEnviarCamion_env.Text) //Compara que la ruta seleccionada sea la misma que la que está ene sa fila.
                        {
                            //Ejecutó una acción.
                            perfomstep = true; 

                            //Actualiza estado a 2 = envio programado.
                           Master.Paquetes[x,y].Status = 2; 

                            //Añade evento al historial del paquete.
                           Master.Paquetes[x,y].Historial.Push(DateTime.Now.ToString() + " : Envio programado"); 

                            //Envia el paquete a la cola para el camión.
                            Master.ColaACamiones.Enqueue(Master.Paquetes[x,y]);

                            //Envia el paquete actual al historial de paquetes antiguos.
                            //Master.PaquetesAntiguos.Push(Master.Paquetes[x,y]);
                            Master.PaquetesFueraAlmacen.Add(Master.Paquetes[x, y]);

                            //Borra el paquete del estante.
                           Master.Paquetes[x,y] = new ProyectoFinalv2.Paquete();

                            ////Ubicaciones en dgv
                            //Encontrados.Add(i);
                        }

                    //Si ejecutó una acción .PerformStep().
                    if(perfomstep)
                        pb_env.PerformStep();
                }

            //Carga de nuevo info
            //Carga los paquetes de Paquetes[,] en el dgv
            dgv_envios.Rows.Clear();
            for (int i = 0; i < Master.Paquetes.GetLength(0); i++)
            {
                for (int j = 0; j < Master.Paquetes.GetLength(1); j++)
                {
                    if (Master.Paquetes[i, j].ID != 0)
                        dgv_envios.Rows.Add(Master.Paquetes[i, j].ID, false, Master.Paquetes[i,j].RutaAsignada, Master.Paquetes[i, j].Peso, Master.Paquetes[i, j].Destinatario,
                            Master.Paquetes[i, j].DireccionDestinatario, Master.Paquetes[i, j].FechaEnvio.ToShortDateString(), Master.Paquetes[i, j].Estante, Master.Paquetes[i, j].Nivel);
                }
            }

            //Si al final de verificar todo el dgv y se ejecutó almenos una accion hacer 100% el ProgressBar.
            if (perfomstep)
                        pb_env.Value = pb_env.Maximum;

                //Espera unos segundos para hacer 0 de nuevo el ProgressBar.
                timer1.Enabled = true;
                timer1.Start();
            }

        private void btn_AsignarL_env_Click(object sender , EventArgs e)
            {

            }

        private void timer1_Tick(object sender , EventArgs e)
            {
                if(segundos > 10)
                { 
                    pb_env.Value = 0;
                    timer1.Stop();
                    timer1.Enabled = false;
                }
                segundos++;
            }

        private void PanelLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
