using iTextSharp.text.html.simpleparser;
using Online_Book_Shop.Pages.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using iText.Layout;
using iText.Kernel.Pdf;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using iText.Layout.Element;

namespace Online_Book_Shop.Pages.Seller
{
    public partial class Selling : System.Web.UI.Page
    {
        Models.Functions con;
        int Seller = LoginPage.User;
        string Seller_Name = LoginPage.User_Name;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Models.Functions();
            if (!IsPostBack)
            {
                Show_Books();
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[5]{
                    new DataColumn("ID"),
                    new DataColumn("Book"),
                    new DataColumn("Price"),
                    new DataColumn("Quantity"),
                    new DataColumn("Total"),
                }
                );

                ViewState["Bill"] = dt;
                this.BindGrid();
            }

            Success_Msg.Text = "";
            Error_Msg.Text = "";
        }

        protected void BindGrid()
        {
            Bill_List.DataSource = ViewState["Bill"];
            Bill_List.DataBind();
        }

        private void Show_Books()
        {
            string Query = "SELECT Book_Id as Id, Book_Name as Name, Author_Name as Author, Category_Name as Category, Book_Quantity as Stock, Book_Price as Price FROM Book_Info,Author_Info,Category_Info WHERE Book_Info.Book_Author = Author_Info.Author_Id AND Book_Info.Book_Category = Category_Info.Category_Id";
            Books_List.DataSource = con.GetData(Query);
            Books_List.DataBind();
        }

        int key = 0;
        int Stock = 0;
        protected void Authors_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book_Name.Value = Books_List.SelectedRow.Cells[2].Text;
            Stock = Convert.ToInt32(Books_List.SelectedRow.Cells[5].Text);
            Book_Price.Value = Books_List.SelectedRow.Cells[6].Text;

            if (Book_Name.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Books_List.SelectedRow.Cells[1].Text);
            }
        }

        private void Update_Stock()
        {
            int New_Quantity;
            New_Quantity = Convert.ToInt32(Books_List.SelectedRow.Cells[5].Text) - Convert.ToInt32(Book_Quantity.Value);

            if(New_Quantity >= 0)
            {
                string Query = "UPDATE Book_Info SET Book_Quantity = {0} WHERE Book_Id = {1}";
                Query = string.Format(Query, New_Quantity, Books_List.SelectedRow.Cells[1].Text);

                con.SetData(Query);

                Show_Books();
            }
            else
            {
                Error_Msg.Text = "The Book is Out of Stock";
            }
        }

        protected void Add_To_Bill_Btn_Click(object sender, EventArgs e)
        {
            if ((Book_Name.Value != "" && Book_Price.Value != "" && Book_Quantity.Value != "") || Book_Date.Value != "")
            {
                int New_Quantity;
                New_Quantity = Convert.ToInt32(Books_List.SelectedRow.Cells[5].Text) - Convert.ToInt32(Book_Quantity.Value);

                if(New_Quantity >= 0)
                {
                    try
                    {
                        int total = Convert.ToInt32(Book_Quantity.Value) * Convert.ToInt32(Book_Price.Value);

                        DataTable dt = (DataTable)ViewState["Bill"];
                        dt.Rows.Add(
                            Bill_List.Rows.Count + 1,
                            Book_Name.Value.Trim(),
                            Book_Price.Value.Trim(),
                            Book_Quantity.Value.Trim(),
                            total
                        );

                        ViewState["Bill"] = dt;
                        this.BindGrid();

                        try
                        {
                            string date = Book_Date.Value;
                            string amount = Book_Price.Value;

                            string Query = "INSERT INTO Bill_Info VALUES('{0}', {1}, {2})";
                            Query = string.Format(Query, DateTime.Now, Seller, amount);

                            con.SetData(Query);

                            Success_Msg.Text = "Bill Added Successfully.";
                            
                            Update_Stock();
                        }
                        catch (Exception Ex)
                        {
                            Error_Msg.Text = Ex.Message;
                        }

                        Book_Name.Value = "";
                        Book_Price.Value = "";
                        Book_Quantity.Value = "";
                    }
                    catch (Exception Ex)
                    {
                        Error_Msg.Text = Ex.Message;
                    }
                }
                else
                {
                    Error_Msg.Text = "Not sufficient stock of book available";
                }    
            }
            else
            {
                Error_Msg.Text = "Something went wrong!";
            }

        }

        protected void Print_Bill_Click(object sender, EventArgs e)
        {
            
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
     
        }
    }
}