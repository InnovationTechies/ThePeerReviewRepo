<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmProjects.aspx.cs" Inherits="PeerReviewSystem.frmProjects" %>
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
            <h1>Projects
            </h1>

            <br />
            <div class="rounded_corners" style="width: 100%">
                <asp:GridView ID="grdProjects" runat="server" AutoGenerateColumns="False" DataSourceID="objectProject" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="table table-hover table-bordered">
                    <AlternatingRowStyle BackColor="White" />

                    <Columns>
                        <asp:BoundField DataField="projectID" HeaderText="projectID" SortExpression="projectID"></asp:BoundField>
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
                        <asp:BoundField DataField="StartDate" HeaderText="StartDate" SortExpression="StartDate"></asp:BoundField>
                        <asp:BoundField DataField="EndDate" HeaderText="EndDate" SortExpression="EndDate"></asp:BoundField>
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
    <asp:ObjectDataSource ID="objectProject" runat="server" SelectMethod="GetProjects" TypeName="PeerReviewSystem.Models.ReviewRepository"></asp:ObjectDataSource>
</asp:Content>
