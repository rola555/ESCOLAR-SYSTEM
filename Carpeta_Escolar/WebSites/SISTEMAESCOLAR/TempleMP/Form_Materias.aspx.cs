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

    public E_Materias objEntMaterias= new E_Materias();

    public N_Materias objNeMaterias = new N_Materias();


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    
    //-------///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    protected void Blistar_Click(object sender, EventArgs e)
    {
        TClaveMateria.Text = "";
        TNombreMateria.Text = "";
        //DTUsuario.Text = "";
        

        Button2.Enabled = true;
        Button2.Text = "Ingresar";

        DataSet ds = new DataSet();
        // EscondeControl();
        ds = objNeMaterias.ListadoMaterias();

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

    }

    private void TextBoxObjeto()
    {
        objEntMaterias.ClaveMateria = TClaveMateria.Text;
        objEntMaterias.NombreMateria = TNombreMateria.Text;
        


    }

    //--------------------///  ingresar registro  ///---------------------------------//
    protected void Button2_Click(object sender, EventArgs e)
    {

        if (TClaveMateria.Text == "")
        {

            Response.Redirect("Form_Materias.aspx");
            //Response.Write("<script>window.alert('AVISO: No existe datos para eliminar')</script>");
            //MuestraMsg("AVISO", "NO hay registros Para eliminar");
        }

        int nGrabados = -1;

        TextBoxObjeto();

        nGrabados = objNeMaterias.abcMaterias("AGREGAR", objEntMaterias);

        if (nGrabados != -1)
        {
            //MuestraMsg("AVISO", "El Registro Fue grabado exitosamente   ");
            Response.Write("<script>window.alert('AVISO: El Registro Fue Guardado Exitosamente')</script>");

            TClaveMateria.Text = "";
            TNombreMateria.Text = "";
            

            DataSet ds = new DataSet();
            ds = objNeMaterias.ListadoMaterias();
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

    //-------------------------------------------------------------------------------------------------------------------


//----//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    protected void BNuevo_Click(object sender, EventArgs e)
    {

        TClaveMateria.Text = "";
        TNombreMateria.Text = "";
        //DTUsuario.Text = "";
       

        Button2.Enabled = true;
        Button2.Text = "Ingresar";

    }

    //-----/////////////////////////////////////////////////////////////////////////////////////////////////////////////


    //-------///////////////////////////////////////////////////////////////////////////////////////////////////////////
    private void ObjetoATextbox(DataSet ds)
    {
        TClaveMateria.Text = ds.Tables[0].Rows[0]["ClaveMateria"].ToString();
        TNombreMateria.Text = ds.Tables[0].Rows[0]["NombreMateria"].ToString();
        



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

        objEntMaterias.IdMateria = Convert.ToInt16(GridView1.DataKeys[GridView1.SelectedIndex].Value.ToString());
        ds = objNeMaterias.SelecionaMaterias(objEntMaterias.IdMateria);

        if (ds.Tables[0].Rows.Count > 0)
        {

            ObjetoATextbox(ds);
            // EscondeControl();
            // PListadoEstudiante.Visible = false;

            // PnlAltas.Visible = true;
            // LblMsg.Visible = false;


        }





    }

    //----------/////////////////////////////////////////////////////////////////////////////////////////////////////////////

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TClaveMateria.Text == "")
        {

            Response.Redirect("Form_Materias.aspx");
            //Response.Write("<script>window.alert('AVISO: No existe datos para eliminar')</script>");
            //MuestraMsg("AVISO", "NO hay registros Para eliminar");
        }

        int nResultado = -1;

        TextBoxObjeto();
        objEntMaterias.IdMateria = Convert.ToInt16(GridView1.DataKeys[GridView1.SelectedIndex].Value.ToString());

        nResultado = objNeMaterias.abcMaterias("BORRAR", objEntMaterias);
        // Response.Write("<script>window.alert('AVISO: No existe datos para eliminar')</script>");
        if (nResultado != -1)
        {

            DataSet ds = new DataSet();
            // EscondeControl();
            ds = objNeMaterias.ListadoMaterias();

            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
                //PListadoEstudiante.Visible = true;
            }


            // MuestraMsg("AVISO", "El Registro Fue Eliminado exitosamente   ");
            Response.Write("<script>window.alert('AVISO: El Registro Fue Eliminado exitosamente')</script>");
            TClaveMateria.Text = "";
            TNombreMateria.Text = "";
            //DTUsuario.Text = "";
           
        }

        else
        {

            //MuestraMsg("AVISO", "El Registro No Pudo Ser Eliminado   ");
            Response.Write("<script>window.alert('AVISO: El Registro No Pudo Ser Eliminado')</script>");

        }

    }

    //---------------///////////////////////////////////////////////////////////////////////////////////////////////77
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (TClaveMateria.Text == "")
        {

            Response.Redirect("Form_Materias.aspx");
            //Response.Write("<script>window.alert('AVISO: No existe datos para eliminar')</script>");
            //MuestraMsg("AVISO", "NO hay registros Para eliminar");
        }

        int nResultado = -1;

        TextBoxObjeto();
        objEntMaterias.IdMateria = Convert.ToInt16(GridView1.DataKeys[GridView1.SelectedIndex].Value.ToString());

        nResultado = objNeMaterias.abcMaterias("MODIFICAR", objEntMaterias);

        if (nResultado != -1)
        {
            //MuestraMsg("AVISO", "El Registro Fue Modificado exitosamente   ");
            Response.Write("<script>window.alert('AVISO: El Registro Fue Modificado Exitosamente')</script>");


            //actualiza BD//
            DataSet ds = new DataSet();
            ds = objNeMaterias.ListadoMaterias();
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
        TClaveMateria.Text = "";
        TNombreMateria.Text = "";
        //DTUsuario.Text = "";
        

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