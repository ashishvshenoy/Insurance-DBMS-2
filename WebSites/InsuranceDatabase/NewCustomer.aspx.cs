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

public partial class NewCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["auth"] == null)
        {
            Response.Redirect("Homepage.aspx");
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string constr = Session["connection"].ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        string fname = TextBox1.Text;
        string lname = TextBox10.Text;
        string c_id = TextBox2.Text;
        string c_sex = slist.SelectedItem.ToString();
        string dob_1 = Calendar1.SelectedDate.ToString();
        string year = dob_1.Substring(6, 4);
        string month = dob_1.Substring(3, 2);
        string day = dob_1.Substring(0, 2);
        string dob = year + "-" + month + "-" + day;
        string phoneno = TextBox11.Text;
        string address = TextBox4.Text;
        string a_id = TextBox9.Text;
        string n_name = TextBox5.Text;
        string n_sex = slist2.SelectedItem.ToString();
        string n_dob = Calendar2.SelectedDate.ToString();
        string relationship = TextBox8.Text;
        string sql = "insert into CUSTOMER values ('" + fname + "','" + lname + "','" + c_id + "','" + phoneno + "','" + c_sex + "','" + dob_1 + "','" + address + "','"+a_id+"');";
        string sql2 = "select * from CUSTOMER where cust_id = '" + c_id + "'";
        string sql3 = "insert into NOMINEE values ('" + n_name + "','" + n_sex + "','" + n_dob + "','" + relationship + "','" + c_id + "');";
        OdbcCommand cmd = new OdbcCommand(sql, cn);
        OdbcCommand cmd2 = new OdbcCommand(sql2, cn);
        OdbcCommand cmd3 = new OdbcCommand(sql3, cn);
        OdbcDataReader dr = cmd2.ExecuteReader();
        try
        {
            
            

            if (dr.HasRows == true)
            {

                Label1.Text = "Data with this Customer ID already exists";
               
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
            cn.Close();
            cn.Dispose();

        }
    }
}
