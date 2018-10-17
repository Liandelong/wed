using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.student
{
    public partial class CheckScore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           for(int i = 0; i < GridView1.Rows.Count; i++)
            {
                if (GridView1.Rows[i].Cells[2].Text == "&nbsp;")
                {
                    GridView1.Rows[i].Cells[2].Text = "未录入成绩";
                }
            }
        }
    }
}