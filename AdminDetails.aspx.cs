using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication22
{
    public partial class AdminDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (new BusinessLogic().Display(new StudentDetails { StudentName = TextBox1.Text, Hallticket = TextBox2.Text, Subject1 = int.Parse(TextBox3.Text), Subject2 = int.Parse(TextBox4.Text) }))
                {
                Label1.Text = "Result Added Sucessfully";
                }
            else
            {
                Label1.Text = "Result Not Added Sucessfully";
            }
        }
    }
}