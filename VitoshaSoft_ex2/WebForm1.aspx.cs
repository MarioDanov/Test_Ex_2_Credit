using System;
using System.Collections.Generic;
using System.Web.UI;

namespace VitoshaSoft_ex2
{
    // Web form interface for credit data presentation.
    public partial class WebForm1 : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // Loading a credit data by credit ID selected by user via DropDownList.
        protected void Credit_Load(object sender, EventArgs e)
        {
            List<Credit> credits = Credit.Create_credits();
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
    }
}