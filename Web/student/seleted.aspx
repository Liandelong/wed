<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="seleted.aspx.cs" Inherits="Web.student.seleted" %>
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
        已选课程
    </div>
    <div class="c">

        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>

    </div>
</asp:Content>
