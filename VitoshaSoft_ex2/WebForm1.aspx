<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="VitoshaSoft_ex2.WebForm1" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Credit</title>
</head>
<body>
    <header style="font-family:sans-serif; font-size:larger"> Credit List </header>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList id="CreditList"
                    AutoPostBack="True"
                    OnSelectedIndexChanged="Credit_Load"
                    runat="server">

                  <asp:ListItem style="color:lightgrey;" disabled="disabled" Selected="False" > Select credit ID </asp:ListItem>
                  <asp:ListItem Value="aN87"> aN87 </asp:ListItem>
                  <asp:ListItem Value="Bj96"> Bj96 </asp:ListItem>
                  <asp:ListItem Value="Kh54"> Kh54 </asp:ListItem>

               </asp:DropDownList>
            <br />
            <br />
            <br />
            <br />
            <asp:TextBox BorderStyle="Inset" Visible="false" ID="TextBox2" runat="server" ReadOnly="true" Width="430" Columns="6" TextMode="SingleLine" Font-Bold="True" BackColor="#A5DAF3"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox Visible="false" ID="TexBox1" runat="server" ReadOnly="true" Width="430" Columns="6" TextMode="SingleLine" BorderStyle="None"></asp:TextBox>
        </div>
    </form>
</body>
</html>
