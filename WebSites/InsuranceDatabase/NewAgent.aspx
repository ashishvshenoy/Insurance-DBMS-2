<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewAgent.aspx.cs" Inherits="NewAgent" Debug ="true"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>

	<title>Add New Agent | Insurance Database</title>
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
					<h1>add new agent</h1>
					<h2>&nbsp; enter&nbsp; NEW AGENT details below</h2>
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
							<h2>Info</h2>
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
                                            First Name*:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                ControlToValidate="TextBox1" ErrorMessage="Enter First Name"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            &nbsp;</td>
                                        <td class="style2">
                                            &nbsp;</td>
                                        <td>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                                ControlToValidate="TextBox1" ErrorMessage="Enter Valid First Name" 
                                                ValidationExpression="[a-zA-Z]+"></asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            Middle Name:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
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
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                                ControlToValidate="TextBox2" ErrorMessage="Enter Valid Middle Name" 
                                                ValidationExpression="[a-zA-Z]+"></asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            Last Name*:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                ControlToValidate="TextBox3" ErrorMessage="Enter Last Name"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            &nbsp;</td>
                                        <td class="style2">
                                            &nbsp;</td>
                                        <td>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                                                ControlToValidate="TextBox3" ErrorMessage="Enter Valid Last Name" 
                                                ValidationExpression="[a-zA-Z]+"></asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            Agent ID*:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                ControlToValidate="TextBox4" ErrorMessage="Enter Agent ID"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            &nbsp;</td>
                                        <td class="style2">
                                            &nbsp;</td>
                                        <td>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                                                ControlToValidate="TextBox4" ErrorMessage="Enter Valid Agent ID" 
                                                ValidationExpression="[1-9][0-9][0-9][0-9][0-9]"></asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            Sex:</td>
                                        <td class="style2">
                                            <asp:RadioButtonList ID="slist" runat="server" RepeatDirection="Horizontal">
                                            <asp:ListItem Text ="M" Value="M" Selected="True" /><asp:ListItem Text ="F" Value="F" /></asp:RadioButtonList>
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
                                            Date of Birth*:</td>
                                        <td class="style2">
                                            <asp:Calendar ID="Calendar1" runat="server" SelectedDate="05/13/2012 10:31:23">
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
                                            Phone No*:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                                ControlToValidate="TextBox5" ErrorMessage="Enter Phone No"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            &nbsp;</td>
                                        <td class="style2">
                                            &nbsp;</td>
                                        <td>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
                                                ControlToValidate="TextBox5" ErrorMessage="Invalid Phone No" 
                                                ValidationExpression="[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]"></asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            Address*:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBox7" runat="server" Height="109px" TextMode="MultiLine"></asp:TextBox>
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

