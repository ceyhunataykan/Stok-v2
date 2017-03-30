Public Class Raporlar
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        StokHareketDetay.ShowDialog()
    End Sub

    Private Sub btnStokKart_Click(sender As Object, e As EventArgs) Handles btnStokKart.Click
        StokListeRapor.ShowDialog()
    End Sub
End Class