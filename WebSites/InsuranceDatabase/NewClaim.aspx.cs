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

public partial class NewClaim : System.Web.UI.Page
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
        if (Session["auth"] == null)
        {
            Response.Redirect("Homepage.aspx");
        }
        string sql = "select policy_no from POLICY";
        OdbcCommand cmd = new OdbcCommand(sql, cn);
        OdbcDataReader reader;

        reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            newItem = new ListItem();
            newItem.Text = reader["policy_no"].ToString();
            DropDownList1.Items.Add(newItem);
        }
        reader.Close();
        cn.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string constr = Session["connection"].ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        string report_no = TextBox1.Text;
        string pol_no = DropDownList1.SelectedItem.ToString();
        string claim_date_1 = Calendar1.SelectedDate.ToString();
        string acc_date_1 = Calendar2.SelectedDate.ToString();
        string year1 = claim_date_1.Substring(6, 4);
        string month1 = claim_date_1.Substring(3, 2);
        string day1 = claim_date_1.Substring(0, 2);
        string claim_date = year1+ "-" + month1 + "-" + day1;
        string year2 = acc_date_1.Substring(6, 4);
        string month2 = acc_date_1.Substring(3, 2);
        string day2 = acc_date_1.Substring(0, 2);
        string acc_date = year2 + "-" + month2 + "-" + day2;
        string claim_amt = TextBox7.Text;
        string sql = "insert into CLAIM values ('" + report_no + "','" + claim_date_1 + "','" + acc_date_1 + "','" + claim_amt + "','" + pol_no+ "');";
        string sql2 = "select * from CLAIM where report_no = '" + report_no + "'";
        string sql3 = "select * from CLAIM where pol_no = '" + pol_no + "'";
        OdbcCommand cmd = new OdbcCommand(sql, cn);
        OdbcCommand cmd2 = new OdbcCommand(sql2, cn);
        OdbcCommand cmd3 = new OdbcCommand(sql3, cn);
        OdbcDataReader dr = cmd2.ExecuteReader();
        OdbcDataReader dr2 = cmd3.ExecuteReader();
        try
        {
            
            if (dr.HasRows == true)
            {

                Label1.Text = "Data with this Report No already exists";
               
            }
            else if (dr2.HasRows == true)
            {

                Label1.Text = "This Policy No has already been claimed";

            }
            else
            {
                cmd.ExecuteNonQuery();
                Label1.Text = "Data added successfully";
                Response.Redirect("HomePage.aspx");
            }
        }
        finally
        {
            dr.Close();
            dr2.Close();
            cn.Close();
            cn.Dispose();

        }
    }
}
