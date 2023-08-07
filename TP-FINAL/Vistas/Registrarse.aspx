<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="Vistas.Registrarse" %>

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
            <section class="Registrarse">
                <div class="ContFormRegis">
                    <asp:Label CssClass="tituloRegistrar" ID="Label1" runat="server" Text="REGISTRATE A CHEPLAY"></asp:Label>
                    <div class="DeDos">
                        <div class="cajasForm">
                            <asp:Label class="lblDatosReg" ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                            <asp:TextBox CssClass="txtDatosReg" ID="txtNombreReg" runat="server" Width="210px"></asp:TextBox>
                        </div>
                        <div class="cajasForm">
                            <asp:Label class="lblDatosReg" ID="Label3" runat="server" Text="Apellido:"></asp:Label>
                            <asp:TextBox CssClass="txtDatosReg" ID="txtApellidoReg" runat="server" Width="210px"></asp:TextBox>
                        </div>
                    </div>
                     <div class="DeDos">
                        <div class="cajasForm">
                            <asp:Label class="lblDatosReg" ID="Label4" runat="server" Text="DNI:"></asp:Label>
                            <asp:TextBox CssClass="txtDatosReg" ID="txtDNIReg" runat="server" Width="210px"></asp:TextBox>
                        </div>
                        <div class="cajasForm">
                            <asp:Label class="lblDatosReg" ID="Label5" runat="server" Text="Telefono:"></asp:Label>
                            <asp:TextBox CssClass="txtDatosReg" ID="txtTelefonoReg" runat="server" Width="210px"></asp:TextBox>
                        </div>
                    </div>
                    <div class="DeDos">
                        <div class="cajasForm">
                            <asp:Label class="lblDatosReg" ID="Label6" runat="server" Text="Direccion:"></asp:Label>
                            <asp:TextBox CssClass="txtDatosReg" ID="txtDireccionReg" runat="server" Width="210px"></asp:TextBox>
                        </div>
                        <div class="cajasForm">
                            <asp:Label class="lblDatosReg" ID="Label7" runat="server" Text="NickName:"></asp:Label>
                            <asp:TextBox CssClass="txtDatosReg" ID="txtNickNameReg" runat="server" Width="210px"></asp:TextBox>
                        </div>
                    </div>
                    <div class="DeDos">
                        <div class="cajasForm">
                            <asp:Label class="lblDatosReg" ID="Label8" runat="server" Text="Contraseña:"></asp:Label>
                            <asp:TextBox CssClass="txtDatosReg" ID="txtContraseñaReg" runat="server" Width="210px" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="cajasForm">
                            <asp:Label class="lblDatosReg" ID="Label9" runat="server" Text="RepitaContraseña:"></asp:Label>
                            <asp:TextBox CssClass="txtDatosReg" ID="txtRepConstraseñaReg" runat="server" Width="210px" TextMode="Password"></asp:TextBox>
                        </div>
                    </div>
                    <asp:Button CssClass="btnRegistrarse" ID="BtnRegistrarse" runat="server" Text="Registrate" OnClick="BtnRegistrarse_Click" />
                    <div class="yaTengoCuenta">
                        <asp:Label CssClass="lblDatosReg" ID="Label10" runat="server" Text="Ya tenes Cuenta?"></asp:Label>
                        <asp:HyperLink CssClass="LinkMandaIniciarSession" ID="LinkIniciarSesion" runat="server" NavigateUrl="~/IngresarUsuario.aspx">Inicia Sesíon</asp:HyperLink>
                    </div>
                </div>
            </section>
        </main>
    </form>
</body>
</html>
