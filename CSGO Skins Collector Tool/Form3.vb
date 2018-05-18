Imports System.IO
Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label34.Text = Form1.TextBox1.Text
        Dim filePath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\CSGO SCT\"
        Dim Num As Integer = 0
        For Each m As String In IO.File.ReadLines(filePath & "Items.txt")
            If m.Contains("AK-47") Or m.Contains("AUG") Or m.Contains("AWP") Or m.Contains("Bayonet") Or m.Contains("Bowie Knife") Or m.Contains("Butterfly Knife") Or m.Contains("CZ75-Auto") Or m.Contains("Desert Eagle") Or m.Contains("Dual Berettas") Or m.Contains("Falchion Knife") Or m.Contains("FAMAS") Or m.Contains("Five-SeveN") Or m.Contains("Flip Knife") Or m.Contains("G3SG1") Or m.Contains("Galil AR") Or m.Contains("Glock-18") Or m.Contains("Gut Knife") Or m.Contains("Huntsman Knife") Or m.Contains("Karambit") Or m.Contains("M249") Or m.Contains("M4A1-S") Or m.Contains("M4A4") Or m.Contains("M9 Bayonet") Or m.Contains("MAC-10") Or m.Contains("MAG-7") Or m.Contains("MP7") Or m.Contains("MP9") Or m.Contains("Negev") Or m.Contains("Nova") Or m.Contains("P2000") Or m.Contains("P250") Or m.Contains("P90") Or m.Contains("PP-Bizon") Or m.Contains("R8-Revolver") Or m.Contains("Sawed-Off") Or m.Contains("SCAR-20") Or m.Contains("SG 553") Or m.Contains("Shadow Daggers") Or m.Contains("SSG 08") Or m.Contains("Tec-9") Or m.Contains("UMP45") Or m.Contains("USP-S") Or m.Contains("XM1014") Then
                Num = Num + 1
            End If
        Next
        Dim Rema As Integer = 885 - Num
        Label33.Text = "You own " & Num & " weapons skins. " & Rema & " remaining. " & Num & "/885"
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Application.Exit()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim webAddress As String = "https://www.paypal.me/officialcracky/5"
        Process.Start(webAddress)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim AppPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\CSGO SCT\"
        Dim FileExtension As String = ".txt"
        Dim text As String = File.ReadAllText(AppPath & "Items" & FileExtension)
#Region "Reset"
        Label3.Text = ""
        PictureBox3.Show()
        Label4.Text = ""
        PictureBox4.Show()
        Label5.Text = ""
        PictureBox5.Show()
        Label6.Text = ""
        PictureBox6.Show()
        Label7.Text = ""
        PictureBox7.Show()
        Label8.Text = ""
        PictureBox8.Show()
        Label9.Text = ""
        PictureBox9.Show()
        Label10.Text = ""
        PictureBox10.Show()
        Label11.Text = ""
        PictureBox11.Show()
        Label12.Text = ""
        PictureBox12.Show()
        Label13.Text = ""
        PictureBox13.Show()
        Label14.Text = ""
        PictureBox14.Show()
        Label15.Text = ""
        PictureBox15.Show()
        Label16.Text = ""
        PictureBox16.Show()
        Label17.Text = ""
        PictureBox17.Show()
        Label18.Text = ""
        PictureBox18.Show()
        Label19.Text = ""
        PictureBox19.Show()
        Label20.Text = ""
        PictureBox20.Show()
        Label21.Text = ""
        PictureBox21.Show()
        Label22.Text = ""
        PictureBox22.Show()
        Label23.Text = ""
        PictureBox23.Show()
        Label24.Text = ""
        PictureBox24.Show()
        Label25.Text = ""
        PictureBox25.Show()
        Label26.Text = ""
        PictureBox26.Show()
        Label27.Text = ""
        PictureBox27.Show()
        Label28.Text = ""
        PictureBox28.Show()
        Label29.Text = ""
        PictureBox29.Show()
        Label30.Text = ""
        PictureBox30.Show()
        Label31.Text = ""
        PictureBox31.Show()
        Label32.Text = ""
        PictureBox32.Show()
#End Region
        Select Case ComboBox1.Text
