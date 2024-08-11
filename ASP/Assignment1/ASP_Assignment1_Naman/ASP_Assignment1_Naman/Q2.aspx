<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Q2.aspx.cs" Inherits="ASP_Assignment1_Naman.Q2" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fruit Selector</title>
    <style>
        .fruit-container {
            text-align: center;
            padding: 20px;
        }
        .fruit-image {
            width: 200px;
            height: 200px;
            border-radius: 10px;
        }
        .fruit-details {
            margin-top: 20px;
            font-size: 20px;
            font-weight: bold;
        }
        .fruit-selection {
            margin-bottom: 20px;
        }
    </style>
</head>
<body style="height: 393px">
    <form id="fruitForm" runat="server" class="fruit-container">
        <div class="fruit-selection">
            <asp:Label ID="lblSelectFruit" runat="server" Text="Select a Fruit: "></asp:Label>
            <asp:DropDownList ID="ddlFruits" runat="server">
                <asp:ListItem Text="--Select Fruit--" Value="" />
                <asp:ListItem Text="Apple" Value="Apple" />
                <asp:ListItem Text="Banana" Value="Banana" />
                <asp:ListItem Text="Orange" Value="Orange" />
                <asp:ListItem Text="Guava" Value="Guava" />
                <asp:ListItem Text="Mango" Value="Mango" />
                <asp:ListItem Text="Pomegranate" Value="Pomegranate" />
                <asp:ListItem Text="Pineapple" Value="Pineapple" />
            </asp:DropDownList>
        </div>
        <asp:Image ID="imgFruit" runat="server" CssClass="fruit-image" />
        <div class="fruit-details">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Check Price" />
            <br />
            <br />
            <asp:Label ID="lblPrice" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>