using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class Formvalidation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                labelmsg.Text = "Registration Successful!";
                labelmsg.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                labelmsg.Text = "Please Correct the Form..";
                labelmsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}