

Public Class frmAnasayfa


    Private Sub tsbuttonExit_Click(sender As Object, e As EventArgs) Handles tsbuttonExit.Click
        Application.Exit()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        ofdAnasayfa.ShowDialog()


    End Sub


    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True


        End If

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBossYas.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True


        End If

    End Sub



    Private Sub TextBox4_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtBossTc.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True


        End If
    End Sub



    Private Sub TextBox17_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True


        End If
    End Sub

    Private Sub TextBox14_TextChanged_1(sender As Object, e As EventArgs) Handles txtCal5.TextChanged

    End Sub

    Private Sub TextBox17_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtCal8.KeyPress, txtCal7.KeyPress, txtCal6.KeyPress, txtCal5.KeyPress, txtCal4.KeyPress, txtCal3.KeyPress, txtCal2.KeyPress, txtCal1.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True


        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBossBanka.Click
        frmBossBanka.Show()

    End Sub



    Private Sub tsbuttonSettings_Click(sender As Object, e As EventArgs) Handles tsbuttonSettings.Click
        frmAyarlar.Show()

    End Sub

    Private Sub tsbuttonDonation_Click(sender As Object, e As EventArgs) Handles tsbuttonDonation.Click
        frmBagis.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnBossTel.Click
        MsgBox("0532.410.53.97", MsgBoxStyle.Information, "Telefon")

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnBossMail.Click
        MsgBox("d...p.....@gmail.com", MsgBoxStyle.YesNo, "Mail göndermek istiyor musunuz?")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnKalanMaas.Click
        frmSayac.Show()
        frmSayac.lbKalanSayac.Text = "0"

        timerAnasayfa.Enabled = True
        timerAnasayfa.Interval = 5000

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timerAnasayfa.Tick
        Dim rastgele As New Random()
        Dim sayi As Integer = rastgele.Next(0, 9999)
        frmSayac.lbKalanSayac.Text = sayi.ToString() & " " & "TL"



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPerKayit.Click
        frmDelal.Show() 'örnek olarak
    End Sub

    Private Sub cmsAnasayfa_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsAnasayfa.Opening

    End Sub

    Private Sub ofdAnasayfa_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdAnasayfa.FileOk

    End Sub
End Class
