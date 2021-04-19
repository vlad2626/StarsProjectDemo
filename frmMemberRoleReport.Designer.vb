<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberRoleReport
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.CMemberRoleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRoleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rpvRoleReport = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.CMemberRoleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRoleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(615, 415)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(155, 29)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'CMemberRoleBindingSource
        '
        Me.CMemberRoleBindingSource.DataSource = GetType(StarsOrg.CMemberRole)
        '
        'CRoleBindingSource
        '
        Me.CRoleBindingSource.DataSource = GetType(StarsOrg.CRole)
        '
        'rpvRoleReport
        '
        Me.rpvRoleReport.Location = New System.Drawing.Point(28, 37)
        Me.rpvRoleReport.Name = "rpvRoleReport"
        Me.rpvRoleReport.ServerReport.BearerToken = Nothing
        Me.rpvRoleReport.Size = New System.Drawing.Size(741, 354)
        Me.rpvRoleReport.TabIndex = 2
        '
        'frmMemberRoleReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.rpvRoleReport)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmMemberRoleReport"
        Me.Text = "frmMemberRoleReport"
        CType(Me.CMemberRoleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRoleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMemberRoleBindingSource As BindingSource
    Friend WithEvents btnClose As Button
    Friend WithEvents CRoleBindingSource As BindingSource
    Friend WithEvents rpvRoleReport As Microsoft.Reporting.WinForms.ReportViewer
End Class
