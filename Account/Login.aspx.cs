using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BoulderWhiteRock.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, System.EventArgs e)
        {
            try
            {
                Response.Redirect(string.Format("{0}?UserName={1}&Password={2}", "http://localhost/WaterRights", EncodeString(LoginUser.UserName), EncodeString(LoginUser.Password)));
            }
            catch (Exception)
            {
                LoginUser.FailureText = "Input correct User Name and Password!";
            }
        }

        private static string EncodeString(string val)
        {
            return val;
        }
    }
}
