using System.Collections.Generic;
using DevExpress.XtraReports.Web.Extensions;
using System;
using DevExpress.XtraReports.UI;
using System.IO;

namespace T424872 {
    public class CustomReportStorageWebExtension : DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension {
        public override bool CanSetData(string url) {
            return false; //Saving is not allowed
        }
        public override bool IsValidUrl(string url) {
            try {
                Type reportType = Type.GetType(url);
                XtraReport report = (XtraReport)Activator.CreateInstance(reportType);
                return true;
            }
            catch {
                return false;
            }            
        }

        public override byte[] GetData(string url) {
            Type reportType = Type.GetType(url);
            XtraReport report = (XtraReport)Activator.CreateInstance(reportType);
            using (MemoryStream ms = new MemoryStream()) {
                report.SaveLayout(ms);
                return ms.ToArray();
            }
        }            

        public override Dictionary<string, string> GetUrls() {
            Dictionary<string, string> urls = new Dictionary<string, string>();
            urls.Add(typeof(ProductsReport).FullName, "Products");
            urls.Add(typeof(CategoriesReport).FullName, "Categories");
            urls.Add(typeof(OrdersReport).FullName, "Orders");
            return urls;
        }

        public override void SetData(DevExpress.XtraReports.UI.XtraReport report, string url) {
            throw new NotImplementedException("Saving is not implmented");
        }

        public override string SetNewData(DevExpress.XtraReports.UI.XtraReport report, string defaultUrl) {
            throw new NotImplementedException("Saving is not implmented");
        }
    }
}
