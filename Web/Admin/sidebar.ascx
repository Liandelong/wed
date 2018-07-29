<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="sidebar.ascx.cs" Inherits="Web.Admin.sidebar" %>
<%--<%@ Register Src="~/Admin/sidebar.ascx" TagPrefix="uc1" TagName="sidebar" %>--%>


<style>
        .list ul{
            list-style-type:none;
        }
        .list ul li{
            margin-bottom:10px;
            margin-left:30px;
        }
    </style>

           <div class="bar notice">
                <div class="title ">欢迎</div>
                <div class="c">
                    <p>第一次登陆请尽快修改密码，默认密码是您生日的后六位</p></div>
            </div>
            <br />
            <div class="bar list">
                <div class="title">功能列表</div>
                <div class="c">
                    <ul>
                        <li><a href="Index.aspx">课程管理</a></li>
                        <li><a href="#">学生管理</a></li>
                        <li><a href="TeacherList.aspx">老师管理</a></li>
                        <li><a href="Teaching.aspx">排&nbsp;&nbsp;课</a></li>
                         <li><a href="../Index.aspx">退&nbsp;&nbsp;出</a></li>
                    </ul>
                    
                </div>
           </div>