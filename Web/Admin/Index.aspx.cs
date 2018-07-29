using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Admin
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ITCastOCSS.Model.Teacher stu = Session["user"] as ITCastOCSS.Model.Teacher;
            if (stu == null)
            {
                Response.Write("<script>alert('请先登录');location.href='../Index.aspx'</script>");
            }

        }
    }
}