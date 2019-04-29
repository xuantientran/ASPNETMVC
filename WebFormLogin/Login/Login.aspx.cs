using System;

public partial class Login : System.Web.UI.Page
{
	protected void LoginButton_Click(object sender, EventArgs e)
	{
		if (UserName.Text == "super" && Password.Text == "super")
		{
			Response.Redirect("../Default.aspx");
		}
		else
		{
			Response.Write("Invalid User");
		}
	}
}