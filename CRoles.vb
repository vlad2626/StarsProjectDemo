Imports System.Data.SqlClient

Public Class CRoles
    ' represents the role table and its associated bussiness rules

    Private _Role As CRole
    'constructor

    Public Sub New()
        'instantiate the cRole object
        _Role = New CRole
    End Sub

    Public ReadOnly Property CurrentObject() As CRole
        Get
            Return _Role
        End Get
    End Property

    Public Sub clear()
        _Role = New CRole
    End Sub

    Public Sub CreateNewRole()
        'call this when clearing the edit portion of the screen to add a new role
        clear()
        _Role.isNewRole = True

    End Sub

    Public Function save() As Integer
        Return _Role.save
    End Function

    Public Function getAllRoles() As SqlDataReader
        Dim objDR As SqlDataReader
        objDR = myDB.getDataReaderBySP("sp_GetAllRoles", Nothing)
        Return objDR
    End Function


    Public Function getRoleByRoleID(strID As String) As CRole
        Dim params As New ArrayList
        ' Dim objDR As SqlDataReader

        params.Add(New SqlParameter("RoleID", strID))
        'objDR = myDB.getDataReaderBySP("sp_GetRoleByRoleID", params)
        ' Return objDR

        FillObject(myDB.getDataReaderBySP("sp_GetRoleByRoleID", params))
        Return _Role
    End Function


    Private Function FillObject(objDR As SqlDataReader) As CRole
        If objDR.Read Then
            With _Role
                .RoleID = objDR.Item("RoleID")
                .RoleDescription = objDR.Item("RoleDescription")

            End With
        Else ' no data returned
            'nothing to do here
        End If
        objDR.Close()

        Return _Role
    End Function
End Class
