<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/TempleMP/MasteAdmin.master" AutoEventWireup="true" CodeFile="Form_Grupos.aspx.cs" Inherits="TempleMP_Form_Estudiante" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form id="Form1" runat="server">
    

    <!--<div class="container ">--><br />
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
	                        
	                        
	                        <asp:Button ID="BNuevo" class="btn btn-primary btn-lg" runat="server" OnClick="BNuevo_Click" Text="Cancelar"  />
	                       
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
                 <h4 class="py-4">Datos Para Creación De Grupos :</h4>
                  <br />
                  <br />
                   
              </div>
       
               
   <div class="row justify-content-center"> 
      
           <!------- /////////////////Username////////////////////////////-->
          
             <div class="form-group col-md-3">   
             <asp:Label ID="Label1" runat="server" Text="Nombre/Grupo:" Font-Bold="True"  ></asp:Label>    
             <asp:TextBox ID="TNombreGrupo" class="form-control"  placeholder="Nombre/Grupo" runat="server"></asp:TextBox>
             </div>
       
   
              <!------- /////////////////Nombre////////////////////////////-->
             
             <div class="form-group col-md-3">  
                  <asp:Label ID="Label2" runat="server" Text="Clave/Grupo : " Font-Bold="True"></asp:Label>
                  <asp:TextBox ID="TClaveGrupo"  class="form-control" placeholder="Clave/Grupo" runat="server" ></asp:TextBox>
               </div>
           

            <!------- /////////////////Correo////////////////////////////-->
         
           <div class="form-group col-md-3">  
                  <asp:Label ID="Label3"  runat="server" Text="Curso:" Font-Bold="True"></asp:Label>               
                   <asp:DropDownList ID="TCurso" class="form-control"    runat="server" ToolTip="Seleccione Curso" OnSelectedIndexChanged="TCurso_SelectedIndexChanged"  >
                  </asp:DropDownList>
                </div>
     
       </div>  <!-- <!-- fin div class row justify   //////////////////////////////////////////////-->


           <div class="row justify-content-center"> 
      
           <!------- /////////////////Username////////////////////////////-->
          
             <div class="form-group col-md-3">   
             <asp:Label ID="Label4" runat="server" Text="Aula :" Font-Bold="True"  ></asp:Label>    
             <asp:DropDownList ID="DropDownListAula" class="form-control"    runat="server" ToolTip="Seleccione Aula"  >
                  </asp:DropDownList>
                 
             </div>
       
   
              <!------- /////////////////Nombre////////////////////////////-->
             
             <div class="form-group col-md-3">  
               </div>
           

            <!------- /////////////////Correo////////////////////////////-->
         
           <div class="form-group col-md-3">  
                     <br />           
                  
                </div>
     
       </div>  <!-- <!-- fin div class row justify   //////////////////////////////////////////////-->
         
         
<!-- ---------------------------------------------------------------------------------------------  -->

           <!------- /////////////////Contraseña////////////////////////////-->      
   
          
          
          <div class="row justify-content-center">    
      <div class="form-group col-md-3">               
    
          </div>
       </div>
               
                     
        </div>   <!-- fin class container-->          
                      
           
        <!-- fin clase div container//////////////////////////////////////////////////////777-->  
   
    

            
       
    
   
   
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TTTutor" runat="server" Visible="False" Width="160px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
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
        <asp:Button ID="Button2" class="btn btn-primary btn-lg" runat="server"   Text="Ingresar" OnClick="Button2_Click" />
       
       
        
          
            
             <asp:Button ID="BAlumnos"  class="btn btn-primary btn-lg" runat="server" Text="Listar/Alumnos"  OnClick="BAlumnos_Click" />
         </div>

	                   

          
              <div class="navbar-brand">   
                  <br />      
                

                  </div> <!-- fin navbar-brand-->

        </div>
     
    </nav> 

       
       


    </asp:Panel>
    <p>
        
   </p>
    <div class="box-body table-responsive no-padding">
    <asp:Panel ID="Panel4" runat="server"></asp:Panel>
        <asp:GridView ID="GridView1" class="table table-bordered table-hover dataTable" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataKeyNames="Id_Estudiante" GridLines="Horizontal" Height="82px" Width="1087px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:TemplateField>
           <HeaderTemplate>
                                  
                Selecciona&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <p> &nbsp;<asp:CheckBox ID="CheckAll" runat="server" AutoPostBack="true" OnCheckedChanged="CheckAll_CheckedChanged" style="text-align: left" />
           </HeaderTemplate>
            <ItemTemplate>
                                      <asp:CheckBox runat="server" ID="chk_selec" />
             </ItemTemplate>
</asp:TemplateField>
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

