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

public partial class ViewCustomer : System.Web.UI.Page
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
        string f_name;
        string l_name;
        string phone;
        string sex;
        string dob;
        string address;
        string agent_id;
        string pol_no;
        string issued_date;
        string type_no;
        string maturity;
        string constr = Session["connection"].ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        string sql = "select * from CUSTOMER where cust_id = '" + cust_id + "';";
        string sql2 = "select * from POLICY where cust_id = '" + cust_id + "';";
        OdbcCommand cmd = new OdbcCommand(sql, cn);
        OdbcCommand cmd2 = new OdbcCommand(sql2, cn);
        OdbcDataReader reader;
        OdbcDataReader reader2;
        reader = cmd.ExecuteReader();
        reader2 = cmd2.ExecuteReader();
        while (reader.Read())
        {
            f_name = reader["f_name"].ToString();
            l_name = reader["l_name"].ToString();
            phone = reader["phone"].ToString();
            sex = reader["sex"].ToString();
            dob = reader["dob"].ToString();
            agent_id = reader["agent_id"].ToString();
            address = reader["address"].ToString();
            htmlstr += "<tr><td class='style2'><b>First Name:</b></td><td class='style1'>" + f_name + "</td><tr><td class = 'style2'><b>Last Name:</b></td><td class = 'style1'>" + l_name + "</td></tr><tr><td class='style2'><b> Agent ID:</b></td><td class = 'style1'>" + agent_id + "</td></tr><tr><td class='style2'><b>Phone:</b></td><td class = 'style1'>" + phone + "</td></tr><tr><td class='style2'><b>Date of Birth:</b></td><td class = 'style1'>" + dob + "</td></tr><tr><td class='style2'><b>Address:</b></td><td class = 'style1'>" + address + "</td></tr><tr><td class='style2'><b>Agent ID:</b></td><td class = 'style1'>" + agent_id + "</td></tr>";
        }
        
        /*while (reader2.Read())
        {
            
            pol_no = reader2["policy_no"].ToString();
            issued_date = reader2["issued_date"].ToString();
            type_no = reader2["type_no"].ToString();
            maturity = reader2["maturity"].ToString();
            htmlstr += "<tr><td class='style2'><b>Policy No:</b></td><td class='style1'>" + pol_no + "</td><tr><td class = 'style2'><b>Issued Date:</b></td><td class = 'style1'>" + issued_date + "</td></tr><tr><td class='style2'> <b>Type No:</b></td><td class = 'style1'>" + type_no + "</td></tr><tr><td class='style2'><b>Maturity:</b></td><td class = 'style1'>" + maturity + "</td></tr>";
            
        }*/
        
        table_data.InnerHtml = htmlstr;
    }
}