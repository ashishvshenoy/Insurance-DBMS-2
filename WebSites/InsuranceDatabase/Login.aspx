<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" Debug ="true"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Login Page</title>
    <link href="login-box.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 86px;
            text-align: right;
        }
        .style2
        {
            width: 127px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="padding: 100px 0 0 250px;">


<div id="login-box">

<H2>Login</H2>
Enter your username and password.
<br />
<br />
    <table style="width:100%;">
        <tr>
            <td class="style1">
                Username:</td>
                    <td class="style2">
                        <asp:TextBox ID="UNtext" runat="server" Font-Size="Smaller" Height="16px" 
                            Width="128px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="UNtext" ErrorMessage="Username Required" Font-Size="Smaller"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        Password:</td>
                    <td class="style2">
                        <asp:TextBox ID="PWText" runat="server" Font-Size="Smaller" Height="16px" 
                            TextMode="Password" Width="128px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="PWText" ErrorMessage="Password required" Font-Size="Smaller"></asp:RequiredFieldValidator>
                    </td>
                </tr>
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
                        <asp:ImageButton ID="LoginButton" runat="server" 
                            ImageUrl="~/images/login-btn.png" onclick="LoginButton_Click1" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
<br />
            &nbsp;</div>

</div>
</form>
</body>
</html>

