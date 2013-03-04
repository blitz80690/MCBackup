<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApplicationOptionsDialog
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
        Me.MCFolderBrowseButton = New System.Windows.Forms.Button()
        Me.MCFolderTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BkpsFolderTextBox = New System.Windows.Forms.TextBox()
        Me.BkpsFolderBrowseButton = New System.Windows.Forms.Button()
        Me.MCFolderDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.BkpsFolderDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ShowWelcomeMessageCheckBox = New System.Windows.Forms.CheckBox()
        Me.ShowTooltipsCheckBox = New System.Windows.Forms.CheckBox()
        Me.ShowDeleteDialogCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MCFolderBrowseButton
        '
        Me.MCFolderBrowseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MCFolderBrowseButton.Location = New System.Drawing.Point(518, 21)
        Me.MCFolderBrowseButton.Name = "MCFolderBrowseButton"
        Me.MCFolderBrowseButton.Size = New System.Drawing.Size(35, 20)
        Me.MCFolderBrowseButton.TabIndex = 0
        Me.MCFolderBrowseButton.Text = "•••"
        Me.MCFolderBrowseButton.UseVisualStyleBackColor = True
        '
        'MCFolderTextBox
        '
        Me.MCFolderTextBox.Location = New System.Drawing.Point(137, 21)
        Me.MCFolderTextBox.Name = "MCFolderTextBox"
        Me.MCFolderTextBox.ReadOnly = True
        Me.MCFolderTextBox.Size = New System.Drawing.Size(375, 20)
        Me.MCFolderTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Minecraft Folder Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Backups Folder Location"
        '
        'BkpsFolderTextBox
        '
        Me.BkpsFolderTextBox.Location = New System.Drawing.Point(137, 47)
        Me.BkpsFolderTextBox.Name = "BkpsFolderTextBox"
        Me.BkpsFolderTextBox.ReadOnly = True
        Me.BkpsFolderTextBox.Size = New System.Drawing.Size(375, 20)
        Me.BkpsFolderTextBox.TabIndex = 4
        '
        'BkpsFolderBrowseButton
        '
        Me.BkpsFolderBrowseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BkpsFolderBrowseButton.Location = New System.Drawing.Point(518, 47)
        Me.BkpsFolderBrowseButton.Name = "BkpsFolderBrowseButton"
        Me.BkpsFolderBrowseButton.Size = New System.Drawing.Size(35, 20)
        Me.BkpsFolderBrowseButton.TabIndex = 3
        Me.BkpsFolderBrowseButton.Text = "•••"
        Me.BkpsFolderBrowseButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(254, 202)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 6
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(502, 202)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(70, 23)
        Me.ResetButton.TabIndex = 7
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MCFolderTextBox)
        Me.GroupBox1.Controls.Add(Me.MCFolderBrowseButton)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BkpsFolderBrowseButton)
        Me.GroupBox1.Controls.Add(Me.BkpsFolderTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 80)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Folder Locations"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ShowWelcomeMessageCheckBox)
        Me.GroupBox2.Controls.Add(Me.ShowTooltipsCheckBox)
        Me.GroupBox2.Controls.Add(Me.ShowDeleteDialogCheckBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 103)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(560, 93)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Appearance Options"
        '
        'ShowWelcomeMessageCheckBox
        '
        Me.ShowWelcomeMessageCheckBox.AutoSize = True
        Me.ShowWelcomeMessageCheckBox.Location = New System.Drawing.Point(7, 68)
        Me.ShowWelcomeMessageCheckBox.Name = "ShowWelcomeMessageCheckBox"
        Me.ShowWelcomeMessageCheckBox.Size = New System.Drawing.Size(190, 17)
        Me.ShowWelcomeMessageCheckBox.TabIndex = 14
        Me.ShowWelcomeMessageCheckBox.Text = "Show welcome message at startup"
        Me.ShowWelcomeMessageCheckBox.UseVisualStyleBackColor = True
        '
        'ShowTooltipsCheckBox
        '
        Me.ShowTooltipsCheckBox.AutoSize = True
        Me.ShowTooltipsCheckBox.Location = New System.Drawing.Point(7, 45)
        Me.ShowTooltipsCheckBox.Name = "ShowTooltipsCheckBox"
        Me.ShowTooltipsCheckBox.Size = New System.Drawing.Size(226, 17)
        Me.ShowTooltipsCheckBox.TabIndex = 13
        Me.ShowTooltipsCheckBox.Text = "Show tooltip when backup/restore is done"
        Me.ShowTooltipsCheckBox.UseVisualStyleBackColor = True
        '
        'ShowDeleteDialogCheckBox
        '
        Me.ShowDeleteDialogCheckBox.AutoSize = True
        Me.ShowDeleteDialogCheckBox.Location = New System.Drawing.Point(7, 22)
        Me.ShowDeleteDialogCheckBox.Name = "ShowDeleteDialogCheckBox"
        Me.ShowDeleteDialogCheckBox.Size = New System.Drawing.Size(287, 17)
        Me.ShowDeleteDialogCheckBox.TabIndex = 12
        Me.ShowDeleteDialogCheckBox.Text = "Show ""Are you sure"" message when deleting a backup"
        Me.ShowDeleteDialogCheckBox.UseVisualStyleBackColor = True
        '
        'ApplicationOptionsDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 237)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.CloseButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ApplicationOptionsDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Application Options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MCFolderBrowseButton As System.Windows.Forms.Button
    Friend WithEvents MCFolderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BkpsFolderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BkpsFolderBrowseButton As System.Windows.Forms.Button
    Friend WithEvents MCFolderDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents BkpsFolderDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ShowTooltipsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ShowDeleteDialogCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ShowWelcomeMessageCheckBox As System.Windows.Forms.CheckBox
End Class
