<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailsProduct.aspx.cs" Inherits="SP.Pages.Products.DetailsProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <style>
        :root {
    box-sizing: border-box;
    font-size: calc(1vw + 0.5em);
}
        img{
            width:50%;
        }
    </style>
     <title><asp:Label runat="server" ID="NameProductLabel"></asp:Label></title>
     <strong><asp:Label runat="server" ID="LabelNameProduct"></asp:Label></strong></br>
    <asp:Label runat="server" ID="LabelMessage"></asp:Label>
    <asp:Image runat="server" ID="ImageProducts" />
    <asp:Label runat="server" ID="LabelDescriptionProduct"  WordWrap = "true"></asp:Label>

</asp:Content>
