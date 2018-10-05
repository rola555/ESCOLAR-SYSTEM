using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class D_ConsultaUsuarios
    {

        private D_ConexionBD Conexion = new D_ConexionBD();
        private SqlDataReader leer;

        public SqlDataReader inciarSesion(string username, string password)
        {

            string sql = "select *from UsuarioCuentas where username ='"+username+"' and Password ='"+password+"'";
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.AbrirConexio();
            comando.CommandText = sql;
            leer = comando.ExecuteReader();

            return leer;

        }

    }
}
