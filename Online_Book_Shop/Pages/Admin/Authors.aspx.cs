using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Book_Shop.Pages.Admin
{
    public partial class Author : System.Web.UI.Page
    {
        Models.Functions con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Models.Functions();
            Show_Authors();

            Name_Error.Text = "";
            Gender_Error.Text = "";
            Country_Error.Text = "";

            Success_Msg.Text = "";
        }

        private void Show_Authors()
        {
            string Query = "SELECT Author_Id as Id, Author_Name as Name, Author_Gender as Gender, Author_Country as Country FROM Author_Info";
            Authors_List.DataSource = con.GetData(Query);
            Authors_List.DataBind();
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(Author_Name.Value != "" && Author_Gender.SelectedIndex != -1 && Author_Country.SelectedIndex != -1)
                {
                    string Name = Author_Name.Value;
                    string Gender = Author_Gender.SelectedItem.ToString();
                    string Country = Author_Country.SelectedItem.ToString();

                    string Query = "INSERT INTO Author_Info VALUES('{0}', '{1}', '{2}')";
                    Query = string.Format(Query, Name, Gender, Country);

                    con.SetData(Query);

                    Show_Authors();

                    Success_Msg.Text = "Author Inserted Successfully";

                    Author_Name.Value = "";
                    Author_Gender.SelectedIndex = -1;
                    Author_Country.SelectedIndex = -1;
                }
                else
                {
                    if(Author_Name.Value == "")
                    {
                        Name_Error.Text = "Name Required";
                    }
                    else
                    {
                        Name_Error.Text = "";
                    }

                    if (Author_Gender.SelectedIndex == -1)
                    {
                        Gender_Error.Text = "Gender Required";
                    }
                    else
                    {
                        Gender_Error.Text = "";
                    }

                    if (Author_Country.SelectedIndex == -1)
                    {
                        Country_Error.Text = "Country Required";
                    }
                    else
                    {
                        Country_Error.Text = "";
                    }
                }
            }
            catch(Exception ex)
            {
                Other_Error.Text = ex.Message;
            }
        }

        int key = 0;
        protected void Authors_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            Author_Name.Value = Authors_List.SelectedRow.Cells[2].Text;
            Author_Gender.SelectedItem.Text = Authors_List.SelectedRow.Cells[3].Text;
            Author_Country.SelectedItem.Text = Authors_List.SelectedRow.Cells[4].Text;

            if(Author_Name.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Authors_List.SelectedRow.Cells[1].Text);
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Author_Name.Value != "" && Author_Gender.SelectedIndex != -1 && Author_Country.SelectedIndex != -1)
                {
                    string Name = Author_Name.Value;
                    string Gender = Author_Gender.SelectedItem.ToString();
                    string Country = Author_Country.SelectedItem.ToString();

                    string Query = "UPDATE Author_Info SET Author_Name = '{0}', Author_Gender = '{1}', Author_Country = '{2}' WHERE Author_Id = {3}";
                    Query = string.Format(Query, Name, Gender, Country, Authors_List.SelectedRow.Cells[1].Text);

                    con.SetData(Query);

                    Show_Authors();

                    Success_Msg.Text = "Author Updated Successfully";

                    Author_Name.Value = "";
                    Author_Gender.SelectedIndex = -1;
                    Author_Country.SelectedIndex = -1;
                }
                else
                {
                    if (Author_Name.Value == "")
                    {
                        Name_Error.Text = "Name Required";
                    }
                    else
                    {
                        Name_Error.Text = "";
                    }

                    if (Author_Gender.SelectedIndex == -1)
                    {
                        Gender_Error.Text = "Gender Required";
                    }
                    else
                    {
                        Gender_Error.Text = "";
                    }

                    if (Author_Country.SelectedIndex == -1)
                    {
                        Country_Error.Text = "Country Required";
                    }
                    else
                    {
                        Country_Error.Text = "";
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
                if (Author_Name.Value != "" && Author_Gender.SelectedIndex != -1 && Author_Country.SelectedIndex != -1)
                {
                    string Name = Author_Name.Value;
                    string Gender = Author_Gender.SelectedItem.ToString();
                    string Country = Author_Country.SelectedItem.ToString();

                    string Query = "DELETE FROM Author_Info WHERE Author_Id = {0}";
                    Query = string.Format(Query, Authors_List.SelectedRow.Cells[1].Text);

                    con.SetData(Query);

                    Show_Authors();

                    Success_Msg.Text = "Author Deleted Successfully";

                    Author_Name.Value = "";
                    Author_Gender.SelectedIndex = -1;
                    Author_Country.SelectedIndex = -1;
                }
                else
                {
                    if (Author_Name.Value == "")
                    {
                        Name_Error.Text = "Name Required";
                    }
                    else
                    {
                        Name_Error.Text = "";
                    }

                    if (Author_Gender.SelectedIndex == -1)
                    {
                        Gender_Error.Text = "Gender Required";
                    }
                    else
                    {
                        Gender_Error.Text = "";
                    }

                    if (Author_Country.SelectedIndex == -1)
                    {
                        Country_Error.Text = "Country Required";
                    }
                    else
                    {
                        Country_Error.Text = "";
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