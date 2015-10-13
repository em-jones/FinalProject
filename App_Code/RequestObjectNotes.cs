using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RequestObjectNotes
/// </summary>
public class RequestObjectNotes
{
    //public Request/ResponseObjectNotes()
    //{
    //    //Request object retrieves values that the client browser passes to the server during a BasePage request
            //-set a cookie
        // cookie: text file containing non-critical information stored on the user's computer
                //uses - remember the user's name and use cookie to respond to user with a greeting
                //     - 
          //Response: used to send output to the browser
            //-request a cookie

    //CREATING cookies
    //HttpCookie myCookie = new HttpCookie("MyNewCookie");
    //myCookie.Value = TextBox1.Text;
    //myCookie.Expires = DateTime.Now.AddDays(30);
    //Response.Cookies.Add(myCookie);

    //OR
    //Response.Cookies["MyNewCookie"].Value = TextBox1.Text;
    //Response.Cookies["MyNewCookie"].Expires = DateTime.Now.AddDays(30);
    //*NOTE* - without an expiration the cookie only lasts as long as the user's current session

    //Getting Information about Cookies:
    //string valOfMyCookie = Request.Cookies["MyNewCookie"].Value;
    //}
}