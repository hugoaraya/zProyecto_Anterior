<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="IngresarProveedor.aspx.cs" Inherits="HostalWeb.Presentacion.templates.IngresarProveedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 256px;
        }
        .auto-style2 {
            width: 303px;
        }
        .auto-style3 {
            width: 256px;
            height: 20px;
        }
        .auto-style4 {
            width: 303px;
            height: 20px;
        }
        .auto-style5 {
            height: 20px;
        }
        .auto-style6 {
            margin-left: 0px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">Ingresar Proveedor</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Rut</td>
            <td class="auto-style2">
                <asp:TextBox ID="txt_rut" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Nombre</td>
            <td class="auto-style2">
                <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Telefono</td>
            <td class="auto-style2">
                <asp:TextBox ID="txt_telefono" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Direccion</td>
            <td class="auto-style4">
                <asp:TextBox ID="txt_direccion" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td class="auto-style1">Rubro</td>
            <td class="auto-style2">
                <asp:DropDownList ID="ddl_rubro" runat="server" CssClass="auto-style6" Height="16px" Width="124px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Correo</td>
            <td class="auto-style2">
                <asp:TextBox ID="txt_correo" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="lb_msj" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                <asp:Button ID="btn_ingresar" runat="server" OnClick="btn_ingresar_Click" Text="Ingresar" />
                &nbsp;<a href="ObtenerListaProveedores.aspx">Proveedores</a>
                </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
