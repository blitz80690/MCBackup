<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupsFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicationOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateCreatedColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContentsColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackupButton = New System.Windows.Forms.Button()
        Me.RestoreButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.RenameButton = New System.Windows.Forms.Button()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.BackupBGW = New System.ComponentModel.BackgroundWorker()
        Me.BackupTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MCBackupNotify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MCFolderDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.ClearBGW = New System.ComponentModel.BackgroundWorker()
        Me.RestoreBGW = New System.ComponentModel.BackgroundWorker()
        Me.RestoreTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ShowAutoBackupButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TimeUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.StartAutoBackupButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TimeLeftLabel = New System.Windows.Forms.Label()
        Me.AutoBackupTimer = New System.Windows.Forms.Timer(Me.components)
        Me.DeleteBGW = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip.SuspendLayout()
        CType(Me.TimeUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(794, 24)
        Me.MenuStrip.TabIndex = 4
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.BackupsFolderToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Backups List"
        '
        'BackupsFolderToolStripMenuItem
        '
        Me.BackupsFolderToolStripMenuItem.Name = "BackupsFolderToolStripMenuItem"
        Me.BackupsFolderToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.BackupsFolderToolStripMenuItem.Text = "Backups Folder"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationOptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'ApplicationOptionsToolStripMenuItem
        '
        Me.ApplicationOptionsToolStripMenuItem.Name = "ApplicationOptionsToolStripMenuItem"
        Me.ApplicationOptionsToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ApplicationOptionsToolStripMenuItem.Text = "Application Options..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.WebsiteToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'WebsiteToolStripMenuItem
        '
        Me.WebsiteToolStripMenuItem.Name = "WebsiteToolStripMenuItem"
        Me.WebsiteToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.WebsiteToolStripMenuItem.Text = "Website"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(573, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "< 1 week"
        '
        'NameColumn
        '
        Me.NameColumn.Text = "Name"
        Me.NameColumn.Width = 195
        '
        'DateCreatedColumn
        '
        Me.DateCreatedColumn.Text = "Date Created"
        Me.DateCreatedColumn.Width = 135
        '
        'ContentsColumn
        '
        Me.ContentsColumn.Text = "Contents"
        Me.ContentsColumn.Width = 435
        '
        'ListView
        '
        Me.ListView.BackColor = System.Drawing.SystemColors.Window
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameColumn, Me.DateCreatedColumn, Me.ContentsColumn})
        Me.ListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView.FullRowSelect = True
        Me.ListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ListView.Location = New System.Drawing.Point(12, 28)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(770, 250)
        Me.ListView.TabIndex = 2
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(638, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "1 - 2 weeks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(717, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "> 2 weeks"
        '
        'BackupButton
        '
        Me.BackupButton.BackColor = System.Drawing.Color.Transparent
        Me.BackupButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackupButton.Location = New System.Drawing.Point(12, 284)
        Me.BackupButton.Name = "BackupButton"
        Me.BackupButton.Size = New System.Drawing.Size(150, 52)
        Me.BackupButton.TabIndex = 8
        Me.BackupButton.Text = "Backup..."
        Me.BackupButton.UseVisualStyleBackColor = False
        '
        'RestoreButton
        '
        Me.RestoreButton.BackColor = System.Drawing.Color.Transparent
        Me.RestoreButton.Enabled = False
        Me.RestoreButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestoreButton.Location = New System.Drawing.Point(168, 284)
        Me.RestoreButton.Name = "RestoreButton"
        Me.RestoreButton.Size = New System.Drawing.Size(150, 52)
        Me.RestoreButton.TabIndex = 9
        Me.RestoreButton.Text = "Restore"
        Me.RestoreButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.Transparent
        Me.DeleteButton.Enabled = False
        Me.DeleteButton.Location = New System.Drawing.Point(324, 284)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(150, 23)
        Me.DeleteButton.TabIndex = 12
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'RenameButton
        '
        Me.RenameButton.BackColor = System.Drawing.Color.Transparent
        Me.RenameButton.Enabled = False
        Me.RenameButton.Location = New System.Drawing.Point(324, 313)
        Me.RenameButton.Name = "RenameButton"
        Me.RenameButton.Size = New System.Drawing.Size(150, 23)
        Me.RenameButton.TabIndex = 13
        Me.RenameButton.Text = "Rename"
        Me.RenameButton.UseVisualStyleBackColor = False
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(12, 387)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(770, 23)
        Me.ProgressBar.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(12, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Status :"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.StatusLabel.Location = New System.Drawing.Point(90, 364)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(65, 20)
        Me.StatusLabel.TabIndex = 16
        Me.StatusLabel.Text = "Ready!"
        '
        'BackupBGW
        '
        '
        'BackupTimer
        '
        '
        'MCBackupNotify
        '
        Me.MCBackupNotify.Icon = CType(resources.GetObject("MCBackupNotify.Icon"), System.Drawing.Icon)
        Me.MCBackupNotify.Text = "NotifyIcon1"
        Me.MCBackupNotify.Visible = True
        '
        'ClearBGW
        '
        '
        'RestoreBGW
        '
        '
        'RestoreTimer
        '
        '
        'ShowAutoBackupButton
        '
        Me.ShowAutoBackupButton.Location = New System.Drawing.Point(688, 313)
        Me.ShowAutoBackupButton.Name = "ShowAutoBackupButton"
        Me.ShowAutoBackupButton.Size = New System.Drawing.Size(94, 23)
        Me.ShowAutoBackupButton.TabIndex = 17
        Me.ShowAutoBackupButton.Text = "Auto Backup >>"
        Me.ShowAutoBackupButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(827, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Backup every"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(952, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "minutes"
        '
        'TimeUpDown
        '
        Me.TimeUpDown.Location = New System.Drawing.Point(906, 187)
        Me.TimeUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.TimeUpDown.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.TimeUpDown.Name = "TimeUpDown"
        Me.TimeUpDown.Size = New System.Drawing.Size(40, 20)
        Me.TimeUpDown.TabIndex = 21
        Me.TimeUpDown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(794, 422)
        Me.ShapeContainer1.TabIndex = 22
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 795
        Me.LineShape1.X2 = 795
        Me.LineShape1.Y1 = 0
        Me.LineShape1.Y2 = 420
        '
        'StartAutoBackupButton
        '
        Me.StartAutoBackupButton.BackColor = System.Drawing.Color.Transparent
        Me.StartAutoBackupButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartAutoBackupButton.Location = New System.Drawing.Point(813, 237)
        Me.StartAutoBackupButton.Name = "StartAutoBackupButton"
        Me.StartAutoBackupButton.Size = New System.Drawing.Size(206, 52)
        Me.StartAutoBackupButton.TabIndex = 23
        Me.StartAutoBackupButton.Text = "Start Auto Backup"
        Me.StartAutoBackupButton.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(816, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 20)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Time left until next backup :"
        '
        'TimeLeftLabel
        '
        Me.TimeLeftLabel.AutoSize = True
        Me.TimeLeftLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLeftLabel.Location = New System.Drawing.Point(880, 97)
        Me.TimeLeftLabel.Name = "TimeLeftLabel"
        Me.TimeLeftLabel.Size = New System.Drawing.Size(66, 25)
        Me.TimeLeftLabel.TabIndex = 25
        Me.TimeLeftLabel.Text = "00:00"
        '
        'AutoBackupTimer
        '
        Me.AutoBackupTimer.Interval = 1000
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(794, 422)
        Me.Controls.Add(Me.TimeLeftLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.StartAutoBackupButton)
        Me.Controls.Add(Me.TimeUpDown)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ShowAutoBackupButton)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.RenameButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.RestoreButton)
        Me.Controls.Add(Me.BackupButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " MCBackup 2.3.0"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.TimeUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebsiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NameColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateCreatedColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContentsColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplicationOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupButton As System.Windows.Forms.Button
    Friend WithEvents RestoreButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents RenameButton As System.Windows.Forms.Button
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents BackupBGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackupTimer As System.Windows.Forms.Timer
    Friend WithEvents MCBackupNotify As System.Windows.Forms.NotifyIcon
    Friend WithEvents MCFolderDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ClearBGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents RestoreBGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents RestoreTimer As System.Windows.Forms.Timer
    Friend WithEvents BackupsFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowAutoBackupButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TimeUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents StartAutoBackupButton As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TimeLeftLabel As System.Windows.Forms.Label
    Friend WithEvents AutoBackupTimer As System.Windows.Forms.Timer
    Friend WithEvents DeleteBGW As System.ComponentModel.BackgroundWorker

End Class
