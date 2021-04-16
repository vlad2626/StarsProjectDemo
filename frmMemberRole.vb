Imports System.Data.SqlClient

Public Class frmMemberRole

    Private objMember As Member
    Private objCMember As CMember
    Public objroles As CRoles
    Private objSemester As CSemester
    Private objMemberRole As CMemberRole
    Private arrUserRoles As ArrayList
    Private arrAllRoles As ArrayList
    Private arrUserRolesAfter As ArrayList


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
        arrUserRoles = New ArrayList
        arrAllRoles = New ArrayList

        arrUserRolesAfter = New ArrayList

        showMembers()
        loadRoles()
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
                arrAllRoles.Add(objDR.Item("RoleID"))

            Loop

            objDR.Close()

        Catch ex As Exception
            ' could have CDB throw the error and trap it here
        End Try



    End Sub




    Private Sub cbADD_Click(sender As Object, e As EventArgs) Handles cbADD.Click
        grpSemester.Enabled = True
        grpRole.Enabled = True
        Dim index = -1
        
        compareRoles()

    End Sub

    Private Sub compareRoles()
        lstRole.Items.Clear()
        'adds all the users
        Dim arrCont = New ArrayList

        For i = 0 To arrAllRoles.Count - 1
            lstRole.Items.Add(arrAllRoles.Item(i))
        Next


        For i = 0 To lstRole.Items.Count - 1
            If arrUserRoles.Contains(lstRole.Items(i)) Then
                lstRole.SetItemChecked(i, True)
            End If


        Next



    End Sub



    Private Sub lstMem_Click(sender As Object, e As EventArgs) Handles lstMem.SelectedIndexChanged, cboSemester.SelectedIndexChanged
        grpSemester.Enabled = True
        cbTest.Items.Clear()

        If lstMem.SelectedIndex = -1 Then
            Exit Sub
        End If
        If cboSemester.SelectedIndex = -1 Then
            Exit Sub
        End If
        Dim semester As String
        cbPID.SelectedIndex = lstMem.SelectedIndex

        If cboSemester.SelectedItem.ToString = "Fall 2016" Then
            semester = "fa16"
        End If

        If cboSemester.SelectedItem.ToString = "Fall 2017" Then
            semester = "fa17"
        End If

        If cboSemester.SelectedItem.ToString = "Summer 2017" Then
            semester = "su17"
        End If

        If cboSemester.SelectedItem.ToString = "Spring 2017" Then
            semester = "sp17"
        End If



        loadSelectedRecord(lstMem.SelectedItem.ToString, semester)
    End Sub

    Private Sub loadSelectedRecord(strMember As String, strSemester As String)
        lstRole.Items.Clear()
        cbADD.Checked = False
        grpRole.Enabled = False
        Dim objDR As SqlDataReader
        Dim count = -1 ' counter for current index of the roles

        objDR = objMemberRole.getAll(strMember, strSemester)
        'objDR = objMemberRole.getAll(lstMem.SelectedItem.ToString)
        Try

            While objDR.Read
                lstRole.Items.Add(objDR.Item("RoleID"))
                arrUserRoles.Add(objDR.Item("RoleID"))
                count = count + 1
                lstRole.SetItemChecked(count, True)

            End While

            For i = 0 To lstRole.Items.Count - 1
                If arrUserRoles.Contains(lstRole.Items(i)) Then
                    lstRole.SetItemChecked(i, True)
                End If


            Next
            objDR.Close()
        Catch ex As Exception
            MessageBox.Show("Error displaying data" & ex.ToString, " Error loading", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdding.Click

        Dim blnChange As Boolean
        Dim semester As String = getSemester(semester)
        Dim objDR

        ' loop to get the changes the user made
        For i = 0 To lstRole.Items.Count - 1
            If lstRole.GetItemChecked(i) = True Then
                arrUserRolesAfter.Add(lstRole.Items(i).ToString)

            End If
        Next

        'nested loop to remove roles
        Try
            For i = 0 To arrUserRoles.Count - 1
                For j = 0 To arrUserRolesAfter.Count - 1
                    If arrUserRoles.Item(i).Equals(arrUserRolesAfter.Item(j)) Then ' when it is false, we will remove the role form the table
                        objDR = objMemberRole.removeRole(cbPID.SelectedItem.ToString, arrUserRolesAfter.Item(i), semester)
                    End If

                Next

            Next
        Catch ex As Exception
            MessageBox.Show("Error removing role" & ex.ToString, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


        'this loop check the lenght of the checcked user array role before And after
        'if it is changed adds the new roles.
        Try



            For i = 0 To arrUserRolesAfter.Count - 1
                objDR = objMemberRole.SaveRoles(cbPID.SelectedItem.ToString, arrUserRolesAfter.Item(i), semester)
                cbTest.Items.Add(cbPID.SelectedItem.ToString & arrUserRolesAfter.Item(i) & semester)
            Next

        Catch ex As Exception
            MessageBox.Show("Error removing role" & ex.ToString, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try






    End Sub


    Private Function getSemester(Semester As String) As String

        If cboSemester.SelectedItem.ToString = "Fall 2016" Then
            Semester = "fa16"
        End If

        If cboSemester.SelectedItem.ToString = "Fall 2017" Then
            Semester = "fa17"
        End If

        If cboSemester.SelectedItem.ToString = "Summer 2017" Then
            Semester = "su17"
        End If

        If cboSemester.SelectedItem.ToString = "Spring 2017" Then
            Semester = "sp17"
        End If

        Return Semester
    End Function
    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click


    End Sub
End Class