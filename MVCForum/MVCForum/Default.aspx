<%@ Page Language="C#" %>
<%@ Import Namespace="System.Web.Mvc" %>

<script runat="server">
    
    protected override void OnLoad(EventArgs e)
    {
        HttpContext.Current.RewritePath(Request.ApplicationPath);
        IHttpHandler httpHandler = new MvcHttpHandler();
        httpHandler.ProcessRequest(HttpContext.Current);
    }
    
</script>