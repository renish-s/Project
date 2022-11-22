<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="Admstudentdetails.aspx.cs" Inherits="ProjectNEST.Admin.Admstudentdetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting">

         <Columns>
        <asp:BoundField DataField="userid" HeaderText="User Id" />
        <asp:BoundField DataField="name" HeaderText="Username" />
        <asp:BoundField DataField="email" HeaderText="Email" />
        <asp:BoundField DataField="phno" HeaderText="Phone" />
        
             <asp:CommandField DeleteText="confirm" HeaderText="confirm" ShowDeleteButton="True" />
        
    </Columns>

    </asp:GridView>
</asp:Content>
