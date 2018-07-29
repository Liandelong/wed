<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="teaching.aspx.cs" Inherits="Web.teacher.teaching" %>
<%@ Register src="sidebar.ascx" tagname="sidebar" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="sidebarHolder" runat="server">
    <uc1:sidebar ID="sidebar1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="title">课程信息

    </div>
    <div class="c">

        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False" Width="100%">
            <Columns>
                <asp:BoundField DataField="CName" HeaderText="CName" SortExpression="CName" />
                <asp:BoundField DataField="Grade" HeaderText="Grade" SortExpression="Grade" />
                <asp:BoundField DataField="Week" HeaderText="Week" SortExpression="Week" />
                <asp:BoundField DataField="Timeperiod" HeaderText="Timeperiod" SortExpression="Timeperiod" />
                <asp:BoundField DataField="MaxNum" HeaderText="MaxNum" SortExpression="MaxNum" />
                <asp:BoundField DataField="ActualNum" HeaderText="ActualNum" SortExpression="ActualNum" />
               <%-- <asp:BoundField DataField="TNo" HeaderText="TNo" SortExpression="TNo" />--%>
               <%-- <asp:BoundField DataField="TName" HeaderText="TName" SortExpression="TName" />
                <asp:BoundField DataField="TID" HeaderText="TID" SortExpression="TID" />
                <asp:BoundField DataField="CID" HeaderText="CID" SortExpression="CID" />
                <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />--%>
            </Columns>
        </asp:GridView>

        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetModelListByTID" TypeName="ITCastOCSS.BLL.Kcb">
            <SelectParameters>
                <asp:SessionParameter Name="id" SessionField="user" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>

    </div>
    </asp:Content>
