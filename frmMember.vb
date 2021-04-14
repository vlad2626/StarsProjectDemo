Imports System.Data.SqlClient
Public Class frmMember
    Private objSemester As CSemester
    Private objRoles As CRoles
    ' once a user is adding a member , check to see if the member has one or more roles, if its more than one. maybe use an array to store the data
    ' create a loop that will get each role one by one, and add it to the table
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'once  a user clicks it will show roles tab again.
        Me.Hide()

    End Sub

    Private Sub frmMember_Load(sender As Object, e As EventArgs) Handles Me.Load
        objSemester = New CSemester(Nothing)
        objRoles = New CRoles
        clearScreenCOntrols(Me)
        loadSemester()
        loadRoles()


    End Sub


    Private Sub loadRoles()
        Dim objDR As SqlDataReader
        'this loop right here should load the roles if its not loaded already
        If clbRole.Items.Count = 0 Then
            Try
                objDR = objRoles.getAllRoles
                Do While objDR.Read
                    clbRole.Items.Add(objDR.Item("RoleDescription"))
                Loop
                objDR.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub loadSemester()
        Dim objDR As SqlDataReader

        If clbSemester.Items.Count = 0 Then


            Try
                objDR = objSemester.getAllSemester()
                Do While objDR.Read
                    clbSemester.Items.Add(objDR.Item("SemesterDescription"))
                Loop

                objDR.Close()

            Catch ex As Exception
                ' could have CDB throw the error and trap it here
            End Try
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim blnError As Boolean
        If Not ValidateTextBoxLength(tbEmail, errP) Then
            blnError = True
            errP.SetError(tbEmail, "you must enter a valid email")
        End If
        If Not ValidateTextBoxLength(tbName, errP) Then
            blnError = True
            errP.SetError(tbName, "you must enter a valid  First name Name")
        End If
        If Not ValidateTextBoxLength(tbLastName, errP) Then
            blnError = True
        End If

    End Sub
End Class