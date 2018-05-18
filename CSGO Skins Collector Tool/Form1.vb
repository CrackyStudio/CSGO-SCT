'_________                       __
'\_   ___ \____________    ____ |  | _____.__.
'/    \  \/\_  __ \__  \ _/ ___\|  |/ <   |  |
'\     \____|  | \// __ \\  \___|    < \___  |
' \______  /|__|  (____  /\___  >__|_ \/ ____|
'        \/            \/     \/     \/\/  
'This freeware was developed by Cracky
'http://steamcommunity.com/id/officialcracky/
'This code is free to use - If you use it, give credits
Imports System
Imports System.Environment
Imports System.IO
Imports System.Net
Imports System.Text
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Application.Exit()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim webAddress As String = "https://www.paypal.me/officialcracky/5"
        Process.Start(webAddress)
    End Sub
    Public Sub DeleteLineFromFile(fp As String, lineToDelete As Func(Of String, Boolean))
        IO.File.WriteAllLines(fp, IO.File.ReadLines(fp).Where(lineToDelete).ToArray)
    End Sub
    Function Between(value As String, a As String, b As String) As String
        Dim posA As Integer = value.IndexOf(a)
        Dim posB As Integer = value.LastIndexOf(b)
        If posA = -1 Then
            Return ""
        End If
        If posB = -1 Then
            Return ""
        End If
        Dim adjustedPosA As Integer = posA + a.Length
        If adjustedPosA >= posB Then
            Return ""
        End If
        Return value.Substring(adjustedPosA, posB - adjustedPosA)
    End Function
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim webAddress As String = "http://store.steampowered.com/"
        Process.Start(webAddress)
    End Sub
    Private Sub LabelMouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.MouseEnter
        Dim newFont As New Font(Label6.Font.Name, Label6.Font.Size, FontStyle.Underline)
        Label6.Font = newFont
    End Sub
    Private Sub LabelMouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.MouseLeave
        Dim newFont2 As New Font(Label6.Font.Name, Label6.Font.Size, FontStyle.Regular)
        Label6.Font = newFont2
    End Sub
    Private Sub TextBox1_MouseClick(sender As Object, e As EventArgs) Handles TextBox1.MouseClick
        TextBox1.Text = ""
    End Sub
    Private Sub TextBox1_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles TextBox1.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
#Region "Settings"
        Dim filePath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\CSGO SCT\"
        If (Not System.IO.Directory.Exists(filePath)) Then
            System.IO.Directory.CreateDirectory(filePath)
        End If
        For Each _file As String In Directory.GetFiles(filePath)
            File.Delete(_file)
        Next
        PictureBox1.Image = Nothing
        Label4.Text = "Pseudo: "
        Label8.Text = "Data Grabbed:"
        Label9.Text = "Listing Items:"
        Label5.BackColor = Color.DarkGray
        Label4.Refresh()
        Label8.Refresh()
        Label9.Refresh()
        Label5.Refresh()
        If InStr(TextBox1.Text, "http://steamcommunity.com/id/") OrElse InStr(TextBox1.Text, "http://steamcommunity.com/profiles/") OrElse InStr(TextBox1.Text, "https://steamcommunity.com/id/") OrElse InStr(TextBox1.Text, "https://steamcommunity.com/profiles/") Then
        Else
            Form2.Show()
            TextBox1.Text = ""
            Me.Hide()
            Exit Sub
        End If
#End Region
#Region "Identify"
        Dim sourceString As String = New System.Net.WebClient().DownloadString(TextBox1.Text)
        My.Computer.FileSystem.WriteAllText(filePath & "Identity.txt", sourceString, False)
        For Each l As String In IO.File.ReadLines(filePath & "Identity.txt")
            If l.Contains("<div class=""playerAvatarAutoSizeInner""><img src=""") Then
                Dim mystr As String = IO.File.ReadAllLines(filePath & "Identity.txt").FirstOrDefault(Function(x) x.Contains("<div class=""playerAvatarAutoSizeInner""><img src="""))
                Dim cut_at As String = "src="""
                Dim cut_at2 As String = """,""personname"""
                Dim xev As Integer = InStr(mystr, cut_at)
                Dim string_after As String = mystr.Substring(xev + cut_at2.Length - 10)
                PictureBox1.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(string_after.Substring(0, string_after.Length - 8))))
            End If
        Next
        For Each m As String In IO.File.ReadLines(filePath & "Identity.txt")
            If m.Contains("<div class=""playerAvatar profile_header_size online") Then
                Label5.BackColor = Color.LightSkyBlue
            ElseIf m.Contains("<div class=""playerAvatar profile_header_size in-game") Then
                Label5.BackColor = Color.LimeGreen
            ElseIf m.Contains("<div class=""playerAvatar profile_header_size offline") Then
                Label5.BackColor = Color.DarkGray
            End If
            Label5.Refresh()
        Next
        For Each n As String In IO.File.ReadLines(filePath & "Identity.txt")
            If n.Contains("<span class=""actual_persona_name"">") Then
                Dim mystr As String = IO.File.ReadAllLines(filePath & "Identity.txt").FirstOrDefault(Function(x) x.Contains("<span class=""actual_persona_name"">"))
                Dim cut_at As String = "name"">"
                Dim cut_at2 As String = """,""personname"""
                Dim xev As Integer = InStr(mystr, cut_at)
                Dim string_after As String = mystr.Substring(xev + cut_at2.Length - 10)
                Dim Encw1252 As Encoding = Encoding.GetEncoding("windows-1252")
                Dim EncUTF8 As Encoding = Encoding.GetEncoding("utf-8")
                Dim Str As String
                Str = "Pseudo:  " & string_after.Substring(1, string_after.Length - 8)
                Str = Encw1252.GetString(Encoding.Convert(EncUTF8, Encw1252, Encoding.Default.GetBytes(Str)))
                Label4.Text = Str
                Label4.Refresh()
            End If
        Next
