/*
    Coded by : K Vidya Vivaswanth
    No rights reserved...
    :p
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

public partial class Login : System.Web.UI.Page
{

    /*
        SQL connection string here 
        server = "Name of your sql server"
        Initial catalog = "Name of your database"
        Integrated security = true, This is for windows automated authentication,
        if you prefer any username / password,
        you have to enter them by specifying username = "your username", password = "your password"
    */

    SqlConnection con = new SqlConnection("server=urserver; Initial catalog=urdb; Integrated Security=true;");

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    // function to insert the values into the database upon clicking on the button.
    public void login(object sender, EventArgs e)
    {
        //open the connection string.
        con.Open();

        //using the SqlDataAdapter class and fetching the row which matches the current username and password.
        SqlDataAdapter da = new SqlDataAdapter("select UserName,Password from ClientProfile where UserName='" + UserName.Text + "' and Password='" + Password.Text + "'", con);

        //creating a new DataTable for storing the selected row.
        DataTable dt = new DataTable();

        //fill the selected row into the table created above.
        da.Fill(dt);

        //if row count exceeds 0, which means there are rows that matches the entered username and password.

        if (dt.Rows.Count == 0)
        {
            result.Text = "InvalidLoginId";
        }
        else if (dt.Rows.Count > 0)
        {
            Session["name"] = UserName.Text;
            Session["id"] = UserName.Text;
            Response.Redirect("~Where ever you want to redirect insert that URL...");
        }
    }

    public void ForgotPassword(object sender, EventArgs e)
    {
        Response.Redirect("ForgotPassword.aspx");
    }
}