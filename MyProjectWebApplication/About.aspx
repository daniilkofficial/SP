<%@ Page Title="О нас" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="SP.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Цель и задачи.</h3>
    <asp:Label runat="server">Целью Единого портала поставщиков является удовлетворение спроса потребителей с наилучшим качеством и по самой выгодным ценам.</asp:Label>
    <h3>Задачи:</h3>
    <asp:Label runat="server">1. Оперативные закупки товаров по тендерам.</asp:Label>
    <asp:Label runat="server">2. Гарантия качественной работы.</asp:Label>
    <asp:Label runat="server">3. Формирование лучших услуг.</asp:Label>
</asp:Content>
