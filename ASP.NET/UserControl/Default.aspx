<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TheWebApplication._Default" %>
<%@ Register Src="userControlOne.ascx" TagName="TheTag" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Main Content
    <uc1:TheTag ID="uniqueIdForPartOne" runat="server"></uc1:TheTag>
    <uc1:TheTagTwo ID="uniqueIdForPartTwo" runat="server"></uc1:TheTagTwo>
    </div>
    </form>
</body>
</html>
