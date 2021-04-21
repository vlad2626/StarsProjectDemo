Imports System.Data.SqlClient
Public Class CMemberRole
    Private _mstrRoleID As String
    Private _mstrSemesterID As String
    Private _mstrPID As String
    ' Private _cMemberRole As CMemberRole ' gotta change after we fix fill object

    Public Sub New()
        _mstrRoleID = ""
        _mstrSemesterID = ""
        _mstrPID = ""
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
        Set(strVal As String)
            _mstrPID = strVal
        End Set
    End Property


    Public Property SemesterID As String
        Get
            Return _mstrSemesterID
        End Get
        Set(strVal As String)
            _mstrSemesterID = strVal
        End Set
    End Property

    Public ReadOnly Property getSaveParameters() As ArrayList
        ' this properties code will create the parameters for the stored procedure to save a record
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("RoleID", _mstrRoleID))
            params.Add(New SqlParameter("SemesterID", _mstrSemesterID))
            params.Add(New SqlParameter("PID", _mstrPID))
            Return params
        End Get
    End Property

    Public Function save() As Integer
        Return myDB.execSP("sp_SaveMemberRole", getSaveParameters())

    End Function


End Class
