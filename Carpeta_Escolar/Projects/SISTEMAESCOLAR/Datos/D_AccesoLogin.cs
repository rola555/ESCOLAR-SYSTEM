using Datos.DsTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




using Datos;

namespace Datos
{
    public class D_AccesoLogin
    {


        public static UsuarioCuentas1TableAdapter adaptador = new UsuarioCuentas1TableAdapter();

       

       public static bool ComprobarLogin5(string username, string Password)
        {


           

            if (adaptador.ComprobarLogin5(username, Password) == null)
            {

                return false;
               
            }
            else
            {

                return true;

            }
        } 






    }



    }

