<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="Online_Book_Shop.Pages.Admin.Books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col">
                <h3 class="text-center"><b>Manage Books</b></h3>
            </div>
        </div>

        <div class="row">
            <div class="col-md-4" style="margin-top: 20px;">
                <div class="mt-3">
                    <label for="book_name" class="form-label text-dark">Enter Book Name</label>
                    <input type="text" placeholder="Book Name" name="book_name" class="form-control" runat="server" id="Book_Name"/>
                </div>

                <asp:Label runat="server" ID="Name_Error" class="text-danger"></asp:Label>

                <div class="mt-3">
                    <label for="book_author" class="form-label text-dark">Select Book Author</label>
                    <asp:DropDownList ID="Book_Author" runat="server" class="form-control"></asp:DropDownList>
                </div>

                <asp:Label runat="server" ID="Author_Error" class="text-danger"></asp:Label>

                <div class="mt-3">
                    <label for="categories_name" class="form-label text-dark">Select Book Category</label>
                    <asp:DropDownList ID="Book_Category" runat="server" class="form-control"></asp:DropDownList>
                </div>

                <asp:Label runat="server" ID="Category_Error" class="text-danger"></asp:Label>

                <div class="mt-3">
                    <label for="book_price" class="form-label text-dark">Enter Book Price</label>
                    <input type="number" placeholder="Book Price" name="book_price" class="form-control" runat="server" id="Book_Price"/>
                </div>

                <asp:Label runat="server" ID="Price_Error" class="text-danger"></asp:Label>

                <div class="mt-3">
                    <label for="book_quantity" class="form-label text-dark">Enter Book Quantity</label>
                    <input type="number" placeholder="Book Quantity" name="book_quantity" class="form-control" runat="server" id="Book_Quantity"/>
                </div>

                <asp:Label runat="server" ID="Quantity_Error" class="text-danger"></asp:Label>

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

                 <h4 class="text-center" style="margin-top: 15px">Book List</h4>

                <asp:GridView ID="Books_List" runat="server" class="table table-bordered" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="true" OnSelectedIndexChanged="Books_List_SelectedIndexChanged">
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
