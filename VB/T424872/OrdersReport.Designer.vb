Namespace T424872
	Partial Public Class OrdersReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column5 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column6 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column7 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column8 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column9 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column10 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression10 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column11 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression11 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column12 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression12 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column13 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression13 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column14 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression14 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(OrdersReport))
			Me.lbDate = New DevExpress.XtraReports.UI.XRLabel()
			Me.lbOrderID = New DevExpress.XtraReports.UI.XRLabel()
			Me.EndDate = New DevExpress.XtraReports.Parameters.Parameter()
			Me.lbHeader = New DevExpress.XtraReports.UI.XRLabel()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			Me.StartDate = New DevExpress.XtraReports.Parameters.Parameter()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.lbDetails = New DevExpress.XtraReports.UI.XRLabel()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' lbDate
			' 
			Me.lbDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrderDate", "{0:dddd, dd MMMM, yyyy}")})
			Me.lbDate.Dpi = 100F
			Me.lbDate.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic)
			Me.lbDate.LocationFloat = New DevExpress.Utils.PointFloat(110F, 10.00001F)
			Me.lbDate.Name = "lbDate"
			Me.lbDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbDate.SizeF = New System.Drawing.SizeF(210F, 25F)
			Me.lbDate.StylePriority.UseFont = False
			Me.lbDate.Text = "lbDate"
			' 
			' lbOrderID
			' 
			Me.lbOrderID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrderID")})
			Me.lbOrderID.Dpi = 100F
			Me.lbOrderID.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold)
			Me.lbOrderID.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.lbOrderID.Name = "lbOrderID"
			Me.lbOrderID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbOrderID.SizeF = New System.Drawing.SizeF(100F, 25F)
			Me.lbOrderID.StylePriority.UseFont = False
			Me.lbOrderID.Text = "lbOrderID"
			' 
			' EndDate
			' 
			Me.EndDate.Description = "To"
			Me.EndDate.Name = "EndDate"
			Me.EndDate.Type = GetType(Date)
			' 
			' lbHeader
			' 
			Me.lbHeader.Dpi = 100F
			Me.lbHeader.Font = New System.Drawing.Font("Times New Roman", 36F)
			Me.lbHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10F)
			Me.lbHeader.Name = "lbHeader"
			Me.lbHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbHeader.SizeF = New System.Drawing.SizeF(650.0001F, 79.99998F)
			Me.lbHeader.StylePriority.UseFont = False
			Me.lbHeader.StylePriority.UseTextAlignment = False
			Me.lbHeader.Text = "Orders Report"
			Me.lbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Dpi = 100F
			Me.BottomMargin.HeightF = 100F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "nwind.mdb"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "OrderID"
			table1.Name = "Orders"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "CustomerID"
			columnExpression2.Table = table1
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "EmployeeID"
			columnExpression3.Table = table1
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "OrderDate"
			columnExpression4.Table = table1
			column4.Expression = columnExpression4
			columnExpression5.ColumnName = "RequiredDate"
			columnExpression5.Table = table1
			column5.Expression = columnExpression5
			columnExpression6.ColumnName = "ShippedDate"
			columnExpression6.Table = table1
			column6.Expression = columnExpression6
			columnExpression7.ColumnName = "ShipVia"
			columnExpression7.Table = table1
			column7.Expression = columnExpression7
			columnExpression8.ColumnName = "Freight"
			columnExpression8.Table = table1
			column8.Expression = columnExpression8
			columnExpression9.ColumnName = "ShipName"
			columnExpression9.Table = table1
			column9.Expression = columnExpression9
			columnExpression10.ColumnName = "ShipAddress"
			columnExpression10.Table = table1
			column10.Expression = columnExpression10
			columnExpression11.ColumnName = "ShipCity"
			columnExpression11.Table = table1
			column11.Expression = columnExpression11
			columnExpression12.ColumnName = "ShipRegion"
			columnExpression12.Table = table1
			column12.Expression = columnExpression12
			columnExpression13.ColumnName = "ShipPostalCode"
			columnExpression13.Table = table1
			column13.Expression = columnExpression13
			columnExpression14.ColumnName = "ShipCountry"
			columnExpression14.Table = table1
			column14.Expression = columnExpression14
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Columns.Add(column5)
			selectQuery1.Columns.Add(column6)
			selectQuery1.Columns.Add(column7)
			selectQuery1.Columns.Add(column8)
			selectQuery1.Columns.Add(column9)
			selectQuery1.Columns.Add(column10)
			selectQuery1.Columns.Add(column11)
			selectQuery1.Columns.Add(column12)
			selectQuery1.Columns.Add(column13)
			selectQuery1.Columns.Add(column14)
			selectQuery1.Name = "Orders"
			selectQuery1.Tables.Add(table1)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' StartDate
			' 
			Me.StartDate.Description = "From"
			Me.StartDate.Name = "StartDate"
			Me.StartDate.Type = GetType(Date)
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbHeader})
			Me.ReportHeader.Dpi = 100F
			Me.ReportHeader.HeightF = 100F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbDate, Me.lbDetails, Me.lbOrderID})
			Me.Detail.Dpi = 100F
			Me.Detail.Font = New System.Drawing.Font("Times New Roman", 10F)
			Me.Detail.HeightF = 100F
			Me.Detail.KeepTogether = True
			Me.Detail.MultiColumn.ColumnCount = 2
			Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.StylePriority.UseFont = False
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' lbDetails
			' 
			Me.lbDetails.Dpi = 100F
			Me.lbDetails.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 35.00001F)
			Me.lbDetails.Multiline = True
			Me.lbDetails.Name = "lbDetails"
			Me.lbDetails.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbDetails.SizeF = New System.Drawing.SizeF(310F, 55F)
			Me.lbDetails.StylePriority.UseTextAlignment = False
			Me.lbDetails.Text = "[ShipName] " & ControlChars.CrLf & "[ShipCity] [ShipCountry]" & ControlChars.CrLf & "[ShipAddress]"
			Me.lbDetails.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.Dpi = 100F
			Me.TopMargin.HeightF = 100F
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' OrdersReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.DataMember = "Orders"
			Me.DataSource = Me.sqlDataSource1
			Me.FilterString = "[OrderDate] Between(?StartDate, ?EndDate)"
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.StartDate, Me.EndDate})
			Me.ReportPrintOptions.PrintOnEmptyDataSource = False
			Me.RequestParameters = False
			Me.Scripts.OnParametersRequestBeforeShow = "OrdersReport_ParametersRequestBeforeShow"
			Me.ScriptsSource = resources.GetString("$this.ScriptsSource")
			Me.Version = "16.1"
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private lbDate As DevExpress.XtraReports.UI.XRLabel
		Private lbOrderID As DevExpress.XtraReports.UI.XRLabel
		Private EndDate As DevExpress.XtraReports.Parameters.Parameter
		Private lbHeader As DevExpress.XtraReports.UI.XRLabel
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private StartDate As DevExpress.XtraReports.Parameters.Parameter
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private lbDetails As DevExpress.XtraReports.UI.XRLabel
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

	End Class
End Namespace
