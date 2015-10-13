using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _ContentTemplate : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoginPanel.Visible = false;
        }
    }



    protected void RegisterToggle_Click(object sender, EventArgs e)
    {
        LoginPanel.Visible = true;
        RegisterToggle.Visible = false;
    }






    protected void Reg(object sender, EventArgs e)
    {
        if (!UsernameValidation.IsValid)
        {
            UserNameLabel.Text = "";
            
            
            //use "display" property to change whether or not something is displayed statically, dynamically...
            

        }
    }

}