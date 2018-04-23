<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="T424872.Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v16.1.Web, Version=16.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>   
</head>
<body>
    <form id="form1" runat="server">
    <div>        
        Select report:
        <asp:DropDownList ID="ddlReportName" runat="server" Width="150px" DataTextField="Value" DataValueField="Key">
        </asp:DropDownList>
        <a href="javascript:ShowReport()">Show</a>
        <dx:ASPxWebDocumentViewer ID="ASPxWebDocumentViewer1" runat="server" ClientInstanceName="webDocumentViewer">
        </dx:ASPxWebDocumentViewer>

         <script type="text/javascript">
             function GetSelectedReportName() {
                 return document.getElementById('<%=ddlReportName.ClientID%>').options[document.getElementById('<%=ddlReportName.ClientID%>').selectedIndex].value;
             }

             function ShowReport() {
                 var reportName = GetSelectedReportName();
                 webDocumentViewer.OpenReport(reportName);
             }

    </script>
    </div>
    </form>
</body>
</html>
