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
    public class E_Materias
    {

        #region atributos

        private int _IdMateria;
        private string _ClaveMateria;
        private string _NombreMateria;

       


        #endregion

        //-------------------------------------------------------------

        #region Constructor
        public E_Materias()
        {

            IdMateria = 0;
            ClaveMateria = string.Empty;
            NombreMateria = string.Empty;

            
        }

        #endregion
        //--------------------------------------------------------------------------------------


        //----------0000000000000000000000000000000000000000000000000000000000000000000000000000000000000//
        #region Encapsulamiento

        public int IdMateria
        {
            get
            {
                return _IdMateria;
            }

            set
            {
                _IdMateria = value;
            }
        }
//---------000000000000000000000000000000000000000000000000000000000000000000000000000000000000//
        public string ClaveMateria
        {
            get
            {
                return _ClaveMateria;
            }

            set
            {
                _ClaveMateria = value;
            }
        }
//----------------------0000000000000000000000000000000000000000000000000000000000000000000//
        public string NombreMateria
        {
            get
            {
                return _NombreMateria;
            }

            set
            {
                _NombreMateria = value;
            }
        }

        //-----------------0000000000000000000000000000000000000000000000000099999999999999//



        #endregion

    }
}
