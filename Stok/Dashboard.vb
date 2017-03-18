Public Class Dashboard
    Private Sub btnStokKart_Click(sender As Object, e As EventArgs) Handles btnStokKart.Click
        StokKart.ShowDialog()
    End Sub

    Private Sub btnStokHareket_Click(sender As Object, e As EventArgs) Handles btnStokHareket.Click
        StokHareket.ShowDialog()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Tanimlar.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        DepoAktar.ShowDialog()
    End Sub
End Class