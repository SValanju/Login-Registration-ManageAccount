<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageDetails.aspx.cs" Inherits="LoginRegistration.ManageDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manage Account Page</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
</head>
<body>
    
    <div class="container my-5">
        <h3>Manage Account</h3>
        <form runat="server" class="py-5" id="form1">
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <div class="form-group row">
                <asp:Label ID="Label1" runat="server" Text="First Name:" CssClass="col-md-3 col-3"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="col-md-4 col-4"></asp:TextBox>
            </div>
            <div class="form-group row">
                <asp:Label ID="Label2" runat="server" Text="Last Name:" CssClass="col-md-3 col-3"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="col-md-4 col-4"></asp:TextBox>
            </div>
            <div class="form-group row">
                <asp:Label ID="Label3" runat="server" Text="Email:" CssClass="col-md-3 col-3"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" CssClass="col-md-4 col-4"></asp:TextBox>
            </div>
            <div class="form-group row">
                <asp:Label ID="Label4" runat="server" Text="UserName:" CssClass="col-md-3 col-3"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" CssClass="col-md-4 col-4"></asp:TextBox>
            </div>
            <div class="form-group row">
                <asp:Label ID="Label5" runat="server" Text="New Passsword:" CssClass="col-md-3 col-3"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server" CssClass="col-md-4 col-4"></asp:TextBox>
            </div>
            <div class="col-md-7 col-7 d-flex justify-content-center">
                <asp:Button ID="update" runat="server" Text="Update" OnClick="update_Click" CssClass="mx-3" />
                <asp:Button ID="cancel" runat="server" Text="Cancel" OnClick="cancel_Click" CssClass="mx-3" />
            </div>
            <asp:LinkButton ID="delete" runat="server" OnClick="delete_Click" CssClass="text-danger">Delete Account</asp:LinkButton>
        </form>
        <asp:Label ID="msg" runat="server" CssClass="text-success"></asp:Label>
        <asp:Label ID="err" runat="server" CssClass="text-danger"></asp:Label>
    </div>

</body>
</html>
