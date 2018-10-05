using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class E_Cursos
    {

        #region Atributos

        private int _IdCurso;
        private string _NombreCurso;
        private string _Hora;
        private int _FMateria;
        private int _FProfesor;
        private string _ApellidoProfesor;





        #endregion

        //-------------------------------------------------------------------------------------

        #region Constuctor

        public E_Cursos()
        {

            IdCurso = 0;
            NombreCurso = string.Empty;
            Hora = string.Empty;
            FMateria = 0;
            FProfesor = 0;
            ApellidoProfesor = string.Empty;
                ;

           
        }

        #endregion

        //-------------------------------------------------------------------------------------
//-----------///////////////////////////////////////////////////////////////////////////////////////////////7

        #region Encapsulamiento

 public int IdCurso
        {
            get
            {
                return _IdCurso;
            }

            set
            {
                _IdCurso = value;
            }
        }
        //---------------------------------------------------------------------------------------------
        public string NombreCurso
        {
            get
            {
                return _NombreCurso;
            }

            set
            {
                _NombreCurso = value;
            }
        }
//------------------------------------------------------------------------------------------------------
        public string Hora
        {
            get
            {
                return _Hora;
            }

            set
            {
                _Hora = value;
            }
        }
//---------------------------------------------------------------------------------
        public int FMateria
        {
            get
            {
                return _FMateria;
            }

            set
            {
                _FMateria = value;
            }
        }
//----------------------------------------------------------------------------------------------------
        public int FProfesor
        {
            get
            {
                return _FProfesor;
            }

            set
            {
                _FProfesor = value;
            }
        }

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

        //----------------------------------------------------------------------------------


        #endregion

    }
}
