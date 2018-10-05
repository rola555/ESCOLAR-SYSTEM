<%@ Page Title="" Language="C#" MasterPageFile="~/MasterLogin.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    
			                        <asp:TextBox ID="TextBox1" placeholder="Ingrese Usuario" class="form-username form-control" runat="server"></asp:TextBox>
                                    
        
        <br />
                                  
     <asp:TextBox ID="TextBox2" type="password" placeholder="Ingrese Contraseña"  class="form-password form-control" runat="server"></asp:TextBox>

			                   
                              
        <br />
    
                                    <asp:Button ID="Button1" runat="server" Text="Entrar" class="btn btn-lg btn-block btn-warning"  OnClick="Button1_Click" />
       
</asp:Content>
    

