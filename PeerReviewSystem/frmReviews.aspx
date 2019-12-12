<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmReviews.aspx.cs" Inherits="PeerReviewSystem.frmReviews" %>

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

            <br />
            <asp:Label ID="lblStaff" runat="server" Text="Staff"></asp:Label>
            <asp:DropDownList ID="drpReviewee" runat="server" DataSourceID="objectEmployee" DataTextField="Name" DataValueField="empID" CssClass="form-control" AutoPostBack="True"></asp:DropDownList>
            <br />

            <br />
             <div class="rounded_corners" style="width: 100%">
                 <asp:GridView ID="grdReview" runat="server" AutoGenerateColumns="False" DataSourceID="objectReview" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="table table-hover table-bordered" AllowPaging="True">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="ReviewDate" HeaderText="ReviewDate" SortExpression="ReviewDate" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Surname" HeaderText="Surname" SortExpression="Surname" />
                    <asp:BoundField DataField="Role" HeaderText="Role" SortExpression="Role" />
                    <asp:BoundField DataField="Question" HeaderText="Question" SortExpression="Question" />
                    <asp:BoundField DataField="rating" HeaderText="rating" SortExpression="rating" />

                    <asp:BoundField DataField="projectID" HeaderText="projectID" SortExpression="projectID" />

                    <asp:BoundField DataField="ProjectLeadID" HeaderText="ProjectLeadID" SortExpression="ProjectLeadID"></asp:BoundField>
                    <asp:BoundField DataField="questionID" HeaderText="questionID" SortExpression="questionID"></asp:BoundField>
                    <asp:BoundField DataField="ratingID" HeaderText="ratingID" SortExpression="ratingID"></asp:BoundField>
                    <asp:BoundField DataField="revieweeID" HeaderText="revieweeID" SortExpression="revieweeID"></asp:BoundField>
                    <asp:BoundField DataField="reviewerID" HeaderText="reviewerID" SortExpression="reviewerID"></asp:BoundField>
                    <asp:BoundField DataField="reviewID" HeaderText="reviewID" SortExpression="reviewID"></asp:BoundField>
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

            <br />
            <br />
            <asp:ObjectDataSource ID="objectEmployee" runat="server" SelectMethod="GetEmployees" TypeName="PeerReviewSystem.Models.ReviewRepository"></asp:ObjectDataSource>

            <asp:ObjectDataSource ID="objectReview" runat="server" SelectMethod="uspGetReviewsEmployee" TypeName="PeerReviewSystem.Models.ReviewRepository" DataObjectTypeName="PeerReviewSystem.Models.Review" DeleteMethod="DeleteReview" InsertMethod="InsertReview" UpdateMethod="UpdateReview">
                <SelectParameters>
                    <asp:ControlParameter ControlID="drpReviewee" PropertyName="SelectedValue" Name="empID" Type="Int32"></asp:ControlParameter>
                </SelectParameters>
            </asp:ObjectDataSource>
            <br />

        </div>
    </div>



</asp:Content>
