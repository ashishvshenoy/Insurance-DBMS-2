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

public partial class UpdatePolicy : System.Web.UI.Page
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
        Button2.Enabled = true;
        string constr = Session["connection"].ToString();
        string policy_no = DropDownList1.SelectedItem.ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        string sql = "select * from POLICY where policy_no = '" + policy_no + "';";
        OdbcCommand cmd = new OdbcCommand(sql, cn);
        OdbcDataReader reader;
        reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            TextBox1.Text = reader["issued_date"].ToString();
            TextBox2.Text = reader["type_no"].ToString();
            TextBox3.Text = reader["maturity"].ToString();


        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string issued_date = TextBox1.Text;
        string type_no = TextBox2.Text;
        string maturity = TextBox3.Text;
        string constr = Session["connection"].ToString();
        string policy_no = DropDownList1.SelectedItem.ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        string sql = "update POLICY set issued_date = '" + issued_date + "', type_no = '" + type_no + "',maturity = '" + maturity + "' where policy_no = '" +policy_no + "';";
        OdbcCommand cmd = new OdbcCommand(sql, cn);
        cmd.ExecuteNonQuery();
        Response.Redirect("HomePage.aspx");
    }
}
