<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackupOptionsDialog
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BackupSavesRadioButton = New System.Windows.Forms.RadioButton()
        Me.TexturepacksCheckBox = New System.Windows.Forms.CheckBox()
        Me.StatsCheckBox = New System.Windows.Forms.CheckBox()
        Me.SavesCheckBox = New System.Windows.Forms.CheckBox()
        Me.ScreenshotsCheckBox = New System.Windows.Forms.CheckBox()
        Me.BinCheckBox = New System.Windows.Forms.CheckBox()
        Me.ResourcesCheckBox = New System.Windows.Forms.CheckBox()
        Me.CustomBackupRadioButton = New System.Windows.Forms.RadioButton()
        Me.BackupAllRadioButton = New System.Windows.Forms.RadioButton()
        Me.ModsCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CustomNameTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimeRadioButton = New System.Windows.Forms.RadioButton()
        Me.CustomNameRadioButton = New System.Windows.Forms.RadioButton()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BackupSavesRadioButton)
        Me.GroupBox3.Controls.Add(Me.TexturepacksCheckBox)
        Me.GroupBox3.Controls.Add(Me.StatsCheckBox)
        Me.GroupBox3.Controls.Add(Me.SavesCheckBox)
        Me.GroupBox3.Controls.Add(Me.ScreenshotsCheckBox)
        Me.GroupBox3.Controls.Add(Me.BinCheckBox)
        Me.GroupBox3.Controls.Add(Me.ResourcesCheckBox)
        Me.GroupBox3.Controls.Add(Me.CustomBackupRadioButton)
        Me.GroupBox3.Controls.Add(Me.BackupAllRadioButton)
        Me.GroupBox3.Controls.Add(Me.ModsCheckBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 106)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 260)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Selection"
        '
        'BackupSavesRadioButton
        '
        Me.BackupSavesRadioButton.AutoSize = True
        Me.BackupSavesRadioButton.Checked = True
        Me.BackupSavesRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackupSavesRadioButton.Location = New System.Drawing.Point(6, 22)
        Me.BackupSavesRadioButton.Name = "BackupSavesRadioButton"
        Me.BackupSavesRadioButton.Size = New System.Drawing.Size(116, 21)
        Me.BackupSavesRadioButton.TabIndex = 1
        Me.BackupSavesRadioButton.TabStop = True
        Me.BackupSavesRadioButton.Text = "Backup Saves"
        Me.BackupSavesRadioButton.UseVisualStyleBackColor = True
        '
        'TexturepacksCheckBox
        '
        Me.TexturepacksCheckBox.AutoSize = True
        Me.TexturepacksCheckBox.Enabled = False
        Me.TexturepacksCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexturepacksCheckBox.Location = New System.Drawing.Point(25, 233)
        Me.TexturepacksCheckBox.Name = "TexturepacksCheckBox"
        Me.TexturepacksCheckBox.Size = New System.Drawing.Size(91, 17)
        Me.TexturepacksCheckBox.TabIndex = 12
        Me.TexturepacksCheckBox.Text = "Texturepacks"
        Me.TexturepacksCheckBox.UseVisualStyleBackColor = True
        '
        'StatsCheckBox
        '
        Me.StatsCheckBox.AutoSize = True
        Me.StatsCheckBox.Enabled = False
        Me.StatsCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatsCheckBox.Location = New System.Drawing.Point(25, 210)
        Me.StatsCheckBox.Name = "StatsCheckBox"
        Me.StatsCheckBox.Size = New System.Drawing.Size(50, 17)
        Me.StatsCheckBox.TabIndex = 11
        Me.StatsCheckBox.Text = "Stats"
        Me.StatsCheckBox.UseVisualStyleBackColor = True
        '
        'SavesCheckBox
        '
        Me.SavesCheckBox.AutoSize = True
        Me.SavesCheckBox.Enabled = False
        Me.SavesCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SavesCheckBox.Location = New System.Drawing.Point(25, 164)
        Me.SavesCheckBox.Name = "SavesCheckBox"
        Me.SavesCheckBox.Size = New System.Drawing.Size(56, 17)
        Me.SavesCheckBox.TabIndex = 9
        Me.SavesCheckBox.Text = "Saves"
        Me.SavesCheckBox.UseVisualStyleBackColor = True
        '
        'ScreenshotsCheckBox
        '
        Me.ScreenshotsCheckBox.AutoSize = True
        Me.ScreenshotsCheckBox.Enabled = False
        Me.ScreenshotsCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScreenshotsCheckBox.Location = New System.Drawing.Point(25, 187)
        Me.ScreenshotsCheckBox.Name = "ScreenshotsCheckBox"
        Me.ScreenshotsCheckBox.Size = New System.Drawing.Size(85, 17)
        Me.ScreenshotsCheckBox.TabIndex = 10
        Me.ScreenshotsCheckBox.Text = "Screenshots"
        Me.ScreenshotsCheckBox.UseVisualStyleBackColor = True
        '
        'BinCheckBox
        '
        Me.BinCheckBox.AutoSize = True
        Me.BinCheckBox.Enabled = False
        Me.BinCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BinCheckBox.Location = New System.Drawing.Point(25, 95)
        Me.BinCheckBox.Name = "BinCheckBox"
        Me.BinCheckBox.Size = New System.Drawing.Size(69, 17)
        Me.BinCheckBox.TabIndex = 6
        Me.BinCheckBox.Text = "Bin (.jars)"
        Me.BinCheckBox.UseVisualStyleBackColor = True
        '
        'ResourcesCheckBox
        '
        Me.ResourcesCheckBox.AutoSize = True
        Me.ResourcesCheckBox.Enabled = False
        Me.ResourcesCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResourcesCheckBox.Location = New System.Drawing.Point(25, 141)
        Me.ResourcesCheckBox.Name = "ResourcesCheckBox"
        Me.ResourcesCheckBox.Size = New System.Drawing.Size(77, 17)
        Me.ResourcesCheckBox.TabIndex = 8
        Me.ResourcesCheckBox.Text = "Resources"
        Me.ResourcesCheckBox.UseVisualStyleBackColor = True
        '
        'CustomBackupRadioButton
        '
        Me.CustomBackupRadioButton.AutoSize = True
        Me.CustomBackupRadioButton.Enabled = False
        Me.CustomBackupRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomBackupRadioButton.Location = New System.Drawing.Point(6, 68)
        Me.CustomBackupRadioButton.Name = "CustomBackupRadioButton"
        Me.CustomBackupRadioButton.Size = New System.Drawing.Size(124, 21)
        Me.CustomBackupRadioButton.TabIndex = 3
        Me.CustomBackupRadioButton.Text = "Custom Backup"
        Me.CustomBackupRadioButton.UseVisualStyleBackColor = True
        '
        'BackupAllRadioButton
        '
        Me.BackupAllRadioButton.AutoSize = True
        Me.BackupAllRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackupAllRadioButton.Location = New System.Drawing.Point(6, 45)
        Me.BackupAllRadioButton.Name = "BackupAllRadioButton"
        Me.BackupAllRadioButton.Size = New System.Drawing.Size(92, 21)
        Me.BackupAllRadioButton.TabIndex = 2
        Me.BackupAllRadioButton.Text = "Backup All"
        Me.BackupAllRadioButton.UseVisualStyleBackColor = True
        '
        'ModsCheckBox
        '
        Me.ModsCheckBox.AutoSize = True
        Me.ModsCheckBox.Enabled = False
        Me.ModsCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModsCheckBox.Location = New System.Drawing.Point(25, 118)
        Me.ModsCheckBox.Name = "ModsCheckBox"
        Me.ModsCheckBox.Size = New System.Drawing.Size(143, 17)
        Me.ModsCheckBox.TabIndex = 7
        Me.ModsCheckBox.Text = "Mods (Modloader/Forge)"
        Me.ModsCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CustomNameTextBox)
        Me.GroupBox2.Controls.Add(Me.DateTimeRadioButton)
        Me.GroupBox2.Controls.Add(Me.CustomNameRadioButton)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(416, 88)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Name"
        '
        'CustomNameTextBox
        '
        Me.CustomNameTextBox.Enabled = False
        Me.CustomNameTextBox.Location = New System.Drawing.Point(134, 53)
        Me.CustomNameTextBox.MaxLength = 20
        Me.CustomNameTextBox.Name = "CustomNameTextBox"
        Me.CustomNameTextBox.Size = New System.Drawing.Size(270, 23)
        Me.CustomNameTextBox.TabIndex = 7
        '
        'DateTimeRadioButton
        '
        Me.DateTimeRadioButton.AutoSize = True
        Me.DateTimeRadioButton.Checked = True
        Me.DateTimeRadioButton.Location = New System.Drawing.Point(6, 27)
        Me.DateTimeRadioButton.Name = "DateTimeRadioButton"
        Me.DateTimeRadioButton.Size = New System.Drawing.Size(119, 21)
        Me.DateTimeRadioButton.TabIndex = 10
        Me.DateTimeRadioButton.TabStop = True
        Me.DateTimeRadioButton.Text = "Date and Time"
        Me.DateTimeRadioButton.UseVisualStyleBackColor = True
        '
        'CustomNameRadioButton
        '
        Me.CustomNameRadioButton.AutoSize = True
        Me.CustomNameRadioButton.Location = New System.Drawing.Point(6, 54)
        Me.CustomNameRadioButton.Name = "CustomNameRadioButton"
        Me.CustomNameRadioButton.Size = New System.Drawing.Size(122, 21)
        Me.CustomNameRadioButton.TabIndex = 8
        Me.CustomNameRadioButton.Text = "Custom Name :"
        Me.CustomNameRadioButton.UseVisualStyleBackColor = True
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmButton.Location = New System.Drawing.Point(218, 224)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(208, 40)
        Me.ConfirmButton.TabIndex = 7
        Me.ConfirmButton.Text = "Start Backup"
        Me.ConfirmButton.UseVisualStyleBackColor = True
        '
        'BackupOptionsDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 376)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "BackupOptionsDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup Options"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BackupSavesRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TexturepacksCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents StatsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SavesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ScreenshotsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BinCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ResourcesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CustomBackupRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents BackupAllRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ModsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CustomNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateTimeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CustomNameRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ConfirmButton As System.Windows.Forms.Button
End Class
