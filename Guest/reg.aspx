<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Site1.Master" AutoEventWireup="true" CodeBehind="reg.aspx.cs" Inherits="ProjectNEST.User.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table align="center"><h1> REGISTRATION PAGE</h1>
           <tr>
                 <td>
                    <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                 <td>
                    <asp:Label ID="Label3" runat="server" Text="Email:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                 <td>
                    <asp:Label ID="Label4" runat="server" Text="Ph No:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
          <tr>
                 <td>
                    <asp:Label ID="Label1" runat="server" Text="Login:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
         <tr>
             <td>
                 <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
             </td>
         </tr>
        </table>
</asp:Content>
