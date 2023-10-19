using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Book_Shop.Pages
{
    public partial class LoginPage : System.Web.UI.Page
    {
        Models.Functions con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Models.Functions();
        }

        public static string User_Name = "";
        public static int User;

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            if(Username_Text.Value == "" || Password_Text.Value == "")
            {
                if (Username_Text.Value == "")
                {
                    Username_Error.Text = "Username Required";
                }
                else
                {
                    Username_Error.Text = "";
                }

                if (Password_Text.Value == "")
                {
                    Password_Error.Text = "Password Required";
                }
                else
                {
                    Password_Error.Text = "";
                }
            }
            else if (Username_Text.Value == "admin@gmail.com" && Password_Text.Value == "admin123")
            {
                Response.Redirect("Admin/Books.aspx");
            }
            else
            {
                string Query = "SELECT * FROM Seller_Info WHERE Seller_Email_Id = '{0}' and Seller_Password = '{1}'";
                Query = string.Format(Query, Username_Text.Value, Password_Text.Value);
                DataTable dt = con.GetData(Query);

                if (dt.Rows.Count == 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertMessage", "alert('Invalid Username or Password')", true);
                    Response.Redirect("LoginPage.aspx");
                    Other_Error.Text = "Invalid Username or Password";
                }
                else
                {
                    User_Name = Username_Text.Value;
                    User = Convert.ToInt32(dt.Rows[0][0].ToString());
                    Response.Redirect("Seller/Selling.aspx");
                }
            }
        }
    }
}