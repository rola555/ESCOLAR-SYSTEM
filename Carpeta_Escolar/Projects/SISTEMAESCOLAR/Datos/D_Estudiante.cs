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
    public class D_Estudiante: D_ConexionBD
    {

        public D_Estudiante() { }
  //------------------------------------------------------//
        public int abcEstudiante(string pAccion, E_Estudiante objE_Estudiante)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcEstudiante", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@Id_Estudiante", objE_Estudiante.Id_Estudiante);
            cmd.Parameters.AddWithValue("@Nombre", objE_Estudiante.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", objE_Estudiante.Apellido);
            cmd.Parameters.AddWithValue("@Genero", objE_Estudiante.Genero);
            cmd.Parameters.AddWithValue("@Fecha_Nacimiento", objE_Estudiante.Fecha_Nacimiento);
            cmd.Parameters.AddWithValue("@Direccion", objE_Estudiante.Direccion);
            cmd.Parameters.AddWithValue("@Tutor", objE_Estudiante.Tutor);
            cmd.Parameters.AddWithValue("@Tel_Tutor", objE_Estudiante.Tel_Tutor);

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
       
        public DataSet ListadoEstudiante()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[ListaEstudiante]";

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

        //-----------------------------------------------------------------//

        public DataSet SeleccionaEstudiante(int pIdEstudiante)
        {

            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Estudiante", pIdEstudiante);
                cmd.CommandText = "[dbo].[SeleccionEstudiante]";
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
