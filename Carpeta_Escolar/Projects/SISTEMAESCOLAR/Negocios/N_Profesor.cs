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
    public class N_Profesor
    {


        D_Profesores objNegocioProfesor = new D_Profesores();

        public int abcProfesor(string pAccion, E_Profesores objE_Profesor)
        {

            return objNegocioProfesor.abcProfesores(pAccion, objE_Profesor);
        }

        public DataSet ListadoProfesor()
        {

            return objNegocioProfesor.ListadoProfesores();

        }

        public DataSet negListadoNombreApellido()
        {

            return objNegocioProfesor.ListaNombreApellidoProfesor();

        }

        public DataSet SeleccionaPorfesor(int pIdProfesor)
        {
            return objNegocioProfesor.SeleccionaProfesores(pIdProfesor);

        }

        //----------------------------------------------------------------------------------------


    }
}
