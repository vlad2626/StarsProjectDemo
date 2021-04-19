﻿Public Class frmMain
    Private roleInfo As frmRole

    Private Sub tsbProxy(sender As Object, e As EventArgs) Handles tsbCourse.MouseEnter, tsbEvent.MouseEnter, tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbLogout.MouseEnter, tsbMember.MouseEnter, tsbRole.MouseEnter, tsbRSVP.MouseEnter, tsbRSVP.MouseEnter, tsbSemester.MouseEnter, tsbTutor.MouseEnter
        ' this is needed because we are not putting our images in the Image property of the toolbar buttons

        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)

        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub


    Private Sub tsbProxyLeave(sender As Object, e As EventArgs) Handles tsbCourse.MouseLeave, tsbEvent.MouseLeave, tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbLogout.MouseLeave, tsbMember.MouseLeave, tsbRole.MouseLeave, tsbRSVP.MouseLeave, tsbRSVP.MouseLeave, tsbSemester.MouseLeave, tsbTutor.MouseLeave
        ' this is needed because we are not putting our images in the Image property of the toolbar buttons

        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)

        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        roleInfo = New frmRole
        Try
            myDB.OpenDB()
        Catch ex As Exception
            MessageBox.Show("unable to open database. connections string =" & gstrConn, "DB Eroor", MessageBoxButtons.OK, MessageBoxIcon.Error)
            endProgram()
        End Try
    End Sub

    Private Sub endProgram()
        'closes each form except main
        Dim f As Form
        Me.Cursor = Cursors.WaitCursor

        For Each f In Application.OpenForms
            If f.Name <> Me.Name Then
                If Not f Is Nothing Then
                    f.Close()
                End If
            End If
        Next

        'close database connection

        If Not objSQLConn Is Nothing Then
            objSQLConn.Close()
            objSQLConn.Dispose()

        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsbRole_Click(sender As Object, e As EventArgs) Handles tsbRole.Click
        Me.Hide()
        roleInfo.ShowDialog()
        Me.Show()
        performNextAction()
    End Sub

    Private Sub performNextAction()
        ' get the next action specified on the child form , and then simulate the click of that button here


        Select Case intNextAction
            Case ACTION_COURSE
                tsbCourse.PerformClick()
            Case ACTION_EVENT
                tsbEvent.PerformClick()
            Case ACTION_HELP
                tsbHelp.PerformClick()
            Case ACTION_HOME
                tsbHome.PerformClick()
            Case ACTION_LOGOUT
                tsbLogout.PerformClick()
            Case ACTION_MEMBER
                tsbMember.PerformClick()
            Case ACTION_NONE
                'nothing to do here
            Case ACTION_ROLE
                tsbRole.PerformClick()
            Case ACTION_RSVP
                tsbRSVP.PerformClick()
            Case ACTION_SEMESTER
                tsbSemester.PerformClick()
            Case ACTION_TUTOR
                tsbTutor.PerformClick()
            Case ACTION_MEMBERROLE
                tsbMemRole.PerformClick()
            Case Else
                MessageBox.Show("unexcpected case vallue  , perfrom next ation", " program error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Select

    End Sub

    Private Sub tsbLogout_Click(sender As Object, e As EventArgs) Handles tsbLogout.Click
        endProgram()
    End Sub

    Private Sub tsbMemRole_Click(sender As Object, e As EventArgs) Handles tsbMemRole.Click
        Me.Hide()
        frmMemberRole.ShowDialog()
        Me.Show()
        performNextAction()

    End Sub
End Class
