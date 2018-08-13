using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalv2
    {
    public class Paquete
        {

        public Paquete()
            { }

       public Paquete(int ID, double Peso, string Remitente, string Destinatario, string DireccionR, string DireccionD, DateTime FechaEnvio, int Estante = -1, int Nivel = -2, int Status = 0)
            {
                this.ID = ID;
                this.Peso = Peso;
                this.Remitente = Remitente;
                this.Destinatario = Destinatario;
                this.DireccionRemitente = DireccionR;
                this.DireccionDestinatario= DireccionD;
                this.FechaEnvio = FechaEnvio;
                this.Estante = Estante;
                this.Nivel = Nivel;
                this.Status = Status; //0 = En instalaciones para envio, 1 = ruta asignada, 2 = enví0 programado, 3 = Enviado, 4 = Llegó a instalaciones, 5 = ruta de reparto, 6 = Entregado, -1 = Error
                this.RutaAsignada = "-1";
            }


        private Stack<string> _Historial = new Stack<string>();

        public Stack<string> Historial
            {
            get { return _Historial; }
            set { _Historial = value; }
            }


        private string _RutaAsignada;
        
        public string RutaAsignada
            {
            get { return _RutaAsignada; }
            set { _RutaAsignada = value; }
            }


        private int _Status;

        public int Status
            {
            get { return _Status; }
            set { _Status = value; }
            }


        private int _Nivel;

        public int Nivel
            {
            get { return _Nivel; }
            set { _Nivel = value; }
            }


        private int _Estante;

        public int Estante
            {
            get { return _Estante; }
            set { _Estante = value; }
            }


        private int _ID;

        public int ID
            {
            get { return _ID; }
            set { _ID = value; }
            }


        private double _Peso;

        public double Peso
            {
            get { return _Peso; }
            set { _Peso = value; }
            }

        private string  _Remitente;

        public string  Remitente
            {
            get { return _Remitente; }
            set { _Remitente = value; }
            }

        private string _Destinatario;

        public string Destinatario
            {
            get { return _Destinatario; }
            set { _Destinatario = value; }
            }

        private string _DireccionRemitente;

        public string DireccionRemitente
            {
            get { return _DireccionRemitente; }
            set { _DireccionRemitente = value; }
            }

        private string _DireccionDestinatario;

        public string DireccionDestinatario
            {
            get { return _DireccionDestinatario; }
            set { _DireccionDestinatario = value; }
            }

        private DateTime _FechaEnvio;

        public DateTime FechaEnvio
            {
            get { return _FechaEnvio; }
            set { _FechaEnvio = value; }
            }

        //public IList<Paquete> Listar(int _ID, int _Peso, string _Remi, string _Desti, string _DirecR, 
        //            string _DirecD, DateTime _Fecha, int _Estante)
        //    {
        //        List<Paquete> Lista = new List<Paquete>();
        //        Paquete pq = new ProyectoFinalv2.Paquete(_ID, _Peso, _Remi, _Desti, _DirecR, _DirecD, _Fecha, _Estante);
        //        Lista.Add(pq);
        //        return Lista;
        //    }


        }
    }
