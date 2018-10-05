using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


using System.Data;
using System.Data.SqlClient;
using System.Configuration;


using Datos.DsTableAdapters;
using Control;
using Datos;


namespace Datos
{
   public class D_ConexionBD
    {
        
        public SqlConnection Conexion;

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
     
            //  D_ConexionBD principal  a bd
        public D_ConexionBD()
        {
           
            Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
          
            
        }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////        

     
            
        //Apertura original de conexion a BD solo se utliza para ingresar, borrar, modifcar datos.
        public void AbrirConexion() 
        {
            try
            {
                if (Conexion.State == ConnectionState.Broken || Conexion.State == ConnectionState.Closed)
                    Conexion.Open();

            }

            catch (Exception e)
            {
                throw new Exception("Error al abrir Conexion", e);

            }
            finally { }
             

        }

        public void CerrarConexion()
        {

            try
            {

                if (Conexion.State == ConnectionState.Open)
                    Conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al cerrar Conexion", e);

            }



        }




        /////////////////////////////////////////////////////////////////////////////////////////////////////////

      // Apertura secundaria se utiliza en login2 para abrir conexion Original
        public SqlConnection AbrirConexio()
        {

            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;


        }

       //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////7


    }

}
