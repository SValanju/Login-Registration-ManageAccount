<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginRegistration.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
</head>
<body>
    <div class="container border-dark my-5">
        <form id="form1" runat="server">
            <h3>Login Here.</h3>
            <hr />
            <div class="row my-3">
                <asp:Label ID="Label1" runat="server" Text="Username :" CssClass="col-md-3 col-4"></asp:Label>
                <asp:TextBox ID="uname" runat="server" CssClass="col-md-6 col-7"></asp:TextBox>
            </div>
            <div class="row my-3">
                <asp:Label ID="Label2" runat="server" Text="Password :" CssClass="col-md-3 col-4"></asp:Label>
                <asp:TextBox ID="pass" runat="server" CssClass="col-md-6 col-7" TextMode="Password"></asp:TextBox>
            </div>
            <div class="col-md-9 col-11 m-0 d-flex justify-content-center">
                <asp:Button ID="login" runat="server" Text="Login" OnClick="login_Click" CssClass="mx-3" />
                <asp:Label ID="Label3" runat="server" Text="New User?" CssClass="mx-2"></asp:Label>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Registration.aspx">Sign up here.</asp:HyperLink>
            </div>
            <div class="row m-0 d-flex justify-content-center">
                <asp:Label ID="Label4" runat="server" CssClass="text-danger"></asp:Label>
            </div>
        </form>
    </div>
</body>
</html>
