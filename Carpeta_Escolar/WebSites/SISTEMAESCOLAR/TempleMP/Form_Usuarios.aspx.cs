using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Data;
using Control;
using Negocios;


public partial class TempleMP_Form_Estudiante : System.Web.UI.Page
{

    public E_RegistrosUsuarios objEntUsuarios = new E_RegistrosUsuarios();

    public N_ResgistroUsuarios objNeUsuarios = new N_ResgistroUsuarios();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Blistar_Click(object sender, EventArgs e)
    {
        TUsername.Text = "";
        TContraseña.Text = "";
        //DTUsuario.Text = "";
        TApellido.Text = "";
        TNombre.Text = "";
        TCorreo.Text = "";
        TTTutor.Text = "";
        Button2.Enabled = true;
        Button2.Text = "Ingresar";

        DataSet ds = new DataSet();
        // EscondeControl();
        ds = objNeUsuarios.ListadoUsuarios();

        if (ds.Tables[0].Rows.Count > 0)
        {
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            //PListadoEstudiante.Visible = true;
        }

        else
        {

            Response.Write("<script>window.alert('AVISO: No existen registros.')</script>");

        }
    }

    private void MuestraMsg(string pTipo, string mMsg)
    {

        TMensaje.Text = mMsg;
        if (pTipo == "AVISO")
            TMensaje.ForeColor = System.Drawing.Color.DarkBlue;

        else
            TMensaje.ForeColor = System.Drawing.Color.Red;
        TMensaje.Visible = true;

    }

    private void TextBoxObjeto()
    {

        objEntUsuarios.Username = TUsername.Text;
        objEntUsuarios.Password = TContraseña.Text;
        objEntUsuarios.Nombre = TNombre.Text;
        objEntUsuarios.Apellido = TApellido.Text;
        objEntUsuarios.Correo = TCorreo.Text;
        objEntUsuarios.TipoUsuario = DTUsuario.Text;



    }
    protected void Button2_Click(object sender, EventArgs e)
    {
       if (TUsername.Text == "")
       {

           Response.Redirect("Form_Usuarios.aspx");
                           //Response.Write("<script>window.alert('AVISO: No existe datos para eliminar')</script>");
                                   //MuestraMsg("AVISO", "NO hay registros Para eliminar");
       }

        int nGrabados = -1;

        TextBoxObjeto();

        nGrabados = objNeUsuarios.abcUsuario("AGREGAR", objEntUsuarios);

        if (nGrabados != -1)
        {
            //MuestraMsg("AVISO", "El Registro Fue grabado exitosamente   ");
            Response.Write("<script>window.alert('AVISO: El Registro Fue Guardado Exitosamente')</script>");

            TUsername.Text = "";
            TContraseña.Text = "";
            TNombre.Text = "";
            TApellido.Text = "";
            TCorreo.Text = "";
            //TTUsuario.Text = "";
            //actualiza BD//
            DataSet ds = new DataSet();
            ds = objNeUsuarios.ListadoUsuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            //---------------------------------------

        }
        else
        {
            //MuestraMsg("ERROR", "El registro no pudo ser grabado");
            Response.Write("<script>window.alert('AVISO: El Registro No Pudo Ser Guardado')</script>");
        }

    }

    protected void BNuevo_Click(object sender, EventArgs e)
    {

        TUsername.Text = "";
        TContraseña.Text = "";
        //DTUsuario.Text = "";
        TApellido.Text = "";
        TNombre.Text = "";
        TCorreo.Text = "";
        TTTutor.Text = "";
        Button2.Enabled = true;
        Button2.Text = "Ingresar";
    }

