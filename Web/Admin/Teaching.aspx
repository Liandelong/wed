<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Teaching.aspx.cs" Inherits="Web.Admin.Teaching" %>
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
        教师排课
    </div>
    <div class="c">
        教师：<asp:DropDownList ID="ddlTeacher" runat="server" DataSourceID="ObjectDataSource1" DataTextField="TName" DataValueField="TID"></asp:DropDownList>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetModelList" TypeName="ITCastOCSS.BLL.Teacher">
            <SelectParameters>
                <asp:Parameter DefaultValue="Tisadmin=0" Name="strWhere" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        课程：<asp:DropDownList ID="ddlCourse" runat="server" DataSourceID="ObjectDataSource2" DataTextField="CName" DataValueField="CID"></asp:DropDownList>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetModelList" TypeName="ITCastOCSS.BLL.Course">
            <SelectParameters>
                <asp:Parameter DefaultValue=" " Name="strWhere" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        星期：<asp:DropDownList ID="ddlWeek" runat="server">
             <asp:ListItem>星期一</asp:ListItem>
             <asp:ListItem>星期二</asp:ListItem>
             <asp:ListItem>星期三</asp:ListItem>
             <asp:ListItem>星期四</asp:ListItem>
             <asp:ListItem>星期五</asp:ListItem>
             <asp:ListItem>星期六</asp:ListItem>
             <asp:ListItem>星期七</asp:ListItem>
        </asp:DropDownList>
        节次：<asp:DropDownList ID="ddlPeriod" runat="server">
              <asp:ListItem>上午一，二节</asp:ListItem>
             <asp:ListItem>上午三，四节</asp:ListItem>
             <asp:ListItem>下午一，二节</asp:ListItem>
             <asp:ListItem>下午三，四节</asp:ListItem>
             
           </asp:DropDownList>
        <br />
        最大选课人数：<asp:TextBox ID="TextNum" Width="50" Text="100" runat="server"></asp:TextBox>
        上课地点;<asp:TextBox ID="TextPlace" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="排课" />
    </div>
</asp:Content>
