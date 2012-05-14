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

public partial class UpdatePaymentInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Button2.Enabled = false;
        if (Session["auth"] == null)
        {
            Response.Redirect("Homepage.aspx");
        }
        ListItem newItem = new ListItem();
        string constr = Session["connection"].ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        string sql = "select pay_no from PAYMENT";
        OdbcCommand cmd = new OdbcCommand(sql, cn);
        OdbcDataReader reader;

        reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            newItem = new ListItem();
            newItem.Text = reader["pay_no"].ToString();
            DropDownList1.Items.Add(newItem);
        }
        reader.Close();
        cn.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Button2.Enabled = true;
        string constr = Session["connection"].ToString();
        string pay_no = DropDownList1.SelectedItem.ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        string sql = "select * from PAYMENT where pay_no = '" + pay_no + "';";
        OdbcCommand cmd = new OdbcCommand(sql, cn);
        OdbcDataReader reader;
        reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            TextBox1.Text = reader["premium"].ToString();
            TextBox2.Text = reader["sum_assured"].ToString();
            TextBox3.Text = reader["mode_of_payment"].ToString();
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string premium = TextBox1.Text;
        string sum_assured = TextBox2.Text;
        string mode_of_payment = TextBox3.Text;

        string constr = Session["connection"].ToString();
        string pay_no= DropDownList1.SelectedItem.ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        string sql = "update PAYMENT set premium = '" + premium + "', sum_assured = '" + sum_assured + "',mode_of_payment = '" + mode_of_payment + "' where pay_no = '" + pay_no + "';";
        OdbcCommand cmd = new OdbcCommand(sql, cn);
        cmd.ExecuteNonQuery();
        Response.Redirect("HomePage.aspx");
    }
}
