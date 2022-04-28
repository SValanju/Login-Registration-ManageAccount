<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LoginRegistration.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
</head>
<body>

    <div class="container">
        <form runat="server">
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <h1 class="my-5">Hello <asp:Label ID="usr" runat="server" Text="User!"></asp:Label></h1>
            <asp:Label ID="Label1" runat="server" Text="Click on below link to manage your account."></asp:Label>
            <br />
            <%--<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ManageDetails.aspx">Manage Account</asp:HyperLink>--%>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Manage Account</asp:LinkButton>
            <asp:Label ID="err" runat="server" CssClass="text-danger" Text="Some error occurred! Please wait." Visible="false"></asp:Label>
        </form>
    </div>

</body>
</html>
