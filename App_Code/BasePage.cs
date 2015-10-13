using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BasePage
/// </summary>
public class BasePage : System.Web.UI.Page
{
	
    public BasePage()
	{
        this.PreRender += Page_PreRender;
        //this.SomePageEvent += SomeNewMethod;
        //this.PreRender += Page_PreRender
        //The += means that all is normally done during that event plus what is done when method is called   
	}



    protected void Page_Load(object sender, EventArgs e)
    {
        this.Theme = "Lavender";
    }

    //protected void PreInit(object sender, EventArgs e)
    //{
    //    //used to set the theme - this occurs before control initialization - appropriate time
    //}

    //protected void PreRender(object sender, EventArgs e)
    //{
    //    //late in the page life cycle and is good for setting properties that shouldn't be overridden 
    //}

    private void Page_PreRender(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.Title))
        {
            this.Title = "New Title";
        }
        //this.Title = "New Title";
    }

    private void Page_PreInit(object sender, EventArgs e)
    {
        if (Request.Cookies["PreferredTheme"] != null)
        {
            this.Theme = Request.Cookies["PreferredTheme"].Value;
        }
        }
  
    
}