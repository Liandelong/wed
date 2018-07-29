<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="CourseInfo.aspx.cs" Inherits="Web.Admin.CourseInfo" %>
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
        课程详细信息
    </div>
    <div class="c">

        <asp:DetailsView DataKeyNames="CID" ID="DetailsView1"  runat="server" AutoGenerateRows="False" DataSourceID="ObjectDataSource1" Height="50px" Width="100%" OnItemInserted="DetailsView1_ItemInserted">
            <Fields>
                <%--<asp:BoundField DataField="CID" HeaderText="CID" SortExpression="CID" />--%>
                <asp:BoundField DataField="Description" HeaderText="描述" SortExpression="Description" />
                <asp:BoundField DataField="Grade" HeaderText="年级" SortExpression="Grade" />
                <asp:BoundField DataField="Term" HeaderText="学期" SortExpression="Term" />
                <asp:BoundField DataField="Credit" HeaderText="学分" SortExpression="Credit" />
                <asp:BoundField DataField="CName" HeaderText="课程名称" SortExpression="CName">
                <HeaderStyle Width="100px" />
                </asp:BoundField>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" InsertMethod="Add" SelectMethod="GetModel" TypeName="ITCastOCSS.BLL.Course" UpdateMethod="Update" DataObjectTypeName="ITCastOCSS.Model.Course">
            <SelectParameters>
                <asp:QueryStringParameter Name="CID" QueryStringField="id" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>

    </div>
</asp:Content>
