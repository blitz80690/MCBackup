Imports Scripting
Imports System.IO
Imports System.Net
Imports System.Threading
Imports Microsoft.WindowsAPICodePack.Taskbar

Public Class Main
    Public APPDATA As String = Environ("APPDATA")
    Private Source, Destination, ItemName As String
    Public BackupName, BackupErrorDesc, ClearErrorDesc, RestoreErrorDesc As String
    Public BackupButtonPressed, BackupAll, BackupError, RestoreAll, ClearError, RestoreError As Boolean
    Private ShowAutoBackupButtonPressed As Boolean

    Dim FileStream As FileStream
    Dim StreamWriter As StreamWriter

    Declare Function ChangeProgressBarColor Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        My.Computer.FileSystem.CreateDirectory(APPDATA & "\.mcbackup\logs")

        If Not My.Computer.FileSystem.FileExists(APPDATA + "\.mcbackup\logs\mcbackup.log") Then
            IO.File.Create(APPDATA + "\.mcbackup\logs\mcbackup.log").Dispose()
        End If

        FileStream = New FileStream((APPDATA + "\.mcbackup\logs\mcbackup.log"), FileMode.Append, FileAccess.Write)
        StreamWriter = New StreamWriter(FileStream, System.Text.Encoding.Default)

        StreamWriter.WriteLine("------ New Log Session : " & LogTimeStamp() & "------")
        StreamWriter.WriteLine(LogTimeStamp() & "[INFO] Program Initialized")

        Dim SearchFolder As Boolean = False
        Dim UpdateAvail As Boolean = False

        If Not My.Computer.FileSystem.FileExists(My.Settings.MCFolder & "\bin\minecraft.jar") Then
            If My.Computer.FileSystem.FileExists(APPDATA & "\.minecraft\bin\minecraft.jar") Then
                My.Settings.MCFolder = APPDATA & "\.minecraft"
                StreamWriter.WriteLine(LogTimeStamp() & "[INFO] Set Minecraft Folder Setting to " & APPDATA + "\.minecraft")
            Else
                MsgBox("MCBackup was unable to find an installed Minecraft on your computer." & vbNewLine & "Please locate and select the folder in which Minecraft is installed before continuing.", MsgBoxStyle.Critical, "Error!")
                StreamWriter.WriteLine(LogTimeStamp() & "[SEVERE] Could not find Minecraft install on the system.")
                SearchForMCFolder()
            End If
        End If

        If Not My.Computer.FileSystem.DirectoryExists(My.Settings.BkpsFolder) Then
            StreamWriter.WriteLine(LogTimeStamp() & "[SEVERE] Could not find saved backups folder.")
            If My.Computer.FileSystem.DirectoryExists(APPDATA & "\.mcbackup\backups") Then
                My.Settings.BkpsFolder = APPDATA & "\.mcbackup\backups"
                StreamWriter.WriteLine(LogTimeStamp() & "[INFO] Set Backups Folder Setting to " & APPDATA + "\.mcbackup\backups")
            Else
                My.Computer.FileSystem.CreateDirectory(APPDATA & "\.mcbackup\backups")
                StreamWriter.WriteLine(LogTimeStamp() & "[INFO] Created folder " & APPDATA + "\.mcbackup\backups")
                My.Settings.BkpsFolder = APPDATA & "\.mcbackup\backups"
                StreamWriter.WriteLine(LogTimeStamp() & "[INFO] Set Backups Folder Setting to " & APPDATA + "\.mcbackup\backups")
            End If
        End If

        LoadBackups()
    End Sub

    Private Sub SearchForMCFolder()
        If MCFolderDialog.ShowDialog = DialogResult.Cancel Then
            Me.Close()
            Exit Sub
        End If

        If My.Computer.FileSystem.FileExists(MCFolderDialog.SelectedPath.ToString & "\bin\minecraft.jar") Then
            My.Settings.MCFolder = MCFolderDialog.SelectedPath.ToString
        Else
            If MsgBox("Could not find installed Minecraft in that folder!" & vbNewLine & "Try Again?", MsgBoxStyle.YesNo, "Error!") = MsgBoxResult.Yes Then
                SearchForMCFolder()
            Else
                Me.Close()
            End If
        End If
    End Sub

    Public Sub LoadBackups()
        ListView.Items.Clear()
        Dim Directory As New IO.DirectoryInfo(My.Settings.BkpsFolder)
        Dim Folders As IO.DirectoryInfo() = Directory.GetDirectories()
        Dim File As IO.DirectoryInfo

        For Each File In Folders
            Dim listViewItem As New ListViewItem()
            Dim listViewSubItem_Date As ListViewItem.ListViewSubItem
            Dim listViewSubItem_Description As ListViewItem.ListViewSubItem

            listViewItem.Text = File.ToString
            listViewItem.Name = File.ToString

            If DateDiff("d", GetFolderDateCreated(Directory.ToString & "\" & File.ToString), Now) > 14 Then
                listViewItem.ForeColor = Color.Red
            ElseIf DateDiff("d", GetFolderDateCreated(Directory.ToString & "\" & File.ToString), Now) > 7 Then
                listViewItem.ForeColor = Color.Orange
            Else
                listViewItem.ForeColor = Color.Green
            End If

            listViewSubItem_Date = New ListViewItem.ListViewSubItem()
            listViewSubItem_Date.Text = GetFolderDateCreated(Directory.ToString & "\" & File.ToString)

            listViewSubItem_Description = New ListViewItem.ListViewSubItem()
            listViewSubItem_Description.Text = GetFolderContents(Directory.ToString & "\" & File.ToString)

            ListView.Items.Add(listViewItem)
            listViewItem.SubItems.Add(listViewSubItem_Date)
            listViewItem.SubItems.Add(listViewSubItem_Description)
        Next
    End Sub

    Private Function GetFolderDateCreated(FolderPath As String)
        Dim FSO As FileSystemObject = New FileSystemObject
        Return FSO.GetFolder(FolderPath).DateCreated
    End Function

    Private Function GetFolderContents(FolderPath As String)
        Dim Directory As New IO.DirectoryInfo(FolderPath)
        Dim Folders As IO.DirectoryInfo() = Directory.GetDirectories()
        Dim Folder As IO.DirectoryInfo
        Dim FoldersToShow As String = Nothing

        For Each Folder In Folders
            If FoldersToShow = Nothing Then
                FoldersToShow = Folder.ToString
            Else
                FoldersToShow = FoldersToShow & ", " & Folder.ToString
            End If
        Next
        Return FoldersToShow
    End Function

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadBackups()
    End Sub

    Private Sub BackupButton_Click(sender As System.Object, e As System.EventArgs) Handles BackupButton.Click
        BackupOptionsDialog.ShowDialog()
    End Sub

    Private Sub BackupTimer_Tick(sender As System.Object, e As System.EventArgs) Handles BackupTimer.Tick
        Dim SourceSize = GetFolderSize(Source)
        Dim DestinationSize = GetFolderSize(Destination)
        Dim PercentComplete As Integer = DestinationSize / SourceSize * 100
        If PercentComplete < 100 Then
            ProgressBar.Value = PercentComplete
            TaskbarManager.Instance.SetProgressValue(PercentComplete, 100)
            StatusLabel.Text = "Backing up... (" & PercentComplete.ToString & "% Complete)"
        End If
    End Sub

    Private Sub BackupBGW_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackupBGW.DoWork
        Try
            My.Computer.FileSystem.CopyDirectory(Source, Destination, True)
            BackupError = False
        Catch ex As Exception
            BackupError = True
            BackupErrorDesc = ex.Message
        End Try
    End Sub

    Private Sub BackupBGW_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackupBGW.RunWorkerCompleted
        BackupTimer.Stop()
        LoadBackups()
        If BackupError = True Then
            StatusLabel.Text = "Error!"
            MCBackupNotify.ShowBalloonTip(2500, "MCBackup - Error!", "There was an error while backing up.", ToolTipIcon.Error)
            MsgBox("There was an error while backing up. Please check the log for more information.", MsgBoxStyle.Critical, "Error!")
            StreamWriter.WriteLine(LogTimeStamp() & "[SEVERE] " & BackupErrorDesc)
            ChangeProgressBarColor(ProgressBar.Handle, 1040, 2, 0)
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error)
            StatusLabel.Text = "Ready!"
            Exit Sub
        End If
        StreamWriter.WriteLine(LogTimeStamp() & "[INFO] Successfully backed up """ & BackupName & """")
        ProgressBar.Value = 100
        TaskbarManager.Instance.SetProgressValue(100, 100)
        StatusLabel.Text = "Backup Finised - Ready!"
        MCBackupNotify.ShowBalloonTip(2500, "MCBackup - Backup Done!", "Your backup has finished!", ToolTipIcon.Info)
    End Sub

    Private Function GetFolderSize(FolderPath As String)
        Dim FSO As FileSystemObject = New FileSystemObject
        Try
            Return FSO.GetFolder(FolderPath).Size
        Catch ex As Exception
        End Try
        Return Nothing
    End Function

    Private Sub DeleteButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteButton.Click
        If My.Settings.ShowDeleteDialog Then
            If ListView.SelectedItems.Count > 1 Then
                DeleteDialog.Message.Text = "Are you sure you want to delete these backups?" & vbNewLine & "They will be lost forever! (A long time)"
                DeleteDialog.ShowDialog()
            Else
                DeleteDialog.Message.Text = "Are you sure you want to delete this backup?" & vbNewLine & "It will be lost forever! (A long time)"
                DeleteDialog.ShowDialog()
            End If
        Else
            For Each Item As ListViewItem In ListView.SelectedItems
                My.Computer.FileSystem.DeleteDirectory(My.Settings.BkpsFolder + Item.Name, FileIO.DeleteDirectoryOption.DeleteAllContents)
                StreamWriter.WriteLine(LogTimeStamp() & "[INFO] Deleted backup " & My.Settings.BkpsFolder & Item.Name)
            Next
        End If
    End Sub

    Private Sub RenameButton_Click(sender As System.Object, e As System.EventArgs) Handles RenameButton.Click
        For Each Item As ListViewItem In ListView.SelectedItems
            RenameDialog.ItemName = Item.Name
        Next
        RenameDialog.ShowDialog()
    End Sub

    Private Sub BackupsFolderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackupsFolderToolStripMenuItem.Click
        Process.Start("explorer.exe", My.Settings.BkpsFolder)
    End Sub

    Private Sub WebsiteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WebsiteToolStripMenuItem.Click
        Process.Start("http://minecraft.nicoco007.com/tools/mcbackup")
    End Sub

    Private Sub ApplicationOptionsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ApplicationOptionsToolStripMenuItem.Click
        ApplicationOptionsDialog.ShowDialog()
    End Sub

    Private Sub RestoreButton_Click(sender As System.Object, e As System.EventArgs) Handles RestoreButton.Click
        ChangeProgressBarColor(ProgressBar.Handle, 1040, 1, 0)
        TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal)
        For Each Item As ListViewItem In ListView.SelectedItems
            If DateDiff("d", GetFolderDateCreated(My.Settings.BkpsFolder & "\" & Item.Name), Now) > 14 Then
                If MsgBox("Are you sure you want to restore to the selected backup? This will delete any existing data, and it is more than 2 weeks old!", MsgBoxStyle.YesNo, "Are you sure?") = MsgBoxResult.No Then
                    Exit Sub
                End If
            ElseIf MsgBox("Are you sure you want to restore to the selected backup? This will delete any existing data.", MsgBoxStyle.YesNo, "Are you sure?") = MsgBoxResult.No Then
                Exit Sub
            End If
            StreamWriter.WriteLine(LogTimeStamp() & "[INFO] Restoring backup """ & My.Settings.BkpsFolder & "\" & ItemName)
            ItemName = Item.Name
            If My.Computer.FileSystem.DirectoryExists(My.Settings.BkpsFolder & "\" & ItemName & "\bin") Then
                RestoreAll = True
                Source = My.Settings.BkpsFolder & "\" & ItemName
                Destination = My.Settings.MCFolder
            Else
                RestoreAll = False
                Source = My.Settings.BkpsFolder & "\" & ItemName & "\saves"
                Destination = My.Settings.MCFolder & "\saves"
            End If
        Next


        ClearBGW.RunWorkerAsync()
        ProgressBar.Style = ProgressBarStyle.Marquee
        StatusLabel.Text = "Removing old data... Please Wait."
    End Sub

    Private Sub ClearBGW_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles ClearBGW.DoWork
        If RestoreAll = True Then
            Dim Directory As New DirectoryInfo(My.Settings.MCFolder)
            Dim Folders As DirectoryInfo() = Directory.GetDirectories()
            Dim Folder As DirectoryInfo
            Dim Files As FileInfo() = Directory.GetFiles()
            Dim File As FileInfo

            For Each Folder In Folders
                My.Computer.FileSystem.DeleteDirectory(My.Settings.MCFolder & "\" & Folder.ToString, FileIO.DeleteDirectoryOption.DeleteAllContents)
            Next

            For Each File In Files
                My.Computer.FileSystem.DeleteFile(My.Settings.MCFolder & "\" & File.ToString)
            Next
        Else
            My.Computer.FileSystem.DeleteDirectory(My.Settings.MCFolder & "\saves", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
    End Sub

    Private Sub ClearBGW_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ClearBGW.RunWorkerCompleted
        RestoreTimer.Stop()
        If RestoreError = True Then
            StatusLabel.Text = "Error!"
            MCBackupNotify.ShowBalloonTip(2500, "MCBackup - Error!", "There was an error while restoring.", ToolTipIcon.Error)
            MsgBox("Error:" & vbNewLine & RestoreErrorDesc, MsgBoxStyle.Critical, "Error!")
            ChangeProgressBarColor(ProgressBar.Handle, 1040, 2, 0)
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error)
            StatusLabel.Text = "Ready!"
            Exit Sub
        End If

        ProgressBar.Style = ProgressBarStyle.Blocks
        ProgressBar.Value = 0
        TaskbarManager.Instance.SetProgressValue(0, 100)
        RestoreBGW.RunWorkerAsync()
        RestoreTimer.Start()
    End Sub

    Private Sub RestoreTimer_Tick(sender As System.Object, e As System.EventArgs) Handles RestoreTimer.Tick
        Dim SourceSize = GetFolderSize(Source)
        Dim DestinationSize = GetFolderSize(Destination)
        Dim PercentComplete As Integer = DestinationSize / SourceSize * 100
        If PercentComplete < 100 Then
            ProgressBar.Value = PercentComplete
            TaskbarManager.Instance.SetProgressValue(PercentComplete, 100)
            StatusLabel.Text = "Restoring... (" & PercentComplete.ToString & "% Complete)"
        End If
    End Sub

    Private Sub RestoreBGW_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles RestoreBGW.DoWork
        Try
            My.Computer.FileSystem.CopyDirectory(Source, Destination, True)
            RestoreError = False
        Catch ex As Exception
            RestoreError = True
            RestoreErrorDesc = ex.Message
        End Try
    End Sub

    Private Sub RestoreBGW_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles RestoreBGW.RunWorkerCompleted
        RestoreTimer.Stop()
        If RestoreError = True Then
            StatusLabel.Text = "Error!"
            MCBackupNotify.ShowBalloonTip(2500, "MCBackup - Error!", "There was an error while the restore.", ToolTipIcon.Error)
            MsgBox("Error:" & vbNewLine & RestoreErrorDesc, MsgBoxStyle.Critical, "Error!")
            ChangeProgressBarColor(ProgressBar.Handle, 1040, 2, 0)
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error)
            StatusLabel.Text = "Ready!"
            Exit Sub
        End If
        ProgressBar.Value = 100
        TaskbarManager.Instance.SetProgressValue(100, 100)
        StatusLabel.Text = "Restore Completed - Ready!"
        MCBackupNotify.ShowBalloonTip(2500, "MCBackup - Restore Completed!", "Your restore has finished!", ToolTipIcon.Info)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutDialog.ShowDialog()
    End Sub

    Private Sub ShowAutoBackupButton_Click(sender As Object, e As EventArgs) Handles ShowAutoBackupButton.Click
        If ShowAutoBackupButtonPressed = False Then
            ShowAutoBackupButtonPressed = True
            Me.Width = 1050
            ShowAutoBackupButton.Text = "Auto Backup <<"
        Else
            ShowAutoBackupButtonPressed = False
            Me.Width = 810
            ShowAutoBackupButton.Text = "Auto Backup >>"
        End If
    End Sub

    Dim SecondsLeft, MinutesLeft As Integer
    Dim AutoBackupStarted As Boolean = False

    Private Sub AutoBackupStart_Click(sender As Object, e As EventArgs) Handles StartAutoBackupButton.Click
        If AutoBackupStarted = False Then
            AutoBackupStarted = True
            MinutesLeft = TimeUpDown.Value
            TimeLeftLabel.Text = TimeToString(0, MinutesLeft)
            AutoBackupTimer.Start()
            StartAutoBackupButton.Text = "Stop Auto Backup"
        Else
            AutoBackupStarted = False
            TimeLeftLabel.Text = "00:00"
            AutoBackupTimer.Stop()
            StartAutoBackupButton.Text = "Start Auto Backup"
            SecondsLeft = 0
            MinutesLeft = 0
        End If
    End Sub

    Private Sub AutoBackupTimer_Tick(sender As Object, e As EventArgs) Handles AutoBackupTimer.Tick
        If MinutesLeft = 0 And SecondsLeft = 0 Then
            MinutesLeft = TimeUpDown.Value
            SecondsLeft = 0

            BackupName = BackupOptionsDialog.GetTime()
            BackupAll = False
            BackupButtonPressed = True
        End If

        TimeLeftLabel.Text = TimeToString(SecondsLeft, MinutesLeft)

        If SecondsLeft = 0 Then
            SecondsLeft = 59
            MinutesLeft = MinutesLeft - 1
        Else
            SecondsLeft = SecondsLeft - 1
        End If
    End Sub

    Private Function TimeToString(Seconds As Integer, Minutes As Integer)
        Dim SecondsString, MinutesString As String
        If Seconds < 10 Then
            SecondsString = "0" & Seconds
        Else
            SecondsString = Seconds
        End If

        If Minutes < 10 Then
            MinutesString = "0" & Minutes
        Else
            MinutesString = Minutes
        End If
        Return MinutesString + ":" + SecondsString
    End Function

    Private Sub ListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView.SelectedIndexChanged
        If ListView.SelectedItems.Count = 0 Then
            RestoreButton.Enabled = False
            DeleteButton.Enabled = False
            RenameButton.Enabled = False
        Else
            RestoreButton.Enabled = True
            DeleteButton.Enabled = True
            RenameButton.Enabled = True
        End If

        If ListView.SelectedItems.Count > 1 Then
            RestoreButton.Enabled = False
            RenameButton.Enabled = False
        End If
    End Sub

    Public Sub StartBackup()
        StreamWriter.WriteLine(LogTimeStamp() & "[INFO] Starting backup """ & BackupName & """")
        ChangeProgressBarColor(ProgressBar.Handle, 1040, 1, 0)
        TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal)
        If BackupAll = True Then
            Source = My.Settings.MCFolder
            Destination = My.Settings.BkpsFolder & "\" & BackupName
        Else
            Source = My.Settings.MCFolder & "\saves"
            Destination = My.Settings.BkpsFolder & "\" & BackupName & "\saves"
        End If

        BackupBGW.RunWorkerAsync()
        BackupTimer.Start()
    End Sub

    Private m_SortingColumn As ColumnHeader

    Private Sub ListView_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView.ColumnClick
        Dim NewSortingColumn As ColumnHeader = ListView.Columns(e.Column)

        If NewSortingColumn.Text = "Contents" Then
            Exit Sub
        End If

        Dim sort_order As System.Windows.Forms.SortOrder
        If m_SortingColumn Is Nothing Then
            sort_order = SortOrder.Ascending
        Else
            If NewSortingColumn.Equals(m_SortingColumn) Then
                If m_SortingColumn.Text.StartsWith("↑ ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                sort_order = SortOrder.Ascending
            End If

            m_SortingColumn.Text = m_SortingColumn.Text.Substring(2)
        End If

        m_SortingColumn = NewSortingColumn
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = "↑ " & m_SortingColumn.Text
        Else
            m_SortingColumn.Text = "↓ " & m_SortingColumn.Text
        End If

        ListView.ListViewItemSorter = New ListViewComparer(e.Column, sort_order)

        ListView.Sort()
    End Sub

    Private Sub Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If My.Settings.ShowWelcomeDialog = True Then
            WelcomeDialog.ShowDialog()
        End If
    End Sub

    Private Function LogTimeStamp()
        Dim Day As String = Format(Now(), "dd")
        Dim Month As String = Format(Now(), "MM")
        Dim Year As String = Format(Now(), "yyyy")
        Dim Hours As String = Format(Now(), "hh")
        Dim Minutes As String = Format(Now(), "mm")
        Dim Seconds As String = Format(Now(), "ss")

        Return Year & "-" & Month & "-" & Day & " " & Hours & ":" & Minutes & ":" & Seconds & " "
    End Function

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        StreamWriter.Close()
    End Sub
End Class