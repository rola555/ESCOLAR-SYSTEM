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
    public E_Estudiante objEntEstudiante = new E_Estudiante();

    public N_Estudiante objNeEstudiante = new N_Estudiante();

    protected void Page_Load(object sender, EventArgs e)
    {
       // IbAceptarEstudiante.Enabled = false;

    }

    private void EscondeControl()
    {

       // PnlAltas.Visible = false;
       // PListadoEstudiante.Visible = false;

    }

    private void ObjetoATextbox(DataSet ds)
    {
        TextNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
        TextApellido.Text = ds.Tables[0].Rows[0]["Apellido"].ToString();
        TextGenero.Text = ds.Tables[0].Rows[0]["Genero"].ToString();
        TextFecha.Text = ds.Tables[0].Rows[0]["Fecha_Nacimiento"].ToString();
        TextDireccion.Text = ds.Tables[0].Rows[0]["Direccion"].ToString();
        TextTutor.Text = ds.Tables[0].Rows[0]["Tutor"].ToString();
        TextTelefono.Text = ds.Tables[0].Rows[0]["Tel_Tutor"].ToString();
    }


    protected void TablaEstudiante_SelectedIndexChanged(object sender, EventArgs e)
    {

        IbAceptarEstudiante.Visible = false;
        BotEliminar.Visible = true;
        IBModificar.Visible = true;

        DataSet ds = new DataSet();

        objEntEstudiante.Id_Estudiante = Convert.ToInt16(TablaEstudiante.DataKeys[TablaEstudiante.SelectedIndex].Value.ToString());
        ds = objNeEstudiante.SelecionaEstudiante(objEntEstudiante.Id_Estudiante);

        if (ds.Tables[0].Rows.Count > 0)
        {

            ObjetoATextbox(ds);
         // EscondeControl();
         // PListadoEstudiante.Visible = false;

         // PnlAltas.Visible = true;
          //LblMsg.Visible = false;


        }
    }



    protected void TablaEstudiant_SelectedIndexChanged(object sender, EventArgs e)
    {

        IbAceptarEstudiante.Visible = false;
        BotEliminar.Visible = true;
        IBModificar.Visible = true;

        DataSet ds = new DataSet();

        objEntEstudiante.Id_Estudiante = Convert.ToInt16(TablaEstudiante.DataKeys[TablaEstudiante.SelectedIndex].Value.ToString());
        ds = objNeEstudiante.SelecionaEstudiante(objEntEstudiante.Id_Estudiante);

        if (ds.Tables[0].Rows.Count > 0)
        {

            ObjetoATextbox(ds);
            // EscondeControl();
            // PListadoEstudiante.Visible = false;

            // PnlAltas.Visible = true;
            //LblMsg.Visible = false;


        }

    }





    protected void IbListaEstudiante_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        EscondeControl();
        ds = objNeEstudiante.ListadoEstudiante();

        if (ds.Tables[0].Rows.Count > 0)
        {
            TablaEstudiante.DataSource = ds.Tables[0];
            TablaEstudiante.DataBind();
            //PListadoEstudiante.Visible = true;
        }

        else
        {

            Response.Write("<script>window.alert('AVISO: No existen registros.')</script>");

        }
    }

    private void MuestraMsg(string pTipo, string mMsg)
    {

        TextMensaje.Text = mMsg ;
        if (pTipo == "AVISO")
            TextMensaje.ForeColor = System.Drawing.Color.DarkBlue;

        else
            TextMensaje.ForeColor = System.Drawing.Color.Red;
        TextMensaje.Visible = true;

    }

    private void TextBoxObjeto()
    {

        objEntEstudiante.Nombre = TextNombre.Text;
        objEntEstudiante.Apellido = TextApellido.Text;
        objEntEstudiante.Genero = TextGenero.Text;
        objEntEstudiante.Fecha_Nacimiento = TextFecha.Text;
        objEntEstudiante.Direccion = TextDireccion.Text;
        objEntEstudiante.Tutor = TextTutor.Text;
        objEntEstudiante.Tel_Tutor = TextTelefono.Text;


    }
    protected void IbAceptarEstudiante_Click(object sender, EventArgs e)
    {
        
            
        int nGrabados = -1;

        TextBoxObjeto();

        nGrabados = objNeEstudiante.abcEstudiante("AGREGAR", objEntEstudiante);

        if (nGrabados != -1)
        {
            MuestraMsg("AVISO", "El Registro Fue grabado exitosamente   ");

            TextNombre.Text = "";
            TextApellido.Text = "";
            TextGenero.Text = "";
            TextFecha.Text = ""; 
            TextDireccion.Text = "";
            TextTutor.Text = "";
            TextTelefono.Text = "";
        }
        else
        {
            MuestraMsg("ERROR", "El registro no pudo ser grabado");
        }
        
    }

    protected void IBModificar_Click(object sender, EventArgs e)
    {
        int nResultado = -1;

        TextBoxObjeto();
        objEntEstudiante.Id_Estudiante = Convert.ToInt16(TablaEstudiante.DataKeys[TablaEstudiante.SelectedIndex].Value.ToString());

        nResultado = objNeEstudiante.abcEstudiante("MODIFICAR", objEntEstudiante);

        if (nResultado != -1)
        {
            MuestraMsg("AVISO", "El Registro Fue Modificado exitosamente   ");
        }

        else
        {

            MuestraMsg("ERROR", "El registro no pudo ser Modificado");




        }
    }

    protected void TablaEstudiante_SelectedIndexChanged1(object sender, EventArgs e)
    {

        IbAceptarEstudiante.Enabled = false;
        BotEliminar.Visible = true;
        IBModificar.Visible = true;

        DataSet ds = new DataSet();

        objEntEstudiante.Id_Estudiante = Convert.ToInt16(TablaEstudiante.DataKeys[TablaEstudiante.SelectedIndex].Value.ToString());
        ds = objNeEstudiante.SelecionaEstudiante(objEntEstudiante.Id_Estudiante);

        if (ds.Tables[0].Rows.Count > 0)
        {

            ObjetoATextbox(ds);
            EscondeControl();
           // PListadoEstudiante.Visible = false;

           // PnlAltas.Visible = true;
           // LblMsg.Visible = false;


        }
    }

    protected void BotEliminar_Click(object sender, EventArgs e)
    {

        int nResultado = -1;

        TextBoxObjeto();
        objEntEstudiante.Id_Estudiante = Convert.ToInt16(TablaEstudiante.DataKeys[TablaEstudiante.SelectedIndex].Value.ToString());

        nResultado = objNeEstudiante.abcEstudiante("BORRAR", objEntEstudiante);

        if (nResultado != -1)
        {

            DataSet ds = new DataSet();
            EscondeControl();
            ds = objNeEstudiante.ListadoEstudiante();

            if (ds.Tables[0].Rows.Count > 0)
            {
                TablaEstudiante.DataSource = ds.Tables[0];
                TablaEstudiante.DataBind();
                //PListadoEstudiante.Visible = true;
            }


            MuestraMsg("AVISO", "El Registro Fue Eliminado exitosamente   ");

        }

        else
        {

            MuestraMsg("AVISO", "El Registro No Pudo Ser Eliminado   ");




        }
    }

    protected void BotLimpiar_Click(object sender, EventArgs e)
    {
        TextNombre.Text = "";
        TextApellido.Text = "";
        TextGenero.Text = "";
        TextFecha.Text = "";
        TextDireccion.Text = "";
        TextTutor.Text = "";
        TextTelefono.Text = "";
        IbAceptarEstudiante.Enabled = true;

    }

    protected void TextNombre_TextChanged(object sender, EventArgs e)
    {
       
    }

    protected void Bregresar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Menuadministrador.aspx"); 
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        TextNombre.Text = "";
        TextApellido.Text = "";
        TextGenero.Text = "";
        TextFecha.Text = "";
        TextDireccion.Text = "";
        TextTutor.Text = "";
        TextTelefono.Text = "";
        IbAceptarEstudiante.Enabled = true;

    }
}