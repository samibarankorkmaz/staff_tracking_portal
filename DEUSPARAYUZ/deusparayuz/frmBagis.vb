Public Class frmBagis
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBagisIban.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True


        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBagisMiktar.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True


        End If
    End Sub
End Class