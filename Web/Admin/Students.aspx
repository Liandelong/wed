<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="Web.Admin.Students" %>
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
        学生管理
    </div>
    <div>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="100%">
            <Columns>
               <%-- <asp:BoundField DataField="SID" HeaderText="SID" SortExpression="SID" />--%>
                <asp:BoundField DataField="SNo" HeaderText="学号" SortExpression="SNo" />
                <asp:BoundField DataField="SName" HeaderText="姓名" SortExpression="SName" />
               <%-- <asp:BoundField DataField="SPwd" HeaderText="SPwd" SortExpression="SPwd" />--%>
                <asp:BoundField DataField="SSex" HeaderText="性别" SortExpression="SSex" />
                <asp:BoundField DataField="SClass" HeaderText="班级" SortExpression="SClass" />
               <%-- <asp:BoundField DataField="SType" HeaderText="SType" SortExpression="SType" />
                <asp:BoundField DataField="SDepartment" HeaderText="SDepartment" SortExpression="SDepartment" />--%>
                <asp:BoundField DataField="SMajor" HeaderText="专业" SortExpression="SMajor" />
               <%-- <asp:BoundField DataField="SMaxNum" HeaderText="SMaxNum" SortExpression="SMaxNum" />
                <asp:BoundField DataField="SActualNum" HeaderText="SActualNum" SortExpression="SActualNum" />
                <asp:BoundField DataField="SBirthday" HeaderText="SBirthday" SortExpression="SBirthday" />
                <asp:BoundField DataField="SInTime" HeaderText="SInTime" SortExpression="SInTime" />--%>
                <asp:BoundField DataField="SGrade" HeaderText="年级" SortExpression="SGrade" />
               <%-- <asp:BoundField DataField="SNote" HeaderText="SNote" SortExpression="SNote" />--%>
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetModelList" TypeName="ITCastOCSS.BLL.Student">
            <SelectParameters>
                <asp:Parameter DefaultValue=" " Name="strWhere" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>

    </div>
</asp:Content>
