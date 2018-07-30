using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.student
{
    public partial class Password : System.Web.UI.Page
    {
        ITCastOCSS.Model.Student stu;
        protected void Page_Load(object sender, EventArgs e)
        {
            stu = Session["user"] as ITCastOCSS.Model.Student;
            if (stu == null)
            {
                Response.Write("<script>alert('请先登录');location.href='../Index.aspx'</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string NewPwd1 = TextBox2.Text;
            string NewPwd2 = TextBox3.Text;
            if (Common.Getmd5(TextBox1.Text) == stu.SPwd)
            {
                ITCastOCSS.BLL.Student stu1 = new ITCastOCSS.BLL.Student();
                if (NewPwd1 == NewPwd2)
                {
                    stu1.StudentPwd(stu.SID, Common.Getmd5(NewPwd1));
                    Label1.Text = "修改成功";
                }
                else
                {
                    Label1.Text = "新密码输入错误";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                }
            }
            else
            {
                Label1.Text = "旧密码输入错误";
            }
        }
    }
}