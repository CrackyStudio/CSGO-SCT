Public Class Form4
    Private Function GetFileVersionInfo(ByVal filename As String) As Version
        Return Version.Parse(FileVersionInfo.GetVersionInfo(filename).FileVersion)
    End Function
    Function Between(Val As String, a As String, b As String) As String
        Dim P1 As Integer = Val.IndexOf(a)
        Dim P2 As Integer = Val.LastIndexOf(b)
        If P1 = -1 Then
            Return ""
        End If
        If P2 = -1 Then
            Return ""
        End If
        Dim AP1 As Integer = P1 + a.Length
        If AP1 >= P2 Then
            Return ""
        End If
        Return Val.Substring(AP1, P2 - AP1)
    End Function
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim webAddress As String = "https://www.paypal.me/officialcracky/5"
        Process.Start(webAddress)
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
        Me.TopMost = True
        Dim SVS As String = New System.Net.WebClient().DownloadString("https://docs.google.com/document/d/1SlzPsYtAO2MWGwIN1tmpDaH_tJtaMBCImtv9CvruXTs")
        Dim Loc As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\CSGO SCT\"
        If (Not System.IO.Directory.Exists(Loc)) Then
            System.IO.Directory.CreateDirectory(Loc)
        End If
        My.Computer.FileSystem.WriteAllText(Loc & "\URLUp.txt", SVS, False)
        For Each VV As String In IO.File.ReadLines(Loc & "\URLUp.txt")
            If VV.Contains("Version 1.0") Then
                Me.TopMost = False
                Me.Hide()
                Form1.Show()
                Me.Close()
                Exit Sub
            Else
                Dim NV1 As String = VV
                Dim NV2 As String = Between(NV1, "property=""og:description"" content=", "><meta name=""google""").Replace(Chr(34), "")
                Dim AV As String = FileVersionInfo.GetVersionInfo(Application.ExecutablePath).FileVersion
                Label7.Text = "A new version is available, would you like to update?" & Chr(10) & "Actual: Version " & AV & Chr(10) & "New: " & NV2
            End If
            Exit Sub
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SDLLS As String = New System.Net.WebClient().DownloadString("https://drive.google.com/open?id=1XWh2-O5inkyF44hNitDlEau0uRZyluF1Qd17QK4xoT0")
        Dim SDLLFP As String = My.Application.Info.DirectoryPath
        My.Computer.FileSystem.WriteAllText(SDLLFP & "\SDLLS.txt", SDLLS, False)
        For Each V As String In IO.File.ReadLines(SDLLFP & "\SDLLS.txt")
            If V.Contains("property=""og:description"" content=") Then
                Dim V1 As String = V
                Dim V2 As String = Between(V1, "property=""og:description"" content=", "><meta name=""google""").Replace(Chr(34), "")
                Dim DLL As String = V2.Replace("&amp;", "&")
                Dim DLLFL As String = My.Application.Info.DirectoryPath & "\CSGO SCT UPDTD.exe"
                Dim DLLWC As New System.Net.WebClient()
                System.IO.File.WriteAllBytes(DLLFL, DLLWC.DownloadData(DLL))
                Dim CSGOSCTVer As String = GetFileVersionInfo(My.Application.Info.DirectoryPath & "\CSGO SCT UPDTD.exe").ToString
                My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\CSGO SCT UPDTD.exe", "CSGO SCT " & CSGOSCTVer & ".exe")
                Process.Start(My.Application.Info.DirectoryPath & "\CSGO SCT " & CSGOSCTVer & ".exe")
            End If
        Next
        If IO.File.Exists(SDLLFP & "\SDLLS.txt") Then
            My.Computer.FileSystem.DeleteFile(SDLLFP & "\SDLLS.txt")
        End If
        Dim Loc As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\CSGO SCT\"
        If IO.File.Exists(Loc & "\URLUp.txt") Then
            My.Computer.FileSystem.DeleteFile(Loc & "\URLUp.txt")
        End If
        Application.Exit()
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Loc As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\CSGO SCT\"
        If IO.File.Exists(Loc & "\URLUp.txt") Then
            My.Computer.FileSystem.DeleteFile(Loc & "\URLUp.txt")
        End If
        Me.TopMost = False
        Me.Hide()
        Form1.Show()
        Me.Close()
    End Sub
End Class