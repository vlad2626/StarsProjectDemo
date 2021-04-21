Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmMemberRoleReport
    Private ds As DataSet
    Private da As SqlDataAdapter
    Private MemberRole As CMemberRoles
    Private Sub frmMemberRoleReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rpvRoleReport.RefreshReport()
        Me.rpvRoleReport.RefreshReport()
    End Sub


    Public Sub display()
        MemberRole = New CMemberRoles
        rpvRoleReport.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory & "Reports\rptMemberRole.rdlc"
        ds = New DataSet
        da = MemberRole.getReportData()
        da.Fill(ds)
        rpvRoleReport.LocalReport.DataSources.Add(New ReportDataSource("dsMemberRole", ds.Tables(0)))
        rpvRoleReport.SetDisplayMode(DisplayMode.PrintLayout)
        rpvRoleReport.RefreshReport()
        Me.Cursor = Cursors.Default
        Me.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub
End Class