using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Online_Book_Shop.Pages.Admin
{
    public partial class Books : System.Web.UI.Page
    {
        Models.Functions con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Models.Functions();
            if (!IsPostBack)
            {
                Show_Books();
                Get_Categories();
                Get_Authors();
            }

            Name_Error.Text = "";
            Author_Error.Text = "";
            Category_Error.Text = "";
            Price_Error.Text = "";
            Quantity_Error.Text = "";

            Success_Msg.Text = "";
        }
        private void Show_Books()
        {
            string Query = "SELECT Book_Id as Id, Book_Name as Name, Author_Name as Author, Category_Name as Category, Book_Quantity as Stock, Book_Price as Price FROM Book_Info,Author_Info,Category_Info WHERE Book_Info.Book_Author = Author_Info.Author_Id AND Book_Info.Book_Category = Category_Info.Category_Id";
            Books_List.DataSource = con.GetData(Query);
            Books_List.DataBind();
        }

        private void Get_Categories()
        {
            string Query = "SELECT * FROM Category_Info";
            Book_Category.DataTextField = con.GetData(Query).Columns["Category_Name"].ToString();
            Book_Category.DataValueField = con.GetData(Query).Columns["Category_Id"].ToString();
            Book_Category.DataSource = con.GetData(Query);
            Book_Category.DataBind();
        }

        private void Get_Authors()
        {
            string Query = "SELECT * FROM Author_Info";
            Book_Author.DataTextField = con.GetData(Query).Columns["Author_Name"].ToString();
            Book_Author.DataValueField = con.GetData(Query).Columns["Author_Id"].ToString();
            Book_Author.DataSource = con.GetData(Query);
            Book_Author.DataBind();
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Book_Name.Value != "" && Book_Author.SelectedIndex != -1 && Book_Category.SelectedIndex != -1 && Book_Price.Value != "" && Book_Quantity.Value != "")
                {
                    string Name = Book_Name.Value;
                    string Author = Book_Author.SelectedValue.ToString();
                    string Category = Book_Category.SelectedValue.ToString();
                    int Quantity = Convert.ToInt32(Book_Quantity.Value);
                    int Price = Convert.ToInt32(Book_Price.Value);

                    string Query = "INSERT INTO Book_Info VALUES('{0}', {1}, {2}, {3}, {4})";
                    Query = string.Format(Query, Name, Author, Category, Quantity, Price);

                    con.SetData(Query);

                    Show_Books();

                    Success_Msg.Text = "Book Inserted Successfully";

                    Book_Name.Value = "";
                    Book_Author.SelectedIndex = -1;
                    Book_Category.SelectedIndex = -1;
                    Book_Quantity.Value = "";
                    Book_Price.Value = "";
                }
                else
                {
                    if (Book_Name.Value == "")
                    {
                        Name_Error.Text = "Name Required";
                    }
                    else
                    {
                        Name_Error.Text = "";
                    }

                    if (Book_Author.SelectedIndex == -1)
                    {
                        Author_Error.Text = "Auhtor Required";
                    }
                    else
                    {
                        Author_Error.Text = "";
                    }

                    if (Book_Category.SelectedIndex == -1)
                    {
                        Category_Error.Text = "Category Required";
                    }
                    else
                    {
                        Category_Error.Text = "";
                    }

                    if (Book_Quantity.Value == "")
                    {
                        Quantity_Error.Text = "Quantity Required";
                    }
                    else
                    {
                        Quantity_Error.Text = "";
                    }

                    if (Book_Price.Value == "")
                    {
                        Price_Error.Text = "Price Required";
                    }
                    else
                    {
                        Price_Error.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                Other_Error.Text = ex.Message;
            }
        }

        int key = 0;
        protected void Books_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book_Name.Value = Books_List.SelectedRow.Cells[2].Text;
            Book_Author.SelectedItem.Text = Books_List.SelectedRow.Cells[3].Text;
            Book_Category.SelectedItem.Text = Books_List.SelectedRow.Cells[4].Text;
            Book_Quantity.Value = Books_List.SelectedRow.Cells[5].Text;
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

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Book_Name.Value != "" && Book_Author.SelectedIndex != -1 && Book_Category.SelectedIndex != -1 && Book_Price.Value != "" && Book_Quantity.Value != "")
                {
                    string Name = Book_Name.Value;
                    string Author = Book_Author.SelectedValue.ToString();
                    string Category = Book_Category.SelectedValue.ToString();
                    int Quantity = Convert.ToInt32(Book_Quantity.Value);
                    int Price = Convert.ToInt32(Book_Price.Value);

                    string Query = "UPDATE Book_Info SET Book_Name = '{0}', Book_Author = {1}, Book_Category = {2}, Book_Quantity = {3}, Book_Price = {4} WHERE Book_Id = {5}";
                    Query = string.Format(Query, Name, Author, Category, Quantity, Price, Books_List.SelectedRow.Cells[1].Text);

                    con.SetData(Query);

                    Show_Books();

                    Success_Msg.Text = "Book Updated Successfully";

                    Book_Name.Value = "";
                    Book_Author.SelectedIndex = -1;
                    Book_Category.SelectedIndex = -1;
                    Book_Quantity.Value = "";
                    Book_Price.Value = "";
                }
                else
                {
                    if (Book_Name.Value == "")
                    {
                        Name_Error.Text = "Name Required";
                    }
                    else
                    {
                        Name_Error.Text = "";
                    }

                    if (Book_Author.SelectedIndex == -1)
                    {
                        Author_Error.Text = "Auhtor Required";
                    }
                    else
                    {
                        Author_Error.Text = "";
                    }

                    if (Book_Category.SelectedIndex == -1)
                    {
                        Category_Error.Text = "Category Required";
                    }
                    else
                    {
                        Category_Error.Text = "";
                    }

                    if (Book_Quantity.Value == "")
                    {
                        Quantity_Error.Text = "Quantity Required";
                    }
                    else
                    {
                        Quantity_Error.Text = "";
                    }

                    if (Book_Price.Value == "")
                    {
                        Price_Error.Text = "Price Required";
                    }
                    else
                    {
                        Price_Error.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                Other_Error.Text = ex.Message;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Book_Name.Value != "" && Book_Author.SelectedIndex != -1 && Book_Category.SelectedIndex != -1 && Book_Price.Value != "" && Book_Quantity.Value != "")
                {
                    string Name = Book_Name.Value;
                    string Author = Book_Author.SelectedValue.ToString();
                    string Category = Book_Category.SelectedValue.ToString();
                    int Quantity = Convert.ToInt32(Book_Quantity.Value);
                    int Price = Convert.ToInt32(Book_Price.Value);

                    string Query = "DELETE FROM Book_Info WHERE Book_Id = {0}";
                    Query = string.Format(Query, Books_List.SelectedRow.Cells[1].Text);

                    con.SetData(Query);

                    Show_Books();

                    Success_Msg.Text = "Book Deleted Successfully";

                    Book_Name.Value = "";
                    Book_Author.SelectedIndex = -1;
                    Book_Category.SelectedIndex = -1;
                    Book_Quantity.Value = "";
                    Book_Price.Value = "";
                }
                else
                {
                    if (Book_Name.Value == "")
                    {
                        Name_Error.Text = "Name Required";
                    }
                    else
                    {
                        Name_Error.Text = "";
                    }

                    if (Book_Author.SelectedIndex == -1)
                    {
                        Author_Error.Text = "Auhtor Required";
                    }
                    else
                    {
                        Author_Error.Text = "";
                    }

                    if (Book_Category.SelectedIndex == -1)
                    {
                        Category_Error.Text = "Category Required";
                    }
                    else
                    {
                        Category_Error.Text = "";
                    }

                    if (Book_Quantity.Value == "")
                    {
                        Quantity_Error.Text = "Quantity Required";
                    }
                    else
                    {
                        Quantity_Error.Text = "";
                    }

                    if (Book_Price.Value == "")
                    {
                        Price_Error.Text = "Price Required";
                    }
                    else
                    {
                        Price_Error.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                Other_Error.Text = ex.Message;
            }
        }
    }
}