#Region "AK-47"
            Case "AK-47"
                Label3.Text = "AK-47 | The Empress"
                Dim AK3 As Integer = text.IndexOf("AK-47 | The Empress")
                If AK3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "AK-47 | Bloodsport"
                Dim AK4 As Integer = text.IndexOf("AK-47 | Bloodsport")
                If AK4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "AK-47 | Neon Revolution"
                Dim AK5 As Integer = text.IndexOf("AK-47 | Neon Revolution")
                If AK5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "AK-47 | Fuel Injector"
                Dim AK6 As Integer = text.IndexOf("AK-47 | Fuel Injector")
                If AK6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "AK-47 | Aquamarine Revenge"
                Dim AK7 As Integer = text.IndexOf("AK-47 | Aquamarine Revenge")
                If AK7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "AK-47 | Wasteland Rebel"
                Dim AK8 As Integer = text.IndexOf("AK-47 | Wasteland Rebel")
                If AK8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                ' 
                Label9.Text = "AK-47 | Jaguar"
                Dim AK9 As Integer = text.IndexOf("AK-47 | Jaguar")
                If AK9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "AK-47 | Vulcan"
                Dim AK10 As Integer = text.IndexOf("AK-47 | Vulcan")
                If AK10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "AK-47 | Fire Serpent"
                Dim AK11 As Integer = text.IndexOf("AK-47 | Fire Serpent")
                If AK11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "AK-47 | Point Disarray"
                Dim AK12 As Integer = text.IndexOf("AK-47 | Point Disarray")
                If AK12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "AK-47 | Frontside Misty"
                Dim AK13 As Integer = text.IndexOf("AK-47 | Frontside Misty")
                If AK13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "AK-47 | Cartel"
                Dim AK14 As Integer = text.IndexOf("AK-47 | Cartel")
                If AK14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "AK-47 | Redline"
                Dim AK15 As Integer = text.IndexOf("AK-47 | Redline")
                If AK15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "AK-47 | Red Laminate"
                Dim AK16 As Integer = text.IndexOf("AK-47 | Red Laminate")
                If AK16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "AK-47 | Case Hardened"
                Dim AK17 As Integer = text.IndexOf("AK-47 | Case Hardened")
                If AK17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "AK-47 | Hydroponic"
                Dim AK18 As Integer = text.IndexOf("AK-47 | Hydroponic")
                If AK18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "AK-47 | Jet Set"
                Dim AK19 As Integer = text.IndexOf("AK-47 | Jet Set")
                If AK19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "AK-47 | Orbit Mk01"
                Dim AK20 As Integer = text.IndexOf("AK-47 | Orbit Mk01")
                If AK20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "AK-47 | Blue Laminate"
                Dim AK21 As Integer = text.IndexOf("AK-47 | Blue Laminate")
                If AK21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "AK-47 | First Class"
                Dim AK22 As Integer = text.IndexOf("AK-47 | First Class")
                If AK22 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "AK-47 | Emerald Pinstripe"
                Dim AK23 As Integer = text.IndexOf("AK-47 | Emerald Pinstripe")
                If AK23 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                Label24.Text = "AK-47 | Elite Build"
                Dim AK24 As Integer = text.IndexOf("AK-47 | Elite Build")
                If AK24 >= 0 Then
                    PictureBox24.Image = My.Resources.GotBox
                Else
                    PictureBox24.Image = My.Resources.NotGotBox
                End If
                '
                Label25.Text = "AK-47 | Black Laminate"
                Dim AK25 As Integer = text.IndexOf("AK-47 | Black Laminate")
                If AK25 >= 0 Then
                    PictureBox25.Image = My.Resources.GotBox
                Else
                    PictureBox25.Image = My.Resources.NotGotBox
                End If
                '
                Label26.Text = "AK-47 | Safari Mesh"
                Dim AK26 As Integer = text.IndexOf("AK-47 | Safari Mesh")
                If AK26 >= 0 Then
                    PictureBox26.Image = My.Resources.GotBox
                Else
                    PictureBox26.Image = My.Resources.NotGotBox
                End If
                '
                Label27.Text = "AK-47 | Jungle Spray"
                Dim AK27 As Integer = text.IndexOf("AK-47 | Jungle Spray")
                If AK26 >= 0 Then
                    PictureBox27.Image = My.Resources.GotBox
                Else
                    PictureBox27.Image = My.Resources.NotGotBox
                End If
                '
                Label28.Text = "AK-47 | Predator"
                Dim AK28 As Integer = text.IndexOf("AK-47 | Predator")
                If AK28 >= 0 Then
                    PictureBox28.Image = My.Resources.GotBox
                Else
                    PictureBox28.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "AUG"
            Case "AUG"
                Label3.Text = "AUG | Chameleon"
                Dim AUG3 As Integer = text.IndexOf("AUG | Chameleon")
                If AUG3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "AUG | Akihabara Accept"
                Dim AUG4 As Integer = text.IndexOf("AUG | Akihabara Accept")
                If AUG4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "AUG | Syd Mead"
                Dim AUG5 As Integer = text.IndexOf("AUG | Syd Mead")
                If AUG5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "AUG | Fleet Flock"
                Dim AUG6 As Integer = text.IndexOf("AUG | Fleet Flock")
                If AUG6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "AUG | Bengal Tiger"
                Dim AUG7 As Integer = text.IndexOf("AUG | Bengal Tiger")
                If AUG7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "AUG | Aristocrat"
                Dim AUG8 As Integer = text.IndexOf("AUG | Aristocrat")
                If AUG8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "AUG | Torque"
                Dim AUG9 As Integer = text.IndexOf("AUG | Torque")
                If AUG9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "AUG | Triqua"
                Dim AUG10 As Integer = text.IndexOf("AUG | Triqua")
                If AUG10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "AUG | Ricochet"
                Dim AUG11 As Integer = text.IndexOf("AUG | Ricochet")
                If AUG11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "AUG | Wings"
                Dim AUG12 As Integer = text.IndexOf("AUG | Wings")
                If AUG12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "AUG | Anodized Navy"
                Dim AUG13 As Integer = text.IndexOf("AUG | Anodized Navy")
                If AUG13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "AUG | Hot Rod"
                Dim AUG14 As Integer = text.IndexOf("AUG | Hot Rod")
                If AUG14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "AUG | Copperhead"
                Dim AUG15 As Integer = text.IndexOf("AUG | Copperhead")
                If AUG15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "AUG | Radiation Hazard"
                Dim AUG16 As Integer = text.IndexOf("AUG | Radiation Hazard")
                If AUG16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "AUG | Condemned"
                Dim AUG17 As Integer = text.IndexOf("AUG | Condemned")
                If AUG17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "AUG | Daedalus"
                Dim AUG18 As Integer = text.IndexOf("AUG | Daedalus")
                If AUG18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "AUG | Storm"
                Dim AUG19 As Integer = text.IndexOf("AUG | Storm")
                If AUG19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "AUG | Contractor"
                Dim AUG20 As Integer = text.IndexOf("AUG | Contractor")
                If AUG20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "AUG | Colony"
                Dim AUG21 As Integer = text.IndexOf("AUG | Colony")
                If AUG21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox22.Hide()
                PictureBox23.Hide()
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "AWP"
            Case "AWP"
                Label3.Text = "AWP | Oni Taiji"
                Dim AWP3 As Integer = text.IndexOf("AWP | Oni Taiji")
                If AWP3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "AWP | Hyper Beast"
                Dim AWP4 As Integer = text.IndexOf("AWP | Hyper Beast")
                If AWP4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "AWP | Man-o'-war"
                Dim AWP5 As Integer = text.IndexOf("AWP | Man-o'-war")
                If AWP5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "AWP | Asiimov"
                Dim AWP6 As Integer = text.IndexOf("AWP | Asiimov")
                If AWP6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "AWP | Lightning Strike"
                Dim AWP7 As Integer = text.IndexOf("AWP | Lightning Strike")
                If AWP7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "AWP | Medusa"
                Dim AWP8 As Integer = text.IndexOf("AWP | Medusa")
                If AWP8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "AWP | Dragon Lore"
                Dim AWP9 As Integer = text.IndexOf("AWP | Dragon Lore")
                If AWP9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "AWP | Fever Dream"
                Dim AWP10 As Integer = text.IndexOf("AWP | Fever Dream")
                If AWP10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "AWP | Elite Build"
                Dim AWP11 As Integer = text.IndexOf("AWP | Elite Build")
                If AWP11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "AWP | Corticera"
                Dim AWP12 As Integer = text.IndexOf("AWP | Corticera")
                If AWP12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "AWP | Redline"
                Dim AWP13 As Integer = text.IndexOf("AWP | Redline")
                If AWP13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "AWP | Electric Hive"
                Dim AWP14 As Integer = text.IndexOf("AWP | Electric Hive")
                If AWP14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "AWP | Graphite"
                Dim AWP15 As Integer = text.IndexOf("AWP | Graphite")
                If AWP15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "AWP | BOOM"
                Dim AWP16 As Integer = text.IndexOf("AWP | BOOM")
                If AWP16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "AWP | Phobos"
                Dim AWP17 As Integer = text.IndexOf("AWP | Phobos")
                If AWP17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "AWP | Worm God"
                Dim AWP18 As Integer = text.IndexOf("AWP | Worm God")
                If AWP18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "AWP | Pink DDPAT"
                Dim AWP19 As Integer = text.IndexOf("AWP | Pink DDPAT")
                If AWP19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "AWP | Pit Viper"
                Dim AWP20 As Integer = text.IndexOf("AWP | Pit Viper")
                If AWP20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "AWP | Snake Camo"
                Dim AWP21 As Integer = text.IndexOf("AWP | Snake Camo")
                If AWP21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "AWP | Sun in Leo"
                Dim AWP22 As Integer = text.IndexOf("AWP | Sun in Leo")
                If AWP22 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "AWP | Safari Mesh"
                Dim AWP23 As Integer = text.IndexOf("AWP | Safari Mesh")
                If AWP23 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "Bayonet"
            Case "Bayonet"
                Label3.Text = "Bayonet"
                Dim Bayonet3 As Integer = text.IndexOf("Bayonet")
                If Bayonet3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "Bayonet | Lore"
                Dim Bayonet4 As Integer = text.IndexOf("Bayonet | Lore")
                If Bayonet4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "Bayonet | Gamma Doppler"
                Dim Bayonet5 As Integer = text.IndexOf("Bayonet | Gamma Doppler")
                If Bayonet5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "Bayonet | Autotronic"
                Dim Bayonet6 As Integer = text.IndexOf("Bayonet | Autotronic")
                If Bayonet6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "Bayonet | Freehand"
                Dim Bayonet7 As Integer = text.IndexOf("Bayonet | Freehand")
                If Bayonet7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "Bayonet | Black Laminate"
                Dim Bayonet8 As Integer = text.IndexOf("Bayonet | Black Laminate")
                If Bayonet8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "Bayonet | Bright Water"
                Dim Bayonet9 As Integer = text.IndexOf("Bayonet | Bright Water")
                If Bayonet9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "Bayonet | Marble Fade"
                Dim Bayonet10 As Integer = text.IndexOf("Bayonet | Marble Fade")
                If Bayonet10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "Bayonet | Tiger Tooth"
                Dim Bayonet11 As Integer = text.IndexOf("Bayonet | Tiger Tooth")
                If Bayonet11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "Bayonet | Doppler"
                Dim Bayonet12 As Integer = text.IndexOf("Bayonet | Doppler")
                If Bayonet12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "Bayonet | Ultraviolet"
                Dim Bayonet13 As Integer = text.IndexOf("Bayonet | Ultraviolet")
                If Bayonet13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "Bayonet | Damascus Steel"
                Dim Bayonet14 As Integer = text.IndexOf("Bayonet | Damascus Steel")
                If Bayonet14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "Bayonet | Rust Coat"
                Dim Bayonet15 As Integer = text.IndexOf("Bayonet | Rust Coat")
                If Bayonet15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "Bayonet | Fade"
                Dim Bayonet16 As Integer = text.IndexOf("Bayonet | Fade")
                If Bayonet16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "Bayonet | Slaughter"
                Dim Bayonet17 As Integer = text.IndexOf("Bayonet | Slaughter")
                If Bayonet17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "Bayonet | Case Hardened"
                Dim Bayonet18 As Integer = text.IndexOf("Bayonet | Case Hardened")
                If Bayonet18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "Bayonet | Crimson Web"
                Dim Bayonet19 As Integer = text.IndexOf("Bayonet | Crimson Web")
                If Bayonet19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "Bayonet | Blue Steel"
                Dim Bayonet20 As Integer = text.IndexOf("Bayonet | Blue Steel")
                If Bayonet20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "Bayonet | Night"
                Dim Bayonet21 As Integer = text.IndexOf("Bayonet | Night")
                If Bayonet21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "Bayonet | Scorched"
                Dim Bayonet22 As Integer = text.IndexOf("Bayonet | Scorched")
                If Bayonet22 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "Bayonet | Stained"
                Dim Bayonet23 As Integer = text.IndexOf("Bayonet | Stained")
                If Bayonet23 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                Label24.Text = "Bayonet | Urban Masked"
                Dim Bayonet24 As Integer = text.IndexOf("Bayonet | Urban Masked")
                If Bayonet24 >= 0 Then
                    PictureBox24.Image = My.Resources.GotBox
                Else
                    PictureBox24.Image = My.Resources.NotGotBox
                End If
                '
                Label25.Text = "Bayonet | Safari Mesh"
                Dim Bayonet25 As Integer = text.IndexOf("Bayonet | Safari Mesh")
                If Bayonet25 >= 0 Then
                    PictureBox25.Image = My.Resources.GotBox
                Else
                    PictureBox25.Image = My.Resources.NotGotBox
                End If
                '
                Label26.Text = "Bayonet | Boreal Forest"
                Dim Bayonet26 As Integer = text.IndexOf("Bayonet | Boreal Forest")
                If Bayonet26 >= 0 Then
                    PictureBox26.Image = My.Resources.GotBox
                Else
                    PictureBox26.Image = My.Resources.NotGotBox
                End If
                '
                Label27.Text = "Bayonet | Forest DDPAT"
                Dim Bayonet27 As Integer = text.IndexOf("Bayonet | Forest DDPAT")
                If Bayonet27 >= 0 Then
                    PictureBox27.Image = My.Resources.GotBox
                Else
                    PictureBox27.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "Bowie Knife"
            Case "Bowie Knife"
                Label3.Text = "Bowie Knife"
                Dim BowieKnife3 As Integer = text.IndexOf("Bowie Knife")
                If BowieKnife3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "Bowie Knife | Doppler"
                Dim BowieKnife4 As Integer = text.IndexOf("Bowie Knife | Doppler")
                If BowieKnife4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "Bowie Knife | Marble Fade"
                Dim BowieKnife5 As Integer = text.IndexOf("Bowie Knife | Marble Fade")
                If BowieKnife5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "Bowie Knife | Tiger Tooth"
                Dim BowieKnife6 As Integer = text.IndexOf("Bowie Knife | Tiger Tooth")
                If BowieKnife6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "Bowie Knife | Ultraviolet"
                Dim BowieKnife7 As Integer = text.IndexOf("Bowie Knife | Ultraviolet")
                If BowieKnife7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "Bowie Knife | Damascus Steel"
                Dim BowieKnife8 As Integer = text.IndexOf("Bowie Knife | Damascus Steel")
                If BowieKnife8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "Bowie Knife | Rust Coat"
                Dim BowieKnife9 As Integer = text.IndexOf("Bowie Knife | Rust Coat")
                If BowieKnife9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "Bowie Knife | Fade"
                Dim BowieKnife10 As Integer = text.IndexOf("Bowie Knife | Fade")
                If BowieKnife10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "Bowie Knife | Slaughter"
                Dim BowieKnife11 As Integer = text.IndexOf("Bowie Knife | Slaughter")
                If BowieKnife11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "Bowie Knife | Crimson Web"
                Dim BowieKnife12 As Integer = text.IndexOf("Bowie Knife | Crimson Web")
                If BowieKnife12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "Bowie Knife | Case Hardened"
                Dim BowieKnife13 As Integer = text.IndexOf("Bowie Knife | Case Hardened")
                If BowieKnife13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "Bowie Knife | Forest DDPAT"
                Dim BowieKnife14 As Integer = text.IndexOf("Bowie Knife | Forest DDPAT")
                If BowieKnife14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "Bowie Knife | Stained"
                Dim BowieKnife15 As Integer = text.IndexOf("Bowie Knife | Stained")
                If BowieKnife15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "Bowie Knife | Scorched"
                Dim BowieKnife16 As Integer = text.IndexOf("Bowie Knife | Scorched")
                If BowieKnife16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "Bowie Knife | Blue Steel"
                Dim BowieKnife17 As Integer = text.IndexOf("Bowie Knife | Blue Steel")
                If BowieKnife17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "Bowie Knife | Urban Masked"
                Dim BowieKnife18 As Integer = text.IndexOf("Bowie Knife | Urban Masked")
                If BowieKnife18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "Bowie Knife | Night"
                Dim BowieKnife19 As Integer = text.IndexOf("Bowie Knife | Night")
                If BowieKnife19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "Bowie Knife | Boreal Forest"
                Dim BowieKnife20 As Integer = text.IndexOf("Bowie Knife | Boreal Forest")
                If BowieKnife20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "Bowie Knife | Safari Mesh"
                Dim BowieKnife21 As Integer = text.IndexOf("Bowie Knife | Safari Mesh")
                If BowieKnife21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox22.Hide()
                PictureBox23.Hide()
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "Butterfly Knife"
            Case "Butterfly Knife"
                Label3.Text = "Butterfly Knife"
                Dim ButterflyKnife3 As Integer = text.IndexOf("Butterfly Knife")
                If ButterflyKnife3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "Butterfly Knife | Doppler"
                Dim ButterflyKnife4 As Integer = text.IndexOf("Butterfly Knife | Doppler")
                If ButterflyKnife4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "Butterfly Knife | Marble Fade"
                Dim ButterflyKnife5 As Integer = text.IndexOf("Butterfly Knife | Marble Fade")
                If ButterflyKnife5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "Butterfly Knife | Tiger Tooth"
                Dim ButterflyKnife6 As Integer = text.IndexOf("Butterfly Knife | Tiger Tooth")
                If ButterflyKnife6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "Butterfly Knife | Damascus Steel"
                Dim ButterflyKnife7 As Integer = text.IndexOf("Butterfly Knife | Damascus Steel")
                If ButterflyKnife7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "Butterfly Knife | Ultraviolet"
                Dim ButterflyKnife8 As Integer = text.IndexOf("Butterfly Knife | Ultraviolet")
                If ButterflyKnife8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "Butterfly Knife | Rust Coat"
                Dim ButterflyKnife9 As Integer = text.IndexOf("Butterfly Knife | Rust Coat")
                If ButterflyKnife9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "Butterfly Knife | Fade"
                Dim ButterflyKnife10 As Integer = text.IndexOf("Butterfly Knife | Fade")
                If ButterflyKnife10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "Butterfly Knife | Slaughter"
                Dim ButterflyKnife11 As Integer = text.IndexOf("Butterfly Knife | Slaughter")
                If ButterflyKnife11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "Butterfly Knife | Crimson Web"
                Dim ButterflyKnife12 As Integer = text.IndexOf("Butterfly Knife | Crimson Web")
                If ButterflyKnife12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "Butterfly Knife | Case Hardened"
                Dim ButterflyKnife13 As Integer = text.IndexOf("Butterfly Knife | Case Hardened")
                If ButterflyKnife13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "Butterfly Knife | Blue Steel"
                Dim ButterflyKnife14 As Integer = text.IndexOf("Butterfly Knife | Blue Steel")
                If ButterflyKnife14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "Butterfly Knife | Night"
                Dim ButterflyKnife15 As Integer = text.IndexOf("Butterfly Knife | Night")
                If ButterflyKnife15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "Butterfly Knife | Boreal Forest"
                Dim ButterflyKnife16 As Integer = text.IndexOf("Butterfly Knife | Boreal Forest")
                If ButterflyKnife16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "Butterfly Knife | Safari Mesh"
                Dim ButterflyKnife17 As Integer = text.IndexOf("Butterfly Knife | Safari Mesh")
                If ButterflyKnife17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "Butterfly Knife | Stained"
                Dim ButterflyKnife18 As Integer = text.IndexOf("Butterfly Knife | Stained")
                If ButterflyKnife18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "Butterfly Knife | Scorched"
                Dim ButterflyKnife19 As Integer = text.IndexOf("Butterfly Knife | Scorched")
                If ButterflyKnife19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "Butterfly Knife | Urban Masked"
                Dim ButterflyKnife20 As Integer = text.IndexOf("Butterfly Knife | Urban Masked")
                If ButterflyKnife20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "Butterfly Knife | Forest DDPAT"
                Dim ButterflyKnife21 As Integer = text.IndexOf("Butterfly Knife | Forest DDPAT")
                If ButterflyKnife21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox22.Hide()
                PictureBox23.Hide()
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "CZ75-Auto"
            Case "CZ75-Auto"
                Label3.Text = "CZ75-Auto | Victoria"
                Dim CZ75Auto3 As Integer = text.IndexOf("CZ75-Auto | Victoria")
                If CZ75Auto3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "CZ75-Auto | Xiangliu"
                Dim CZ75Auto4 As Integer = text.IndexOf("CZ75-Auto | Xiangliu")
                If CZ75Auto4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "CZ75-Auto | Yellow Jacket"
                Dim CZ75Auto5 As Integer = text.IndexOf("CZ75-Auto | Yellow Jacket")
                If CZ75Auto5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "CZ75-Auto | The Fuschia Is Now"
                Dim CZ75Auto6 As Integer = text.IndexOf("CZ75-Auto | The Fuschia Is Now")
                If CZ75Auto6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "CZ75-Auto | Tacticat"
                Dim CZ75Auto7 As Integer = text.IndexOf("CZ75-Auto | Tacticat")
                If CZ75Auto7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "CZ75-Auto | Red Astor"
                Dim CZ75Auto8 As Integer = text.IndexOf("CZ75-Auto | Red Astor")
                If CZ75Auto8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "CZ75-Auto | Pole Position"
                Dim CZ75Auto9 As Integer = text.IndexOf("CZ75-Auto | Pole Position")
                If CZ75Auto9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "CZ75-Auto | Tigris"
                Dim CZ75Auto10 As Integer = text.IndexOf("CZ75-Auto | Tigris")
                If CZ75Auto10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "CZ75-Auto | Tread Plate"
                Dim CZ75Auto11 As Integer = text.IndexOf("CZ75-Auto | Tread Plate")
                If CZ75Auto11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "CZ75-Auto | Chalice"
                Dim CZ75Auto12 As Integer = text.IndexOf("CZ75-Auto | Chalice")
                If CZ75Auto12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "CZ75-Auto | Polymer"
                Dim CZ75Auto13 As Integer = text.IndexOf("CZ75-Auto | Polymer")
                If CZ75Auto13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "CZ75-Auto | Imprint"
                Dim CZ75Auto14 As Integer = text.IndexOf("CZ75-Auto | Imprint")
                If CZ75Auto14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "CZ75-Auto | Hexane"
                Dim CZ75Auto15 As Integer = text.IndexOf("CZ75-Auto | Hexane")
                If CZ75Auto15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "CZ75-Auto | Twist"
                Dim CZ75Auto16 As Integer = text.IndexOf("CZ75-Auto | Twist")
                If CZ75Auto16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "CZ75-Auto | Poison Dart"
                Dim CZ75Auto17 As Integer = text.IndexOf("CZ75-Auto | Poison Dart")
                If CZ75Auto17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "CZ75-Auto | Crimson Web"
                Dim CZ75Auto18 As Integer = text.IndexOf("CZ75-Auto | Crimson Web")
                If CZ75Auto18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "CZ75-Auto | Emerald"
                Dim CZ75Auto19 As Integer = text.IndexOf("CZ75-Auto | Emerald")
                If CZ75Auto19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "CZ75-Auto | Nitro"
                Dim CZ75Auto20 As Integer = text.IndexOf("CZ75-Auto | Nitro")
                If CZ75Auto20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "CZ75-Auto | Tuxedo"
                Dim CZ75Auto21 As Integer = text.IndexOf("CZ75-Auto | Tuxedo")
                If CZ75Auto21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "CZ75-Auto | Army Sheen"
                Dim CZ75Auto22 As Integer = text.IndexOf("CZ75-Auto | Army Sheen")
                If CZ75Auto22 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "CZ75-Auto | Green Plaid"
                Dim CZ75Auto23 As Integer = text.IndexOf("CZ75-Auto | Green Plaid")
                If CZ75Auto23 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "Desert Eagle"
            Case "Desert Eagle"
                Label3.Text = "Desert Eagle | Golden Koi"
                Dim DesertEagle3 As Integer = text.IndexOf("Desert Eagle | Golden Koi")
                If DesertEagle3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "Desert Eagle | Kumicho Dragon"
                Dim DesertEagle4 As Integer = text.IndexOf("Desert Eagle | Kumicho Dragon")
                If DesertEagle4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "Desert Eagle | onspiracy"
                Dim DesertEagle5 As Integer = text.IndexOf("Desert Eagle | onspiracy")
                If DesertEagle5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "Desert Eagle | Cobalt Disruption"
                Dim DesertEagle6 As Integer = text.IndexOf("Desert Eagle | Cobalt Disruption")
                If DesertEagle6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "Desert Eagle | Hypnotic"
                Dim DesertEagle7 As Integer = text.IndexOf("Desert Eagle | Hypnotic")
                If DesertEagle7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "Desert Eagle | Directive"
                Dim DesertEagle8 As Integer = text.IndexOf("Desert Eagle | Directive")
                If DesertEagle8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "Desert Eagle | Naga"
                Dim DesertEagle9 As Integer = text.IndexOf("Desert Eagle | Naga")
                If DesertEagle9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "Desert Eagle | Crimson Web"
                Dim DesertEagle10 As Integer = text.IndexOf("Desert Eagle | Crimson Web")
                If DesertEagle10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "Desert Eagle | Heirloom"
                Dim DesertEagle11 As Integer = text.IndexOf("Desert Eagle | Heirloom")
                If DesertEagle11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "Desert Eagle | Sunset Storm 弐"
                Dim DesertEagle12 As Integer = text.IndexOf("Desert Eagle | Sunset Storm 弐")
                If DesertEagle12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "Desert Eagle | Sunset Storm 壱"
                Dim DesertEagle13 As Integer = text.IndexOf("Desert Eagle | Sunset Storm 壱")
                If DesertEagle13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "Desert Eagle | Hand Cannon"
                Dim DesertEagle14 As Integer = text.IndexOf("Desert Eagle | Hand Cannon")
                If DesertEagle14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "Desert Eagle | Pilot"
                Dim DesertEagle15 As Integer = text.IndexOf("Desert Eagle | Pilot")
                If DesertEagle15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "Desert Eagle | Blaze"
                Dim DesertEagle16 As Integer = text.IndexOf("Desert Eagle | Blaze")
                If DesertEagle16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "Desert Eagle | Oxide Blaze"
                Dim DesertEagle17 As Integer = text.IndexOf("Desert Eagle | Oxide Blaze")
                If DesertEagle17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "Desert Eagle | Corinthian"
                Dim DesertEagle18 As Integer = text.IndexOf("Desert Eagle | Corinthian")
                If DesertEagle18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "Desert Eagle | Bronze Deco"
                Dim DesertEagle19 As Integer = text.IndexOf("Desert Eagle | Bronze Deco")
                If DesertEagle19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "Desert Eagle | Meteorite"
                Dim DesertEagle20 As Integer = text.IndexOf("Desert Eagle | Meteorite")
                If DesertEagle20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "Desert Eagle | Urban Rubble"
                Dim DesertEagle21 As Integer = text.IndexOf("Desert Eagle | Urban Rubble")
                If DesertEagle21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "Desert Eagle | Night"
                Dim DesertEagle22 As Integer = text.IndexOf("Desert Eagle | Night")
                If DesertEagle22 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "Desert Eagle | Midnight Storm"
                Dim DesertEagle23 As Integer = text.IndexOf("Desert Eagle | Midnight Storm")
                If DesertEagle23 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                Label24.Text = "Desert Eagle | Urban DDPAT"
                Dim DesertEagle24 As Integer = text.IndexOf("Desert Eagle | Urban DDPAT")
                If DesertEagle24 >= 0 Then
                    PictureBox24.Image = My.Resources.GotBox
                Else
                    PictureBox24.Image = My.Resources.NotGotBox
                End If
                '
                Label25.Text = "Desert Eagle | Mudder"
                Dim DesertEagle25 As Integer = text.IndexOf("Desert Eagle | Mudder")
                If DesertEagle25 >= 0 Then
                    PictureBox25.Image = My.Resources.GotBox
                Else
                    PictureBox25.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "Dual Berettas"
            Case "Dual Berettas"
                Label3.Text = "Dual Berettas | Cobra Strike"
                Dim DualBerettas3 As Integer = text.IndexOf("Dual Berettas | Cobra Strike")
                If DualBerettas3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "Dual Berettas | Royal Consorts"
                Dim DualBerettas4 As Integer = text.IndexOf("Dual Berettas | Royal Consorts")
                If DualBerettas4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "Dual Berettas | Urban Shock"
                Dim DualBerettas5 As Integer = text.IndexOf("Dual Berettas | Urban Shock")
                If DualBerettas5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "Dual Berettas | Marina"
                Dim DualBerettas6 As Integer = text.IndexOf("Dual Berettas | Marina")
                If DualBerettas6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "Dual Berettas | Hemoglobin"
                Dim DualBerettas7 As Integer = text.IndexOf("Dual Berettas | Hemoglobin")
                If DualBerettas7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "Dual Berettas | Duelist"
                Dim DualBerettas8 As Integer = text.IndexOf("Dual Berettas | Duelist")
                If DualBerettas8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "Dual Berettas | Cobalt Quartz"
                Dim DualBerettas9 As Integer = text.IndexOf("Dual Berettas | Cobalt Quartz")
                If DualBerettas9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "Dual Berettas | Demolition"
                Dim DualBerettas10 As Integer = text.IndexOf("Dual Berettas | Demolition")
                If DualBerettas10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "Dual Berettas | Ventilators"
                Dim DualBerettas11 As Integer = text.IndexOf("Dual Berettas | Ventilators")
                If DualBerettas11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "Dual Berettas | Cartel"
                Dim DualBerettas12 As Integer = text.IndexOf("Dual Berettas | Cartel")
                If DualBerettas12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "Dual Berettas | Dualing Dragons"
                Dim DualBerettas13 As Integer = text.IndexOf("Dual Berettas | Dualing Dragons")
                If DualBerettas13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "Dual Berettas | Retribution"
                Dim DualBerettas14 As Integer = text.IndexOf("Dual Berettas | Retribution")
                If DualBerettas14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "Dual Berettas | Panther"
                Dim DualBerettas15 As Integer = text.IndexOf("Dual Berettas | Panther")
                If DualBerettas15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "Dual Berettas | Black Limba"
                Dim DualBerettas16 As Integer = text.IndexOf("Dual Berettas | Black Limba")
                If DualBerettas16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "Dual Berettas | Anodized Navy"
                Dim DualBerettas17 As Integer = text.IndexOf("Dual Berettas | Anodized Navy")
                If DualBerettas17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "Dual Berettas | Stained"
                Dim DualBerettas18 As Integer = text.IndexOf("Dual Berettas | Stained")
                If DualBerettas18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "Dual Berettas | Moon in Libra"
                Dim DualBerettas19 As Integer = text.IndexOf("Dual Berettas | Moon in Libra")
                If DualBerettas19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "Dual Berettas | Briar"
                Dim DualBerettas20 As Integer = text.IndexOf("Dual Berettas | Briar")
                If DualBerettas20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "Dual Berettas | Contractor"
                Dim DualBerettas21 As Integer = text.IndexOf("Dual Berettas | Contractor")
                If DualBerettas21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "Dual Berettas | Colony"
                Dim DualBerettas22 As Integer = text.IndexOf("Dual Berettas | Colony")
                If DualBerettas22 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox23.Hide()
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "Falchion Knife"
            Case "Falchion Knife"
                Label3.Text = "Falchion Knife"
                Dim FalchionKnife3 As Integer = text.IndexOf("Falchion Knife")
                If FalchionKnife3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "Falchion Knife | Marble Fade"
                Dim FalchionKnife4 As Integer = text.IndexOf("Falchion Knife | Marble Fade")
                If FalchionKnife4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "Falchion Knife | Doppler"
                Dim FalchionKnife5 As Integer = text.IndexOf("Falchion Knife | Doppler")
                If FalchionKnife5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "Falchion Knife | Rust Coat"
                Dim FalchionKnife6 As Integer = text.IndexOf("Falchion Knife | Rust Coat")
                If FalchionKnife6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "Falchion Knife | Tiger Tooth"
                Dim FalchionKnife7 As Integer = text.IndexOf("Falchion Knife | Tiger Tooth")
                If FalchionKnife7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "Falchion Knife | Damascus Steel"
                Dim FalchionKnife8 As Integer = text.IndexOf("Falchion Knife | Damascus Steel")
                If FalchionKnife8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "Falchion Knife | Ultraviolet"
                Dim FalchionKnife9 As Integer = text.IndexOf("Falchion Knife | Ultraviolet")
                If FalchionKnife9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "Falchion Knife | Fade"
                Dim FalchionKnife10 As Integer = text.IndexOf("Falchion Knife | Fade")
                If FalchionKnife10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "Falchion Knife | Slaughter"
                Dim FalchionKnife11 As Integer = text.IndexOf("Falchion Knife | Slaughter")
                If FalchionKnife11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "Falchion Knife | Crimson Web"
                Dim FalchionKnife12 As Integer = text.IndexOf("Falchion Knife | Crimson Web")
                If FalchionKnife12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "Falchion Knife | Case Hardened"
                Dim FalchionKnife13 As Integer = text.IndexOf("Falchion Knife | Case Hardened")
                If FalchionKnife13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "Falchion Knife | Blue Steel"
                Dim FalchionKnife14 As Integer = text.IndexOf("Falchion Knife | Blue Steel")
                If FalchionKnife14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "Falchion Knife | Night"
                Dim FalchionKnife15 As Integer = text.IndexOf("Falchion Knife | Night")
                If FalchionKnife15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "Falchion Knife | Boreal Forest"
                Dim FalchionKnife16 As Integer = text.IndexOf("Falchion Knife | Boreal Forest")
                If FalchionKnife16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "Falchion Knife | Forest DDPAT"
                Dim FalchionKnife17 As Integer = text.IndexOf("Falchion Knife | Forest DDPAT")
                If FalchionKnife17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "Falchion Knife | Stained"
                Dim FalchionKnife18 As Integer = text.IndexOf("Falchion Knife | Stained")
                If FalchionKnife18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "Falchion Knife | Urban Masked"
                Dim FalchionKnife19 As Integer = text.IndexOf("Falchion Knife | Urban Masked")
                If FalchionKnife19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "Falchion Knife | Safari Mesh"
                Dim FalchionKnife20 As Integer = text.IndexOf("Falchion Knife | Safari Mesh")
                If FalchionKnife20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "Falchion Knife | Scorched"
                Dim FalchionKnife21 As Integer = text.IndexOf("Falchion Knife | Scorched")
                If FalchionKnife21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox22.Hide()
                PictureBox23.Hide()
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "FAMAS"
            Case "FAMAS"
                Label3.Text = "FAMAS | Roll Cage"
                Dim FAMAS3 As Integer = text.IndexOf("FAMAS | Roll Cage")
                If FAMAS3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "FAMAS | Mecha Industries"
                Dim FAMAS4 As Integer = text.IndexOf("FAMAS | Mecha Industries")
                If FAMAS4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "FAMAS | Djinn"
                Dim FAMAS5 As Integer = text.IndexOf("FAMAS | Djinn")
                If FAMAS5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "FAMAS | Afterimage"
                Dim FAMAS6 As Integer = text.IndexOf("FAMAS | Afterimage")
                If FAMAS6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "FAMAS | Valence"
                Dim FAMAS7 As Integer = text.IndexOf("FAMAS | Valence")
                If FAMAS7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "FAMAS | Neural Net"
                Dim FAMAS8 As Integer = text.IndexOf("FAMAS | Neural Net")
                If FAMAS8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "FAMAS | Sergeant"
                Dim FAMAS9 As Integer = text.IndexOf("FAMAS | Sergeant")
                If FAMAS9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "FAMAS | Pulse"
                Dim FAMAS10 As Integer = text.IndexOf("FAMAS | Pulse")
                If FAMAS10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "FAMAS | Styx"
                Dim FAMAS11 As Integer = text.IndexOf("FAMAS | Styx")
                If FAMAS11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "FAMAS | Spitfire"
                Dim FAMAS12 As Integer = text.IndexOf("FAMAS | Spitfire")
                If FAMAS12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "FAMAS | Macabre"
                Dim FAMAS13 As Integer = text.IndexOf("FAMAS | Macabre")
                If FAMAS13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "FAMAS | Survivor Z"
                Dim FAMAS14 As Integer = text.IndexOf("FAMAS | Survivor Z")
                If FAMAS14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "FAMAS | Hexane"
                Dim FAMAS15 As Integer = text.IndexOf("FAMAS | Hexane")
                If FAMAS15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "FAMAS | Doomkitty"
                Dim FAMAS16 As Integer = text.IndexOf("FAMAS | Doomkitty")
                If FAMAS16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "FAMAS | Teardown"
                Dim FAMAS17 As Integer = text.IndexOf("FAMAS | Teardown")
                If FAMAS17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "FAMAS | Cyanospatter"
                Dim FAMAS18 As Integer = text.IndexOf("FAMAS | Cyanospatter")
                If FAMAS18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "FAMAS | Colony"
                Dim FAMAS19 As Integer = text.IndexOf("FAMAS | Colony")
                If FAMAS19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "FAMAS | Contrast Spray"
                Dim FAMAS20 As Integer = text.IndexOf("FAMAS | Contrast Spray")
                If FAMAS20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox21.Hide()
                PictureBox22.Hide()
                PictureBox23.Hide()
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "Five-SeveN"
            Case "Five-SeveN"
                Label3.Text = "Five-SeveN | Hyper Beast"
                Dim FiveSeveN3 As Integer = text.IndexOf("Five-SeveN | Hyper Beast")
                If FiveSeveN3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "Five-SeveN | Monkey Business"
                Dim FiveSeveN4 As Integer = text.IndexOf("Five-SeveN | Monkey Business")
                If FiveSeveN4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "Five-SeveN | Fowl Play"
                Dim FiveSeveN5 As Integer = text.IndexOf("Five-SeveN | Fowl Play")
                If FiveSeveN5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "Five-SeveN | Triumvirate"
                Dim FiveSeveN6 As Integer = text.IndexOf("Five-SeveN | Triumvirate")
                If FiveSeveN6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "Five-SeveN | Retrobution"
                Dim FiveSeveN7 As Integer = text.IndexOf("Five-SeveN | Retrobution")
                If FiveSeveN7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "Five-SeveN | Copper Galaxy"
                Dim FiveSeveN8 As Integer = text.IndexOf("Five-SeveN | Copper Galaxy")
                If FiveSeveN8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "Five-SeveN | Case Hardened"
                Dim FiveSeveN9 As Integer = text.IndexOf("Five-SeveN | Case Hardened")
                If FiveSeveN9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "Five-SeveN | Neon Kimono"
                Dim FiveSeveN10 As Integer = text.IndexOf("Five-SeveN | Neon Kimono")
                If FiveSeveN10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "Five-SeveN | Capillary"
                Dim FiveSeveN11 As Integer = text.IndexOf("Five-SeveN | Capillary")
                If FiveSeveN11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "Five-SeveN | Scumbria"
                Dim FiveSeveN12 As Integer = text.IndexOf("Five-SeveN | Scumbria")
                If FiveSeveN12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "Five-SeveN | Violent Daimyo"
                Dim FiveSeveN13 As Integer = text.IndexOf("Five-SeveN | Violent Daimyo")
                If FiveSeveN13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "Five-SeveN | Urban Hazard"
                Dim FiveSeveN14 As Integer = text.IndexOf("Five-SeveN | Urban Hazard")
                If FiveSeveN14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "Five-SeveN | Nightshade"
                Dim FiveSeveN15 As Integer = text.IndexOf("Five-SeveN | Nightshade")
                If FiveSeveN15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "Five-SeveN | Kami"
                Dim FiveSeveN16 As Integer = text.IndexOf("Five-SeveN | Kami")
                If FiveSeveN16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "Five-SeveN | Nitro"
                Dim FiveSeveN17 As Integer = text.IndexOf("Five-SeveN | Nitro")
                If FiveSeveN17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "Five-SeveN | Silver Quartz"
                Dim FiveSeveN18 As Integer = text.IndexOf("Five-SeveN | Silver Quartz")
                If FiveSeveN18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "Five-SeveN | Hot Shot"
                Dim FiveSeveN19 As Integer = text.IndexOf("Five-SeveN | Hot Shot")
                If FiveSeveN19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "Five-SeveN | Orange Peel"
                Dim FiveSeveN20 As Integer = text.IndexOf("Five-SeveN | Orange Peel")
                If FiveSeveN20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "Five-SeveN | Candy Apple"
                Dim FiveSeveN21 As Integer = text.IndexOf("Five-SeveN | Candy Apple")
                If FiveSeveN21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "Five-SeveN | Contractor"
                Dim FiveSeveN22 As Integer = text.IndexOf("Five-SeveN | Contractor")
                If FiveSeveN22 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "Five-SeveN | Forest Night"
                Dim FiveSeveN23 As Integer = text.IndexOf("Five-SeveN | Forest Night")
                If FiveSeveN23 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                Label24.Text = "Five-SeveN | Anodized Gunmetal"
                Dim FiveSeveN24 As Integer = text.IndexOf("Five-SeveN | Anodized Gunmetal")
                If FiveSeveN24 >= 0 Then
                    PictureBox24.Image = My.Resources.GotBox
                Else
                    PictureBox24.Image = My.Resources.NotGotBox
                End If
                '
                Label25.Text = "Five-SeveN | Jungle"
                Dim FiveSeveN25 As Integer = text.IndexOf("Five-SeveN | Jungle")
                If FiveSeveN25 >= 0 Then
                    PictureBox25.Image = My.Resources.GotBox
                Else
                    PictureBox25.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "Flip Knife"
            Case "Flip Knife"
                Label3.Text = "Flip Knife"
                Dim FlipKnife3 As Integer = text.IndexOf("Flip Knife")
                If FlipKnife3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "Flip Knife | Gamma Doppler"
                Dim FlipKnife4 As Integer = text.IndexOf("Flip Knife | Gamma Doppler")
                If FlipKnife4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "Flip Knife | Bright Water"
                Dim FlipKnife5 As Integer = text.IndexOf("Flip Knife | Bright Water")
                If FlipKnife5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "Flip Knife | Lore"
                Dim FlipKnife6 As Integer = text.IndexOf("Flip Knife | Lore")
                If FlipKnife6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "Flip Knife | Autotronic"
                Dim FlipKnife7 As Integer = text.IndexOf("Flip Knife | Autotronic")
                If FlipKnife7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "Flip Knife | Freehand"
                Dim FlipKnife8 As Integer = text.IndexOf("Flip Knife | Freehand")
                If FlipKnife8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "Flip Knife | Black Laminate"
                Dim FlipKnife9 As Integer = text.IndexOf("Flip Knife | Black Laminate")
                If FlipKnife9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "Flip Knife | Marble Fade"
                Dim FlipKnife10 As Integer = text.IndexOf("Flip Knife | Marble Fade")
                If FlipKnife10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "Flip Knife | Tiger Tooth"
                Dim FlipKnife11 As Integer = text.IndexOf("Flip Knife | Tiger Tooth")
                If FlipKnife11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "Flip Knife | Doppler"
                Dim FlipKnife12 As Integer = text.IndexOf("Flip Knife | Doppler")
                If FlipKnife12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "Flip Knife | Ultraviolet"
                Dim FlipKnife13 As Integer = text.IndexOf("Flip Knife | Ultraviolet")
                If FlipKnife13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "Flip Knife | Damascus Steel"
                Dim FlipKnife14 As Integer = text.IndexOf("Flip Knife | Damascus Steel")
                If FlipKnife14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "Flip Knife | Rust Coat"
                Dim FlipKnife15 As Integer = text.IndexOf("Flip Knife | Rust Coat")
                If FlipKnife15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "Flip Knife | Fade"
                Dim FlipKnife16 As Integer = text.IndexOf("Flip Knife | Fade")
                If FlipKnife16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "Flip Knife | Slaughter"
                Dim FlipKnife17 As Integer = text.IndexOf("Flip Knife | Slaughter")
                If FlipKnife17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "Flip Knife | Crimson Web"
                Dim FlipKnife18 As Integer = text.IndexOf("Flip Knife | Crimson Web")
                If FlipKnife18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "Flip Knife | Stained"
                Dim FlipKnife19 As Integer = text.IndexOf("Flip Knife | Stained")
                If FlipKnife19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "Flip Knife | Night"
                Dim FlipKnife20 As Integer = text.IndexOf("Flip Knife | Night")
                If FlipKnife20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "Flip Knife | Case Hardened"
                Dim FlipKnife21 As Integer = text.IndexOf("Flip Knife | Case Hardened")
                If FlipKnife21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "Flip Knife | Blue Steel"
                Dim FlipKnife22 As Integer = text.IndexOf("Flip Knife | Blue Steel")
                If FlipKnife22 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "Flip Knife | Safari Mesh"
                Dim FlipKnife23 As Integer = text.IndexOf("Flip Knife | Safari Mesh")
                If FlipKnife23 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                Label24.Text = "Flip Knife | Boreal Forest"
                Dim FlipKnife24 As Integer = text.IndexOf("Flip Knife | Boreal Forest")
                If FlipKnife24 >= 0 Then
                    PictureBox24.Image = My.Resources.GotBox
                Else
                    PictureBox24.Image = My.Resources.NotGotBox
                End If
                '
                Label25.Text = "Flip Knife | Scorched"
                Dim FlipKnife25 As Integer = text.IndexOf("Flip Knife | Scorched")
                If FlipKnife25 >= 0 Then
                    PictureBox25.Image = My.Resources.GotBox
                Else
                    PictureBox25.Image = My.Resources.NotGotBox
                End If
                '
                Label26.Text = "Flip Knife | Forest DDPAT"
                Dim FlipKnife26 As Integer = text.IndexOf("Flip Knife | Forest DDPAT")
                If FlipKnife26 >= 0 Then
                    PictureBox26.Image = My.Resources.GotBox
                Else
                    PictureBox26.Image = My.Resources.NotGotBox
                End If
                '
                Label27.Text = "Flip Knife | Urban Masked"
                Dim FlipKnife27 As Integer = text.IndexOf("Flip Knife | Urban Masked")
                If FlipKnife27 >= 0 Then
                    PictureBox27.Image = My.Resources.GotBox
                Else
                    PictureBox27.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "G3SG1"
            Case "G3SG1"
                Label3.Text = "G3SG1 | The Executioner"
                Dim G3SG13 As Integer = text.IndexOf("G3SG1 | The Executioner")
                If G3SG13 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "G3SG1 | Flux"
                Dim G3SG14 As Integer = text.IndexOf("G3SG1 | Flux")
                If G3SG14 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "G3SG1 | Stinger"
                Dim G3SG15 As Integer = text.IndexOf("G3SG1 | Stinger")
                If G3SG15 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "G3SG1 | Chronos"
                Dim G3SG16 As Integer = text.IndexOf("G3SG1 | Chronos")
                If G3SG16 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "G3SG1 | Hunter"
                Dim G3SG17 As Integer = text.IndexOf("G3SG1 | Hunter")
                If G3SG17 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "G3SG1 | Ventilator"
                Dim G3SG18 As Integer = text.IndexOf("G3SG1 | Ventilator")
                If G3SG18 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "G3SG1 | Orange Crash"
                Dim G3SG19 As Integer = text.IndexOf("G3SG1 | Orange Crash")
                If G3SG19 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "G3SG1 | Murky"
                Dim G3SG110 As Integer = text.IndexOf("G3SG1 | Murky")
                If G3SG110 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "G3SG1 | Azure Zebra"
                Dim G3SG111 As Integer = text.IndexOf("G3SG1 | Azure Zebra")
                If G3SG111 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "G3SG1 | Demeter"
                Dim G3SG112 As Integer = text.IndexOf("G3SG1 | Demeter")
                If G3SG112 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "G3SG1 | Green Apple"
                Dim G3SG113 As Integer = text.IndexOf("G3SG1 | Green Apple")
                If G3SG113 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "G3SG1 | VariCamo"
                Dim G3SG114 As Integer = text.IndexOf("G3SG1 | VariCamo")
                If G3SG114 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "G3SG1 | Arctic Camo"
                Dim G3SG115 As Integer = text.IndexOf("G3SG1 | Arctic Camo")
                If G3SG115 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "G3SG1 | Orange Kimono"
                Dim G3SG116 As Integer = text.IndexOf("G3SG1 | Orange Kimono")
                If G3SG116 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "G3SG1 | Contractor"
                Dim G3SG117 As Integer = text.IndexOf("G3SG1 | Contractor")
                If G3SG117 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "G3SG1 | Jungle Dashed"
                Dim G3SG118 As Integer = text.IndexOf("G3SG1 | Jungle Dashed")
                If G3SG118 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "G3SG1 | Safari Mesh"
                Dim G3SG119 As Integer = text.IndexOf("G3SG1 | Safari Mesh")
                If G3SG119 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "G3SG1 | Desert Storm"
                Dim G3SG120 As Integer = text.IndexOf("G3SG1 | Desert Storm")
                If G3SG120 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "G3SG1 | Polar Camo"
                Dim G3SG121 As Integer = text.IndexOf("G3SG1 | Polar Camo")
                If G3SG121 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox22.Hide()
                PictureBox23.Hide()
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "Galil AR"
            Case "Galil AR"
                Label3.Text = "Galil AR | Chatterbox"
                Dim GalilAR3 As Integer = text.IndexOf("Galil AR | Chatterbox")
                If GalilAR3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "Galil AR | Sugar Rush"
                Dim GalilAR4 As Integer = text.IndexOf("Galil AR | Sugar Rush")
                If GalilAR4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "Galil AR | Eco"
                Dim GalilAR5 As Integer = text.IndexOf("Galil AR | Eco")
                If GalilAR5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "Galil AR | Crimson Tsunami"
                Dim GalilAR6 As Integer = text.IndexOf("Galil AR | Crimson Tsunami")
                If GalilAR6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "Galil AR | Firefight"
                Dim GalilAR7 As Integer = text.IndexOf("Galil AR | Firefight")
                If GalilAR7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "Galil AR | Stone Cold"
                Dim GalilAR8 As Integer = text.IndexOf("Galil AR | Stone Cold")
                If GalilAR8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "Galil AR | Orange DDPAT"
                Dim GalilAR9 As Integer = text.IndexOf("Galil AR | Orange DDPAT")
                If GalilAR9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "Galil AR | Cerberus"
                Dim GalilAR10 As Integer = text.IndexOf("Galil AR | Cerberus")
                If GalilAR10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "Galil AR | Black Sand"
                Dim GalilAR11 As Integer = text.IndexOf("Galil AR | Black Sand")
                If GalilAR11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "Galil AR | Rocket Pop"
                Dim GalilAR12 As Integer = text.IndexOf("Galil AR | Rocket Pop")
                If GalilAR12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "Galil AR | Kami"
                Dim GalilAR13 As Integer = text.IndexOf("Galil AR | Kami")
                If GalilAR13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "Galil AR | Blue Titanium"
                Dim GalilAR14 As Integer = text.IndexOf("Galil AR | Blue Titanium")
                If GalilAR14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "Galil AR | Sandstorm"
                Dim GalilAR15 As Integer = text.IndexOf("Galil AR | Sandstorm")
                If GalilAR15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "Galil AR | Shattered"
                Dim GalilAR16 As Integer = text.IndexOf("Galil AR | Shattered")
                If GalilAR16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "Galil AR | Aqua Terrace"
                Dim GalilAR17 As Integer = text.IndexOf("Galil AR | Aqua Terrace")
                If GalilAR17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "Galil AR | Tuxedo"
                Dim GalilAR18 As Integer = text.IndexOf("Galil AR | Tuxedo")
                If GalilAR18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "Galil AR | Urban Rubble"
                Dim GalilAR19 As Integer = text.IndexOf("Galil AR | Urban Rubble")
                If GalilAR19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "Galil AR | VariCamo"
                Dim GalilAR20 As Integer = text.IndexOf("Galil AR | VariCamo")
                If GalilAR20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "Galil AR | Winter Forest"
                Dim GalilAR21 As Integer = text.IndexOf("Galil AR | Winter Forest")
                If GalilAR21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "Galil AR | Sage Spray"
                Dim GalilAR22 As Integer = text.IndexOf("Galil AR | Sage Spray")
                If GalilAR22 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "Galil AR | Hunting Blind"
                Dim GalilAR23 As Integer = text.IndexOf("Galil AR | Hunting Blind")
                If GalilAR23 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "Glock-18"
            Case "Glock-18"
                Label3.Text = "Glock-18 | Wasteland Rebel"
                Dim Glock183 As Integer = text.IndexOf("Glock-18 | Wasteland Rebel")
                If Glock183 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "Glock-18 | Water Elemental"
                Dim Glock184 As Integer = text.IndexOf("Glock-18 | Water Elemental")
                If Glock184 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "Glock-18 | Twilight Galaxy"
                Dim Glock185 As Integer = text.IndexOf("Glock-18 | Twilight Galaxy")
                If Glock185 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "Glock-18 | Weasel"
                Dim Glock186 As Integer = text.IndexOf("Glock-18 | Weasel")
                If Glock186 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "Glock-18 | Royal Legion"
                Dim Glock187 As Integer = text.IndexOf("Glock-18 | Royal Legion")
                If Glock187 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "Glock-18 | Grinder"
                Dim Glock188 As Integer = text.IndexOf("Glock-18 | Grinder")
                If Glock188 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "Glock-18 | Steel Disruption"
                Dim Glock189 As Integer = text.IndexOf("Glock-18 | Steel Disruption")
                If Glock189 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "Glock-18 | Dragon Tattoo"
                Dim Glock1810 As Integer = text.IndexOf("Glock-18 | Dragon Tattoo")
                If Glock1810 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "Glock-18 | Fade"
                Dim Glock1811 As Integer = text.IndexOf("Glock-18 | Fade")
                If Glock1811 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "Glock-18 | Brass"
                Dim Glock1812 As Integer = text.IndexOf("Glock-18 | Brass")
                If Glock1812 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "Glock-18 | Off World"
                Dim Glock1813 As Integer = text.IndexOf("Glock-18 | Off World")
                If Glock1813 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "Glock-18 | Ironwork"
                Dim Glock1814 As Integer = text.IndexOf("Glock-18 | Ironwork")
                If Glock1814 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "Glock-18 | Wraiths"
                Dim Glock1815 As Integer = text.IndexOf("Glock-18 | Wraiths")
                If Glock1815 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "Glock-18 | Bunsen Burner"
                Dim Glock1816 As Integer = text.IndexOf("Glock-18 | Bunsen Burner")
                If Glock1816 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "Glock-18 | Catacombs"
                Dim Glock1817 As Integer = text.IndexOf("Glock-18 | Catacombs")
                If Glock1817 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "Glock-18 | Blue Fissure"
                Dim Glock1818 As Integer = text.IndexOf("Glock-18 | Blue Fissure")
                If Glock1818 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "Glock-18 | Reactor"
                Dim Glock1819 As Integer = text.IndexOf("Glock-18 | Reactor")
                If Glock1819 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "Glock-18 | Candy Apple"
                Dim Glock1820 As Integer = text.IndexOf("Glock-18 | Candy Apple")
                If Glock1820 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "Glock-18 | Night"
                Dim Glock1821 As Integer = text.IndexOf("Glock-18 | Night")
                If Glock1821 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "Glock-18 | Death Rattle"
                Dim Glock1822 As Integer = text.IndexOf("Glock-18 | Death Rattle")
                If Glock1822 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "Glock-18 | Groundwater"
                Dim Glock1823 As Integer = text.IndexOf("Glock-18 | Groundwater")
                If Glock1823 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                Label24.Text = "Glock-18 | Sand Dune"
                Dim Glock1824 As Integer = text.IndexOf("Glock-18 | Sand Dune")
                If Glock1824 >= 0 Then
                    PictureBox24.Image = My.Resources.GotBox
                Else
                    PictureBox24.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "Gut Knife"
            Case "Gut Knife"
                Label3.Text = "Gut Knife	"
                Dim GutKnife3 As Integer = text.IndexOf("Gut Knife	")
                If GutKnife3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "Gut Knife | Autotronic"
                Dim GutKnife4 As Integer = text.IndexOf("Gut Knife | Autotronic")
                If GutKnife4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "Gut Knife | Gamma Doppler"
                Dim GutKnife5 As Integer = text.IndexOf("Gut Knife | Gamma Doppler")
                If GutKnife5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "Gut Knife | Lore"
                Dim GutKnife6 As Integer = text.IndexOf("Gut Knife | Lore")
                If GutKnife6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "Gut Knife | Bright Water"
                Dim GutKnife7 As Integer = text.IndexOf("Gut Knife | Bright Water")
                If GutKnife7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "Gut Knife | Freehand"
                Dim GutKnife8 As Integer = text.IndexOf("Gut Knife | Freehand")
                If GutKnife8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "Gut Knife | Black Laminate"
                Dim GutKnife9 As Integer = text.IndexOf("Gut Knife | Black Laminate")
                If GutKnife9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "Gut Knife | Marble Fade"
                Dim GutKnife10 As Integer = text.IndexOf("Gut Knife | Marble Fade")
                If GutKnife10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "Gut Knife | Doppler"
                Dim GutKnife11 As Integer = text.IndexOf("Gut Knife | Doppler")
                If GutKnife11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "Gut Knife | Tiger Tooth"
                Dim GutKnife12 As Integer = text.IndexOf("Gut Knife | Tiger Tooth")
                If GutKnife12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "Gut Knife | Damascus Steel"
                Dim GutKnife13 As Integer = text.IndexOf("Gut Knife | Damascus Steel")
                If GutKnife13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "Gut Knife | Ultraviolet"
                Dim GutKnife14 As Integer = text.IndexOf("Gut Knife | Ultraviolet")
                If GutKnife14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "Gut Knife | Rust Coat"
                Dim GutKnife15 As Integer = text.IndexOf("Gut Knife | Rust Coat")
                If GutKnife15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "Gut Knife | Stained"
                Dim GutKnife16 As Integer = text.IndexOf("Gut Knife | Stained")
                If GutKnife16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "Gut Knife | Crimson Web"
                Dim GutKnife17 As Integer = text.IndexOf("Gut Knife | Crimson Web")
                If GutKnife17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "Gut Knife | Night"
                Dim GutKnife18 As Integer = text.IndexOf("Gut Knife | Night")
                If GutKnife18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "Gut Knife | Fade"
                Dim GutKnife19 As Integer = text.IndexOf("Gut Knife | Fade")
                If GutKnife19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "Gut Knife | Case Hardened"
                Dim GutKnife20 As Integer = text.IndexOf("Gut Knife | Case Hardened")
                If GutKnife20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "Gut Knife | Blue Steel"
                Dim GutKnife21 As Integer = text.IndexOf("Gut Knife | Blue Steel")
                If GutKnife21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "Gut Knife | Slaughter"
                Dim GutKnife22 As Integer = text.IndexOf("Gut Knife | Slaughter")
                If GutKnife22 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "Gut Knife | Safari Mesh"
                Dim GutKnife23 As Integer = text.IndexOf("Gut Knife | Safari Mesh")
                If GutKnife23 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                Label24.Text = "Gut Knife | Scorched"
                Dim GutKnife24 As Integer = text.IndexOf("Gut Knife | Scorched")
                If GutKnife24 >= 0 Then
                    PictureBox24.Image = My.Resources.GotBox
                Else
                    PictureBox24.Image = My.Resources.NotGotBox
                End If
                '
                Label25.Text = "Gut Knife | Boreal Forest"
                Dim GutKnife25 As Integer = text.IndexOf("Gut Knife | Boreal Forest")
                If GutKnife25 >= 0 Then
                    PictureBox25.Image = My.Resources.GotBox
                Else
                    PictureBox25.Image = My.Resources.NotGotBox
                End If
                '
                Label26.Text = "Gut Knife | Forest DDPAT"
                Dim GutKnife26 As Integer = text.IndexOf("Gut Knife | Forest DDPAT")
                If GutKnife26 >= 0 Then
                    PictureBox26.Image = My.Resources.GotBox
                Else
                    PictureBox26.Image = My.Resources.NotGotBox
                End If
                '
                Label27.Text = "Gut Knife | Urban Masked"
                Dim GutKnife27 As Integer = text.IndexOf("Gut Knife | Urban Masked")
                If GutKnife27 >= 0 Then
                    PictureBox27.Image = My.Resources.GotBox
                Else
                    PictureBox27.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "Huntsman Knife"
            Case "Huntsman Knife"
                Label3.Text = "Huntsman Knife"
                Dim HuntsmanKnife3 As Integer = text.IndexOf("Huntsman Knife")
                If HuntsmanKnife3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "Huntsman Knife | Marble Fade"
                Dim HuntsmanKnife4 As Integer = text.IndexOf("Huntsman Knife | Marble Fade")
                If HuntsmanKnife4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "Huntsman Knife | Doppler"
                Dim HuntsmanKnife5 As Integer = text.IndexOf("Huntsman Knife | Doppler")
                If HuntsmanKnife5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "Huntsman Knife | Tiger Tooth"
                Dim HuntsmanKnife6 As Integer = text.IndexOf("Huntsman Knife | Tiger Tooth")
                If HuntsmanKnife6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "Huntsman Knife | Damascus Steel"
                Dim HuntsmanKnife7 As Integer = text.IndexOf("Huntsman Knife | Damascus Steel")
                If HuntsmanKnife7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "Huntsman Knife | Rust Coat"
                Dim HuntsmanKnife8 As Integer = text.IndexOf("Huntsman Knife | Rust Coat")
                If HuntsmanKnife8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "Huntsman Knife | Ultraviolet"
                Dim HuntsmanKnife9 As Integer = text.IndexOf("Huntsman Knife | Ultraviolet")
                If HuntsmanKnife9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "Huntsman Knife | Crimson Web"
                Dim HuntsmanKnife10 As Integer = text.IndexOf("Huntsman Knife | Crimson Web")
                If HuntsmanKnife10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "Huntsman Knife | Fade"
                Dim HuntsmanKnife11 As Integer = text.IndexOf("Huntsman Knife | Fade")
                If HuntsmanKnife11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "Huntsman Knife | Slaughter"
                Dim HuntsmanKnife12 As Integer = text.IndexOf("Huntsman Knife | Slaughter")
                If HuntsmanKnife12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "Huntsman Knife | Night"
                Dim HuntsmanKnife13 As Integer = text.IndexOf("Huntsman Knife | Night")
                If HuntsmanKnife13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "Huntsman Knife | Case Hardened"
                Dim HuntsmanKnife14 As Integer = text.IndexOf("Huntsman Knife | Case Hardened")
                If HuntsmanKnife14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "Huntsman Knife | Blue Steel"
                Dim HuntsmanKnife15 As Integer = text.IndexOf("Huntsman Knife | Blue Steel")
                If HuntsmanKnife15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "Huntsman Knife | Forest DDPAT"
                Dim HuntsmanKnife16 As Integer = text.IndexOf("Huntsman Knife | Forest DDPAT")
                If HuntsmanKnife16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "Huntsman Knife | Stained"
                Dim HuntsmanKnife17 As Integer = text.IndexOf("Huntsman Knife | Stained")
                If HuntsmanKnife17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "Huntsman Knife | Urban Masked"
                Dim HuntsmanKnife18 As Integer = text.IndexOf("Huntsman Knife | Urban Masked")
                If HuntsmanKnife18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "Huntsman Knife | Boreal Forest"
                Dim HuntsmanKnife19 As Integer = text.IndexOf("Huntsman Knife | Boreal Forest")
                If HuntsmanKnife19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "Huntsman Knife | Scorched"
                Dim HuntsmanKnife20 As Integer = text.IndexOf("Huntsman Knife | Scorched")
                If HuntsmanKnife20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "Huntsman Knife | Safari Mesh"
                Dim HuntsmanKnife21 As Integer = text.IndexOf("Huntsman Knife | Safari Mesh")
                If HuntsmanKnife21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox22.Hide()
                PictureBox23.Hide()
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "Karambit"
            Case "Karambit"
                Label3.Text = "Karambit"
                Dim Karambit3 As Integer = text.IndexOf("Karambit")
                If Karambit3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "Karambit | Lore"
                Dim Karambit4 As Integer = text.IndexOf("Karambit | Lore")
                If Karambit4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "Karambit | Gamma Doppler"
                Dim Karambit5 As Integer = text.IndexOf("Karambit | Gamma Doppler")
                If Karambit5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "Karambit | Autotronic"
                Dim Karambit6 As Integer = text.IndexOf("Karambit | Autotronic")
                If Karambit6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "Karambit | Black Laminate"
                Dim Karambit7 As Integer = text.IndexOf("Karambit | Black Laminate")
                If Karambit7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "Karambit | Bright Water"
                Dim Karambit8 As Integer = text.IndexOf("Karambit | Bright Water")
                If Karambit8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "Karambit | Freehand"
                Dim Karambit9 As Integer = text.IndexOf("Karambit | Freehand")
                If Karambit9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "Karambit | Marble Fade"
                Dim Karambit10 As Integer = text.IndexOf("Karambit | Marble Fade")
                If Karambit10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "Karambit | Tiger Tooth"
                Dim Karambit11 As Integer = text.IndexOf("Karambit | Tiger Tooth")
                If Karambit11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "Karambit | Doppler"
                Dim Karambit12 As Integer = text.IndexOf("Karambit | Doppler")
                If Karambit12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "Karambit | Damascus Steel"
                Dim Karambit13 As Integer = text.IndexOf("Karambit | Damascus Steel")
                If Karambit13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "Karambit | Ultraviolet"
                Dim Karambit14 As Integer = text.IndexOf("Karambit | Ultraviolet")
                If Karambit14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "Karambit | Rust Coat"
                Dim Karambit15 As Integer = text.IndexOf("Karambit | Rust Coat")
                If Karambit15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "Karambit | Fade"
                Dim Karambit16 As Integer = text.IndexOf("Karambit | Fade")
                If Karambit16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "Karambit | Case Hardened"
                Dim Karambit17 As Integer = text.IndexOf("Karambit | Case Hardened")
                If Karambit17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "Karambit | Slaughter"
                Dim Karambit18 As Integer = text.IndexOf("Karambit | Slaughter")
                If Karambit18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "Karambit | Crimson Web"
                Dim Karambit19 As Integer = text.IndexOf("Karambit | Crimson Web")
                If Karambit19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "Karambit | Stained"
                Dim Karambit20 As Integer = text.IndexOf("Karambit | Stained")
                If Karambit20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "Karambit | Blue Steel"
                Dim Karambit21 As Integer = text.IndexOf("Karambit | Blue Steel")
                If Karambit21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "Karambit | Night"
                Dim Karambit22 As Integer = text.IndexOf("Karambit | Night")
                If Karambit22 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "Karambit | Boreal Forest"
                Dim Karambit23 As Integer = text.IndexOf("Karambit | Boreal Forest")
                If Karambit23 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                Label24.Text = "Karambit | Forest DDPAT"
                Dim Karambit24 As Integer = text.IndexOf("Karambit | Forest DDPAT")
                If Karambit24 >= 0 Then
                    PictureBox24.Image = My.Resources.GotBox
                Else
                    PictureBox24.Image = My.Resources.NotGotBox
                End If
                '
                Label25.Text = "Karambit | Safari Mesh"
                Dim Karambit25 As Integer = text.IndexOf("Karambit | Safari Mesh")
                If Karambit25 >= 0 Then
                    PictureBox25.Image = My.Resources.GotBox
                Else
                    PictureBox25.Image = My.Resources.NotGotBox
                End If
                '
                Label26.Text = "Karambit | Urban Masked"
                Dim Karambit26 As Integer = text.IndexOf("Karambit | Urban Masked")
                If Karambit26 >= 0 Then
                    PictureBox26.Image = My.Resources.GotBox
                Else
                    PictureBox26.Image = My.Resources.NotGotBox
                End If
                '
                Label27.Text = "Karambit | Scorched"
                Dim Karambit27 As Integer = text.IndexOf("Karambit | Scorched")
                If Karambit27 >= 0 Then
                    PictureBox27.Image = My.Resources.GotBox
                Else
                    PictureBox27.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "M249"
            Case "M249"
                Label3.Text = "M249 | Emerald Poison Dart"
                Dim M2493 As Integer = text.IndexOf("M249 | Emerald Poison Dart")
                If M2493 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "M249 | Nebula Crusader"
                Dim M2494 As Integer = text.IndexOf("M249 | Nebula Crusader")
                If M2494 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "M249 | Spectre"
                Dim M2495 As Integer = text.IndexOf("M249 | Spectre")
                If M2495 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "M249 | System Lock"
                Dim M2496 As Integer = text.IndexOf("M249 | System Lock")
                If M2496 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "M249 | Magma"
                Dim M2497 As Integer = text.IndexOf("M249 | Magma")
                If M2497 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "M249 | Shipping Forecast"
                Dim M2498 As Integer = text.IndexOf("M249 | Shipping Forecast")
                If M2498 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "M249 | Gator Mesh"
                Dim M2499 As Integer = text.IndexOf("M249 | Gator Mesh")
                If M2499 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "M249 | Blizzard Marbleized"
                Dim M24910 As Integer = text.IndexOf("M249 | Blizzard Marbleized")
                If M24910 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "M249 | Impact Drill"
                Dim M24911 As Integer = text.IndexOf("M249 | Impact Drill")
                If M24911 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "M249 | Contrast Spray"
                Dim M24912 As Integer = text.IndexOf("M249 | Contrast Spray")
                If M24912 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "M249 | Jungle DDPAT"
                Dim M24913 As Integer = text.IndexOf("M249 | Jungle DDPAT")
                If M24913 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox14.Hide()
                PictureBox15.Hide()
                PictureBox16.Hide()
                PictureBox17.Hide()
                PictureBox18.Hide()
                PictureBox19.Hide()
                PictureBox20.Hide()
                PictureBox21.Hide()
                PictureBox22.Hide()
                PictureBox23.Hide()
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "M4A1-S"
            Case "M4A1-S"
                Label3.Text = "M4A1-S | Mecha Industries"
                Dim M4A1S3 As Integer = text.IndexOf("M4A1-S | Mecha Industries")
                If M4A1S3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "M4A1-S | Chantico's Fire"
                Dim M4A1S4 As Integer = text.IndexOf("M4A1-S | Chantico's Fire")
                If M4A1S4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "M4A1-S | Golden Coil"
                Dim M4A1S5 As Integer = text.IndexOf("M4A1-S | Golden Coil")
                If M4A1S5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "M4A1-S | Hyper Beast"
                Dim M4A1S6 As Integer = text.IndexOf("M4A1-S | Hyper Beast")
                If M4A1S6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "M4A1-S | Cyrex"
                Dim M4A1S7 As Integer = text.IndexOf("M4A1-S | Cyrex")
                If M4A1S7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "M4A1-S | Leaded Glass"
                Dim M4A1S8 As Integer = text.IndexOf("M4A1-S | Leaded Glass")
                If M4A1S8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "M4A1-S | Decimator"
                Dim M4A1S9 As Integer = text.IndexOf("M4A1-S | Decimator")
                If M4A1S9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "M4A1-S | Atomic Alloy"
                Dim M4A1S10 As Integer = text.IndexOf("M4A1-S | Atomic Alloy")
                If M4A1S10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "M4A1-S | Guardian"
                Dim M4A1S11 As Integer = text.IndexOf("M4A1-S | Guardian")
                If M4A1S11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "M4A1-S | Hot Rod"
                Dim M4A1S12 As Integer = text.IndexOf("M4A1-S | Hot Rod")
                If M4A1S12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "M4A1-S | Knight"
                Dim M4A1S13 As Integer = text.IndexOf("M4A1-S | Knight")
                If M4A1S13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "M4A1-S | Master Piece"
                Dim M4A1S14 As Integer = text.IndexOf("M4A1-S | Master Piece")
                If M4A1S14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "M4A1-S | Flashback"
                Dim M4A1S15 As Integer = text.IndexOf("M4A1-S | Flashback")
                If M4A1S15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "M4A1-S | Basilisk"
                Dim M4A1S16 As Integer = text.IndexOf("M4A1-S | Basilisk")
                If M4A1S16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "M4A1-S | Bright Water"
                Dim M4A1S17 As Integer = text.IndexOf("M4A1-S | Bright Water")
                If M4A1S17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "M4A1-S | Dark Water"
                Dim M4A1S18 As Integer = text.IndexOf("M4A1-S | Dark Water")
                If M4A1S18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "M4A1-S | Icarus Fell"
                Dim M4A1S19 As Integer = text.IndexOf("M4A1-S | Icarus Fell")
                If M4A1S19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "M4A1-S | Nitro"
                Dim M4A1S20 As Integer = text.IndexOf("M4A1-S | Nitro")
                If M4A1S20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "M4A1-S | Briefing"
                Dim M4A1S21 As Integer = text.IndexOf("M4A1-S | Briefing")
                If M4A1S21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "M4A1-S | Blood Tiger"
                Dim M4A1S22 As Integer = text.IndexOf("M4A1-S | Blood Tiger")
                If M4A1S22 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "M4A1-S | VariCamo"
                Dim M4A1S23 As Integer = text.IndexOf("M4A1-S | VariCamo")
                If M4A1S23 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                Label24.Text = "M4A1-S | Boreal Forest"
                Dim M4A1S24 As Integer = text.IndexOf("M4A1-S | Boreal Forest")
                If M4A1S24 >= 0 Then
                    PictureBox24.Image = My.Resources.GotBox
                Else
                    PictureBox24.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "M4A4"
            Case "M4A4"
                Label3.Text = "M4A4 | Howl"
                Dim M4A43 As Integer = text.IndexOf("M4A4 | Howl")
                If M4A43 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "M4A4 | Buzz Kill"
                Dim M4A44 As Integer = text.IndexOf("M4A4 | Buzz Kill")
                If M4A44 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "M4A4 | The Battlestar"
                Dim M4A45 As Integer = text.IndexOf("M4A4 | The Battlestar")
                If M4A45 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "M4A4 | Royal Paladin"
                Dim M4A46 As Integer = text.IndexOf("M4A4 | Royal Paladin")
                If M4A46 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "M4A4 | Bullet Rain"
                Dim M4A47 As Integer = text.IndexOf("M4A4 | Bullet Rain")
                If M4A47 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "M4A4 | Desert-Strike"
                Dim M4A48 As Integer = text.IndexOf("M4A4 | Desert-Strike")
                If M4A48 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "M4A4 | Asiimov"
                Dim M4A49 As Integer = text.IndexOf("M4A4 | Asiimov")
                If M4A49 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "M4A4 | X-Ray"
                Dim M4A410 As Integer = text.IndexOf("M4A4 | X-Ray")
                If M4A410 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "M4A4 | Hellfire"
                Dim M4A411 As Integer = text.IndexOf("M4A4 | Hellfire")
                If M4A411 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "M4A4 | Desolate Space"
                Dim M4A412 As Integer = text.IndexOf("M4A4 | Desolate Space")
                If M4A412 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "M4A4 | 龍王 (Dragon King)"
                Dim M4A413 As Integer = text.IndexOf("M4A4 | 龍王 (Dragon King)")
                If M4A413 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "M4A4 | Poseidon"
                Dim M4A414 As Integer = text.IndexOf("M4A4 | Poseidon")
                If M4A414 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "M4A4 | Evil Daimyo"
                Dim M4A415 As Integer = text.IndexOf("M4A4 | Evil Daimyo")
                If M4A415 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "M4A4 | Griffin"
                Dim M4A416 As Integer = text.IndexOf("M4A4 | Griffin")
                If M4A416 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "M4A4 | Zirka"
                Dim M4A417 As Integer = text.IndexOf("M4A4 | Zirka")
                If M4A417 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "M4A4 | Daybreak"
                Dim M4A418 As Integer = text.IndexOf("M4A4 | Daybreak")
                If M4A418 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "M4A4 | Modern Hunter"
                Dim M4A419 As Integer = text.IndexOf("M4A4 | Modern Hunter")
                If M4A419 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "M4A4 | Faded Zebra"
                Dim M4A420 As Integer = text.IndexOf("M4A4 | Faded Zebra")
                If M4A420 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "M4A4 | Radiation Hazard"
                Dim M4A421 As Integer = text.IndexOf("M4A4 | Radiation Hazard")
                If M4A421 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "M4A4 | Urban DDPAT"
                Dim M4A422 As Integer = text.IndexOf("M4A4 | Urban DDPAT")
                If M4A422 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "M4A4 | Tornado"
                Dim M4A423 As Integer = text.IndexOf("M4A4 | Tornado")
                If M4A423 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                Label24.Text = "M4A4 | Jungle Tiger"
                Dim M4A424 As Integer = text.IndexOf("M4A4 | Jungle Tiger")
                If M4A424 >= 0 Then
                    PictureBox24.Image = My.Resources.GotBox
                Else
                    PictureBox24.Image = My.Resources.NotGotBox
                End If
                '
                Label25.Text = "M4A4 | Desert Storm"
                Dim M4A425 As Integer = text.IndexOf("M4A4 | Desert Storm")
                If M4A425 >= 0 Then
                    PictureBox25.Image = My.Resources.GotBox
                Else
                    PictureBox25.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "M9 Bayonet"
            Case "M9 Bayonet"
                Label3.Text = "M9 Bayonet"
                Dim M9Bayonet3 As Integer = text.IndexOf("M9 Bayonet")
                If M9Bayonet3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "M9 Bayonet | Lore"
                Dim M9Bayonet4 As Integer = text.IndexOf("M9 Bayonet | Lore")
                If M9Bayonet4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "M9 Bayonet | Gamma Doppler"
                Dim M9Bayonet5 As Integer = text.IndexOf("M9 Bayonet | Gamma Doppler")
                If M9Bayonet5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "M9 Bayonet | Autotronic"
                Dim M9Bayonet6 As Integer = text.IndexOf("M9 Bayonet | Autotronic")
                If M9Bayonet6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "M9 Bayonet | Black Laminate"
                Dim M9Bayonet7 As Integer = text.IndexOf("M9 Bayonet | Black Laminate")
                If M9Bayonet7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "M9 Bayonet | Freehand"
                Dim M9Bayonet8 As Integer = text.IndexOf("M9 Bayonet | Freehand")
                If M9Bayonet8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "M9 Bayonet | Bright Water"
                Dim M9Bayonet9 As Integer = text.IndexOf("M9 Bayonet | Bright Water")
                If M9Bayonet9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "M9 Bayonet | Marble Fade"
                Dim M9Bayonet10 As Integer = text.IndexOf("M9 Bayonet | Marble Fade")
                If M9Bayonet10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "M9 Bayonet | Tiger Tooth"
                Dim M9Bayonet11 As Integer = text.IndexOf("M9 Bayonet | Tiger Tooth")
                If M9Bayonet11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "M9 Bayonet | Doppler"
                Dim M9Bayonet12 As Integer = text.IndexOf("M9 Bayonet | Doppler")
                If M9Bayonet12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "M9 Bayonet | Rust Coat"
                Dim M9Bayonet13 As Integer = text.IndexOf("M9 Bayonet | Rust Coat")
                If M9Bayonet13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "M9 Bayonet | Damascus Steel"
                Dim M9Bayonet14 As Integer = text.IndexOf("M9 Bayonet | Damascus Steel")
                If M9Bayonet14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "M9 Bayonet | Ultraviolet"
                Dim M9Bayonet15 As Integer = text.IndexOf("M9 Bayonet | Ultraviolet")
                If M9Bayonet15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "M9 Bayonet | Fade"
                Dim M9Bayonet16 As Integer = text.IndexOf("M9 Bayonet | Fade")
                If M9Bayonet16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "M9 Bayonet | Crimson Web"
                Dim M9Bayonet17 As Integer = text.IndexOf("M9 Bayonet | Crimson Web")
                If M9Bayonet17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "M9 Bayonet | Slaughter"
                Dim M9Bayonet18 As Integer = text.IndexOf("M9 Bayonet | Slaughter")
                If M9Bayonet18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "M9 Bayonet | Blue Steel"
                Dim M9Bayonet19 As Integer = text.IndexOf("M9 Bayonet | Blue Steel")
                If M9Bayonet19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "M9 Bayonet | Case Hardened"
                Dim M9Bayonet20 As Integer = text.IndexOf("M9 Bayonet | Case Hardened")
                If M9Bayonet20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "M9 Bayonet | Stained"
                Dim M9Bayonet21 As Integer = text.IndexOf("M9 Bayonet | Stained")
                If M9Bayonet21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "M9 Bayonet | Night"
                Dim M9Bayonet22 As Integer = text.IndexOf("M9 Bayonet | Night")
                If M9Bayonet22 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "M9 Bayonet | Scorched"
                Dim M9Bayonet23 As Integer = text.IndexOf("M9 Bayonet | Scorched")
                If M9Bayonet23 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                Label24.Text = "M9 Bayonet | Boreal Forest"
                Dim M9Bayonet24 As Integer = text.IndexOf("M9 Bayonet | Boreal Forest")
                If M9Bayonet24 >= 0 Then
                    PictureBox24.Image = My.Resources.GotBox
                Else
                    PictureBox24.Image = My.Resources.NotGotBox
                End If
                '
                Label25.Text = "M9 Bayonet | Forest DDPAT"
                Dim M9Bayonet25 As Integer = text.IndexOf("M9 Bayonet | Forest DDPAT")
                If M9Bayonet25 >= 0 Then
                    PictureBox25.Image = My.Resources.GotBox
                Else
                    PictureBox25.Image = My.Resources.NotGotBox
                End If
                '
                Label26.Text = "M9 Bayonet | Urban Masked"
                Dim M9Bayonet26 As Integer = text.IndexOf("M9 Bayonet | Urban Masked")
                If M9Bayonet26 >= 0 Then
                    PictureBox26.Image = My.Resources.GotBox
                Else
                    PictureBox26.Image = My.Resources.NotGotBox
                End If
                '
                Label27.Text = "M9 Bayonet | Safari Mesh"
                Dim M9Bayonet27 As Integer = text.IndexOf("M9 Bayonet | Safari Mesh")
                If M9Bayonet27 >= 0 Then
                    PictureBox27.Image = My.Resources.GotBox
                Else
                    PictureBox27.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "MAC-10"
            Case "MAC-10"
                Label3.Text = "MAC-10 | Neon Rider"
                Dim MAC103 As Integer = text.IndexOf("MAC-10 | Neon Rider")
                If MAC103 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "MAC-10 | Last Dive"
                Dim MAC104 As Integer = text.IndexOf("MAC-10 | Last Dive")
                If MAC104 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "MAC-10 | Malachite"
                Dim MAC105 As Integer = text.IndexOf("MAC-10 | Malachite")
                If MAC105 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "MAC-10 | Tatter"
                Dim MAC106 As Integer = text.IndexOf("MAC-10 | Tatter")
                If MAC106 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "MAC-10 | Curse"
                Dim MAC107 As Integer = text.IndexOf("MAC-10 | Curse")
                If MAC107 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "MAC-10 | Heat"
                Dim MAC108 As Integer = text.IndexOf("MAC-10 | Heat")
                If MAC108 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "MAC-10 | Graven"
                Dim MAC109 As Integer = text.IndexOf("MAC-10 | Graven")
                If MAC109 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "MAC-10 | Oceanic"
                Dim MAC1010 As Integer = text.IndexOf("MAC-10 | Oceanic")
                If MAC1010 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "MAC-10 | Aloha"
                Dim MAC1011 As Integer = text.IndexOf("MAC-10 | Aloha")
                If MAC1011 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "MAC-10 | Carnivore"
                Dim MAC1012 As Integer = text.IndexOf("MAC-10 | Carnivore")
                If MAC1012 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "MAC-10 | Lapis Gator"
                Dim MAC1013 As Integer = text.IndexOf("MAC-10 | Lapis Gator")
                If MAC1013 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "MAC-10 | Rangeen"
                Dim MAC1014 As Integer = text.IndexOf("MAC-10 | Rangeen")
                If MAC1014 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "MAC-10 | Ultraviolet"
                Dim MAC1015 As Integer = text.IndexOf("MAC-10 | Ultraviolet")
                If MAC1015 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "MAC-10 | Fade"
                Dim MAC1016 As Integer = text.IndexOf("MAC-10 | Fade")
                If MAC1016 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "MAC-10 | Nuclear Garden"
                Dim MAC1017 As Integer = text.IndexOf("MAC-10 | Nuclear Garden")
                If MAC1017 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "MAC-10 | Amber Fade"
                Dim MAC1018 As Integer = text.IndexOf("MAC-10 | Amber Fade")
                If MAC1018 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "MAC-10 | Commuter"
                Dim MAC1019 As Integer = text.IndexOf("MAC-10 | Commuter")
                If MAC1019 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "MAC-10 | Silver"
                Dim MAC1020 As Integer = text.IndexOf("MAC-10 | Silver")
                If MAC1020 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "MAC-10 | Palm"
                Dim MAC1021 As Integer = text.IndexOf("MAC-10 | Palm")
                If MAC1021 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "MAC-10 | Candy Apple"
                Dim MAC1022 As Integer = text.IndexOf("MAC-10 | Candy Apple")
                If MAC1022 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "MAC-10 | Indigo"
                Dim MAC1023 As Integer = text.IndexOf("MAC-10 | Indigo")
                If MAC1023 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                Label24.Text = "MAC-10 | Tornado"
                Dim MAC1024 As Integer = text.IndexOf("MAC-10 | Tornado")
                If MAC1024 >= 0 Then
                    PictureBox24.Image = My.Resources.GotBox
                Else
                    PictureBox24.Image = My.Resources.NotGotBox
                End If
                '
                Label25.Text = "MAC-10 | Urban DDPAT"
                Dim MAC1025 As Integer = text.IndexOf("MAC-10 | Urban DDPAT")
                If MAC1025 >= 0 Then
                    PictureBox25.Image = My.Resources.GotBox
                Else
                    PictureBox25.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "MAG-7"
            Case "MAG-7"
                Label3.Text = "MAG-7 | Petroglyph"
                Dim MAG73 As Integer = text.IndexOf("MAG-7 | Petroglyph")
                If MAG73 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "MAG-7 | Praetorian"
                Dim MAG74 As Integer = text.IndexOf("MAG-7 | Praetorian")
                If MAG74 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "MAG-7 | Heat"
                Dim MAG75 As Integer = text.IndexOf("MAG-7 | Heat")
                If MAG75 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "MAG-7 | Bulldozer"
                Dim MAG76 As Integer = text.IndexOf("MAG-7 | Bulldozer")
                If MAG76 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "MAG-7 | Hard Water"
                Dim MAG77 As Integer = text.IndexOf("MAG-7 | Hard Water")
                If MAG77 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "MAG-7 | Sonar"
                Dim MAG78 As Integer = text.IndexOf("MAG-7 | Sonar")
                If MAG78 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "MAG-7 | Cobalt Core"
                Dim MAG79 As Integer = text.IndexOf("MAG-7 | Cobalt Core")
                If MAG79 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "MAG-7 | Firestarter"
                Dim MAG710 As Integer = text.IndexOf("MAG-7 | Firestarter")
                If MAG710 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "MAG-7 | Heaven Guard"
                Dim MAG711 As Integer = text.IndexOf("MAG-7 | Heaven Guard")
                If MAG711 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "MAG-7 | Memento"
                Dim MAG712 As Integer = text.IndexOf("MAG-7 | Memento")
                If MAG712 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "MAG-7 | Counter Terrace"
                Dim MAG713 As Integer = text.IndexOf("MAG-7 | Counter Terrace")
                If MAG713 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "MAG-7 | Hazard"
                Dim MAG714 As Integer = text.IndexOf("MAG-7 | Hazard")
                If MAG714 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "MAG-7 | Silver"
                Dim MAG715 As Integer = text.IndexOf("MAG-7 | Silver")
                If MAG715 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "MAG-7 | Metallic DDPAT"
                Dim MAG716 As Integer = text.IndexOf("MAG-7 | Metallic DDPAT")
                If MAG716 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "MAG-7 | Seabird"
                Dim MAG717 As Integer = text.IndexOf("MAG-7 | Seabird")
                If MAG717 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "MAG-7 | Storm"
                Dim MAG718 As Integer = text.IndexOf("MAG-7 | Storm")
                If MAG718 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "MAG-7 | Irradiated Alert"
                Dim MAG719 As Integer = text.IndexOf("MAG-7 | Irradiated Alert")
                If MAG719 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "MAG-7 | Sand Dune"
                Dim MAG720 As Integer = text.IndexOf("MAG-7 | Sand Dune")
                If MAG720 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox21.Hide()
                PictureBox22.Hide()
                PictureBox23.Hide()
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "MP7"
            Case "MP7"
                Label3.Text = "MP7 | Nemesis"
                Dim MP73 As Integer = text.IndexOf("MP7 | Nemesis")
                If MP73 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "MP7 | Impire"
                Dim MP74 As Integer = text.IndexOf("MP7 | Impire")
                If MP74 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "MP7 | Special Deliver"
                Dim MP75 As Integer = text.IndexOf("MP7 | Special Deliver")
                If MP75 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "MP7 | Ocean Foam"
                Dim MP76 As Integer = text.IndexOf("MP7 | Ocean Foam")
                If MP76 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "MP7 | Akoben"
                Dim MP77 As Integer = text.IndexOf("MP7 | Akoben")
                If MP77 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "MP7 | Cirrus"
                Dim MP78 As Integer = text.IndexOf("MP7 | Cirrus")
                If MP78 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "MP7 | Armor Core"
                Dim MP79 As Integer = text.IndexOf("MP7 | Armor Core")
                If MP79 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "MP7 | Urban Hazard"
                Dim MP710 As Integer = text.IndexOf("MP7 | Urban Hazard")
                If MP710 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "MP7 | Skulls"
                Dim MP711 As Integer = text.IndexOf("MP7 | Skulls")
                If MP711 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "MP7 | Full Stop"
                Dim MP712 As Integer = text.IndexOf("MP7 | Full Stop")
                If MP712 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "MP7 | Anodized Navy"
                Dim MP713 As Integer = text.IndexOf("MP7 | Anodized Navy")
                If MP713 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "MP7 | Whiteout"
                Dim MP714 As Integer = text.IndexOf("MP7 | Whiteout")
                If MP714 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "MP7 | Gunsmoke"
                Dim MP715 As Integer = text.IndexOf("MP7 | Gunsmoke")
                If MP715 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "MP7 | Orange Peel"
                Dim MP716 As Integer = text.IndexOf("MP7 | Orange Peel")
                If MP716 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "MP7 | Asterion"
                Dim MP717 As Integer = text.IndexOf("MP7 | Asterion")
                If MP717 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "MP7 | Olive Plaid"
                Dim MP718 As Integer = text.IndexOf("MP7 | Olive Plaid")
                If MP718 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "MP7 | Forest DDPAT"
                Dim MP719 As Integer = text.IndexOf("MP7 | Forest DDPAT")
                If MP719 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "MP7 | Army Recon"
                Dim MP720 As Integer = text.IndexOf("MP7 | Army Recon")
                If MP720 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "MP7 | Groundwater"
                Dim MP721 As Integer = text.IndexOf("MP7 | Groundwater")
                If MP721 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox22.Hide()
                PictureBox23.Hide()
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "MP9"
            Case "MP9"
                Label3.Text = "MP9 | Airlock"
                Dim MP93 As Integer = text.IndexOf("MP9 | Airlock")
                If MP93 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "MP9 | Goo"
                Dim MP94 As Integer = text.IndexOf("MP9 | Goo")
                If MP94 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "MP9 | Ruby Poison Dart"
                Dim MP95 As Integer = text.IndexOf("MP9 | Ruby Poison Dart")
                If MP95 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "MP9 | Rose Iron"
                Dim MP96 As Integer = text.IndexOf("MP9 | Rose Iron")
                If MP96 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "MP9 | Hypnotic"
                Dim MP97 As Integer = text.IndexOf("MP9 | Hypnotic")
                If MP97 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "MP9 | Bulldozer"
                Dim MP98 As Integer = text.IndexOf("MP9 | Bulldozer")
                If MP98 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "MP9 | Sand Scale"
                Dim MP99 As Integer = text.IndexOf("MP9 | Sand Scale")
                If MP99 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "MP9 | Bioleak"
                Dim MP910 As Integer = text.IndexOf("MP9 | Bioleak")
                If MP910 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "MP9 | Deadly Poison"
                Dim MP911 As Integer = text.IndexOf("MP9 | Deadly Poison")
                If MP911 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "MP9 | Dart"
                Dim MP912 As Integer = text.IndexOf("MP9 | Dart")
                If MP912 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "MP9 | Pandora's Box"
                Dim MP913 As Integer = text.IndexOf("MP9 | Pandora's Box")
                If MP913 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "MP9 | Setting Sun"
                Dim MP914 As Integer = text.IndexOf("MP9 | Setting Sun")
                If MP914 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "MP9 | Dark Age"
                Dim MP915 As Integer = text.IndexOf("MP9 | Dark Age")
                If MP915 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "MP9 | Hot Rod"
                Dim MP916 As Integer = text.IndexOf("MP9 | Hot Rod")
                If MP916 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "MP9 | Orange Peel"
                Dim MP917 As Integer = text.IndexOf("MP9 | Orange Peel")
                If MP917 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "MP9 | Green Plaid"
                Dim MP918 As Integer = text.IndexOf("MP9 | Green Plaid")
                If MP918 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "MP9 | Storm"
                Dim MP919 As Integer = text.IndexOf("MP9 | Storm")
                If MP919 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "MP9 | Sand Dashed"
                Dim MP920 As Integer = text.IndexOf("MP9 | Sand Dashed")
                If MP920 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "MP9 | Dry Season"
                Dim MP921 As Integer = text.IndexOf("MP9 | Dry Season")
                If MP921 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox22.Hide()
                PictureBox23.Hide()
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "Negev"
            Case "Negev"
                Label3.Text = "Negev | Power Loader"
                Dim Negev3 As Integer = text.IndexOf("Negev | Power Loader")
                If Negev3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "Negev | Loudmouth"
                Dim Negev4 As Integer = text.IndexOf("Negev | Loudmouth")
                If Negev4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "Negev | Dazzle"
                Dim Negev5 As Integer = text.IndexOf("Negev | Dazzle")
                If Negev5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "Negev | Man-o'-war"
                Dim Negev6 As Integer = text.IndexOf("Negev | Man-o'-war")
                If Negev6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "Negev | Bratatat"
                Dim Negev7 As Integer = text.IndexOf("Negev | Bratatat")
                If Negev7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "Negev | Desert-Strike"
                Dim Negev8 As Integer = text.IndexOf("Negev | Desert-Strike")
                If Negev8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "Negev | Terrain"
                Dim Negev9 As Integer = text.IndexOf("Negev | Terrain")
                If Negev9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "Negev | Anodized Navy"
                Dim Negev10 As Integer = text.IndexOf("Negev | Anodized Navy")
                If Negev10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "Negev | Nuclear Waste"
                Dim Negev11 As Integer = text.IndexOf("Negev | Nuclear Waste")
                If Negev11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "Negev | CaliCamo"
                Dim Negev12 As Integer = text.IndexOf("Negev | CaliCamo")
                If Negev12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "Negev | Palm"
                Dim Negev13 As Integer = text.IndexOf("Negev | Palm")
                If Negev13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "Negev | Army Sheen"
                Dim Negev14 As Integer = text.IndexOf("Negev | Army Sheen")
                If Negev14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox15.Hide()
                PictureBox16.Hide()
                PictureBox17.Hide()
                PictureBox18.Hide()
                PictureBox19.Hide()
                PictureBox20.Hide()
                PictureBox21.Hide()
                PictureBox22.Hide()
                PictureBox23.Hide()
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "Nova"
            Case "Nova"
                Label3.Text = "Nova | Hyper Beast"
                Dim Nova3 As Integer = text.IndexOf("Nova | Hyper Beast")
                If Nova3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "Nova | Bloomstick"
                Dim Nova4 As Integer = text.IndexOf("Nova | Bloomstick")
                If Nova4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "Nova | Antique"
                Dim Nova5 As Integer = text.IndexOf("Nova | Antique")
                If Nova5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "Nova | Gila"
                Dim Nova6 As Integer = text.IndexOf("Nova | Gila")
                If Nova6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "Nova | Koi"
                Dim Nova7 As Integer = text.IndexOf("Nova | Koi")
                If Nova7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "Nova | Rising Skull"
                Dim Nova8 As Integer = text.IndexOf("Nova | Rising Skull")
                If Nova8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "Nova | Graphite"
                Dim Nova9 As Integer = text.IndexOf("Nova | Graphite")
                If Nova9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "Nova | Exo"
                Dim Nova10 As Integer = text.IndexOf("Nova | Exo")
                If Nova10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "Nova | Ranger"
                Dim Nova11 As Integer = text.IndexOf("Nova | Ranger")
                If Nova11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "Nova | Ghost Camo"
                Dim Nova12 As Integer = text.IndexOf("Nova | Ghost Camo")
                If Nova12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "Nova | Tempest"
                Dim Nova13 As Integer = text.IndexOf("Nova | Tempest")
                If Nova13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "Nova | Blaze Orange"
                Dim Nova14 As Integer = text.IndexOf("Nova | Blaze Orange")
                If Nova14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "Nova | Modern Hunter"
                Dim Nova15 As Integer = text.IndexOf("Nova | Modern Hunter")
                If Nova15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "Nova | Green Apple"
                Dim Nova16 As Integer = text.IndexOf("Nova | Green Apple")
                If Nova16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "Nova | Caged Steel"
                Dim Nova17 As Integer = text.IndexOf("Nova | Caged Steel")
                If Nova17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "Nova | Candy Apple"
                Dim Nova18 As Integer = text.IndexOf("Nova | Candy Apple")
                If Nova18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "Nova | Moon in Libra"
                Dim Nova19 As Integer = text.IndexOf("Nova | Moon in Libra")
                If Nova19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "Nova | Sand Dune"
                Dim Nova20 As Integer = text.IndexOf("Nova | Sand Dune")
                If Nova20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "Nova | Predator"
                Dim Nova21 As Integer = text.IndexOf("Nova | Predator")
                If Nova21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "Nova | Polar Mesh"
                Dim Nova22 As Integer = text.IndexOf("Nova | Polar Mesh")
                If Nova22 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "Nova | Forest Leaves"
                Dim Nova23 As Integer = text.IndexOf("Nova | Forest Leaves")
                If Nova23 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                Label24.Text = "Nova | Walnut"
                Dim Nova24 As Integer = text.IndexOf("Nova | Walnut")
                If Nova24 >= 0 Then
                    PictureBox24.Image = My.Resources.GotBox
                Else
                    PictureBox24.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "P2000"
            Case "P2000"
                Label3.Text = "P2000 | Fire Elemental"
                Dim P20003 As Integer = text.IndexOf("P2000 | Fire Elemental")
                If P20003 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "P2000 | Imperial Dragon"
                Dim P20004 As Integer = text.IndexOf("P2000 | Imperial Dragon")
                If P20004 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "P2000 | Corticera"
                Dim P20005 As Integer = text.IndexOf("P2000 | Corticera")
                If P20005 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "P2000 | Ocean Foam"
                Dim P20006 As Integer = text.IndexOf("P2000 | Ocean Foam")
                If P20006 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "P2000 | Woodsman"
                Dim P20007 As Integer = text.IndexOf("P2000 | Woodsman")
                If P20007 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "P2000 | Handgun"
                Dim P20008 As Integer = text.IndexOf("P2000 | Handgun")
                If P20008 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "P2000 | Amber Fade"
                Dim P20009 As Integer = text.IndexOf("P2000 | Amber Fade")
                If P20009 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "P2000 | Scorpion"
                Dim P200010 As Integer = text.IndexOf("P2000 | Scorpion")
                If P200010 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "P2000 | Turf"
                Dim P200011 As Integer = text.IndexOf("P2000 | Turf")
                If P200011 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "P2000 | Oceanic"
                Dim P200012 As Integer = text.IndexOf("P2000 | Oceanic")
                If P200012 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "P2000 | Imperial"
                Dim P200013 As Integer = text.IndexOf("P2000 | Imperial")
                If P200013 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "P2000 | Ivory"
                Dim P200014 As Integer = text.IndexOf("P2000 | Ivory")
                If P200014 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "P2000 | Pulse"
                Dim P200015 As Integer = text.IndexOf("P2000 | Pulse")
                If P200015 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "P2000 | Red FragCam"
                Dim P200016 As Integer = text.IndexOf("P2000 | Red FragCam")
                If P200016 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "P2000 | Chainmail"
                Dim P200017 As Integer = text.IndexOf("P2000 | Chainmail")
                If P200017 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "P2000 | Silver"
                Dim P200018 As Integer = text.IndexOf("P2000 | Silver")
                If P200018 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "P2000 | Pathfinder"
                Dim P200019 As Integer = text.IndexOf("P2000 | Pathfinder")
                If P200019 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "P2000 | Grassland"
                Dim P200020 As Integer = text.IndexOf("P2000 | Grassland")
                If P200020 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "P2000 | Coach Class"
                Dim P200021 As Integer = text.IndexOf("P2000 | Coach Class")
                If P200021 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "P2000 | Granite Marbleized"
                Dim P200022 As Integer = text.IndexOf("P2000 | Granite Marbleized")
                If P200022 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "P2000 | Grassland Leaves"
                Dim P200023 As Integer = text.IndexOf("P2000 | Grassland Leaves")
                If P200023 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "P250"
            Case "P250"
                Label3.Text = "P250 | See Ya Later"
                Dim P2503 As Integer = text.IndexOf("P250 | See Ya Later")
                If P2503 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "P250 | Asiimov"
                Dim P2504 As Integer = text.IndexOf("P250 | Asiimov")
                If P2504 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "P250 | Muertos"
                Dim P2505 As Integer = text.IndexOf("P250 | Muertos")
                If P2505 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "P250 | Cartel"
                Dim P2506 As Integer = text.IndexOf("P250 | Cartel")
                If P2506 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "P250 | Undertow"
                Dim P2507 As Integer = text.IndexOf("P250 | Undertow")
                If P2507 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "P250 | Mehndi"
                Dim P2508 As Integer = text.IndexOf("P250 | Mehndi")
                If P2508 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "P250 | Franklin"
                Dim P2509 As Integer = text.IndexOf("P250 | Franklin")
                If P2509 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "P250 | Red Rock"
                Dim P25010 As Integer = text.IndexOf("P250 | Red Rock")
                If P25010 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "P250 | Wingshot"
                Dim P25011 As Integer = text.IndexOf("P250 | Wingshot")
                If P25011 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "P250 | Supernova"
                Dim P25012 As Integer = text.IndexOf("P250 | Supernova")
                If P25012 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "P250 | Splash"
                Dim P25013 As Integer = text.IndexOf("P250 | Splash")
                If P25013 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "P250 | Nuclear Threat"
                Dim P25014 As Integer = text.IndexOf("P250 | Nuclear Threat")
                If P25014 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "P250 | Ripple"
                Dim P25015 As Integer = text.IndexOf("P250 | Ripple")
                If P25015 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "P250 | Iron Clad"
                Dim P25016 As Integer = text.IndexOf("P250 | Iron Clad")
                If P25016 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "P250 | Valence"
                Dim P25017 As Integer = text.IndexOf("P250 | Valence")
                If P25017 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "P250 | Steel Disruption"
                Dim P25018 As Integer = text.IndexOf("P250 | Steel Disruption")
                If P25018 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "P250 | Hive"
                Dim P25019 As Integer = text.IndexOf("P250 | Hive")
                If P25019 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "P250 | Whiteout"
                Dim P25020 As Integer = text.IndexOf("P250 | Whiteout")
                If P25020 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "P250 | Modern Hunter"
                Dim P25021 As Integer = text.IndexOf("P250 | Modern Hunter")
                If P25021 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "P250 | Crimson Kimono"
                Dim P25022 As Integer = text.IndexOf("P250 | Crimson Kimono")
                If P25022 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "P250 | Contamination"
                Dim P25023 As Integer = text.IndexOf("P250 | Contamination")
                If P25023 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                Label24.Text = "P250 | Metallic DDPAT"
                Dim P25024 As Integer = text.IndexOf("P250 | Metallic DDPAT")
                If P25024 >= 0 Then
                    PictureBox24.Image = My.Resources.GotBox
                Else
                    PictureBox24.Image = My.Resources.NotGotBox
                End If
                '
                Label25.Text = "P250 | Facets"
                Dim P25025 As Integer = text.IndexOf("P250 | Facets")
                If P25025 >= 0 Then
                    PictureBox25.Image = My.Resources.GotBox
                Else
                    PictureBox25.Image = My.Resources.NotGotBox
                End If
                '
                Label26.Text = "P250 | Gunsmoke"
                Dim P25026 As Integer = text.IndexOf("P250 | Gunsmoke")
                If P25026 >= 0 Then
                    PictureBox26.Image = My.Resources.GotBox
                Else
                    PictureBox26.Image = My.Resources.NotGotBox
                End If
                '
                Label27.Text = "P250 | Mint Kimono"
                Dim P25027 As Integer = text.IndexOf("P250 | Mint Kimono")
                If P25027 >= 0 Then
                    PictureBox27.Image = My.Resources.GotBox
                Else
                    PictureBox27.Image = My.Resources.NotGotBox
                End If
                '
                Label28.Text = "P250 | Sand Dune"
                Dim P25028 As Integer = text.IndexOf("P250 | Sand Dune")
                If P25028 >= 0 Then
                    PictureBox28.Image = My.Resources.GotBox
                Else
                    PictureBox28.Image = My.Resources.NotGotBox
                End If
                '
                Label29.Text = "P250 | Bone Mask"
                Dim P25029 As Integer = text.IndexOf("P250 | Bone Mask")
                If P25029 >= 0 Then
                    PictureBox29.Image = My.Resources.GotBox
                Else
                    PictureBox29.Image = My.Resources.NotGotBox
                End If
                '
                Label30.Text = "P250 | Boreal Forest"
                Dim P25030 As Integer = text.IndexOf("P250 | Boreal Forest")
                If P25030 >= 0 Then
                    PictureBox30.Image = My.Resources.GotBox
                Else
                    PictureBox30.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "P90"
            Case "P90"
                Label3.Text = "P90 | Asiimov"
                Dim P903 As Integer = text.IndexOf("P90 | Asiimov")
                If P903 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "P90 | Death by Kitty"
                Dim P904 As Integer = text.IndexOf("P90 | Death by Kitty")
                If P904 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "P90 | Shallow Grave"
                Dim P905 As Integer = text.IndexOf("P90 | Shallow Grave")
                If P905 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "P90 | Shapewood"
                Dim P906 As Integer = text.IndexOf("P90 | Shapewood")
                If P906 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "P90 | Trigon"
                Dim P907 As Integer = text.IndexOf("P90 | Trigon")
                If P907 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "P90 | Cold Blooded"
                Dim P908 As Integer = text.IndexOf("P90 | Cold Blooded")
                If P908 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "P90 | Emerald Dragon"
                Dim P909 As Integer = text.IndexOf("P90 | Emerald Dragon")
                If P909 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "P90 | Death Grip"
                Dim P9010 As Integer = text.IndexOf("P90 | Death Grip")
                If P9010 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "P90 | Chopper"
                Dim P9011 As Integer = text.IndexOf("P90 | Chopper")
                If P9011 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "P90 | Virus"
                Dim P9012 As Integer = text.IndexOf("P90 | Virus")
                If P9012 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "P90 | Blind Spot"
                Dim P9013 As Integer = text.IndexOf("P90 | Blind Spot")
                If P9013 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "P90 | Grim"
                Dim P9014 As Integer = text.IndexOf("P90 | Grim")
                If P9014 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "P90 | Elite Build"
                Dim P9015 As Integer = text.IndexOf("P90 | Elite Build")
                If P9015 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "P90 | Module"
                Dim P9016 As Integer = text.IndexOf("P90 | Module")
                If P9016 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "P90 | Desert Warfare"
                Dim P9017 As Integer = text.IndexOf("P90 | Desert Warfare")
                If P9017 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "P90 | Teardown"
                Dim P9018 As Integer = text.IndexOf("P90 | Teardown")
                If P9018 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "P90 | Glacier Mesh"
                Dim P9019 As Integer = text.IndexOf("P90 | Glacier Mesh")
                If P9019 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "P90 | Leather"
                Dim P9020 As Integer = text.IndexOf("P90 | Leather")
                If P9020 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "P90 | Ash Wood"
                Dim P9021 As Integer = text.IndexOf("P90 | Ash Wood")
                If P9021 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "P90 | Fallout Warning"
                Dim P9022 As Integer = text.IndexOf("P90 | Fallout Warning")
                If P9022 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "P90 | Storm"
                Dim P9023 As Integer = text.IndexOf("P90 | Storm")
                If P9023 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                Label24.Text = "P90 | Scorched"
                Dim P9024 As Integer = text.IndexOf("P90 | Scorched")
                If P9024 >= 0 Then
                    PictureBox24.Image = My.Resources.GotBox
                Else
                    PictureBox24.Image = My.Resources.NotGotBox
                End If
                '
                Label25.Text = "P90 | Sand Spray"
                Dim P9025 As Integer = text.IndexOf("P90 | Sand Spray")
                If P9025 >= 0 Then
                    PictureBox25.Image = My.Resources.GotBox
                Else
                    PictureBox25.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "PP-Bizon"
            Case "PP-Bizon"
                Label3.Text = "PP-Bizon | Judgement of Anubis"
                Dim PPBizon3 As Integer = text.IndexOf("PP-Bizon | Judgement of Anubis")
                If PPBizon3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "PP-Bizon | High Roller"
                Dim PPBizon4 As Integer = text.IndexOf("PP-Bizon | High Roller")
                If PPBizon4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "PP-Bizon | Fuel Rod"
                Dim PPBizon5 As Integer = text.IndexOf("PP-Bizon | Fuel Rod")
                If PPBizon5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "PP-Bizon | Blue Streak"
                Dim PPBizon6 As Integer = text.IndexOf("PP-Bizon | Blue Streak")
                If PPBizon6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "PP-Bizon | Osiris"
                Dim PPBizon7 As Integer = text.IndexOf("PP-Bizon | Osiris")
                If PPBizon7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "PP-Bizon | Antique"
                Dim PPBizon8 As Integer = text.IndexOf("PP-Bizon | Antique")
                If PPBizon8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "PP-Bizon | Jungle Slipstream"
                Dim PPBizon9 As Integer = text.IndexOf("PP-Bizon | Jungle Slipstream")
                If PPBizon9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "PP-Bizon | Harvester"
                Dim PPBizon10 As Integer = text.IndexOf("PP-Bizon | Harvester")
                If PPBizon10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "PP-Bizon | Photic Zone"
                Dim PPBizon11 As Integer = text.IndexOf("PP-Bizon | Photic Zone")
                If PPBizon11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "PP-Bizon | Water Sigil"
                Dim PPBizon12 As Integer = text.IndexOf("PP-Bizon | Water Sigil")
                If PPBizon12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "PP-Bizon | Cobalt Halftone"
                Dim PPBizon13 As Integer = text.IndexOf("PP-Bizon | Cobalt Halftone")
                If PPBizon13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "PP-Bizon | Brass"
                Dim PPBizon14 As Integer = text.IndexOf("PP-Bizon | Brass")
                If PPBizon14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "PP-Bizon | Rust Coat"
                Dim PPBizon15 As Integer = text.IndexOf("PP-Bizon | Rust Coat")
                If PPBizon15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "PP-Bizon | Modern Hunter"
                Dim PPBizon16 As Integer = text.IndexOf("PP-Bizon | Modern Hunter")
                If PPBizon16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "PP-Bizon | Chemical Green"
                Dim PPBizon17 As Integer = text.IndexOf("PP-Bizon | Chemical Green")
                If PPBizon17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "PP-Bizon | Night Ops"
                Dim PPBizon18 As Integer = text.IndexOf("PP-Bizon | Night Ops")
                If PPBizon18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "PP-Bizon | Carbon Fiber"
                Dim PPBizon19 As Integer = text.IndexOf("PP-Bizon | Carbon Fiber")
                If PPBizon19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "PP-Bizon | Bamboo Print"
                Dim PPBizon20 As Integer = text.IndexOf("PP-Bizon | Bamboo Print")
                If PPBizon20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "PP-Bizon | Sand Dashed"
                Dim PPBizon21 As Integer = text.IndexOf("PP-Bizon | Sand Dashed")
                If PPBizon21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "PP-Bizon | Urban Dashed"
                Dim PPBizon22 As Integer = text.IndexOf("PP-Bizon | Urban Dashed")
                If PPBizon22 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "PP-Bizon | Forest Leaves"
                Dim PPBizon23 As Integer = text.IndexOf("PP-Bizon | Forest Leaves")
                If PPBizon23 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                Label24.Text = "PP-Bizon | Irradiated Alert"
                Dim PPBizon24 As Integer = text.IndexOf("PP-Bizon | Irradiated Alert")
                If PPBizon24 >= 0 Then
                    PictureBox24.Image = My.Resources.GotBox
                Else
                    PictureBox24.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "R8-Revolver"
            Case "R8-Revolver"
                Label3.Text = "R8-Revolver | Fade"
                Dim R8Revolver3 As Integer = text.IndexOf("R8-Revolver | Fade")
                If R8Revolver3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "R8-Revolver | Llama Cannon"
                Dim R8Revolver4 As Integer = text.IndexOf("R8-Revolver | Llama Cannon")
                If R8Revolver4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "R8-Revolver | Amber Fade"
                Dim R8Revolver5 As Integer = text.IndexOf("R8-Revolver | Amber Fade")
                If R8Revolver5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "R8-Revolver | Reboot"
                Dim R8Revolver6 As Integer = text.IndexOf("R8-Revolver | Reboot")
                If R8Revolver6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "R8-Revolver | Crimson Web"
                Dim R8Revolver7 As Integer = text.IndexOf("R8-Revolver | Crimson Web")
                If R8Revolver7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "R8-Revolver | Bone Mask"
                Dim R8Revolver8 As Integer = text.IndexOf("R8-Revolver | Bone Mask")
                If R8Revolver8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox9.Hide()
                PictureBox10.Hide()
                PictureBox11.Hide()
                PictureBox12.Hide()
                PictureBox13.Hide()
                PictureBox14.Hide()
                PictureBox15.Hide()
                PictureBox16.Hide()
                PictureBox17.Hide()
                PictureBox18.Hide()
                PictureBox19.Hide()
                PictureBox20.Hide()
                PictureBox21.Hide()
                PictureBox22.Hide()
                PictureBox23.Hide()
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "Sawed-Off"
            Case "Sawed-Off"
                Label3.Text = "Sawed-Off | The Kraken"
                Dim SawedOff3 As Integer = text.IndexOf("Sawed-Off | The Kraken")
                If SawedOff3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "Sawed-Off | Wasteland Princess"
                Dim SawedOff4 As Integer = text.IndexOf("Sawed-Off | Wasteland Princess")
                If SawedOff4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "Sawed-Off | Limelight"
                Dim SawedOff5 As Integer = text.IndexOf("Sawed-Off | Limelight")
                If SawedOff5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "Sawed-Off | Serenity"
                Dim SawedOff6 As Integer = text.IndexOf("Sawed-Off | Serenity")
                If SawedOff6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "Sawed-Off | Highwayman"
                Dim SawedOff7 As Integer = text.IndexOf("Sawed-Off | Highwayman")
                If SawedOff7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "Sawed-Off | Orange DDPAT"
                Dim SawedOff8 As Integer = text.IndexOf("Sawed-Off | Orange DDPAT")
                If SawedOff8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "Sawed-Off | Morris"
                Dim SawedOff9 As Integer = text.IndexOf("Sawed-Off | Morris")
                If SawedOff9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "Sawed-Off | Zander"
                Dim SawedOff10 As Integer = text.IndexOf("Sawed-Off | Zander")
                If SawedOff10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "Sawed-Off | Fubar"
                Dim SawedOff11 As Integer = text.IndexOf("Sawed-Off | Fubar")
                If SawedOff11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "Sawed-Off | Yorick"
                Dim SawedOff12 As Integer = text.IndexOf("Sawed-Off | Yorick")
                If SawedOff12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "Sawed-Off | Origami"
                Dim SawedOff13 As Integer = text.IndexOf("Sawed-Off | Origami")
                If SawedOff13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "Sawed-Off | First Class"
                Dim SawedOff14 As Integer = text.IndexOf("Sawed-Off | First Class")
                If SawedOff14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "Sawed-Off | Full Stop"
                Dim SawedOff15 As Integer = text.IndexOf("Sawed-Off | Full Stop")
                If SawedOff15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "Sawed-Off | Amber Fade"
                Dim SawedOff16 As Integer = text.IndexOf("Sawed-Off | Amber Fade")
                If SawedOff16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "Sawed-Off | Copper"
                Dim SawedOff17 As Integer = text.IndexOf("Sawed-Off | Copper")
                If SawedOff17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "Sawed-Off | Rust Coat"
                Dim SawedOff18 As Integer = text.IndexOf("Sawed-Off | Rust Coat")
                If SawedOff18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "Sawed-Off | Snake Camo"
                Dim SawedOff19 As Integer = text.IndexOf("Sawed-Off | Snake Camo")
                If SawedOff19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "Sawed-Off | Mosaico"
                Dim SawedOff20 As Integer = text.IndexOf("Sawed-Off | Mosaico")
                If SawedOff20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "Sawed-Off | Bamboo Shadow"
                Dim SawedOff21 As Integer = text.IndexOf("Sawed-Off | Bamboo Shadow")
                If SawedOff21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "Sawed-Off | Sage Spray"
                Dim SawedOff22 As Integer = text.IndexOf("Sawed-Off | Sage Spray")
                If SawedOff22 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "Sawed-Off | Forest DDPAT"
                Dim SawedOff23 As Integer = text.IndexOf("Sawed-Off | Forest DDPAT")
                If SawedOff23 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                Label24.Text = "Sawed-Off | Irradiated Alert"
                Dim SawedOff24 As Integer = text.IndexOf("Sawed-Off | Irradiated Alert")
                If SawedOff24 >= 0 Then
                    PictureBox24.Image = My.Resources.GotBox
                Else
                    PictureBox24.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "SCAR-20"
            Case "SCAR-20"
                Label3.Text = "SCAR-20 | Bloodsport"
                Dim SCAR203 As Integer = text.IndexOf("SCAR-20 | Bloodsport")
                If SCAR203 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "SCAR-20 | Cardiac"
                Dim SCAR204 As Integer = text.IndexOf("SCAR-20 | Cardiac")
                If SCAR204 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "SCAR-20 | Cyrex"
                Dim SCAR205 As Integer = text.IndexOf("SCAR-20 | Cyrex")
                If SCAR205 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "SCAR-20 | Splash Jam"
                Dim SCAR206 As Integer = text.IndexOf("SCAR-20 | Splash Jam")
                If SCAR206 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "SCAR-20 | Powercore"
                Dim SCAR207 As Integer = text.IndexOf("SCAR-20 | Powercore")
                If SCAR207 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "SCAR-20 | Emerald"
                Dim SCAR208 As Integer = text.IndexOf("SCAR-20 | Emerald")
                If SCAR208 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "SCAR-20 | Jungle Slipstream"
                Dim SCAR209 As Integer = text.IndexOf("SCAR-20 | Jungle Slipstream")
                If SCAR209 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "SCAR-20 | Blueprint"
                Dim SCAR2010 As Integer = text.IndexOf("SCAR-20 | Blueprint")
                If SCAR2010 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "SCAR-20 | Outbreak"
                Dim SCAR2011 As Integer = text.IndexOf("SCAR-20 | Outbreak")
                If SCAR2011 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "SCAR-20 | Green Marine"
                Dim SCAR2012 As Integer = text.IndexOf("SCAR-20 | Green Marine")
                If SCAR2012 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "SCAR-20 | Grotto"
                Dim SCAR2013 As Integer = text.IndexOf("SCAR-20 | Grotto")
                If SCAR2013 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "SCAR-20 | Crimson Web"
                Dim SCAR2014 As Integer = text.IndexOf("SCAR-20 | Crimson Web")
                If SCAR2014 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "SCAR-20 | Carbon Fiber"
                Dim SCAR2015 As Integer = text.IndexOf("SCAR-20 | Carbon Fiber")
                If SCAR2015 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "SCAR-20 | Palm"
                Dim SCAR2016 As Integer = text.IndexOf("SCAR-20 | Palm")
                If SCAR2016 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "SCAR-20 | Army Sheen"
                Dim SCAR2017 As Integer = text.IndexOf("SCAR-20 | Army Sheen")
                If SCAR2017 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "SCAR-20 | Storm"
                Dim SCAR2018 As Integer = text.IndexOf("SCAR-20 | Storm")
                If SCAR2018 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "SCAR-20 | Contractor"
                Dim SCAR2019 As Integer = text.IndexOf("SCAR-20 | Contractor")
                If SCAR2019 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "SCAR-20 | Sand Mesh"
                Dim SCAR2020 As Integer = text.IndexOf("SCAR-20 | Sand Mesh")
                If SCAR2020 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox21.Hide()
                PictureBox22.Hide()
                PictureBox23.Hide()
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "SG 553"
            Case "SG 553"
                Label3.Text = "SG 553 | Cyrex"
                Dim SG5533 As Integer = text.IndexOf("SG 553 | Cyrex")
                If SG5533 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "SG 553 | Phantom"
                Dim SG5534 As Integer = text.IndexOf("SG 553 | Phantom")
                If SG5534 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "SG 553 | Triarch"
                Dim SG5535 As Integer = text.IndexOf("SG 553 | Triarch")
                If SG5535 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "SG 553 | Tiger Moth"
                Dim SG5536 As Integer = text.IndexOf("SG 553 | Tiger Moth")
                If SG5536 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "SG 553 | Pulse"
                Dim SG5537 As Integer = text.IndexOf("SG 553 | Pulse")
                If SG5537 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "SG 553 | Bulldozer"
                Dim SG5538 As Integer = text.IndexOf("SG 553 | Bulldozer")
                If SG5538 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "SG 553 | Aerial"
                Dim SG5539 As Integer = text.IndexOf("SG 553 | Aerial")
                If SG5539 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "SG 553 | Atlas"
                Dim SG55310 As Integer = text.IndexOf("SG 553 | Atlas")
                If SG55310 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "SG 553 | Wave Spray"
                Dim SG55311 As Integer = text.IndexOf("SG 553 | Wave Spray")
                If SG55311 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "SG 553 | Ultraviolet"
                Dim SG55312 As Integer = text.IndexOf("SG 553 | Ultraviolet")
                If SG55312 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "SG 553 | Anodized Navy"
                Dim SG55313 As Integer = text.IndexOf("SG 553 | Anodized Navy")
                If SG55313 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "SG 553 | Damascus Steel"
                Dim SG55314 As Integer = text.IndexOf("SG 553 | Damascus Steel")
                If SG55314 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "SG 553 | Fallout Warning"
                Dim SG55315 As Integer = text.IndexOf("SG 553 | Fallout Warning")
                If SG55315 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "SG 553 | Traveler"
                Dim SG55316 As Integer = text.IndexOf("SG 553 | Traveler")
                If SG55316 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "SG 553 | Gator Mesh"
                Dim SG55317 As Integer = text.IndexOf("SG 553 | Gator Mesh")
                If SG55317 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "SG 553 | Army Sheen"
                Dim SG55318 As Integer = text.IndexOf("SG 553 | Army Sheen")
                If SG55318 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "SG 553 | Waves Perforated"
                Dim SG55319 As Integer = text.IndexOf("SG 553 | Waves Perforated")
                If SG55319 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "SG 553 | Tornado"
                Dim SG55320 As Integer = text.IndexOf("SG 553 | Tornado")
                If SG55320 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox21.Hide()
                PictureBox22.Hide()
                PictureBox23.Hide()
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "Shadow Daggers"
            Case "Shadow Daggers"
                Label3.Text = "Shadow Daggers"
                Dim ShadowDaggers3 As Integer = text.IndexOf("Shadow Daggers")
                If ShadowDaggers3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "Shadow Daggers | Ultraviolet"
                Dim ShadowDaggers4 As Integer = text.IndexOf("Shadow Daggers | Ultraviolet")
                If ShadowDaggers4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "Shadow Daggers | Doppler"
                Dim ShadowDaggers5 As Integer = text.IndexOf("Shadow Daggers | Doppler")
                If ShadowDaggers5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "Shadow Daggers | Marble Fade"
                Dim ShadowDaggers6 As Integer = text.IndexOf("Shadow Daggers | Marble Fade")
                If ShadowDaggers6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "Shadow Daggers | Tiger Tooth"
                Dim ShadowDaggers7 As Integer = text.IndexOf("Shadow Daggers | Tiger Tooth")
                If ShadowDaggers7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "Shadow Daggers | Damascus Steel"
                Dim ShadowDaggers8 As Integer = text.IndexOf("Shadow Daggers | Damascus Steel")
                If ShadowDaggers8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "Shadow Daggers | Rust Coat"
                Dim ShadowDaggers9 As Integer = text.IndexOf("Shadow Daggers | Rust Coat")
                If ShadowDaggers9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "Shadow Daggers | Fade"
                Dim ShadowDaggers10 As Integer = text.IndexOf("Shadow Daggers | Fade")
                If ShadowDaggers10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "Shadow Daggers | Slaughter"
                Dim ShadowDaggers11 As Integer = text.IndexOf("Shadow Daggers | Slaughter")
                If ShadowDaggers11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "Shadow Daggers | Case Hardened"
                Dim ShadowDaggers12 As Integer = text.IndexOf("Shadow Daggers | Case Hardened")
                If ShadowDaggers12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "Shadow Daggers | Crimson Web"
                Dim ShadowDaggers13 As Integer = text.IndexOf("Shadow Daggers | Crimson Web")
                If ShadowDaggers13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "Shadow Daggers | Blue Steel"
                Dim ShadowDaggers14 As Integer = text.IndexOf("Shadow Daggers | Blue Steel")
                If ShadowDaggers14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "Shadow Daggers | Urban Masked"
                Dim ShadowDaggers15 As Integer = text.IndexOf("Shadow Daggers | Urban Masked")
                If ShadowDaggers15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "Shadow Daggers | Night"
                Dim ShadowDaggers16 As Integer = text.IndexOf("Shadow Daggers | Night")
                If ShadowDaggers16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "Shadow Daggers | Safari Mesh"
                Dim ShadowDaggers17 As Integer = text.IndexOf("Shadow Daggers | Safari Mesh")
                If ShadowDaggers17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "Shadow Daggers | Scorched"
                Dim ShadowDaggers18 As Integer = text.IndexOf("Shadow Daggers | Scorched")
                If ShadowDaggers18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "Shadow Daggers | Stained"
                Dim ShadowDaggers19 As Integer = text.IndexOf("Shadow Daggers | Stained")
                If ShadowDaggers19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "Shadow Daggers | Forest DDPAT"
                Dim ShadowDaggers20 As Integer = text.IndexOf("Shadow Daggers | Forest DDPAT")
                If ShadowDaggers20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "Shadow Daggers | Boreal Forest"
                Dim ShadowDaggers21 As Integer = text.IndexOf("Shadow Daggers | Boreal Forest")
                If ShadowDaggers21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox22.Hide()
                PictureBox23.Hide()
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "SSG 08"
            Case "SSG 08"
                Label3.Text = "SSG 08 | Dragonfire"
                Dim SSG083 As Integer = text.IndexOf("SSG 08 | Dragonfire")
                If SSG083 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "SSG 08 | Blood in the Water"
                Dim SSG084 As Integer = text.IndexOf("SSG 08 | Blood in the Water")
                If SSG084 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "SSG 08 | Big Iron"
                Dim SSG085 As Integer = text.IndexOf("SSG 08 | Big Iron")
                If SSG085 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "SSG 08 | Death's Head"
                Dim SSG086 As Integer = text.IndexOf("SSG 08 | Death's Head")
                If SSG086 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "SSG 08 | Ghost Crusader"
                Dim SSG087 As Integer = text.IndexOf("SSG 08 | Ghost Crusader")
                If SSG087 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "SSG 08 | Necropos"
                Dim SSG088 As Integer = text.IndexOf("SSG 08 | Necropos")
                If SSG088 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "SSG 08 | Dark Water"
                Dim SSG089 As Integer = text.IndexOf("SSG 08 | Dark Water")
                If SSG089 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "SSG 08 | Abyss"
                Dim SSG0810 As Integer = text.IndexOf("SSG 08 | Abyss")
                If SSG0810 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "SSG 08 | Slashed"
                Dim SSG0811 As Integer = text.IndexOf("SSG 08 | Slashed")
                If SSG0811 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "SSG 08 | Detour"
                Dim SSG0812 As Integer = text.IndexOf("SSG 08 | Detour")
                If SSG0812 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "SSG 08 | Acid Fade"
                Dim SSG0813 As Integer = text.IndexOf("SSG 08 | Acid Fade")
                If SSG0813 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "SSG 08 | Tropical Storm"
                Dim SSG0814 As Integer = text.IndexOf("SSG 08 | Tropical Storm")
                If SSG0814 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "SSG 08 | Mayan Dreams"
                Dim SSG0815 As Integer = text.IndexOf("SSG 08 | Mayan Dreams")
                If SSG0815 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "SSG 08 | Sand Dune"
                Dim SSG0816 As Integer = text.IndexOf("SSG 08 | Sand Dune")
                If SSG0816 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "SSG 08 | Blue Spruce"
                Dim SSG0817 As Integer = text.IndexOf("SSG 08 | Blue Spruce")
                If SSG0817 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "SSG 08 | Lichen Dashed"
                Dim SSG0818 As Integer = text.IndexOf("SSG 08 | Lichen Dashed")
                If SSG0818 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox19.Hide()
                PictureBox20.Hide()
                PictureBox21.Hide()
                PictureBox22.Hide()
                PictureBox23.Hide()
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "Tec-9"
            Case "Tec-9"
                Label3.Text = "Tec-9 | Fuel Injector"
                Dim Tec93 As Integer = text.IndexOf("Tec-9 | Fuel Injector")
                If Tec93 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "Tec-9 | Re-Entry"
                Dim Tec94 As Integer = text.IndexOf("Tec-9 | Re-Entry")
                If Tec94 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "Tec-9 | Avalanche"
                Dim Tec95 As Integer = text.IndexOf("Tec-9 | Avalanche")
                If Tec95 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "Tec-9 | Titanium Bit"
                Dim Tec96 As Integer = text.IndexOf("Tec-9 | Titanium Bit")
                If Tec96 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "Tec-9 | Red Quartz"
                Dim Tec97 As Integer = text.IndexOf("Tec-9 | Red Quartz")
                If Tec97 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "Tec-9 | Nuclear Threat"
                Dim Tec98 As Integer = text.IndexOf("Tec-9 | Nuclear Threat")
                If Tec98 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "Tec-9 | Cracked Opal"
                Dim Tec99 As Integer = text.IndexOf("Tec-9 | Cracked Opal")
                If Tec99 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "Tec-9 | Cut Out"
                Dim Tec910 As Integer = text.IndexOf("Tec-9 | Cut Out")
                If Tec910 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "Tec-9 | Ice Cap"
                Dim Tec911 As Integer = text.IndexOf("Tec-9 | Ice Cap")
                If Tec911 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "Tec-9 | Jambiya"
                Dim Tec912 As Integer = text.IndexOf("Tec-9 | Jambiya")
                If Tec912 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "Tec-9 | Isaac"
                Dim Tec913 As Integer = text.IndexOf("Tec-9 | Isaac")
                If Tec913 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "Tec-9 | Sandstorm"
                Dim Tec914 As Integer = text.IndexOf("Tec-9 | Sandstorm")
                If Tec914 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "Tec-9 | Blue Titanium"
                Dim Tec915 As Integer = text.IndexOf("Tec-9 | Blue Titanium")
                If Tec915 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "Tec-9 | Terrace"
                Dim Tec916 As Integer = text.IndexOf("Tec-9 | Terrace")
                If Tec916 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "Tec-9 | Toxic"
                Dim Tec917 As Integer = text.IndexOf("Tec-9 | Toxic")
                If Tec917 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "Tec-9 | Brass"
                Dim Tec918 As Integer = text.IndexOf("Tec-9 | Brass")
                If Tec918 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "Tec-9 | Ossified"
                Dim Tec919 As Integer = text.IndexOf("Tec-9 | Ossified")
                If Tec919 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "Tec-9 | Hades"
                Dim Tec920 As Integer = text.IndexOf("Tec-9 | Hades")
                If Tec920 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "Tec-9 | VariCamo"
                Dim Tec921 As Integer = text.IndexOf("Tec-9 | VariCamo")
                If Tec921 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "Tec-9 | Bamboo Forest"
                Dim Tec922 As Integer = text.IndexOf("Tec-9 | Bamboo Forest")
                If Tec922 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "Tec-9 | Urban DDPAT"
                Dim Tec923 As Integer = text.IndexOf("Tec-9 | Urban DDPAT")
                If Tec923 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                Label24.Text = "Tec-9 | Army Mesh"
                Dim Tec924 As Integer = text.IndexOf("Tec-9 | Army Mesh")
                If Tec924 >= 0 Then
                    PictureBox24.Image = My.Resources.GotBox
                Else
                    PictureBox24.Image = My.Resources.NotGotBox
                End If
                '
                Label25.Text = "Tec-9 | Groundwater"
                Dim Tec925 As Integer = text.IndexOf("Tec-9 | Groundwater")
                If Tec925 >= 0 Then
                    PictureBox25.Image = My.Resources.GotBox
                Else
                    PictureBox25.Image = My.Resources.NotGotBox
                End If
                '
                Label26.Text = "Tec-9 | Tornado"
                Dim Tec926 As Integer = text.IndexOf("Tec-9 | Tornado")
                If Tec926 >= 0 Then
                    PictureBox26.Image = My.Resources.GotBox
                Else
                    PictureBox26.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "UMP-45"
            Case "UMP-45"
                Label3.Text = "UMP-45 | Primal Saber"
                Dim UMP453 As Integer = text.IndexOf("UMP-45 | Primal Saber")
                If UMP453 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "UMP-45 | Exposure"
                Dim UMP454 As Integer = text.IndexOf("UMP-45 | Exposure")
                If UMP454 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "UMP-45 | Scaffold"
                Dim UMP455 As Integer = text.IndexOf("UMP-45 | Scaffold")
                If UMP455 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "UMP-45 | Grand Prix"
                Dim UMP456 As Integer = text.IndexOf("UMP-45 | Grand Prix")
                If UMP456 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "UMP-45 | Metal Flowers"
                Dim UMP457 As Integer = text.IndexOf("UMP-45 | Metal Flowers")
                If UMP457 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "UMP-45 | Briefing"
                Dim UMP458 As Integer = text.IndexOf("UMP-45 | Briefing")
                If UMP458 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "UMP-45 | Riot"
                Dim UMP459 As Integer = text.IndexOf("UMP-45 | Riot")
                If UMP459 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "UMP-45 | Delusion"
                Dim UMP4510 As Integer = text.IndexOf("UMP-45 | Delusion")
                If UMP4510 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "UMP-45 | Labyrinth"
                Dim UMP4511 As Integer = text.IndexOf("UMP-45 | Labyrinth")
                If UMP4511 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "UMP-45 | Corporal"
                Dim UMP4512 As Integer = text.IndexOf("UMP-45 | Corporal")
                If UMP4512 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "UMP-45 | Bone Pile"
                Dim UMP4513 As Integer = text.IndexOf("UMP-45 | Bone Pile")
                If UMP4513 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "UMP-45 | Minotaur's Labyrinth"
                Dim UMP4514 As Integer = text.IndexOf("UMP-45 | Minotaur's Labyrinth")
                If UMP4514 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "UMP-45 | Blaze"
                Dim UMP4515 As Integer = text.IndexOf("UMP-45 | Blaze")
                If UMP4515 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "UMP-45 | Carbon Fiber"
                Dim UMP4516 As Integer = text.IndexOf("UMP-45 | Carbon Fiber")
                If UMP4516 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "UMP-45 | Gunsmoke"
                Dim UMP4517 As Integer = text.IndexOf("UMP-45 | Gunsmoke")
                If UMP4517 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "UMP-45 | Fallout Warning"
                Dim UMP4518 As Integer = text.IndexOf("UMP-45 | Fallout Warning")
                If UMP4518 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "UMP-45 | Indigo"
                Dim UMP4519 As Integer = text.IndexOf("UMP-45 | Indigo")
                If UMP4519 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "UMP-45 | Scorched"
                Dim UMP4520 As Integer = text.IndexOf("UMP-45 | Scorched")
                If UMP4520 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "UMP-45 | Urban DDPAT"
                Dim UMP4521 As Integer = text.IndexOf("UMP-45 | Urban DDPAT")
                If UMP4521 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "UMP-45 | Caramel"
                Dim UMP4522 As Integer = text.IndexOf("UMP-45 | Caramel")
                If UMP4522 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox23.Hide()
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "USP-S"
            Case "USP-S"
                Label3.Text = "USP-S | Neo-Noir"
                Dim USPS3 As Integer = text.IndexOf("USP-S | Neo-Noir")
                If USPS3 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "USP-S | Kill Confirmed"
                Dim USPS4 As Integer = text.IndexOf("USP-S | Kill Confirmed")
                If USPS4 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "USP-S | Caiman"
                Dim USPS5 As Integer = text.IndexOf("USP-S | Caiman")
                If USPS5 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "USP-S | Orion"
                Dim USPS6 As Integer = text.IndexOf("USP-S | Orion")
                If USPS6 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "USP-S | Serum"
                Dim USPS7 As Integer = text.IndexOf("USP-S | Serum")
                If USPS7 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "USP-S | Cyrex"
                Dim USPS8 As Integer = text.IndexOf("USP-S | Cyrex")
                If USPS8 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "USP-S | Guardian"
                Dim USPS9 As Integer = text.IndexOf("USP-S | Guardian")
                If USPS9 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "USP-S | Overgrowth"
                Dim USPS10 As Integer = text.IndexOf("USP-S | Overgrowth")
                If USPS10 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "USP-S | Dark Water"
                Dim USPS11 As Integer = text.IndexOf("USP-S | Dark Water")
                If USPS11 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "USP-S | Road Rash"
                Dim USPS12 As Integer = text.IndexOf("USP-S | Road Rash")
                If USPS12 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "USP-S | Blueprint"
                Dim USPS13 As Integer = text.IndexOf("USP-S | Blueprint")
                If USPS13 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "USP-S | Lead Conduit"
                Dim USPS14 As Integer = text.IndexOf("USP-S | Lead Conduit")
                If USPS14 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "USP-S | Torque"
                Dim USPS15 As Integer = text.IndexOf("USP-S | Torque")
                If USPS15 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "USP-S | Blood Tiger"
                Dim USPS16 As Integer = text.IndexOf("USP-S | Blood Tiger")
                If USPS16 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "USP-S | Stainless"
                Dim USPS17 As Integer = text.IndexOf("USP-S | Stainless")
                If USPS17 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "USP-S | Business Class"
                Dim USPS18 As Integer = text.IndexOf("USP-S | Business Class")
                If USPS18 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "USP-S | Night Ops"
                Dim USPS19 As Integer = text.IndexOf("USP-S | Night Ops")
                If USPS19 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "USP-S | Para Green"
                Dim USPS20 As Integer = text.IndexOf("USP-S | Para Green")
                If USPS20 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "USP-S | Royal Blue"
                Dim USPS21 As Integer = text.IndexOf("USP-S | Royal Blue")
                If USPS21 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "USP-S | Forest Leaves"
                Dim USPS22 As Integer = text.IndexOf("USP-S | Forest Leaves")
                If USPS22 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox23.Hide()
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
#Region "XM1014"
            Case "XM1014"
                Label3.Text = "XM1014 | Tranquility"
                Dim XM10143 As Integer = text.IndexOf("XM1014 | Tranquility")
                If XM10143 >= 0 Then
                    PictureBox3.Image = My.Resources.GotBox
                Else
                    PictureBox3.Image = My.Resources.NotGotBox
                End If
                '
                Label4.Text = "XM1014 | Ziggy"
                Dim XM10144 As Integer = text.IndexOf("XM1014 | Ziggy")
                If XM10144 >= 0 Then
                    PictureBox4.Image = My.Resources.GotBox
                Else
                    PictureBox4.Image = My.Resources.NotGotBox
                End If
                '
                Label5.Text = "XM1014 | Seasons"
                Dim XM10145 As Integer = text.IndexOf("XM1014 | Seasons")
                If XM10145 >= 0 Then
                    PictureBox5.Image = My.Resources.GotBox
                Else
                    PictureBox5.Image = My.Resources.NotGotBox
                End If
                '
                Label6.Text = "XM1014 | Black Tie"
                Dim XM10146 As Integer = text.IndexOf("XM1014 | Black Tie")
                If XM10146 >= 0 Then
                    PictureBox6.Image = My.Resources.GotBox
                Else
                    PictureBox6.Image = My.Resources.NotGotBox
                End If
                '
                Label7.Text = "XM1014 | Teclu Burner"
                Dim XM10147 As Integer = text.IndexOf("XM1014 | Teclu Burner")
                If XM10147 >= 0 Then
                    PictureBox7.Image = My.Resources.GotBox
                Else
                    PictureBox7.Image = My.Resources.NotGotBox
                End If
                '
                Label8.Text = "XM1014 | Heaven Guard"
                Dim XM10148 As Integer = text.IndexOf("XM1014 | Heaven Guard")
                If XM10148 >= 0 Then
                    PictureBox8.Image = My.Resources.GotBox
                Else
                    PictureBox8.Image = My.Resources.NotGotBox
                End If
                '
                Label9.Text = "XM1014 | Slipstream"
                Dim XM10149 As Integer = text.IndexOf("XM1014 | Slipstream")
                If XM10149 >= 0 Then
                    PictureBox9.Image = My.Resources.GotBox
                Else
                    PictureBox9.Image = My.Resources.NotGotBox
                End If
                '
                Label10.Text = "XM1014 | Scumbria"
                Dim XM101410 As Integer = text.IndexOf("XM1014 | Scumbria")
                If XM101410 >= 0 Then
                    PictureBox10.Image = My.Resources.GotBox
                Else
                    PictureBox10.Image = My.Resources.NotGotBox
                End If
                '
                Label11.Text = "XM1014 | Quicksilver"
                Dim XM101411 As Integer = text.IndexOf("XM1014 | Quicksilver")
                If XM101411 >= 0 Then
                    PictureBox11.Image = My.Resources.GotBox
                Else
                    PictureBox11.Image = My.Resources.NotGotBox
                End If
                '
                Label12.Text = "XM1014 | Red Python"
                Dim XM101412 As Integer = text.IndexOf("XM1014 | Red Python")
                If XM101412 >= 0 Then
                    PictureBox12.Image = My.Resources.GotBox
                Else
                    PictureBox12.Image = My.Resources.NotGotBox
                End If
                '
                Label13.Text = "XM1014 | Bone Machine"
                Dim XM101413 As Integer = text.IndexOf("XM1014 | Bone Machine")
                If XM101413 >= 0 Then
                    PictureBox13.Image = My.Resources.GotBox
                Else
                    PictureBox13.Image = My.Resources.NotGotBox
                End If
                '
                Label14.Text = "XM1014 | Red Leather"
                Dim XM101414 As Integer = text.IndexOf("XM1014 | Red Leather")
                If XM101414 >= 0 Then
                    PictureBox14.Image = My.Resources.GotBox
                Else
                    PictureBox14.Image = My.Resources.NotGotBox
                End If
                '
                Label15.Text = "XM1014 | VariCamo Blue"
                Dim XM101415 As Integer = text.IndexOf("XM1014 | VariCamo Blue")
                If XM101415 >= 0 Then
                    PictureBox15.Image = My.Resources.GotBox
                Else
                    PictureBox15.Image = My.Resources.NotGotBox
                End If
                '
                Label16.Text = "XM1014 | Blaze Orange"
                Dim XM101416 As Integer = text.IndexOf("XM1014 | Blaze Orange")
                If XM101416 >= 0 Then
                    PictureBox16.Image = My.Resources.GotBox
                Else
                    PictureBox16.Image = My.Resources.NotGotBox
                End If
                '
                Label17.Text = "XM1014 | Blue Steel"
                Dim XM101417 As Integer = text.IndexOf("XM1014 | Blue Steel")
                If XM101417 >= 0 Then
                    PictureBox17.Image = My.Resources.GotBox
                Else
                    PictureBox17.Image = My.Resources.NotGotBox
                End If
                '
                Label18.Text = "XM1014 | CaliCamo"
                Dim XM101418 As Integer = text.IndexOf("XM1014 | CaliCamo")
                If XM101418 >= 0 Then
                    PictureBox18.Image = My.Resources.GotBox
                Else
                    PictureBox18.Image = My.Resources.NotGotBox
                End If
                '
                Label19.Text = "XM1014 | Fallout Warning"
                Dim XM101419 As Integer = text.IndexOf("XM1014 | Fallout Warning")
                If XM101419 >= 0 Then
                    PictureBox19.Image = My.Resources.GotBox
                Else
                    PictureBox19.Image = My.Resources.NotGotBox
                End If
                '
                Label20.Text = "XM1014 | Blue Spruce"
                Dim XM101420 As Integer = text.IndexOf("XM1014 | Blue Spruce")
                If XM101420 >= 0 Then
                    PictureBox20.Image = My.Resources.GotBox
                Else
                    PictureBox20.Image = My.Resources.NotGotBox
                End If
                '
                Label21.Text = "XM1014 | Jungle"
                Dim XM101421 As Integer = text.IndexOf("XM1014 | Jungle")
                If XM101421 >= 0 Then
                    PictureBox21.Image = My.Resources.GotBox
                Else
                    PictureBox21.Image = My.Resources.NotGotBox
                End If
                '
                Label22.Text = "XM1014 | Grassland"
                Dim XM101422 As Integer = text.IndexOf("XM1014 | Grassland")
                If XM101422 >= 0 Then
                    PictureBox22.Image = My.Resources.GotBox
                Else
                    PictureBox22.Image = My.Resources.NotGotBox
                End If
                '
                Label23.Text = "XM1014 | Urban Perforated"
                Dim XM101423 As Integer = text.IndexOf("XM1014 | Urban Perforated")
                If XM101423 >= 0 Then
                    PictureBox23.Image = My.Resources.GotBox
                Else
                    PictureBox23.Image = My.Resources.NotGotBox
                End If
                '
                PictureBox24.Hide()
                PictureBox25.Hide()
                PictureBox26.Hide()
                PictureBox27.Hide()
                PictureBox28.Hide()
                PictureBox29.Hide()
                PictureBox30.Hide()
                PictureBox31.Hide()
                PictureBox32.Hide()
                '
#End Region
        End Select
    End Sub
End Class