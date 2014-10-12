using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class ParkingGarage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, MenuEventArgs e){
        if (Session["BreadCrumbs"] != null) {
            BreadCrumbLabel.Text = Session["BreadCrumbs"].ToString();
            Page.Header.Title = "Parking Garage | " + Session["BreadCrumbs"].ToString();
        };
    }

    protected void MainMenu_MenuItemClick(object sender, MenuEventArgs e)
    {
        Navigate(e.Item.Value);
    }
    
    public void Navigate(string targetId) {
        switch (targetId.ToUpper()) {
            case "HOME" : {
                    Session["BreadCrumbs"] = "Home";
                    Response.Redirect("~/Home.aspx");
                    break;
                }
            case "MAKERESERVATION": {
                    Session["BreadCrumbs"] = "Make Reservation";
                    Response.Redirect("~/MakeReservation.aspx");
                    break;
                }
            case "MANAGERESERVATION": {
                    Session["BreadCrumbs"] = "Manage Reservation ";
                    Response.Redirect("~/ManageReservation.aspx");
                    break;
                }
            case "EDITACCOUNT": {
                    Session["BreadCrumbs"] = "Edit account";
                    Response.Redirect("~/EditAccount.aspx");
                    break;
                }
           case "PRICING": {
                    Session["BreadCrumbs"] = "Pricing";
                    Response.Redirect("~/Pricing.aspx");
                    break;
                }
          case "POLICIES": {
                    Session["BreadCrumbs"] = "Policies";
                    Response.Redirect("~/Policies.aspx");
                    break;
                }
            case "CONTACTUS": {
                    Session["BreadCrumbs"] = "Contact Us";
                    Response.Redirect("~/ContactUs.aspx");
                    break;
                }
            default: {
                    break;
                }
        }
}
    }
