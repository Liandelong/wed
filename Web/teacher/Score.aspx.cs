using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Web.teacher
{
    public partial class Score : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                Label lbl = GridView1.Rows[i].Cells[0].FindControl("ldlscore") as Label;
                TextBox txt = GridView1.Rows[i].Cells[4].FindControl("TextBox1") as TextBox;
                if (txt.Text.Trim()!="")
                {
                int eid = Convert.ToInt32(lbl.Text);
                double score = Convert.ToDouble(txt.Text);
                ITCastOCSS.BLL.Elective ele = new ITCastOCSS.BLL.Elective();
                ele.input(eid,score); 
                }      
            }
            Label1.Text = "更新成功";
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}