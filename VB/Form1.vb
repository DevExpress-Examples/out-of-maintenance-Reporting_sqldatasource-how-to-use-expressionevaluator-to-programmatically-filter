Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Native.Sql
Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess.Sql.DataApi
Imports DevExpress.XtraReports.UI

Namespace dxSample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim report As XtraReport = New XtraReport2()
            documentViewer1.DocumentSource = report
            report.CreateDocument()
        End Sub
    End Class
End Namespace
