using System;
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
using System.Security.Cryptography;

public partial class Registration : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["connection"] == null)
            Response.Redirect("HomePage.aspx");

    }


    protected void SubmitButton_Click1(object sender, EventArgs e)
    {
        string username = TextBoxUN.Text;
        string password = TextBoxPW.Text + TextBoxUN.Text;
        HashAlgorithm mhash = new SHA1CryptoServiceProvider();
        byte[] bytValue = System.Text.Encoding.UTF8.GetBytes(password);
        byte[] bytHash = mhash.ComputeHash(bytValue);
        mhash.Clear();
        password = Convert.ToBase64String(bytHash);

        string fullname = TextBoxFN.Text;
        string emailid = TextBoxEID.Text;

        String constr = Session["connection"].ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();


        if (IsPostBack)
        {
            Response.Write("You have successfully completed registration");
            string sql = "insert into userdata values ('" + username + "','" + password + "','"+ fullname + "','"+emailid+"');";
            OdbcCommand cmd = new OdbcCommand(sql, cn);

            try
            {
                cmd.ExecuteNonQuery();
            }

            finally
            {
                cn.Close();
                cn.Dispose();

            }



            SubmitButton.Enabled = false;
            Response.Redirect("HomePage.aspx");

        }
    }
}
