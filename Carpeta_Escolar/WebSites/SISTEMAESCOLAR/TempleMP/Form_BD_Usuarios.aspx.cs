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

    
///NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
    protected void Blistar_Click(object sender, EventArgs e)
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

   
    //NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
    
    
   
    //NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
    private void ObjetoATextbox(DataSet ds)
    {
         ds.Tables[0].Rows[0]["username"].ToString();
        ds.Tables[0].Rows[0]["Password"].ToString();
        ds.Tables[0].Rows[0]["Nombre"].ToString();
        ds.Tables[0].Rows[0]["Apellido"].ToString();
        ds.Tables[0].Rows[0]["Correo"].ToString();
        ds.Tables[0].Rows[0]["TipoUsuario"].ToString();
    }

    //NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        
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
    //NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN






    
}