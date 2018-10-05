using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


using System.Data;
using Control;
using Negocios;
using Datos;


public partial class TempleMP_Form_Estudiante : System.Web.UI.Page
{

    

    public E_Cursos objEntCursos = new E_Cursos();

    public N_Cursos objNeCursos = new N_Cursos();



    public N_Profesor objNeNombreApellidoProf = new N_Profesor();

    public E_Profesores objEntProfesores = new E_Profesores();



    protected void Page_Load(object sender, EventArgs e)
    {

        seleccionarMateria();
        //seleccionarProfesor();

       

    }

    //-----------------------------------------------------------------------------------------------------------

     private void seleccionarMateria()
        {

        if (IsPostBack == false)
        {
            D_ListarTablaMateria objNegocioListarTablaMaterias = new D_ListarTablaMateria();
            TMateria.DataSource = objNegocioListarTablaMaterias.ListarMaterias();


            TMateria.DataTextField = "NombreMateria";
            TMateria.DataValueField = "IdMateria";
            TMateria.DataBind();
        }

        }

    //------------------------------------------------------------------------------------------------------------
    private void seleccionarProfesor()
    {
        if (IsPostBack == false)
        {
            D_ListarTablaProfesor objNegocioListarTablaProfesor = new D_ListarTablaProfesor();
            DataSet ds = new DataSet(); 
           
           
         // TProfesor.DataSource = objNegocioListarTablaProfesor.ListarProfesoress();
          //TProfesor.DataTextField = "Nombreapellido";
          //TProfesor.DataValueField = "IdProfesor";
          //TProfesor.DataBind();


           

        }


    }
    //-------------------------------------------------------------------------------------------------
   
    
    //-----------------------------------------------------------------------------

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    
    //-------///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    protected void Blistar_Click(object sender, EventArgs e)
    {
        // listarTablapersonalizada();


        TNombreCurso.Text = "";
        THoraCurso.Text = "";
        //DTUsuario.Text = "";


        Button2.Enabled = true;
        Button2.Text = "Ingresar";

        DataSet ds = new DataSet();
        // EscondeControl();
        ds = objNeCursos.ListadoCursos();

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

    private void TextBoxObjetoParaIngresar()
    {
        objEntCursos.NombreCurso = TNombreCurso.Text;
        objEntCursos.Hora = THoraCurso.Text;
        objEntCursos.FMateria = Convert.ToInt32(TMateria.SelectedValue);
       // objEntCursos.FProfesor = Convert.ToInt32(TProfesor.Text);
        objEntCursos.ApellidoProfesor = TApellidoProfesor.Text;
        objEntCursos.FProfesor = Convert.ToInt32(TextBox123.Text);
        

    }

    //--------------------///  ingresar registro  ///---------------------------------//
    protected void Button2_Click(object sender, EventArgs e)
    {

        if (TNombreCurso.Text == "")
        {

            Response.Redirect("Form_Cursos.aspx");
            //Response.Write("<script>window.alert('AVISO: No existe datos para eliminar')</script>");
            //MuestraMsg("AVISO", "NO hay registros Para eliminar");
        }

        int nGrabados = -1;

        TextBoxObjetoParaIngresar();

        

        nGrabados = objNeCursos.abcCursos("AGREGAR", objEntCursos);

        if (nGrabados != -1)
        {
            //MuestraMsg("AVISO", "El Registro Fue grabado exitosamente   ");
            Response.Write("<script>window.alert('AVISO: El Registro Fue Guardado Exitosamente')</script>");

            TNombreCurso.Text = "";
            THoraCurso.Text = "";


            DataSet ds = new DataSet();
            ds = objNeCursos.ListadoCursos();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            //---------------------------------------

        }
        else
        {
            //MuestraMsg("ERROR", "El registro no pudo ser grabado");
            Response.Write("<script>window.alert('AVISO: El Registro No Pudo Ser Guardado')</script>");
        }
        Gridview3.Visible = false;
        TNombreCurso.Text = string.Empty;
        THoraCurso.Text = string.Empty;
    }

    //-------------------------------------------------------------------------------------------------------------------


//----//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    protected void BNuevo_Click(object sender, EventArgs e)
    {

        TNombreCurso.Text = "";
        THoraCurso.Text = "";
        //DTUsuario.Text = "";


        Button2.Enabled = true;
        Button2.Text = "Ingresar";

    }

    //-----/////////////////////////////////////////////////////////////////////////////////////////////////////////////


    //-------///////////////////////////////////////////////////////////////////////////////////////////////////////////
    private void ObjetoATextbox(DataSet ds)
    {

        TextBox123.Text = ds.Tables[0].Rows[0]["IdProfesor"].ToString();
        TApellidoProfesor.Text = ds.Tables[0].Rows[0]["ApellidoProfesor"].ToString();
        TNombreProfesor.Text = ds.Tables[0].Rows[0]["NombreProfesor"].ToString();

        


    }
    //-----------///////////////////////////////////////////////////////////////////////////////////////////////////////////7

    private void TextBoxObjetoParaEliminar()
    {
        objEntCursos.NombreCurso = TNombreCurso.Text;
        objEntCursos.Hora = THoraCurso.Text;
        objEntCursos.FMateria = Convert.ToInt32(TMateria.SelectedValue);
        // objEntCursos.FProfesor = Convert.ToInt32(TProfesor.Text);
        objEntCursos.ApellidoProfesor = TApellidoProfesor.Text;
        //objEntCursos.FProfesor = Convert.ToInt32(TextBox123.Text);


    }
    ///-----------//////////////////////////////////////////////////////////////////////////////////////////////////////////////7
    private void ObjetoParaMostrarEnGridviewPrincipal(DataSet ds)
    {

        


            TNombreCurso.Text = ds.Tables[0].Rows[0]["NombreCurso"].ToString();
            THoraCurso.Text = ds.Tables[0].Rows[0]["Hora"].ToString();
            TMateria.SelectedValue = ds.Tables[0].Rows[0]["FMateria"].ToString();
       // TNombreProfesor.Text = GridView1.Rows[].Cells[0].Value.ToString();
        




    }
    ///----------------------------------------------------------------------------------------------------------------------

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

        Button2.Text = " ";
        Button2.Enabled = false;
        Button1.Visible = true;
        Button3.Visible = true;

        //BotEliminar.Visible = true;
        //IBModificar.Visible = true;

        DataSet ds = new DataSet();

      

        objEntCursos.IdCurso = Convert.ToInt16(GridView1.DataKeys[GridView1.SelectedIndex].Value.ToString());
        ds = objNeCursos.SelecionaCursos(objEntCursos.IdCurso);

        if (ds.Tables[0].Rows.Count > 0)
        {

            ObjetoParaMostrarEnGridviewPrincipal(ds);
            // EscondeControl();
            // PListadoEstudiante.Visible = false;

            // PnlAltas.Visible = true;
            // LblMsg.Visible = false;


        }


    }

