Public Class RenameDialog
    Dim APPDATA As String = Environ("APPDATA")
    Public ItemName As String
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles RenameButton.Click
        Try
            My.Computer.FileSystem.RenameDirectory(My.Settings.BkpsFolder & "\" & ItemName, RenameTextBox.Text)
        Catch ex As Exception
            MsgBox("Error : " & ex.Message, MsgBoxStyle.Critical, "Error!")
            Exit Sub
        End Try
        Main.LoadBackups()
        Me.Close()
    End Sub

    Private Sub CancelButton_Click(sender As System.Object, e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub Rename_Form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class