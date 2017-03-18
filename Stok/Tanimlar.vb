Public Class Tanimlar
    Private Sub btnStokKart_Click(sender As Object, e As EventArgs) Handles btnStokKart.Click
        StokKart.ShowDialog()
    End Sub

    Private Sub btnKategori_Click(sender As Object, e As EventArgs) Handles btnKategori.Click
        Kategoriler.ShowDialog()
    End Sub

    Private Sub btnBirim_Click(sender As Object, e As EventArgs) Handles btnBirim.Click
        Birimler.ShowDialog()
    End Sub

    Private Sub btnBolum_Click(sender As Object, e As EventArgs) Handles btnBolum.Click
        Bolumler.ShowDialog()
    End Sub

    Private Sub btnDepo_Click(sender As Object, e As EventArgs) Handles btnDepo.Click
        Depolar.ShowDialog()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        CariHesap.ShowDialog()
    End Sub
End Class