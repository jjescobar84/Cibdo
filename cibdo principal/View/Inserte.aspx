<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inserte.aspx.cs" Inherits="View.Inserte" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="Content/parsley.css" rel="stylesheet" />
    <link href="Css/bootstrap.css" rel="stylesheet" />
    <link href="Css/bootstrap.min." rel="stylesheet" />
    <title>Registrar Recordatorios</title>
     <center><h10>Registrar Recordatorio</h10></head><br></br>
         

<body>
    <form id="form1" runat="server">
    <div>
    
         
  
        <center><asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label><asp:TextBox ID="TextBox2" runat="server" required=""></asp:TextBox><br></br></center>
        <center><asp:Label ID="Label3" runat="server" Text="Fecha"></asp:Label><asp:TextBox ID="TextBox3" runat="server" required=""></asp:TextBox><br></br></center>
        <center><asp:Label ID="Label4" runat="server" Text="Hora"></asp:Label><asp:TextBox ID="TextBox4" runat="server" required=""></asp:TextBox><br></br></center>
       <center> <asp:Label ID="Label5" runat="server" Text="Descripcion"></asp:Label><asp:TextBox ID="TextBox5" runat="server" required=""></asp:TextBox><br></br>
           <center> <label>Tipo:</label><asp:DropDownList ID="DropDownList1" runat="server" Width="134px">
            <asp:ListItem Value="Reunión">Reunion</asp:ListItem>
            <asp:ListItem Value="Taller">Taller</asp:ListItem>
        </asp:DropDownList><br></br>
    </div>
        <center><asp:Button ID="Button1" runat="server" Text="Registrar" Height="35px" Width="201px" OnClick="Button1_Click1" Class="btn btn-danger" /></center>
         <script src="parsley.js"></script>
    </form>
       <script src="Scripts/bootstrap.js"></script>
     <script src="Scripts/bootstrap.js"></script>
</body>
</html>
