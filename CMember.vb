Imports System.Data.SqlClient

Public Class CMember
    Private _mstrPID As String
    Private _mstrFName As String
    Private _mstrLName As String
    Private _mstrMI As String
    Private _mstrEmail As String
    Private _mstrPhone As String
    Private _isNewMember As Boolean
    Private _mstrPhoto As String    'photo path?


    Public Sub New()
        _mstrPID = 0
        _mstrFName = ""
        _mstrLName = ""
        _mstrMI = ""
        _mstrEmail = ""
        _mstrPhone = 0
        _mstrPhoto = ""
    End Sub

#Region "Exposed Properties"
    Public Property PID As String
        Get
            Return _mstrPID
        End Get
        Set(strValue As String)
            _mstrPID = strValue
        End Set
    End Property
    Public Property FName As String
        Get
            Return _mstrFName
        End Get
        Set(strValue As String)
            _mstrFName = strValue
        End Set
    End Property
    Public Property LName As String
        Get
            Return _mstrLName
        End Get
        Set(strValue As String)
            _mstrLName = strValue
        End Set
    End Property
    Public Property MI As String
        Get
            Return _mstrMI
        End Get
        Set(strValue As String)
            _mstrMI = strValue
        End Set
    End Property
    Public Property Email As String
        Get
            Return _mstrEmail
        End Get
        Set(strValue As String)
            _mstrEmail = strValue
        End Set
    End Property
    Public Property Phone As String
        Get
            Return _mstrPhone
        End Get
        Set(strValue As String)
            _mstrPhone = strValue
        End Set
    End Property
    Public Property Photo As String
        Get
            Return _mstrPhoto
        End Get
        Set(strValue As String)
            _mstrPhoto = strValue
        End Set
    End Property
    Public Property IsNewMember As Boolean
        Get
            Return _isNewMember
        End Get
        Set(blnVal As Boolean)
            _isNewMember = blnVal
        End Set
    End Property
    Public ReadOnly Property GetSaveParamters() As ArrayList
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("PID", _mstrPID))
            params.Add(New SqlParameter("FName", _mstrFName))
            params.Add(New SqlParameter("LName", _mstrLName))
            params.Add(New SqlParameter("MI", _mstrMI))
            params.Add(New SqlParameter("Email", _mstrEmail))
            params.Add(New SqlParameter("Phone", _mstrPhone))
            params.Add(New SqlParameter("PhotoPath", _mstrPhoto))
            Return params
        End Get
    End Property
#End Region

    Public Function Save() As Integer
        If IsNewMember Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("PID", _mstrPID))
            Dim strResult As String = myDB.getSingleValueFromSP("sp_CheckPIDExists", params)
            If Not strResult = 0 Then
                Return -1
            End If
        End If
        Return myDB.execSP("sp_saveMember", GetSaveParamters())
    End Function

    Public Function GetReportData() As SqlDataAdapter
        Return myDB.getDataAdapterBySp("sp_getAllMembers", Nothing)
    End Function
End Class

