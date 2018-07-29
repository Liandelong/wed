<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Web.student.Index" %>
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
        个人信息
    </div>
    <div class="c">

        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="ObjectDataSource1" Height="50px" Width="100%">
            <Fields>
 <asp:BoundField DataField="SNo" HeaderText="学号" SortExpression="SNo" >
                <HeaderStyle Width="100px" />
                </asp:BoundField>
 <asp:BoundField DataField="SName" HeaderText="姓名" SortExpression="SName" />
 <asp:BoundField DataField="SClass" HeaderText="班级" SortExpression="SClass" />
 <asp:BoundField DataField="SMajor" HeaderText="专业" SortExpression="SMajor" />
 <asp:BoundField DataField="SGrade" HeaderText="年级" SortExpression="SGrade" />
 <asp:BoundField DataField="SActualNum" HeaderText="已选课数" SortExpression="SActualNum" />
            <%--   
                <asp:BoundField DataField="SID" HeaderText="SID" SortExpression="SID" />
                <asp:BoundField DataField="SPwd" HeaderText="SPwd" SortExpression="SPwd" />
                <asp:BoundField DataField="SSex" HeaderText="SSex" SortExpression="SSex" />               
                <asp:BoundField DataField="SType" HeaderText="SType" SortExpression="SType" />
                <asp:BoundField DataField="SDepartment" HeaderText="SDepartment" SortExpression="SDepartment" />              
                <asp:BoundField DataField="SMaxNum" HeaderText="SMaxNum" SortExpression="SMaxNum" />                
                <asp:BoundField DataField="SBirthday" HeaderText="SBirthday" SortExpression="SBirthday" />
                <asp:BoundField DataField="SInTime" HeaderText="SInTime" SortExpression="SInTime" />
               
                <asp:BoundField DataField="SNote" HeaderText="SNote" SortExpression="SNote" />--%>
            </Fields>
        </asp:DetailsView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetModel" TypeName="ITCastOCSS.BLL.Student">
            <SelectParameters>
                <asp:SessionParameter Name="SID" SessionField="user" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>

    </div>
</asp:Content>
