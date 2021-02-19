<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CalculaBonos.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/Styles.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="containerAll">
        <h3>Lista de Empleados</h3>
        <div id="containerTable">          
            <asp:GridView ID="ListaEmpleados" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="#" />
                    <asp:BoundField DataField="name" HeaderText="Nombre completo" />
                    <asp:BoundField DataField="sueldo" HeaderText="Sueldo" />
                    <asp:BoundField DataField="sexo" HeaderText="Sexo" />
                    <asp:BoundField DataField="nacionalidad" HeaderText="Nacionalidad" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
    <script src="Content/Events.js"></script>
</asp:Content>
