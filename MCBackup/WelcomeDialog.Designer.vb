<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeDialog
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
        Me.ShowAtStartupCheckBox = New System.Windows.Forms.CheckBox()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NoConnectionLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShowAtStartupCheckBox
        '
        Me.ShowAtStartupCheckBox.AutoSize = True
        Me.ShowAtStartupCheckBox.Checked = True
        Me.ShowAtStartupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShowAtStartupCheckBox.Location = New System.Drawing.Point(12, 278)
        Me.ShowAtStartupCheckBox.Name = "ShowAtStartupCheckBox"
        Me.ShowAtStartupCheckBox.Size = New System.Drawing.Size(119, 17)
        Me.ShowAtStartupCheckBox.TabIndex = 2
        Me.ShowAtStartupCheckBox.Text = "Show this at startup"
        Me.ShowAtStartupCheckBox.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(497, 272)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'WebBrowser
        '
        Me.WebBrowser.Location = New System.Drawing.Point(12, 128)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.Size = New System.Drawing.Size(560, 138)
        Me.WebBrowser.TabIndex = 4
        Me.WebBrowser.Url = New System.Uri("", System.UriKind.Relative)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "News"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MCBackup.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(42, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(351, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 26)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Need help?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contact us at support@nicoco007.com"
        '
        'NoConnectionLabel
        '
        Me.NoConnectionLabel.AutoSize = True
        Me.NoConnectionLabel.BackColor = System.Drawing.Color.White
        Me.NoConnectionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoConnectionLabel.ForeColor = System.Drawing.Color.Red
        Me.NoConnectionLabel.Location = New System.Drawing.Point(167, 183)
        Me.NoConnectionLabel.Name = "NoConnectionLabel"
        Me.NoConnectionLabel.Size = New System.Drawing.Size(251, 26)
        Me.NoConnectionLabel.TabIndex = 9
        Me.NoConnectionLabel.Text = "Can't connect to minecraft.nicoco007.com;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "News will not be loaded."
        Me.NoConnectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WelcomeDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 307)
        Me.Controls.Add(Me.NoConnectionLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.WebBrowser)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.ShowAtStartupCheckBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "WelcomeDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShowAtStartupCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents WebBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NoConnectionLabel As System.Windows.Forms.Label
End Class
