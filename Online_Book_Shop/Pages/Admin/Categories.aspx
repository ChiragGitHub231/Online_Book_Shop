<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="Online_Book_Shop.Pages.Admin.Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col">
                <h3 class="text-center"><b>Manage Categories</b></h3>
            </div>
        </div>

        <div class="row">
            <div class="col-md-4" style="margin-top: 20px;">
                <div class="mt-3">
                    <label for="category_name" class="form-label text-dark">Enter Category Name</label>
                    <input type="text" placeholder="Category Name" name="category_name" class="form-control" runat="server" id="Category_Name"/>
                </div>

                <asp:Label runat="server" ID="Name_Error" class="text-danger"></asp:Label>

                <div class="mt-3">
                    <label for="category_description" class="form-label text-dark">Enter Category Description</label>
                    <input type="text" placeholder="Category Description" name="category_description" class="form-control" runat="server" id="Category_Description"/>
                </div>

                <asp:Label runat="server" ID="Description_Error" class="text-danger"></asp:Label>

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

                <h4 class="text-center" style="margin-top: 5px">Category List</h4>

               <asp:GridView ID="Categories_List" runat="server" class="table table-bordered" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="true" OnSelectedIndexChanged="Categories_List_SelectedIndexChanged">
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
