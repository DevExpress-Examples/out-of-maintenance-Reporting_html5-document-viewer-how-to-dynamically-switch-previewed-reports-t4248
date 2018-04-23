Namespace T424872
	Partial Public Class CategoriesReport
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CategoriesReport))
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.lbDescription = New DevExpress.XtraReports.UI.XRLabel()
			Me.pbPicture = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.lbHeader = New DevExpress.XtraReports.UI.XRLabel()
			Me.lbCategoryName = New DevExpress.XtraReports.UI.XRLabel()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbHeader})
			Me.ReportHeader.Dpi = 100F
			Me.ReportHeader.HeightF = 100F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' lbDescription
			' 
			Me.lbDescription.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description")})
			Me.lbDescription.Dpi = 100F
			Me.lbDescription.Font = New System.Drawing.Font("Times New Roman", 14F)
			Me.lbDescription.LocationFloat = New DevExpress.Utils.PointFloat(220F, 53.08332F)
			Me.lbDescription.Multiline = True
			Me.lbDescription.Name = "lbDescription"
			Me.lbDescription.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbDescription.SizeF = New System.Drawing.SizeF(430F, 56.91668F)
			Me.lbDescription.StylePriority.UseFont = False
			Me.lbDescription.Text = "lbDescription"
			' 
			' pbPicture
			' 
			Me.pbPicture.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
			Me.pbPicture.Dpi = 100F
			Me.pbPicture.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10F)
			Me.pbPicture.Name = "pbPicture"
			Me.pbPicture.SizeF = New System.Drawing.SizeF(200F, 100F)
			Me.pbPicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "nwind.mdb"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "CategoryID"
			table1.Name = "Categories"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "CategoryName"
			columnExpression2.Table = table1
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "Description"
			columnExpression3.Table = table1
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "Picture"
			columnExpression4.Table = table1
			column4.Expression = columnExpression4
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Name = "Categories"
			selectQuery1.Tables.Add(table1)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbDescription, Me.pbPicture, Me.lbCategoryName})
			Me.Detail.Dpi = 100F
			Me.Detail.HeightF = 110F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.Dpi = 100F
			Me.TopMargin.HeightF = 100F
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' lbHeader
			' 
			Me.lbHeader.Dpi = 100F
			Me.lbHeader.Font = New System.Drawing.Font("Times New Roman", 36F)
			Me.lbHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10.00001F)
			Me.lbHeader.Name = "lbHeader"
			Me.lbHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbHeader.SizeF = New System.Drawing.SizeF(650.0001F, 79.99998F)
			Me.lbHeader.StylePriority.UseFont = False
			Me.lbHeader.StylePriority.UseTextAlignment = False
			Me.lbHeader.Text = "Categories Report"
			Me.lbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' lbCategoryName
			' 
			Me.lbCategoryName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
			Me.lbCategoryName.Dpi = 100F
			Me.lbCategoryName.Font = New System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold)
			Me.lbCategoryName.LocationFloat = New DevExpress.Utils.PointFloat(220F, 10.00001F)
			Me.lbCategoryName.Name = "lbCategoryName"
			Me.lbCategoryName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbCategoryName.SizeF = New System.Drawing.SizeF(430F, 32F)
			Me.lbCategoryName.StylePriority.UseFont = False
			Me.lbCategoryName.Text = "lbCategoryName"
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Dpi = 100F
			Me.BottomMargin.HeightF = 100F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' CategoriesReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.DataMember = "Categories"
			Me.DataSource = Me.sqlDataSource1
			Me.Version = "16.1"
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private lbHeader As DevExpress.XtraReports.UI.XRLabel
		Private lbDescription As DevExpress.XtraReports.UI.XRLabel
		Private pbPicture As DevExpress.XtraReports.UI.XRPictureBox
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private lbCategoryName As DevExpress.XtraReports.UI.XRLabel
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

	End Class
End Namespace
