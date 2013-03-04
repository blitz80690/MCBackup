<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteDialog))
        Me.Message = New System.Windows.Forms.Label()
        Me.YesButton = New System.Windows.Forms.Button()
        Me.NoButton = New System.Windows.Forms.Button()
        Me.DontShowAgainCheckBox = New System.Windows.Forms.CheckBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Message
        '
        Me.Message.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Message.Location = New System.Drawing.Point(0, 2)
        Me.Message.Name = "Message"
        Me.Message.Size = New System.Drawing.Size(294, 38)
        Me.Message.TabIndex = 0
        Me.Message.Text = "Are you sure you want to delete this backup?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It will be lost forever! (A long ti" & _
    "me)"
        Me.Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'YesButton
        '
        Me.YesButton.Location = New System.Drawing.Point(32, 45)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.Size = New System.Drawing.Size(75, 23)
        Me.YesButton.TabIndex = 1
        Me.YesButton.Text = "Yes"
        Me.YesButton.UseVisualStyleBackColor = True
        '
        'NoButton
        '
        Me.NoButton.Location = New System.Drawing.Point(187, 45)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(75, 23)
        Me.NoButton.TabIndex = 2
        Me.NoButton.Text = "No"
        Me.NoButton.UseVisualStyleBackColor = True
        '
        'DontShowAgainCheckBox
        '
        Me.DontShowAgainCheckBox.AutoSize = True
        Me.DontShowAgainCheckBox.Location = New System.Drawing.Point(52, 118)
        Me.DontShowAgainCheckBox.Name = "DontShowAgainCheckBox"
        Me.DontShowAgainCheckBox.Size = New System.Drawing.Size(189, 17)
        Me.DontShowAgainCheckBox.TabIndex = 3
        Me.DontShowAgainCheckBox.Text = "Don't show me this message again"
        Me.DontShowAgainCheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Note: The window might freeze for a while; that's normal." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This window will close" & _
    " by itself when the operation is done."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeleteDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 144)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DontShowAgainCheckBox)
        Me.Controls.Add(Me.NoButton)
        Me.Controls.Add(Me.YesButton)
        Me.Controls.Add(Me.Message)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DeleteDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Are you sure?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Message As System.Windows.Forms.Label
    Friend WithEvents YesButton As System.Windows.Forms.Button
    Friend WithEvents NoButton As System.Windows.Forms.Button
    Friend WithEvents DontShowAgainCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
