<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Web.Index" %>
<%@ Register src="UserControl/sidebar.ascx" tagname="sidebar" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="sidebarHolder" runat="server">
    <uc1:sidebar ID="sidebar1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="100%">
    <Columns>
        <asp:BoundField DataField="NTitle" HeaderText="标题" SortExpression="NTitle" />
        <asp:BoundField DataField="NContent" HeaderText="内容" SortExpression="NContent" />
        <asp:BoundField DataField="NAuthor" HeaderText="作者" SortExpression="NAuthor">
        <HeaderStyle Width="60px" />
        </asp:BoundField>
        <asp:BoundField DataField="NTime" DataFormatString="{0:yyyy-y-yy}" HeaderText="时间" SortExpression="NTime">
        <HeaderStyle Width="80px" />
        </asp:BoundField>
    </Columns>
</asp:GridView>
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetModelList" TypeName="ITCastOCSS.BLL.Notice">
    <SelectParameters>
        <asp:Parameter DefaultValue=" " Name="strWhere" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
</asp:Content>
