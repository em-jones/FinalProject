using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for boxAdditionLoop
/// </summary>

namespace Lab4
{
    public class boxAdditionLoop
    {



        public static string loop(String value1, String value2)
        {
            int sum = 0;
            if (Convert.ToInt32(value1) < Convert.ToInt32(value2))
            {
                for (int i = Convert.ToInt32(value1); i <= Convert.ToInt32(value2); i++)
                { sum += i; }
                return "The total is " + Convert.ToString(sum);
            }
            else
            {
                return "Please enter an integer in the second box that is larger than the integer in the first box.";

            }
        }

    }
}

