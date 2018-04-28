<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="moduloHostal.aspx.cs" Inherits="HostalWeb.Presentacion.moduloHostal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Módulo Administración Hostal</h2>
    <div class="contenedorHostal">
        <div class="box" >
            <h3>Registrar Empleado</h3>
                <a href="../templates/mantenedorEmpleado.aspx">Mantenedor Empleado (completo)???</a><br />
                <a href="../templates/ingresarEmpleado.aspx">Ingresar Empleado</a><br />
                <a href="../templates/obtenerDatoEmpleado.aspx">Obtener Dato Empleado</a><br />
                <a href="../templates/obtenerListaEmpleados.aspx">Obtener Lista Empleado</a><br />
                <a href="../templates/ModificarEmpleado.aspx">Modificar Empleado</a>
        </div>
    </div>
</asp:Content>
