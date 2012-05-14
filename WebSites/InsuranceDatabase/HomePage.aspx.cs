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

public partial class HomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        Session["connection"] = "Driver={MySQL ODBC 5.1 Driver}; Server=localhost; Database=test; User=root; Password=;";
        menuitems.InnerHtml = "<!-- Navigation --><ul id='nav' class='sf-menu'><li class='current-menu-item'><a href='HomePage.aspx'>Home<span class='subheader'>Welcome</span></a></li><li><a href='Login.aspx?query=user'>Login<span class='subheader'></span></a><ul><li><a href='Login.aspx?query=admin'><span>Admin</span></a></li><li><a href='Login.aspx?query=user'><span>User</span></a></li></ul></li><li><a href='Registration.aspx'>Sign Up<span class='subheader'>Register</span></a></li><li><a href='PlanDetails.aspx?query=12345'>Insurance Plans<span class='subheader'>Various Schemes</span></a><ul><li><a href='PlanDetails.aspx?query=12345'>Jeevan Arogya<span></span></a></li><li><a href='PlanDetails.aspx?query=56789'><span>Endowment Plus</span></a></li><li><a href='PlanDetails.aspx?query=90123'><span>Jeevan Anurag</span></a></li><li><a href='PlanDetails.aspx?query=34567'><span>Jeevan Bharathi</span></a></li><li><a href='PlanDetails.aspx?query=78901'><span>Jeevan Saathi</span></a></li></ul></li><li><a href='#'>About<span class='subheader'>About the creators</span></a></li></ul>";
        string s;
        if (Session["auth"] == null)
        {
            s = null;
            Button1.Enabled = false;
        }
        else
        {
            s = Session["auth"].ToString();
        }
      if (s != null)
        {
            Button1.Enabled = true;
            if (s.Equals("1"))
            {
                Page.Response.Cache.SetCacheability(HttpCacheability.NoCache);

                menuitems.InnerHtml = "<!-- Navigation --><ul id='nav' class='sf-menu'><li class='current-menu-item'><a href='HomePage.aspx'>Home<span class='subheader'>Welcome</span></a></li><li><a href='PlanDetails.aspx?query=12345'>Insurance Plans<span class='subheader'>Various Schemes</span></a><ul><li><a href='PlanDetails.aspx?query=12345'>Jeevan Arogya<span></span></a></li><li><a href='PlanDetails.aspx?query=56789'><span>Endowment Plus</span></a></li><li><a href='PlanDetails.aspx?query=90123'><span>Jeevan Anurag</span></a></li><li><a href='PlanDetails.aspx?query=34567'><span>Jeevan Bharathi</span></a></li><li><a href='PlanDetails.aspx?query=78901'><span>Jeevan Saathi</span></a></li></ul></li><li><a href='#'>Add New Data</a><ul><li><a href='NewAgent.aspx'>Add New Agent<span></span></a></li><li><a href='NewCustomer.aspx'><span>Add New Customer</span></a></li><li><a href='NewPolicy.aspx'><span>Add New Policy</span></a></li><li><a href='NewVehicleInsurance.aspx'><span>Add New Vehicle Insurance</span></a></li><li><a href='NewClaim.aspx'><span>Add New Claim</span></a></li></ul></li><li><a href='#'>Delete Data</a><ul><li><a href='DeleteAgent.aspx'>Delete Agent<span></span></a></li><li><a href='DeleteCustomer.aspx'><span>Delete Customer</span></a></li><li><a href='DeletePolicy.aspx'><span>Delete Policy</span></a></li></ul></li><li><a href='#'>View Data</a><ul><li><a href='ViewCustomer.aspx'>Customer Details<span></span></a></li><li><a href='ViewAgent.aspx'><span>Agent Details</span></a></li><li><a href='ViewPolicy.aspx'><span>Policy Details</span></a></li><li><a href='ViewClaim.aspx'><span>Claim Details</span></a></li><li><a href='ViewNominee.aspx'><span>Nominee Details</span></a></li></ul></li><li><a href='#'>Update Data</a><ul><li><a href='UpdateCustomer.aspx'>Update Customer Details<span></span></a></li><li><a href='UpdateAgent.aspx'><span>Update Agent Details</span></a></li><li><a href='UpdatePolicy.aspx'><span>Update Policy Details</span></a></li><li><a href='UpdatePaymentInfo.aspx'><span>Update Payment Info</span></a></li></ul></li><li><a href='#'>Report<span class='subheader'>Generating various reports</span></a><ul><li><a href='ReportPage.aspx'>Custom Queries<span></span></a></li><li><a href='DefaultReport.aspx'>Default Report<span></span></a></li></li></li></ul>";
            }
            if (s.Equals("2"))
            {
                Page.Response.Cache.SetCacheability(HttpCacheability.NoCache);
                menuitems.InnerHtml = "<!-- Navigation --><ul id='nav' class='sf-menu'><li class='current-menu-item'><a href='HomePage.aspx'>Home<span class='subheader'>Welcome</span></a></li><li><a href='PlanDetails.aspx?query=12345'>Insurance Plans<span class='subheader'>Various Schemes</span></a><ul><li><a href='PlanDetails.aspx?query=12345'>Jeevan Arogya<span></span></a></li><li><a href='PlanDetails.aspx?query=56789'><span>Endowment Plus</span></a></li><li><a href='PlanDetails.aspx?query=90123'><span>Jeevan Anurag</span></a></li><li><a href='PlanDetails.aspx?query=34567'><span>Jeevan Bharathi</span></a></li><li><a href='PlanDetails.aspx?query=78901'><span>Jeevan Saathi</span></a></li></ul></li><li><a href='#'>View My Data</a><ul><li><a href='ViewCustomer.aspx'>Customer Details<span></span></a></li><li><a href='ViewAgent.aspx'><span>Agent Details</span></a></li><li><a href='ViewPolicy.aspx'><span>Policy Details</span></a></li><li><a href='ViewClaim.aspx'><span>Claim Details</span></a></li><li><a href='ViewNominee.aspx'><span>Nominee Details</span></a></li></ul></li></li></ul>";
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Contents.RemoveAll();
        Response.Redirect("HomePage.aspx");
    }
}
