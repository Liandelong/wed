<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Score.aspx.cs" Inherits="Web.teacher.Score" %>
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
        录入成绩
    </div>
    <div class="c">

        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False" Width="100%" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
              <%--  <asp:BoundField DataField="SID" HeaderText="SID" SortExpression="SID" />--%>
                <asp:TemplateField Visible="False">
                    <ItemTemplate>
                        <asp:Label ID="ldlscore" runat="server" Text='<%# Bind("EID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="SNo" HeaderText="学号" SortExpression="SNo" />
                <asp:BoundField DataField="SName" HeaderText="姓名" SortExpression="SName" />
               <%-- <asp:BoundField DataField="CID" HeaderText="CID" SortExpression="CID" />--%>
               <%-- <asp:BoundField DataField="Credit" HeaderText="Credit" SortExpression="Credit" />--%>
                <asp:BoundField DataField="CName" HeaderText="课程" SortExpression="CName" />
               <%-- <asp:BoundField DataField="Week" HeaderText="Week" SortExpression="Week" />
                <asp:BoundField DataField="Timeperiod" HeaderText="Timeperiod" SortExpression="Timeperiod" />
                <asp:BoundField DataField="Place" HeaderText="Place" SortExpression="Place" />
                <asp:BoundField DataField="MaxNum" HeaderText="MaxNum" SortExpression="MaxNum" />
                <asp:BoundField DataField="ActualNum" HeaderText="ActualNum" SortExpression="ActualNum" />
               
                <asp:BoundField DataField="EID" HeaderText="EID" SortExpression="EID" />--%>
                <asp:TemplateField HeaderText="成绩" SortExpression="Score">
                    <ItemTemplate>
                       <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Score") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="录入成绩" OnClick="Button1_Click" />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetModelListByTID" TypeName="ITCastOCSS.BLL.v_Score">
            <SelectParameters>
                <asp:SessionParameter Name="id" SessionField="user" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>

    </div>
</asp:Content>
