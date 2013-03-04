Public Class ApplicationOptionsDialog

    Dim APPDATA As String = Environ("APPDATA")

    Private Sub Application_Options_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        RefreshSettings()
    End Sub

    Private Sub MCFolderBrowseButton_Click(sender As System.Object, e As System.EventArgs) Handles MCFolderBrowseButton.Click
        If DialogResult.Cancel = MCFolderDialog.ShowDialog Then
            Exit Sub
        End If

        If My.Computer.FileSystem.FileExists(MCFolderDialog.SelectedPath.ToString & "\bin\minecraft.jar") Then
            My.Settings.MCFolder = MCFolderDialog.SelectedPath.ToString
            RefreshSettings()
        Else
            If MsgBox("Could not find installed Minecraft in that folder!" & vbNewLine & "Try Again?", MsgBoxStyle.YesNo, "Error!") = MsgBoxResult.Yes Then
                MCFolderBrowseButton_Click(sender, e)
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub BkpsFolderBrowseButton_Click(sender As System.Object, e As System.EventArgs) Handles BkpsFolderBrowseButton.Click
        If BkpsFolderDialog.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If

        My.Settings.BkpsFolder = BkpsFolderDialog.SelectedPath.ToString
        RefreshSettings()
    End Sub

    Private Sub RefreshSettings()
        MCFolderTextBox.Text = My.Settings.MCFolder
        BkpsFolderTextBox.Text = My.Settings.BkpsFolder
        ShowDeleteDialogCheckBox.Checked = My.Settings.ShowDeleteDialog
        ShowTooltipsCheckBox.Checked = My.Settings.ShowTooltips
        ShowWelcomeMessageCheckBox.Checked = My.Settings.ShowWelcomeDialog
    End Sub

    Private Sub CloseButton_Click(sender As System.Object, e As System.EventArgs) Handles CloseButton.Click
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub ResetButton_Click(sender As System.Object, e As System.EventArgs) Handles ResetButton.Click
        If MsgBox("Are you sure you want to reset application settings to defaults? You will loose all your settings.", MsgBoxStyle.YesNo, "Are you sure?") = MsgBoxResult.No Then
            Exit Sub
        End If

        If My.Computer.FileSystem.DirectoryExists(APPDATA & "\.minecraft") Then
            My.Settings.MCFolder = APPDATA & "\.minecraft"
        Else
            MsgBox("MCBackup was unable to reset the default Minecraft folder location : It does not exist!", MsgBoxStyle.Critical, "Error!")
        End If

        If My.Computer.FileSystem.DirectoryExists(APPDATA & "\.mcbackup\backups") Then
            My.Settings.BkpsFolder = APPDATA & "\.mcbackup\backups"
        Else
            My.Computer.FileSystem.CreateDirectory(APPDATA & "\.mcbackup\backups")
            My.Settings.BkpsFolder = APPDATA & "\.mcbackup\backups"
        End If

        My.Settings.ShowDeleteDialog = True
        My.Settings.ShowTooltips = True
        My.Settings.ShowWelcomeDialog = True

        RefreshSettings()
    End Sub

    Private Sub ShowDeleteDialogCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowDeleteDialogCheckBox.CheckedChanged
        My.Settings.ShowDeleteDialog = ShowDeleteDialogCheckBox.Checked
    End Sub

    Private Sub ShowTooltipsCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowTooltipsCheckBox.CheckedChanged
        My.Settings.ShowTooltips = ShowTooltipsCheckBox.Checked
    End Sub

    Private Sub ShowWelcomeMessageCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowWelcomeMessageCheckBox.CheckedChanged
        My.Settings.ShowWelcomeDialog = ShowWelcomeMessageCheckBox.Checked
    End Sub
End Class