using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using DevExpress.XtraReports.Web.Extensions;
using System.IO;
using DevExpress.XtraReports.UI;

namespace T424872 {
    public class CustomWebDocumentViewerReportResolver : IWebDocumentViewerReportResolver {
        public ReportStorageWebExtension ReportStorage { get; private set; }

        public CustomWebDocumentViewerReportResolver() {
            this.ReportStorage = new CustomReportStorageWebExtension();
        }

        public DevExpress.XtraReports.UI.XtraReport Resolve(string reportName) {
            XtraReport report = new XtraReport();

            byte[] reportLayout = ReportStorage.GetData(reportName);
            using (MemoryStream ms = new MemoryStream(reportLayout)) {
                report.LoadLayout(ms);    
            }
            return report;
        }
    }
}