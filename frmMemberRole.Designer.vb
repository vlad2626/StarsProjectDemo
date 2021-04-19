<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMemberRole
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMemberRole))
        Me.grpMembers = New System.Windows.Forms.GroupBox()
        Me.lstMem = New System.Windows.Forms.ListBox()
        Me.grpSemester = New System.Windows.Forms.GroupBox()
        Me.cboSemester = New System.Windows.Forms.ComboBox()
        Me.grpRole = New System.Windows.Forms.GroupBox()
        Me.lstRole = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbMember = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRole = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEvent = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRSVP = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCourse = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSemester = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbTutor = New System.Windows.Forms.ToolStripButton()
        Me.tsbLogout = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.cbADD = New System.Windows.Forms.CheckBox()
        Me.btnAdding = New System.Windows.Forms.Button()
        Me.grpPID = New System.Windows.Forms.GroupBox()
        Me.cbPID = New System.Windows.Forms.ComboBox()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.grpMembers.SuspendLayout()
        Me.grpSemester.SuspendLayout()
        Me.grpRole.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.grpPID.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMembers
        '
        Me.grpMembers.Controls.Add(Me.lstMem)
        Me.grpMembers.Location = New System.Drawing.Point(12, 147)
        Me.grpMembers.Name = "grpMembers"
        Me.grpMembers.Size = New System.Drawing.Size(401, 377)
        Me.grpMembers.TabIndex = 0
        Me.grpMembers.TabStop = False
        Me.grpMembers.Text = "Members"
        '
        'lstMem
        '
        Me.lstMem.FormattingEnabled = True
        Me.lstMem.Location = New System.Drawing.Point(21, 36)
        Me.lstMem.Name = "lstMem"
        Me.lstMem.Size = New System.Drawing.Size(362, 290)
        Me.lstMem.TabIndex = 0
        '
        'grpSemester
        '
        Me.grpSemester.Controls.Add(Me.cboSemester)
        Me.grpSemester.Location = New System.Drawing.Point(711, 137)
        Me.grpSemester.Name = "grpSemester"
        Me.grpSemester.Size = New System.Drawing.Size(340, 198)
        Me.grpSemester.TabIndex = 1
        Me.grpSemester.TabStop = False
        Me.grpSemester.Text = "Semester"
        '
        'cboSemester
        '
        Me.cboSemester.FormattingEnabled = True
        Me.cboSemester.Location = New System.Drawing.Point(24, 32)
        Me.cboSemester.Name = "cboSemester"
        Me.cboSemester.Size = New System.Drawing.Size(288, 21)
        Me.cboSemester.TabIndex = 0
        '
        'grpRole
        '
        Me.grpRole.Controls.Add(Me.lstRole)
        Me.grpRole.Location = New System.Drawing.Point(711, 350)
        Me.grpRole.Name = "grpRole"
        Me.grpRole.Size = New System.Drawing.Size(334, 164)
        Me.grpRole.TabIndex = 2
        Me.grpRole.TabStop = False
        Me.grpRole.Text = "Role"
        '
        'lstRole
        '
        Me.lstRole.CheckOnClick = True
        Me.lstRole.FormattingEnabled = True
        Me.lstRole.Location = New System.Drawing.Point(24, 27)
        Me.lstRole.Name = "lstRole"
        Me.lstRole.Size = New System.Drawing.Size(289, 124)
        Me.lstRole.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(261, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(606, 58)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MemberRoles"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator11, Me.tsbHome, Me.ToolStripSeparator9, Me.tsbMember, Me.ToolStripSeparator4, Me.tsbRole, Me.ToolStripSeparator3, Me.tsbEvent, Me.ToolStripSeparator5, Me.tsbRSVP, Me.ToolStripSeparator6, Me.tsbCourse, Me.ToolStripSeparator2, Me.tsbSemester, Me.ToolStripSeparator7, Me.tsbTutor, Me.tsbLogout, Me.ToolStripSeparator8, Me.tsbHelp, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1088, 50)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.AutoSize = False
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(10, 50)
        '
        'tsbHome
        '
        Me.tsbHome.AutoSize = False
        Me.tsbHome.BackgroundImage = Global.StarsOrg.My.Resources.Resources.home
        Me.tsbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHome.Name = "tsbHome"
        Me.tsbHome.Size = New System.Drawing.Size(48, 48)
        Me.tsbHome.Text = "HOME"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.AutoSize = False
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(10, 50)
        '
        'tsbMember
        '
        Me.tsbMember.AutoSize = False
        Me.tsbMember.BackgroundImage = Global.StarsOrg.My.Resources.Resources.member
        Me.tsbMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbMember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMember.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMember.Name = "tsbMember"
        Me.tsbMember.Size = New System.Drawing.Size(48, 48)
        Me.tsbMember.Text = "MEMBER"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(10, 50)
        '
        'tsbRole
        '
        Me.tsbRole.AutoSize = False
        Me.tsbRole.BackgroundImage = Global.StarsOrg.My.Resources.Resources.roles
        Me.tsbRole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRole.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRole.Name = "tsbRole"
        Me.tsbRole.Size = New System.Drawing.Size(48, 48)
        Me.tsbRole.Text = "ROLE"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(10, 50)
        '
        'tsbEvent
        '
        Me.tsbEvent.AutoSize = False
        Me.tsbEvent.BackgroundImage = Global.StarsOrg.My.Resources.Resources.events
        Me.tsbEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEvent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEvent.Name = "tsbEvent"
        Me.tsbEvent.Size = New System.Drawing.Size(48, 48)
        Me.tsbEvent.Text = "EVENT"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.AutoSize = False
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(10, 50)
        '
        'tsbRSVP
        '
        Me.tsbRSVP.AutoSize = False
        Me.tsbRSVP.BackgroundImage = Global.StarsOrg.My.Resources.Resources.rsvp
        Me.tsbRSVP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRSVP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRSVP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRSVP.Name = "tsbRSVP"
        Me.tsbRSVP.Size = New System.Drawing.Size(48, 48)
        Me.tsbRSVP.Text = "RSVP"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(10, 50)
        '
        'tsbCourse
        '
        Me.tsbCourse.AutoSize = False
        Me.tsbCourse.BackgroundImage = Global.StarsOrg.My.Resources.Resources.courses
        Me.tsbCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCourse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCourse.Name = "tsbCourse"
        Me.tsbCourse.Size = New System.Drawing.Size(48, 48)
        Me.tsbCourse.Text = "COURSE"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(10, 50)
        '
        'tsbSemester
        '
        Me.tsbSemester.AutoSize = False
        Me.tsbSemester.BackgroundImage = Global.StarsOrg.My.Resources.Resources.semesters
        Me.tsbSemester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbSemester.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSemester.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSemester.Name = "tsbSemester"
        Me.tsbSemester.Size = New System.Drawing.Size(48, 48)
        Me.tsbSemester.Text = "SEMESTER"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.AutoSize = False
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(10, 50)
        '
        'tsbTutor
        '
        Me.tsbTutor.AutoSize = False
        Me.tsbTutor.BackgroundImage = Global.StarsOrg.My.Resources.Resources.tutors
        Me.tsbTutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbTutor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbTutor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbTutor.Name = "tsbTutor"
        Me.tsbTutor.Size = New System.Drawing.Size(48, 48)
        Me.tsbTutor.Text = "TUTOR"
        '
        'tsbLogout
        '
        Me.tsbLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbLogout.AutoSize = False
        Me.tsbLogout.BackgroundImage = Global.StarsOrg.My.Resources.Resources.logout
        Me.tsbLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbLogout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLogout.Name = "tsbLogout"
        Me.tsbLogout.Size = New System.Drawing.Size(48, 48)
        Me.tsbLogout.Text = "LOGOUT"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator8.AutoSize = False
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(10, 50)
        '
        'tsbHelp
        '
        Me.tsbHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbHelp.AutoSize = False
        Me.tsbHelp.BackgroundImage = Global.StarsOrg.My.Resources.Resources.help
        Me.tsbHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHelp.Name = "tsbHelp"
        Me.tsbHelp.Size = New System.Drawing.Size(48, 48)
        Me.tsbHelp.Text = "HELP"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(10, 50)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 47)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'cbADD
        '
        Me.cbADD.AutoSize = True
        Me.cbADD.Location = New System.Drawing.Point(431, 377)
        Me.cbADD.Name = "cbADD"
        Me.cbADD.Size = New System.Drawing.Size(110, 17)
        Me.cbADD.TabIndex = 5
        Me.cbADD.Text = "ADD NEW ROLE"
        Me.cbADD.UseVisualStyleBackColor = True
        '
        'btnAdding
        '
        Me.btnAdding.Location = New System.Drawing.Point(789, 527)
        Me.btnAdding.Name = "btnAdding"
        Me.btnAdding.Size = New System.Drawing.Size(119, 31)
        Me.btnAdding.TabIndex = 6
        Me.btnAdding.Text = "ADD"
        Me.btnAdding.UseVisualStyleBackColor = True
        '
        'grpPID
        '
        Me.grpPID.Controls.Add(Me.cbPID)
        Me.grpPID.Enabled = False
        Me.grpPID.Location = New System.Drawing.Point(431, 160)
        Me.grpPID.Name = "grpPID"
        Me.grpPID.Size = New System.Drawing.Size(256, 154)
        Me.grpPID.TabIndex = 8
        Me.grpPID.TabStop = False
        Me.grpPID.Text = "PID"
        '
        'cbPID
        '
        Me.cbPID.FormattingEnabled = True
        Me.cbPID.Location = New System.Drawing.Point(21, 29)
        Me.cbPID.Name = "cbPID"
        Me.cbPID.Size = New System.Drawing.Size(226, 21)
        Me.cbPID.TabIndex = 0
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(940, 522)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(111, 36)
        Me.btnReport.TabIndex = 12
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'frmMemberRole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 712)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.grpPID)
        Me.Controls.Add(Me.btnAdding)
        Me.Controls.Add(Me.cbADD)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpRole)
        Me.Controls.Add(Me.grpSemester)
        Me.Controls.Add(Me.grpMembers)
        Me.Name = "frmMemberRole"
        Me.Text = "frmMemberRole"
        Me.grpMembers.ResumeLayout(False)
        Me.grpSemester.ResumeLayout(False)
        Me.grpRole.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpPID.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpMembers As GroupBox
    Friend WithEvents grpSemester As GroupBox
    Friend WithEvents grpRole As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstMem As ListBox
    Friend WithEvents lstRole As CheckedListBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents tsbHome As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents tsbMember As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsbRole As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbEvent As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsbRSVP As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tsbCourse As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbSemester As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents tsbTutor As ToolStripButton
    Friend WithEvents tsbLogout As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents tsbHelp As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents cbADD As CheckBox
    Friend WithEvents btnAdding As Button
    Friend WithEvents cboSemester As ComboBox
    Friend WithEvents grpPID As GroupBox
    Friend WithEvents cbPID As ComboBox
    Friend WithEvents btnReport As Button
End Class
