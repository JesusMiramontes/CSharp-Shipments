using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProyectoFinalv2
    {
    public partial class Form0 : Form
        {
            //Siguiente id a asignar
            int idActual = 1;

            //Paquete aux.
            Paquete pq;

            //Hashing para buscar y asignar posición en estante, nivel.
            BusquedaYasignacion hs = new BusquedaYasignacion();


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

        //--------------- INICIO BOTONES FORMA ---------------
        private void CloseButton_Click(object sender, EventArgs e) //Boton que cierra la forma
        { this.Close(); }

        private void MinimizeButton_Click(object sender, EventArgs e) //Boton que minimiza la forma
        { this.WindowState = FormWindowState.Minimized; }

        //--------------- FIN BOTONES FORMA ---------------

        public Form0()
            {
            //Carga la forma;
            InitializeComponent();


            }


        private void Form0_Load(object sender , EventArgs e)
            {
                rec_id.Text = idActual.ToString(); //Muestra el id actual en la forma.
                //new Master().Show();
                //new Historial().Show();
                //new SalidaCamiones().Show();
            }

        private void btnAgregar_MouseEnter(object sender , EventArgs e)//Cuando el mouse entra a al "boton" cambia los colores (highlight)
            {
                btnAgregarL.BackColor = btnAgregar.BackColor = Color.FromArgb(156, 156, 156);
                btnAgregarL.ForeColor = Color.White;
            }

        private void btnAgregar_MouseLeave(object sender , EventArgs e) //Cuanto el mouse sale regresa el color al original
            {
                btnAgregarL.BackColor = btnAgregar.BackColor = Color.FromArgb(212, 212, 212);
                btnAgregarL.ForeColor = Color.FromArgb(64, 64, 64);
            }

        private void btnFinalizar_MouseEnter(object sender , EventArgs e)//Cuando el mouse entra a al "boton" cambia los colores (highlight)
            {
                btnFinalizarL.BackColor = btnFinalizar.BackColor = Color.FromArgb(156, 156, 156);
                btnFinalizarL.ForeColor = Color.White;
            }

        private void btnFinalizar_MouseLeave(object sender , EventArgs e) //Cuanto el mouse sale regresa el color al original
            {
                btnFinalizarL.BackColor = btnFinalizar.BackColor = Color.FromArgb(212, 212, 212);
                btnFinalizarL.ForeColor = Color.FromArgb(64, 64, 64);
            }

        private void btnAgregar_Click(object sender , EventArgs e)
            {
            
                try 
                    {
                        //Intenta agregar los datos ingresados en la forma a un nuevo paquete solo para verificar que los datos fueron escritos correctamente.
                        pq =  new Paquete(idActual , Convert.ToDouble(rec_peso.Text) , rec_remitente.Text , rec_destinatario.Text , rec_direccionR.Text , rec_direccionD.Text , Convert.ToDateTime(rec_fechaE.Text) , -1);
                        
                        //Agrega los datos al dgv
                        dgv_recepcion.Rows.Add(idActual , rec_peso.Text , rec_remitente.Text , rec_destinatario.Text ,
                                    rec_direccionR.Text , rec_direccionD.Text , rec_fechaE.Text , "-1", "-1");

                        idActual++; //incrementa idactual

                        ////Limpia controles de agregar paquete.
                        //rec_destinatario.Clear();
                        //rec_direccionD.Clear();
                        //rec_direccionR .Clear();
                        //rec_fechaE.Clear();
                        //rec_peso.Clear();
                        //rec_remitente.Clear();
                    }
                catch ( Exception ex)
                    {
                        //Cambia colores
                        CloseButton.BackColor = MinimizeButton.BackColor = TituloForma.BackColor = TopBar.BackColor = Color.FromArgb(229, 115, 104);
                        //TituloForma.ForeColor = Color.White;
                        
                        //Muestra mensaje error.
                        CustomMsgBox.Mostrar(ex.Message);

                        //Regresa colores.
                        CloseButton.BackColor = MinimizeButton.BackColor = TituloForma.BackColor = TopBar.BackColor = Color.FromArgb(16, 157, 89);
                        //TituloForma.ForeColor = Color.FromArgb(181, 181, 181);
                    }
                finally
                    {
                        rec_id.Text = idActual.ToString(); //Vuelve a mostrar id en forma.
                        rec_peso.Focus();
                    }
                
            }

        private void DownDgv_Paint(object sender , PaintEventArgs e)
            {

            }

        private void btnLimpiar_Click(object sender , EventArgs e)
            {
                //Limpia controles.
                rec_destinatario.Clear();
                rec_direccionD.Clear();
                rec_direccionR .Clear();
                rec_fechaE.Clear();
                rec_peso.Clear();
                rec_remitente.Clear();
            }

        private void btnNuevo_Click(object sender , EventArgs e) //Boton para agregar nuevo batch de paquetes.
            {
                //Rehabilita controles para ingresar paquete.
                btnFinalizarL.Enabled = btnFinalizar.Enabled = true;
                rec_destinatario.ReadOnly = false;
                rec_direccionD.ReadOnly = false;
                rec_direccionR .ReadOnly = false;
                rec_fechaE.ReadOnly = false;
                rec_peso.ReadOnly = false;
                rec_remitente.ReadOnly = false;
                dgv_recepcion.ReadOnly = false;

                //Limpia dgv
                dgv_recepcion.Rows.Clear();

                //ProgressBar a 0
                pb_rec.Value = 0;
            }

        private void btnLimpiar_MouseEnter(object sender , EventArgs e)
            {
                btnLimpiarL.BackColor = btnLimpiar.BackColor = Color.FromArgb(156, 156, 156);
                btnLimpiarL.ForeColor = Color.White;
            }

        private void btnLimpiar_MouseLeave(object sender , EventArgs e)
            {
                btnLimpiarL.BackColor = btnLimpiar.BackColor = Color.FromArgb(212, 212, 212);
                btnLimpiarL.ForeColor = Color.FromArgb(64, 64, 64);
            }

        private void btnNuevo_MouseLeave(object sender , EventArgs e)
            {
                btnNuevoL.BackColor = btnNuevo.BackColor = Color.FromArgb(212, 212, 212);
                btnNuevoL.ForeColor = Color.FromArgb(64, 64, 64);
            }

        private void btnNuevo_MouseEnter(object sender , EventArgs e)
            {
                btnNuevoL.BackColor = btnNuevo.BackColor = Color.FromArgb(156, 156, 156);
                btnNuevoL.ForeColor = Color.White;
            }

        private void btnFinalizar_Click(object sender , EventArgs e) //Boton que carga los datos del dgv en el arreglo de paquetes
            {
            bool error = false; //Variable que =true cuando hay error en operacion
            string descripcionError = ""; //Descripciond el error

            //Limpiar campos
            rec_destinatario.Clear();
            rec_direccionD.Clear();
            rec_direccionR .Clear();
            rec_fechaE.Clear();
            rec_peso.Clear();
            rec_remitente.Clear();
            rec_remitente.ReadOnly = true;

            //Modificar atributos campos
            rec_destinatario.ReadOnly = true;
            rec_direccionD.ReadOnly = true;
            rec_direccionR .ReadOnly = true;
            rec_fechaE.ReadOnly = true;
            rec_peso.ReadOnly = true;
            rec_remitente.ReadOnly = true;
            dgv_recepcion.ReadOnly = true;
            btnFinalizarL.Enabled = btnFinalizar.Enabled = false;

            //Progressbar
            try //Si no se tiene ningun valor y se presiona finalizar el maximum de progressbar = 10
                {
                    pb_rec.Maximum = dgv_recepcion.RowCount;
                }
            catch ( Exception )
                {
                    pb_rec.Maximum = 10;
                }

            if (dgv_recepcion.RowCount == 0) //Verifica que haya datos en dgv
            {
                descripcionError = "Oh! Creo que olvidaste agregar infomación! Presina el boton 'nuevo', esta vez agrega al menos un paquete antes de presionarme de nuevo.";
                error = true;
            }

            for ( int i = 0 ; i < dgv_recepcion.RowCount ; i++ )
                {
                    //Carga los dato en pq para despues agtregarlo al arreglo
                    pq = new ProyectoFinalv2.Paquete(int.Parse(dgv_recepcion [0 , i].Value.ToString()) ,
                            Convert.ToDouble(dgv_recepcion [1 , i].Value.ToString()) ,
                            dgv_recepcion [2 , i].Value.ToString() ,
                            dgv_recepcion [3 , i].Value.ToString() ,
                            dgv_recepcion [4 , i].Value.ToString() ,
                            dgv_recepcion [5 , i].Value.ToString() ,
                            Convert.ToDateTime(dgv_recepcion [6 , i].Value.ToString()));
                    pq.Historial.Push(DateTime.Now.ToString() + " : Paquete recibido en instalaciones para envío."); //Agrega evento al historial del paquete

                    try
                        {
                            hs.InsertarHash(pq); 
                            dgv_recepcion[7, i].Value = hs.Ui; //Si logró insertar actualiza el "estante" del dgv
                            dgv_recepcion[8, i].Value = hs.Uj; //Si logró insertar actualiza el "nivel" del dgv
                            pb_rec.PerformStep();
                        }
                    catch ( Exception ex)
                        {
                            descripcionError = ex.Message; 
                            error = true;
                            dgv_recepcion[7, i].Value = "x";
                            dgv_recepcion[8, i].Value = "x";
                            idActual--; //Reduce el ID, ya que no fue posible insertar
                        }    

                    
                }
            
            if(error) //Si alguna operacion resultó en error muestra el mensaje
                {
                    //Cambia colores
                    CloseButton.BackColor = MinimizeButton.BackColor = TituloForma.BackColor = TopBar.BackColor = Color.FromArgb(229, 115, 104); 
                    //TituloForma.ForeColor = Color.White;

                    //Muestra mensaje
                    CustomMsgBox.Mostrar(descripcionError);

                    //Regresa colores
                    CloseButton.BackColor = MinimizeButton.BackColor = TituloForma.BackColor = TopBar.BackColor = Color.FromArgb(16, 157, 89);
                    //TituloForma.ForeColor = Color.FromArgb(181, 181, 181);

                    error = false;
                }
                
                
            }

        private void button1_Click(object sender , EventArgs e)
            {
                //new Envios().Show();
            }

        private void TopBar_Click(object sender, EventArgs e)
        {

        }

        private void dgv_recepcion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //new SalidaCamiones().Show();
        }
    }
    }
