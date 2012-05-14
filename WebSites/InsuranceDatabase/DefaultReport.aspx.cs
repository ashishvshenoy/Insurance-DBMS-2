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

public partial class DefaultReport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["auth"] == null)
        {
            Response.Redirect("Homepage.aspx");
            
        }
        Button2.Enabled = false;

    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        string date_1 = Calendar1.SelectedDate.ToString();
        Session["date_1"] = date_1;
        string year = date_1.Substring(6, 4);
        string month = date_1.Substring(3, 2);
        string day = date_1.Substring(0, 2);
        string start_date = year + "-" + month + "-" + day;

        string date_2 = Calendar2.SelectedDate.ToString();
        string year2 = date_2.Substring(6, 4);
        string month2 = date_2.Substring(3, 2);
        string day2 = date_2.Substring(0, 2);
        string end_date = year2 + "-" + month2 + "-" + day2;
        Session["date_2"] = date_2;

        
        string sql = "select * from POLICY where issued_date >= '" + date_1 + "' AND issued_date <= '" + date_2+"';";
        string constr = Session["connection"].ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        OdbcCommand cmd2 = new OdbcCommand(sql, cn);
        OdbcDataReader reader2;
        reader2 = cmd2.ExecuteReader();

        string htmlstr = "<p class='enlarge'>&nbsp;<table style='width:100%;'><tr><td class='style1'><b>Policy No</b></td><td class='style2'><b>Issued Date</b></td><td><b>Customer ID</b></td><td class='style2'><b>Type No</b></td><td class='style2'><b>Maturity</b></td></tr>";
        while (reader2.Read())
        {

            string pol_no = reader2["policy_no"].ToString();
            string issued_date = reader2["issued_date"].ToString();
            string type_no = reader2["type_no"].ToString();
            string maturity = reader2["maturity"].ToString();
            string cust_id = reader2["cust_id"].ToString();
            htmlstr += "<tr><td class = 'style2'>" + pol_no + "</td><td class = 'style2'>" + issued_date + "</td><td class='style2'>"+cust_id+"</td><td class = 'style1'>" + type_no + "</td><td class='style2'>" + maturity + "</td></tr>";
        }
        htmlstr += "</table>";
        table_data.InnerHtml = htmlstr;
        head_text.InnerHtml = "<div class='yui-u first' id = header runat ='server'><h1>REPORT</h1><h2>All policies issued between " + date_1.Substring(0, 10) + " & " + date_2.Substring(0, 10) + "</h2></div>";
        Button2.Enabled = true;
        Session["next"] = "1";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Session["next"].Equals("1"))
        {
            string date_1 = Session["date_1"].ToString() ;
            string year = date_1.Substring(6, 4);
            string month = date_1.Substring(3, 2);
            string day = date_1.Substring(0, 2);
            string start_date = year + "-" + month + "-" + day;

            string date_2 = Session["date_2"].ToString();
            string year2 = date_2.Substring(6, 4);
            string month2 = date_2.Substring(3, 2);
            string day2 = date_2.Substring(0, 2);
            string end_date = year2 + "-" + month2 + "-" + day2;


            string sql = "select * from CUSTOMER where cust_id in (select cust_id from POLICY where issued_date >= '" + date_1 + "' AND issued_date <= '" + date_2 + "');";
            string constr = Session["connection"].ToString();
            OdbcConnection cn = new OdbcConnection(constr);
            cn.Open();
            OdbcCommand cmd2 = new OdbcCommand(sql, cn);
            OdbcDataReader reader2;
            reader2 = cmd2.ExecuteReader();
            string htmlstr = "<p class='enlarge'>&nbsp;<table style='width:100%;'><tr><td class='style1'><b>First Name</b></td><td class='style2'><b>Last Name</b></td><td><b>Customer ID</b></td><td class='style2'><b>Phone</b></td><td class='style2'><b>Sex</b></td><td class='style2'><b>DOB</b></td><td class='style2'><b>Agent ID</b></td></tr>";
            while (reader2.Read())
            {

                string f_name = reader2["f_name"].ToString();
                string l_name = reader2["l_name"].ToString();
                string cust_id = reader2["cust_id"].ToString();
                string phone = reader2["phone"].ToString();
                string sex = reader2["sex"].ToString();
                string dob = reader2["dob"].ToString();
                string agent_id = reader2["agent_id"].ToString();
                htmlstr += "<tr><td class = 'style2'>" + f_name + "</td><td class = 'style2'>" + l_name + "</td><td class='style2'>" + cust_id + "</td><td class = 'style1'>" + phone + "</td><td class='style2'>" + sex + "</td><td class='style2'>" + dob + "</td><td class='style2'>" + agent_id + "</td></tr>";
            }
            htmlstr += "</table>";
            table_data.InnerHtml = htmlstr;
            head_text.InnerHtml = "<div class='yui-u first' id = header runat ='server'><h1>REPORT</h1><h2>All Customers who took insurance between " + date_1.Substring(0, 10) + " & " + date_2.Substring(0, 10) + "</h2></div>";
            Button2.Enabled = true;
            Session["next"] = 2;
        }

        else
        {
            string date_1 = Session["date_1"].ToString();
            string year = date_1.Substring(6, 4);
            string month = date_1.Substring(3, 2);
            string day = date_1.Substring(0, 2);
            string start_date = year + "-" + month + "-" + day;

            string date_2 = Session["date_2"].ToString();
            string year2 = date_2.Substring(6, 4);
            string month2 = date_2.Substring(3, 2);
            string day2 = date_2.Substring(0, 2);
            string end_date = year2 + "-" + month2 + "-" + day2;


            string sql = "select * from AGENT where agent_id in (select agent_id from CUSTOMER where cust_id in(select cust_id from POLICY where issued_date >= '" + date_1 + "' AND issued_date <= '" + date_2 + "'));";
            string constr = Session["connection"].ToString();
            OdbcConnection cn = new OdbcConnection(constr);
            cn.Open();
            OdbcCommand cmd2 = new OdbcCommand(sql, cn);
            OdbcDataReader reader2;
            reader2 = cmd2.ExecuteReader();
            string htmlstr = "<p class='enlarge'>&nbsp;<table style='width:100%;'><tr><td class='style1'><b>First Name</b></td><td class='style2'><b>Last Name</b></td><td><b>Agent ID</b></td><td class='style2'><b>Phone</b></td><td class='style2'><b>Sex</b></td><td class='style2'><b>DOB</b></td></tr>";
            while (reader2.Read())
            {

                string f_name = reader2["f_name"].ToString();
                string l_name = reader2["l_name"].ToString();
                string phone = reader2["phone"].ToString();
                string sex = reader2["sex"].ToString();
                string dob = reader2["dob"].ToString();
                string agent_id = reader2["agent_id"].ToString();
                htmlstr += "<tr><td class = 'style2'>" + f_name + "</td><td class = 'style2'>" + l_name + "</td><td class='style2'>" + agent_id + "</td><td class = 'style1'>" + phone + "</td><td class='style2'>" + sex + "</td><td class='style2'>" + dob + "</td></tr>";
            }
            htmlstr += "</table>";
            table_data.InnerHtml = htmlstr;
            head_text.InnerHtml = "<div class='yui-u first' id = header runat ='server'><h1>REPORT</h1><h2>All Agents who sold insurance between " + date_1.Substring(0, 10) + " & " + date_2.Substring(0, 10) + "</h2></div>";
            Button2.Enabled = false;
            Session["next"] = 3;
        }

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}
