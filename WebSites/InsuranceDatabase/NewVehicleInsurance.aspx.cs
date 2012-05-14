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

public partial class NewVehicleInsurance : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["auth"] == null)
        {
            Response.Redirect("Homepage.aspx");
        }
        string constr = Session["connection"].ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        ListItem newItem = new ListItem();
        string sql = "select cust_id from CUSTOMER";
        OdbcCommand cmd = new OdbcCommand(sql, cn);
        OdbcDataReader reader;

        reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            newItem = new ListItem();
            newItem.Text = reader["cust_id"].ToString();
            DropDownList4.Items.Add(newItem);
        }
        reader.Close();
        cn.Close();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string constr = Session["connection"].ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        string c_id =DropDownList4.SelectedItem.ToString();
        string pol_type = DropDownList1.SelectedItem.ToString();
        string pol_no = TextBox3.Text;
        string id = Calendar1.SelectedDate.ToString();
        string val = Calendar2.SelectedDate.ToString();
        string year1 = id.Substring(6, 4);
        string month1 = id.Substring(3, 2);
        string day1 = id.Substring(0, 2);
        string issueddate = year1 + "-" + month1 + "-" + day1;
        string year2 = val.Substring(6, 4);
        string month2 = val.Substring(3, 2);
        string day2 = val.Substring(0, 2);
        string validity = year2 + "-" + month2 + "-" + day2;
        string lic_no = TextBoxPN.Text;
        string model = TextBoxPN0.Text;
        string type = DropDownList3.SelectedItem.ToString();
        string color = TextBoxPN1.Text;
        string year_of_build = DropDownList5.SelectedItem.ToString() ;
        string sql = "insert into POLICY values ('" + pol_no + "','" + id + "','" + c_id + "','" + pol_type + "','" + val + "');";
        string sql2 = "select * from POLICY where policy_no = '" + pol_no + "'";
        string sql3 = "insert into VEHICLE_DETAILS values ('" + lic_no + "','" + model + "','" + type + "','" + color + "','" + pol_no + "','"+ year_of_build+"');";
        string sql4 = "select * from VEHICLE_DETAILS where lic_plate = '" + lic_no + "'";
        OdbcCommand cmd = new OdbcCommand(sql, cn);
        OdbcCommand cmd2 = new OdbcCommand(sql2, cn);
        OdbcCommand cmd3 = new OdbcCommand(sql3, cn);
        OdbcCommand cmd4 = new OdbcCommand(sql4, cn);
        OdbcDataReader dr = cmd2.ExecuteReader();
        OdbcDataReader dr2 = cmd4.ExecuteReader();
        try
        {
            if (dr.HasRows == true)
            {

                Label1.Text = "Data with this Policy No already exists";

            }
            else if (dr2.HasRows == true)
            {

                Label2.Text = "Data with this License Plate already exists";

            }
            else
            {
                cmd.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
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
