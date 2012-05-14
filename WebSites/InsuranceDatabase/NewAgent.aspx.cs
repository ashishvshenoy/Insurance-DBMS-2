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

public partial class NewAgent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["auth"]==null)
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
        string lname = TextBox3.Text;
        string mname = TextBox2.Text;
        string a_id = TextBox4.Text;
        string sex = slist.SelectedItem.ToString();
        string dob_1 = Calendar1.SelectedDate.ToString();
        string year = dob_1.Substring(6, 4);
        string month = dob_1.Substring(3, 2);
        string day = dob_1.Substring(0, 2);
        string dob = year + "-" + month + "-" + day;
        string phoneno = TextBox5.Text;
        string address = TextBox7.Text;
        string sql = "insert into AGENT values ('" + fname + "','" + lname + "','" + a_id + "','" + phoneno + "','" + sex + "','" + dob_1 + "','" + address + "');";
        string sql2 = "select * from AGENT where agent_id = '" + a_id + "'";
        OdbcCommand cmd = new OdbcCommand(sql, cn);
        OdbcCommand cmd2 = new OdbcCommand(sql2, cn);
        OdbcDataReader dr = cmd2.ExecuteReader();

        try
        {
            
            

            if (dr.HasRows == true)
            {

                Label1.Text = "Data with this Agent ID already exists";
               
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
            cn.Close();
            cn.Dispose();

        }

    }
   
}
