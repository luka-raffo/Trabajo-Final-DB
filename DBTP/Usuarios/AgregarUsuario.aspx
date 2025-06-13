<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="DBTP.Usuarios.AgregarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" type="text/css" href="styles.css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 29px;
            margin-left: 256px;
        }
        .auto-style3 {
            height: 46px;
        }
        .auto-style4 {
            height: 37px;
        }
        .auto-style6 {
            height: 23px;
            width: 178px;
        }
        .auto-style8 {
            width: 10px;
        }
        .auto-style9 {
            height: 37px;
            width: 10px;
        }
        .auto-style10 {
            height: 46px;
            width: 10px;
        }
        .auto-style13 {
            width: 239px;
        }
        .auto-style14 {
            height: 37px;
            width: 239px;
        }
        .auto-style15 {
            height: 46px;
            width: 239px;
        }
        .auto-style22 {
            width: 169px;
        }
        .auto-style23 {
            height: 37px;
        }
        .auto-style24 {
            height: 46px;
        }
        .auto-style26 {
            height: 30px;
            width: 178px;
        }
        .auto-style27 {
            height: 37px;
            width: 178px;
        }
        .auto-style28 {
            height: 46px;
            width: 178px;
        }
        .auto-style32 {
            width: 208px;
        }
        .auto-style33 {
            height: 39px;
            width: 208px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p style="margin-left: 157px">
                <asp:HyperLink ID="hypAgregarOdontologo" runat="server" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="Medium" Font-Underline="True" ForeColor="#3366FF" NavigateUrl="AñadirOdontologo.aspx">Agregar Odontologo</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="hypListarOdontologo" runat="server" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="Medium" Font-Underline="True" ForeColor="#3366FF" NavigateUrl="ListarOdontologos.aspx">Listado de Odontologos</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="hypEliminarOdontologo" runat="server" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="Medium" Font-Underline="True" ForeColor="#3366FF" NavigateUrl="EliminarOdontologo.aspx">Eliminar Odontologo</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
        <div style="margin-left: 372px">
            <asp:Label ID="lblAgregarOdontologos" runat="server" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="X-Large" ForeColor="#00CC00" Text="¡AGREGAR USUARIO!"></asp:Label>
        </div>
            <br />
        <div style="margin-left: 463px">
        </div>
            <br />
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style9">
                    <br />
                </td>
                <td class="auto-style27">
                    <asp:Label ID="lblNombreUsuario" runat="server" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="Medium" Text="Nombre Usuario"></asp:Label>
                    <br />
                </td>
                <td class="auto-style23" colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtNombreUsuario" runat="server" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="Medium" ></asp:TextBox>
                    <br />
                </td>
                <td class="auto-style14"></td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <br />
                </td>
                <td class="auto-style28">
                    <asp:Label ID="lblcontraseniaUsuario" runat="server" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="Medium" Text="Contraseña"></asp:Label>
                    <br />
                </td>
                <td class="auto-style24" colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtContraseniaUsuario" runat="server" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="Medium"></asp:TextBox>
                    <br />
                </td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
            
            <tr>
                <td class="auto-style10"></td>
                <td class="auto-style6"><asp:Button ID="btnAceptar0" runat="server" BorderStyle="Solid" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="Medium" ForeColor="#33CC33" Text="Aceptar" OnClick="btnAceptar0_Click" />
                </td>
                <td class="auto-style32">
                    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                </td>
                
        </table>
    </form>
</body>
</html>