Public Class DeleteDialog

    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        For Each Item As ListViewItem In Main.ListView.SelectedItems
            My.Computer.FileSystem.DeleteDirectory(Main.APPDATA & "\.mcbackup\backups\" & Item.Name, FileIO.DeleteDirectoryOption.DeleteAllContents)
        Next
        Main.LoadBackups()
        Me.Close()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Me.Close()
    End Sub

    Private Sub DontShowAgainCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles DontShowAgainCheckBox.CheckedChanged
        My.Settings.ShowDeleteDialog = Not DontShowAgainCheckBox.Checked
    End Sub
End Class