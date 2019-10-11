<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PeerReviewSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Welcome</h1>
        <p class="lead">Please select and start review on project and team members</p>
    </div>
    <div class="row">

        <div class="form-group">

            <br />

            <asp:Label ID="lblProjectLead" runat="server" Text="Project Lead"></asp:Label>
            <asp:DropDownList ID="drpProjectLead" runat="server" DataSourceID="objectEmployee" DataTextField="Name" DataValueField="empID" CssClass="form-control"></asp:DropDownList>

            <br />

            <asp:Label ID="lblReviewer" runat="server" Text="Reviewer"></asp:Label>
            <asp:DropDownList ID="dropReviewer" runat="server" DataSourceID="objectEmployee" DataTextField="Name" DataValueField="empID" CssClass="form-control"></asp:DropDownList>

        </div>

        <br />
        <asp:Label ID="lblProject" runat="server" Text="Project"></asp:Label>
        <asp:DropDownList ID="drpProject" runat="server" DataSourceID="objectProject" DataTextField="Name" DataValueField="projectID" CssClass="form-control"></asp:DropDownList>


        <br />

        <asp:Label ID="lblReviewee" runat="server" Text="Reviewee"></asp:Label>
        <asp:DropDownList ID="drpReviewee" runat="server" DataSourceID="objectEmployee" DataTextField="Name" DataValueField="Role" CssClass="form-control" OnSelectedIndexChanged="drpReviewee_SelectedIndexChanged"></asp:DropDownList>

        <br />

        <br />

        <div class="table-responsive">
            <asp:GridView ID="grdViewQuestions" runat="server" class="table-responsive" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
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
            <div />
            
            <br />
            

            <div class="table-responsive">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="objectReview" CellPadding="4" ForeColor="#333333" GridLines="None" class="table-responsive">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="reviewID" HeaderText="reviewID" SortExpression="reviewID" Visible="false" />
                        <asp:BoundField DataField="ReviewDate" HeaderText="ReviewDate" SortExpression="ReviewDate" />
                        <asp:BoundField DataField="Project_Manager" HeaderText="Project_Manager" SortExpression="Project_Manager" />
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

            </div>
            <br />
            <asp:DetailsView ID="DetailsView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="50px" Width="125px" AutoGenerateRows="False" DataSourceID="objectReview" DefaultMode="Insert" OnPageIndexChanging="DetailsView1_PageIndexChanging" DataKeyNames="reviewID" CssClass="form-control">
                <AlternatingRowStyle BackColor="White" />
                <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
                <EditRowStyle BackColor="#2461BF" />
                <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
                <Fields>
                    <asp:BoundField DataField="reviewID" HeaderText="reviewID" SortExpression="reviewID" InsertVisible="false" />
                    <asp:BoundField DataField="ReviewDate" HeaderText="ReviewDate" SortExpression="ReviewDate" />
                    <asp:BoundField DataField="Project_Manager" HeaderText="Project_Manager" SortExpression="Project_Manager" />
                    <asp:BoundField DataField="reviewer" HeaderText="reviewer" SortExpression="reviewer" />
                    <asp:BoundField DataField="project" HeaderText="project" SortExpression="project" />
                    <asp:BoundField DataField="reviewee" HeaderText="reviewee" SortExpression="reviewee" />
                    <asp:BoundField DataField="question" HeaderText="question" SortExpression="question" />
                    <asp:BoundField DataField="rating" HeaderText="rating" SortExpression="rating" />
                    <asp:CommandField ShowInsertButton="True" />
                </Fields>
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
            </asp:DetailsView>
            <br />
            <asp:ObjectDataSource ID="objectEmployee" runat="server" SelectMethod="GetEmployees" TypeName="PeerReviewSystem.Models.ReviewRepository"></asp:ObjectDataSource>
            <asp:ObjectDataSource ID="objectProject" runat="server" SelectMethod="GetProjects" TypeName="PeerReviewSystem.Models.ReviewRepository"></asp:ObjectDataSource>
            <asp:ObjectDataSource ID="objectQuestions" runat="server" SelectMethod="GetQuestions" TypeName="PeerReviewSystem.Models.ReviewRepository"></asp:ObjectDataSource>

            <asp:ObjectDataSource ID="objectReview" runat="server" SelectMethod="GetReviews" TypeName="PeerReviewSystem.Models.ReviewRepository" DataObjectTypeName="PeerReviewSystem.Models.Review" DeleteMethod="DeleteReview" InsertMethod="InsertReview" UpdateMethod="UpdateReview"></asp:ObjectDataSource>
            <br />
            <br />
        </div>

    </div>

    </div>

</asp:Content>
