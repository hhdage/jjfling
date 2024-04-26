<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aboutme
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.authorValueLabel = New System.Windows.Forms.Label()
        Me.authorLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'authorValueLabel
        '
        Me.authorValueLabel.AutoSize = True
        Me.authorValueLabel.Location = New System.Drawing.Point(70, 66)
        Me.authorValueLabel.Name = "authorValueLabel"
        Me.authorValueLabel.Size = New System.Drawing.Size(35, 12)
        Me.authorValueLabel.TabIndex = 0
        Me.authorValueLabel.Text = "huhao"
        '
        'authorLabel
        '
        Me.authorLabel.AutoSize = True
        Me.authorLabel.Location = New System.Drawing.Point(70, 42)
        Me.authorLabel.Name = "authorLabel"
        Me.authorLabel.Size = New System.Drawing.Size(29, 12)
        Me.authorLabel.TabIndex = 1
        Me.authorLabel.Text = "作者"
        '
        'Aboutme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 161)
        Me.Controls.Add(Me.authorLabel)
        Me.Controls.Add(Me.authorValueLabel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Aboutme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "关于huhao"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents authorValueLabel As Label
    Friend WithEvents authorLabel As Label
End Class
