<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmAddRole.aspx.cs" Inherits="PeerReviewSystem.frmAddRole" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     &nbsp;&nbsp;&nbsp;

    <style type="text/css">
        .rounded_corners {
            border: 1px solid #A1DCF2;
            -webkit-border-radius: 8px;
            -moz-border-radius: 8px;
            border-radius: 8px;
            overflow: hidden;
        }

            .rounded_corners td, .rounded_corners th {
                border: 1px solid #A1DCF2;
                font-family: Arial;
                font-size: 10pt;
                text-align: left;
            }

            .rounded_corners table table td {
                border-style: none;
            }
    </style>

    <br />
    <div class="row">
        <div class="form-group">
            <h1>Add Role
            </h1>

            <asp:Label ID="lblRole" runat="server" Text="Role"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Field is required" ControlToValidate="txtRole">
                <asp:TextBox ID="txtRole" runat="server" CssClass="form-control" Width="100%" ValidateRequestMode="Enabled"></asp:TextBox>
            </asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="btnSave_Click" />
            <br />
              <br /> 
            <div class="rounded_corners" style="width: 100%">
                <asp:GridView ID="grdRoleAdd" runat="server" AutoGenerateColumns="False" DataSourceID="objectJobRole" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="table table-hover table-bordered" AllowPaging="True" DataKeyNames="roleID">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:CommandField ShowEditButton="True"></asp:CommandField>
                        <asp:BoundField DataField="roleID" HeaderText="roleID" SortExpression="roleID"></asp:BoundField>
                        <asp:BoundField DataField="Role" HeaderText="Role" SortExpression="Role"></asp:BoundField>
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
            </div>




        </div>
    </div>
    <asp:ObjectDataSource ID="objectJobRole" runat="server" DataObjectTypeName="PeerReviewSystem.Models.JobRole" InsertMethod="InsertRole" SelectMethod="GetJobRoles" TypeName="PeerReviewSystem.Models.ReviewRepository" UpdateMethod="UpdatetRole"></asp:ObjectDataSource>

</asp:Content>
