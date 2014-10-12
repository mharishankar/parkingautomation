using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using DataAccess;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){

    }

    protected void login_Btn(object sender, EventArgs e) {
        string username = UserIDTextBox.Text.ToString();
        string password = PasswordTextBox.Text.ToString();
        if (DataAccess.DataAccessing.checkifUser(username, password) == false)
            Response.Redirect("~/Login.aspx");
        else
            Response.Redirect("~/Home.aspx");
    }
}
