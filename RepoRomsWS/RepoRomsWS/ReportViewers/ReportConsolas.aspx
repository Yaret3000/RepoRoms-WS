﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportConsolas.aspx.cs" Inherits="RepoRomsWS.ReportViewers.ReportConsolas" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
           <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" AsyncRendering="false" Height="443px" Width="451px">
        </rsweb:ReportViewer>
           
    </form>
</body>
</html>
