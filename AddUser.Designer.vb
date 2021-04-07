<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.tbMI = New System.Windows.Forms.TextBox()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.tbPhotoPath = New System.Windows.Forms.TextBox()
        Me.msbPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.msbPid = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(284, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 78)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add a new user"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(135, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(135, 456)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PhotoPath"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(135, 402)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 30)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(135, 359)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 30)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "PhoneNumber"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(135, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 30)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Email:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(135, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 30)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "LastName:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(135, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 30)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "MI"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.IndianRed
        Me.btnClose.Location = New System.Drawing.Point(522, 537)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(121, 49)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightGreen
        Me.btnSave.Location = New System.Drawing.Point(306, 537)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 49)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(310, 179)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(371, 20)
        Me.tbName.TabIndex = 11
        '
        'tbMI
        '
        Me.tbMI.Location = New System.Drawing.Point(310, 224)
        Me.tbMI.MaxLength = 2
        Me.tbMI.Name = "tbMI"
        Me.tbMI.Size = New System.Drawing.Size(43, 20)
        Me.tbMI.TabIndex = 12
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(306, 268)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(371, 20)
        Me.tbLastName.TabIndex = 13
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(306, 315)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(371, 20)
        Me.tbEmail.TabIndex = 14
        '
        'tbPhotoPath
        '
        Me.tbPhotoPath.Location = New System.Drawing.Point(306, 456)
        Me.tbPhotoPath.Name = "tbPhotoPath"
        Me.tbPhotoPath.Size = New System.Drawing.Size(371, 20)
        Me.tbPhotoPath.TabIndex = 15
        '
        'msbPhoneNumber
        '
        Me.msbPhoneNumber.Location = New System.Drawing.Point(309, 375)
        Me.msbPhoneNumber.Mask = "(999) 000-0000"
        Me.msbPhoneNumber.Name = "msbPhoneNumber"
        Me.msbPhoneNumber.Size = New System.Drawing.Size(256, 20)
        Me.msbPhoneNumber.TabIndex = 16
        '
        'msbPid
        '
        Me.msbPid.Location = New System.Drawing.Point(309, 421)
        Me.msbPid.Mask = "00000"
        Me.msbPid.Name = "msbPid"
        Me.msbPid.Size = New System.Drawing.Size(213, 20)
        Me.msbPid.TabIndex = 17
        Me.msbPid.ValidatingType = GetType(Integer)
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.msbPid)
        Me.Controls.Add(Me.msbPhoneNumber)
        Me.Controls.Add(Me.tbPhotoPath)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.tbLastName)
        Me.Controls.Add(Me.tbMI)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddUser"
        Me.Size = New System.Drawing.Size(993, 666)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents tbName As TextBox
    Friend WithEvents tbMI As TextBox
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents tbPhotoPath As TextBox
    Friend WithEvents msbPhoneNumber As MaskedTextBox
    Friend WithEvents msbPid As MaskedTextBox
End Class
