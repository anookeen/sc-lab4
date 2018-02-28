<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
  .gridview{
    
   
   padding:2px;
   margin:2% auto;
   
   
}
        div {
        color:black !important;}
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1"  CssClass="gridview" BackColor="#99CCFF" BorderColor="#3399FF" ForeColor="Black" BorderWidth="4px"  >
            						
<pagerstyle cssclass="gridview">

</pagerstyle>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:user_infoConnectionString %>" ProviderName="<%$ ConnectionStrings:user_infoConnectionString.ProviderName %>" SelectCommand="SELECT * FROM userdata"></asp:SqlDataSource>
    
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LogOut" />
        <br />
    
    </div>
    </form>
</body>
</html>
