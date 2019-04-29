<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLoginDemo.Models.ClsUserBO>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Login Successfull</title>
</head>
<body>
    <div>
        Welcome <%= Model.UserName %>. Congratulations.
    </div>
</body>
</html>
