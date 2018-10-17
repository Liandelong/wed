<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="CheckScore.aspx.cs" Inherits="Web.student.CheckScore" %>
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
        查询成绩
    </div>
    <div class="c">

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
            <Columns>
               <%-- <asp:BoundField DataField="SID" HeaderText="SID" SortExpression="SID" />
                <asp:BoundField DataField="SNo" HeaderText="SNo" SortExpression="SNo" />--%>
                <asp:BoundField DataField="SName" HeaderText="SName" SortExpression="SName" />
               <%-- <asp:BoundField DataField="CID" HeaderText="CID" SortExpression="CID" />
                <asp:BoundField DataField="Credit" HeaderText="Credit" SortExpression="Credit" />--%>
                <asp:BoundField DataField="CName" HeaderText="CName" SortExpression="CName" />
                <%--<asp:BoundField DataField="Week" HeaderText="Week" SortExpression="Week" />
                <asp:BoundField DataField="Timeperiod" HeaderText="Timeperiod" SortExpression="Timeperiod" />
                <asp:BoundField DataField="Place" HeaderText="Place" SortExpression="Place" />
                <asp:BoundField DataField="MaxNum" HeaderText="MaxNum" SortExpression="MaxNum" />
                <asp:BoundField DataField="ActualNum" HeaderText="ActualNum" SortExpression="ActualNum" />--%>
                <asp:BoundField DataField="Score" HeaderText="Score" SortExpression="Score" />
               <%-- <asp:BoundField DataField="EID" HeaderText="EID" SortExpression="EID" />
                <asp:BoundField DataField="TID" HeaderText="TID" SortExpression="TID" />--%>
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetModelListBysTID" TypeName="ITCastOCSS.BLL.v_Score">
            <SelectParameters>
                <asp:SessionParameter Name="id" SessionField="user" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>

    </div>
</asp:Content>
