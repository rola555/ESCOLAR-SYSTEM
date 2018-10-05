using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Data;
using Control;
using Negocios;
using Datos;



public partial class TempleMP_Form_Estudiante : System.Web.UI.Page
{

    public E_Profesores objEntProfesor = new E_Profesores();

    public N_Profesor objNeProfesores = new N_Profesor();


    public E_Grupos objEntGrupos = new E_Grupos();
    public N_Grupos objNeGrupos = new N_Grupos();

    protected void Page_Load(object sender, EventArgs e)
    {
        seleccionarCurso();

    }

//-----------------------------------------------------------------------------------------------
    private void seleccionarCurso()//______--------///////////////////////////////////////////////////////////////////
    {

        if (IsPostBack == false)
        {
            D_ListarTablaGrupos objNegocioListarTablaGrupos = new D_ListarTablaGrupos();
            DGrupo.DataSource = objNegocioListarTablaGrupos.ListarGrupos();


            DGrupo.DataTextField = "NombreGrupo";
          //  DGrupo.DataValueField = "IdGrupo";
            DGrupo.DataBind();
        }

    }
//------------------------------------------------------------------------------------------------
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    
    //-------///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    protected void Blistar_Click(object sender, EventArgs e)
    {

        

    }
    //--------////////////////////////////////////////////////////////////////////////////////////////////////////////////////////7

    private void MuestraMsg(string pTipo, string mMsg)
    {

    }

    private void TextBoxObjeto()
    {
       
       

    }

    //--------------------///  ingresar registro  ///---------------------------------//
    protected void Button2_Click(object sender, EventArgs e)
    {
        

    }

    //-------------------------------------------------------------------------------------------------------------------


//----//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    protected void BNuevo_Click(object sender, EventArgs e)
    {


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

        int nGrabados = -1;


        foreach (GridViewRow row in GridView1.Rows)
        {
            CheckBox check = row.FindControl("chk_selec") as CheckBox;
            int Id = Convert.ToInt32(row.Cells[1].Text);
            // TAlumno.Text = Id.ToString();



            if (check.Checked)
            {


                nGrabados = -1;


                //objEntGrupos.NombreGrupo = TNombreGrupo.Text;
                //objEntGrupos.ClaveGrupo = TClaveGrupo.Text;
                //objEntGrupos.IdCurso = Convert.ToInt32(TCurso.SelectedValue);
                //objEntGrupos.IdAula = Convert.ToInt32(DropDownListAula.SelectedValue);
                objEntGrupos.IdGrupo = Id;

                //TextBoxObjetoParaIngresar(); //ya no se utiliza este metodo, se asignan los parametros aqui mismo.

                nGrabados = objNeGrupos.abcGrupo("BORRAR", objEntGrupos);
            }

        } // Termina foreach 


        if (nGrabados != -1)
        {
            Response.Write("<script>window.alert('AVISO: El Grupo Fue Creado Exitosamente')</script>");
            Response.Redirect("Form_Consulta_Grupo.aspx");
        }

        else
        {
            //MuestraMsg("ERROR", "El registro no pudo ser grabado");
            Response.Write("<script>window.alert('AVISO: NO ha Seleccionado Ningun registro de la BD de Alumnos')</script>");
        }

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
    protected void DTUsuario_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void TUsername_TextChanged(object sender, EventArgs e)
    {

    }

    protected void DGrupo_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void BConsultar_Click(object sender, EventArgs e)
    {
        // listarTablapersonalizada();





       
    }

    protected void CheckAll_CheckedChanged(object sender, EventArgs e)
    {
        //////////////////////////////////////7selleciona todo///////////////////////////////////////////////////////////////////

        bool a = ((CheckBox)GridView1.HeaderRow.FindControl("CheckAll")).Checked;

        for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
        {
            if (a == true)
            {
                ((CheckBox)GridView1.Rows[i].FindControl("chk_selec")).Checked = true;
            }
            else if (a == false)
            {
                ((CheckBox)GridView1.Rows[i].FindControl("chk_selec")).Checked = false;
            }

        }
    }
}