<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Vistas.Carrito" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="StyleSheet" href="Estilo.css" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
        <header class="Cabecera">
            <asp:ImageButton class="logo" ID="Logo" runat="server" ImageUrl="~/Imagenes2/logoProg3.png" OnClick="Logo_Click" />
            <nav class="LinkCabecera">
                <asp:HyperLink class="linkC" ID="Linktienda" runat="server" NavigateUrl="~/TiendaJuegos.aspx">Tienda</asp:HyperLink>
                <asp:HyperLink class="linkC" ID="Linkcarrito" runat="server" NavigateUrl="~/Carrito.aspx">Carrito</asp:HyperLink>
            </nav>
        </header>
        <main>
            <section class="Editar">
                <div class="contAgregar">
                    <asp:Label CssClass="tituloAgregar" ID="Label1" runat="server" Text="Carrito"></asp:Label>
                    <asp:Label CssClass="labelNom" ID="Label2" runat="server" Text="Estos son los juegos que seleccionaste"></asp:Label>
                    <asp:GridView ID="GrdJuegosCarrito" runat="server"></asp:GridView>
                    <asp:Button CssClass="btnRegistrarse" ID="btnComprar" runat="server" Text="Confirmar Compra" />
                </div>
            </section>
        </main>
    </form>
</body>
</html>
