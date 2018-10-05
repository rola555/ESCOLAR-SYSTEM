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
    public class D_Profesores: D_ConexionBD
    {


        public D_Profesores() { }


        public int abcProfesores(string pAccion, E_Profesores objE_Profesores)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcProfesores", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@IdProfesor", objE_Profesores.IdProfesor);
            cmd.Parameters.AddWithValue("@NombreProfesor", objE_Profesores.NombreProfesor);
            cmd.Parameters.AddWithValue("@ApellidoProfesor", objE_Profesores.ApellidoProfesor);
            cmd.Parameters.AddWithValue("@EspecialidadProfesor", objE_Profesores.EspecialidadProfesor);
            cmd.Parameters.AddWithValue("@TelefonoProfesor", objE_Profesores.TelefonoProfesor);
            

            try
            {
                AbrirConexion();
                Resultado = cmd.ExecuteNonQuery();

            }

            catch (Exception e)
            {
                throw new Exception("Error al procesar datos", e);
            }

            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        //------------------------------------------------------------------------------------------------------------------

        public DataSet ListadoProfesores()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[ListaProfesores]";

                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Datos Profesor", ex);


            }
            finally
            {

                Conexion.Close();
                cmd.Dispose();
            }
            return ds;

        }
        //--------------------------------------------------------------------------------------------------------

        public DataSet ListaNombreApellidoProfesor()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[Listanombreapellidoprofesor]";

                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Datos Profesor", ex);


            }
            finally
            {

                Conexion.Close();
                cmd.Dispose();
            }
            return ds;

        }

        //----------------------------------------------------------------------------------------------

        public DataSet SeleccionaProfesores(int pIdProfesor)
        {

            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdProfesor", pIdProfesor);
                cmd.CommandText = "[dbo].[SeleccionProfesor]";
                da.SelectCommand = cmd;
                da.Fill(ds);

            }
            catch (Exception ex)
            {
                throw new Exception("Datos Profesor", ex);
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
