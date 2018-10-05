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
    public class N_ListarTablaMateria
    {
        D_ListarTablaMateria objNegocioListarTablaMaterias = new D_ListarTablaMateria();

        public DataTable ListarTablaMateria()
        {

            return objNegocioListarTablaMaterias.ListarMaterias();

        }

    }
}
