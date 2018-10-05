using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Datos;
using Control;

namespace Negocios
{
    public class N_Aula
    {

        D_Aula objNegocioAula = new D_Aula();
        //-----------------------------------------------------------------------------

        public int abcAulas(string pAccion, E_Aula objE_Aula)
        {

            return objNegocioAula.abcAulas(pAccion, objE_Aula);
        }

        //---------------------------------------------------------------------------

        public DataSet ListadoAulas()
        {

            return objNegocioAula.ListadoDeAulas();
            //--------------------"ListadoDeAulas();" es el metodo que se encuentra en la capa de datos de la clase "D_Aula".
        }

        //------------------------------------------------------------------------------

        public DataSet SelecionaAulas(int pIdAula)
        {
            return objNegocioAula.SeleccionaAulas(pIdAula);
            //--------------------"SeleccionaAulas();" es el metodo que se encuentra en la capa de datos de la clase "D_Aula".

        }

    }
}
