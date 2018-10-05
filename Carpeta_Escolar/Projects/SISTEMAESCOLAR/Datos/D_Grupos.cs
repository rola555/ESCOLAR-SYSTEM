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
    public class D_Grupos: D_ConexionBD
    {

        public D_Grupos() { }


        public int abcGrupos(string pAccion, E_Grupos objE_Grupos)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcGrupos", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@IdGrupo", objE_Grupos.IdGrupo);
            cmd.Parameters.AddWithValue("@NombreGrupo", objE_Grupos.NombreGrupo);
            cmd.Parameters.AddWithValue("@ClaveGrupo", objE_Grupos.ClaveGrupo);
            cmd.Parameters.AddWithValue("@IdEstudiante", objE_Grupos.IdEstudiante);
            cmd.Parameters.AddWithValue("@IdCurso", objE_Grupos.IdCurso);
            cmd.Parameters.AddWithValue("@IdAula", objE_Grupos.IdAula);



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

        public DataSet ListadoGrupos()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "[dbo].[ListarGruposPeronalizado]";

                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Datos de Grupos", ex);


            }
            finally
            {

                Conexion.Close();
                cmd.Dispose();
            }
            return ds;

        }

        //-----------------------------------------------------------------//

        public DataSet SeleccionaGrupos(int pIdGrupos)
        {

            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdGrupo", pIdGrupos);
                cmd.CommandText = "[dbo].[SeleccionGrupos]";
                da.SelectCommand = cmd;
                da.Fill(ds);

            }
            catch (Exception ex)
            {
                throw new Exception("Datos de Grupo", ex);
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