    private void ObjetoATextbox(DataSet ds)
    {
        TUsername.Text = ds.Tables[0].Rows[0]["username"].ToString();
        TContraseña.Text = ds.Tables[0].Rows[0]["Password"].ToString();
        TNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
        TApellido.Text = ds.Tables[0].Rows[0]["Apellido"].ToString();
        TCorreo.Text = ds.Tables[0].Rows[0]["Correo"].ToString();
        DTUsuario.Text = ds.Tables[0].Rows[0]["TipoUsuario"].ToString();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Button2.Text = " ";
        Button2.Enabled = false;
        Button1.Visible = true;
        Button3.Visible = true;
        
        //BotEliminar.Visible = true;
        //IBModificar.Visible = true;

        DataSet ds = new DataSet();

        objEntUsuarios.IdUsuarioCuenta = Convert.ToInt16(GridView1.DataKeys[GridView1.SelectedIndex].Value.ToString());
        ds = objNeUsuarios.SelecionaRegistroUsuarios(objEntUsuarios.IdUsuarioCuenta);

        if (ds.Tables[0].Rows.Count > 0)
        {

            ObjetoATextbox(ds);
            // EscondeControl();
            // PListadoEstudiante.Visible = false;

            // PnlAltas.Visible = true;
            // LblMsg.Visible = false;


        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TUsername.Text == "" )
        {

          Response.Redirect("Form_Usuarios.aspx");
          //Response.Write("<script>window.alert('AVISO: No existe datos para eliminar')</script>");
            //MuestraMsg("AVISO", "NO hay registros Para eliminar");
        }

       

        int nResultado = -1;
      
        
           

        TextBoxObjeto();
        objEntUsuarios.IdUsuarioCuenta = Convert.ToInt16(GridView1.DataKeys[GridView1.SelectedIndex].Value.ToString());

        nResultado = objNeUsuarios.abcUsuario("BORRAR", objEntUsuarios);

        

        
        
           // Response.Write("<script>window.alert('AVISO: No existe datos para eliminar')</script>");
        

        

            if (nResultado != -1)
            {

                DataSet ds = new DataSet();
                // EscondeControl();
                ds = objNeUsuarios.ListadoUsuarios();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    GridView1.DataSource = ds.Tables[0];
                    GridView1.DataBind();
                    //PListadoEstudiante.Visible = true;
                }


               // MuestraMsg("AVISO", "El Registro Fue Eliminado exitosamente   ");
            Response.Write("<script>window.alert('AVISO: El Registro Fue Eliminado exitosamente')</script>");
            TUsername.Text = "";
            TContraseña.Text = "";
            //DTUsuario.Text = "";
            TApellido.Text = "";
            TNombre.Text = "";
            TCorreo.Text = "";
            TTTutor.Text = "";



        }

            else
            {

                //MuestraMsg("AVISO", "El Registro No Pudo Ser Eliminado   ");
            Response.Write("<script>window.alert('AVISO: El Registro No Pudo Ser Eliminado')</script>");







        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        if (TUsername.Text == "")
        {

            Response.Redirect("Form_Usuarios.aspx");
            //Response.Write("<script>window.alert('AVISO: No existe datos para eliminar')</script>");
            //MuestraMsg("AVISO", "NO hay registros Para eliminar");
        }

        int nResultado = -1;

        TextBoxObjeto();
        objEntUsuarios.IdUsuarioCuenta = Convert.ToInt16(GridView1.DataKeys[GridView1.SelectedIndex].Value.ToString());

        nResultado = objNeUsuarios.abcUsuario("MODIFICAR", objEntUsuarios);

        if (nResultado != -1)
        {
            //MuestraMsg("AVISO", "El Registro Fue Modificado exitosamente   ");
            Response.Write("<script>window.alert('AVISO: El Registro Fue Modificado Exitosamente')</script>");


            //actualiza BD//
            DataSet ds = new DataSet();
            ds = objNeUsuarios.ListadoUsuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            //---------------------------------------

        }

        else
        {

            //MuestraMsg("ERROR", "El registro no pudo ser Modificado");
            Response.Write("<script>window.alert('AVISO: El Registro No Pudo Ser Modificado')</script>");




        }


    }

    protected void BCancelar_Click(object sender, EventArgs e)
    {
        TUsername.Text = "";
        TContraseña.Text = "";
        //DTUsuario.Text = "";
        TApellido.Text = "";
        TNombre.Text = "";
        TCorreo.Text = "";
        TTTutor.Text = "";
        Button2.Enabled = true;
        Button2.Text = "Ingresar";
    }

    protected void DTUsuario_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void TUsername_TextChanged(object sender, EventArgs e)
    {

    }
}