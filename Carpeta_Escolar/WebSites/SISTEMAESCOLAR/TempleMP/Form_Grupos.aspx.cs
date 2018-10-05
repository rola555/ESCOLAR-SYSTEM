using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;


using System.Data;
using Control;
using Negocios;
using Datos;



public partial class TempleMP_Form_Estudiante : System.Web.UI.Page
{
    public E_Grupos objEntGrupos = new E_Grupos();
    public N_Grupos objNeGrupos = new N_Grupos();

    //------------------------------------------------------------------------
    public E_Profesores objEntProfesor = new E_Profesores();
    public N_Profesor objNeProfesores = new N_Profesor();

    //---------------//-------------------------------//-------------------------------

    public N_Estudiante objNeEstudiantes = new N_Estudiante();
    public E_Estudiante objEntEstudiante = new E_Estudiante();


    protected void Page_Load(object sender, EventArgs e)
    {
        seleccionarAula();
        seleccionarCurso();
    }

    //-------------------------------------------------------------------------------------------------------------------
    private void seleccionarAula()
    {

        if (IsPostBack == false)
        {
            D_ListarTablaAula objNegocioListarTablaAulas = new D_ListarTablaAula();
            DropDownListAula.DataSource = objNegocioListarTablaAulas.ListarAula();


            DropDownListAula.DataTextField = "CodigoAula";
            DropDownListAula.DataValueField = "IdAula";
            DropDownListAula.DataBind();
        }

    }

    //---------------------------------------------------------------------------------------------------------------------

    private void seleccionarCurso()
    {

        if (IsPostBack == false)
        {
            D_ListarTablaCursos objNegocioListarTablaCursos = new D_ListarTablaCursos();
            TCurso.DataSource = objNegocioListarTablaCursos.ListarCursos();


            TCurso.DataTextField = "NombreCurso";
            TCurso.DataValueField = "IdCurso";
            TCurso.DataBind();
        }

    }
    //-----------------------------------------------------------------------------------------------------------------------
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    //-------///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    //--------////////////////////////////////////////////////////////////////////////////////////////////////////////////////////7

    private void MuestraMsg(string pTipo, string mMsg)
    {

    }

    private void TextBoxObjeto()
    {



    }


    //---------------------------------------------------------------------------------

    private void TextBoxObjetoParaIngresar()
    {
        objEntGrupos.NombreGrupo = TNombreGrupo.Text;
        objEntGrupos.ClaveGrupo = TClaveGrupo.Text;
        objEntGrupos.IdCurso = Convert.ToInt32(TCurso.SelectedValue);
        objEntGrupos.IdAula = Convert.ToInt32(DropDownListAula.SelectedValue);
       // objEntGrupos.IdEstudiante = Convert.ToInt32(TAlumno.Text);



    }

    //--------------------///  ingresar registro  ///---------------------------------//
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (TNombreGrupo.Text == "" || TClaveGrupo.Text == "")
        {

            Response.Write("<script>window.alert('AVISO: Por favor Llene Todos Los Campos')</script>");
            //Response.Write("Form_Grupos.aspx");

            DataSet ds = new DataSet();
            ds = objNeEstudiantes.ListadoEstudiante();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

            //MuestraMsg("AVISO", "NO hay registros Para eliminar");



        }

        int nGrabados = -1;


        foreach (GridViewRow row in GridView1.Rows)
        {
            CheckBox check = row.FindControl("chk_selec") as CheckBox;
            int Id = Convert.ToInt32(row.Cells[1].Text);
            // TAlumno.Text = Id.ToString();



            if (check.Checked)
            {


                nGrabados = -1;


                objEntGrupos.NombreGrupo = TNombreGrupo.Text;
                objEntGrupos.ClaveGrupo = TClaveGrupo.Text;
                objEntGrupos.IdCurso = Convert.ToInt32(TCurso.SelectedValue);
                objEntGrupos.IdAula = Convert.ToInt32(DropDownListAula.SelectedValue);
                objEntGrupos.IdEstudiante = Id;

                //TextBoxObjetoParaIngresar(); //ya no se utiliza este metodo, se asignan los parametros aqui mismo.

                nGrabados = objNeGrupos.abcGrupo("AGREGAR", objEntGrupos);
            }

        } // Termina foreach 


        if (nGrabados != -1)
        {
            Response.Write("<script>window.alert('AVISO: El Grupo Fue Creado Exitosamente')</script>");
            DataSet ds = new DataSet();
            ds = objNeEstudiantes.ListadoEstudiante();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        else
        {
            //MuestraMsg("ERROR", "El registro no pudo ser grabado");
            Response.Write("<script>window.alert('AVISO: NO ha Seleccionado Ningun registro de la BD de Alumnos')</script>");
        }



    }

    //-------------------------------------------------------------------------------------------------------------------


    //----//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    protected void BNuevo_Click(object sender, EventArgs e)
    {

        TNombreGrupo.Text = "";
        TClaveGrupo.Text = "";
       GridView1.Visible = false;

    }

    //-----/////////////////////////////////////////////////////////////////////////////////////////////////////////////


    //-------///////////////////////////////////////////////////////////////////////////////////////////////////////////
    private void ObjetoATextbox(DataSet ds)
    {




    }
    //-----------///////////////////////////////////////////////////////////////////////////////////////////////////////////7

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {




    }

    //----------/////////////////////////////////////////////////////////////////////////////////////////////////////////////

    protected void Button1_Click(object sender, EventArgs e)
    {


    }

    //---------------///////////////////////////////////////////////////////////////////////////////////////////////77
    protected void Button3_Click(object sender, EventArgs e)
    {




    }


    //---///////////////////////////////////////////////////////////////////////////////////////////////////
    protected void BCancelar_Click(object sender, EventArgs e)
    {



    }
    //---///////////////////////////////////////////////////////////////////////////////////////////////////




    protected void BAlumnos_Click(object sender, EventArgs e)
    {

        GridView1.Visible = true;
        // TNombreGrupo.Text = "";
        //TClaveGrupo.Text = "";
        //DTUsuario.Text = "";


        //  Button2.Enabled = true;
        //Button2.Text = "Ingresar";

        DataSet ds = new DataSet();
        // EscondeControl();
        ds = objNeEstudiantes.ListadoEstudiante();

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

    protected void Blistar_Click(object sender, EventArgs e)
    {

    }

    protected void TCurso_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void CheckAll_CheckedChanged(object sender, EventArgs e)
    {
        ///////////////////////////////////////7selleciona todo///////////////////////////////////////////////////////////////////

        bool a = ((CheckBox)GridView1.HeaderRow.FindControl("CheckAll")).Checked;

        for (int i = 0; i <= GridView1.Rows.Count -1; i++)
        {
           if( a == true)
            {
                ((CheckBox)GridView1.Rows[i].FindControl("chk_selec")).Checked = true;
            }
           else if(a == false)
            {
                ((CheckBox)GridView1.Rows[i].FindControl("chk_selec")).Checked = false;
            }

        }
    }
}