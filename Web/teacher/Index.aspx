<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Web.teacher.Index" %>
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
        教师个人信息
    </div>
    <div class="c">

        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="ObjectDataSource1" Height="50px" Width="100%">
            <Fields>
                <asp:BoundField DataField="TID" HeaderText="TID" SortExpression="TID" Visible="False" />
                <asp:BoundField DataField="TNo" HeaderText="教师编号" SortExpression="TNo">
                <HeaderStyle Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="TName" HeaderText="姓名" SortExpression="TName" />
                <asp:BoundField DataField="TSex" HeaderText="性别" SortExpression="TSex" />
                <asp:BoundField DataField="TMajor" HeaderText="专业" SortExpression="TMajor" />
                <asp:BoundField DataField="TPwd" HeaderText="密码" SortExpression="TPwd" Visible="False" />
                <asp:BoundField DataField="TDepartment" HeaderText="部门" SortExpression="TDepartment" />
                <asp:BoundField DataField="TTitle" HeaderText="职称" SortExpression="TTitle" />
                <asp:BoundField DataField="TIsAdmin" HeaderText="是否为管理员" SortExpression="TIsAdmin" />
            </Fields>
        </asp:DetailsView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetModel" TypeName="ITCastOCSS.BLL.Teacher">
            <SelectParameters>
                <asp:SessionParameter Name="TID" SessionField="user" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>

    </div>
</asp:Content>
