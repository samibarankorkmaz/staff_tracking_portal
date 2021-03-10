Public Class frmTemaAyarlari
    Dim r, g, b As Integer

    Private Sub btnRastgele_Click(sender As Object, e As EventArgs) Handles btnTemaRastgele.Click
        Dim rn As Random = New Random()
        r = rn.Next(255)
        g = rn.Next(255)
        b = rn.Next(255)
        hsR.Value = r
        hsG.Value = g
        hsB.Value = b
        txtR.Text = r.ToString()
        txtG.Text = g.ToString()
        txtB.Text = b.ToString()
        pnRenk.BackColor = Color.FromArgb(r, g, b)
        txtRGB.Text = r.ToString() + "," + g.ToString() + "," + b.ToString()
        txtHexa.Text = "#" + hexaCevir(r) + hexaCevir(g) + hexaCevir(b)
    End Sub

    Private Sub hsR_Scroll(sender As Object, e As ScrollEventArgs) Handles hsR.Scroll

    End Sub

    Sub islem()
        r = hsR.Value
        g = hsG.Value
        b = hsB.Value
        txtR.Text = r.ToString()
        txtG.Text = g.ToString()
        txtB.Text = b.ToString()
        pnRenk.BackColor = Color.FromArgb(r, g, b)
        txtRGB.Text = r.ToString() + "," + g.ToString() + "," + b.ToString()
        txtHexa.Text = "#" + hexaCevir(r) + hexaCevir(g) + hexaCevir(b)
    End Sub





    Function hexaCevir(sayi As Integer)
        Dim h As String = ""
        Dim s1, s2 As Integer
        Dim degerler() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"}
        s1 = (sayi / 16)
        s2 = sayi - (s1 * 16)
        h = degerler(s1) & degerler(s2)
        Return h
    End Function

End Class