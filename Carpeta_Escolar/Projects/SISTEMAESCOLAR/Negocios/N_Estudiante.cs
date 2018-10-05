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
    public class N_Estudiante
    {
        D_Estudiante objNegocioEstudiante = new D_Estudiante();

        public int abcEstudiante(string pAccion, E_Estudiante objE_Estudiante)
        {

            return objNegocioEstudiante.abcEstudiante(pAccion, objE_Estudiante);
        }

        public DataSet ListadoEstudiante()
        {

            return objNegocioEstudiante.ListadoEstudiante();
        
        }

        public DataSet SelecionaEstudiante(int pIdEstudiante)
        {
            return objNegocioEstudiante.SeleccionaEstudiante(pIdEstudiante);

        }

    }
}
