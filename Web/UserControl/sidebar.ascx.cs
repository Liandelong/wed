using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.UserControl
{
    public partial class sidebar : System.Web.UI.UserControl
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
           //学生为1  老师为2
            string type = ddlType.SelectedValue;
            string no = txtNo.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            //md5加密
           pwd= Common.Getmd5(pwd);
           

            string code = txtCode.Text.Trim();
          
            if (Session["code"]!=null&& code.ToLower() == Session["code"].ToString().ToLower())
            {
                Session.Remove("code");
                string msg;
                if (type == "1")//学生
                {
                    ITCastOCSS.BLL.Student stu = new ITCastOCSS.BLL.Student();
                    ITCastOCSS.Model.Student stu1 = new ITCastOCSS.Model.Student();
                    if(stu.login(no,pwd,out msg,out stu1))
                    {
                        Session["user"] = stu1;
                        Response.Redirect("student/Index.aspx");
                    }
                    lblMsg.Text = msg;
                }
                else if(type=="2")//老师
                {
                    ITCastOCSS.BLL.Teacher tea = new ITCastOCSS.BLL.Teacher();
                    ITCastOCSS.Model.Teacher tea1 = new ITCastOCSS.Model.Teacher();
                    if(tea.login(no,pwd,out msg,out tea1))
                    {
                        Session["user"] = tea1;
                        if (tea1.TIsAdmin == 0)
                        {
                            Response.Redirect("teacher/Index.aspx");
                        }
                        else if (tea1.TIsAdmin == 1)
                        {
                            Response.Redirect("Admin/Index.aspx");
                        }
                       
                    }
                    lblMsg.Text = msg;
                }

                //Response.Redirect("student/Index.aspx");
            }
            else
            {
                lblMsg.Text = "验证码错误！！！";
            }
        }
    }
}