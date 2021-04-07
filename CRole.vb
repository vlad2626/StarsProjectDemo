﻿Imports System.Data.SqlClient
Public Class CRole
    'Represents a single record in the role table

    Private _mstrRoleID As String
    Private _mstrRoleDescription As String
    Private _isNewRole As Boolean

    'constructor

    Public Sub New()
        _mstrRoleID = " "
        _mstrRoleDescription = " "

    End Sub

#Region " exposed properties"
    Public Property RoleID As String
        Get
            Return _mstrRoleID
        End Get
        Set(strVal As String)
            _mstrRoleID = strVal
        End Set
    End Property

    Public Property RoleDescription As String
        Get
            Return _mstrRoleDescription
        End Get
        Set(strVal As String)
            _mstrRoleDescription = strVal
        End Set
    End Property

    Public Property isNewRole As Boolean
        Get
            Return isNewRole
        End Get
        Set(blnVal As Boolean)
            _isNewRole = blnVal
        End Set
    End Property

    Public ReadOnly Property getSaveParameters As ArrayList
        ' this properties code will create the parameters for the stored procedure to save a record
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("roleID", _mstrRoleID))
            params.Add(New SqlParameter("roleDescription", _mstrRoleDescription))
            Return params
        End Get
    End Property

#End Region
    Public Function save() As Integer
        ' return -1 if the id already exist and we cannot create a new record with duplicate id 
        If isNewRole Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("roleID", _mstrRoleID))
            Dim strResult As String = myDB.getSingleValueFromSP("sp_CheckRoleIDExist", params)
            If Not strResult = 0 Then
                Return -1 ' not unique
            End If
        End If
        'if not a new role it, or it is new and has a unique id then do the save, update or insert
        Return myDB.execSP("sp_saveRole", getSaveParameters())
    End Function
End Class
