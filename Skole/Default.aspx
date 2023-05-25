<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Skole.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Fornavn</td>
                    <td><asp:TextBox ID="Fornavn" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Etternavn</td>
                    <td><asp:TextBox ID="Etternavn" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>KlasseID</td>
                    <td><asp:TextBox ID="KlasseID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" Text="Søk" OnClick="Button1_Click" />
                        <asp:Button ID="Button2" runat="server" Text="Søk KlasseID" OnClick="Button2_Click" />
                    </td>
                </tr>                           
               
            </table>
            <br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
