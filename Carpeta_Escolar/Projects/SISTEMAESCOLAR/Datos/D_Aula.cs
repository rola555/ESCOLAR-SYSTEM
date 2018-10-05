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
    public class D_Aula: D_ConexionBD
    {

        public D_Aula() { }

        //-----------------------------------------------------------------------------

        public int abcAulas(string pAccion, E_Aula objE_Aula)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcAula", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@IdAula", objE_Aula.IdAula);
            cmd.Parameters.AddWithValue("@CodigoAula", objE_Aula.CodigoAula);
            cmd.Parameters.AddWithValue("@Edificio", objE_Aula.Edificio);
            cmd.Parameters.AddWithValue("@Nivel", objE_Aula.Nivel);
            cmd.Parameters.AddWithValue("@Descripcion", objE_Aula.Descripcion);


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

        //------------------------------------------------------------------------------
        public DataSet ListadoDeAulas()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[ListaAulas]";

                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Datos De Aulas", ex);


            }
            finally
            {

                Conexion.Close();
                cmd.Dispose();
            }
            return ds;

        }

        //-----------------------------------------------------------------//

        public DataSet SeleccionaAulas(int pIdAulas)
        {

            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdAula", pIdAulas);
                cmd.CommandText = "[dbo].[SeleccionAulas]";
                da.SelectCommand = cmd;
                da.Fill(ds);

            }
            catch (Exception ex)
            {
                throw new Exception("Datos De Aulas", ex);
            }
            finally
            {
                Conexion.Close();
                cmd.Dispose();

            }
            return ds;
        }
        //-----------------------------------------------------------------------------------------
    }
}
