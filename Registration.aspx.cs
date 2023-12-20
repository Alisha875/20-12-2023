using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment9
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblMsg.Visible = false;
            Page.UnobtrusiveValidationMode=UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LblMsg.Visible = true;
            LblMsg.Text = "Product Name: " + TextBox1.Text + "<br />";
            LblMsg.Text += "Product Category: " + DropDownList1.SelectedValue + "<br />";
            LblMsg.Text += "Product Price: " + TextBox2.Text + "<br />";
            LblMsg.Text += "Description: " + TextBox3.Text + "<br />";
            LblMsg.Text += "Release Date: " + Calendar1.SelectedDate.ToShortDateString();
        }

    }
}