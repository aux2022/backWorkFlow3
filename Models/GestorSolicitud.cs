using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using EASendMail;


namespace back_salidaActivos.Models
{
    public class GestorSolicitud
    {
        public List<solicitud> GetSolicituds()
        {
            List<solicitud> lista = new List<solicitud>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "solicitud_All";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string solicitante = dr.GetString(1).Trim();
                    string correoSolicitante = dr.GetString(2).Trim();
                    string fechaSolicitud = dr.GetString(3).Trim();
                    string tipoTicket = dr.GetString(4).Trim();
                    string provedor = dr.GetString(5).Trim();
                    string motivo = dr.GetString(6).Trim();
                    string area = dr.GetString(7).Trim();
                    string descripcion = dr.GetString(8).Trim();
                    string observaciones = dr.GetString(9).Trim();
                    string regresa = dr.GetString(10).Trim();
                    string autorizador = dr.GetString(11).Trim();
                    string statusAprobacion = dr.GetString(12).Trim();
                    string comentariosAutorizador = dr.GetString(13).Trim();
                    string fechaSalida = dr.GetString(14).Trim();
                    string nombreProvedor = dr.GetString(15).Trim();
                    string validarSalida = dr.GetString(16).Trim();
                    string fechaCompromiso = dr.GetString(17).Trim();
                    string comentariosCompras = dr.GetString(18).Trim();
                    string historialCompras= dr.GetString(19).Trim();
                    string fechaRegreso = dr.GetString(20).Trim();
                    string comentariosRegreso = dr.GetString(21).Trim();
                    string status2 = dr.GetString(22).Trim();         
                    string emailSent = dr.GetString(23).Trim();

                    solicitud Solicitud = new solicitud(id, solicitante, correoSolicitante, fechaSolicitud, tipoTicket,provedor, motivo, area, descripcion, observaciones,regresa,autorizador,statusAprobacion,comentariosAutorizador,fechaSalida,
             nombreProvedor,validarSalida,fechaCompromiso,comentariosCompras,historialCompras,fechaRegreso,comentariosRegreso,status2,emailSent);

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }

        public List<solicitud> GetSolicitudsById(int id2)
        {

            List<solicitud> lista = new List<solicitud>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from solicitud where id_solicitud =" + id2, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string solicitante = dr.GetString(1).Trim();
                    string correoSolicitante = dr.GetString(2).Trim();
                    string fechaSolicitud = dr.GetString(3).Trim();
                    string tipoTicket = dr.GetString(4).Trim();
                    string provedor = dr.GetString(5).Trim();
                    string motivo = dr.GetString(6).Trim();
                    string area = dr.GetString(7).Trim();
                    string descripcion = dr.GetString(8).Trim();
                    string observaciones = dr.GetString(9).Trim();
                    string regresa = dr.GetString(10).Trim();
                    string autorizador = dr.GetString(11).Trim();
                    string statusAprobacion = dr.GetString(12).Trim();
                    string comentariosAutorizador = dr.GetString(13).Trim();
                    string fechaSalida = dr.GetString(14).Trim();
                    string nombreProvedor = dr.GetString(15).Trim();
                    string validarSalida = dr.GetString(16).Trim();
                    string fechaCompromiso = dr.GetString(17).Trim();
                    string comentariosCompras = dr.GetString(18).Trim();
                    string historialCompras = dr.GetString(19).Trim();
                    string fechaRegreso = dr.GetString(20).Trim();
                    string comentariosRegreso = dr.GetString(21).Trim();
                    string status2 = dr.GetString(22).Trim();
                    string emailSent = dr.GetString(23).Trim();

                    solicitud Solicitud = new solicitud(id, solicitante, correoSolicitante, fechaSolicitud,tipoTicket, provedor, motivo, area, descripcion, observaciones, regresa, autorizador, statusAprobacion, comentariosAutorizador, fechaSalida,
             nombreProvedor, validarSalida, fechaCompromiso, comentariosCompras, historialCompras,fechaRegreso, comentariosRegreso, status2, emailSent);

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }


