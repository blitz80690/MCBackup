Public Class WelcomeDialog
    Private Sub ShowAtStartupCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowAtStartupCheckBox.CheckedChanged
        My.Settings.ShowWelcomeDialog = ShowAtStartupCheckBox.Checked
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub


    Private Sub WelcomeDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            My.Computer.Network.Ping("70.33.246.120")
            WebBrowser.Navigate("http://content.nicoco007.com/downloads/mcbackup/welcome/news.html")
            NoConnectionLabel.Visible = False
            ConnectingLabel.Visible = False
        Catch ex As Exception
            NoConnectionLabel.Visible = True
            ConnectingLabel.Visible = False
        End Try
    End Sub
End Class