using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Data.SqlClient;
using Datos.DsTableAdapters;

using System.Data;
using Control;
using Negocios;
using Datos;
public partial class TempleMP_MasteProfesor : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        N_ConsultaUsuario objUsuario = new N_ConsultaUsuario();
        SqlDataReader Loguear;
        Loguear = objUsuario.IniciarSesion();
        Loguear.Read();

        Label1.Text = P_ClasePrevilegios.Tipousuario;
        // Label1.Text = P_ClasePrevilegios.CualNombre;
        //Label2.Text = P_ClasePrevilegios.CualApellido;

        Label3.Text = P_ClasePrevilegios.CualNombre + " " + P_ClasePrevilegios.CualApellido;
    }
}
