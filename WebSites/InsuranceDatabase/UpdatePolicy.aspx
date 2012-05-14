<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdatePolicy.aspx.cs" Inherits="UpdatePolicy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
  <title>Update Policy | Insurance Database</title>
  <meta name="robots" content="index, follow" />
  <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
  <meta name="author" content="RapidxHTML" />
  <link href="css/style_v.css" rel="stylesheet" type="text/css" />
  <script type="text/javascript" src="js/jquery.js"></script>
  <script type="text/javascript" src="js/jquery.easing.1.3.js"></script>
  <script type="text/javascript" src="js/fancybox/jquery.fancybox-1.3.1.js"></script>
  <link rel="stylesheet" type="text/css" href="js/fancybox/jquery.fancybox-1.3.1.css" media="screen" />
  <script type="text/javascript" src="js/easyslider.js"></script>
  <script type="text/javascript" src="js/custom.js"></script>
        <style type="text/css">
            .style1
            {
                width: 231px;
                text-align: center;
            }
            .style2
            {
                width: 128px;
                text-align: right;
            }
        </style>
</head>

<body>

    <form id="form1" runat="server">

<!-- wrapper -->
<div class="rapidxwpr">

  <!-- header -->
  <div id="header">
  
    <!-- logo -->
    <div class="logo">
      <h1>UPDATE POLICY</h1>
        &nbsp;</div>
    <!-- / logo -->
  
  </div>
  <!-- / header -->
  
  <!-- mainmenu -->
  <div id="mainmenu">
    <ul id="menu">
      <li class="home"><a href="HomePage.aspx">Home</a></li>
      <li class="portfolio"></li>
      <li class="contact"></li>
    </ul>
  </div>
  <!-- / mainmenu -->
  
  <!-- main body -->
  <div id="middle">
    <div class="middle_bg">

      <div class="tab_container">
      
        <div id="tab1" class="tab_content">
          <!-- page title -->
          <div class="page_title" id = "table_data" runat = "server">
          <h2>&nbsp;</h2>
              &nbsp;<table style="width:100%; height: 102px;">
                  <tr>
                      <td class="style2">
                          Policy NO:</td>
                      <td class="style1">
                                        <asp:DropDownList ID="DropDownList1" runat="server">
                                        </asp:DropDownList>
                                    </td>
                      <td>
                          &nbsp;</td>
                  </tr>
                  <tr>
                      <td class="style2">
                          Issued Date:</td>
                      <td class="style1">
                          <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                      </td>
                      <td>
                          &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        Type_No:</td>
                                    <td class="style1">
                                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        Maturity:</td>
                                    <td class="style1">
                                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        &nbsp;</td>
                                    <td class="style1">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        &nbsp;</td>
                                    <td class="style1">
                                        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="View" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        &nbsp;</td>
                                    <td class="style1">
                                        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Update" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </div> 
          <!-- / page title -->
          
          <!-- services -->
          <!-- / services -->
        </div>    
      
      </div>

                &nbsp;</div>
  </div>
  <!-- / main body -->
  
  <!-- footer -->
  
  <!-- / footer -->

</div>
<!-- / wrapper -->

    </form>

</body>
</html>

