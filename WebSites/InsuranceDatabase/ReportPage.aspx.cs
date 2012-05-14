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
public partial class ReportPage : System.Web.UI.Page
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
        int i;
        string htmlstr = "<table style='width:100%;'>";
        string data;
        string sql = TextBox1.Text;
        string constr = Session["connection"].ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        OdbcCommand cmd = new OdbcCommand(sql, cn);
        OdbcDataReader reader;
        reader = cmd.ExecuteReader();
        int col_count = reader.FieldCount;
        int count1;
        
        while (reader.Read())
        {
            htmlstr+="<tr>";
            count1 = col_count;
            i = 0;
            while (count1 != 0)
            {
                data = reader[i].ToString();
                htmlstr += "<td class='style2'>"+data+"</td>";
                count1--;
                i++;
            }
            htmlstr += "</tr>";
        }
        htmlstr += "</table>";
        table_data.InnerHtml = htmlstr;
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        int i;
        string htmlstr = "<table style='width:100%;'>";
        string data;
        string sql = TextBox1.Text;
        string constr = Session["connection"].ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        OdbcCommand cmd = new OdbcCommand(sql, cn);
        OdbcDataReader reader;
        reader = cmd.ExecuteReader();
        int col_count = reader.FieldCount;
        int count1;

        while (reader.Read())
        {
            htmlstr += "<tr>";
            count1 = col_count;
            i = 0;
            while (count1 != 0)
            {
                data = reader[i].ToString();
                htmlstr += "<td class='style2'>" + data + "</td>";
                count1--;
                i++;
            }
            htmlstr += "</tr>";
        }
        htmlstr += "</table>";
        table_data.InnerHtml = htmlstr;
    }
}
