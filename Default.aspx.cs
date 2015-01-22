using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BoulderWhiteRock
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BWRDataAccess bwrDataAccess = new BWRDataAccess();
            contentText.Text = bwrDataAccess.GetHomeText();
        }
    }
}
