<!-- default file list -->
*Files to look at*:

* [CustomWebDocumentViewerReportResolver.cs](./CS/T424872/CustomWebDocumentViewerReportResolver.cs) (VB: [CustomWebDocumentViewerReportResolver.vb](./VB/T424872/CustomWebDocumentViewerReportResolver.vb))
* **[Default.aspx](./CS/T424872/Default.aspx) (VB: [Default.aspx.vb](./VB/T424872/Default.aspx.vb))**
* [Default.aspx.cs](./CS/T424872/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/T424872/Default.aspx.vb))
* [Global.asax.cs](./CS/T424872/Global.asax.cs) (VB: [Global.asax.vb](./VB/T424872/Global.asax.vb))
<!-- default file list end -->
# HTML5 Document Viewer - How to dynamically switch previewed reports


<p>This example demonstrates how to dynamically switch reports previewed in the <a href="https://documentation.devexpress.com/XtraReports/CustomDocument17738.aspx">HTML5 Document Viewer</a> component by using this component's client-side API. <br><br>The client-side <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsWebScriptsASPxClientWebDocumentViewer_OpenReporttopic">ASPxClientWebDocumentViewer.OpenReport</a> method is used to open a report in the <a href="https://documentation.devexpress.com/XtraReports/CustomDocument17738.aspx">HTML5 Document Viewer</a> component. By default, the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsWebScriptsASPxClientWebDocumentViewer_OpenReporttopic">OpenReport</a> method expects a fully qualified name of a report class as its parameter. <br><br>In any case, you can implement the <a href="https://documentation.devexpress.com/XtraReports/clsDevExpressXtraReportsWebWebDocumentViewerIWebDocumentViewerReportResolvertopic.aspx">IWebDocumentViewerReportResolver</a> interface to implement your own server-side logic and open the required report by a string passed to the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsWebScriptsASPxClientWebDocumentViewer_OpenReporttopic">OpenReport</a> method. In this code example, a custom report resolver class ("CustomWebDocumentViewerReportResolver ") is implemented to load a report by its URL from a custom storage extension (<a href="https://documentation.devexpress.com/XtraReports/clsDevExpressXtraReportsWebExtensionsReportStorageWebExtensiontopic.aspx">ReportStorageWebExtension</a><u>)</u>, which can be used by Web Report Designer in your application.</p>
<p>Note that a custom report resolver class should be registered in the application's <strong>Global.asax</strong> file. </p>

<br/>


