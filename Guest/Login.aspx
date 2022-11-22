<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjectNEST.Guest.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>Login</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="username"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            </td>
            
        </tr>
    </table>
</asp:Content>
