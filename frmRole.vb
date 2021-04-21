Imports System.Data.SqlClient
Public Class frmRole

    Public objroles As CRoles
    ' Private objMember As Member
    'Private objAdd As frmMember
    Private blnClearing As Boolean
    Private blnReloading As Boolean


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
#Region " txtBoxes"
    Private Sub txtDesc_GotFocus(sender As Object, e As EventArgs) Handles txtDesc.GotFocus, txtRoleID.GotFocus
        Dim txtBox As TextBox
        txtBox = DirectCast(sender, TextBox)
        txtBox.SelectAll()
    End Sub


    Private Sub txtRoleID_LostFocus(sender As Object, e As EventArgs) Handles txtRoleID.LostFocus, txtDesc.LostFocus
        Dim txtBox As TextBox
        txtBox = DirectCast(sender, TextBox)
        txtBox.SelectAll()
    End Sub


#End Region

    Private Sub loadRoles()
        Dim objDR As SqlDataReader
        lstRoles.Items.Clear()

        Try
            objDR = objroles.getAllRoles()
            Do While objDR.Read
                lstRoles.Items.Add(objDR.Item("PID"))
            Loop

            objDR.Close()

        Catch ex As Exception
            ' could have CDB throw the error and trap it here
        End Try

        If objroles.CurrentObject.RoleID <> "" Then
            lstRoles.SelectedIndex = lstRoles.FindStringExact(objroles.CurrentObject.RoleID)
        End If
        blnReloading = False

    End Sub

    'Private Sub showMembers()
    '    Dim objDR As SqlDataReader
    '    lstMembers.Items.Clear()
    '    Try
    '        objDR = objMember.getAllMembers()
    '        Do While objDR.Read
    '            lstMembers.Items.Add(objDR.Item("LName"))
    '        Loop
    '        objDR.Close()
    '    Catch ex As Exception
    '        MessageBox.Show("showing members" & ex.ToString, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub frmRole_Load(sender As Object, e As EventArgs) Handles Me.Load
        objroles = New CRoles
        ' objMember = New Member(Nothing)
        'objAdd = New frmMember

    End Sub

    Private Sub frmRole_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        clearScreenCOntrols(Me)
        loadRoles()
        'showMembers()
        grpEdit.Enabled = False

    End Sub

    Private Sub lstRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRoles.SelectedIndexChanged
        If blnClearing Then
            Exit Sub
        End If

        If blnReloading Then
            tslStatus.Text = ""
            Exit Sub
        End If

        If lstRoles.SelectedIndex = -1 Then
            Exit Sub
        End If

        chkNew.Checked = False
        loadSelectedRecord()
        grpEdit.Enabled = True
    End Sub

    Private Sub loadSelectedRecord()
        Try
            objroles.getRoleByRoleID(lstRoles.SelectedItem - 1.ToString)
            With objroles.CurrentObject
                lstRoles.Items.Add(.RoleID)

            End With
        Catch ex As Exception
            MessageBox.Show("Error displaying data" & ex.ToString, " Error loading", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub chkNew_CheckedChanged(sender As Object, e As EventArgs) Handles chkNew.CheckedChanged
        If blnClearing Then
            Exit Sub

        End If

        If chkNew.Checked Then
            tslStatus.Text = " "
            txtRoleID.Clear()
            txtDesc.Clear()
            lstRoles.SelectedIndex = -1
            grpRoles.Enabled = False
            grpEdit.Enabled = True

            txtRoleID.Focus()
            objroles.CreateNewRole()
        Else
            grpRoles.Enabled = True
            grpEdit.Enabled = False
            grpMembers.Enabled = False
            objroles.CurrentObject.isNewRole = False

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean

        tslStatus.Text = " "
        ' add you validation code here

        If Not ValidateTextBoxLength(txtRoleID, errP) Then
            blnErrors = True
        End If

        If Not ValidateTextBoxLength(txtDesc, errP) Then
            blnErrors = True
        End If

        If blnErrors Then
            Exit Sub
        End If

        With objroles.CurrentObject
            .RoleID = txtRoleID.Text
            .RoleDescription = txtDesc.Text
        End With

        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objroles.save
            If intResult = 1 Then
                tslStatus.Text = " Role Record saved"
            End If

            If intResult = -1 Then ' role id is not uni
                MessageBox.Show("Role ID must be unique , unaable to save record", "Info error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tslStatus.Text = "Error"
            End If
        Catch ex As Exception
            MessageBox.Show(" unaable to save record :" & ex.ToString, "Info error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tslStatus.Text = "Error"
        End Try

        Me.Cursor = Cursors.Default
        blnReloading = True
        loadRoles()  ' reload so that a newly saved record will apear in the list
        chkNew.Checked = False

        grpRoles.Enabled = True ' in case it was disabled for a new record
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnClearing = True
        tslStatus.Text = " "
        chkNew.Checked = False

        errP.Clear()

        If lstRoles.SelectedIndex <> -1 Then
            loadSelectedRecord() ' reload what was selected in case user had messed up the form 
        Else
            grpEdit.Enabled = False

        End If

        blnClearing = False
        objroles.CurrentObject.isNewRole = False
        grpRoles.Enabled = True

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        '  objAdd.ShowDialog()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim roleReport As New frmRoleReport3
        If lstRoles.Items.Count = 0 Then
            MessageBox.Show("There are no records to print")
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        roleReport.display()
        Me.Cursor = Cursors.Default

    End Sub
End Class