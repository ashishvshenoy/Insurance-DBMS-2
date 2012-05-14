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

public partial class NewPolicy : System.Web.UI.Page
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
        string c_id = TextBox1.Text;
        string pol_type = DropDownList1.SelectedItem.ToString();
        string pol_no = TextBox3.Text;
        string id_1 = Calendar1.SelectedDate.ToString();
        string year = id_1.Substring(6, 4);
        string month = id_1.Substring(3, 2);
        string day = id_1.Substring(0, 2);
        string issueddate = year + "-" + month + "-" + day;
        string maturity = Calendar2.SelectedDate.ToString();
        string pay_no = TextBoxPN.Text;
        string premium = TextBoxPN0.Text;
        string sa = TextBox5.Text;
        string mode = DropDownList2.SelectedItem.ToString();

        string sql = "insert into POLICY values ('" + pol_no + "','" + id_1 + "','" + c_id + "','" + pol_type + "','" + maturity + "');";
        string sql2 = "select * from POLICY where policy_no = '" + pol_no + "'";
        string sql3 = "insert into PAYMENT values ('" + pay_no + "','" + premium + "','" + sa + "','" + mode + "','" + pol_no + "');";
        string sql4 = "select * from PAYMENT where pay_no = '" + pay_no + "'";
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

                Label1.Text = "Data with this Payment No already exists";

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
