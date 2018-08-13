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
    public partial class Historial : Form
        {

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
            if (mouseDown)
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

        BusquedaYasignacion hs = new BusquedaYasignacion();
        Paquete pq = new Paquete();
        bool Encontrado = false;
        bool EncontradoEnAntiguos = false;
        bool EncontradoEnAlmacen = false, EncontradoEnCola = false;
        int[] cords = new int[] {-1, -1 };
        int cordEnLista = -1;
        int cordEnAntiguos = -1;

        public Historial()
            {
            InitializeComponent();
            }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_hist_Click(object sender, EventArgs e)
        {
            //Limpia forma
            //id_hist.Clear();
            peso_hist.Clear();
            remitente_hist.Clear();
            destinatario_hist.Clear();
            direccionD_hist.Clear();
            direccionR_hist.Clear();
            fechaE_hist.Clear();
            LbShowStatus_hist.Visible = false;
            lbError_hist.Visible = false;
            lbCheck1_hist.Visible = lbCheck2_hist.Visible = lbCheck3_hist.Visible = lbCheck4_hist.Visible = lbCheck5_hist.Visible = false;
            Step1.Visible = Step2.Visible = Step3.Visible = Step4.Visible = Step5.Visible = false;
            Porcentaje_hist.Size = new Size(0, 0);

            //Paquete auxiliar
            pq = new Paquete();
            Encontrado = false;
            EncontradoEnAlmacen = EncontradoEnCola = false;
            cords = new int[] {-1, -1 };
            cordEnLista = -1;
            cordEnAntiguos = -1;

            try
            {
                //Busca el paquete en almacen y regresa Estante y nivel
                cords = hs.MostrarHash(int.Parse(id_hist.Text));
                Encontrado = true;
                EncontradoEnAlmacen = true;
            }
            catch (Exception )
            {

                try
                    {
                        //Si no lo encontró en estantes busca en cola para camion
                        cordEnLista = BusquedaYasignacion.Binaria(int.Parse(id_hist.Text));
                        Encontrado = true;
                        EncontradoEnCola = true;
                    }
                catch ( Exception ex)
                    {
                        //Si no lo encontró en cola busca en antiguos
                        try
                        {
                            cordEnAntiguos = BusquedaYasignacion.Binaria(int.Parse(id_hist.Text), Master.PaquetesAntiguos);
                            EncontradoEnAntiguos = Encontrado = true;
                        }
                        catch (Exception)
                        {
                            CustomMsgBox.Mostrar(ex.Message);
                            lbError_hist.Visible = true;
                            //throw;
                        }
                        
                    }

                
            }

            if(Encontrado)
                {

                //Si lo encontró copia el paquete al aux
                if(EncontradoEnAlmacen)
                    pq = Master.Paquetes[cords[0], cords[1]];
                else if(EncontradoEnCola)
                    pq = Master.PaquetesFueraAlmacen[cordEnLista];
                else if (EncontradoEnAntiguos)
                    pq = Master.PaquetesAntiguos[cordEnAntiguos];

                //Actualiza campos para mostrar información.
                id_hist.Text = pq.ID.ToString();
                peso_hist.Text = pq.Peso.ToString();
                remitente_hist.Text = pq.Remitente;
                destinatario_hist.Text = pq.Destinatario;
                direccionR_hist.Text = pq.DireccionRemitente;
                direccionD_hist.Text = pq.DireccionDestinatario;
                fechaE_hist.Text = pq.FechaEnvio.ToShortDateString();
                LbShowStatus_hist.Visible = true;

                string MostrarEstado = ""; //Variable usada para mostrar el texto en pantalla

                switch (pq.Status) //Dependiendo del status del paquete cambia el tamaño de la barra y muestra las etapas.
                {
                    case 0:
                        cbStatus_hist.Text = MostrarEstado = "Recibido";
                        Step1.Visible = lbCheck1_hist.Visible = true;
                        Porcentaje_hist.Visible = true;
                        Porcentaje_hist.Size = new Size(56, 18);
                        break;
                    case 1:
                        cbStatus_hist.Text = MostrarEstado = "Asignado";
                        Step1.Visible = lbCheck1_hist.Visible = true;
                        Porcentaje_hist.Visible = true;
                        Porcentaje_hist.Size = new Size(56, 18);
                        break;
                    case 2:
                        cbStatus_hist.Text = MostrarEstado = "Programado";
                        Step1.Visible = lbCheck1_hist.Visible = true;
                        Porcentaje_hist.Visible = true;
                        Porcentaje_hist.Size = new Size(56, 18);
                        break;
                    case 3:
                        cbStatus_hist.Text = MostrarEstado = "Enviado";
                        Step1.Visible = lbCheck1_hist.Visible = true;
                        Step2.Visible = lbCheck2_hist.Visible = true;
                        Porcentaje_hist.Visible = true;
                        Porcentaje_hist.Size = new Size(179, 18);
                        break;
                    case 4:
                        cbStatus_hist.Text = MostrarEstado = "En ciudad";
                        Step1.Visible = lbCheck1_hist.Visible = true;
                        Step2.Visible = lbCheck2_hist.Visible = true;
                        Step3.Visible = lbCheck3_hist.Visible = true;
                        Porcentaje_hist.Visible = true;
                        Porcentaje_hist.Size = new Size(287, 18);
                        break;
                    case 5:
                        cbStatus_hist.Text = MostrarEstado = "Reparto";
                        Step1.Visible = lbCheck1_hist.Visible = true;
                        Step2.Visible = lbCheck2_hist.Visible = true;
                        Step3.Visible = lbCheck3_hist.Visible = true;
                        Step4.Visible = lbCheck4_hist.Visible = true;
                        Porcentaje_hist.Visible = true;
                        Porcentaje_hist.Size = new Size(403, 18);
                        break;
                    case 6:
                        cbStatus_hist.Text = MostrarEstado = "Entregado";
                        Step1.Visible = lbCheck1_hist.Visible = true;
                        Step2.Visible = lbCheck2_hist.Visible = true;
                        Step3.Visible = lbCheck3_hist.Visible = true;
                        Step4.Visible = lbCheck4_hist.Visible = true;
                        Step5.Visible = lbCheck5_hist.Visible = true;
                        Porcentaje_hist.Visible = true;
                        Porcentaje_hist.Size = new Size(519, 18);
                        break;
                    case -1:
                        LbShowStatus_hist.Visible = false;
                        cbStatus_hist.Text = "Error";
                        lbError_hist.Text = "Error entrega";
                        lbError_hist.Visible = true;
                        break;
                    default:
                        break;
                }

                LbShowStatus_hist.Text = MostrarEstado; //Muestra el estado en pantalla.

                Stack<String> auxPila = pq.Historial; //Copia la pila del historial a una lista.

                LbHistorial_hist.DataSource = auxPila.ToList<string>(); //Muestra el historial en ListBox   


                }

        }

        private void Historial_Load(object sender, EventArgs e)
        {

        }

        private void btnCambiar_hist_Click(object sender , EventArgs e)
            {
                if(cbStatus_hist.SelectedIndex != 3)
                    pq.Status = cbStatus_hist.SelectedIndex + 4;
                if(cbStatus_hist.SelectedIndex == 3)
                    pq.Status = -1;
                pq.Historial.Push(DateTime.Now.ToString() + " : " + cbStatus_hist.Text);
            }

        }
    }
