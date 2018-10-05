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

public partial class MenuMaestro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        N_ConsultaUsuario objUsuario = new N_ConsultaUsuario();
        SqlDataReader Loguear;
        Loguear = objUsuario.IniciarSesion();
        Loguear.Read();

        Label1.Text = P_ClasePrevilegios.Tipousuario;
        // Label2.Text = P_ClasePrevilegios.CualApellido;

    }

    protected void IbListaEstudiante_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");

    }

    protected void Button7_Click(object sender, EventArgs e)
    {

    }

    protected void Button12_Click(object sender, EventArgs e)
    {
        Response.Redirect("P_Estudiante.aspx");
    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        Response.Redirect("P_Usuarios.aspx");
    }
}