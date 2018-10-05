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
    public class N_Cursos
    {

        D_Cursos objNegocioCursos = new D_Cursos();
        

        //--------------------------------------------------------------------------

        public int abcCursos(string pAccion, E_Cursos objE_Cursos)
        {

            return objNegocioCursos.abcCursos(pAccion, objE_Cursos);
        }

        //--------------------------------------------------------------------------

        public DataSet ListadoCursos()
        {

            return objNegocioCursos.ListadoCursos();

        }
        //--------------------------------------------------------------------------------------
        

        //----------------------------------------------

        public DataSet SelecionaCursos(int pIdCursos)
        {
            return objNegocioCursos.SeleccionaCursos(pIdCursos);

        }


    }
}
