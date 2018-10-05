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
    public class N_Materias
    {

        D_Materias objNegocioMaterias = new D_Materias();


       //--------------------------------------------------------------------------
        public int abcMaterias(string pAccion, E_Materias objE_Materias)
        {

            return objNegocioMaterias.abcMaterias(pAccion, objE_Materias);
        }

        //--------------------------------------------------------------------------

        public DataSet ListadoMaterias()
        {

            return objNegocioMaterias.ListadoMaterias();

        }
        //--------------------------------------------------------------------------------------

        public DataSet SelecionaMaterias(int pIdMateria)
        {
            return objNegocioMaterias.SeleccionaMaterias(pIdMateria);

        }
        //------------------------------------------------------------------------------------
    }
}
