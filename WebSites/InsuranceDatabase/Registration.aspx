<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" Debug ="true"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Registration Page</title>
    <link href="login-box.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 109px;
            text-align: right;
        }
        .style2
        {
            width: 127px;
        }
        .style3
        {
            width: 109px;
            text-align: right;
            height: 26px;
        }
        .style4
        {
            width: 127px;
            height: 26px;
        }
        .style5
        {
            height: 26px;
            width: 82px;
        }
        .style6
        {
            width: 109px;
            text-align: right;
            height: 25px;
        }
        .style7
        {
            width: 127px;
            height: 25px;
        }
        .style8
        {
            height: 25px;
            width: 82px;
        }
        .style9
        {
            width: 109px;
            text-align: right;
            height: 29px;
        }
        .style10
        {
            width: 127px;
            height: 29px;
        }
        .style11
        {
            height: 29px;
            width: 82px;
        }
        .style12
        {
            width: 82px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="padding: 100px 0 0 250px;">


<div id="login-box">

<H2>Registration</H2>
Enter all the details below.
<br />
<br />
    <table style="width:100%;">
        <tr>
            <td class="style1">
                Customer ID:</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBoxUN" runat="server" Font-Size="Smaller" Height="16px" 
                            Width="128px" ></asp:TextBox>
                    </td>
                    <td class="style12">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                            ControlToValidate="TextBoxUN" ErrorMessage="Enter Valid ID" Font-Size="Smaller" 
                            ValidationExpression="[1-9][0-9][0-9][0-9][0-9]"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        Password:</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBoxPW" runat="server" Font-Size="Smaller" Height="16px" 
                            TextMode="Password" Width="128px"></asp:TextBox>
                    </td>
                    <td class="style12">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="TextBoxPW" ErrorMessage="Password required" 
                            Font-Size="Smaller"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        Re-Type Password</td>
                    <td class="style4">
                        <asp:TextBox ID="TextBoxRPW" runat="server" Font-Size="Smaller" Height="16px" 
                            TextMode="Password" Width="128px"></asp:TextBox>
                    </td>
                    <td class="style5">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="TextBoxRPW" ErrorMessage="Field required" 
                            Font-Size="Smaller"></asp:RequiredFieldValidator>
                        <br />
                        <asp:CompareValidator ID="CompareValidator1" runat="server" 
                            ControlToCompare="TextBoxPW" ControlToValidate="TextBoxRPW" 
                            ErrorMessage="CompareValidator" Font-Size="Smaller"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style6">
                        Email ID:</td>
                    <td class="style7">
                        <asp:TextBox ID="TextBoxEID" runat="server" Font-Size="Smaller" Height="16px" 
                            Width="128px"></asp:TextBox>
                    </td>
                    <td class="style8">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                            ControlToValidate="TextBoxEID" ErrorMessage="Enter Valid Email ID" 
                            Font-Size="Smaller" 
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style9">
                        Full Name:</td>
                    <td class="style10">
                        <asp:TextBox ID="TextBoxFN" runat="server" Font-Size="Smaller" Height="16px" 
                            Width="128px"></asp:TextBox>
                    </td>
                    <td class="style11">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                            ErrorMessage="Full Name Required" Font-Size="Smaller" 
                            ControlToValidate="TextBoxFN"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        &nbsp;</td>
                    <td class="style2">
                        <asp:Button ID="SubmitButton" runat="server" onclick="SubmitButton_Click1" 
                            style="text-align: center" Text="Submit" />
                    </td>
                    <td class="style12">
                        &nbsp;</td>
                </tr>
            </table>
<br />
            &nbsp;</div>

</div>
</form>
</body>
</html>

