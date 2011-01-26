Public Class frmTibiMon
    Private Declare Sub ReleaseCapture Lib "user32" ()
    Private Declare Sub SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = 2

    Public healthAlertmin As String
    Public x, y, z As String
    Public xTemp, yTemp, zTemp As String
    Public tmVer As String = "1.3"

    Private Sub tmrFindTib_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMain.Tick
        'Declare grpHealth
        Dim hp As String = ReadInt(Addresses.HP)
        Dim mana As String = ReadInt(Addresses.Mana)
        Dim hpmax As String = ReadInt(Addresses.HP_Max)
        Dim manamax As String = ReadInt(Addresses.Mana_Max)
        x = ReadInt(Addresses.X)
        y = ReadInt(Addresses.Y)
        z = ReadInt(Addresses.z)

        txtHPmax.Text = hpmax
        pbarHealth.Maximum = txtHPmax.Text
        pbarHealth.Value = hp
        txtHealth.Text = pbarHealth.Value
        txtManaMax.Text = manamax
        pbarMana.Maximum = txtManaMax.Text
        pbarMana.Value = mana
        txtMana.Text = pbarMana.Value
        txtX.Text = x
        txtY.Text = y
        txtZ.Text = z


        If chkSkills.CheckState = 1 Then
            'Declare grpSkills
            Dim target As String = ReadInt(Addresses.RedSquare)
            Dim fistPerc As String = ReadInt(Addresses.Fist_Percent)
            Dim clubPerc As String = ReadInt(Addresses.Club_Percent)
            Dim swordPerc As String = ReadInt(Addresses.Sword_Percent)
            Dim axePerc As String = ReadInt(Addresses.Axe_Percent)
            Dim distPerc As String = ReadInt(Addresses.Distance_Percent)
            Dim fist As String = ReadInt(Addresses.Fist)
            Dim club As String = ReadInt(Addresses.Club)
            Dim sword As String = ReadInt(Addresses.Sword)
            Dim axe As String = ReadInt(Addresses.Axe)
            Dim dist As String = ReadInt(Addresses.Distance)
            Dim shieldPerc As String = ReadInt(Addresses.Shielding_Percent)
            Dim shield As String = ReadInt(Addresses.Shielding)
            Dim fistPercLft As String = 100 - fistPerc
            Dim clubPercLft As String = 100 - clubPerc
            Dim swordPercLft As String = 100 - swordPerc
            Dim axePercLft As String = 100 - axePerc
            Dim distPercLft As String = 100 - distPerc
            Dim shieldPercLft As String = 100 - shieldPerc

            txtTargetID.Text = target
            Select Case cmbSkills.Text
                Case "Fist"
                    txtSkill.Text = fistPercLft & "%"
                    txtNextskill.Text = fist + 1
                    pbarSkills.Value = fistPerc
                    lblSkill.Text = "Fist:"
                Case "Club"
                    txtSkill.Text = clubPercLft & "%"
                    txtNextskill.Text = club + 1
                    pbarSkills.Value = clubPerc
                    lblSkill.Text = "Club:"
                Case "Sword"
                    txtSkill.Text = swordPercLft & "%"
                    txtNextskill.Text = sword + 1
                    pbarSkills.Value = swordPerc
                    lblSkill.Text = "Sword:"
                Case "Axe"
                    txtSkill.Text = axePercLft & "%"
                    txtNextskill.Text = axe + 1
                    pbarSkills.Value = axePerc
                    lblSkill.Text = "Axe:"
                Case "Distance"
                    txtSkill.Text = distPercLft & "%"
                    txtNextskill.Text = dist + 1
                    pbarSkills.Value = distPerc
                    lblSkill.Text = "Distance:"
                Case Else
                    txtSkill.Text = ""
                    txtNextskill.Text = ""
                    pbarSkills.Value = 0
                    lblSkill.Text = "Set Skill:"
            End Select
            txtShield.Text = shieldPercLft & "%"
            txtNextshield.Text = shield + 1
            pbarShield.Value = shieldPerc
        End If

        If chkPlayerPos.CheckState = 1 Then
            If x <> xTemp Or y <> yTemp Then
                tmrXYZsound.Enabled = True
            Else
                tmrXYZsound.Enabled = False
            End If
        Else
            tmrXYZsound.Enabled = False
        End If

        If chkHealth.CheckState = 1 Then
            If hp < healthAlertmin Then
                tmrLowHealth.Enabled = True
            Else
                tmrLowHealth.Enabled = False
            End If
        Else
            tmrLowHealth.Enabled = False
        End If

    End Sub

    Private Sub btnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.Click
        If chkSkills.CheckState = 1 Then
            Me.Size = New Size(720, 275)
            grpMain.Size = New Size(711, 265)
        Else
            Me.Size = New Size(720, 160)
            grpMain.Size = New Size(711, 155)
        End If
        btnOptions.Visible = False
        btnoptions2.Visible = True
        grpOptions.Visible = True
    End Sub

    Private Sub btnoptions2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnoptions2.Click
        If chkSkills.CheckState = 1 Then
            Me.Size = New Size(380, 275)
            grpMain.Size = New Size(374, 265)
        Else
            Me.Size = New Size(380, 160)
            grpMain.Size = New Size(374, 155)
        End If
        btnoptions2.Visible = False
        btnOptions.Visible = True
        grpOptions.Visible = False
    End Sub

    Private Sub frmTibiMon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Size(380, 160)
        grpMain.Size = New Size(374, 155)
        grpHealth.Visible = True
        tmrMain.Enabled = True

        wbUpdate.Navigate("http://www.computertutorit.com/tibimon/tmv.php")
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbarOpacity.Scroll
        Me.Opacity = 0.1 + tbarOpacity.Value / 100
    End Sub

    Private Sub frmTibiMon_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle.ToInt32, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        NotifyIcon1.Visible = False
        End
    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click
        Me.Visible = False
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub txtTargetID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTargetID.TextChanged
        If chkPlaySound.CheckState = 1 Then
            If txtTargetID.Text = "0" Then
                My.Computer.Audio.Play(My.Resources.Notarget, AudioPlayMode.Background)
                'Sound.PlayWaveResource(My.Resources.Notarget)
                lblTarget.Text = "NO"
                lblTarget.ForeColor = Color.Red
            Else
                lblTarget.Text = "YES"
                lblTarget.ForeColor = Color.LimeGreen
            End If
        Else
            If txtTargetID.Text = "0" Then
                lblTarget.Text = "NO"
                lblTarget.ForeColor = Color.Red
            Else
                lblTarget.Text = "YES"
                lblTarget.ForeColor = Color.LimeGreen
            End If
        End If
    End Sub

    Private Sub chkPlaySound_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPlaySound.CheckedChanged
        If chkPlaySound.CheckState = CheckState.Checked Then
            If txtTargetID.Text = "0" Then
                My.Computer.Audio.Play(My.Resources.Notarget, AudioPlayMode.Background)
                'Sound.PlayWaveResource(My.Resources.Notarget)
                lblTarget.Text = "NO"
                lblTarget.ForeColor = Color.Red
            Else
                lblTarget.Text = "YES"
                lblTarget.ForeColor = Color.LimeGreen
            End If
        End If
    End Sub

    Private Sub chkPlayerPos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPlayerPos.CheckedChanged
        If chkPlayerPos.CheckState = 1 Then
            xTemp = x
            yTemp = y
            zTemp = z
        Else
            xTemp = ""
            yTemp = ""
            zTemp = ""
            tmrXYZsound.Enabled = False
        End If
    End Sub

    Private Sub tmrXYZsound_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrXYZsound.Tick
        My.Computer.Audio.Play(My.Resources.location, AudioPlayMode.Background)
    End Sub

    Private Sub chkHealth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHealth.CheckedChanged
        If chkHealth.CheckState = 1 Then
            tmrMain.Enabled = False
            healthAlertmin = InputBox("Minimum Health to Alert?", "Min. Health Alert", "100")
            tmrMain.Enabled = True
        Else
            healthAlertmin = ""
            tmrLowHealth.Enabled = False
        End If
    End Sub

    Private Sub tmrLowHealth_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLowHealth.Tick
        My.Computer.Audio.Play(My.Resources.health, AudioPlayMode.Background)
    End Sub

    Private Sub chkTopMost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTopMost.CheckedChanged
        If chkTopMost.CheckState = 1 Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If Me.Visible = False Then
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
        Else
            Me.Visible = False
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        NotifyIcon1.Visible = False
        End
    End Sub

    Private Sub chkSkills_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSkills.CheckedChanged
        If chkSkills.CheckState = 1 Then
            grpSkills.Visible = True
            If btnOptions.Visible = True Then
                Me.Size = New Size(380, 275)
                grpMain.Size = New Size(374, 265)
            Else
                Me.Size = New Size(720, 275)
                grpMain.Size = New Size(711, 265)
            End If
        Else
            grpSkills.Visible = False
            If btnOptions.Visible = True Then
                Me.Size = New Size(380, 160)
                grpMain.Size = New Size(374, 155)
            Else
                Me.Size = New Size(720, 160)
                grpMain.Size = New Size(711, 155)
            End If
        End If
    End Sub

    Private Sub grpMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grpMain.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle.ToInt32, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
        End If
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        MsgBox("TibiMon is designed to allow the user to safely train without breaking the rules." & vbNewLine & "TibiMon does not give an advantage over other players nor does it make any changes to the Tibia Client.", MsgBoxStyle.Information, "About TibiMon")
    End Sub

    Private Sub wbUpdate_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles wbUpdate.DocumentCompleted
        Dim ver As String
        ver = wbUpdate.DocumentText
        Dim yesNo As Integer
        If ver = tmVer Then
        Else
            yesNo = MsgBox("A new update has been made available." & vbNewLine & "Would you like to download it now?", MsgBoxStyle.YesNo, "Update Ready!")
            If yesNo = 6 Then ' Yes
                wbdownload.Navigate("http://www.computertutorit.com/tibimon/TibiMon-v13.exe")
                'no=7
            End If
        End If
    End Sub
End Class
