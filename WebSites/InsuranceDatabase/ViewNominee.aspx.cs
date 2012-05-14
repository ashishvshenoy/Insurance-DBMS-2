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

public partial class ViewNominee : System.Web.UI.Page
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


            newItem.Text = cust_id;
            DropDownList1.Items.Add(newItem);
            
        }
        else
        {

            string sql = "select cust_id from CUSTOMER";
            OdbcCommand cmd = new OdbcCommand(sql, cn);
            OdbcDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                newItem = new ListItem();
                newItem.Text = reader["cust_id"].ToString();
                DropDownList1.Items.Add(newItem);
            }
            reader.Close();
            cn.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string htmlstr = "<h2>&nbsp;</h2>&nbsp;<table style='width:100%;'>";
        string cust_id = DropDownList1.SelectedItem.ToString();
        string name;
        string sex;
        string dob;
        string relationship;
        string constr = Session["connection"].ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        string sql = "select * from NOMINEE where cust_id = '" + cust_id + "';";
        OdbcCommand cmd = new OdbcCommand(sql, cn);
        OdbcDataReader reader;
        reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            name = reader["name"].ToString();
            sex = reader["sex"].ToString();
            dob = reader["dob"].ToString();
            relationship = reader["relationship"].ToString();
            htmlstr += "<tr><td class='style2'>Name:</td><td class='style1'>" + name + "</td><tr><td class = 'style2'>Sex:</td><td class = 'style1'>" +sex + "</td></tr><tr><td class='style2'> Relationship:</td><td class = 'style1'>" + relationship + "</td></tr><tr><td class='style2'>DOB:</td><td class = 'style1'>" + dob + "</td></tr><tr><td class='style2'>Customer ID :</td><td class = 'style1'>" + cust_id + "</td></tr>";
        }
        table_data.InnerHtml = htmlstr;
    }
}