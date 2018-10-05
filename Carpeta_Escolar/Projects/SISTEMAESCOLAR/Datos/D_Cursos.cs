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
    public class D_Cursos: D_ConexionBD
    {

        public D_Cursos() { }


        public int abcCursos(string pAccion, E_Cursos objE_Cursos)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcCursos", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@IdCurso", objE_Cursos.IdCurso);
            cmd.Parameters.AddWithValue("@NombreCurso", objE_Cursos.NombreCurso);
            cmd.Parameters.AddWithValue("@Hora", objE_Cursos.Hora);
            cmd.Parameters.AddWithValue("@FMateria", objE_Cursos.FMateria);
            cmd.Parameters.AddWithValue("@FProfesor", objE_Cursos.FProfesor);

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
        //-------------------------------------------------------//
        public DataSet ListadoCursos()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.CommandText = "[dbo].[ListarCursosPeronalizado]";

                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Datos de Curso", ex);


            }
            finally
            {

                Conexion.Close();
                cmd.Dispose();
            }
            return ds;

        }

        //-----------------------------------------------------------------//
        //-----------------------------------------------------------------//

       

        public DataSet SeleccionaCursos(int pIdCursos)
        {

            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdCurso", pIdCursos);
                cmd.CommandText = "[dbo].[SeleccionCursos]";
                da.SelectCommand = cmd;
                da.Fill(ds);

            }
            catch (Exception ex)
            {
                throw new Exception("Datos de Curso", ex);
            }
            finally
            {
                Conexion.Close();
                cmd.Dispose();

            }
            return ds;
        }
//--------------------------------------------------------------------------------------------


    }
}
