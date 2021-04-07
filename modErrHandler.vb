Module modErrHandler
    'usefull routines for input validation
    Public Function ValidateTextBoxLength(ByRef obj As TextBox, ByRef errP As ErrorProvider) As Boolean
        'this procedure validates that a text box is not empty
        If obj.Text.Length = 0 Then
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            errP.SetError(obj, "You must enter a Value here")
            obj.Focus()
            Return False
        Else
            errP.SetError(obj, "")
            Return True


        End If
    End Function

    Public Function ValidateTextBoxNumeric(ByRef obj As TextBox, ByRef errP As ErrorProvider) As Boolean
        ' this validates that a text box is numeric only 
        If Not IsNumeric(obj.Text) Then
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            errP.SetError(obj, "you must enter a numeric value here")
            obj.Focus()
            Return False
        Else
            errP.SetError(obj, "")
            Return True

        End If
    End Function

    Public Function ValidateTextBoxDate(ByRef obj As TextBox, ByRef errP As ErrorProvider) As Boolean
        'this procedure validas that a textbox as a valid date
        If Not IsDate(obj.Text) Then
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            errP.SetError(obj, "you must enter a valid date  value here")
            obj.Focus()
            Return False
        Else
            errP.SetError(obj, "")
            Return True
        End If
    End Function

    Public Function ValidateCombo(ByRef obj As ComboBox, ByRef errP As ErrorProvider) As Boolean
        'this procedure validas that a textbox as a valid date
        If obj.SelectedIndex Then
            errP.SetError(obj, "you must make a selection here")
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            obj.Focus()
            Return False
        Else
            errP.SetError(obj, "")
            Return True
        End If
    End Function

    Public Function ValidateMaskedTextBoxLenght(ByRef obj As MaskedTextBox, ByRef errP As ErrorProvider) As Boolean
        'this procedure validas that a textbox as a valid date
        If obj.Text.Length = 0 Then
            errP.SetError(obj, "you must make a selection here")
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            obj.Focus()
            Return False
        Else
            errP.SetError(obj, "")
            Return True
        End If
    End Function
End Module
