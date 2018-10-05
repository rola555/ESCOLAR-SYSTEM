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
    public class N_ListarTablaProfesor
    {

        D_ListarTablaProfesor objNegocioListarTablaProfesor = new D_ListarTablaProfesor();

        public DataTable ListarTablaMateria()
        {

            return objNegocioListarTablaProfesor.ListarProfesoress();

        }


    }
}
