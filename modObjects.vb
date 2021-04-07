Module modObjects
    Public Sub clearScreenCOntrols(ByVal objContainer As Control)
        ' this procedure will clear all controls on the form passed in as the argument
        'not all controls tupes have been implemented here - add ass needed.
        Dim obj As Control
        Dim strControlType As String
        For Each obj In objContainer.Controls
            strControlType = TypeName(obj) ' this returns the classname of the control
            Select Case strControlType
                Case "TextBox"
                    Dim cntrl As TextBox
                    cntrl = DirectCast(obj, TextBox)
                    cntrl.Clear()
                Case "CheckBox"
                    Dim cntrl As CheckBox
                    cntrl = DirectCast(obj, CheckBox)
                    cntrl.Checked = False
                Case "ComboBox"
                    Dim cntrl As ComboBox
                    cntrl = DirectCast(obj, ComboBox)
                    cntrl.SelectedIndex = -1
                Case "RadioButton"
                    Dim cntrl As RadioButton
                    cntrl = DirectCast(obj, RadioButton)
                    cntrl.Checked = False
                Case "MaskedTextBox"
                    Dim cntrl As MaskedTextBox
                    cntrl = DirectCast(obj, MaskedTextBox)
                    cntrl.Clear()
                Case "GroupBox"
                    'must recurse trough its controls collection
                    Dim cntrl As GroupBox
                    cntrl = DirectCast(obj, GroupBox)
                    clearScreenCOntrols(cntrl)
                Case Else
                    'do nothng or add error trapping code here
            End Select
        Next

    End Sub
End Module
