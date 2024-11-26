<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="login_3eroB.Registrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Timer ID="Timer1" Enabled="false" Interval="2000" OnTick="Timer1_Tick" runat="server"></asp:Timer>
                    <table class="auto-style1">
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td align ="center">
            <table class="auto-style2">
                <tr>
                    <td colspan="2" align="center">Registro de clientes</td>
                </tr>
                <tr>
                    <td>Nombre:</td>
                    <td>
                        <asp:TextBox ID="txt_nom" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Cedula:</td>
                    <td>
                        <asp:TextBox ID="txt_ced" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
    <td>Clave:</td>
    <td>
        <asp:TextBox ID="txt_clav" runat="server"></asp:TextBox>
    </td>
</tr>
                <tr>
    <td>Correo:</td>
    <td>
        <asp:TextBox ID="txt_correo" runat="server"></asp:TextBox>
    </td>
</tr>
                <tr>
    <td>Perfil:</td>
    <td>
        <asp:DropDownList ID="ddl_perfil" runat="server">
        </asp:DropDownList>
    </td>
</tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="Registrarse" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:LinkButton ID="lnk_regresa" runat="server" OnClick="lnk_regresa_Click">Regresar</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
                </ContentTemplate>            
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
