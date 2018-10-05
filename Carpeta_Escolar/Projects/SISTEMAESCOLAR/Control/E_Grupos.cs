using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class E_Grupos
    {

        #region Atributos

        private int _IdGrupo;
        private string _NombreGrupo;
        private string _ClaveGrupo;
        private int _IdEstudiante;
        private int _IdCurso;
        private int _IdAula;

       


        #endregion
        //----------------------------------------------------------------------------------------

        #region Constuctor
        public E_Grupos()
        {
            IdGrupo = 0;
            NombreGrupo = string.Empty;
            ClaveGrupo = string.Empty;
            IdEstudiante = 0;
            IdCurso = 0;
            IdAula = 0;


        }

        #endregion

        //-------------------------------------------------------------------------------------------------

        #region Encapsulamiento
 public int IdGrupo
        {
            get
            {
                return _IdGrupo;
            }

            set
            {
                _IdGrupo = value;
            }
        }
//_--------------------------------------------------------------------------------------------------------------
        public string NombreGrupo
        {
            get
            {
                return _NombreGrupo;
            }

            set
            {
                _NombreGrupo = value;
            }
        }
//--------------------------------------------------------------------------------------------------------------
        public string ClaveGrupo
        {
            get
            {
                return _ClaveGrupo;
            }

            set
            {
                _ClaveGrupo = value;
            }
        }
//_--------------------------------------------------------------------------------------------------------------
        public int IdEstudiante
        {
            get
            {
                return _IdEstudiante;
            }

            set
            {
                _IdEstudiante = value;
            }
        }
//-----------------------------------------------------------------------------------------------------------------------------
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
//----------------------------------------------------------------------------------------------------------------------
        public int IdAula
        {
            get
            {
                return _IdAula;
            }

            set
            {
                _IdAula = value;
            }
        }

        //-------------------------------------------------------------------------------------------------------



        #endregion

    }
}
