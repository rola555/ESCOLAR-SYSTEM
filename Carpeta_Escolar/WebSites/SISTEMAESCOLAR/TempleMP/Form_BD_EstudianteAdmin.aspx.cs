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

    public E_Estudiante objEntEstudiante = new E_Estudiante();

    public N_Estudiante objNeEstudiante = new N_Estudiante();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    
    //NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
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
//NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
    
    
    
    //NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
    private void ObjetoATextbox(DataSet ds)
    {
        ds.Tables[0].Rows[0]["Nombre"].ToString();
        ds.Tables[0].Rows[0]["Apellido"].ToString();
        ds.Tables[0].Rows[0]["Genero"].ToString();
        ds.Tables[0].Rows[0]["Fecha_Nacimiento"].ToString();
        ds.Tables[0].Rows[0]["Direccion"].ToString();
        ds.Tables[0].Rows[0]["Tutor"].ToString();
        ds.Tables[0].Rows[0]["Tel_Tutor"].ToString();
    }
    //NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        

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
    //NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN





    protected void CheckAll_CheckedChanged(object sender, EventArgs e)
    {

        //////////////////////////////////////7selleciona todo///////////////////////////////////////////////////////////////////

        bool a = ((CheckBox)GridView1.HeaderRow.FindControl("CheckAll")).Checked;

        for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
        {
            if (a == true)
            {
                ((CheckBox)GridView1.Rows[i].FindControl("CheckBox1")).Checked = true;
            }
            else if (a == false)
            {
                ((CheckBox)GridView1.Rows[i].FindControl("CheckBox1")).Checked = false;
            }

        }
    }
}