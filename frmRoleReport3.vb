Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmRoleReport3
    Private ds As DataSet
    Private da As SqlDataAdapter
    Private Role As CRole
    Private Sub frmRoleReport3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rpvRoleReport3.RefreshReport()
    End Sub

    Public Sub display()
        Role = New CRole
        rpvRoleReport3.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory & "Reports\rpRoles.rdlc"
        ds = New DataSet
        da = Role.getReportData()
        da.Fill(ds)
        rpvRoleReport3.LocalReport.DataSources.Add(New ReportDataSource("dsRoles3", ds.Tables(0)))
        rpvRoleReport3.SetDisplayMode(DisplayMode.PrintLayout)
        rpvRoleReport3.RefreshReport()
        Me.Cursor = Cursors.Default
        Me.ShowDialog()
    End Sub
End Class