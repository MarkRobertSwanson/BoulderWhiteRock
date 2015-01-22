<%@ Page Title="News And Events" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="News.aspx.cs" Inherits="BoulderWhiteRock.News" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h3>
        News and Events
    </h3>
    <p id="mainText" class="mainText">
        <asp:Label ID="contentText" runat="server"></asp:Label>
        <br />
        <br />
        <A href="Boulder White Rock Annual Meeting.docx" target='_blank' title="Click Here to Download Form">Click Here to Download Form</A>
    </p>
</asp:Content>