    //----------/////////////////////////////////////////////////////////////////////////////////////////////////////////////

    protected void Button1_Click(object sender, EventArgs e)
    {

        if (TNombreCurso.Text == "")
        {

            Response.Redirect("Form_Cursos.aspx");
            //Response.Write("<script>window.alert('AVISO: No existe datos para eliminar')</script>");
            //MuestraMsg("AVISO", "NO hay registros Para eliminar");
        }

        int nResultado = -1;
        TextBoxObjetoParaEliminar();
        objEntCursos.IdCurso = Convert.ToInt16(GridView1.DataKeys[GridView1.SelectedIndex].Value.ToString());

        nResultado = objNeCursos.abcCursos("BORRAR", objEntCursos);

        // Response.Write("<script>window.alert('AVISO: No existe datos para eliminar')</script>");
        if (nResultado != -1)
        {

            DataSet ds = new DataSet();
            // EscondeControl();
            ds = objNeCursos.ListadoCursos();

            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
                //PListadoEstudiante.Visible = true;
            }


            // MuestraMsg("AVISO", "El Registro Fue Eliminado exitosamente   ");
            Response.Write("<script>window.alert('AVISO: El Registro Fue Eliminado exitosamente')</script>");
            TNombreCurso.Text = "";
            THoraCurso.Text = "";
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


        if (TNombreCurso.Text == "")
        {

            Response.Redirect("Form_Cursos.aspx");
            //Response.Write("<script>window.alert('AVISO: No existe datos para eliminar')</script>");
            //MuestraMsg("AVISO", "NO hay registros Para eliminar");
        }

        int nResultado = -1;

        TextBoxObjetoParaIngresar();
        objEntCursos.IdCurso = Convert.ToInt16(GridView1.DataKeys[GridView1.SelectedIndex].Value.ToString());

        nResultado = objNeCursos.abcCursos("MODIFICAR", objEntCursos);

        if (nResultado != -1)
        {
            //MuestraMsg("AVISO", "El Registro Fue Modificado exitosamente   ");
            Response.Write("<script>window.alert('AVISO: El Registro Fue Modificado Exitosamente')</script>");


            //actualiza BD//
            DataSet ds = new DataSet();
            ds = objNeCursos.ListadoCursos();
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
    
    //---///////////////////////////////////////////////////////////////////////////////////////////////////
    protected void DTUsuario_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void TUsername_TextChanged(object sender, EventArgs e)
    {

    }

    protected void THoraCurso_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TNombreProfesor_TextChanged(object sender, EventArgs e)
    {

    }

    protected void BCancelar_Click(object sender, EventArgs e)
    {
        // listarTablapersonalizada();


        Gridview3.Visible = true;

        DataSet ds = new DataSet();
        // EscondeControl();
        ds = objNeNombreApellidoProf.negListadoNombreApellido();

        if (ds.Tables[0].Rows.Count > 0)
        {
            Gridview3.DataSource = ds.Tables[0];
            Gridview3.DataBind();
            //PListadoEstudiante.Visible = true;
        }

        else
        {

            Response.Write("<script>window.alert('AVISO: No existen registros.')</script>");

        }

       // Gridview3.Visible = false;

    }

    protected void Gridview3_SelectedIndexChanged(object sender, EventArgs e)
    {
        

        DataSet ds = new DataSet();

        objEntProfesores.IdProfesor = Convert.ToInt16(Gridview3.DataKeys[Gridview3.SelectedIndex].Value.ToString());
        ds = objNeNombreApellidoProf.SeleccionaPorfesor(objEntProfesores.IdProfesor);

        if (ds.Tables[0].Rows.Count > 0)
        {

            ObjetoATextbox(ds);

            // EscondeControl();
            // PListadoEstudiante.Visible = false;

            // PnlAltas.Visible = true;
            Gridview3.Visible = false;
        }

    }

    protected void CancelAll_Click(object sender, EventArgs e)
    {
        TNombreCurso.Text = "";
        THoraCurso.Text = "";
        TNombreProfesor.Text = "";
        TApellidoProfesor.Text = "";
        TMateria.DataTextFormatString = "";
        
            
        //DTUsuario.Text = "";


        Button2.Enabled = true;
        Button2.Text = "Ingresar";
    }

    protected void TMateria_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}