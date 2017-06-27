<%@ Page Language="C#" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="view" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Your Title</title>
    <link rel="stylesheet" type="text/css" href="Assets/css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="Assets/css/style.css">
    <link rel="stylesheet" type="text/css" href="Assets/css/w3.css">
    <link href="Assets/css/landing-page.css" rel="stylesheet">
    <link href="Assets/css/jquery-ui.css" rel="stylesheet">
    
    <script src="Assets/Scripts/jquery.min.js"></script>
    <script src="Assets/js/bootstrap.js"></script>
    <script src="Assets/js/bootstrap.min.js"></script>

</head>
<body>
	<form id="form1" runat="server">
			<div class="w3-container" style="margin-top: 5%">
    		<h2>View Display</h2>    
  <asp:GridView ID="grid1" runat="server" AutoGenerateColumns="False" CellPadding="14" class="w3-table w3-padding"> 
  	<AlternatingRowStyle BackColor="White" />  
     <columns>  
         <asp:TemplateField HeaderText="Coloumn_in_ur_table">  
             <ItemTemplate>  
                 <asp:Label ID="Coloumn_in_ur_table" runat="server" Text='<%#Bind("Coloumn_in_ur_table") %>'></asp:Label>
             </ItemTemplate>  
         </asp:TemplateField>
         <asp:TemplateField HeaderText="Coloumn_in_ur_table">  
             <ItemTemplate>  
                 <asp:Label ID="Coloumn_in_ur_table" runat="server" Text='<%#Bind("Coloumn_in_ur_table") %>'></asp:Label>
             </ItemTemplate>  
         </asp:TemplateField>  
         <asp:TemplateField HeaderText="Coloumn_in_ur_table">  
             <ItemTemplate>  
                 <asp:Label ID="Coloumn_in_ur_table" runat="server" Text='<%#Bind("Coloumn_in_ur_table") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>
         <asp:TemplateField HeaderText="View Details">  
             <ItemTemplate>  
                 <asp:LinkButton runat="server" class="btn btn-success btn-sm" OnClick="ViewClick_Redirect" Text="View Details" CommandArgument='<%#Eval("BAUserName")%>'/>
             </ItemTemplate>  
         </asp:TemplateField>  
     </columns>  

  </asp:GridView>
		
	</div>
	</form>
</body>

</html>