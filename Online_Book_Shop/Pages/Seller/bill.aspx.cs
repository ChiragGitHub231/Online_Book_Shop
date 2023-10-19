using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Book_Shop.Pages.Seller
{
    public partial class bill : System.Web.UI.Page
    {
        Models.Functions con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Models.Functions();
            Show_Bills();

            Success_Msg.Text = "";
            Error_Msg.Text = "";
        }

        private void Show_Bills()
        {
            string Query = "SELECT Bill_Id as Id, Seller_Name as Name, Bill_Date as Date, Bill_Amount as Amount FROM Bill_Info, Seller_Info WHERE Bill_Info.Bill_Seller=Seller_Info.Seller_Id";
            Bill_History_List.DataSource = con.GetData(Query);
            Bill_History_List.DataBind();
        }

        int key = 0;
        protected void Bill_History_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bill_Seller.Value = Bill_History_List.SelectedRow.Cells[2].Text;
            Bill_Date.Value = Bill_History_List.SelectedRow.Cells[3].Text;
            Bill_Amount.Value = Bill_History_List.SelectedRow.Cells[4].Text;

            if (Bill_Seller.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Bill_History_List.SelectedRow.Cells[1].Text);
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Bill_Date.Value != "" && Bill_Seller.Value != "" && Bill_Amount.Value != "")
                {
                    
                    string Query = "DELETE FROM Bill_Info WHERE Bill_Id = {0}";
                    Query = string.Format(Query, Bill_History_List.SelectedRow.Cells[1].Text);

                    con.SetData(Query);

                    Show_Bills();

                    Success_Msg.Text = "Bill Deleted Successfully";

                    Bill_Date.Value = "";
                    Bill_Amount.Value = "";
                    Bill_Seller.Value = "";
                }
                else
                {
                    Error_Msg.Text = "Something went wrong!";
                }
            }
            catch (Exception ex)
            {
                Error_Msg.Text = ex.Message;
            }
        }
    }
}