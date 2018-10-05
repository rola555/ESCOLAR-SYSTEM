<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/TempleMP/MasteAdmin.master" AutoEventWireup="true" CodeFile="Form_Cursos.aspx.cs" Inherits="TempleMP_Form_Estudiante" %>




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
                 <h4 class="py-4">Datos para registro de Cursos :</h4>
                  <br />
                  <br />
                   
              </div>
       
               
   <div class="row justify-content-center"> 
      
           <!------- /////////////////Username////////////////////////////-->
          
             <div class="form-group col-md-3">   
             <asp:Label ID="Label1" runat="server" Text="Nombre/Curso:" Font-Bold="True"  ></asp:Label>    
             <asp:TextBox ID="TNombreCurso" class="form-control"  placeholder="Nombre de Curso" runat="server"  OnTextChanged="TUsername_TextChanged"></asp:TextBox>
             </div>
       
   
              <!------- /////////////////Nombre////////////////////////////-->
             
             <div class="form-group col-md-3">  
                  <asp:Label ID="Label2" runat="server" Text="Hora de Curso : " Font-Bold="True"></asp:Label>
                  <asp:TextBox ID="THoraCurso"  class="form-control" placeholder="Hora de Curso" runat="server" OnTextChanged="THoraCurso_TextChanged" ></asp:TextBox>
               </div>
           

            <!------- /////////////////Correo////////////////////////////-->
         
           <div class="form-group col-md-3">  
                  <asp:Label ID="Label3"  runat="server" Text="Seleccione Materia :" Font-Bold="True"></asp:Label>
                  <asp:DropDownList ID="TMateria" class="form-control"    runat="server" ToolTip="Seleccione Materia" OnSelectedIndexChanged="TMateria_SelectedIndexChanged"  >
                  </asp:DropDownList>
            </div>
     
       </div>  <!-- <!-- fin div class row justify   //////////////////////////////////////////////-->
         
<!-- ---------------------------------------------------------------------------------------------  -->

           <!------- /////////////////Contraseña////////////////////////////-->      
   <div class="row justify-content-center"> 
              
           <div class="form-group col-md-3"> 
           <asp:Label ID="Label4" runat="server" Text="Nombre de Profesor :" Font-Bold="True"></asp:Label>
           <asp:TextBox ID="TNombreProfesor" class="form-control" placeholder="Nombre de profesor"  runat="server" OnTextChanged="TNombreProfesor_TextChanged" onFocus="this.blur()" ></asp:TextBox>
             <asp:Button ID="BCancelar" class="btn btn-primary btn-sm" runat="server"   Text="Buscar" OnClick="BCancelar_Click" /> 
               <asp:gridview runat="server" ID="Gridview3" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="Gridview3_SelectedIndexChanged" Width="288px" AutoGenerateColumns="False" DataKeyNames="IdProfesor"
                    >
                   <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                   <Columns>
                       <asp:CommandField HeaderText="." ShowSelectButton="True" />
                       <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                       <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                   </Columns>
                   <EditRowStyle BackColor="#999999" />
                   <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                   <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                   <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                   <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                   <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                   <SortedAscendingCellStyle BackColor="#E9E7E2" />
                   <SortedAscendingHeaderStyle BackColor="#506C8C" />
                   <SortedDescendingCellStyle BackColor="#FFFDF8" />
                   <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
               </asp:gridview>
           </div>
          
        <div class="form-group col-md-3">  
                  <asp:Label ID="Label5" runat="server" Text="Apellido de profesor : " Font-Bold="True"></asp:Label>
                  <asp:TextBox ID="TApellidoProfesor"  class="form-control" placeholder="Apellido de Profesor" runat="server" OnTextChanged="THoraCurso_TextChanged"  onFocus="this.blur()" ></asp:TextBox>
                 
       
             </div>
                      
       
                                        
    
         <!------- /////////////////Apellido////////////////////////////--> 
                
                     
         <div class="form-group col-md-3"> 
             <br />
           
            <!-- <asp:Button ID="Buscar" class="btn btn-primary btn-sm" runat="server"   Text="Buscar" OnClick="BCancelar_Click" /> -->                               
         </div>
                                  
                              
 
       </div>  <!-- fin div class row justify  //////////////////////////////////////////////-->  
          
          
          <div class="row justify-content-center">    
      <div class="form-group col-md-3">               
   
          </div>
       </div>
               
            
      <div class="form-group col-md-3" aria-hidden="False">  
                  <asp:Label ID="Label6" runat="server" Text="Id prof: " Font-Bold="True" Visible="False"></asp:Label>
                  <asp:TextBox ID="TextBox123"  class="form-control" placeholder="id de profesor" runat="server" OnTextChanged="THoraCurso_TextChanged"  onFocus="this.blur()" Visible="False" ></asp:TextBox>
                 
       
             </div>          
        </div>   <!-- fin class container-->          
                      
           
        <!-- fin clase div container//////////////////////////////////////////////////////777-->  
   
    

            
      
   
   
   

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
            
        <asp:Button ID="CancelAll"  class="btn btn-primary btn-lg" runat="server" Text="Cancelar" OnClick="CancelAll_Click"></asp:Button>     
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
        <asp:GridView ID="GridView1" class="table table-bordered table-hover dataTable" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Height="82px" Width="1044px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="IdCurso">
            <Columns>
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

