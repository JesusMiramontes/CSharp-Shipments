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
    public partial class Master : Form
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
        {
            this.Close();
            if (!advertenciacerrar)
            {
                CustomMsgBox.Mostrar("Antes de que te vayas...", "Asegurate de guardar la información antes de salir, de lo contrario los cambios pueden perderse. ");
                advertenciacerrar = true;
            }
            else if (advertenciacerrar)
                this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e) //Boton que minimiza la forma
        { this.WindowState = FormWindowState.Minimized; }

        //--------------- FIN BOTONES FORMA ---------------


        bool advertenciacerrar = false;

        //Arreglo de paquetes (Estantes).
        public static Paquete[,] Paquetes = new Paquete[10, 10];

        //Cola de paquetes que deben agregarse a camón.
        public static Queue<Paquete> ColaACamiones = new Queue<Paquete>();

        //Paquetes antiguos que ya salieron de instalaciones de envío.
        public static List<Paquete> PaquetesAntiguos = new List<Paquete>();

        //Paquetes atiguos que ya salieron de instalaciones de envio.
        public static List<Paquete> PaquetesFueraAlmacen = new List<Paquete>();

        public Master()
            {
            InitializeComponent();

            //Inicializa los paquetes en el arreglo de paquetes para evitar null
            for (int i = 0; i < Master.Paquetes.GetLength(0); i++)
            {
                for (int j = 0; j < Master.Paquetes.GetLength(1); j++)
                {
                    Master.Paquetes[i, j] = new Paquete();
                }
            }

        }

        private void panelIngresoDatos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_recepcion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnRecepcion_Click(object sender, EventArgs e)
        {
            new Form0().Show();
        }

        private void btnEnvios_Click(object sender, EventArgs e)
        {
            new Envios().Show();
        }

        private void btnCamiones_Click(object sender, EventArgs e)
        {
            new SalidaCamiones().Show();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            new Historial().Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void Master_Load(object sender, EventArgs e)
        {

        }
    }
    }
