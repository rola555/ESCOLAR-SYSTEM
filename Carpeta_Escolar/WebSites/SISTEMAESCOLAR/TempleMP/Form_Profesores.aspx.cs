﻿using System;
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

    public E_Profesores objEntProfesor = new E_Profesores();

    public N_Profesor objNeProfesores = new N_Profesor();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    
    //-------///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    protected void Blistar_Click(object sender, EventArgs e)
    {

        TNombreProfesor.Text = "";
        TApellidoProfesor.Text = "";
        //DTUsuario.Text = "";
        TEspecialidadProfesor.Text = "";
        TTelefonoProfesor.Text = "";
        
        Button2.Enabled = true;
        Button2.Text = "Ingresar";

        DataSet ds = new DataSet();
        // EscondeControl();
        ds = objNeProfesores.ListadoProfesor();

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
    //--------////////////////////////////////////////////////////////////////////////////////////////////////////////////////////7

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
        objEntProfesor.NombreProfesor = TNombreProfesor.Text;
        objEntProfesor.ApellidoProfesor = TApellidoProfesor.Text;
        objEntProfesor.EspecialidadProfesor = TEspecialidadProfesor.Text;
        objEntProfesor.TelefonoProfesor = TTelefonoProfesor.Text;
       

    }

    //--------------------///  ingresar registro  ///---------------------------------//
    protected void Button2_Click(object sender, EventArgs e)
    {

        if (TNombreProfesor.Text == "")
        {

            Response.Redirect("Form_Profesores.aspx");
            //Response.Write("<script>window.alert('AVISO: No existe datos para eliminar')</script>");
            //MuestraMsg("AVISO", "NO hay registros Para eliminar");
        }

        int nGrabados = -1;

        TextBoxObjeto();

        nGrabados = objNeProfesores.abcProfesor("AGREGAR", objEntProfesor);

        if (nGrabados != -1)
        {
            //MuestraMsg("AVISO", "El Registro Fue grabado exitosamente   ");
            Response.Write("<script>window.alert('AVISO: El Registro Fue Guardado Exitosamente')</script>");

            TNombreProfesor.Text = "";
            TApellidoProfesor.Text = "";
            TEspecialidadProfesor.Text = "";
            TTelefonoProfesor.Text = "";
            
            DataSet ds = new DataSet();
            ds = objNeProfesores.ListadoProfesor();
           // GridView1.DataSource = ds.Tables[0];
            //GridView1.DataBind();
            //---------------------------------------

        }
        else
        {
            //MuestraMsg("ERROR", "El registro no pudo ser grabado");
            Response.Write("<script>window.alert('AVISO: El Registro No Pudo Ser Guardado')</script>");
        }

    }

    //-------------------------------------------------------------------------------------------------------------------


