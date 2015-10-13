<%@ Page Title="f i n E" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="_ContentTemplate" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MC" Runat="Server">
    <asp:Button ID="RegisterToggle" runat="server" Text="Register" OnClick="RegisterToggle_Click"/>
    
<asp:Panel ID="LoginPanel" runat="server" Visible="false">
    <asp:TextBox ID="User" runat="server" CausesValidation="true"></asp:TextBox>
    <asp:RequiredFieldValidator ID="UsernameValidation" runat="server" ControlToValidate="User" Display="Dynamic" ErrorMessage="Please Enter a Valid User Name" Text="Please Enter a Valid User Name"></asp:RequiredFieldValidator>
    <asp:Label ID="UserNameLabel" runat="server" Text="User Name" CssClass="LoginLabel"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="Password" runat="server" CausesValidation="true"></asp:TextBox>
    
    <asp:Label ID="PWText" runat="server" CssClass="LoginLabel" Text="Password"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="Email" runat="server" ></asp:TextBox><asp:Label ID="MailText" runat="server" Text="Email" CssClass="LoginLabel"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="EmailV" runat="server"></asp:TextBox><asp:Label ID="EmailConText" runat="server" Text="Confirm Email" CssClass="LoginLabel"></asp:Label>
    <br />
    <br />
    <asp:Button ID="Register" runat="server" Text="Register" OnClick="Reg" AutoPostBack="true"/>
    
</asp:Panel>
    
     
</asp:Content>

