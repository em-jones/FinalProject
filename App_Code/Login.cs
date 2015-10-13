using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for Login
/// </summary>
public class Login : MasterPage
{
	public Login()
	{
		
	}

    public void checkLogin(){
        //getlogin information
        //redirect home if not logged in
        Response.Redirect("Home.aspx");
    }
}