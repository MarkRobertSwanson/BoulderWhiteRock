<%@ Page Title="Contact Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="ContactUs.aspx.cs" Inherits="BoulderWhiteRock.ContactUs" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h3>
        Contact Us
    </h3>
    <p id="mainText" class="mainText">
        <asp:Label ID="contentText" runat="server"></asp:Label>
    </p>
</asp:Content>
