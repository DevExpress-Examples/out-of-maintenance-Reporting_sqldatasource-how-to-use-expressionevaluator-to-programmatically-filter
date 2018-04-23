Namespace dxSample
    Partial Public Class XtraReport2
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
            Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
            Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo3 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo4 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo5 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo6 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim tableQuery2 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim tableInfo2 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo7 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport2))
            Dim dynamicListLookUpSettings1 As New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.categoryName = New DevExpress.XtraReports.Parameters.Parameter()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3, Me.xrLabel4})
            Me.Detail.HeightF = 25.00001F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.BackColor = System.Drawing.Color.Transparent
            Me.xrLabel3.BorderColor = System.Drawing.Color.Black
            Me.xrLabel3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
            Me.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel3.BorderWidth = 1F
            Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CategoryProducts.ProductID")})
            Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 9.75F)
            Me.xrLabel3.ForeColor = System.Drawing.Color.Black
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(100.625F, 0F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(50.83332F, 25.00001F)
            Me.xrLabel3.StylePriority.UseBackColor = False
            Me.xrLabel3.StylePriority.UseBorderColor = False
            Me.xrLabel3.StylePriority.UseBorderDashStyle = False
            Me.xrLabel3.StylePriority.UseBorders = False
            Me.xrLabel3.StylePriority.UseBorderWidth = False
            Me.xrLabel3.StylePriority.UseFont = False
            Me.xrLabel3.StylePriority.UseForeColor = False
            Me.xrLabel3.StylePriority.UsePadding = False
            Me.xrLabel3.StylePriority.UseTextAlignment = False
            xrSummary1.FormatString = "{0:#)}"
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
            Me.xrLabel3.Summary = xrSummary1
            Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.BackColor = System.Drawing.Color.Transparent
            Me.xrLabel4.BorderColor = System.Drawing.Color.Black
            Me.xrLabel4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
            Me.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel4.BorderWidth = 1F
            Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CategoryProducts.ProductName")})
            Me.xrLabel4.Font = New System.Drawing.Font("Times New Roman", 9.75F)
            Me.xrLabel4.ForeColor = System.Drawing.Color.Black
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(151.4583F, 0F)
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(498.5417F, 25F)
            Me.xrLabel4.StylePriority.UseBackColor = False
            Me.xrLabel4.StylePriority.UseBorderColor = False
            Me.xrLabel4.StylePriority.UseBorderDashStyle = False
            Me.xrLabel4.StylePriority.UseBorders = False
            Me.xrLabel4.StylePriority.UseBorderWidth = False
            Me.xrLabel4.StylePriority.UseFont = False
            Me.xrLabel4.StylePriority.UseForeColor = False
            Me.xrLabel4.StylePriority.UsePadding = False
            Me.xrLabel4.StylePriority.UseTextAlignment = False
            Me.xrLabel4.Text = "xrTableCell4"
            Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "dxSample.Properties.Settings.nwindConnectionString"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            tableQuery1.Name = "CategoryProducts"
            tableInfo1.Name = "CategoryProducts"
            columnInfo1.Name = "ProductID"
            columnInfo2.Name = "SupplierID"
            columnInfo3.Name = "ProductName"
            columnInfo4.Name = "CategoryName"
            columnInfo5.Name = "Picture"
            columnInfo6.Name = "Description"
            tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2, columnInfo3, columnInfo4, columnInfo5, columnInfo6})
            tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1})
            tableQuery2.Name = "Categories"
            tableInfo2.Name = "Categories"
            columnInfo7.Name = "CategoryName"
            tableInfo2.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo7})
            tableQuery2.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo2})
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1, tableQuery2})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(192)))), (CInt((CByte(255)))), (CInt((CByte(192)))))
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1, Me.xrLabel2})
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("CategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.HeightF = 90.625F
            Me.GroupHeader1.Name = "GroupHeader1"
            Me.GroupHeader1.StylePriority.UseBackColor = False
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.BorderColor = System.Drawing.Color.Black
            Me.xrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
            Me.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel1.BorderWidth = 1F
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CategoryProducts.CategoryName")})
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 20F)
            Me.xrLabel1.ForeColor = System.Drawing.Color.Black
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(650F, 61.45833F)
            Me.xrLabel1.StylePriority.UseBackColor = False
            Me.xrLabel1.StylePriority.UseBorderColor = False
            Me.xrLabel1.StylePriority.UseBorderDashStyle = False
            Me.xrLabel1.StylePriority.UseBorders = False
            Me.xrLabel1.StylePriority.UseBorderWidth = False
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.StylePriority.UsePadding = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "xrTableCell1"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.BorderColor = System.Drawing.Color.Black
            Me.xrLabel2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
            Me.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel2.BorderWidth = 1F
            Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CategoryProducts.Description")})
            Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrLabel2.ForeColor = System.Drawing.Color.Black
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 61.45833F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(650F, 29.16666F)
            Me.xrLabel2.StylePriority.UseBackColor = False
            Me.xrLabel2.StylePriority.UseBorderColor = False
            Me.xrLabel2.StylePriority.UseBorderDashStyle = False
            Me.xrLabel2.StylePriority.UseBorders = False
            Me.xrLabel2.StylePriority.UseBorderWidth = False
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.StylePriority.UseForeColor = False
            Me.xrLabel2.StylePriority.UsePadding = False
            Me.xrLabel2.StylePriority.UseTextAlignment = False
            Me.xrLabel2.Text = "xrTableCell2"
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' categoryName
            ' 
            Me.categoryName.Description = "Select Category"
            dynamicListLookUpSettings1.DataAdapter = Nothing
            dynamicListLookUpSettings1.DataMember = "Categories"
            dynamicListLookUpSettings1.DataSource = Me.sqlDataSource1
            dynamicListLookUpSettings1.DisplayMember = "CategoryName"
            dynamicListLookUpSettings1.FilterString = Nothing
            dynamicListLookUpSettings1.ValueMember = "CategoryName"
            Me.categoryName.LookUpSettings = dynamicListLookUpSettings1
            Me.categoryName.Name = "categoryName"
            Me.categoryName.ValueInfo = "Beverages"
            ' 
            ' XtraReport2
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
            Me.DataMember = "CategoryProducts"
            Me.DataSource = Me.sqlDataSource1
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.categoryName})
            Me.RequestParameters = False
            Me.Version = "15.2"
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
        Private WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private categoryName As DevExpress.XtraReports.Parameters.Parameter
    End Class
End Namespace
