<%@ Page Language="C#" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<%@ Import Namespace="System.IO" %>

<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        StreamReader streamReader = File.OpenText(MapPath("~/BREAKING_CHANGES.txt"));
        this.pre1.InnerText = streamReader.ReadToEnd();
    }
</script>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>BREAKING_CHANGES.txt - Ext.NET Examples</title>
    <link href="/resources/css/examples.css"  rel="stylesheet" />
</head>
<body>
    <pre runat="server" id="pre1">
    </pre>
</body>
</html>
    