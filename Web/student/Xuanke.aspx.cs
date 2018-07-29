using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.student
{
    public partial class Xuanke : System.Web.UI.Page
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
          
                string msg = null;
                for (int i = 0; i < GridView1.Rows.Count; i++)
                {
                    CheckBox cb = GridView1.Rows[i].Cells[8].FindControl("cbb") as CheckBox;
                    Label lbl = GridView1.Rows[i].Cells[0].FindControl("ldl1") as Label;
                    if (cb.Checked)
                    {

                        ITCastOCSS.BLL.Elective lel = new ITCastOCSS.BLL.Elective();

                    //lel.Xuanke(,3);
                    if (lel.Xuanke(stu.SID, Convert.ToInt32(lbl.Text)))
                    {
                        msg = "选择成功";
                    }
                    else
                    {
                        msg = "选择失败";
                    }
                }
                }
                Label2.Text = msg;
   
           
            }
    }
}