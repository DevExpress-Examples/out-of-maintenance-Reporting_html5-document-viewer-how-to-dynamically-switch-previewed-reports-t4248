Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.XtraReports.Web.WebDocumentViewer
Imports DevExpress.XtraReports.Web.Extensions
Imports System.IO
Imports DevExpress.XtraReports.UI

Namespace T424872
	Public Class CustomWebDocumentViewerReportResolver
		Implements IWebDocumentViewerReportResolver

		Private privateReportStorage As ReportStorageWebExtension
		Public Property ReportStorage() As ReportStorageWebExtension
			Get
				Return privateReportStorage
			End Get
			Private Set(ByVal value As ReportStorageWebExtension)
				privateReportStorage = value
			End Set
		End Property

		Public Sub New()
			Me.ReportStorage = New CustomReportStorageWebExtension()
		End Sub

		Public Function Resolve(ByVal reportName As String) As DevExpress.XtraReports.UI.XtraReport Implements IWebDocumentViewerReportResolver.Resolve
			Dim report As New XtraReport()

			Dim reportLayout() As Byte = ReportStorage.GetData(reportName)
			Using ms As New MemoryStream(reportLayout)
				report.LoadLayout(ms)
			End Using
			Return report
		End Function
	End Class
End Namespace