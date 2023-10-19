<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Seller/SellerMaster.Master" AutoEventWireup="true" CodeBehind="Selling.aspx.cs" EnableEventValidation="false" Inherits="Online_Book_Shop.Pages.Seller.Selling" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <script type="text/javascript">
       function PrintBill() {
           var PGrid = document.getElementById('<%=Bill_List.ClientID%>');

           PGrid.border = 0;

           var PWin = window.open('', 'left=100, top=100, width=1024, height=768, tollbar=0, scrollbar=1, status=0, resizable=1');

           PWin.document.write(PGrid.outerHTML);

           PWin.document.close();

           PWin.focus();

           PWin.print();

           PWin.close();
       }
   </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">

    <div class="container-fluid">
        <div class="row">

        </div>

        <div class="row">

            <div class="col-md-6">

                <h3 class="text-center">Book Details</h3>

                <div class="row">

                    <div class="col">
                        <div class="mt-3">
                            <label for="book_name">Enter Book Name</label>
                            <input type="text" placeholder="Book Name" name="book_name" class="form-control" runat="server" id="Book_Name"/>
                        </div>
                    </div>

                    <div class="col">
                        <div class="mt-3">
                            <label for="book_price">Enter Book Price</label>
                            <input type="text" placeholder="Book Price" name="book_price" class="form-control" runat="server" id="Book_Price"/>
                        </div>
                    </div>

                </div>

                <div class="row">

                    <div class="col">
                        <div class="mt-3">
                            <label for="book_quantity">Enter Book Quantity</label>
                            <input type="text" placeholder="Book Quantity" name="book_quantity" class="form-control" runat="server" id="Book_Quantity"/>
                        </div>
                    </div>

                    <div class="col">
                        <div class="mt-3">
                            <label for="book_date">Enter Bill Date</label>
                            <input type="date" placeholder="Bill Date" name="book_date" class="form-control" runat="server" id="Book_Date"/>
                        </div>
                    </div>

                </div>

                <asp:Label runat="server" ID="Success_Msg" class="text-success"></asp:Label>

                <asp:Label runat="server" ID="Error_Msg" class="text-danger"></asp:Label>

                <div class="row mt-3 mb-3">
                    <div class="col d-grid">
                        <asp:Button Text="Add To Bill" ID="Add_To_Bill_Btn" runat="server" class="btn-warning btn-block btn" OnClick="Add_To_Bill_Btn_Click"/>
                    </div>
                </div>

                <div class="col mt-5">

                </div>

                <h4 class="text-center">Book List</h4>

                <div class="row mt-2">
                
                <div class="col">
                    <asp:GridView ID="Books_List" runat="server" class="table table-bordered" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="true" OnSelectedIndexChanged="Authors_List_SelectedIndexChanged">
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

            <div class="col-md-6">
                <h4 class="text-center">Client's Bill</h4>
                <div class="col">
                    
                    <div id="Print_To_Bill" runat="server">
                        <asp:GridView ID="Bill_List" runat="server" class="table table-bordered" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="true" OnSelectedIndexChanged="Authors_List_SelectedIndexChanged">
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#2461BF" />
                            <HeaderStyle BackColor="SlateBlue" Font-Bold="false" ForeColor="White" />
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

                <div class="col d-grid">
                    <asp:Button Text="Print Bill" ID="Print_Bill" OnClientClick="PrintBill()" runat="server" class="btn-warning btn-block btn" OnClick="Print_Bill_Click"/>
                </div>
            </div>

       </div>
    </div>

</asp:Content>
