Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.DataAccess.Native.Sql
Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess.Sql.DataApi

Namespace dxSample
    Partial Public Class XtraReport2
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub
        Private ReadOnly Property FilterExpression() As String
            Get
                Return String.Format("CategoryName == '{0}'", Me.Parameters("categoryName").Value)
            End Get
        End Property
        Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
            e.Cancel = Not IsFit()
        End Sub

        Private Function IsFit() As Boolean
            Dim rr As ResultRow = TryCast(Me.GetCurrentRow(), ResultRow)

            Dim resultSet As IResultSet = TryCast((TryCast(Me.DataSource, SqlDataSource)).Result, DevExpress.DataAccess.Sql.DataApi.IResultSet)
            Dim tableProd As ITable = Nothing
            resultSet.TryGetTable("CategoryProducts", tableProd)
            Dim filter As DevExpress.Data.Filtering.CriteriaOperator = DevExpress.Data.Filtering.CriteriaOperator.Parse(FilterExpression)
            Dim evaluator As New DevExpress.Data.Filtering.Helpers.ExpressionEvaluator((DirectCast(tableProd, ITypedList).GetItemProperties(Nothing)), filter)

            Dim isFit_Renamed As Boolean = evaluator.Fit(rr)
            Return isFit_Renamed
        End Function

        Private Sub GroupHeader1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader1.BeforePrint
            e.Cancel = Not IsFit()
        End Sub
    End Class
End Namespace
