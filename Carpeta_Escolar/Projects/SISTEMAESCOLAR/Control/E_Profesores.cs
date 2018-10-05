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
    public class E_Profesores
    {

        #region Atributos
        private int _IdProfesor;
        private string _NombreProfesor;
        private string _ApellidoProfesor;
        private string _EspecialidadProfesor;
        private string _TelefonoProfesor;

       

        #endregion


        #region Constructor

        public E_Profesores()
        {

            IdProfesor = 0;
            NombreProfesor = string.Empty;
            ApellidoProfesor = string.Empty;
           EspecialidadProfesor = string.Empty;
            TelefonoProfesor = string.Empty;
          

        }

        #endregion


        //--------------------------------------------------------------------------//
        #region Encapsulamiento

 public int IdProfesor
        {
            get
            {
                return _IdProfesor;
            }

            set
            {
                _IdProfesor = value;
            }
        }
//-----------------------------------------------------------------------------------------
        public string NombreProfesor
        {
            get
            {
                return _NombreProfesor;
            }

            set
            {
                _NombreProfesor = value;
            }
        }
//------------------------------------------------------------------------------------------------------//
        public string ApellidoProfesor
        {
            get
            {
                return _ApellidoProfesor;
            }

            set
            {
                _ApellidoProfesor = value;
            }
        }
//--------------------------------------------------------------------------------------------//
        public string EspecialidadProfesor
        {
            get
            {
                return _EspecialidadProfesor;
            }

            set
            {
                _EspecialidadProfesor = value;
            }
        }
//-------------------------------------------------------------------------------------------------//
        public string TelefonoProfesor
        {
            get
            {
                return _TelefonoProfesor;
            }

            set
            {
                _TelefonoProfesor = value;
            }
        }

//-----------------------------------------------------------------------------------------//



        #endregion
    }
}
