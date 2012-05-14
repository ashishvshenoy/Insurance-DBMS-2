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


public partial class ViewPolicy : System.Web.UI.Page
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
            string sql = "select policy_no from POLICY where cust_id ='" + cust_id + "';";
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
        else
        {

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
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string htmlstr = "<h2>&nbsp;</h2>&nbsp;<table style='width:100%;'>";
        string pol_no = DropDownList1.SelectedItem.ToString();
        string issued_date;
        string type_no;
        string maturity;
        string constr = Session["connection"].ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        string sql2 = "select * from POLICY where policy_no = '" + pol_no + "';";
        OdbcCommand cmd2 = new OdbcCommand(sql2, cn);
        OdbcDataReader reader2;
        reader2 = cmd2.ExecuteReader();
        while (reader2.Read())
        {

            pol_no = reader2["policy_no"].ToString();
            issued_date = reader2["issued_date"].ToString();
            type_no = reader2["type_no"].ToString();
            maturity = reader2["maturity"].ToString();
            htmlstr += "<tr><td class='style2'><b>Policy No:</b></td><td class='style1'>" + pol_no + "</td><tr><td class = 'style2'><b>Issued Date:</b></td><td class = 'style1'>" + issued_date + "</td></tr><tr><td class='style2'> <b>Type No:</b></td><td class = 'style1'>" + type_no + "</td></tr><tr><td class='style2'><b>Maturity:</b></td><td class = 'style1'>" + maturity + "</td></tr>";
        }
        table_data.InnerHtml = htmlstr;
    }
}