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

public partial class PlanDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String s = Request.QueryString["query"];
        String type_name;
        string sql = "select * from INSURANCE_TYPE where type_no ='" + s + "';";
        string constr = Session["connection"].ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        OdbcCommand cmd = new OdbcCommand(sql, cn);
        int id = Convert.ToInt32(s);
        switch (id)
        {
            case 12345: type_name = "Jeevan Arogya";
                break;
            case 56789: type_name = "Endowment Plus";
                break;
            case 90123: type_name = "Jeevan Anurag";
                break;
            case 34567: type_name = "Jeevan Bharathi";
                break;
            case 78901: type_name = "Jeevan Saathi";
                break;
            default: type_name = "Unknown";
                break;
        }

        try
        {
            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                var value1 = dr[1];

                String rules = value1.ToString();
                header_left.InnerHtml = "<h1>Insurance Schemes</h1>\n<blockquote><p>" + type_name + "</p></blockquote>";
                string html_string = "<h2>About the scheme <br />\n<p>" + rules + "</p>";
                html_string = html_string.Replace("@", "<br><br>");
                main_content.InnerHtml = html_string;
            }

        }
        finally
        {
            //cn.Close();
            //cn.Dispose();

        }
    }
}
