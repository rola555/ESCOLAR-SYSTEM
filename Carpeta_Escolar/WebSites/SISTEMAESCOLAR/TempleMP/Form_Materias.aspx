<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/TempleMP/MasteAdmin.master" AutoEventWireup="true" CodeFile="Form_Materias.aspx.cs" Inherits="TempleMP_Form_Estudiante" %>




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
                 <h4 class="py-4">Datos para registro de Materias :</h4>
                  <br />
                  <br />
                   
              </div>
       
               
   <div class="row justify-content-center"> 
      
           <!------- /////////////////Username////////////////////////////-->
          
             <div class="form-group col-md-3">   
             <asp:Label ID="Label1" runat="server" Text="Clave de Materia:" Font-Bold="True"  ></asp:Label>    
             <asp:TextBox ID="TClaveMateria" class="form-control"  placeholder="Clave de Materia" runat="server"  OnTextChanged="TUsername_TextChanged"></asp:TextBox>
             </div>
       
   
              <!------- /////////////////Nombre////////////////////////////-->
             
             <div class="form-group col-md-3">  
                  <asp:Label ID="Label2" runat="server" Text="Nombre de Materia : " Font-Bold="True"></asp:Label>
                  <asp:TextBox ID="TNombreMateria"  class="form-control" placeholder="Nombre de Materia" runat="server" ></asp:TextBox>
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
                
                     
         <div class="form-group col-md-6"> 
             
             <asp:Button ID="BCancelar" class="btn btn-primary btn-sm" runat="server"   Text="Cancelar" OnClick="BCancelar_Click" />                                
         </div>
                                  
                              
 
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
        <asp:GridView ID="GridView1" class="table table-bordered table-hover dataTable" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataKeyNames="IdMateria" GridLines="Horizontal" Height="82px" Width="1094px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="IdMateria" HeaderText="Id/Materia" />
                <asp:BoundField DataField="ClaveMateria" HeaderText="Clave/Materia" />
                <asp:BoundField DataField="NombreMateria" HeaderText="Nombre/Materia" />
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
    </form>
</asp:Content>

