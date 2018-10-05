using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class E_Aula
    {
        #region Atributos

        private int _IdAula;
        private string _CodigoAula;
        private string _Edificio;
        private string _Nivel;
        private string _Descripcion;

       



        #endregion
        //-------------------------------------------------------------

        #region Constructor

        public E_Aula()
        {


            IdAula = 0;
            CodigoAula = string.Empty;
            Edificio = string.Empty;
            Nivel = string.Empty;
            Descripcion = string.Empty;

        }




        #endregion
        //-----------------------------------------------------------
        #region Encapsulamiento

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

        //---------------------------------------------------------------
        public string CodigoAula
        {
            get
            {
                return _CodigoAula;
            }

            set
            {
                _CodigoAula = value;
            }
        }
        //----------------------------------------------------------------------------


        public string Edificio
        {
            get
            {
                return _Edificio;
            }

            set
            {
                _Edificio = value;
            }
        }
       //-------------------------------------------------------------------------------
        public string Nivel
        {
            get
            {
                return _Nivel;
            }

            set
            {
                _Nivel = value;
            }
        }
      //-----------------------------------------------------------------------
        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                _Descripcion = value;
            }
        }

        //--------------------------------------------------------------------


        #endregion



    }
}
