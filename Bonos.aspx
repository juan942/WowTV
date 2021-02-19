<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Bonos.aspx.cs" Inherits="CalculaBonos.Bonos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/BonoStyles.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--Datos del empleado--%>

    <div id="containerAll">
        <h3>Calcular Bono de Empleado</h3>
        <div id="containerAll-head">
            <%--DDL para elegir el empleado--%>
            <asp:DropDownList runat="server" ID="ddlEmpleados" AutoPostBack="true" onselectedindexchanged="ddlEmpleados_SelectedIndexChanged" Width="182px">
            </asp:DropDownList>
            <br />
        </div>
        <div id="containerAll-left">
            <%--Detalles del Empleado--%>
            <asp:Label id="LabelID" Text="ID:" runat="server"/>
            <asp:Label id="LabelID2" Text="" runat="server"/>
            <br />
            <asp:Label id="LabelSueldo" Text="Sueldo:" runat="server"/>
            <asp:Label id="LabelSueldo2" Text="" runat="server"/>
            <br />
            <asp:Label id="LabelEdad" Text="Edad:" runat="server"/>
            <asp:Label id="LabelEdad2" Text="" runat="server"/>
            <br />
            <asp:Label id="LabelSexo" Text="Sexo:" runat="server"/>
            <asp:Label id="LabelSexo2" Text="" runat="server"/>
            <br />
            <asp:Label id="LabelNac" Text="Nacionalidad:" runat="server"/>
            <asp:Label id="LabelNac2" Text="" runat="server"/>
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

            <asp:RadioButton id="Radio1" GroupName="Antiguedad" Text="1 a 10 años" BackColor="AliceBlue" runat="server"/>
            <br />
            <asp:RadioButton id="Radio2" GroupName="Antiguedad" Text="Más de 10 años" BackColor="AliceBlue" runat="server"/>
            <hr />
        </div>
        <div id="containerAll-right">
            <%-- Desglose de el bono --%>
            <asp:Label id="AumentoSexo1" Text="Bono por Género: " runat="server"/>
            <asp:Label id="AumentoSexo2" Text="" runat="server"/>
            <br />
            <asp:Label id="AumentoEdad1" Text="Bono por Edad: " runat="server"/>
            <asp:Label id="AumentoEdad2" Text="" runat="server"/>
            <br />
            <asp:Label id="DecrementoNac1" Text="Decremento por Nacionalidad: " runat="server"/>
            <asp:Label id="DecrementoNac2" Text="" runat="server"/>
            <br />
            <asp:Label id="AumentoAntigedad1" Text="Bono por antiguedad: " runat="server"/>
            <asp:Label id="AumentoAntigedad2" Text="" runat="server"/>
            <br />
            <hr />
            <asp:Label id="LabelBono" Text="Bono: " runat="server"/>
            <asp:Label id="LabelBono2" Text="" runat="server"/>
            <hr />
            <asp:Button ID="Button1" runat="server" Text="Calcular" OnClick="Button1_Click"/>
            <asp:Button ID="Limpiar" runat="server" Text="Limpiar"/>
        </div>
    </div>

    <script src="Content/Bono.js"></script>
</asp:Content>
