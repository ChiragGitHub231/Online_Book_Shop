using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Book_Shop.Pages.Admin
{
    public partial class Seller : System.Web.UI.Page
    {
        Models.Functions con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Models.Functions();
            Show_Sellers();

            Name_Error.Text = "";
            Email_Id_Error.Text = "";
            Contact_No_Error.Text = "";
            Password_Error.Text = "";

            Success_Msg.Text = "";
        }

        private void Show_Sellers()
        {
            string Query = "SELECT Seller_Id as Id, Seller_Name as Name, Seller_Email_Id as Email_Id, Seller_Contact_No as Contact_No, Seller_Password as Password FROM Seller_Info";
            Sellers_List.DataSource = con.GetData(Query);
            Sellers_List.DataBind();
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Seller_Name.Value != "" && Seller_Email_Id.Value != "" && Seller_Contact_No.Value != "" && Seller_Password.Value != "")
                {
                    string Name = Seller_Name.Value;
                    string Email_Id = Seller_Email_Id.Value;
                    string Contact_No = Seller_Contact_No.Value;
                    string Address = Seller_Password.Value;

                    string Query = "INSERT INTO Seller_Info VALUES('{0}', '{1}', '{2}', '{3}')";
                    Query = string.Format(Query, Name, Email_Id, Contact_No, Address);

                    con.SetData(Query);

                    Show_Sellers();

                    Success_Msg.Text = "Seller Inserted Successfully";

                    Seller_Name.Value = "";
                    Seller_Email_Id.Value = "";
                    Seller_Contact_No.Value = "";
                    Seller_Password.Value = "";
                }
                else
                {
                    if (Seller_Name.Value == "")
                    {
                        Name_Error.Text = "Name Required";
                    }
                    else
                    {
                        Name_Error.Text = "";
                    }

                    if (Seller_Email_Id.Value == "")
                    {
                        Email_Id_Error.Text = "Email Id Required";
                    }
                    else
                    {
                        Email_Id_Error.Text = "";
                    }

                    if (Seller_Contact_No.Value == "")
                    {
                        Contact_No_Error.Text = "Contact No Required";
                    }
                    else
                    {
                        Contact_No_Error.Text = "";
                    }

                    if (Seller_Password.Value == "")
                    {
                        Password_Error.Text = "Password Required";
                    }
                    else
                    {
                        Password_Error.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                Other_Error.Text = ex.Message;
            }
        }

        int key = 0;
        protected void Sellers_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            Seller_Name.Value = Sellers_List.SelectedRow.Cells[2].Text;
            Seller_Email_Id.Value = Sellers_List.SelectedRow.Cells[3].Text;
            Seller_Contact_No.Value = Sellers_List.SelectedRow.Cells[4].Text;
            Seller_Password.Value = Sellers_List.SelectedRow.Cells[5].Text;

            if (Seller_Name.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Sellers_List.SelectedRow.Cells[1].Text);
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Seller_Name.Value != "" && Seller_Email_Id.Value != "" && Seller_Contact_No.Value != "" && Seller_Password.Value != "")
                {
                    string Name = Seller_Name.Value;
                    string Email_Id = Seller_Email_Id.Value;
                    string Contact_No = Seller_Contact_No.Value;
                    string Address = Seller_Password.Value;

                    string Query = "UPDATE Seller_Info SET Seller_Name = '{0}', Seller_Email_Id = '{1}', Seller_Contact_No = '{2}', Seller_Address = '{3}' WHERE Seller_Id = {4}";
                    Query = string.Format(Query, Name, Email_Id, Contact_No, Address, Sellers_List.SelectedRow.Cells[1].Text);

                    con.SetData(Query);

                    Show_Sellers();

                    Success_Msg.Text = "Seller Updated Successfully";

                    Seller_Name.Value = "";
                    Seller_Email_Id.Value = "";
                    Seller_Contact_No.Value = "";
                    Seller_Password.Value = "";
                }
                else
                {
                    if (Seller_Name.Value == "")
                    {
                        Name_Error.Text = "Name Required";
                    }
                    else
                    {
                        Name_Error.Text = "";
                    }

                    if (Seller_Email_Id.Value == "")
                    {
                        Email_Id_Error.Text = "Email Id Required";
                    }
                    else
                    {
                        Email_Id_Error.Text = "";
                    }

                    if (Seller_Contact_No.Value == "")
                    {
                        Contact_No_Error.Text = "Contact No Required";
                    }
                    else
                    {
                        Contact_No_Error.Text = "";
                    }

                    if (Seller_Password.Value == "")
                    {
                        Password_Error.Text = "Password Required";
                    }
                    else
                    {
                        Password_Error.Text = "";
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
                if (Seller_Name.Value != "" && Seller_Email_Id.Value != "" && Seller_Contact_No.Value != "" && Seller_Password.Value != "")
                {
                    string Name = Seller_Name.Value;
                    string Email_Id = Seller_Email_Id.Value;
                    string Contact_No = Seller_Contact_No.Value;
                    string Address = Seller_Password.Value;

                    string Query = "DELETE FROM Seller_Info WHERE Seller_Id = {0}";
                    Query = string.Format(Query, Sellers_List.SelectedRow.Cells[1].Text);

                    con.SetData(Query);

                    Show_Sellers();

                    Success_Msg.Text = "Seller Deleted Successfully";

                    Seller_Name.Value = "";
                    Seller_Email_Id.Value = "";
                    Seller_Contact_No.Value = "";
                    Seller_Password.Value = "";
                }
                else
                {
                    if (Seller_Name.Value == "")
                    {
                        Name_Error.Text = "Name Required";
                    }
                    else
                    {
                        Name_Error.Text = "";
                    }

                    if (Seller_Email_Id.Value == "")
                    {
                        Email_Id_Error.Text = "Email Id Required";
                    }
                    else
                    {
                        Email_Id_Error.Text = "";
                    }

                    if (Seller_Contact_No.Value == "")
                    {
                        Contact_No_Error.Text = "Contact No Required";
                    }
                    else
                    {
                        Contact_No_Error.Text = "";
                    }

                    if (Seller_Password.Value == "")
                    {
                        Password_Error.Text = "Password Required";
                    }
                    else
                    {
                        Password_Error.Text = "";
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