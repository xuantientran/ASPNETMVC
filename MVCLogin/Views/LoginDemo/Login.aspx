<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLoginDemo.Models.ClsUserBO>" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Login</title>
    <script src="../../Scripts/jquery-1.7.1.js" type="text/javascript"></script>
    <script src="../../Scripts/jquery.validate.min.js"></script>
    <script src="../../Scripts/jquery.validate.unobtrusive.js"></script>
</head>
<body>
    <div>
        <% using (Html.BeginForm("ValidateUser", "LoginDemo", FormMethod.Post))
           { %>
        <%Html.EnableClientValidation(); %>
        <%Html.EnableUnobtrusiveJavaScript(); %>
        <%=Html.ValidationSummary() %>
        User Name :
        <%=Html.TextBoxFor(x => x.UserName) %>        
        <br />
        Password :
        <%=Html.PasswordFor(x => x.Password) %>
        <br />
        <input id="Submit1" type="submit" value="submit" />
        <% } %>
    </div>
</body>
</html>
