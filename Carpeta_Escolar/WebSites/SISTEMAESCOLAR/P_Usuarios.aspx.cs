using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Data;
using Control;
using Negocios;


public partial class P_Estudiante : System.Web.UI.Page


{
    public E_RegistrosUsuarios objEntUsuarios= new E_RegistrosUsuarios();

    public N_ResgistroUsuarios objNeUsuarios = new N_ResgistroUsuarios();

    protected void Page_Load(object sender, EventArgs e)
    {
       // IbAceptarEstudiante.Enabled = false;

    }


    protected void Button1_Click(object sender, EventArgs e)
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

        else
        {

            Response.Write("<script>window.alert('AVISO: No existen registros.')</script>");

        }
    }

    private void ObjetoATextbox(DataSet ds)
    {
        TUsuario.Text = ds.Tables[0].Rows[0]["username"].ToString();
        TContraseña.Text = ds.Tables[0].Rows[0]["Password"].ToString();
        TNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
        TApellido.Text = ds.Tables[0].Rows[0]["Apellido"].ToString();
        TCorreo.Text = ds.Tables[0].Rows[0]["Correo"].ToString();
        LTUsuario.Text = ds.Tables[0].Rows[0]["TipoUsuario"].ToString();
       
    }

    protected void TablaEstudiante_SelectedIndexChanged(object sender, EventArgs e)
    {

       // IbAceptarEstudiante.Visible = false;
       // BotEliminar.Visible = true;
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
            //LblMsg.Visible = false;


        }
    }



    protected void Button2_Click(object sender, EventArgs e)
    {


        int nGrabados = -1;

        TextBoxObjeto();

        nGrabados = objNeUsuarios.abcUsuario("AGREGAR", objEntUsuarios);

        if (nGrabados != -1)
        {
            MuestraMsg("AVISO", "El Registro Fue grabado exitosamente   ");

            TUsuario.Text = "";
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
            MuestraMsg("ERROR", "El registro no pudo ser grabado");
        }

    }

    private void TextBoxObjeto()
    {

        objEntUsuarios.Username = TUsuario.Text;
        objEntUsuarios.Password = TContraseña.Text;
        objEntUsuarios.Nombre = TNombre.Text;
        objEntUsuarios.Apellido = TApellido.Text;
        objEntUsuarios.Correo = TCorreo.Text;
        objEntUsuarios.TipoUsuario = LTUsuario.Text;
      


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

    protected void BRegresar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Menuadministrador.aspx"); 
    }

    protected void Bcancelar_Click(object sender, EventArgs e)
    {
        //IbAceptarEstudiante.Enabled = true;
        TUsuario.Text = "";
        TContraseña.Text = "";
        TNombre.Text = "";
        TApellido.Text = "";
        TCorreo.Text = "";


        BIngresar.Enabled = true;
        

    }

    protected void Button2_Click1(object sender, EventArgs e)
    {
        int nResultado = -1;

        TextBoxObjeto();
        objEntUsuarios.IdUsuarioCuenta = Convert.ToInt16(GridView1.DataKeys[GridView1.SelectedIndex].Value.ToString());

        nResultado = objNeUsuarios.abcUsuario("BORRAR", objEntUsuarios);

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


            MuestraMsg("AVISO", "El Registro Fue Eliminado exitosamente   ");

        }

        else
        {

            MuestraMsg("AVISO", "El Registro No Pudo Ser Eliminado   ");




        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        BIngresar.Enabled = false;
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

    protected void Button3_Click(object sender, EventArgs e)
    {
        int nResultado = -1;

        TextBoxObjeto();
        objEntUsuarios.IdUsuarioCuenta = Convert.ToInt16(GridView1.DataKeys[GridView1.SelectedIndex].Value.ToString());

        nResultado = objNeUsuarios.abcUsuario("MODIFICAR", objEntUsuarios);

        if (nResultado != -1)
        {
            MuestraMsg("AVISO", "El Registro Fue Modificado exitosamente   ");

            //actualiza BD//
            DataSet ds = new DataSet();
            ds = objNeUsuarios.ListadoUsuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            //---------------------------------------

        }

        else
        {

            MuestraMsg("ERROR", "El registro no pudo ser Modificado");




        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        TUsuario.Text = "";
        TContraseña.Text = "";
        TNombre.Text = "";
        TApellido.Text = "";
        TCorreo.Text = "";


        BIngresar.Enabled = true;
    }
}