Imports System.Data.SqlClient
Public Class Member
    'member table 
    Private _Member As Member

    Public Sub New(member As Member)
        _Member = member
    End Sub

    Public ReadOnly Property currentObject() As Member
        Get
            Return _Member
        End Get
    End Property
    Public Sub clear()
        '_Member = New member
    End Sub

    Public Function getAllMembers() As SqlDataReader
        Dim objDr As SqlDataReader
        objDr = myDB.getDataReaderBySP("sp_getAllMembers", Nothing)
        Return objDr
    End Function


End Class
