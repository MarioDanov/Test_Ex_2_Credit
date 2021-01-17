using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VitoshaSoft_ex2
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Credit_Load(object sender, EventArgs e)
        {
            List<Credit> credits = Create_credits();
            foreach(Credit c in credits){
                if(CreditList.SelectedValue == c.ID)
                {
                    System.Text.StringBuilder s_empty = new System.Text.StringBuilder();
                    System.Text.StringBuilder s = new System.Text.StringBuilder();
                    s_empty.Append("   Borrower  ").Append("   Creditor   ").Append("  Credit  ").Append("   Credit ID   ").Append("  Deadline   ").Append("  Overdue");
                    s.Append("     " + c.Borrower_Name).Append("        ").Append(c.Creditor_Name).Append("        ").Append(c.Credit_amount).Append("        ").Append(c.ID).Append("        ").Append(c.Payday.ToString("d")).Append("        ").Append(c.Overdue);
                    this.TexBox1.Text = s.ToString(); 
                    this.TexBox1.Visible = true;
                    this.TextBox2.Text = s_empty.ToString();
                    this.TextBox2.Visible = true;
                }
            }
        }
        public virtual List<Credit> Create_credits()
        {
            DateTime dt = new DateTime(2021, 12, 10);
            DateTime dt2 = new DateTime(2021, 01, 10);
            DateTime dt3 = new DateTime(2020, 12, 10);

            Credit credit1 = new Credit("Georg", "Petkan", "aN87", 1000.21f, dt.Date);
            Credit credit2 = new Credit("Dragan", "Oktan", "Bj96", 314.74f, dt2.Date);
            Credit credit3 = new Credit("Philips", "Pakistan", "Kh54", 5060f, dt3.Date);

            List<Credit> credits = new List<Credit>();

            credits.Add(credit1);
            credits.Add(credit2);
            credits.Add(credit3);

            return credits;
        }
    }
}