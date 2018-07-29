<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="TeacherInfo.aspx.cs" Inherits="Web.Admin.TeacherInfo" %>
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
        老师详细信息
    </div>
    <div class="c">

        <asp:DetailsView ID="DetailsView1" DataKeyNames="TID" runat="server" AutoGenerateRows="False" DataSourceID="ObjectDataSource1" Height="50px" Width="100%" OnItemInserted="DetailsView1_ItemInserted" OnItemInserting="DetailsView1_ItemInserting" OnItemUpdating="DetailsView1_ItemUpdating">
            <Fields>
                <asp:BoundField DataField="TID" HeaderText="TID" SortExpression="TID" Visible="False" />
                <asp:BoundField DataField="TNo" HeaderText="编号" SortExpression="TNo" />
                <asp:BoundField DataField="TName" HeaderText="姓名" SortExpression="TName">
                <HeaderStyle Width="100px" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="性别" SortExpression="TSex">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("TSex") %>'></asp:TextBox>      
                    </EditItemTemplate>
                    <InsertItemTemplate>
                       <asp:RadioButton ID="Man" GroupName="sex" runat="server" Text="男" />
                        <asp:RadioButton ID="Women" GroupName="sex" runat="server" Text="女" />
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("TSex") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="TMajor" HeaderText="专业" SortExpression="TMajor" />
                <asp:BoundField DataField="TPwd" HeaderText="TPwd" SortExpression="TPwd" Visible="False" />
                <asp:BoundField DataField="TDepartment" HeaderText="部门" SortExpression="TDepartment" />
                <asp:BoundField DataField="TTitle" HeaderText="职称" SortExpression="TTitle" />
                <asp:BoundField DataField="TIsAdmin" HeaderText="身份" SortExpression="TIsAdmin" Visible="False" />
                <asp:CommandField ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetModel" TypeName="ITCastOCSS.BLL.Teacher" DataObjectTypeName="ITCastOCSS.Model.Teacher" InsertMethod="Add" UpdateMethod="Update">
            <SelectParameters>
                <asp:QueryStringParameter Name="TID" QueryStringField="id" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>

    </div>
</asp:Content>
