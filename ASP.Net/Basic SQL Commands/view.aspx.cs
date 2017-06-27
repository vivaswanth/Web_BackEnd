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
using System.Web.Security;

public partial class view : System.Web.UI.Page
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
    	con.Open();
    	DisplayRecord(); 
    }

    //function that fetches the data from the table and binds them to the given grid view
    public DataTable DisplayRecord()  
    {  
    	//using SqlDataAdapter class
        SqlDataAdapter Adp = new SqlDataAdapter("Select * from urtable", con);  

        //temporary table for storing data
        DataTable Dt = new DataTable();  

        //fill the temporary table with the data from adapter
        Adp.Fill(Dt);  

        //specifying the data source for the gridview
        grid1.DataSource = Dt;  

        //binding them to their corresponding variables given in .aspx file
        grid1.DataBind();  

        //return the data table
        return Dt;  
    }

    protected void ViewClick_Redirect(object sender, EventArgs e)
	{

		//setting the command argument for redirection upon clicking the link button along with a parameter in URL 
     	string Id = (sender as LinkButton).CommandArgument;
     	Response.Redirect("urpage.aspx?Id=" + Id);
	} 
}