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

public partial class ViewAgent : System.Web.UI.Page
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
            string sql = "select agent_id from CUSTOMER where cust_id ='" + cust_id + "';";
            OdbcCommand cmd = new OdbcCommand(sql, cn);
            OdbcDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                newItem = new ListItem();
                newItem.Text = reader["agent_id"].ToString();
                DropDownList1.Items.Add(newItem);
            }
            reader.Close();
            cn.Close();
        }
        else
        {
            
            string sql = "select agent_id from AGENT";
            OdbcCommand cmd = new OdbcCommand(sql, cn);
            OdbcDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                newItem = new ListItem();
                newItem.Text = reader["agent_id"].ToString();
                DropDownList1.Items.Add(newItem);
            }
            reader.Close();
            cn.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string htmlstr = "<h2>&nbsp;</h2>&nbsp;<table style='width:100%;'>";
        string agent_id = DropDownList1.SelectedItem.ToString();
        string f_name;
        string l_name;
        string phone;
        string sex;
        string dob;
        string address;
        string constr = Session["connection"].ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        string sql = "select * from AGENT where agent_id = '" + agent_id + "';";
        OdbcCommand cmd = new OdbcCommand(sql, cn);
        OdbcDataReader reader;
        reader = cmd.ExecuteReader();
        
        while (reader.Read())
        {
            f_name = reader["f_name"].ToString();
            l_name = reader["l_name"].ToString();
            phone = reader["phone"].ToString();
            sex = reader["sex"].ToString();
            dob = reader["dob"].ToString();
            address = reader["address"].ToString();
            htmlstr += "<tr><td class='style2'>First Name:</td><td class='style1'>" + f_name + "</td><tr><td class = 'style2'>Last Name:</td><td class = 'style1'>" + l_name + "</td></tr><tr><td class='style2'> Agent ID:</td><td class = 'style1'>" + agent_id + "</td></tr><tr><td class='style2'>Phone:</td><td class = 'style1'>" + phone + "</td></tr><tr><td class='style2'>Date of Birth:</td><td class = 'style1'>" + dob + "</td></tr><tr><td class='style2'>Address:</td><td class = 'style1'>" + address + "</td></tr>";
        }
        table_data.InnerHtml = htmlstr;
    }
}
