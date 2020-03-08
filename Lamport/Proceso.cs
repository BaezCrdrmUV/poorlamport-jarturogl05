using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamport
{
    public class Proceso
    {
        int Id { get; set; }
        int TimeStamp { get; set; }


        public Proceso(int id, int timeStamp)
        {
            this.Id = id;
            this.TimeStamp = timeStamp;
        }


        public string Enviar(Proceso procesoReceptor, Mensaje mensaje)
        {
            TimeStamp += 1;
            mensaje.Reloj = TimeStamp;
            string logEnviar = "El proceso #" + this.Id + " Envío " + "y su reloj es: " + TimeStamp + "\n";
            string logRecibir = procesoReceptor.Recibir(mensaje);
            return logEnviar + logRecibir;


        }


        public string Recibir(Mensaje mensaje)
        {
            int[] relojes = { TimeStamp, mensaje.Reloj };
            TimeStamp = relojes.Max() + 1;
            return "El proceso #" + this.Id + " Recibió " + "y su reloj es : " + TimeStamp + "\n" ;
        }

    }
}
