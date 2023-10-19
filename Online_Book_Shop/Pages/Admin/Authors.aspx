<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Authors.aspx.cs" Inherits="Online_Book_Shop.Pages.Admin.Author" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col">
                <h3 class="text-center"><b>Manage Authors</b></h3>
            </div>
        </div>

        <div class="row">
            <div class="col-md-4" style="margin-top: 3px;">
                <div class="mt-3">
                    <label for="author_name" class="form-label text-dark">Enter Author Name</label>
                    <input type="text" placeholder="Author Name" name="author_name" class="form-control" runat="server" id="Author_Name"/>
                </div>

                <asp:Label runat="server" ID="Name_Error" class="text-danger"></asp:Label>

                <div class="mt-3">
                    <label for="author_gender" class="form-label text-dark">Select Gender</label>
                    <asp:DropDownList ID="Author_Gender"  runat="server" class="form-control">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <asp:Label runat="server" ID="Gender_Error" class="text-danger"></asp:Label>

                <div class="mt-3">
                    <label for="author_country" class="form-label text-dark">Select Country</label>
                    <asp:DropDownList ID="Author_Country" runat="server" class="form-control">
                        <asp:ListItem>India</asp:ListItem>
                        <asp:ListItem>Australia</asp:ListItem>
                        <asp:ListItem>USA</asp:ListItem>
                        <asp:ListItem>France</asp:ListItem>
                        <asp:ListItem>England</asp:ListItem>
                        <asp:ListItem>West Indies</asp:ListItem>
                        <asp:ListItem>Other</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <asp:Label runat="server" ID="Country_Error" class="text-danger"></asp:Label>

                <br />

                <asp:Label runat="server" ID="Success_Msg" class="text-success"></asp:Label>

                <asp:Label runat="server" ID="Other_Error" class="text-danger"></asp:Label>

                <div class="row mt-4">
                    <div class="col d-grid"><asp:Button Text="Update" ID="UpdateBtn" runat="server" class="btn-warning btn-block btn" OnClick="UpdateBtn_Click"/></div>
                    <div class="col d-grid"><asp:Button Text="Add" ID="AddBtn" runat="server" class="btn-primary btn-block btn" OnClick="AddBtn_Click"/></div>
                    <div class="col d-grid"><asp:Button Text="Delete" ID="DeleteBtn" runat="server" class="btn-danger btn-block btn" OnClick="DeleteBtn_Click"/></div>
                </div>

            </div>

            <div class="col-md-8" style="margin-top:15px;">

                <h4 class="text-center">Author List</h4>

                <asp:GridView ID="Authors_List" runat="server" class="table table-bordered" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="true" OnSelectedIndexChanged="Authors_List_SelectedIndexChanged">
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
