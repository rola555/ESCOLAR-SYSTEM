<%@ Page Title="" Language="C#" MasterPageFile="~/TempleMP/MPA.master" AutoEventWireup="true" CodeFile="Defaults.aspx.cs" Inherits="TempleMP_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="Form1" runat="server">

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
<!--  //////////////////////////////////////////////////////////////////////////////////////////////////////////// -->
        
      <div class="container"> 
          
         
              <div class ="text-left">  
                 <h4 class="py-4">Datos para registro de Usuarios :</h4>
                  <br />
                  <br />
                   
              </div>
       
               
   <div class="row justify-content-center"> 

       <!--                ///////////////////////////////////////////////////////////////////////////Fin Titulo //////////////////////////-->

        <!------- /////////////////Username////////////////////////////-->
          
             <div class="form-group col-md-3">   
             <asp:Label ID="Label1" runat="server" Text="Seudónimo:" Font-Bold="True"  ></asp:Label>    
             <asp:TextBox ID="TUsername" class="form-control"  placeholder="Seudónimo de Usuario" runat="server"  OnTextChanged="TUsername_TextChanged"></asp:TextBox>
             </div>
       
   
              <!------- /////////////////Nombre////////////////////////////-->
             
             <div class="form-group col-md-3">  
                  <asp:Label ID="Label2" runat="server" Text="Nombre : " Font-Bold="True"></asp:Label>
                  <asp:TextBox ID="TNombre"  class="form-control" placeholder="Nombre de Usuario" runat="server" OnTextChanged="TNombre_TextChanged" ></asp:TextBox>
               </div>
           

            <!------- /////////////////Correo////////////////////////////-->
         
           <div class="form-group col-md-3">  
                  <asp:Label ID="Label3"  runat="server" Text="Correo :" Font-Bold="True"></asp:Label>
                  <asp:TextBox ID="TCorreo" class="form-control" placeholder="ejemplo_xx@hotmail.com" runat="server" OnTextChanged="TextBox1_TextChanged" ></asp:TextBox>
            </div>
     
       </div>  <!-- <!-- fin div class row justify   //////////////////////////////////////////////-->
         
<!-- ---------------------------------------------------------------------------------------------  -->

           <!------- /////////////////Contraseña////////////////////////////-->      
   <div class="row justify-content-center"> 
              
           <div class="form-group col-md-3"> 
           <asp:Label ID="Label4" runat="server" Text="Contraseña :" Font-Bold="True"></asp:Label>
           <asp:TextBox ID="TContraseña" class="form-control" placeholder="Contraseña" runat="server" OnTextChanged="TContraseña_TextChanged" ></asp:TextBox>
            </div>
          
            
                                        
    
         <!------- /////////////////Apellido////////////////////////////--> 
                
                     
         <div class="form-group col-md-3"> 
          <asp:Label ID="Label5" runat="server" Text="Apellido  : " Font-Bold="True"></asp:Label>
         <asp:TextBox ID="TApellido" class="form-control" placeholder="Apellido de Usuario" runat="server" OnTextChanged="TApellido_TextChanged"></asp:TextBox>                                   
         </div>
                                  
                              
 <!--<asp:Label ID="Label6"  runat="server" Text="Tipo/Usuario :"></asp:Label>-->  
         <div class="form-group col-md-3">  
         <asp:Label ID="Label7" runat="server" Text="Tipo/Usuario :" Font-Bold="True"></asp:Label>                                           
         <asp:DropDownList ID="DTUsuario"  class="form-control" runat="server"  OnSelectedIndexChanged="DTUsuario_SelectedIndexChanged">
         <asp:ListItem>Profesor</asp:ListItem>
         <asp:ListItem>Administrador</asp:ListItem>
         </asp:DropDownList> 
              </div>    
       </div>  <!-- fin div class row justify  //////////////////////////////////////////////-->  
          
          
          <div class="row justify-content-center">    
      <div class="form-group col-md-3">               
     <asp:Button ID="BCancelar" class="btn btn-primary btn-sm" runat="server"   Text="Cancelar" OnClick="BCancelar_Click" />
          </div>
       </div>
               
                     
        </div>   <!-- fin class container-->          
                      
           
        <!-- fin clase div container//////////////////////////////////////////////////////777-->  





        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TTTutor" runat="server" Visible="False" Width="160px"></asp:TextBox>
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
        <asp:Button ID="Button2" class="btn btn-primary btn-lg" runat="server"   Text="Ingresar" OnClick="Button2_Click" />
       
        <asp:Button ID="Button3" class="btn btn-primary btn-lg" runat="server"    Text="Modificar"  OnClick="Button3_Click" />
        
        <asp:Button ID="Button1" class="btn btn-primary btn-lg" runat="server"    Text="Eliminar"  OnClick="Button1_Click" />    
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
        <asp:GridView ID="GridView1" class="table table-bordered table-hover dataTable" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataKeyNames="IdUsuarioCuenta" GridLines="Horizontal" Height="82px" Width="1094px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="IdUsuarioCuenta" HeaderText="Id Usuario" />
                <asp:BoundField DataField="username" HeaderText="UserName" />
                <asp:BoundField DataField="Password" HeaderText="Contraseña" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre/Usuario" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido/Usuario" />
                <asp:BoundField DataField="Correo" HeaderText="Correo" />
                <asp:BoundField DataField="TipoUsuario" HeaderText="Tipo/Usuario" />
                <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
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







        </form><!-- ///////////////////////////////////////////Fin Form/////////////////////////////-->
</asp:Content>

