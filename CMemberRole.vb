Imports System.Data.SqlClient
Public Class CMemberRole
    Private _MemberRole As CMemberRole
    Private _member As CMember
    Private _mstrRoleID As String
    Private _mstrSemesterID As String
    Private _mstrPID As Integer


    Public Sub New()
        _mstrPID = 4481
        _mstrRoleID = ""
        _mstrSemesterID = ""
    End Sub

    Public Property RoleID As String
        Get
            Return _mstrRoleID
        End Get
        Set(strVal As String)
            _mstrRoleID = strVal
        End Set
    End Property

    Public Property PID As String
        Get
            Return _mstrPID
        End Get
        Set(value As String)
            _mstrPID = value
        End Set
    End Property

    Public Property SemesterID As String
        Get
            Return _mstrSemesterID
        End Get
        Set(value As String)
            _mstrSemesterID = value
        End Set
    End Property



    Public Function getAll(strVal As String, strSem As String) As SqlDataReader
        Dim objDr As SqlDataReader
        Dim params As New ArrayList

        params.Add(New SqlParameter("LName", strVal))
        params.Add(New SqlParameter("SemesterID", strSem))

        objDr = myDB.getDataReaderBySP("sp_loadAll23", params)
        Return objDr
    End Function

    Private Function FillObject(objDR As SqlDataReader) As CMemberRole

        If objDR.Read Then
            With _MemberRole
                .PID = objDR.Item("PID")
                .RoleID = objDR.Item("RoleID")

                .SemesterID = objDR.Item("SemesterID")


            End With
        Else ' no data returned
            'nothing to do here
        End If
        objDR.Close()

        Return _MemberRole
    End Function

    Public Function FillObjectMember(objDR As SqlDataReader) As CMemberRole


        If objDR.Read Then
            With _MemberRole

                .PID = objDR.Item("PID")





            End With
        Else ' no data returned
            'nothing to do here
        End If
        objDR.Close()

        Return _MemberRole
    End Function


    Public Function getRoleByRoleID(strID As String) As CMemberRole
        Dim params As New ArrayList
        ' Dim objDR As SqlDataReader

        params.Add(New SqlParameter("PID", strID))
        'objDR = myDB.getDataReaderBySP("sp_GetRoleByRoleID", params)
        ' Return objDR

        FillObject(myDB.getDataReaderBySP("sp_GetMemberByPID", params))
        Return _MemberRole
    End Function

    Public Function loadInfo(StrName As String)
        Dim params As New ArrayList

        params.Add(New SqlParameter("LName", StrName))


        FillObject(myDB.getDataReaderBySP("sp_roles", params))
        Return _MemberRole
    End Function


    Public Function loadAllInfo(strName As String) As CMemberRole
        Dim params As New ArrayList
        params.Add(New SqlParameter("LName", strName))
        FillObject(myDB.getDataReaderBySP("sp_GetAllRoles", Nothing))
        Return _MemberRole
    End Function
    Public Function getRoleByLastName(strName As String) As CMemberRole
        Dim params As New ArrayList


        params.Add(New SqlParameter("LName", strName))


        FillObject(myDB.getDataReaderBySP("sp_GetMemberByLastName", params))
        Return _MemberRole
    End Function



    Public Function SaveRoles(strPID As String, strRoleID As String, strSemester As String)
        Dim objDr As SqlDataAdapter
        Dim params As New ArrayList
        params.Add(New SqlParameter("PID", strPID))
        params.Add(New SqlParameter("RoleID", strRoleID))
        params.Add(New SqlParameter("SemesterID", strSemester))
        'objDr = myDB.getDataAdapterBySp("sp_SaveMemberRole", params)
        myDB.execSP("sp_SaveMemberRole", params)
        Return objDr
    End Function

    Public Function removeRole(strPID As String, strRoleID As String, strSemester As String)
        Dim objDr As SqlDataAdapter
        Dim params As New ArrayList
        params.Add(New SqlParameter("PID", strPID))
        params.Add(New SqlParameter("RoleID", strRoleID))
        params.Add(New SqlParameter("SemesterID", strSemester))
        myDB.execSP("sp_deleteRole", params)


    End Function

    Public ReadOnly Property CurrentObject() As CMemberRole
        Get
            Return _MemberRole
        End Get
    End Property

    Public ReadOnly Property getSaveParameters() As ArrayList
        ' this properties code will create the parameters for the stored procedure to save a record
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("roleID", _mstrRoleID))
            params.Add(New SqlParameter("SemesterID", _mstrSemesterID))
            params.Add(New SqlParameter("PID", _mstrPID))

            Return params
        End Get
    End Property
End Class
