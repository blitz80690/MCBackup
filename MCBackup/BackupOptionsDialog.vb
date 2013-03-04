Public Class BackupOptionsDialog
    Public ButtonPressed As Boolean

    Private Sub ConfirmButton_Click(sender As System.Object, e As System.EventArgs) Handles ConfirmButton.Click
        If DateTimeRadioButton.Checked = True Then
            Main.BackupName = GetTime()
        ElseIf CustomNameTextBox.Text = Nothing Then
            MsgBox("Please enter a valid name.", MsgBoxStyle.Critical, "Error!")
            Exit Sub
        Else
            Main.BackupName = CustomNameTextBox.Text
        End If

        If InStr(Main.BackupName, "\") Or InStr(Main.BackupName, "/") Or InStr(Main.BackupName, ":") Or InStr(Main.BackupName, "*") Or InStr(Main.BackupName, "?") Or InStr(Main.BackupName, Chr(34)) Or InStr(Main.BackupName, "<") Or InStr(Main.BackupName, ">") Or InStr(Main.BackupName, "|") Then
            MsgBox("File name can not contain the following characters:" & vbNewLine & "                              \ / : * ? "" < > |", MsgBoxStyle.Critical, "Error!")
            Exit Sub
        End If

        If BackupAllRadioButton.Checked = True Then
            Main.BackupAll = True
        Else
            Main.BackupAll = False
        End If

        If My.Computer.FileSystem.DirectoryExists(Main.APPDATA + "\.mcbackup\backups\" + Main.BackupName) Then
            MsgBox("Error: That backup already exists!" + vbNewLine + "Please choose another name.", MsgBoxStyle.Critical, "Error!")
            Exit Sub
        End If

        Main.StartBackup()
        Me.Close()
    End Sub

    Public Function GetTime()
        Dim Day As String = Format(Now(), "dd")
        Dim Month As String = Format(Now(), "MM")
        Dim Year As String = Format(Now(), "yyyy")
        Dim Hours As String = Format(Now(), "hh")
        Dim Minutes As String = Format(Now(), "mm")
        Dim Seconds As String = Format(Now(), "ss")

        Return Year & "-" & Month & "-" & Day & " (" & Hours & "h" & Minutes & "m" & Seconds & "s)"
    End Function

    Private Sub CancelButton_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CustomBackupRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CustomBackupRadioButton.CheckedChanged
        Dim Checked = CustomBackupRadioButton.Checked
        BinCheckBox.Enabled = Checked
        ModsCheckBox.Enabled = Checked
        ResourcesCheckBox.Enabled = Checked
        SavesCheckBox.Enabled = Checked
        ScreenshotsCheckBox.Enabled = Checked
        StatsCheckBox.Enabled = Checked
        TexturepacksCheckBox.Enabled = Checked
    End Sub

    Private Sub CustomNameRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CustomNameRadioButton.CheckedChanged
        CustomNameTextBox.Enabled = CustomNameRadioButton.Checked
    End Sub
End Class