<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AgregarEmpleado.aspx.cs" Inherits="CalculaBonos.AgregarEmpleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/Agregar.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="containerAll">
        <h3>Crear Nuevo Empleado</h3>
        <div id="containerForm">
            <asp:Label id="LabelID" Text="ID:" runat="server"/>
            <asp:Label id="Label6" Text="" runat="server"/>            
            <br />
            <asp:Label id="LabelName" Text="Nombre:" runat="server"/>
            <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
            <br />
            <asp:Label id="LabelSueldo" Text="Sueldo:" runat="server"/>
            <input id="inputSueldo" type="number"/>
            <br />
            <asp:Label id="LabelEdad" Text="Edad:" runat="server"/>
            <input id="inputEdad" type="number" min="18" max="80"/>
            <br />
            <asp:Label id="LabelSexo" Text="Sexo:" runat="server"/>
            <asp:DropDownList ID="DDLSexo" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Label id="LabelNac" Text="Nacionalidad:" runat="server"/>
            <asp:DropDownList ID="DDLNac" runat="server">
            </asp:DropDownList>
            <br />
            <hr />

            <asp:CheckBox ID="PHP" runat="server" AutoPostBack="true" Enabled="true" Checked="false"/>
            <asp:Label ID="Label3" runat="server" Text="Curso PHP"></asp:Label>
            <br />
            <asp:CheckBox ID="Java" runat="server" AutoPostBack="true" Enabled="true" Checked="false"/>
            <asp:Label ID="Label1" runat="server" Text="Curso Java"></asp:Label>
            <br />
            <asp:CheckBox ID="Asp" runat="server" AutoPostBack="true" Enabled="true" Checked="false"/>
            <asp:Label ID="Label2" runat="server" Text="Curso Asp.net"></asp:Label>
            <hr />

            <asp:Label id="Label4" Text="Años en la empresa:" runat="server"/>
            <input id="aniosEmpresa" type="number" min="1" max="60"/>
            <hr />
            <asp:Button ID="Button1" runat="server" Text="Agregar Empleado"/>
        </div>
    </div>
    <script src="Content/Agregar.js"></script>
</asp:Content>
