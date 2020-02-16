<%@ Page Title="Товары" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListProducts.aspx.cs" Inherits="SP.Pages.Products.ListProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        :root {
    box-sizing: border-box;
    font-size: calc(1vw + 0.5em);
}
        img{
            width:100%;
        }
    </style>
     <h1><%: Title %>.</h1>
    </br>
    <asp:GridView ID="ProductsGridView" runat="server" BackColor="White" Width="100%" BorderColor="#CCCCCC" BorderStyle="None" AutoGenerateColumns="False" BorderWidth="1px" CellPadding="3">
        <Columns>

            <asp:BoundField DataField="RowNumb" HeaderText="№" />
           <asp:ImageField DataImageUrlField="ImageProduct" HeaderText="Фото товара"  >
           </asp:ImageField>
            <asp:BoundField HeaderText="Цена товара" DataField="Price" DataFormatString="{0:C}" />
           <asp:BoundField DataField="NameProduct" HeaderText="Наименование товара" />
           <asp:BoundField DataField="DescriptionProduct" HeaderText="Описание товара" />
         <asp:HyperLinkField HeaderText="Подробности" NavigateUrl="~/Pages/Products/DetailsProduct.aspx" Text="Подробности" runat="server" DataNavigateUrlFields="IdProduct" DataNavigateUrlFormatString="DetailsProduct.aspx?id={0}" meta:resourcekey="HyperLinkFieldResource1"   />
        
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#000066" HorizontalAlign="Left" BackColor="White" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
    </asp:GridView>
</asp:Content>
