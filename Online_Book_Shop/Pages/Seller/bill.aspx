<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Seller/SellerMaster.Master" AutoEventWireup="true" CodeBehind="bill.aspx.cs" Inherits="Online_Book_Shop.Pages.Seller.bill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <!--
    <div class="container-fluid">
        <div class="col-md-12">
            <h3 class="text-center"><b>Bill History</b></h3>
        </div>

        <asp:GridView ID="Bill_List" runat="server" class="table table-bordered" CellPadding="4" ForeColor="#333333" GridLines="None">
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

    -->

    <div class="container-fluid">
        <div class="row">
            <div class="col">
                <h3 class="text-center"><b>Manage Bill</b></h3>
            </div>
        </div>

        <div class="row">
            <div class="col-md-4" style="margin-top: 3px;">
                <div class="mt-3">
                    <label for="bill_date" class="form-label text-dark">Bill Date</label>
                    <input type="text" placeholder="Bill Date" name="bill_date" class="form-control" runat="server" id="Bill_Date" disabled/>
                </div>

                <div class="mt-3">
                    <label for="bill_seller" class="form-label text-dark">Bill Seller</label>
                    <input type="text" placeholder="Bill Seller" name="bill_seller" class="form-control" runat="server" id="Bill_Seller" disabled/>
                </div>

                <div class="mt-3">
                    <label for="bill_amount" class="form-label text-dark">Bill Amount</label>
                    <input type="number" placeholder="Bill Amount" name="bill_amount" class="form-control" runat="server" id="Bill_Amount" disabled/>
                </div>

                <br />

                <asp:Label runat="server" ID="Success_Msg" class="text-success"></asp:Label>

                <asp:Label runat="server" ID="Error_Msg" class="text-danger"></asp:Label>

                <div class="row mt-4">
                    <div class="col d-grid"><asp:Button Text="Delete" ID="DeleteBtn" runat="server" class="btn-danger btn-block btn" OnClick="DeleteBtn_Click"/></div>
                </div>

            </div>

            <div class="col-md-8" style="margin-top:15px;">

                <h4 class="text-center">Bill List</h4>

                <asp:GridView ID="Bill_History_List" runat="server" class="table table-bordered" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="true" OnSelectedIndexChanged="Bill_History_List_SelectedIndexChanged">
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
