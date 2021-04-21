Imports System.Data.SqlClient

Public Class CMembers
    Private _Member As CMember

    Public Sub New()
        _Member = New CMember
    End Sub

    Public ReadOnly Property CurrentObject() As CMember
        Get
            Return _Member
        End Get
    End Property

    Public Sub Clear()
        _Member = New CMember
    End Sub

    Public Sub CreateNewMember()
        Clear()
        _Member.IsNewMember = True
    End Sub

    Public Function Save() As Integer
        Return _Member.Save()
    End Function

    Public Function GetAllMembers() As SqlDataReader
        Dim objDR As SqlDataReader
        objDR = myDB.getDataReaderBySP("sp_getAllMembers", Nothing)
        Return objDR
    End Function

    Public Function GetMemberByPID(strPID As String) As CMember
        Dim params As New ArrayList
        Dim objDR As SqlDataReader
        params.Add(New SqlParameter("pID", strPID))
        FillObject(myDB.getDataReaderBySP("sp_getMemberByPID", params))
        Return _Member
    End Function

    Private Function FillObject(objDR As SqlDataReader) As CMember
        If objDR.Read Then
            With _Member
                .PID = objDR.Item("PID")
                .FName = objDR.Item("FName")
                .LName = objDR.Item("LName")
                .MI = objDR.Item("MI")
                .Email = objDR.Item("Email")
                .Phone = objDR.Item("Phone")
                .Photo = objDR.Item("PhotoPath")
            End With
        Else
        End If
        objDR.Close()
        Return _Member
    End Function
End Class
