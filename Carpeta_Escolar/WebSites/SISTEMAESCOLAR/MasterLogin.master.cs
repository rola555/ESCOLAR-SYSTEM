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

public partial class MasterLogin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        N_ConsultaUsuario objUsuario = new N_ConsultaUsuario();
        SqlDataReader Loguear;



        objUsuario.Username = TextBox1.Text;
        objUsuario.Password = TextBox2.Text;
        Loguear = objUsuario.IniciarSesion();

        if (Loguear.Read() == true)
        {
            P_ClasePrevilegios.Tipousuario = Loguear["TipoUsuario"].ToString();
            P_ClasePrevilegios.CualApellido = Loguear["Apellido"].ToString();
            P_ClasePrevilegios.CualNombre = Loguear["Nombre"].ToString();

            if (P_ClasePrevilegios.Tipousuario == "Profesor")
            {
                //aqui estamos mandando a llamar los registros nombre y apellidos de la bd atravez de Tipousuario y CualApellido las cuales se encuentran en la capa Presentacion
                P_ClasePrevilegios.Tipousuario = Loguear["TipoUsuario"].ToString();
                // P_ClasePrevilegios.CualApellido = Loguear["Apellido"].ToString();
                // P_ClasePrevilegios.CualNombre = Loguear["Nombre"].ToString();

                Response.Redirect("TempleMP/HomeProfesor.aspx");

            }
            else
            {
                if (P_ClasePrevilegios.Tipousuario == "Administrador")
                {


                    Response.Redirect("TempleMP/Form_Usuarios.aspx");
                }
                else
                {
                    Response.Write("<script>window.alert('AVISO: Este Parametro No tiene un Rol especifico')</script>");
                    TextBox1.Text = " ";
                    TextBox2.Text = " ";
                }

            }




        }

        else
        {

            Response.Write("<script>window.alert('AVISO: El Usuario Y la Contraseña son Incorrectos')</script>");
        }



    }
    public static UsuarioCuentas1TableAdapter adaptador = new UsuarioCuentas1TableAdapter();

}

