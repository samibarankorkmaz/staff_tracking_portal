Public Class frmAdminGiris
    Private Sub btnGiris_Click(sender As Object, e As EventArgs) Handles btnGiris.Click
        If txtAd.Text = "admin" And txtSif.Text = "admin" And cbBaglanti.SelectedItem = "Offline" Then

            frmAnasayfa.Show()



        Else
            MsgBox("Kullanıcı adı-şifreniz yanlış veya bağlantı türünüz doğru değil, lütfen layığıyla giriniz!", MsgBoxStyle.Critical, "Olamaz!")

        End If



    End Sub


    Private Sub frmAdminGiris_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbBaglanti_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBaglanti.SelectedIndexChanged

    End Sub
End Class