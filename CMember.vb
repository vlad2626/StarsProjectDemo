Imports System.Data.SqlClient

Public Class CMember
    Private _PID As String



    Public Sub New()
        _PID = ""

    End Sub


    Public Property PID As String
        Get
            Return _PID
        End Get
        Set(value As String)
            _PID = value
        End Set
    End Property


End Class
