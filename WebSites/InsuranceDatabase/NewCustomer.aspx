<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewCustomer.aspx.cs" Inherits="NewCustomer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>

	<title>Add New Customer | Insurance Database</title>
	<meta http-equiv="content-type" content="text/html; charset=utf-8" />

	<meta name="keywords" content="" />
	<meta name="description" content="" />

	<link rel="stylesheet" type="text/css" href="reset-fonts-grids.css" media="all" /> 
	<link rel="stylesheet" type="text/css" href="resume.css" media="all" />

    <style type="text/css">
        .style1
        {
            width: 133px;
        }
        .style2
        {
            width: 203px;
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
					<h1>Add new customer</h1>
					<h2>Enter the details below</h2>
				</div>

				<br />
                <br />
			</div><!--// .yui-gc -->
		    <br />
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
							<h2>Customer Info</h2>
						</div>
						<div class="yui-u">
							<p class="enlarge">
								<table style="width:100%;">
                                    <tr>
                                        <td class="style1">
                                            &nbsp;</td>
                                        <td class="style2">
                                            <asp:Label id ="Label1" runat="server" ForeColor="Red"></asp:Label>
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
                                            First
                                            Name*:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBox1" runat="server" Width="199px"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                ControlToValidate="TextBox1" ErrorMessage="Enter the Customer Name"></asp:RequiredFieldValidator>
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
                                            Last Name:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBox10" runat="server" Width="199px"></asp:TextBox>
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
                                                ControlToValidate="TextBox10" ErrorMessage="Enter Valid Last Name" 
                                                ValidationExpression="[a-zA-Z]+"></asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            Customer ID*:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBox2" runat="server" Width="199px"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                ControlToValidate="TextBox2" ErrorMessage="Enter Customer ID"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            &nbsp;</td>
                                        <td class="style2">
                                            &nbsp;</td>
                                        <td>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                                                ControlToValidate="TextBox2" ErrorMessage="Enter Valid Customer ID" 
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
                                            <asp:Calendar ID="Calendar1" runat="server" SelectedDate="05/13/2012 11:19:55">
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
                                            Address*:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBox4" runat="server" Height="127px" TextMode="MultiLine" 
                                                Width="201px"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                ControlToValidate="TextBox4" ErrorMessage="Enter Address"></asp:RequiredFieldValidator>
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
                                            Phone No:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBox11" runat="server" Width="199px"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                                                ControlToValidate="TextBox11" ErrorMessage="Invalid Phone No" 
                                                ValidationExpression="[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]"></asp:RegularExpressionValidator>
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
                                            Agent ID*:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBox9" runat="server" Width="199px"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                                ControlToValidate="TextBox9" ErrorMessage="Enter Agent's ID"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            &nbsp;</td>
                                        <td class="style2">
                                            &nbsp;</td>
                                        <td>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
                                                ControlToValidate="TextBox9" ErrorMessage="Enter Valid Agent ID" 
                                                ValidationExpression="[1-9][0-9][0-9][0-9][0-9]"></asp:RegularExpressionValidator>
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

					<div class="yui-gf">
	
						<div class="yui-u first">
							<h2>Nominee Info</h2>
						</div><!--// .yui-u -->

						<div class="yui-u">

							<div class="job">
                                    <p class="enlarge">
								<table style="width:100%;">
                                    <tr>
                                        <td class="style1">
                                            Name*:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBox5" runat="server" Width="199px"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                                ControlToValidate="TextBox5" ErrorMessage="Enter Nominee Name"></asp:RequiredFieldValidator>
                                                </td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            &nbsp;</td>
                                        <td class="style2">
                                            &nbsp;</td>
                                        <td>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" 
                                                ControlToValidate="TextBox5" ErrorMessage="Enter Valid Name" 
                                                ValidationExpression="[a-zA-Z]+"></asp:RegularExpressionValidator>
                                                    </td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            Sex:</td>
                                        <td class="style2">
                                           <asp:RadioButtonList ID="slist2" runat="server" RepeatDirection="Horizontal">
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
                                            <asp:Calendar ID="Calendar2" runat="server" SelectedDate="05/13/2012 18:29:06">
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
                                            Relationship*:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBox8" runat="server" Width="199px"></asp:TextBox>
                                                </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                                ControlToValidate="TextBox8" ErrorMessage="Enter Relationship with Customer"></asp:RequiredFieldValidator>
                                                </td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            &nbsp;</td>
                                        <td class="style2">
                                            &nbsp;</td>
                                        <td>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" 
                                                ControlToValidate="TextBox8" ErrorMessage="Enter Valid Relationship" 
                                                ValidationExpression="[a-zA-Z]+"></asp:RegularExpressionValidator>
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
                            </p></p>
							</div>

						</div><!--// .yui-u -->
					    <br />
                        <br />
                        <br />
					</div><!--// .yui-gf -->


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

