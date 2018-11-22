using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqCashe
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getData();
        }

        protected void btnDeposit_Click(object sender, EventArgs e)
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                Accounts acc = db.Accounts.SingleOrDefault(x => x.AccountNumber == 1);
                acc.AccountBalance += 500;
                db.SubmitChanges();
            }

            }
        private void getData()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                Accounts acc = db.Accounts.SingleOrDefault(x => x.AccountNumber == 1);
                lblAccountName.Text = acc.AccountName.ToString();
                lblAccountNumber.Text = acc.AccountNumber.ToString();
                lblAccountBalance.Text = acc.AccountBalance.ToString();
            }
        }
    }
}