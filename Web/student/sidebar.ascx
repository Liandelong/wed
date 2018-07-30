<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="sidebar.ascx.cs" Inherits="Web.student.sidebar" %>
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
                        <li><a href="Index.aspx">个人信息</a></li>
                        <li><a href="Password.aspx">更改密码</a></li>
                        <li><a href="Xuanke.aspx">在线选课</a></li>
                        <li><a href="#">查询成绩</a></li>
                         <li><a href="../Index.aspx">退&nbsp;&nbsp;出</a></li>
                    </ul>
                    
                </div>
           </div>