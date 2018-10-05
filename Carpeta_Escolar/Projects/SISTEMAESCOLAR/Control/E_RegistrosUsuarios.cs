using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Control;

namespace Control
{
    public class E_RegistrosUsuarios
    {
        #region Atributos
        private int _IdUsuarioCuenta;
        private string _username;
        private string _Password;
        private string _Nombre;
        private string _Apellido;
        private string _Correo;
        private string _TipoUsuario;


    





    #endregion



    #region Constructor

    public E_RegistrosUsuarios()
    {

        _IdUsuarioCuenta = 0;
        Username = string.Empty;
        Password = string.Empty;
        Nombre = string.Empty;
        Apellido = string.Empty;
        Correo = string.Empty;
        TipoUsuario = string.Empty;






    }

    #endregion

    #region Encapsulamiento
    //-------------------------------------------------//
    public int IdUsuarioCuenta
    {
        get
        {
            return _IdUsuarioCuenta;
        }

        set
        {
            _IdUsuarioCuenta = value;
        }
    }
//-------------------------------------------------------------
        public string Username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
            }
        }
//------------------------------------------------------------------
        public string Password
        {
            get
            {
                return _Password;
            }

            set
            {
                _Password = value;
            }
        }
//--------------------------------------------------------------
        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }
//-----------------------------------------------------------------
        public string Apellido
        {
            get
            {
                return _Apellido;
            }

            set
            {
                _Apellido = value;
            }
        }
//-----------------------------------------------------------------
        public string Correo
        {
            get
            {
                return _Correo;
            }

            set
            {
                _Correo = value;
            }
        }
//--------------------------------------------------------------
        public string TipoUsuario
        {
            get
            {
                return _TipoUsuario;
            }

            set
            {
                _TipoUsuario = value;
            }
        }
        //-----------------------------------------------


        #endregion

    }
}
