<%@ Page Title="Water Statistics" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="WaterStatistics.aspx.cs" Inherits="BoulderWhiteRock.WaterStatistics" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h3>
        Current Water Statistics
    </h3>
    <p id="mainText" class="mainText">
        <asp:Label ID="contentText" runat="server"></asp:Label>
    </p>
</asp:Content>
