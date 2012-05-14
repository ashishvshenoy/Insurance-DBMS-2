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

public partial class UpdateAgent : System.Web.UI.Page
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        Button2.Enabled = true;
        string constr = Session["connection"].ToString();
        string agent_id = DropDownList1.SelectedItem.ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        string sql = "select * from AGENT where agent_id = '" + agent_id + "';";
        OdbcCommand cmd = new OdbcCommand(sql, cn);
        OdbcDataReader reader;
        reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            TextBox1.Text = reader["f_name"].ToString();
            TextBox2.Text = reader["l_name"].ToString();
            TextBox3.Text = reader["phone"].ToString();
            if (reader["sex"].ToString().Equals("M"))
            {
                slist.SelectedIndex = 1;
            }
            else
                slist.SelectedIndex = 2;

            TextBox5.Text = reader["address"].ToString();
           
        }
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string f_name = TextBox1.Text;
        string l_name = TextBox2.Text;
        string phone = TextBox3.Text;
        string sex = slist.SelectedItem.ToString();
        string address = TextBox5.Text;
        string constr = Session["connection"].ToString();
        string agent_id = DropDownList1.SelectedItem.ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        string sql = "update AGENT set f_name = '"+f_name+"', l_name = '"+l_name+"',phone = '"+phone+"',sex = '"+sex+"',address = '"+address+"' where agent_id = '"+agent_id+"';";
        OdbcCommand cmd = new OdbcCommand(sql, cn);
        cmd.ExecuteNonQuery();
        Response.Redirect("HomePage.aspx");

      
    }
}
