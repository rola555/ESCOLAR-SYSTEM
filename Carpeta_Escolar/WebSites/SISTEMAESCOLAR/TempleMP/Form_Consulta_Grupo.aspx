<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/TempleMP/MasteAdmin.master" AutoEventWireup="true" CodeFile="Form_Consulta_Grupo.aspx.cs" Inherits="TempleMP_Form_Estudiante" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form id="Form1" runat="server">
    

 <!--<div class="container ">-->
    <br />
     <br />
     <br />
    <nav class="navbar navbar-expand navbar-dark bg-dark">
    
      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExample02" aria-controls="navbarsExample02" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>

      <div class="collapse navbar-collapse" id="navbarsExample02">
        <ul class="navbar-nav mr-auto">
          <li class="nav-item active">
           
          </li>
          <li class="nav-item">
           
          </li>
        </ul>
       
          <div class="col-md-12 col-md-offset-0">
	                        
	                        <asp:Button ID="Blistar"  class="btn btn-primary btn-lg" runat="server" Text="Listar/BD"  OnClick="Blistar_Click" />
	                        <asp:Button ID="BNuevo" class="btn btn-primary btn-lg" runat="server" OnClick="BNuevo_Click" Text="Nuevo"  />
	                       
	                    </div>

          
              <div class="navbar-brand">   
                  <br />      
                

                  </div> <!-- fin navbar-brand-->

        </div>
     
    </nav> 




     
    
    
        
                        
              
                       
              
    
  
<!------------------------------------------------------------------------------------------------------ -->
    <!--  //////////////////// comienza opciones de menu ////////////////////////--> 
    
      <div class="container"> 
          
         
              <div class ="text-left">  
                 <h4 class="py-4">Consulta de grupos :</h4>
                  <br />
                  <br />
                   
              </div>
       
               
   <div class="row justify-content-center"> 
      
           <!------- /////////////////Username////////////////////////////-->
          
             <div class="form-group col-md-3">   
             <asp:Label ID="Label1" runat="server" Text="Seleccione/Grupo:" Font-Bold="True"  ></asp:Label>    
           
                 <asp:DropDownList ID="DGrupo" class="form-control"    runat="server" ToolTip="Seleccione Curso" OnSelectedIndexChanged="DGrupo_SelectedIndexChanged"  >
                  </asp:DropDownList>              
                                              
      
                      
             </div>
       
   
              <!------- /////////////////Nombre////////////////////////////-->
             
             <div class="form-group col-md-3">  
                 <br />
                 
               </div>
           

            <!------- /////////////////Correo////////////////////////////-->
         
           <div class="form-group col-md-3">  
                    </div>
     
       </div>  <!-- <!-- fin div class row justify   //////////////////////////////////////////////-->
         
<!-- ---------------------------------------------------------------------------------------------  -->

           <!------- /////////////////Contraseña////////////////////////////-->      
   <div class="row justify-content-center"> 
              
           <div class="form-group col-md-3"> 

            </div>
          
            
                                        
    
         <!------- /////////////////Apellido////////////////////////////--> 
                
                     
                     
                              
 
       </div>  <!-- fin div class row justify  //////////////////////////////////////////////-->  
          
          
          <div class="row justify-content-center">    
      <div class="form-group col-md-3">               
    
          </div>
       </div>
               
                     
        </div>   <!-- fin class container-->          
                      
           
        <!-- fin clase div container//////////////////////////////////////////////////////777-->  
   
    

            
       
    
   
   
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TTTutor" runat="server" Visible="False" Width="160px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
    <asp:TextBox ID="TMensaje" runat="server" BackColor="#669999" Enabled="False" Width="284px" Visible="False"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    

    <asp:Panel ID="Panel3" runat="server" BackColor="#ECF0F5">
        





         <!--<div class="container ">-->

    <nav class="navbar navbar-expand navbar-dark bg-dark">
    
      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExample02" aria-controls="navbarsExample02" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>

      <div class="collapse navbar-collapse" id="navbarsExample3">
        <ul class="navbar-nav mr-auto">
          <li class="nav-item active">
           
          </li>
          <li class="nav-item">
           
          </li>
        </ul>
       
         
	                      
	    <div class="col-md-12 col-md-offset-0">               
        <asp:Button ID="BConsultar" class="btn btn-primary btn-lg" runat="server"   Text="Consultar" OnClick="BConsultar_Click" />
       
        <asp:Button ID="Button3" class="btn btn-primary btn-lg" runat="server"    Text="Modificar"  OnClick="Button3_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      
        <asp:Button ID="Button4" class="btn btn-primary btn-lg" runat="server"    Text="Eliminar Alumnos"  OnClick="Button1_Click" />    
         </div>

	                   

          
              <div class="navbar-brand">   
                  <br />      
                

                  </div> <!-- fin navbar-brand-->

        </div>
     
    </nav> 

       
       


    </asp:Panel>
    <p>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="ListarGrupPersonalizado" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="DGrupo" Name="NombreGrupo" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>

   </p>
    <div class="box-body table-responsive no-padding">
    <asp:Panel ID="Panel4" runat="server"></asp:Panel>
        <asp:GridView ID="GridView1" class="table table-bordered table-hover dataTable" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataKeyNames="IdGrupo" GridLines="Horizontal" Height="82px" Width="1094px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowPaging="True" DataSourceID="SqlDataSource1">
            <Columns>
                 <asp:TemplateField>
           <HeaderTemplate>
                                  Selecciona&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <p> &nbsp;<asp:CheckBox ID="CheckAll" runat="server" AutoPostBack="true" OnCheckedChanged="CheckAll_CheckedChanged"/>
           </HeaderTemplate>
            <ItemTemplate>
                                      <asp:CheckBox runat="server" ID="chk_selec" />
             </ItemTemplate>
</asp:TemplateField>
                <asp:BoundField DataField="IdGrupo" HeaderText="IdGrupo" InsertVisible="False" ReadOnly="True" SortExpression="IdGrupo" />
                <asp:BoundField DataField="ClaveGrupo" HeaderText="ClaveGrupo" SortExpression="ClaveGrupo" />
                <asp:BoundField DataField="NombreGrupo" HeaderText="NombreGrupo" SortExpression="NombreGrupo" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                <asp:BoundField DataField="NombreCurso" HeaderText="NombreCurso" SortExpression="NombreCurso" />
                <asp:BoundField DataField="CodigoAula" HeaderText="CodigoAula" SortExpression="CodigoAula" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>
        </div>
   
    <p>
    <br />
</p>
        </form>
</asp:Content>

