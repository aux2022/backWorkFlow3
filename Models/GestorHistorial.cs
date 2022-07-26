using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace back_salidaActivos.Models
{
    public class GestorHistorial
    {
        public List<historial> GetHistorials()
        {
            List<historial> lista = new List<historial>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "historial_All";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    int id_solicitud = dr.GetInt32(1);
                    string fecha = dr.GetString(2).Trim();
                    string mensajeHistorial = dr.GetString(3).Trim();

      
                    historial Historial = new historial(id, id_solicitud, fecha, mensajeHistorial);

                    lista.Add(Historial);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }

        public List<historial> GetHistorialsById(int id2)
        {

            List<historial> lista = new List<historial>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from historial where id_historial =" + id2, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    int id_solicitud = dr.GetInt32(1);
                    string fecha = dr.GetString(2).Trim();
                    string mensajeHistorial = dr.GetString(3).Trim();


                    historial Historial = new historial(id, id_solicitud, fecha, mensajeHistorial);

                    lista.Add(Historial);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }




        public List<historial> GetHistorialsById2(int id3)
        {

            List<historial> lista = new List<historial>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select id_solicitud,fecha,mensajeHistorial from historial where id_solicitud =" + id3, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
   
                    int id_solicitud = dr.GetInt32(0);
                    string fecha = dr.GetString(1).Trim();
                    string mensajeHistorial = dr.GetString(2).Trim();


                    historial Historial = new historial(id_solicitud, id_solicitud, fecha, mensajeHistorial);

                    lista.Add(Historial);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }





    }
}