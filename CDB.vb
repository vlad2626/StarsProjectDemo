Imports System.Data.SqlClient

Public Class CDB
    Public Function OpenDB() As Boolean
        objSQLCommand = New SqlCommand ' instantiate the command object
        Dim blnResult As Boolean

        If objSQLConn Is Nothing Then ' we need to instantiate the connection object
            Try
                objSQLConn = New SqlConnection(gstrConn)
                objSQLConn.Open()
                blnResult = True

            Catch exOpenConnError As Exception

                MessageBox.Show("Cannot open database" & exOpenConnError.ToString, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                blnResult = False ' you should log this error.
            End Try

        Else
            If objSQLConn.State = ConnectionState.Open Then
                Return True

            Else
                Return False
            End If
        End If
        Return blnResult
    End Function


    Public Sub CloseDB()
        Try
            objSQLConn.Close() ' close the connection 
        Catch ex As Exception
            MessageBox.Show("errror attemting to close database" & ex.ToString, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Function getDataReaderBySP(ByVal strSP As String, ByRef params As ArrayList) As SqlDataReader
        If Not OpenDB() Then
            ' should error log this problem 

            Return Nothing

        End If

        objSQLCommand = New SqlCommand(strSP, objSQLConn)
        objSQLCommand.CommandType = CommandType.StoredProcedure

        If Not params Is Nothing Then ' add eacj parameter into the command object

            For Each p As SqlParameter In params
                objSQLCommand.Parameters.Add(p)
            Next

        End If
        Try
            Return objSQLCommand.ExecuteReader
        Catch ex As Exception
            MessageBox.Show("failed to get data reader" & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function

    Public Function getDataAdapterBySp(ByVal strSP As String, ByRef params As ArrayList) As SqlDataAdapter
        objSQLCommand = New SqlCommand(strSP, objSQLConn)
        Dim sqlDa As SqlDataAdapter
        objSQLCommand.CommandType = CommandType.StoredProcedure
        If Not params Is Nothing Then
            For Each p As SqlParameter In params
                objSQLCommand.Parameters.Add(p)
            Next
        End If
        Try
            sqlDa = New SqlDataAdapter(objSQLCommand)
            Return sqlDa
        Catch ex As Exception
            MessageBox.Show("failed to get data adapter" & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function

    Public Function execSP(ByVal strSP As String, ByRef params As ArrayList) As Integer
        If Not OpenDB() Then
            Return -1
        End If

        objSQLCommand = New SqlCommand(strSP, objSQLConn)
        objSQLCommand.CommandType = CommandType.StoredProcedure
        Try
            If Not params Is Nothing Then
                For Each p As SqlParameter In params
                    objSQLCommand.Parameters.Add(p)
                Next
            End If
            Return objSQLCommand.ExecuteNonQuery

        Catch ex As Exception
            MessageBox.Show("Error Excuting sp" & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

    Public Function getSingleValueFromSP(ByVal strSP As String, ByRef params As ArrayList) As String
        Dim sqlDR As SqlDataReader = getDataReaderBySP(strSP, params)
        Dim strResult As String

        If Not sqlDR Is Nothing Then ' we got a data reader
            If sqlDR.Read Then ' we have some data
                strResult = sqlDR.GetValue(0).ToString
                sqlDR.Close()
                Return strResult
            Else
                Return "-1"
            End If
        End If

        Return "-2" ' failed to connect or get a data reader

    End Function
End Class
