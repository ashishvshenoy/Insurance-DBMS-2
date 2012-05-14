<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewVehicleInsurance.aspx.cs" Inherits="NewVehicleInsurance" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>

	<title>Add New Vehicle Insurance | Insurance Database</title>
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
                                            <asp:DropDownList ID="DropDownList4" runat="server">
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
                                            Policy Type:</td>
                                        <td class="style2">
                                            <asp:DropDownList ID="DropDownList1" runat="server">
                                                <asp:ListItem>77777</asp:ListItem>
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
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                                ControlToValidate="TextBox3" ErrorMessage="Enter Valid Policy No" 
                                                ValidationExpression="[1-9][0-9][0-9][0-9][0-9]"></asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            Issued Date*:</td>
                                        <td class="style2">
                                            <asp:Calendar ID="Calendar1" runat="server" SelectedDate="05/13/2012 11:21:45">
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
                                            Validity*:</td>
                                        <td class="style2">
                                            <asp:Calendar ID="Calendar2" runat="server" SelectedDate="05/13/2012 11:21:45">
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
							<h2>Vehicle Info</h2>
						</div>
						<div class="yui-u">
							<p class="enlarge">
								&nbsp;<table style="width:100%;">
                                    <tr>
                                        <td class="style1">
                                            &nbsp;</td>
                                        <td class="style2">
                                            <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>
                                        </td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style1">
                                            License Plate*:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBoxPN" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPN" runat="server" 
                                                ControlToValidate="TextBoxPN" ErrorMessage="Enter License Plate No"></asp:RequiredFieldValidator>
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
                                            Model*:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBoxPN0" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPre" runat="server" 
                                                ControlToValidate="TextBoxPN0" ErrorMessage="Enter Model"></asp:RequiredFieldValidator>
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
                                            Type:</td>
                                        <td class="style2">
                                            <asp:DropDownList ID="DropDownList3" runat="server">
                                                <asp:ListItem>Two Wheeler</asp:ListItem>
                                                <asp:ListItem>Four Wheeler</asp:ListItem>
                                                <asp:ListItem>Three Wheeler</asp:ListItem>
                                                <asp:ListItem>Other</asp:ListItem>
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
                                            Color*:</td>
                                        <td class="style2">
                                            <asp:TextBox ID="TextBoxPN1" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPre0" runat="server" 
                                                ControlToValidate="TextBoxPN1" ErrorMessage="Enter Color"></asp:RequiredFieldValidator>
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
                                            Year of build:</td>
                                        <td class="style2">
                                            <asp:DropDownList ID="DropDownList5" runat="server">
                                                <asp:ListItem>1980</asp:ListItem>
                                                <asp:ListItem>1981</asp:ListItem>
                                                <asp:ListItem>1982</asp:ListItem>
                                                <asp:ListItem>1983</asp:ListItem>
                                                <asp:ListItem>1984</asp:ListItem>
                                                <asp:ListItem>1985</asp:ListItem>
                                                <asp:ListItem>1986</asp:ListItem>
                                                <asp:ListItem>1987</asp:ListItem>
                                                <asp:ListItem>1988</asp:ListItem>
                                                <asp:ListItem>1989</asp:ListItem>
                                                <asp:ListItem>1990</asp:ListItem>
                                                <asp:ListItem>1991</asp:ListItem>
                                                <asp:ListItem>1992</asp:ListItem>
                                                <asp:ListItem>1993</asp:ListItem>
                                                <asp:ListItem>1994</asp:ListItem>
                                                <asp:ListItem>1995</asp:ListItem>
                                                <asp:ListItem>1996</asp:ListItem>
                                                <asp:ListItem>1997</asp:ListItem>
                                                <asp:ListItem>1998</asp:ListItem>
                                                <asp:ListItem>1999</asp:ListItem>
                                                <asp:ListItem>2000</asp:ListItem>
                                                <asp:ListItem>2001</asp:ListItem>
                                                <asp:ListItem>2002</asp:ListItem>
                                                <asp:ListItem>2003</asp:ListItem>
                                                <asp:ListItem>2004</asp:ListItem>
                                                <asp:ListItem>2005</asp:ListItem>
                                                <asp:ListItem>2006</asp:ListItem>
                                                <asp:ListItem>2007</asp:ListItem>
                                                <asp:ListItem>2008</asp:ListItem>
                                                <asp:ListItem>2009</asp:ListItem>
                                                <asp:ListItem>2010</asp:ListItem>
                                                <asp:ListItem>2011</asp:ListItem>
                                                <asp:ListItem>2012</asp:ListItem>
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
