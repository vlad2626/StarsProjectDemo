Imports System.Data.SqlClient
Public Class CSemester

    Private _CSemester As CSemester

    Public Sub New(cSemester As CSemester)
        _CSemester = cSemester
    End Sub



    Public Function getAllSemester()
        Dim objDR As SqlDataReader
        objDR = myDB.getDataReaderBySP("sp_getAllSemester", Nothing)
        Return objDR
    End Function
End Class
