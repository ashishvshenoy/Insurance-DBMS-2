<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewPolicy.aspx.cs" Inherits="NewPolicy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>

	<title>Add New Policy | Insurance Database</title>
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
					<h1>add new POLICY</h1>
					<h2>enter details below</h2>
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
							<h2>Policy Info</h2>
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
                                            &nbsp;</td>
                                        <td class="style2">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            Customer ID*:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                ControlToValidate="TextBox1" ErrorMessage="Enter Customer ID"></asp:RequiredFieldValidator>
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
                                            Policy Type*:</td>
                                        <td class="style2">
                                            <asp:DropDownList ID="DropDownList1" runat="server">
                                                <asp:ListItem>12345</asp:ListItem>
                                                <asp:ListItem>56789</asp:ListItem>
                                                <asp:ListItem>90123</asp:ListItem>
                                                <asp:ListItem>34567</asp:ListItem>
                                                <asp:ListItem>78901</asp:ListItem>
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
                                            Policy No*:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                ControlToValidate="TextBox3" ErrorMessage="Enter Policy No"></asp:RequiredFieldValidator>
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
                                            Issued Date*:</td>
                                        <td class="style2">
                                            <asp:Calendar ID="Calendar1" runat="server" SelectedDate="05/13/2012 11:20:38">
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
                                            Maturity*:</td>
                                        <td class="style2">
                                            <asp:Calendar ID="Calendar2" runat="server" SelectedDate="05/13/2012 11:20:38">
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
                                            &nbsp;</td>
                                        <td class="style2">
                                            &nbsp;</td>
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
				<div id="Div1">
			<div id="Div2">
				<div class="yui-b">

					<div class="yui-gf">
						<div class="yui-u first">
							<h2>Payment Info</h2>
						</div>
						<div class="yui-u">
							<p class="enlarge">
								&nbsp;<table style="width:100%;">
                                    <tr>
                                        <td class="style1">
                                            Payment No*:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBoxPN" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPN" runat="server" 
                                                ControlToValidate="TextBoxPN" ErrorMessage="Enter Payment No"></asp:RequiredFieldValidator>
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
                                            Premium*:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBoxPN0" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPre" runat="server" 
                                                ControlToValidate="TextBoxPN0" ErrorMessage="Enter Premium Amount"></asp:RequiredFieldValidator>
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
                                            Sum Assured*:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                ControlToValidate="TextBox3" ErrorMessage="Enter Sum Assured"></asp:RequiredFieldValidator>
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
                                            Mode of Payment:</td>
                                        <td class="style2">
                                            <asp:DropDownList ID="DropDownList2" runat="server">
                                                <asp:ListItem>Monthly</asp:ListItem>
                                                <asp:ListItem>Quarterly</asp:ListItem>
                                                <asp:ListItem>Half Yearly</asp:ListItem>
                                                <asp:ListItem>Yearly</asp:ListItem>
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
					</div>
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
