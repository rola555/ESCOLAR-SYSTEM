using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data.SqlClient;
using System.Data;

namespace Negocios
{
    public class N_ConsultaUsuario
    {
        //encapsular variable
        private D_ConsultaUsuarios objDato = new D_ConsultaUsuarios();

        private String _Username;
        private String _Password;

        public String Username
        {
            set { _Username = value; }
            get { return _Username; }

        }

        public String Password
        {
            set { _Password = value; }
            get { return _Password; }

        }

        //Constructor
        public N_ConsultaUsuario() { }


        //Funciones y Metodos
        public SqlDataReader IniciarSesion()
        {
            SqlDataReader Loguear;
            Loguear = objDato.inciarSesion(Username, Password);

            return Loguear;
        }





    }
}
