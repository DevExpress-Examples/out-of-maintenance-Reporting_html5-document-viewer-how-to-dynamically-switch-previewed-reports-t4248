Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace T424872
	Partial Public Class [Default]
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				Dim reportsStorage As New CustomReportStorageWebExtension()

				ddlReportName.DataSource = reportsStorage.GetUrls()
				ddlReportName.DataBind()
			End If
		End Sub
	End Class
End Namespace