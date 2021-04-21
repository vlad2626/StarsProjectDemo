Imports System.Data.SqlClient

Public Class frmMemberRole

    Private objMember As CMembers
    ' Private objCMember As CMember
    Public objroles As CRoles
    Private objSemesters As CSemesters
    Private objMemberRoles As CMemberRoles
    Private arrUserRoles As ArrayList
    Private arrAllRoles As ArrayList
    Private arrUserRolesAfter As ArrayList


    'Private objAdd As frmMember
    Private blnClearing As Boolean
    Private blnReloading As Boolean

    Private Sub showMembers()
        Dim objDR As SqlDataReader
        lstMem.Items.Clear()
        Try
            'objDR = objMemberRoles.getAllMembers()
            objDR = objMember.GetAllMembers()
            Do While objDR.Read
                lstMem.Items.Add(objDR.Item("LName"))

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
                objDR = objSemesters.getAllSemesters()
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

        objroles = New CRoles

        objSemesters = New CSemesters
        objMemberRoles = New CMemberRoles
        objMember = New CMembers

        arrUserRoles = New ArrayList
        arrAllRoles = New ArrayList

        arrUserRolesAfter = New ArrayList

        showMembers()
        loadRoles()
        loadSemester()

        grpRole.Enabled = True
        grpSemester.Enabled = False

        grpInfo.Enabled = True
        grpInfo.Visible = True

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
        clbRoles.Items.Clear()

        Try
            objDR = objroles.getAllRoles()

            While objDR.Read
                clbRoles.Items.Add(objDR.Item("RoleID"))
            End While

            objDR.Close()

        Catch ex As Exception

        End Try



    End Sub










    Private Sub lstMem_Click(sender As Object, e As EventArgs) Handles lstMem.SelectedIndexChanged, cboSemester.SelectedIndexChanged
        grpSemester.Enabled = True


        If lstMem.SelectedIndex = -1 Then
            Exit Sub
        End If
        If cboSemester.SelectedIndex = -1 Then
            Exit Sub
        End If
        Dim semester As String





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

        If cboSemester.SelectedItem.ToString = "" Then
            semester = "fa16"
        End If



        loadSelectedRecord(lstMem.SelectedItem.ToString, semester)
    End Sub

    Private Sub loadSelectedRecord(strMember As String, strSemester As String)
        'clbRoles.Items.Clear()
        'arrUserRoles.Clear()
        ' clears the last user roles
        For i = 0 To clbRoles.Items.Count - 1
            clbRoles.SetItemChecked(i, False)
        Next
        'cbADD.Checked = False
        'grpRole.Enabled = False
        Dim objDR As SqlDataReader
        Dim count = -1 ' counter for current index of the roles

        'curent working way to get all roles
        objDR = objMemberRoles.getAllMemberRolesBySemester(strMember, strSemester)



        'objDR = objMemberRoles.getAllMemberRolesBySemester(lstMem.SelectedItem.ToString, strSemester)
        Try


            ' this only loads 1 role for the user.
            ' With objMemberRoles.CurrentObject
            'While objDR.Read
            '    clbRoles.Items.Add(objDR.Item("RoleID"))
            '    lblPID.Text = ""   'pull from a variable
            '    ' End With
            'End While



            'currently working to load all roles

            While objDR.Read
                For i = 0 To clbRoles.Items.Count - 1 ' iterate trough the roles
                    If clbRoles.Items(i).Equals(objDR.Item("RoleID")) Then
                        clbRoles.SetItemChecked(i, True)
                    End If
                    If clbRoles.GetItemChecked(i) Then ' if this is true it will add it to an arraylist of userRoles 
                        arrUserRoles.Add(clbRoles.Items(i))

                    End If
                Next
                lblPID.Text = objDR.Item("PID")
                lblFirstName.Text = objDR.Item("FName")
                lblLastName.Text = objDR.Item("LName")
            End While
            objDR.Close()



        Catch ex As Exception
            MessageBox.Show("Error displaying data" & ex.ToString, " Error loading", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdding.Click

        Dim blnChange As Boolean
        Dim semester As String
        Dim objDR
        Dim i As Integer
        Dim message = False
        Dim intResult As Integer



        objDR = objMemberRoles.getSemesterBySemesterID(cboSemester.SelectedItem.ToString)

        While objDR.read
            semester = objDR.item("SemesterID")
        End While
        objDR.close()


        'clears the array list.
        arrUserRolesAfter = New ArrayList
        ' loop to get the changes the user made
        For i = 0 To clbRoles.Items.Count - 1
            If (clbRoles.GetItemChecked(i)) Then
                arrUserRolesAfter.Add(clbRoles.Items(i))
            End If

        Next
        'guest cannot be members
        For i = 0 To arrUserRolesAfter.Count - 1
            If arrUserRolesAfter.Item(i).Equals("Member") Then
                For j = 0 To arrUserRolesAfter.Count - 1


                    If arrUserRolesAfter.Item(j).Equals("Guest") Then
                        arrUserRolesAfter.Remove(i)
                        clbRoles.SetItemChecked(i, False) ' reset both the guest and member checkbox so user has to make a choice
                        clbRoles.SetItemChecked(j, False)
                        MessageBox.Show("Members cannot be guest", "UserError", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Next
            End If
        Next

        ' must have member role to have admin Or officer
        For i = 0 To arrUserRolesAfter.Count - 1
            If (arrUserRolesAfter.Item(i).Equals("Admin")) Or (arrUserRolesAfter.Item(i).Equals("Officer")) Then
                For j = 0 To arrUserRolesAfter.Count - 1
                    If arrUserRolesAfter.Contains("Member") Then
                        message = False

                    Else
                        message = True
                    End If


                Next
            End If
            If message Then
                MessageBox.Show("Must be a member to also have Admin or officerRole", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Exit Sub
            End If

        Next


        Dim remove


        'nested loop to remove roles
        Try
            For i = 0 To arrUserRoles.Count - 1
                For j = 0 To arrUserRolesAfter.Count - 1
                    If Not arrUserRoles.Item(i).Equals(arrUserRolesAfter.Item(j)) Then ' when it is true, we will remove the role form the table
                        objDR = objMemberRoles.removeRole(lblPID.Text, arrUserRoles.Item(i), semester)
                    End If
                Next
            Next
        Catch ex As Exception
            MessageBox.Show("Error removing role" & ex.ToString, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'this loop check the lenght of the checcked user array role before And after
        'if it is changed adds the new roles.
        Try

            'this nested loop will check if the changes the user made and if it is a new one it will save it into the DB without 
            'overwriting the old ones.
            For i = 0 To arrUserRolesAfter.Count - 1
                For j = 0 To arrUserRoles.Count - 1

                    If Not arrUserRolesAfter.Item(i).Equals(arrUserRoles.Item(j)) Then
                        objMemberRoles.SaveRoles(lblPID.Text, arrUserRolesAfter.Item(i).ToString, semester)
                    End If
                Next
                ' objMemberRoles.SaveRoles(cbPID.SelectedItem.ToString, arrUserRolesAfter.Item(i), semester)
            Next

        Catch ex As Exception
            MessageBox.Show("Error saving role" & clbRoles.Items.Count, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'cbADD.Checked = False ' 

        loadSelectedRecord(lstMem.SelectedItem.ToString, semester)

    End Sub


    Private Function getSemester(Semester As String) As String

        If cboSemester.SelectedIndex = -1 Then
            Semester = "fa16"
        End If

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
        If cboSemester.SelectedIndex = -1 Then
            Semester = "fa16"
        End If

        Return Semester
    End Function

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim roleReport As New frmMemberRoleReport
        If lstMem.Items.Count = 0 Then
            MessageBox.Show("There are no records to print")
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        roleReport.display()
        Me.Cursor = Cursors.Default

    End Sub


End Class