#End Region
#Region "Grab Data"
        PictureBox1.Refresh()
        Label4.Refresh()
        Dim AppPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\CSGO SCT\"
        Dim FileName As String = "Item"
        Dim FileNumber As Integer = 1
        Dim FileExtension As String = ".txt"
        Dim ItemsLink As String = New System.Net.WebClient().DownloadString(TextBox1.Text & "/inventory/json/730/2/")
        My.Computer.FileSystem.WriteAllText(AppPath & "730Items.txt", ItemsLink, False)
        My.Computer.FileSystem.WriteAllText(AppPath & "730Items1.txt", My.Computer.FileSystem.ReadAllText(AppPath & "730Items.txt").Replace("}]},", vbCrLf), False)
        My.Computer.FileSystem.DeleteFile(AppPath & "730Items.txt")
        Dim Lines As New List(Of String)(IO.File.ReadAllLines(AppPath & "730Items1.txt"))
        Do
            Dim ItemDataFile As String = IO.File.ReadAllLines(AppPath & "730Items1.txt").FirstOrDefault(Function(x) x.Contains("""name"""))
            If ItemDataFile IsNot Nothing Then
                Using sw As StreamWriter = File.AppendText(AppPath & FileName & FileNumber & FileExtension)
                    sw.WriteLine(Between(ItemDataFile, """name""", """name_color"""))
                    sw.Close()
                    FileNumber = FileNumber + 1
                    Label8.Text = "Data Grabbed:   " & FileNumber - 1
                    Label8.Refresh()
                End Using
                Lines.RemoveAt(0)
                IO.File.WriteAllLines(AppPath & "730Items1.txt", Lines.ToArray())
            Else
                IO.File.Delete(AppPath & "730Items1.txt")
                Exit Do
            End If
        Loop
        Label8.Text = Label8.Text & "/" & FileNumber - 1
        Label8.Refresh()
#End Region
#Region "List Items"
        Dim FileNumber1 As Integer = 1
        Dim DI As New IO.DirectoryInfo(AppPath)
        Dim FIGF As IO.FileInfo() = DI.GetFiles()
        Dim FI As IO.FileInfo
        For Each FI In FIGF
            If IO.File.Exists(AppPath & FileName & FileNumber1 & FileExtension) Then
                Dim FileToRead As String = IO.File.ReadAllLines(AppPath & FileName & FileNumber1 & FileExtension).FirstOrDefault(Function(x) x.Contains(":"""))
                Using sw As StreamWriter = File.AppendText(AppPath & "Items" & FileExtension)
                    sw.WriteLine(Between(FileToRead, ":""", """,""market_hash_name"))
                    sw.Close()
                    IO.File.Delete(AppPath & FileName & FileNumber1 & FileExtension)
                    FileNumber1 = FileNumber1 + 1
                    Label9.Text = "Listing Items:   " & FileNumber1 - 1
                    Label9.Refresh()
                End Using
            End If
        Next
        My.Computer.FileSystem.WriteAllText(AppPath & "Items" & FileExtension, My.Computer.FileSystem.ReadAllText(AppPath & "Items" & FileExtension).Replace("\u2122", " -"), False)
        My.Computer.FileSystem.WriteAllText(AppPath & "Items" & FileExtension, My.Computer.FileSystem.ReadAllText(AppPath & "Items" & FileExtension).Replace("\u2605 ", ""), False)
        Label9.Text = Label9.Text & "/" & FileNumber1 - 1
        Label9.Refresh()
#End Region
#Region "New Form"
        Form3.Show()
        Me.Hide()
#End Region
    End Sub
End Class
'  _________ __
' /   _____//  |_  ____ _____    _____  
' \_____  \\   __\/ __ \\__  \  /     \ 
' /        \|  | \  ___/ / __ \|  Y Y  \
'/_______  /|__|  \___  >____  /__|_|  /
'        \/           \/     \/      \/      
'http://store.steampowered.com/
'Powered by Steam
'CSGO Skins Collector Tool and Cracky are not affiliated with anyone. All trademarks and registered trademarks are the property of their respective owners. 