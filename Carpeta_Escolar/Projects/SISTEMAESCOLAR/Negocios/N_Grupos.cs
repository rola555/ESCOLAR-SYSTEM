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
    public class N_Grupos
    {
        D_Grupos objNegocioGrupos = new D_Grupos();

        //--------------------------------------------------------------------------------------

        public int abcGrupo(string pAccion, E_Grupos objE_Grupos)
        {

            return objNegocioGrupos.abcGrupos(pAccion, objE_Grupos);

        }

        //---------------------------------------------------------------------------------------

        public DataSet ListadoGrupo()
        {

            return objNegocioGrupos.ListadoGrupos();

        }
        //---------------------------------------------------------------------------------------


        public DataSet SelecionaGrupo(int pIdCursos)
        {
            return objNegocioGrupos.SeleccionaGrupos(pIdCursos);

        }

        //---------------------------------------------------------------------------------------

    }
}
