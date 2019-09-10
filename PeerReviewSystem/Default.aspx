<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PeerReviewSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Welcome</h1>
        <p class="lead">Please select and start review on project and team members</p>
    </div>
    <div class="row">
       <div class="form-group">
           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None">
               <AlternatingRowStyle BackColor="White" />
               <Columns>
                   <asp:CommandField ShowSelectButton="True" />
                   <asp:BoundField DataField="roleID" HeaderText="roleID" SortExpression="roleID" />
                   <asp:BoundField DataField="Role" HeaderText="Role" SortExpression="Role" />
               </Columns>
               <EditRowStyle BackColor="#2461BF" />
               <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
               <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
               <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
               <RowStyle BackColor="#EFF3FB" />
               <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
               <SortedAscendingCellStyle BackColor="#F5F7FB" />
               <SortedAscendingHeaderStyle BackColor="#6D95E1" />
               <SortedDescendingCellStyle BackColor="#E9EBEF" />
               <SortedDescendingHeaderStyle BackColor="#4870BE" />
           </asp:GridView>
           <br />
           <asp:DetailsView ID="DetailsView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="50px" Width="125px">
               <AlternatingRowStyle BackColor="White" />
               <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
               <EditRowStyle BackColor="#2461BF" />
               <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
               <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
               <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
               <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
               <RowStyle BackColor="#EFF3FB" />
           </asp:DetailsView>
           <br />
           <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetJobRoles" TypeName="PeerReviewSystem.Models.ReviewRepository"></asp:ObjectDataSource>
       </div>
        
    </div>

</asp:Content>
