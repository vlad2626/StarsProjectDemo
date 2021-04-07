<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReport
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
        Me.rpvReport = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnCLose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rpvReport
        '
        Me.rpvReport.Location = New System.Drawing.Point(23, 12)
        Me.rpvReport.Name = "rpvReport"
        Me.rpvReport.ServerReport.BearerToken = Nothing
        Me.rpvReport.Size = New System.Drawing.Size(749, 382)
        Me.rpvReport.TabIndex = 0
        '
        'btnCLose
        '
        Me.btnCLose.Location = New System.Drawing.Point(601, 414)
        Me.btnCLose.Name = "btnCLose"
        Me.btnCLose.Size = New System.Drawing.Size(171, 35)
        Me.btnCLose.TabIndex = 1
        Me.btnCLose.Text = "CLose"
        Me.btnCLose.UseVisualStyleBackColor = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCLose)
        Me.Controls.Add(Me.rpvReport)
        Me.Name = "frmReport"
        Me.Text = "Role Report"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rpvReport As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnCLose As Button
End Class
