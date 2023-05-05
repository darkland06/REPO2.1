using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;

namespace datos
{


    public class ticketDB
    {
        string cadena = "server=localhost; user=root; database=loginn; password=123456789;";

        public ticked Autenticar(login login)
        {
            ticked user = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM login WHERE usuario = @usuario  AND contrasena = @contrasena;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@usuario", MySqlDbType.VarChar, 45).Value = login.usuario;
                        comando.Parameters.Add("@contrasena", MySqlDbType.VarChar, 45).Value = login.contrasena;

                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            user = new ticked();

                            user.fecha = Convert.ToDateTime(dr["fecha"]);
                            user.idTicked = dr["idTicket"].ToString();
                            user.usuario = dr["usuario"].ToString();
                            user.contrasena = dr["contrasena"].ToString();
                            user.nombreCliente = dr["nombreCliente"].ToString();
                            user.tipoSoporte = dr["tipoSoporte"].ToString();

                        }
                    }
                }
            }
            catch (System.Exception)
            {
            }
            return user;



        }
    }
}
