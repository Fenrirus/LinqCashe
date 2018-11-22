using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqCashe
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SampleDataContext sdc = new SampleDataContext())
            using (SampleDataContext sdc2 = new SampleDataContext())
            {
                sdc.Log = Response.Output;
                sdc2.Log = Response.Output;
                Students student1 = sdc.Students.FirstOrDefault(s => s.ID == 1);
                Students student2 = sdc2.Students.FirstOrDefault(s => s.ID == 1);

                student1.FirstName = "Henio";
                sdc.SubmitChanges();

                sdc2.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues,student2);

                Label1.Text = student1.FirstName;
                Label2.Text = student2.FirstName;
            }
        }
    }
}