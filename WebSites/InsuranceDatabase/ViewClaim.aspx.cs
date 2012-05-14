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
using System.Data.Odbc;

public partial class ViewClaim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["auth"] == null)
        {
            Response.Redirect("Homepage.aspx");
        }
        ListItem newItem = new ListItem();
        string constr = Session["connection"].ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        if (Session["user_cust_id"] != null)
        {
            string cust_id = Session["user_cust_id"].ToString();
            string sql = "select report_no from CLAIM where pol_no in (select policy_no from POLICY where cust_id ='" + cust_id + "');";
            OdbcCommand cmd = new OdbcCommand(sql, cn);
            OdbcDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                newItem = new ListItem();
                newItem.Text = reader["report_no"].ToString();
                DropDownList1.Items.Add(newItem);
            }
            reader.Close();
            cn.Close();
        }
        else
        {

            string sql = "select report_no from CLAIM";
            OdbcCommand cmd = new OdbcCommand(sql, cn);
            OdbcDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                newItem = new ListItem();
                newItem.Text = reader["report_no"].ToString();
                DropDownList1.Items.Add(newItem);
            }
            reader.Close();
            cn.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string htmlstr = "<h2>&nbsp;</h2>&nbsp;<table style='width:100%;'>";
        string report_no = DropDownList1.SelectedItem.ToString();
        string claim_date;
        string accident_date;
        string claim_amount;
        string pol_no;
        
        string constr = Session["connection"].ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        string sql = "select * from CLAIM where report_no = '" + report_no+ "';";
        OdbcCommand cmd = new OdbcCommand(sql, cn);
        OdbcDataReader reader;
        reader = cmd.ExecuteReader();
        while (reader.Read())
        {
           claim_date = reader["claim_date"].ToString();
            claim_amount = reader["claim_amount"].ToString();
            accident_date = reader["accident_date"].ToString();
            pol_no = reader["pol_no"].ToString();
            htmlstr += "<tr><td class='style2'>Report No:</td><td class='style1'>" + report_no + "</td><tr><td class = 'style2'>Claim Date:</td><td class = 'style1'>" + claim_date + "</td></tr><tr><td class='style2'> Claim Amount:</td><td class = 'style1'>" + claim_amount +"</td></tr><tr><td class='style2'>Policy No:</td><td class = 'style1'>" + pol_no +  "</td></tr>";
        }
        table_data.InnerHtml = htmlstr;
    }
}