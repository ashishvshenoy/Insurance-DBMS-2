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

public partial class DeletePolicy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["auth"] == null)
        {
            Response.Redirect("Homepage.aspx");
        }
        Button1.Text = "Delete";
        ListItem newItem = new ListItem();
        string constr = Session["connection"].ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
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
        string policy_no = DropDownList1.SelectedItem.ToString();
        string date;
        string cust_id;
        string type_no;
        string maturity;
        if (Session["delbutton"] != null)
        {
            string pol_no2 = Session["pol_no"].ToString();
            string sql2 = "delete from POLICY where policy_no = " + policy_no + ";";
            string constr = Session["connection"].ToString();
            OdbcConnection cn2 = new OdbcConnection(constr);
            cn2.Open();
            OdbcCommand cmd = new OdbcCommand(sql2, cn2);
            cmd.ExecuteNonQuery();
            cn2.Close();
            Session["delbutton"] = null;
            Session["pol_no"] = null;
            Response.Redirect("HomePage.aspx");
        }
        else
        {
            string constr = Session["connection"].ToString();
            OdbcConnection cn = new OdbcConnection(constr);
            cn.Open();
            string sql = "select * from POLICY where policy_no = '" + policy_no + "';";
            OdbcCommand cmd = new OdbcCommand(sql, cn);
            OdbcDataReader reader;
            reader = cmd.ExecuteReader();
            string htmlstr = "<p class='enlarge'>&nbsp;<table style='width:100%;'><tr><td class='style1'><b>Policy No</b></td><td class='style2'><b>Issued Date</b></td><td><b>Customer ID</b></td><td class='style2'><b>Type No</b></td><td class='style2'><b>Maturity</b></td></td></tr>";
            while (reader.Read())
            {
                date = reader["issued_date"].ToString();
                cust_id = reader["cust_id"].ToString();
                type_no = reader["type_no"].ToString();
                maturity = reader["maturity"].ToString();
                htmlstr += "<tr><td class='style2'>" + policy_no + "</td><td class='style2'>" + date + "&nbsp;</td><td>" + cust_id + "</td><td class='style2'>" + type_no + "</td><td class='style2'>" + maturity + "</td></tr>";
            }
            htmlstr = htmlstr + "</table></p>";

            table.InnerHtml = htmlstr;
            Button1.Text = "Confirm Delete";

            Session["pol_no"] = policy_no;
            Session["delbutton"] = "1";
        }

    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["delbutton"] = null;
        Session["pol_no"] = null;
        Response.Redirect("HomePage.aspx");
    }
}