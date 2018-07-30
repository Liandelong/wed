<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Xuanke.aspx.cs" Inherits="Web.student.Xuanke" %>
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
        选课
    </div>
    <div class="c">
       <a href="seleted.aspx">已选课程</a>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False">
            <Columns>
               <asp:TemplateField HeaderText="CID" SortExpression="CID">
                    <ItemTemplate>
                        <asp:Label ID="ldl1" runat="server" Text='<%# Bind("CID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:BoundField DataField="CName" HeaderText="课程" SortExpression="CName" />
                <asp:BoundField DataField="TName" HeaderText="教师姓名" SortExpression="TName" />
                
                <asp:BoundField DataField="Week" HeaderText="Week" SortExpression="Week" />
                <asp:BoundField DataField="Timeperiod" HeaderText="Timeperiod" SortExpression="Timeperiod" />
                <asp:BoundField DataField="Place" HeaderText="地点" SortExpression="Place" />
                <asp:BoundField DataField="MaxNum" HeaderText="最大选课人数" SortExpression="MaxNum" />
                <asp:BoundField DataField="ActualNum" HeaderText="已选人数" SortExpression="ActualNum" />
                
               <%-- <asp:BoundField DataField="Credit" HeaderText="学分" SortExpression="Credit" />--%>
                <asp:TemplateField>
                     <ItemTemplate>
                         <asp:CheckBox ID="cbb" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="TID" SortExpression="TID" Visible="False">
                    <%--<EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("TID") %>'></asp:TextBox>
                    </EditItemTemplate>--%>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("TID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        &nbsp;
        <asp:Button ID="Button1" runat="server" Text="选课" OnClick="Button1_Click" />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetModelList" TypeName="ITCastOCSS.BLL.Xuanke">
            <SelectParameters>
                <asp:Parameter DefaultValue=" " Name="strWhere" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>

    </div>
</asp:Content>
