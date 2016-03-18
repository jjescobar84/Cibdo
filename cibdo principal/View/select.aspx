<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="select.aspx.cs" Inherits="View.select" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Button" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="idRecordatorio" DataSourceID="LinqDataSource3" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
            <Columns>
                <asp:CommandField HeaderText="Opcion" ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="idRecordatorio" HeaderText="idRecordatorio" InsertVisible="False" ReadOnly="True" SortExpression="idRecordatorio" />
                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                <asp:BoundField DataField="fecha" HeaderText="fecha" SortExpression="fecha" />
                <asp:BoundField DataField="hora" HeaderText="hora" SortExpression="hora" />
                <asp:BoundField DataField="descripcion" HeaderText="descripcion" SortExpression="descripcion" />
                <asp:BoundField DataField="Persona_idPersona" HeaderText="Persona_idPersona" SortExpression="Persona_idPersona" />
                <asp:BoundField DataField="Tipo_recordatorio_descripcion" HeaderText="Tipo_recordatorio_descripcion" SortExpression="Tipo_recordatorio_descripcion" />
            </Columns>
        </asp:GridView>
        <asp:LinqDataSource ID="LinqDataSource3" runat="server" ContextTypeName="Model.DataClasses1DataContext" EnableDelete="True" EnableUpdate="True" EntityTypeName="" TableName="tb_Recordatorios">
        </asp:LinqDataSource>
        <asp:LinqDataSource ID="LinqDataSource2" runat="server" ContextTypeName="Model.DataClasses1DataContext" EnableUpdate="True" EntityTypeName="" TableName="tb_Recordatorios">
        </asp:LinqDataSource>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="Model.DataClasses1DataContext" EnableDelete="True" EntityTypeName="" TableName="tb_Recordatorios">
        </asp:LinqDataSource>
    </form>
    </body>
    </html>