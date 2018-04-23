Imports System.Collections.Generic
Imports DevExpress.XtraReports.Web.Extensions
Imports System
Imports DevExpress.XtraReports.UI
Imports System.IO

Namespace T424872
	Public Class CustomReportStorageWebExtension
		Inherits DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension

		Public Overrides Function CanSetData(ByVal url As String) As Boolean
			Return False 'Saving is not allowed
		End Function
		Public Overrides Function IsValidUrl(ByVal url As String) As Boolean
			Try
				Dim reportType As Type = Type.GetType(url)
				Dim report As XtraReport = DirectCast(Activator.CreateInstance(reportType), XtraReport)
				Return True
			Catch
				Return False
			End Try
		End Function

		Public Overrides Function GetData(ByVal url As String) As Byte()
			Dim reportType As Type = Type.GetType(url)
			Dim report As XtraReport = DirectCast(Activator.CreateInstance(reportType), XtraReport)
			Using ms As New MemoryStream()
				report.SaveLayout(ms)
				Return ms.ToArray()
			End Using
		End Function

		Public Overrides Function GetUrls() As Dictionary(Of String, String)
			Dim urls As New Dictionary(Of String, String)()
			urls.Add(GetType(ProductsReport).FullName, "Products")
			urls.Add(GetType(CategoriesReport).FullName, "Categories")
			urls.Add(GetType(OrdersReport).FullName, "Orders")
			Return urls
		End Function

		Public Overrides Sub SetData(ByVal report As DevExpress.XtraReports.UI.XtraReport, ByVal url As String)
			Throw New NotImplementedException("Saving is not implmented")
		End Sub

		Public Overrides Function SetNewData(ByVal report As DevExpress.XtraReports.UI.XtraReport, ByVal defaultUrl As String) As String
			Throw New NotImplementedException("Saving is not implmented")
		End Function
	End Class
End Namespace
