using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Book_Shop.Pages.Admin
{
    public partial class Categories : System.Web.UI.Page
    {
        Models.Functions con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Models.Functions();
            Show_Categories();

            Name_Error.Text = "";
            Description_Error.Text = "";

            Success_Msg.Text = "";
        }

        private void Show_Categories()
        {
            string Query = "SELECT Category_Id as Id, Category_Name as Name, Category_Description as Description FROM Category_Info";
            Categories_List.DataSource = con.GetData(Query);
            Categories_List.DataBind();
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Category_Name.Value != "" && Category_Description.Value != "")
                {
                    string Name = Category_Name.Value;
                    string Description = Category_Description.Value;

                    string Query = "INSERT INTO Category_Info VALUES('{0}', '{1}')";
                    Query = string.Format(Query, Name, Description);

                    con.SetData(Query);

                    Show_Categories();

                    Success_Msg.Text = "Category Inserted Successfully";

                    Category_Name.Value = "";
                    Category_Description.Value = "";
                }
                else
                {
                    if (Category_Name.Value == "")
                    {
                        Name_Error.Text = "Name Required";
                    }
                    else
                    {
                        Name_Error.Text = "";
                    }

                    if (Category_Description.Value == "")
                    {
                        Description_Error.Text = "Description Required";
                    }
                    else
                    {
                        Description_Error.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                Other_Error.Text = ex.Message;
            }
        }

        int key = 0;
        protected void Categories_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category_Name.Value = Categories_List.SelectedRow.Cells[2].Text;
            Category_Description.Value = Categories_List.SelectedRow.Cells[3].Text;

            if (Category_Name.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Categories_List.SelectedRow.Cells[1].Text);
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Category_Name.Value != "" && Category_Description.Value != "")
                {
                    string Name = Category_Name.Value;
                    string Description = Category_Description.Value;

                    string Query = "UPDATE Category_Info SET Category_Name = '{0}', Category_Description = '{1}' WHERE Category_Id = {2}";
                    Query = string.Format(Query, Name, Description, Categories_List.SelectedRow.Cells[1].Text);

                    con.SetData(Query);

                    Show_Categories();

                    Success_Msg.Text = "Category Updated Successfully";

                    Category_Name.Value = "";
                    Category_Description.Value = "";
                }
                else
                {
                    if (Category_Name.Value == "")
                    {
                        Name_Error.Text = "Name Required";
                    }
                    else
                    {
                        Name_Error.Text = "";
                    }

                    if (Category_Description.Value == "")
                    {
                        Description_Error.Text = "Description Required";
                    }
                    else
                    {
                        Description_Error.Text = "";
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
                if (Category_Name.Value != "" && Category_Description.Value != "")
                {
                    string Name = Category_Name.Value;
                    string Description = Category_Description.Value;

                    string Query = "DELETE FROM Category_Info WHERE Category_Id = {0}";
                    Query = string.Format(Query, Categories_List.SelectedRow.Cells[1].Text);

                    con.SetData(Query);

                    Show_Categories();

                    Success_Msg.Text = "Category Deleted Successfully";

                    Category_Name.Value = "";
                    Category_Description.Value = "";
                }
                else
                {
                    if (Category_Name.Value == "")
                    {
                        Name_Error.Text = "Name Required";
                    }
                    else
                    {
                        Name_Error.Text = "";
                    }

                    if (Category_Description.Value == "")
                    {
                        Description_Error.Text = "Description Required";
                    }
                    else
                    {
                        Description_Error.Text = "";
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