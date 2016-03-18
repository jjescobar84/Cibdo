<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertObjetos.aspx.cs" Inherits="View.InsertObjetos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/parsley.css" rel="stylesheet" />
    <title>Registrar Ojetos</title>
     <center>  <h10>Registrar Objeto</h10> <br><br>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
   
        <center><asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label><asp:TextBox ID="TextBox1" runat="server" required=""></asp:TextBox><br><br>
        <center><asp:Label ID="Label2" runat="server" Text="Estado"></asp:Label><asp:TextBox ID="TextBox2" runat="server" required=""></asp:TextBox><br><br>
        <center></center><asp:Label ID="Label3" runat="server" Text="Cantidad"></asp:Label><asp:TextBox ID="TextBox3" runat="server" required=""></asp:TextBox><br><br>
 <center><asp:Button ID="Button1" runat="server" Text="Registrar" Height="35px" Width="201px" OnClick="Button1_Click1" />
    </div>
    </form>
     <script src="parsley.js"></script>
</body>
</html>
