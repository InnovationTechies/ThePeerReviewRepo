<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmStaff.aspx.cs" Inherits="PeerReviewSystem.frmStaff" %>
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
            <h1>Staff Members
            </h1>

            <asp:Label ID="lblRole" runat="server" Text="Role"></asp:Label>
            <asp:DropDownList ID="drpRole" runat="server" DataSourceID="objectJobRole" DataTextField="Role" DataValueField="roleID" CssClass="form-control" AutoPostBack="true"></asp:DropDownList>
            <br />

            <br />
            <div class="rounded_corners" style="width: 100%">
                <asp:GridView ID="grdStaff" runat="server" AutoGenerateColumns="False" DataSourceID="objectEmployee" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="table table-hover table-bordered">
                    <AlternatingRowStyle BackColor="White" />

                    <Columns>
                        <asp:BoundField DataField="empID" HeaderText="empID" SortExpression="empID" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
                        <asp:BoundField DataField="Surname" HeaderText="Surname" SortExpression="Surname"></asp:BoundField>
                        <asp:BoundField DataField="RoleID" HeaderText="RoleID" SortExpression="RoleID" Visible="false"></asp:BoundField>
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
    <asp:ObjectDataSource ID="objectEmployee" runat="server" SelectMethod="GetEmployees" TypeName="PeerReviewSystem.Models.ReviewRepository">
        <SelectParameters>
            <asp:ControlParameter ControlID="drpRole" PropertyName="SelectedValue" Name="RoleID" Type="Int32"></asp:ControlParameter>
        </SelectParameters>
    </asp:ObjectDataSource>

</asp:Content>