        public bool addSolicitud(solicitud Solicitud)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "solicitud_Add";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@solicitante", Solicitud.solicitante);
                cmd.Parameters.AddWithValue("@fechaSolicitud", Solicitud.fechaSolicitud);
                cmd.Parameters.AddWithValue("@tipoTicket", Solicitud.tipoTicket);
                cmd.Parameters.AddWithValue("@provedor", Solicitud.provedor);
                cmd.Parameters.AddWithValue("@motivo", Solicitud.motivo);
                cmd.Parameters.AddWithValue("@area", Solicitud.area);
                cmd.Parameters.AddWithValue("@descripcion", Solicitud.descripcion);
                cmd.Parameters.AddWithValue("@observaciones", Solicitud.observaciones);
                cmd.Parameters.AddWithValue("@autorizador", Solicitud.autorizador);
                cmd.Parameters.AddWithValue("@statusAprobacion", Solicitud.statusAprobacion);
                cmd.Parameters.AddWithValue("@comentariosAutorizador", Solicitud.comentariosAutorizador);
                cmd.Parameters.AddWithValue("@fechaSalida", Solicitud.fechaSalida);
                cmd.Parameters.AddWithValue("@nombreProvedor", Solicitud.nombreProvedor);
                cmd.Parameters.AddWithValue("@comentariosCompras", Solicitud.comentariosCompras);
                cmd.Parameters.AddWithValue("@historialCompras", Solicitud.historialCompras);
                cmd.Parameters.AddWithValue("@fechaRegreso", Solicitud.fechaRegreso);
                cmd.Parameters.AddWithValue("@status2", Solicitud.status2);
                cmd.Parameters.AddWithValue("@regresa", Solicitud.regresa);
                cmd.Parameters.AddWithValue("@validarSalida", Solicitud.validarSalida);
                cmd.Parameters.AddWithValue("@fechaCompromiso", Solicitud.fechaCompromiso);
                cmd.Parameters.AddWithValue("@comentariosRegreso", Solicitud.comentariosRegreso);
                cmd.Parameters.AddWithValue("@correoSolicitante", Solicitud.correoSolicitante);
                cmd.Parameters.AddWithValue("@emailSent", Solicitud.emailSent);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    res = true;
            
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    res = false;
                    throw;
                }
                finally
                {
                    cmd.Parameters.Clear();
                    conn.Close();
                }
                return res;
            }


        }

        public string EnviarCorreo(string mensajeCorreo)
        {


            Console.Write("Hola Mundo Sobre Linea 1");
            string mensaje = "Error al enviar correo.";

            try
            {
                Console.Write("Hola Mundo Sobre Linea 2");
                SmtpMail objetoCorreo = new SmtpMail("TryIt");

                objetoCorreo.From = "aux_ti@bioflex.mx";
                objetoCorreo.To = "randyfull8@gmail.com";
                objetoCorreo.Subject = "Nueva Solicitud Salida De Activo";
                objetoCorreo.TextBody = mensajeCorreo;

                SmtpServer objetoServidor = new SmtpServer("smtp.gmail.com");

                objetoServidor.User = "aux_ti@bioflex.mx";
                objetoServidor.Password = "2022BioA";
                objetoServidor.Port = 587;
                objetoServidor.ConnectType = SmtpConnectType.ConnectSSLAuto;

                SmtpClient objetoCliente = new SmtpClient();
                objetoCliente.SendMail(objetoServidor, objetoCorreo);
                mensaje = "Correo Enviado Correctamente.";


            }
            catch (Exception ex)
            {
                Console.Write("Hola Mundo Sobre Linea 4");
                mensaje = "Error al enviar correo." + ex.Message;
            }
            return mensaje;
        }


        //
        public bool updateSolicitud(int id, solicitud Solicitud)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "solicitud_Update";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Solicitud", id);
                cmd.Parameters.AddWithValue("@solicitante", Solicitud.solicitante);
                cmd.Parameters.AddWithValue("@fechaSolicitud", Solicitud.fechaSolicitud);
                cmd.Parameters.AddWithValue("@tipoTicket", Solicitud.tipoTicket);
                cmd.Parameters.AddWithValue("@provedor", Solicitud.provedor);
                cmd.Parameters.AddWithValue("@motivo", Solicitud.motivo);
                cmd.Parameters.AddWithValue("@area", Solicitud.area);
                cmd.Parameters.AddWithValue("@descripcion", Solicitud.descripcion);
                cmd.Parameters.AddWithValue("@observaciones", Solicitud.observaciones);
                cmd.Parameters.AddWithValue("@autorizador", Solicitud.autorizador);
                cmd.Parameters.AddWithValue("@statusAprobacion", Solicitud.statusAprobacion);
                cmd.Parameters.AddWithValue("@comentariosAutorizador", Solicitud.comentariosAutorizador);
                cmd.Parameters.AddWithValue("@fechaSalida", Solicitud.fechaSalida);
                cmd.Parameters.AddWithValue("@nombreProvedor", Solicitud.nombreProvedor);
                cmd.Parameters.AddWithValue("@comentariosCompras", Solicitud.comentariosCompras);
                cmd.Parameters.AddWithValue("@historialCompras", Solicitud.historialCompras);
                cmd.Parameters.AddWithValue("@fechaRegreso", Solicitud.fechaRegreso);
                cmd.Parameters.AddWithValue("@status2", Solicitud.status2);
                cmd.Parameters.AddWithValue("@regresa", Solicitud.regresa);
                cmd.Parameters.AddWithValue("@validarSalida", Solicitud.validarSalida);
                cmd.Parameters.AddWithValue("@fechaCompromiso", Solicitud.fechaCompromiso);
                cmd.Parameters.AddWithValue("@comentariosRegreso", Solicitud.comentariosRegreso);
                cmd.Parameters.AddWithValue("@correoSolicitante", Solicitud.correoSolicitante);
                cmd.Parameters.AddWithValue("@emailSent", Solicitud.emailSent);
                //

                //
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    res = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    res = false;
                    throw;
                }
                finally
                {
                    cmd.Parameters.Clear();
                    conn.Close();
                }
                return res;
            }


        }

        public bool deleteSolicitud(int id)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "solicitud_Delete";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_solicitud", id);

                //

                //
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    res = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    res = false;
                    throw;
                }
                finally
                {
                    cmd.Parameters.Clear();
                    conn.Close();
                }
                return res;
            }


        }
        //
    }
}