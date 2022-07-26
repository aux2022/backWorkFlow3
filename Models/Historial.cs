using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_salidaActivos.Models
{
    public class historial
    {
        public int id_historial { get; set; }
        public int id_solicitud { get; set; }
        public string fecha { get; set; }
        public string mensajeHistorial { get; set; }


        public historial() { }


        public historial(
             int Id_Historial,
            int Id_solicitud,
        string Fecha,
            string MensajeHistorial
         )
        {

            id_historial = Id_Historial;
            id_solicitud = Id_solicitud;
            fecha = Fecha;
            mensajeHistorial = MensajeHistorial;
        }



        public historial(
          
          int Id_solicitud,
      string Fecha,
          string MensajeHistorial
       )
        {

           
            id_solicitud = Id_solicitud;
            fecha = Fecha;
            mensajeHistorial = MensajeHistorial;
        }

    }
}