using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Admin
{
    public partial class TeacherInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            Response.Redirect("TeacherList.aspx");
        }

        protected void DetailsView1_ItemInserting(object sender, DetailsViewInsertEventArgs e)
        {
          CheckBox chb=(CheckBox)DetailsView1.FindControl("Man");
            e.Values["TSex"] = chb.Checked ? "男" : "女";
            e.Values["TPwd"] = Common.Getmd5("123");
        }

        protected void DetailsView1_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
        {
            //CheckBox chb = (CheckBox)DetailsView1.FindControl("Man");
            //e.Values["TSex"] = chb.Checked ? "男" : "女";
            //e.Values["TPwd"] = Common.Getmd5("123");  
        }
    }
}