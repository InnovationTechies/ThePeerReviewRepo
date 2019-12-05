<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmRoles.aspx.cs" Inherits="PeerReviewSystem.frmRoles" %>

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

    <div class="row">
        <div class="form-group">
            <h1>Roles
            </h1>

            <br />
            <div class="rounded_corners" style="width: 100%">
                <asp:GridView ID="grdRoles" runat="server" AutoGenerateColumns="False" DataSourceID="objectJobRole" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="table table-hover table-bordered">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
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
     <br />
    <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="btn btn-primary" />

    <br />
    <asp:ObjectDataSource ID="objectJobRole" runat="server" DataObjectTypeName="PeerReviewSystem.Models.JobRole" InsertMethod="InsertRole" SelectMethod="GetJobRoles" TypeName="PeerReviewSystem.Models.ReviewRepository" UpdateMethod="UpdatetRole"></asp:ObjectDataSource>
</asp:Content>
