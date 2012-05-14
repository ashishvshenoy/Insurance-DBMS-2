<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewClaim.aspx.cs" Inherits="NewClaim" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>

	<title>Add New Claim | Insurance Database</title>
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
    </style>

</head>
<body>

    <form id="form1" runat="server">

<div id="doc2" class="yui-t7">
	<div id="inner">
	
		<div id="hd">
			<div class="yui-gc">
				<div class="yui-u first">
					<h1>add CLAIM</h1>
					<h2>enter&nbsp; The claim Details Below</h2>
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
							<h2>Claim Details</h2>
						</div>
						<div class="yui-u">
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
                                            FIR No*:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                ControlToValidate="TextBox1" ErrorMessage="Enter FIR No"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            &nbsp;</td>
                                        <td class="style2">
                                            &nbsp;</td>
                                        <td>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                                ControlToValidate="TextBox1" ErrorMessage="Enter Valid FIR No" 
                                                ValidationExpression="[1-9][0-9]+"></asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            Policy No*:</td>
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
                                            Claim Date*:</td>
                                        <td class="style2">
                                            <asp:Calendar ID="Calendar1" runat="server" SelectedDate="05/13/2012 11:16:38">
                                            </asp:Calendar>
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
                                            Accident Date*:</td>
                                        <td class="style2">
                                            <asp:Calendar ID="Calendar2" runat="server" SelectedDate="05/13/2012 11:16:45">
                                            </asp:Calendar>
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
                                            Claim Amount*:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                ControlToValidate="TextBox7" ErrorMessage="Enter Claim Amount"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            &nbsp;</td>
                                        <td class="style2">
                                            &nbsp;</td>
                                        <td>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" 
                                                ControlToValidate="TextBox7" ErrorMessage="Enter Valid Claim Amount" 
                                                ValidationExpression="[1-9][0-9]+"></asp:RegularExpressionValidator>
                                        </td>
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
                                            <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" />
                                        </td>
                                        <td>
                                            &nbsp;</td>
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
			<p>Ashish V Shenoy &amp; Ashitosh K Sunthe 2012</p>
		</div><!--// footer -->

	</div><!-- // inner -->


</div><!--// doc -->


</form>


</body>
</html>