using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.student
{
    public partial class seleted : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string str = e.Row.Cells[5].Text;
                if (str== "&nbsp;")
                {
                    e.Row.Cells[5].Text = "未录入成绩";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //for (int i= 0;i< GridView1.Rows.Count; i++)
            //{
            //    string score = GridView1.Rows[i].Cells[5].Text;
            //    CheckBox chb = GridView1.Rows[i].Cells[6].FindControl("CheckBox1") as CheckBox;
            //    if(score== "&nbsp;"&&)
            //}
        }
    }
}