//----//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    protected void BNuevo_Click(object sender, EventArgs e)
    {

        TNombreProfesor.Text = "";
        TApellidoProfesor.Text = "";
        //DTUsuario.Text = "";
        TEspecialidadProfesor.Text = "";
        TTelefonoProfesor.Text = "";
       
        Button2.Enabled = true;
        Button2.Text = "Ingresar";

    }

    //-----/////////////////////////////////////////////////////////////////////////////////////////////////////////////


    //-------///////////////////////////////////////////////////////////////////////////////////////////////////////////
    private void ObjetoATextbox(DataSet ds)
    {
        TNombreProfesor.Text = ds.Tables[0].Rows[0]["NombreProfesor"].ToString();
        TApellidoProfesor.Text = ds.Tables[0].Rows[0]["ApellidoProfesor"].ToString();
        TEspecialidadProfesor.Text = ds.Tables[0].Rows[0]["EspecialidadProfesor"].ToString();
        TTelefonoProfesor.Text = ds.Tables[0].Rows[0]["TelefonoProfesor"].ToString();
        


    }
    //-----------///////////////////////////////////////////////////////////////////////////////////////////////////////////7

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
         
    
        Button2.Text = " ";
        Button2.Enabled = false;
        Button1.Visible = true;
        Button3.Visible = true;

        //BotEliminar.Visible = true;
        //IBModificar.Visible = true;

        DataSet ds = new DataSet();

        objEntProfesor.IdProfesor = Convert.ToInt16(GridView1.DataKeys[GridView1.SelectedIndex].Value.ToString());
        ds = objNeProfesores.SeleccionaPorfesor(objEntProfesor.IdProfesor);

        if (ds.Tables[0].Rows.Count > 0)
        {

            ObjetoATextbox(ds);
            // EscondeControl();
            // PListadoEstudiante.Visible = false;

            // PnlAltas.Visible = true;
            // LblMsg.Visible = false;


        }

    

}
    //--------------------------------------------------------------------------------------------------------------

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TNombreProfesor.Text == "")
        {

            Response.Redirect("Form_Profesores.aspx");
            //Response.Write("<script>window.alert('AVISO: No existe datos para eliminar')</script>");
            //MuestraMsg("AVISO", "NO hay registros Para eliminar");
        }



        int nResultado = -1;




        TextBoxObjeto();
        objEntProfesor.IdProfesor = Convert.ToInt16(GridView1.DataKeys[GridView1.SelectedIndex].Value.ToString());

        nResultado = objNeProfesores.abcProfesor("BORRAR", objEntProfesor);





        // Response.Write("<script>window.alert('AVISO: No existe datos para eliminar')</script>");




        if (nResultado != -1)
        {

            DataSet ds = new DataSet();
            // EscondeControl();
            ds = objNeProfesores.ListadoProfesor();

            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
                //PListadoEstudiante.Visible = true;
            }


            // MuestraMsg("AVISO", "El Registro Fue Eliminado exitosamente   ");
            Response.Write("<script>window.alert('AVISO: El Registro Fue Eliminado exitosamente')</script>");
            TNombreProfesor.Text = "";
            TApellidoProfesor.Text = "";
            //DTUsuario.Text = "";
            TEspecialidadProfesor.Text = "";
            TTelefonoProfesor.Text = "";
            



        }

        else
        {

            //MuestraMsg("AVISO", "El Registro No Pudo Ser Eliminado   ");
            Response.Write("<script>window.alert('AVISO: El Registro No Pudo Ser Eliminado')</script>");







        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        if (TNombreProfesor.Text == "")
        {

            Response.Redirect("Form_Profesores.aspx");
            //Response.Write("<script>window.alert('AVISO: No existe datos para eliminar')</script>");
            //MuestraMsg("AVISO", "NO hay registros Para eliminar");
        }

        int nResultado = -1;

        TextBoxObjeto();
        objEntProfesor.IdProfesor = Convert.ToInt16(GridView1.DataKeys[GridView1.SelectedIndex].Value.ToString());

        nResultado = objNeProfesores.abcProfesor("MODIFICAR", objEntProfesor);

        if (nResultado != -1)
        {
            //MuestraMsg("AVISO", "El Registro Fue Modificado exitosamente   ");
            Response.Write("<script>window.alert('AVISO: El Registro Fue Modificado Exitosamente')</script>");


            //actualiza BD//
            DataSet ds = new DataSet();
            ds = objNeProfesores.ListadoProfesor();
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


    //---///////////////////////////////////////////////////////////////////////////////////////////////////
    protected void BCancelar_Click(object sender, EventArgs e)
    {

        TNombreProfesor.Text = "";
        TApellidoProfesor.Text = "";
        //DTUsuario.Text = "";
        TEspecialidadProfesor.Text = "";
        TTelefonoProfesor.Text = "";

        Button2.Enabled = true;
        Button2.Text = "Ingresar";


    }
    //---///////////////////////////////////////////////////////////////////////////////////////////////////
    protected void DTUsuario_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void TUsername_TextChanged(object sender, EventArgs e)
    {

    }
}