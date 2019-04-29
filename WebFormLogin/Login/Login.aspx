﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>

			<table cellpadding="1" cellspacing="0" style="border-collapse: collapse;">
				<tr>
					<td>
						<table cellpadding="0">
							<tr>
								<td align="center" colspan="2">Log In</td>
							</tr>
							<tr>
								<td align="right">
									<asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:</asp:Label>
								</td>
								<td>
									<asp:TextBox ID="UserName" runat="server"></asp:TextBox>
									<asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
								</td>
							</tr>
							<tr>
								<td align="right">
									<asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
								</td>
								<td>
									<asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
									<asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
								</td>
							</tr>
							<tr>
								<td align="center" colspan="2" style="color: Red;">
									<asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
								</td>
							</tr>
							<tr>
								<td align="right" colspan="2">
									<asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" ValidationGroup="Login1" OnClick="LoginButton_Click" />
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>

		</div>
	</form>
</body>
</html>
