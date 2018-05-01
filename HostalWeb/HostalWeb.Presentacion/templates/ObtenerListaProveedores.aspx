<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="ObtenerListaProveedores.aspx.cs" Inherits="HostalWeb.Presentacion.templates.ObtenerListaProveedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 205px;
        }
        .auto-style3 {
            width: 197px;
        }
        .auto-style4 {
            width: 179px;
        }
        .auto-style5 {
            width: 179px;
            height: 144px;
        }
        .auto-style6 {
            width: 205px;
            height: 144px;
        }
        .auto-style7 {
            width: 197px;
            height: 144px;
        }
        .auto-style8 {
            height: 144px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
        <table style="width:100%;">
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style1">Listado de Proveedores</td>
                <td class="auto-style3">Rubro</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                <td class="auto-style6">
                    <asp:GridView ID="GvProveedor" runat="server" AllowPaging="True" OnPageIndexChanging="GvProveedor_PageIndexChanging" PageSize="5">
                    </asp:GridView>
                </td>
                <td class="auto-style7">
                    <asp:GridView ID="Gv_Rubro" runat="server" AllowPaging="True" OnPageIndexChanging="Gv_Rubro_PageIndexChanging" PageSize="5">
                    </asp:GridView>
                </td>
                <td class="auto-style8">
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style1"><a href="IngresarProveedor.aspx">Ingresar Proveedor</a></td>                
            </tr>
        </table>
    
</asp:Content>
