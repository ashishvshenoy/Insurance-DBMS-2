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
using System.Security.Cryptography;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Session["connection"] == null)
            Response.Redirect("HomePage.aspx");
        if (Session["auth"] != null)
        {
            Response.Redirect("Homepage.aspx");
        }

    }
    protected void LoginButton_Click1(object sender, ImageClickEventArgs e)
    {
        String constr = Session["connection"].ToString();
        OdbcConnection cn = new OdbcConnection(constr);
        cn.Open();
        string username = UNtext.Text;
        String password = PWText.Text + UNtext.Text;
        HashAlgorithm mhash = new SHA1CryptoServiceProvider();
        byte[] bytValue = System.Text.Encoding.UTF8.GetBytes(password);
        byte[] bytHash = mhash.ComputeHash(bytValue);
        mhash.Clear();
        password = Convert.ToBase64String(bytHash);
        string priv = Request.QueryString["query"];
        if (IsPostBack)
        {
            string sql = null;
            
            if (priv.Equals("user"))
            {
                sql = "select * from userdata where username ='" + username + "' and password ='" + password + "';";
                Session["user_cust_id"] = username;
            }

            if (priv.Equals("admin"))
            {
                sql = "select * from userdata where username ='admin' and password ='" + password + "';";
            }
            else
            {
                
            }
           
            OdbcCommand cmd = new OdbcCommand(sql, cn);


            try
            {
                OdbcDataReader dr = cmd.ExecuteReader();
                if (priv.Equals("user") && UNtext.ToString().Equals("admin"))
                {
                    Label1.Text = "Failed to authenticate";
                }
                else
                {
                    if (dr.HasRows == true)
                    {

                        if (priv.Equals("admin"))
                        {
                            Session["auth"] = "1";
                        }
                        else
                        {
                            Session["auth"] = "2";
                        }
                        Response.Redirect("HomePage.aspx");
                    }
                    else
                        Label1.Text = "Failed to authenticate";
                }
            }

            finally
            {
                cn.Close();
                cn.Dispose();

            }
        }
    }
}
