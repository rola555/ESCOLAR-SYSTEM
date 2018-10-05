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

    //-----------------------------------------------------------------------------------------------

    public E_Estudiante objEntEstudiante = new E_Estudiante();

    public N_Estudiante objNeEstudiante = new N_Estudiante();

//----------------------------------------------------------------------------------------------------------

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Blistar_Click(object sender, EventArgs e)
    {


        DataSet ds = new DataSet();
        //EscondeControl();
        ds = objNeEstudiante.ListadoEstudiante();

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
    //--------------------------------------------------------------------------------------------------------------------
    private void MuestraMsg(string pTipo, string mMsg)
    {

       

    }

    private void TextBoxObjeto()
    {


        objEntEstudiante.Nombre = TNombres.Text;
        objEntEstudiante.Apellido = TApellido.Text;
        objEntEstudiante.Genero = DGenero.Text;
        objEntEstudiante.Fecha_Nacimiento = TFechaNacimiento.Text;
        objEntEstudiante.Direccion = TDireccion.Text;
        objEntEstudiante.Tutor = TNombreTutor.Text;
        objEntEstudiante.Tel_Tutor = TTelTutor.Text;



    }
    //------------------------------------------------------------------------------------------------------------------
    protected void Button2_Click(object sender, EventArgs e)
    {

        if (TNombres.Text == "")
        {

            Response.Redirect("Form_EstudianteAdmin.aspx");
            //Response.Write("<script>window.alert('AVISO: No existe datos para eliminar')</script>");
            //MuestraMsg("AVISO", "NO hay registros Para eliminar");

        }

        int nGrabados = -1;

        TextBoxObjeto();

        nGrabados = objNeEstudiante.abcEstudiante("AGREGAR", objEntEstudiante);

        if (nGrabados != -1)
        {


            //MuestraMsg("AVISO", "El Registro Fue grabado exitosamente   ");
            Response.Write("<script>window.alert('AVISO: El Registro Fue Guardado Exitosamente')</script>");

            TNombres.Text = "";
            TApellido.Text = "";
            
            TFechaNacimiento.Text = "";
            TDireccion.Text = "";
            TNombreTutor.Text = "";
            TTTutor.Text = "";

            DataSet ds = new DataSet();
            ds = objNeEstudiante.ListadoEstudiante();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }
        else
        {
            //MuestraMsg("ERROR", "El registro no pudo ser grabado");
            Response.Write("<script>window.alert('AVISO: El Registro No Pudo Ser Guardado')</script>");
        }


    }
    //-----------------------------------------------------------------------------------------------------------------------------
    protected void BNuevo_Click(object sender, EventArgs e)
    {


        TNombres.Text = "";
        TApellido.Text = "";
        
        TFechaNacimiento.Text = "";
        TDireccion.Text = "";
        TNombreTutor.Text = "";
        TTTutor.Text = "";
        Button2.Enabled = true;
        Button2.Text = "Ingresar";


    }
    //------------------------------------------------------------------------------------------------------
    private void ObjetoATextbox(DataSet ds)
    {

        TNombres.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
        TApellido.Text = ds.Tables[0].Rows[0]["Apellido"].ToString();
        DGenero.Text = ds.Tables[0].Rows[0]["Genero"].ToString();
        TFechaNacimiento.Text = ds.Tables[0].Rows[0]["Fecha_Nacimiento"].ToString();
        TDireccion.Text = ds.Tables[0].Rows[0]["Direccion"].ToString();
        TNombreTutor.Text = ds.Tables[0].Rows[0]["Tutor"].ToString();
        TTTutor.Text = ds.Tables[0].Rows[0]["Tel_Tutor"].ToString();

    }
    //----------------------------------------------------------------------------------------------------------
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

        Button2.Text = " ";
        Button2.Enabled = false;
        Button1.Visible = true;
        Button3.Visible = true;

        DataSet ds = new DataSet();

        objEntEstudiante.Id_Estudiante = Convert.ToInt16(GridView1.DataKeys[GridView1.SelectedIndex].Value.ToString());
        ds = objNeEstudiante.SelecionaEstudiante(objEntEstudiante.Id_Estudiante);

        if (ds.Tables[0].Rows.Count > 0)
        {

            ObjetoATextbox(ds);
            // EscondeControl();
            // PListadoEstudiante.Visible = false;

            // PnlAltas.Visible = true;
            // LblMsg.Visible = false;
        }

    }
    //--------------------------------------------------------------------------------------------------------------------------
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (TNombres.Text == "")
        {

            Response.Redirect("Form_EstudianteAdmin.aspx");
            //Response.Write("<script>window.alert('AVISO: No existe datos para eliminar')</script>");
            //MuestraMsg("AVISO", "NO hay registros Para eliminar");
        }
        int nResultado = -1;

        TextBoxObjeto();
        objEntEstudiante.Id_Estudiante = Convert.ToInt16(GridView1.DataKeys[GridView1.SelectedIndex].Value.ToString());

        nResultado = objNeEstudiante.abcEstudiante("BORRAR", objEntEstudiante);

        if (nResultado != -1)
        {

            DataSet ds = new DataSet();
            // EscondeControl();
            ds = objNeEstudiante.ListadoEstudiante();

            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
                //PListadoEstudiante.Visible = true;
            }


            //MuestraMsg("AVISO", "El Registro Fue Eliminado exitosamente   ");
            Response.Write("<script>window.alert('AVISO: El Registro Fue Eliminado Exitosamente')</script>");
            TNombres.Text = "";
            TApellido.Text = "";
           
            TFechaNacimiento.Text = "";
            TDireccion.Text = "";
            TNombreTutor.Text = "";
            TTTutor.Text = "";

        }

        else
        {

            //MuestraMsg("AVISO", "El Registro No Pudo Ser Eliminado   ");
            Response.Write("<script>window.alert('AVISO: El Registro No Pudo Ser Eliminado')</script>");




        }


    }
    //--------------------------------------------------------------------------------------
    protected void Button3_Click(object sender, EventArgs e)
    {


        if (TNombres.Text == "")
        {

            Response.Redirect("Form_EstudianteAdmin.aspx");
            //Response.Write("<script>window.alert('AVISO: No existe datos para eliminar')</script>");
            //MuestraMsg("AVISO", "NO hay registros Para eliminar");
        }

        int nResultado = -1;

        TextBoxObjeto();
        objEntEstudiante.Id_Estudiante = Convert.ToInt16(GridView1.DataKeys[GridView1.SelectedIndex].Value.ToString());

        nResultado = objNeEstudiante.abcEstudiante("MODIFICAR", objEntEstudiante);

        if (nResultado != -1)
        {
            // MuestraMsg("AVISO", "El Registro Fue Modificado exitosamente   ");
            Response.Write("<script>window.alert('AVISO: El Registro Fue Modificado Exitosamente')</script>");
            DataSet ds = new DataSet();
            ds = objNeEstudiante.ListadoEstudiante();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        else
        {

            //MuestraMsg("ERROR", "El registro no pudo ser Modificado");
            Response.Write("<script>window.alert('AVISO: El Registro No Pudo Ser Modificado')</script>");




        }


    }
    //----------------------------------------------------------------------------------------------------------------------
    protected void BCancelar_Click(object sender, EventArgs e)
    {
        TNombres.Text = "";
        TApellido.Text = "";
       
        TFechaNacimiento.Text = "";
        TDireccion.Text = "";
        TNombreTutor.Text = "";
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