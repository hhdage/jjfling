<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWinForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWinForm))
        Me.redBtn = New System.Windows.Forms.Button()
        Me.blueBtn = New System.Windows.Forms.Button()
        Me.greenBtn = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.fileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.editMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.settingMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newSubMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.openSubMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitSubMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusSubMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.optionSubMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.copySubMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pasteSubMeunItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.backSubMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutSubMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'redBtn
        '
        Me.redBtn.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.redBtn.ForeColor = System.Drawing.Color.Red
        Me.redBtn.Location = New System.Drawing.Point(425, 55)
        Me.redBtn.Name = "redBtn"
        Me.redBtn.Size = New System.Drawing.Size(100, 60)
        Me.redBtn.TabIndex = 0
        Me.redBtn.Text = "红色"
        Me.redBtn.UseVisualStyleBackColor = True
        '
        'blueBtn
        '
        Me.blueBtn.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.blueBtn.ForeColor = System.Drawing.Color.Blue
        Me.blueBtn.Location = New System.Drawing.Point(425, 133)
        Me.blueBtn.Name = "blueBtn"
        Me.blueBtn.Size = New System.Drawing.Size(100, 60)
        Me.blueBtn.TabIndex = 1
        Me.blueBtn.Text = "蓝色"
        Me.blueBtn.UseVisualStyleBackColor = True
        '
        'greenBtn
        '
        Me.greenBtn.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.greenBtn.ForeColor = System.Drawing.Color.Green
        Me.greenBtn.Location = New System.Drawing.Point(425, 211)
        Me.greenBtn.Name = "greenBtn"
        Me.greenBtn.Size = New System.Drawing.Size(100, 60)
        Me.greenBtn.TabIndex = 2
        Me.greenBtn.Text = "绿色"
        Me.greenBtn.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(34, 24)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(300, 300)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileMenuItem, Me.viewMenuItem, Me.editMenuItem, Me.settingMenuItem, Me.aboutMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MainMenu.Size = New System.Drawing.Size(584, 25)
        Me.MainMenu.TabIndex = 4
        Me.MainMenu.Text = "MainMenu"
        '
        'fileMenuItem
        '
        Me.fileMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newSubMenuItem, Me.openSubMenuItem, Me.exitSubMenuItem})
        Me.fileMenuItem.Name = "fileMenuItem"
        Me.fileMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.fileMenuItem.Text = "文件"
        '
        'viewMenuItem
        '
        Me.viewMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusSubMenuItem, Me.optionSubMenuItem})
        Me.viewMenuItem.Name = "viewMenuItem"
        Me.viewMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.viewMenuItem.Text = "视图"
        '
        'editMenuItem
        '
        Me.editMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.copySubMenuItem, Me.pasteSubMeunItem, Me.backSubMenuItem})
        Me.editMenuItem.Name = "editMenuItem"
        Me.editMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.editMenuItem.Text = "编辑"
        '
        'settingMenuItem
        '
        Me.settingMenuItem.Name = "settingMenuItem"
        Me.settingMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.settingMenuItem.Text = "设置"
        '
        'aboutMenuItem
        '
        Me.aboutMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aboutSubMenuItem})
        Me.aboutMenuItem.Name = "aboutMenuItem"
        Me.aboutMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.aboutMenuItem.Text = "关于"
        '
        'newSubMenuItem
        '
        Me.newSubMenuItem.Name = "newSubMenuItem"
        Me.newSubMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.newSubMenuItem.Text = "新建"
        '
        'openSubMenuItem
        '
        Me.openSubMenuItem.Name = "openSubMenuItem"
        Me.openSubMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.openSubMenuItem.Text = "打开"
        '
        'exitSubMenuItem
        '
        Me.exitSubMenuItem.Name = "exitSubMenuItem"
        Me.exitSubMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.exitSubMenuItem.Text = "退出"
        '
        'statusSubMenuItem
        '
        Me.statusSubMenuItem.Name = "statusSubMenuItem"
        Me.statusSubMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.statusSubMenuItem.Text = "状态栏"
        '
        'optionSubMenuItem
        '
        Me.optionSubMenuItem.Name = "optionSubMenuItem"
        Me.optionSubMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.optionSubMenuItem.Text = "选项"
        '
        'copySubMenuItem
        '
        Me.copySubMenuItem.Name = "copySubMenuItem"
        Me.copySubMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.copySubMenuItem.Text = "复制"
        '
        'pasteSubMeunItem
        '
        Me.pasteSubMeunItem.Name = "pasteSubMeunItem"
        Me.pasteSubMeunItem.Size = New System.Drawing.Size(180, 22)
        Me.pasteSubMeunItem.Text = "粘贴"
        '
        'backSubMenuItem
        '
        Me.backSubMenuItem.Name = "backSubMenuItem"
        Me.backSubMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.backSubMenuItem.Text = "撤销"
        '
        'aboutSubMenuItem
        '
        Me.aboutSubMenuItem.Name = "aboutSubMenuItem"
        Me.aboutSubMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.aboutSubMenuItem.Text = "关于作者"
        '
        'MainWinForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.greenBtn)
        Me.Controls.Add(Me.blueBtn)
        Me.Controls.Add(Me.redBtn)
        Me.Controls.Add(Me.MainMenu)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "MainWinForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "新版贪吃蛇游戏 V3.0.1"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents redBtn As Button
    Friend WithEvents blueBtn As Button
    Friend WithEvents greenBtn As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents MainMenu As MenuStrip
    Friend WithEvents fileMenuItem As ToolStripMenuItem
    Friend WithEvents viewMenuItem As ToolStripMenuItem
    Friend WithEvents editMenuItem As ToolStripMenuItem
    Friend WithEvents settingMenuItem As ToolStripMenuItem
    Friend WithEvents aboutMenuItem As ToolStripMenuItem
    Friend WithEvents newSubMenuItem As ToolStripMenuItem
    Friend WithEvents openSubMenuItem As ToolStripMenuItem
    Friend WithEvents exitSubMenuItem As ToolStripMenuItem
    Friend WithEvents statusSubMenuItem As ToolStripMenuItem
    Friend WithEvents optionSubMenuItem As ToolStripMenuItem
    Friend WithEvents copySubMenuItem As ToolStripMenuItem
    Friend WithEvents pasteSubMeunItem As ToolStripMenuItem
    Friend WithEvents backSubMenuItem As ToolStripMenuItem
    Friend WithEvents aboutSubMenuItem As ToolStripMenuItem
End Class
