<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="seleted.aspx.cs" Inherits="Web.student.seleted" %>
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
        已选课程
    </div>
    <div class="c">

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnRowDataBound="GridView1_RowDataBound" Width="100%">
            <Columns>
               <%-- <asp:BoundField DataField="SID" HeaderText="SID" SortExpression="SID" />
                <asp:BoundField DataField="SNo" HeaderText="SNo" SortExpression="SNo" />
                <asp:BoundField DataField="SName" HeaderText="SName" SortExpression="SName" />
                <asp:BoundField DataField="CID" HeaderText="CID" SortExpression="CID" />--%>
                <asp:BoundField DataField="CName" HeaderText="课程" SortExpression="CName" />
                <asp:BoundField DataField="Credit" HeaderText="学分" SortExpression="Credit" />
                
                <asp:BoundField DataField="Week" HeaderText="星期" SortExpression="Week" />
                <asp:BoundField DataField="Timeperiod" HeaderText="上课时间" SortExpression="Timeperiod" />
                <asp:BoundField DataField="Place" HeaderText="地点" SortExpression="Place" />
                <%--<asp:BoundField DataField="MaxNum" HeaderText="MaxNum" SortExpression="MaxNum" />
                <asp:BoundField DataField="ActualNum" HeaderText="ActualNum" SortExpression="ActualNum" />--%>
                <asp:BoundField DataField="Score" HeaderText="成绩" SortExpression="Score" />
               <%-- <asp:BoundField DataField="EID" HeaderText="EID" SortExpression="EID" />
                <asp:BoundField DataField="TID" HeaderText="TID" SortExpression="TID" />--%>
                <asp:TemplateField>
                   <%-- <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </EditItemTemplate>--%>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="退选" OnClick="Button1_Click" />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetModelListBysTID" TypeName="ITCastOCSS.BLL.v_Score">
            <SelectParameters>
                <asp:SessionParameter Name="id" SessionField="user" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>

    </div>
</asp:Content>
