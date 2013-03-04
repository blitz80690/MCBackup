Public Class WelcomeDialog
    Private Sub ShowAtStartupCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowAtStartupCheckBox.CheckedChanged
        My.Settings.ShowWelcomeDialog = ShowAtStartupCheckBox.Checked
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub


    Private Sub WelcomeDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.Network.Ping("70.33.246.120") <> Nothing Then
            NoConnectionLabel.Visible = False
            WebBrowser.Navigate("C:\Users\Nicolas\Desktop\news.html")
        End If
    End Sub
End Class