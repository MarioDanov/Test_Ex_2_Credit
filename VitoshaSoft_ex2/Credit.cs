using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VitoshaSoft_ex2
{
    public class Credit
    {
        //fields
        private string borrower_Name;
        private string creditor_Name;

        protected string id;

        protected float credit_amount;
        protected DateTime payday;
        protected bool overdue;

        //properties
        public string Borrower_Name
        {
            get { return this.borrower_Name; }
            set { this.borrower_Name = value; }
        }
        public string Creditor_Name
        {
            get { return this.creditor_Name; }
            set { this.creditor_Name = value; }
        }
        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public float Credit_amount
        {
            get { return this.credit_amount; }
            set { this.credit_amount = value; }
        }
        public DateTime Payday
        {
            get { return this.payday; }
            set { this.payday = value; }
        }
        public bool Overdue
        {
            get { return this.overdue; }
            set { this.overdue = value; }
        }

        //constructors
        public Credit(string b_Name, string c_Name, string id_code, float c_amount, DateTime pd)
        {
            this.borrower_Name = b_Name;
            this.creditor_Name = c_Name;
            this.id = id_code;
            this.credit_amount = c_amount;
            this.payday = pd;
            this.overdue = Overdue_Result();

        }

        //methods
        //creates List of credits
        public virtual List<Credit> Create_credits()
        {
            DateTime dt = new DateTime(2021, 12, 10);
            DateTime dt2 = new DateTime(2021, 01, 10);
            DateTime dt3 = new DateTime(2020, 12, 10);

            Credit credit1 = new Credit("Ivan", "Petkan", "aN87", 1000.21f, dt);
            Credit credit2 = new Credit("Dragan", "Oktan", "Bj96", 314.7f, dt2);
            Credit credit3 = new Credit("Metan", "Pakistan", "Kh54", 5060.1f, dt3);

            List<Credit> credits = new List<Credit>();

            credits.Add(credit1);
            credits.Add(credit2);
            credits.Add(credit3);

            return credits;
        }
        //check credits status
        public virtual bool Overdue_Result()
        {
            return this.payday - DateTime.Now.Date > TimeSpan.FromDays(0);
        }
    }
}