<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="productlogin.aspx.cs" Inherits="ProjectNEST.Admin.productlogin" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table align="center" ><h2>Product Registration</h2>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Product Name:"></asp:Label>
            </td>
             <td>
                 <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Product Description:"></asp:Label>
            </td>
             <td>
                 <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                             <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click1"  />

            </td>
             </tr>

             
        </table>
    <table>
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="pid"  OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit1" OnRowDeleting="GridView1_RowDeleting" >
            <Columns>
                 <asp:BoundField DataField="pid" HeaderText="ID" />
                    <asp:BoundField DataField="pname" HeaderText="Product Name" />
                    <asp:BoundField DataField="pprice" HeaderText="Product Price" />
                    <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
                    <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
