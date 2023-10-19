<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Online_Book_Shop.Pages.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link rel="stylesheet" href="../Libraries/css/bootstrap.min.css" />

    <meta name="viewport" content="width=device-width, initial-scale=1" />

<style>
body {font-family: Arial, Helvetica, sans-serif;}

input[type=email], input[type=password] {
  width: 30%;
  padding: 12px 10px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  box-sizing: border-box;
}

#LoginBtn {
  background-color: #04AA6D;
  color: white;
  padding: 14px 20px;
  margin: 8px 0;
  border: none;
  cursor: pointer;
  width: 43%;
  margin-top: 20px;
}

label{
    margin-right:15px;
}

#LoginBtn:hover {
  opacity: 0.8;
}

.title-text {
  text-align: center;
  margin: 24px 0 12px 0;
}

.container {
  padding: 16px;
  text-align: center;
}

span.user_password {
  float: right;
  padding-top: 16px;
}

p{
    margin-top: 7px;
}

#Password_Error, #Username_Error{
    margin-right: 50px;
}


</style>

</head>

<body>
    <div class="container" style="margin-top: 105px">

        <div class="title-text" style="padding-bottom:7px">
            <h1>Login Form</h1>
        </div>

        <form id="form1" runat="server">
            
            <label for="user_name">Enter Username</label>
            <input type="email" placeholder="Email Id" name="user_name" class="form-control" runat="server" id="Username_Text"/>

            <br />

            <asp:Label runat="server" ID="Username_Error" class="text-danger"></asp:Label>

            <br />

            <label for="user_password">Enter Password</label>
            <input type="password" placeholder="Password" name="user_password" class="form-control" runat="server" id="Password_Text"/>

            <br />

            <asp:Label runat="server" ID="Password_Error" class="text-danger"></asp:Label>

            <br />

            <asp:Label runat="server" ID="Other_Error" class="text-danger"></asp:Label>

            <asp:Button Text="Login" runat="server" ID="LoginBtn" OnClick="LoginBtn_Click"/>

        </form>
   
    </div>
    
</body>
</html>