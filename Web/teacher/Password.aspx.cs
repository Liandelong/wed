using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.teacher
{
    public partial class Password : System.Web.UI.Page
    {
        ITCastOCSS.Model.Teacher sea1;
        protected void Page_Load(object sender, EventArgs e)
        {
            sea1 = Session["user"] as ITCastOCSS.Model.Teacher;
            if (sea1 == null)
            {
                Response.Write("<script>alert('请先登录');location.href='../Index.aspx'</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ITCastOCSS.BLL.Teacher tea = new ITCastOCSS.BLL.Teacher();
            string pwd = TextBox1.Text;
            string pwd1 =sea1.TPwd;
            if (Common.Getmd5(pwd)==pwd1)
            {
                if (TextBox2.Text.Trim() == TextBox3.Text.Trim())
                {
                    tea.Tescherpwd(sea1.TID, Common.Getmd5(TextBox2.Text));
                    Label1.Text = "修改成功";
                }
                else
                {
                    Label1.Text = "新密码错误";
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