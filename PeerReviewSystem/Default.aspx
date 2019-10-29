<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PeerReviewSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

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
                text-align: center;
            }

            .rounded_corners table table td {
                border-style: none;
            }
    </style>

    <div class="row">
        <div class="form-group">
            <br />
            <asp:Label ID="lblProjectLead" runat="server" Text="Project Lead"></asp:Label>
            <asp:DropDownList ID="drpProjectLead" runat="server" DataSourceID="objectEmployee" DataTextField="Name" DataValueField="empID" CssClass="form-control"></asp:DropDownList>

            <br />
            <asp:Label ID="lblReviewer" runat="server" Text="Reviewer"></asp:Label>
            <asp:DropDownList ID="dropReviewer" runat="server" DataSourceID="objectEmployee" DataTextField="Name" DataValueField="empID" CssClass="form-control"></asp:DropDownList>

            <br />
            <asp:Label ID="lblProject" runat="server" Text="Project"></asp:Label>
            <asp:DropDownList ID="drpProject" runat="server" DataSourceID="objectProject" DataTextField="Name" DataValueField="projectID" CssClass="form-control"></asp:DropDownList>

            <br />
            <asp:Label ID="lblReviewee" runat="server" Text="Reviewee"></asp:Label>
            <asp:DropDownList ID="drpReviewee" runat="server" DataSourceID="objectEmployee" DataTextField="Name" DataValueField="RoleID" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="drpReviewee_SelectedIndexChanged"></asp:DropDownList>
            <br />

            <hr />
            <div class="rounded_corners" style="width: 100%">
                <asp:GridView ID="grdRevQuestion" runat="server" class="table-responsive" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="table table-hover table-bordered" AutoGenerateColumns="False" DataSourceID="objectQuestions" AllowPaging="True">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="questionID" HeaderText="questionID" SortExpression="questionID" />
                        <asp:BoundField DataField="Question" HeaderText="Question" SortExpression="Question" />
                        <asp:BoundField DataField="RoleID" HeaderText="RoleID" SortExpression="RoleID" />
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


            <asp:Button ID="btnSaveReview" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="btnSaveReview_Click" />


            <br />

        </div>

        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="grdReview" runat="server" AutoGenerateColumns="False" DataSourceID="objectReview" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="table table-hover table-bordered" AllowPaging="True">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True"></asp:CommandField>
                <asp:BoundField DataField="reviewID" HeaderText="reviewID" SortExpression="reviewID" />
                <asp:BoundField DataField="ReviewDate" HeaderText="ReviewDate" SortExpression="ReviewDate" />
                <asp:BoundField DataField="ProjectManager" HeaderText="ProjectManager" SortExpression="ProjectManager" />
                <asp:BoundField DataField="reviewer" HeaderText="reviewer" SortExpression="reviewer" />
                <asp:BoundField DataField="project" HeaderText="project" SortExpression="project" />
                <asp:BoundField DataField="reviewee" HeaderText="reviewee" SortExpression="reviewee" />
                <asp:BoundField DataField="question" HeaderText="question" SortExpression="question" />
                <asp:BoundField DataField="rating" HeaderText="rating" SortExpression="rating" />

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
        <br />
        <br />
        <asp:ObjectDataSource ID="objectAnswers" runat="server" SelectMethod="GetAnswerRating" TypeName="PeerReviewSystem.Models.ReviewRepository"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="objectEmployee" runat="server" SelectMethod="GetEmployees" TypeName="PeerReviewSystem.Models.ReviewRepository"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="objectProject" runat="server" SelectMethod="GetProjects" TypeName="PeerReviewSystem.Models.ReviewRepository"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="objectQuestions" runat="server" SelectMethod="GetQuestionsByEmployee" TypeName="PeerReviewSystem.Models.ReviewRepository">
            <SelectParameters>
                <asp:ControlParameter ControlID="drpReviewee" PropertyName="SelectedValue" Name="RoleID" Type="Int32"></asp:ControlParameter>
            </SelectParameters>
        </asp:ObjectDataSource>

        <asp:ObjectDataSource ID="objectReview" runat="server" SelectMethod="GetReviews" TypeName="PeerReviewSystem.Models.ReviewRepository" DataObjectTypeName="PeerReviewSystem.Models.Review" DeleteMethod="DeleteReview" InsertMethod="InsertReview" UpdateMethod="UpdateReview"></asp:ObjectDataSource>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

    </div>

</asp:Content>
