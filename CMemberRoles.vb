Imports System.Data.SqlClient
Public Class CMemberRoles
    Private _MemberRole As CMemberRole






    Public Sub New()
        'instantiate the Roles object object
        _MemberRole = New CMemberRole
    End Sub





    Public Function getAllMemberRolesBySemester(strLName As String, strSem As String) As SqlDataReader ' working as sql data read
        Dim objDr As SqlDataReader
        Dim params As New ArrayList

        params.Add(New SqlParameter("LName", strLName))
        params.Add(New SqlParameter("SemesterID", strSem))
        objDr = myDB.getDataReaderBySP("sp_loadAllMemberRolesBySemester", params)
        'FillObject(myDB.getDataReaderBySP("sp_loadAllMemberRolesBySemester", params))
        Return objDr   'curent working way
        'Return _MemberRole
    End Function

    Private Function FillObject(objDR As SqlDataReader) As CMemberRole
        If objDR.Read Then
            With _MemberRole
                .PID = objDR.Item("PID")
                .RoleID = objDR.Item("RoleID")
                .SemesterID = objDR.Item("SemesterID")
            End With
        Else

        End If
        objDR.Close()

        Return _MemberRole
    End Function



    Public Function getAllRoles()
        Dim objDR As SqlDataReader
        objDR = myDB.getDataReaderBySP("sp_GetAllRoles", Nothing)
        Return objDR
    End Function

    Public Function getRoleByRoleID(strID As String) As CMemberRole
        Dim params As New ArrayList
        ' Dim objDR As SqlDataReader

        params.Add(New SqlParameter("PID", strID))
        FillObject(myDB.getDataReaderBySP("sp_GetRoleByRoleID", params))
        ' Return objDR

        '  FillObject(myDB.getDataReaderBySP("getAllMemberRoles", Nothing))
        Return _MemberRole
    End Function







    Public Function getRoleByLastName(strName As String, strSemester As String) As SqlDataReader
        Dim params As New ArrayList
        Dim objDR As SqlDataReader
        params.Add(New SqlParameter("LName", strName))
        params.Add(New SqlParameter("SemesterID", strSemester))
        objDR = myDB.getDataReaderBySP("sp_loadAllMemberRolesBySemester", params)
        Return objDR

    End Function

    Public Function getSemesterBySemesterID(strSem As String)
        Dim objDr As SqlDataReader
        Dim params As New ArrayList
        params.Add(New SqlParameter("SemesterDescription", strSem))
        objDr = myDB.getDataReaderBySP("sp_GeSemesterBySemesterID", params)
        Return objDr
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

        Return objDr
    End Function

    Public ReadOnly Property CurrentObject() As CMemberRole
        Get
            Return _MemberRole
        End Get
    End Property


    Public Function save() As Integer
        Return _MemberRole.save
    End Function



    Public Function getReportData() As SqlDataAdapter
        Return myDB.getDataAdapterBySp("dbo.sp_LoadAllMemberRoles", Nothing)
    End Function

End Class
