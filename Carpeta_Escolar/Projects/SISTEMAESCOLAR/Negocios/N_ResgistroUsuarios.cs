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
    public class N_ResgistroUsuarios
    {
        D_ConstructorRegistroUsuarios objNegocioRegistroUsuarios = new D_ConstructorRegistroUsuarios();

        public int abcUsuario(string pAccion, E_RegistrosUsuarios objE_Usuario)
        {

            return objNegocioRegistroUsuarios.abcUsuario(pAccion, objE_Usuario);
        }

        public DataSet ListadoUsuarios()
        {

            return objNegocioRegistroUsuarios.ListadoUsuarios();
        
        }

        public DataSet SelecionaRegistroUsuarios(int pIdRegistroUsuario)
        {
            return objNegocioRegistroUsuarios.SeleccionaUsuario(pIdRegistroUsuario);

        }

    }
}
