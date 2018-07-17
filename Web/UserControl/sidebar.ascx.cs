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
        readonly string ADMIN = "admin";
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
           
            string type = ddlType.SelectedValue;
            string no = txtNo.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            string code = txtCode.Text.Trim();
            //if (no == ADMIN && pwd == ADMIN)
            //{
            //    Response.Redirect("student/Index.aspx");
            //}
            //else
            //{
            //    lblMsg.Text="登录失败";
            //}
            if (Session["code"]!=null&& code.ToLower() == Session["code"].ToString().ToLower())
            {
                Session.Remove("code");
                Response.Redirect("student/Index.aspx");
            }
            else
            {
                lblMsg.Text = "验证码错误";
            }
        }
    }
}