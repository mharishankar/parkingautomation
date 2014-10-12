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

public partial class MakeReservation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void chooseContract(object sender, EventArgs e) {
        if (RadioButtonList1.SelectedValue == "0") {
            reserve1.Visible = true;
            reserve2.Visible = false;
        }
        else if (RadioButtonList1.SelectedValue == "1") {
            reserve1.Visible = false;
            reserve2.Visible = true;
        }
    }
}
