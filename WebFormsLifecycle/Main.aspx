<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WebFormsLifecycle.Main" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Main page</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body style="background-color: rgb(128, 128, 128);">
    <form id="form1" runat="server">
        <br />
        <div class="container px-4">
            <div class="row gx-5" style="height: 600px;">
                <div class="col p-0">
                    <div class="p-4 border border-4 bg-light rounded-2 h-75">
                        <asp:Image CssClass="img-fluid rounded mx-auto d-block" Style="width: 400px; height:400px;" Visible="false" ID="cat" runat="server" ImageUrl="~/Content/cat/cat1.png" />
                           <%-- position-relative top-50 start-50 translate-middle rounded-3--%>
                    </div>
                </div>
                <div class="col">
                    <div class="p-3 border bg-light rounded-2 h-75">
                        <p class="position-relative top-50 start-50 translate-middle text-center">
                            <asp:Label ID="ClickLabel" runat="server" Text="Click to continue"></asp:Label>
                            <br />
                            <asp:Button ID="ClickMe_BTN" runat="server" Text="&#128176;" CssClass="btn btn-danger w-50 mt-3" OnClick="ClickMe_BTN_Click1"></asp:Button>
                        </p>
                    </div>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
