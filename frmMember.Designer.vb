<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMember
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.msbPid = New System.Windows.Forms.MaskedTextBox()
        Me.msbPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.tbPhotoPath = New System.Windows.Forms.TextBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.tbMI = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpRole = New System.Windows.Forms.GroupBox()
        Me.GrpSemester = New System.Windows.Forms.GroupBox()
        Me.clbRole = New System.Windows.Forms.CheckedListBox()
        Me.clbSemester = New System.Windows.Forms.CheckedListBox()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRole.SuspendLayout()
        Me.GrpSemester.SuspendLayout()
        Me.SuspendLayout()
        '
        'msbPid
        '
        Me.msbPid.Location = New System.Drawing.Point(202, 349)
        Me.msbPid.Mask = "00000"
        Me.msbPid.Name = "msbPid"
        Me.msbPid.Size = New System.Drawing.Size(213, 20)
        Me.msbPid.TabIndex = 34
        Me.msbPid.ValidatingType = GetType(Integer)
        '
        'msbPhoneNumber
        '
        Me.msbPhoneNumber.Location = New System.Drawing.Point(202, 306)
        Me.msbPhoneNumber.Mask = "(999) 000-0000"
        Me.msbPhoneNumber.Name = "msbPhoneNumber"
        Me.msbPhoneNumber.Size = New System.Drawing.Size(256, 20)
        Me.msbPhoneNumber.TabIndex = 33
        '
        'tbPhotoPath
        '
        Me.tbPhotoPath.Location = New System.Drawing.Point(202, 393)
        Me.tbPhotoPath.Name = "tbPhotoPath"
        Me.tbPhotoPath.Size = New System.Drawing.Size(371, 20)
        Me.tbPhotoPath.TabIndex = 32
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(202, 252)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(371, 20)
        Me.tbEmail.TabIndex = 31
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(202, 199)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(143, 20)
        Me.tbLastName.TabIndex = 30
        '
        'tbMI
        '
        Me.tbMI.Location = New System.Drawing.Point(202, 157)
        Me.tbMI.MaxLength = 2
        Me.tbMI.Name = "tbMI"
        Me.tbMI.Size = New System.Drawing.Size(43, 20)
        Me.tbMI.TabIndex = 29
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(202, 114)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(143, 20)
        Me.tbName.TabIndex = 28
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightGreen
        Me.btnSave.Location = New System.Drawing.Point(71, 508)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 49)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.IndianRed
        Me.btnClose.Location = New System.Drawing.Point(269, 508)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(121, 49)
        Me.btnClose.TabIndex = 26
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(53, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 30)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "MI"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(53, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 30)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "LastName:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(53, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 30)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Email:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(53, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 30)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "PhoneNumber"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(53, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 30)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "PID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(53, 393)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 30)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "PhotoPath"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(53, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 30)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "First Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(345, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 78)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Add a new user"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'grpRole
        '
        Me.grpRole.Controls.Add(Me.clbRole)
        Me.grpRole.Location = New System.Drawing.Point(675, 122)
        Me.grpRole.Name = "grpRole"
        Me.grpRole.Size = New System.Drawing.Size(380, 174)
        Me.grpRole.TabIndex = 35
        Me.grpRole.TabStop = False
        Me.grpRole.Text = "Role"
        '
        'GrpSemester
        '
        Me.GrpSemester.Controls.Add(Me.clbSemester)
        Me.GrpSemester.Location = New System.Drawing.Point(675, 339)
        Me.GrpSemester.Name = "GrpSemester"
        Me.GrpSemester.Size = New System.Drawing.Size(383, 165)
        Me.GrpSemester.TabIndex = 36
        Me.GrpSemester.TabStop = False
        Me.GrpSemester.Text = "Semester"
        '
        'clbRole
        '
        Me.clbRole.FormattingEnabled = True
        Me.clbRole.Location = New System.Drawing.Point(6, 29)
        Me.clbRole.Name = "clbRole"
        Me.clbRole.Size = New System.Drawing.Size(368, 139)
        Me.clbRole.TabIndex = 0
        '
        'clbSemester
        '
        Me.clbSemester.FormattingEnabled = True
        Me.clbSemester.Location = New System.Drawing.Point(6, 35)
        Me.clbSemester.Name = "clbSemester"
        Me.clbSemester.Size = New System.Drawing.Size(358, 124)
        Me.clbSemester.TabIndex = 0
        '
        'frmMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 620)
        Me.Controls.Add(Me.GrpSemester)
        Me.Controls.Add(Me.grpRole)
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
        Me.Name = "frmMember"
        Me.Text = "frmMember"
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRole.ResumeLayout(False)
        Me.GrpSemester.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msbPid As MaskedTextBox
    Friend WithEvents msbPhoneNumber As MaskedTextBox
    Friend WithEvents tbPhotoPath As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents tbMI As TextBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents GrpSemester As GroupBox
    Friend WithEvents grpRole As GroupBox
    Friend WithEvents clbSemester As CheckedListBox
    Friend WithEvents clbRole As CheckedListBox
End Class
