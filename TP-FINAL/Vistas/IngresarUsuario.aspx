<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IngresarUsuario.aspx.cs" Inherits="Vistas.IngresarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="StyleSheet" href="Estilo.css" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
        <main>
            <section class="ingresar">
                <div class="contForm">
                    <asp:Label CssClass="tituloIngresar" ID="Label1" runat="server" Text="INGRESAR"></asp:Label>
                    <asp:Label CssClass="labelNom" ID="Label2" runat="server" Text="Ingrese su nombre de usuario"></asp:Label>
                    <asp:TextBox CssClass="txtBoxIng" ID="txtNomUsuarioIng" runat="server" Width="230px"></asp:TextBox>
                    <asp:Label CssClass="labelNom" ID="Label3" runat="server" Text="Ingrese su contraseña"></asp:Label>
                    <asp:TextBox CssClass="txtBoxIng" ID="txtContraseñaIng" runat="server" Width="230px" TextMode="Password"></asp:TextBox>
                    <asp:Button CssClass="btnIng" ID="btnIngresar" runat="server" Text="Iniciar Sesíon" OnClick="btnIngresar_Click" />
                    <div class="MandoRegistrarse">
                        <asp:Label CssClass="preguntaReg" ID="Label4" runat="server" Text="Aun no tenes cuenta en ChePlay?"></asp:Label>
                        <asp:HyperLink CssClass="linkRegis" ID="linkRegis" runat="server" NavigateUrl="~/Registrarse.aspx">Registrate</asp:HyperLink>
                    </div>
                </div>
            </section>
        </main>
    </form>
</body>
</html>
