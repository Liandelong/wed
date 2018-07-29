<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="TeacherList.aspx.cs" Inherits="Web.Admin.Teacher" %><%@ Register src="sidebar.ascx" tagname="sidebar" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="sidebarHolder" runat="server">
    <uc1:sidebar ID="sidebar1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="title">
        老师列表
    </div>
    <div class="c">

        <asp:GridView DataKeyNames="TID" ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="100%">
            <Columns>
               <%-- <asp:BoundField DataField="TID" HeaderText="TID" SortExpression="TID" />--%>
                <asp:HyperLinkField DataNavigateUrlFields="TID" DataNavigateUrlFormatString="TeacherInfo.aspx?id={0}" DataTextField="TName" HeaderText="姓名" />
                <asp:BoundField DataField="TNo" HeaderText="编号" SortExpression="TNo" />
                <asp:BoundField DataField="TSex" HeaderText="性别" SortExpression="TSex" />
                <asp:BoundField DataField="TMajor" HeaderText="专业" SortExpression="TMajor" />
               <%-- <asp:BoundField DataField="TPwd" HeaderText="TPwd" SortExpression="TPwd" />--%>
                <asp:BoundField DataField="TDepartment" HeaderText="部门" SortExpression="TDepartment" />
                <asp:BoundField DataField="TTitle" HeaderText="职称" SortExpression="TTitle" />
                <asp:BoundField DataField="TIsAdmin" HeaderText="身份" SortExpression="TIsAdmin" />
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton OnClientClick="return confirm('确认删除吗？')" ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="删除"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetModelList" TypeName="ITCastOCSS.BLL.Teacher" DataObjectTypeName="ITCastOCSS.Model.Teacher" DeleteMethod="Delete">
            <SelectParameters>
                <asp:Parameter DefaultValue=" TIsAdmin=0" Name="strWhere" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>

    </div>
</asp:Content>
