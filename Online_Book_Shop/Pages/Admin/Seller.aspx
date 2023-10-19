<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Seller.aspx.cs" Inherits="Online_Book_Shop.Pages.Admin.Seller" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col">
                <h3 class="text-center"><b>Manage Seller</b></h3>
            </div>
        </div>

        <div class="row">
            <div class="col-md-4" style="margin-top: 20px;">
                <div class="mt-3">
                    <label for="seller_name" class="form-label text-dark">Enter Seller Name</label>
                    <input type="text" placeholder="Seller Name" name="seller_name" class="form-control" runat="server" id="Seller_Name"/>
                </div>

                <asp:Label runat="server" ID="Name_Error" class="text-danger"></asp:Label>

                <div class="mt-3">
                    <label for="seller_email_id" class="form-label text-dark">Enter Seller Email Id</label>
                    <input type="email" placeholder="Seller Email Id" name="seller_email_id" class="form-control" runat="server" id="Seller_Email_Id"/>
                </div>

                <asp:Label runat="server" ID="Email_Id_Error" class="text-danger"></asp:Label>

                <div class="mt-3">
                    <label for="seller_contact_no" class="form-label text-dark">Enter Seller Contact No</label>
                    <input type="tel" placeholder="Seller Contact No" name="seller_contact_no" class="form-control" runat="server" id="Seller_Contact_No"/>
                </div>

                <asp:Label runat="server" ID="Contact_No_Error" class="text-danger"></asp:Label>

                <div class="mt-3">
                    <label for="seller_password" class="form-label text-dark">Enter Seller Password</label>
                    <input type="text" placeholder="Seller Password" name="seller_password" class="form-control" runat="server" id="Seller_Password"/>
                </div>

                <asp:Label runat="server" ID="Password_Error" class="text-danger"></asp:Label>

                <br />

                <asp:Label runat="server" ID="Success_Msg" class="text-success"></asp:Label>

                <asp:Label runat="server" ID="Other_Error" class="text-danger"></asp:Label>

                <div class="row mt-4">

                    <div class="col d-grid"><asp:Button Text="Update" ID="UpdateBtn" runat="server" class="btn-warning btn-block btn" OnClick="UpdateBtn_Click"/></div>
                    <div class="col d-grid"><asp:Button Text="Add" ID="AddBtn" runat="server" class="btn-primary btn-block btn" OnClick="AddBtn_Click"/></div>
                    <div class="col d-grid"><asp:Button Text="Delete" ID="DeleteBtn" runat="server" class="btn-danger btn-block btn" OnClick="DeleteBtn_Click"/></div>
                </div>

            </div>

            <div class="col-md-8">

                <h4 class="text-center" style="margin-top: 15px">Seller Information</h4>

                <asp:GridView ID="Sellers_List" runat="server" class="table table-bordered" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="true" OnSelectedIndexChanged="Sellers_List_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="false" ForeColor="White" />
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

</asp:Content>
