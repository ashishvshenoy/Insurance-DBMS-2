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

public partial class DeleteCustomer : System.Web.UI.Page
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        string cust_id = DropDownList1.SelectedItem.ToString();
        string f_name;
        string l_name;
        string phone;
        string sex;
        string dob;
        string address;
        string agent_id;
        if (Session["delbutton"] != null)
        {
            string cust_id2 = Session["cust_id"].ToString();
            string sql2 = "delete from CUSTOMER where cust_id = " + cust_id + ";";
            string constr = Session["connection"].ToString();
            OdbcConnection cn2 = new OdbcConnection(constr);
            cn2.Open();
            OdbcCommand cmd = new OdbcCommand(sql2, cn2);
            cmd.ExecuteNonQuery();
            cn2.Close();
            Session["delbutton"] = null;
            Session["cust_id"] = null;
            Response.Redirect("HomePage.aspx");
        }
        else
        {
            string constr = Session["connection"].ToString();
            OdbcConnection cn = new OdbcConnection(constr);
            cn.Open();
            string sql = "select * from CUSTOMER where cust_id = '" + cust_id + "';";
            OdbcCommand cmd = new OdbcCommand(sql, cn);
            OdbcDataReader reader;
            reader = cmd.ExecuteReader();
            string htmlstr = "<p class='enlarge'>&nbsp;<table style='width:100%;'><tr><td class='style1'><b>First Name</b></td><td class='style2'><b>Last Name</b></td><td><b>Agent ID</b></td><td class='style2'><b>Phone</b></td><td class='style2'><b>Sex</b></td><td class='style2'><b>Date of Birth</b></td><td class='style2'><b>Address</b></td></tr>";
            while (reader.Read())
            {
                f_name = reader["f_name"].ToString();
                l_name = reader["l_name"].ToString();
                phone = reader["phone"].ToString();
                sex = reader["sex"].ToString();
                dob = reader["dob"].ToString();
                address = reader["address"].ToString();
                agent_id = reader["agent_id"].ToString();
                htmlstr += "<tr><td class='style2'>" + f_name + "</td><td class='style2'>" + l_name + "</td><td>" + agent_id + "</td><td class='style2'>" + phone + "</td><td class='style2'>" + sex + "</td><td class='style2'>" + dob + "</td><td class='style2'>" + address + "</td></tr>";
            }
            htmlstr = htmlstr + "</table></p>";

            table.InnerHtml = htmlstr;
            Button1.Text = "Confirm Delete";

            Session["cust_id"] = cust_id;
            Session["delbutton"] = "1";
        }

    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["delbutton"] = null;
        Session["cust_id"] = null;
        Response.Redirect("HomePage.aspx");
    }
}