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
    public class E_Estudiante
    {
        #region Atributos
        private int _Id_Estudiante;
        private string _Nombre;
        private string _Apellido;
        private string _Genero;
        private string _Fecha_Nacimiento;
        private string _Direccion;
        private string _Tutor;
        private string _Tel_Tutor;




        #endregion



        #region Constructor

        public E_Estudiante()
        {

            Id_Estudiante = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Genero = string.Empty;
            Fecha_Nacimiento = string.Empty;
            Direccion = string.Empty;
            Tutor = string.Empty;
            Tel_Tutor = string.Empty;





        }

        #endregion

        #region Encapsulamiento
        //-------------------------------------------------//
        public int Id_Estudiante
        {
            get
            {
                return _Id_Estudiante;
            }

            set
            {
                _Id_Estudiante = value;
            }
        }
        //-------------------------------------------------//
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
        //-------------------------------------------------//
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
        //-------------------------------------------------//
        public string Genero
        {
            get
            {
                return _Genero;
            }

            set
            {
                _Genero = value;
            }
        }
        //----------------------------------------------------
        public string Fecha_Nacimiento
        {
            get
            {
                return _Fecha_Nacimiento;
            }

            set
            {
                _Fecha_Nacimiento = value;
            }
        }
        //----------------------------------------------------------
        public string Direccion
        {
            get
            {
                return _Direccion;
            }

            set
            {
                _Direccion = value;
            }
        }
        //---------------------------------------------------
        public string Tutor
        {
            get
            {
                return _Tutor;
            }

            set
            {
                _Tutor = value;
            }
        }
        //-------------------------------------------
        public string Tel_Tutor
        {
            get
            {
                return _Tel_Tutor;
            }

            set
            {
                _Tel_Tutor = value;
            }
        }

        //-------------------------------------------------//

        #endregion
    }
}
