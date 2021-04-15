Imports System.Data.SqlClient

Public Class frmMemberRole

    Private objMember As Member
    Private objCMember As CMember
    Public objroles As CRoles
    Private objSemester As CSemester
    Private objMemberRole As CMemberRole

    Private objAdd As frmMember
    Private blnClearing As Boolean
    Private blnReloading As Boolean

    Private Sub showMembers()
        Dim objDR As SqlDataReader
        lstMem.Items.Clear()
        Try
            objDR = objMember.getAllMembers()
            Do While objDR.Read
                lstMem.Items.Add(objDR.Item("LName"))
                cbPID.Items.Add(objDR.Item("PID"))
            Loop
            objDR.Close()
        Catch ex As Exception
            MessageBox.Show("showing members" & ex.ToString, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub


    Private Sub loadSemester()
        Dim objDR As SqlDataReader

        If cboSemester.Items.Count = 0 Then


            Try
                objDR = objSemester.getAllSemester()
                Do While objDR.Read
                    cboSemester.Items.Add(objDR.Item("SemesterDescription"))
                Loop

                objDR.Close()

            Catch ex As Exception
                ' could have CDB throw the error and trap it here
            End Try
        End If
    End Sub
    Private Sub frmMemberRole_Load(sender As Object, e As EventArgs) Handles Me.Load
        objMember = New Member(Nothing)
        objroles = New CRoles
        objAdd = New frmMember
        objSemester = New CSemester(Nothing)
        objMemberRole = New CMemberRole
        objCMember = New CMember

        showMembers()
        'loadRoles()
        loadSemester()

        grpRole.Enabled = False
        grpSemester.Enabled = False

    End Sub
#Region "Toolbar"
    Private Sub tsbCourse_Click(sender As Object, e As EventArgs) Handles tsbCourse.Click
        intNextAction = ACTION_COURSE
        Me.Hide()
    End Sub

    Private Sub tsbEvent_Click(sender As Object, e As EventArgs) Handles tsbEvent.Click
        intNextAction = ACTION_EVENT
        Me.Hide()
    End Sub

    Private Sub tsbHelp_Click(sender As Object, e As EventArgs) Handles tsbHelp.Click
        intNextAction = ACTION_HOME
        Me.Hide()
    End Sub

    Private Sub tsbHome_Click(sender As Object, e As EventArgs) Handles tsbHome.Click
        intNextAction = ACTION_HOME
        Me.Hide()
    End Sub

    Private Sub tsbLogout_Click(sender As Object, e As EventArgs) Handles tsbLogout.Click
        intNextAction = ACTION_LOGOUT
        Me.Hide()
    End Sub

    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
        intNextAction = ACTION_MEMBER
        Me.Hide()
    End Sub

    Private Sub tsbRole_Click(sender As Object, e As EventArgs) Handles tsbRole.Click
        ' already in the role from
    End Sub

    Private Sub tsbRSVP_Click(sender As Object, e As EventArgs) Handles tsbRSVP.Click
        intNextAction = ACTION_RSVP
        Me.Hide()
    End Sub

    Private Sub tsbSemester_Click(sender As Object, e As EventArgs) Handles tsbSemester.Click
        intNextAction = ACTION_SEMESTER
        Me.Hide()

    End Sub

    Private Sub tsbTutor_Click(sender As Object, e As EventArgs) Handles tsbTutor.Click
        intNextAction = ACTION_TUTOR
        Me.Hide()
    End Sub
#End Region
    Private Sub loadRoles()
        Dim objDR As SqlDataReader
        lstRole.Items.Clear()

        Try
            objDR = objroles.getAllRoles()
            Do While objDR.Read
                lstRole.Items.Add(objDR.Item("RoleID"))
            Loop

            objDR.Close()

        Catch ex As Exception
            ' could have CDB throw the error and trap it here
        End Try



    End Sub




    Private Sub cbADD_Click(sender As Object, e As EventArgs) Handles cbADD.Click
        grpSemester.Enabled = True
        grpRole.Enabled = True

    End Sub

    Private Sub lstMem_Click(sender As Object, e As EventArgs) Handles lstMem.SelectedIndexChanged

        If lstMem.SelectedIndex = -1 Then
            Exit Sub
        End If
        cbPID.SelectedIndex = lstMem.SelectedIndex
        cboSemester.SelectedIndex = 0 ' default to 2016.
        loadSelectedRecord()
    End Sub

    Private Sub loadSelectedRecord()
        lstRole.Items.Clear()
        Dim objDR As SqlDataReader

        'objDR = objMemberRole.getAll(lstMem.SelectedItem.ToString, cboSemester.SelectedItem.ToString)
        objDR = objMemberRole.getAll(lstMem.SelectedItem.ToString)
        Try

            While objDR.Read
                lstRole.Items.Add(objDR.Item("RoleID"))
            End While
            objDR.Close()
        Catch ex As Exception
            MessageBox.Show("Error displaying data" & ex.ToString, " Error loading", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub
End Class