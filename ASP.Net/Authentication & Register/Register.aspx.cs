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

public partial class Register : System.Web.UI.Page
{
	
    /*
        SQL connection string here 
        server = "Name of your sql server"
        Initial catalog = "Name of your database"
        Integrated security = true, This is for windows automated authentication,
        if you prefer any username / password,
        you have to enter them by specifying username = "your username", password = "your password"
    */

	SqlConnection con = new SqlConnection("server=DESKTOP-30COJRN; Initial catalog=multibanking; Integrated Security=true;");
    protected void Page_Load(object sender, EventArgs e)
    {
    	
    }


    // function to insert the values into the database upon clicking on the button.
    protected void CreateUser_Click(object sender, EventArgs e)
    {
        try
        {
            //open the connection string.
            con.Open();

            //your sql string here.
            string str = "INSERT INTO ClientProfile([FirstName], [LastName], [UserName], [Gender], [DOB], [FatherName], [MobileNum], [Email], [IDProof], [Password], [AddressLine], [City], [State], [PinCode]) VALUES('" + FirstName.Text + "','" + LastName.Text + "','" + UserName.Text + "','" +Sex.SelectedItem.Text + "', '"+ DOB.Text+"','"+FatherName.Text+"','" + MobileNum.Text + "','" + Email.Text + "','" + IDProof.SelectedItem.Text + "','" + Password.Text + "','" + AddressLine.Text + "','"+ City.Text+"','"+ State.SelectedItem.Text+"','"+ PinCode.Text+"')";
            
            //using SqlCommand built-in function, create an object of the SqlCommand class with the above string.
            SqlCommand cmd = new SqlCommand(str, con);

            //execute the sql query using the object created above.
            cmd.ExecuteNonQuery().ToString();  

            //specify any means to show status, eg: alert / messagebox etc...
            result.Text = "successfully inserted";
        }
        catch(Exception ee)
        {
            Response.Write(ee);
        }
    }
}