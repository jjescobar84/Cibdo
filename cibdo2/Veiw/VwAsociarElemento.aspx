<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VwAsociarElemento.aspx.cs" Inherits="Veiw.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <!-- Vista para asociar los elementos-->

      <div class="container">
    <div class="row">
      <div class="col-xs-6">
        <div class="col-se-6">

          <div style="height:540px;width:600px" class="container">
            <br>
            <br>
            <center>
              <h1>Registrar Alquiler</h1> </center>
            <br>
            <br>
            <center>
              <div class="form-group">
                <label for="Nombre" class="col-sm-2 control-label">Nombre:</label>
                <div class="col-sm-10">
                  <input style="width: 300px;" type="text" class="form-control">
                </div>
              </div>
              <br>
              <br>
              <br>
              <div class="form-group">
                <label for="Documento" class="col-sm-2 control-label">Apellido:</label>
                <div class="col-sm-10">
                  <input style="width: 300px" type="text" class="form-control">
                </div>
              </div>
              <br>
              <br>
              <div class="form-group">
                <label for="Tipo De Documento" class="col-sm-2 control-label">Tipo documento:</label>
                <div class="col-sm-10">
                  <select style="width: 300px;" class="form-control">
                    <option>C.C</option>
                    <option>C.E</option>
                  </select>
                </div>
              </div>
              <br>
              <br>
              <div class="form-group">
                <label class="col-sm-2 control-label" for="Ed">Número documento:</label>
                <div class="col-sm-10">
                  <input style="width: 300px;" type="number" class="form-control">
                </div>
              </div>
              <br>
              <br>
              <div class="form-group">
                <label class="col-sm-2 control-label" for="Ed">Fecha inicio:</label>
                <div class="col-sm-10">
                  <input style="width: 300px;" type="date" class="form-control">
                </div>
              </div>
              <br>
              <br>
              <div class="form-group">
                <label class="col-sm-2 control-label" for="Ed">Fecha fin:</label>
                <div class="col-sm-10">
                  <input style="width: 300px;" type="date" class="form-control">
                </div>
              </div>
              <br>
              <br>
              <div class="form-group">
                <label class="col-sm-2 control-label" for="Ed">Número fijo:</label>
                <div class="col-sm-10">
                  <input style="width: 300px;" type="number" class="form-control">
                </div>
              </div>
              <br>
              <br>
              <div class="form-group">
                <label class="col-sm-2 control-label" for="Ed">Número celular:</label>
                <div class="col-sm-10">
                  <input style="width: 300px;" type="number" class="form-control">
                </div>
              </div>
              <br>
              <br>
              <div class="form-group">
                <label class="col-sm-2 control-label" for="Ed">Barrio:</label>
                <div class="col-sm-10">
                  <input style="width: 300px;" type="text" class="form-control">
                </div>
              </div>
              <br>
              <br>
              <div class="form-group">
                <label class="col-sm-2 control-label" for="Ed">Dirección:</label>
                <div class="col-sm-10">
                  <input style="width: 300px;" type="text" class="form-control">
                </div>
              </div>
              <div class="tab-content">
                <div class="tab-pane active">
                  <br>
                  <br>
                  <br>
                  <button type="submit" class="btn btn-danger" style="margin-right:20px"><a style="color:white" href="Registrar-Alquiler.html">Cancelar</a></button>
                  <button type="submit" class="btn btn-success" style="margin-left:20px"><a style="color:white" href="Registrar-Alquiler.html">Registrar</a></button>
                </div>
              </div>
          </div>
        </div>
      </div>
      <div class="col-xs-6">
        <div class="col-ms-6">
          <ul class="tabs">
            <li>
              <input type="radio" name="tabs" id="tab-1">
              <label for="tab-1">Objetos</label>
              <div class="tab-content">
                <p>
                  polla grande
                </p>
              </div>
            </li>
            <li>
              <input type="radio" name="tabs" id="tab-2">
              <label for="tab-2">Espacio</label>
              <div class="tab-content">
                <p>
                  <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" GridLines="none" CssClass="mGrid">
                   <Columns> 
                       <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
                       <asp:BoundField DataField="descripcion" HeaderText="Tipo" SortExpression="descripcion"/>
                       <asp:BoundField DataField="costo" HeaderText="Costo" SortExpression="costo"/>
                       <asp:BoundField DataField="estado_espacio" HeaderText="Estado" SortExpression="estado_espacio"/>
                       
                   </Columns>
                 </asp:GridView>
                </p>
              </div>
            </li>
          </ul>
        </div>
      </div>
    </div>
  </div>
</asp:Content>