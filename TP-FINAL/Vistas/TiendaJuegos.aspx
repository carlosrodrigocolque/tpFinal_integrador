<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TiendaJuegos.aspx.cs" Inherits="Vistas.TiendaJuegos" %>

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
            <section class="tienda">
                <div class="ContFiltro">
                    <asp:Label CssClass="tituloTienda" ID="Label1" runat="server" Text="TIENDA"></asp:Label>
                    <div class="filtro">
                        <asp:Label CssClass="textoFiltro" ID="Label2" runat="server" Text="Buscar Juego Por Nombre"></asp:Label>
                        <asp:TextBox ID="txtNombreFiltro" runat="server" Width="213px"></asp:TextBox>
                        <asp:Button CssClass="botonFiltro" ID="btnBuscar" runat="server" Text="Buscar" />
                    </div>
                </div>
                <div class="contenedorJuegos">
                    <div class="contFiltros">
                        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource2">
                            <ItemTemplate>
                                &nbsp;<asp:Button CssClass="btnCategoria" ID="btnCat" runat="server" Text='<%# Eval("NombreDeCategoria_CT") %>' Width="335px" />
<br />
                            </ItemTemplate>
                        </asp:DataList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ChePlayConnectionString %>" SelectCommand="SELECT [NombreDeCategoria_CT] FROM [Categorias]"></asp:SqlDataSource>
                    </div>
                    <div class="ListaJuegos">
                        <asp:ListView ID="listJuegos" runat="server" DataSourceID="SqlDataSource1" GroupItemCount="3">
                            <%--<AlternatingItemTemplate>
                                <td runat="server" style="background-color:#FFF8DC;">Nombre_JU:
                                    <asp:Label ID="Nombre_JULabel" runat="server" Text='<%# Eval("Nombre_JU") %>' />
                                    <br />
                                    URLportada_JU:
                                    <asp:Label ID="URLportada_JULabel" runat="server" Text='<%# Eval("URLportada_JU") %>' />
                                    <br />
                                    Descripcion_JU:
                                    <asp:Label ID="Descripcion_JULabel" runat="server" Text='<%# Eval("Descripcion_JU") %>' />
                                    <br />
                                </td>
                            </AlternatingItemTemplate>--%>
                            <EditItemTemplate>
                                <td runat="server" style="background-color:#008A8C;color: #FFFFFF;">Nombre_JU:
                                    <asp:TextBox ID="Nombre_JUTextBox" runat="server" Text='<%# Bind("Nombre_JU") %>' />
                                    <br />
                                    URLportada_JU:
                                    <asp:TextBox ID="URLportada_JUTextBox" runat="server" Text='<%# Bind("URLportada_JU") %>' />
                                    <br />
                                    Descripcion_JU:
                                    <asp:TextBox ID="Descripcion_JUTextBox" runat="server" Text='<%# Bind("Descripcion_JU") %>' />
                                    <br />
                                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" />
                                    <br />
                                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
                                    <br />
                                </td>
                            </EditItemTemplate>
                            <EmptyDataTemplate>
                                <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                                    <tr>
                                        <td>No se han devuelto datos.</td>
                                    </tr>
                                </table>
                            </EmptyDataTemplate>
                            <EmptyItemTemplate>
                                <td runat="server" />
                            </EmptyItemTemplate>
                            <GroupTemplate>
                                <tr id="itemPlaceholderContainer" runat="server">
                                    <td id="itemPlaceholder" runat="server"></td>
                                </tr>
                            </GroupTemplate>
                            <InsertItemTemplate>
                                <td runat="server" style="">Nombre_JU:
                                    <asp:TextBox ID="Nombre_JUTextBox" runat="server" Text='<%# Bind("Nombre_JU") %>' />
                                    <br />
                                    URLportada_JU:
                                    <asp:TextBox ID="URLportada_JUTextBox" runat="server" Text='<%# Bind("URLportada_JU") %>' />
                                    <br />
                                    Descripcion_JU:
                                    <asp:TextBox ID="Descripcion_JUTextBox" runat="server" Text='<%# Bind("Descripcion_JU") %>' />
                                    <br />
                                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
                                    <br />
                                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" />
                                    <br />
                                </td>
                            </InsertItemTemplate>
                            <ItemTemplate>
                                <td runat="server" style="background-color:#DCDCDC;color: #000000;" class="caja">&nbsp;<asp:Label CssClass="nombreJuego" ID="lblNombreJuego" runat="server" Text='<%# Eval("Nombre_JU") %>' />
                                    <br />
                                    <asp:Image CssClass="imgLista" ID="Image1" runat="server" ImageUrl='<%# Eval("URLportada_JU") %>' />
                                    <br />
                                    <asp:Label CssClass="descripcion" ID="lblDescripcion" runat="server" Text='<%# Eval("Descripcion_JU") %>' />
                                    <br />
                                    <div class="precio">
                                        <asp:Label CssClass="precioUnitario" ID="lblPrecio" runat="server" Text='<%# Eval("PrecioUnitario_PXJ") %>'></asp:Label>
                                        <asp:Label CssClass="simboloPesos" ID="Label3" runat="server" Text="$"></asp:Label>
                                        <br />
                                    </div>
                                    <asp:Button CssClass="botonCarrito" ID="btnCarrito" runat="server" Text="Agregar al Carrito" />
                                    <br />
                                </td>
                           </ItemTemplate>
                            <LayoutTemplate>
                                <table runat="server">
                                    <tr runat="server">
                                        <td runat="server">
                                            <table id="groupPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                                <tr id="groupPlaceholder" runat="server">
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr runat="server">
                                        <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                                            <asp:DataPager ID="DataPager1" runat="server" PageSize="6">
                                                <Fields>
                                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                                    <asp:NumericPagerField />
                                                    <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                                </Fields>
                                            </asp:DataPager>
                                        </td>
                                    </tr>
                                </table>
                            </LayoutTemplate>
                            <SelectedItemTemplate>
                                <td runat="server" style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">Nombre_JU:
                                    <asp:Label ID="Nombre_JULabel" runat="server" Text='<%# Eval("Nombre_JU") %>' />
                                    <br />
                                    URLportada_JU:
                                    <asp:Label ID="URLportada_JULabel" runat="server" Text='<%# Eval("URLportada_JU") %>' />
                                    <br />
                                    Descripcion_JU:
                                    <asp:Label ID="Descripcion_JULabel" runat="server" Text='<%# Eval("Descripcion_JU") %>' />
                                    <br />
                                </td>
                            </SelectedItemTemplate>
                        </asp:ListView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ChePlayConnectionString %>" SelectCommand="SELECT Juegos.Nombre_JU,NombreDePlataforma_PL, Juegos.URLportada_JU, Juegos.Descripcion_JU, PlataformasxJuegos.PrecioUnitario_PXJ  FROM (Juegos INNER JOIN PlataformasxJuegos ON Juegos.CodJuego_JU = PlataformasxJuegos.CodJuego_JU_PXJ ) inner join Plataformas on CodPlataforma_PL=CodPlataforma_PL_PXJ"></asp:SqlDataSource>
                    </div>
                </div>
            </section>
        </main>
    </form>
</body>
</html>
