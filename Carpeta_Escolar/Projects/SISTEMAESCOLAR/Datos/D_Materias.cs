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
    public class D_Materias: D_ConexionBD
    {
        public D_Materias() { }


        //------------------------------------------------------//
        public int abcMaterias(string pAccion, E_Materias objE_Materias)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcMaterias", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@IdMateria", objE_Materias.IdMateria);
            cmd.Parameters.AddWithValue("@ClaveMateria", objE_Materias.ClaveMateria);
            cmd.Parameters.AddWithValue("@NombreMateria", objE_Materias.NombreMateria);
           
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

        public DataSet ListadoMaterias()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[ListaMaterias]";

                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Datos Materias", ex);


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

        public DataSet SeleccionaMaterias(int pIdMaterias)
        {

            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdMateria", pIdMaterias);
                cmd.CommandText = "[dbo].[SeleccionMateria]";
                da.SelectCommand = cmd;
                da.Fill(ds);

            }
            catch (Exception ex)
            {
                throw new Exception("Datos Materias", ex);
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
