Public Class frmBossBanka
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBossBanka.KeyPress, txtBossIban.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class