<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Web.Admin.Index" %>
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
         课程管理
     </div>
     <div class="c">
         <a href="CourseInfo.aspx">添加</a>
         <asp:GridView ID="GridView1" DataKeyNames="CID" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="100%">
             <Columns>
                 <asp:BoundField DataField="CID" HeaderText="CID" SortExpression="CID" Visible="False" />
                 <asp:HyperLinkField DataNavigateUrlFields="CID" DataNavigateUrlFormatString="CourseInfo.aspx?id={0}" DataTextField="CName" HeaderText="课程名称" />
                 <asp:BoundField DataField="Grade" HeaderText="年级" SortExpression="Grade" />
                 <asp:BoundField DataField="Term" HeaderText="学期" SortExpression="Term" />
                 <asp:BoundField DataField="Credit" HeaderText="学分" SortExpression="Credit" />
                
               <%--<asp:BoundField DataField="Description" HeaderText="描述" SortExpression="Description" />--%>
                 <asp:TemplateField ShowHeader="False">
                     <ItemTemplate>
                         <asp:LinkButton OnClientClick="return confirm('确定删除？')" ID="LinkButton1"  runat="server" CausesValidation="False" CommandName="Delete" Text="删除"></asp:LinkButton>
                     </ItemTemplate>
                 </asp:TemplateField>
             </Columns>
         </asp:GridView>
         <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="ITCastOCSS.Model.Course" DeleteMethod="Delete" SelectMethod="GetModelList" TypeName="ITCastOCSS.BLL.Course">
             <SelectParameters>
                 <asp:Parameter DefaultValue="  " Name="strWhere" Type="String" />
             </SelectParameters>
         </asp:ObjectDataSource>

     </div>
</asp:Content>
