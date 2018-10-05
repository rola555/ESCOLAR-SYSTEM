using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;
using Control;

namespace Datos
{
    public class D_ListarTablaProfesor
    {

        private D_ConexionBD Conexion = new D_ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable ListarProfesoress()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexio();
            Comando.CommandText = "ConcatenarProfesor";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

      
    }
}
