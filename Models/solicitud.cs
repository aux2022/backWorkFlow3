using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_salidaActivos.Models
{
    public class solicitud
    {
        public int id_solicitud { get; set; }
        public string solicitante { get; set; }
        public string fechaSolicitud { get; set; }

        public string tipoTicket{ get; set; }
        public string provedor { get; set; }

        public string motivo { get; set; }

        public string area { get; set; }
        public string descripcion { get; set; }
        public string observaciones { get; set; }

        public string autorizador { get; set; }

        public string statusAprobacion { get; set; }
        public string comentariosAutorizador { get; set; }

        public string fechaSalida { get; set; }

        public string nombreProvedor { get; set; }
        public string comentariosCompras { get; set; }

        public string historialCompras { get; set; }

        public string fechaRegreso { get; set; }
        public string status2 { get; set; }

        public string regresa { get; set; }
        public string validarSalida { get; set; }
        public string fechaCompromiso { get; set; }
        public string comentariosRegreso { get; set; }

        public string correoSolicitante { get; set; }

        public string emailSent { get; set; }



        public solicitud() { }

        public solicitud(
             int Id_solicitud,
         string Solicitante,
             string CorreoSolicitante,
             string FechaSolicitud,
             string TipoTicket,
            string Provedor,
            string Motivo,
             string Area,
            string Descripcion,
            string Observaciones,
            string Regresa,
             string Autorizador,
            string StatusAprobacion,
            string ComentariosAutorizador,
            string FechaSalida,
             string NombreProvedor,
            string ValidarSalida,
             string FechaCompromiso,
             string ComentariosCompras,
             string HistorialCompras,
            string FechaRegreso,
            string ComentariosRegreso,
             string Status2,
            string EmailSent)
        {
            id_solicitud = Id_solicitud;
            solicitante = Solicitante;
            correoSolicitante = CorreoSolicitante;
            fechaSolicitud = FechaSolicitud;
            tipoTicket = TipoTicket;
            provedor = Provedor;
            motivo = Motivo;
            area = Area;
            descripcion = Descripcion;
            observaciones = Observaciones;
            regresa = Regresa;
            autorizador = Autorizador;
            statusAprobacion = StatusAprobacion;
            comentariosAutorizador = ComentariosAutorizador;
            fechaSalida = FechaSalida;
            nombreProvedor = NombreProvedor;
            validarSalida = ValidarSalida;
            fechaCompromiso = FechaCompromiso;
            comentariosCompras = ComentariosCompras;
            historialCompras = HistorialCompras;
            fechaRegreso = FechaRegreso;
            comentariosRegreso = ComentariosRegreso;
            status2 = Status2;
            emailSent = EmailSent;


        }



        public solicitud(string Solicitante,
             string CorreoSolicitante,
             string FechaSolicitud,
             string TipoTicket,
            string Provedor,
            string Motivo,
     
             string Area,
            string Descripcion,
            string Observaciones,
            string Regresa,
             string Autorizador,
            string StatusAprobacion,
            string ComentariosAutorizador,
            string FechaSalida,
             string NombreProvedor,
            string ValidarSalida,
             string FechaCompromiso,
             string ComentariosCompras,
             string HistorialCompras,
            string FechaRegreso,
            string ComentariosRegreso,
             string Status2,
            string EmailSent)
        {

            solicitante = Solicitante;
            correoSolicitante = CorreoSolicitante;
            fechaSolicitud = FechaSolicitud;
            tipoTicket = TipoTicket;
            provedor = Provedor;
            motivo = Motivo;
            area = Area;
            descripcion = Descripcion;
            observaciones = Observaciones;
            regresa = Regresa;
            autorizador= Autorizador;
            statusAprobacion= StatusAprobacion;
            comentariosAutorizador = ComentariosAutorizador;
            fechaSalida = FechaSalida;
            nombreProvedor = NombreProvedor;
            validarSalida = ValidarSalida;
            fechaCompromiso = FechaCompromiso;
            comentariosCompras = ComentariosCompras;
            historialCompras = HistorialCompras;
            fechaRegreso = FechaRegreso;
            comentariosRegreso = ComentariosRegreso;
            status2 = Status2;
            emailSent = EmailSent;
        }




    }
}



