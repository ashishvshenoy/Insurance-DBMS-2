<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteAgent.aspx.cs" Inherits="DeleteAgent" Debug="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>

	<title>Delete Agent | Insurance Database</title>
	<meta http-equiv="content-type" content="text/html; charset=utf-8" />

	<meta name="keywords" content="" />
	<meta name="description" content="" />

	<link rel="stylesheet" type="text/css" href="reset-fonts-grids.css" media="all" /> 
	<link rel="stylesheet" type="text/css" href="resume.css" media="all" />

    <style type="text/css">
        .style1
        {
            width: 136px;
        }
        .style2
        {
            width: 164px;
            text-align: center;
        }
        .style3
        {
            width: 202px;
        }
        .style4
        {
            width: 59px;
        }
    </style>

</head>
<body>

    <form id="form1" runat="server">

<div id="doc2" class="yui-t7">
	<div id="inner">
	
		<div id="hd">
			<div class="yui-gc">
				<div class="yui-u first">
					<h1>&nbsp;DELETE EXISTING agent</h1>
					<h2>&nbsp;&nbsp;&nbsp; SELECT AGENT ID OF THE AGENT TO BE DELETED</h2>
				</div>

			</div><!--// .yui-gc -->
		    <br />
            <br />
            <br />
            <br />
		</div><!--// hd -->

		<div id="bd">
			<div id="yui-main">
				<div class="yui-b">

					<div class="yui-gf">
						<div class="yui-u first">
							<h2>&nbsp;</h2>
						</div>
						<div class="yui-u" id = "table" runat = "server">
							<p class="enlarge">
								&nbsp;<table style="width:100%;">
                                    <tr>
                                        <td class="style1">
                                            &nbsp;</td>
                                        <td class="style2">
                                            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                                        </td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            Agent ID:</td>
                                        <td class="style2">
                                            <asp:DropDownList ID="DropDownList1" runat="server">
                                                
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            &nbsp;</td>
                                        <td class="style2">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            &nbsp;</td>
                                        <td class="style2">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                </table>
							</p>
						</div>
						<div class="yui-u" id = "Div1" runat = "server">
							<p class="enlarge">
							    <table style="width:100%;">
                                    <tr>
                                        <td class="style4">
                                            &nbsp;</td>
                                        <td class="style3">
                                            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                                                Text="Button" Height="36px" Width="122px" />
                                        </td>
                                        <td>
                                            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                                                Text="Back Home" Height="36px" Width="122px" />
                                        </td>
                                    </tr>
                                </table>
							</p>
							</div>
						
					    <br />
                        <br />
                        <br />
                        <br />
					</div><!--// .yui-gf -->

					<!--// .yui-gf -->

					<!--// .yui-gf-->

					<!--// .yui-gf -->


					<!--// .yui-gf -->


				</div><!--// .yui-b -->
			</div><!--// yui-main -->
		</div><!--// bd -->

		<div id="ft">
			<p>Ashish V Shenoy 2012</p>
		</div><!--// footer -->

	</div><!-- // inner -->


</div><!--// doc -->


</form>


</body>
</html>
