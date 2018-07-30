<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Password.aspx.cs" Inherits="Web.teacher.Password" %>
<%@ Register src="sidebar.ascx" tagname="sidebar" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="sidebarHolder" runat="server">
    <uc1:sidebar ID="sidebar1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="title">
        修改密码
    </div>
    <div>
        <div>
        旧密码：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div>
        新密码：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <div>
        新密码：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" Text="修改" OnClick="Button1_Click" /><asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    
</asp:Content>
