using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace T424872 {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                CustomReportStorageWebExtension reportsStorage = new CustomReportStorageWebExtension();

                ddlReportName.DataSource = reportsStorage.GetUrls();
                ddlReportName.DataBind();
            }
        }
    }
}