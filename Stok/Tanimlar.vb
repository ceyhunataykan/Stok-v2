Public Class Tanimlar
    Private Sub btnStokKart_Click(sender As Object, e As EventArgs) Handles btnStokKart.Click
        StokKart.ShowDialog()
    End Sub

    Private Sub btnKategori_Click(sender As Object, e As EventArgs) Handles btnKategori.Click
        Kategoriler.ShowDialog()
    End Sub
End Class