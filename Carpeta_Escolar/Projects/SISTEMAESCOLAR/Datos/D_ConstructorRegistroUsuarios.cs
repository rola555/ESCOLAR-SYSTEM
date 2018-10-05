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
    public class D_ConstructorRegistroUsuarios : D_ConexionBD
    {

        public D_ConstructorRegistroUsuarios() { }
  //------------------------------------------------------//
        public int abcUsuario(string pAccion, E_RegistrosUsuarios objE_Usuario)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcRegistrarUsuarios", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@IdUsuarioCuenta", objE_Usuario.IdUsuarioCuenta);
            cmd.Parameters.AddWithValue("@username", objE_Usuario.Username);
            cmd.Parameters.AddWithValue("@Password", objE_Usuario.Password);
            cmd.Parameters.AddWithValue("@Nombre", objE_Usuario.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", objE_Usuario.Apellido);
            cmd.Parameters.AddWithValue("@Correo", objE_Usuario.Correo);
            cmd.Parameters.AddWithValue("@TipoUsuario", objE_Usuario.TipoUsuario);
            

            try
            {
                AbrirConexion();
                Resultado = cmd.ExecuteNonQuery();

            }

            catch(Exception e)
            {
                throw new Exception("Error al procesar datos",e);
            }

            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return Resultado;
        }
//-------------------------------------------------------//
       
        public DataSet ListadoUsuarios()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[ListaRegistroUsuarios]";

                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch(Exception ex)
            {
                throw new Exception("Datos Estudiante", ex);


            }
            finally
            {

                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
            //-----------------------------------------------------------------//
        }

        public DataSet SeleccionaUsuario(int pIdUsuario)
        {

            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdUsuarioCuenta", pIdUsuario);
                cmd.CommandText = "[dbo].[SeleccionUsuario]";
                da.SelectCommand = cmd;
                da.Fill(ds);
                
            }
            catch(Exception ex)
            {
                throw new Exception("Datos Estudiante", ex);
            }
            finally
            {
                Conexion.Close();
                cmd.Dispose();

            }
            return ds;
        }

    }
}
