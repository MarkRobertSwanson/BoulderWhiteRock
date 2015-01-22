<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="BoulderWhiteRock._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to the Boulder and White Rock
        <br />Ditch and Reservoir Company
    </h2>
    <p id="mainText" class="mainText">
        <asp:Label ID="contentText" runat="server"></asp:Label>
    </p>
    <p class="mainText">
</asp:Content>
