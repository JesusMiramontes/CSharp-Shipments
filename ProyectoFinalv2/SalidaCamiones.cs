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
    public partial class SalidaCamiones : Form
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


        //List<Paquete> ColaALista = new List<Paquete>();

        public static void ToDgv(DataGridView dgv, List<Paquete> lista)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgv.Rows.Add(false, lista[i].RutaAsignada.ToString(), lista[i].ID, lista[i].Peso, lista[i].DireccionDestinatario);
            }
        }

        public SalidaCamiones()
            {
                InitializeComponent();
                try
                {
                    ToDgv(dgv_cola, Master.PaquetesFueraAlmacen);
                }
                catch (Exception)
                {

                }
        }

        private void dgv_recepcion_CellContentClick(object sender , DataGridViewCellEventArgs e)
            {

            }

        private void btnRecargarClick(object sender , EventArgs e)
            {
                ToDgv(dgv_cola, Master.PaquetesFueraAlmacen);
            }

        private void dgv_cola_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEnviar_cola_Click(object sender, EventArgs e)
        {

            //Progressbar
            try //Si no se tiene ningun valor y se presiona finalizar el maximum de progressbar = 10
            {
                pb_cola.Maximum = dgv_cola.RowCount;
            }
            catch (Exception)
            {
                pb_cola.Maximum = 10;
            }
            bool perfomstep = false; //Variable que verifica qe almenos se haya realizado una accion.

            for (int i = 0; i < dgv_cola.RowCount; i++)
            {
                if (Convert.ToBoolean(dgv_cola[0, i].Value))
                {
                    perfomstep = true; //Se ejecutó una acción.
                    dgv_cola[1, i].Value = false; //Borra el check.

                    int id = Convert.ToInt32(dgv_cola[2, i].Value); //Toma el id de paquete del dgv
                    int LugarEncontrado = BusquedaYasignacion.Binaria(id); //Busca la posicion del id en la lista

                    //Le asigna la ruta al paquete (propiedad).
                    Master.PaquetesFueraAlmacen[LugarEncontrado].Status = 3;

                    //Mandarlo a PaqutesAntiguos
                    Master.PaquetesAntiguos.Add(Master.PaquetesFueraAlmacen[LugarEncontrado]);

                    //Borrarlo de lista Fuera de almacen
                    Master.PaquetesFueraAlmacen.RemoveAt(LugarEncontrado);
                }
                if (perfomstep)
                    pb_cola.PerformStep();
            }

            if (perfomstep)
            {
                pb_cola.Value = pb_cola.Maximum;
                Master.ColaACamiones = new Queue<Paquete>();
                for (int i = Master.PaquetesFueraAlmacen.Count -1 ; i >= 0; i--)
                {
                    Master.ColaACamiones.Enqueue(Master.PaquetesFueraAlmacen[i]);
                }

                //Carga de nuevo info a gdv
                try
                {
                    ToDgv(dgv_cola, Master.PaquetesFueraAlmacen);
                }
                catch (Exception)
                {

                }

            }

        }

        private void dgv_cola_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Paquete pq = new Paquete();
                int row = Convert.ToInt32(dgv_cola.CurrentRow.Index);
                int id = Convert.ToInt32(dgv_cola[2, row].Value);
                pq = Master.PaquetesFueraAlmacen[BusquedaYasignacion.Binaria(id)];

                rec_id.Text = pq.ID.ToString(); ;
                rec_destinatario.Text = pq.Destinatario;
                rec_direccionD.Text = pq.DireccionDestinatario;
                rec_direccionR.Text = pq.DireccionRemitente;
                rec_fechaE.Text = pq.FechaEnvio.ToShortDateString();
                rec_peso.Text = pq.Peso.ToString();
                rec_remitente.Text = pq.Remitente;
            }
            catch (Exception)
            {

                //throw;
            }

        }
    }
    }
