using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Days_Between_Dates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TimeSpan daysPassed = TimeSpan.Zero;
            DateTime firstDate = firstCalendar.SelectedDate;
            DateTime secondDate = secondCalendar.SelectedDate;
            if (firstDate > secondDate) { daysPassed = firstDate.Subtract(secondDate); }
            if (firstDate < secondDate) { daysPassed = secondDate.Subtract(firstDate); }
            resultLabel.Text = daysPassed.Days.ToString();
        } 
    }
}