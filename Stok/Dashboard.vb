Public Class Dashboard
    Private Sub btnStokKart_Click(sender As Object, e As EventArgs) Handles btnStokKart.Click
        StokKart.ShowDialog()
    End Sub

    Private Sub btnStokHareket_Click(sender As Object, e As EventArgs) Handles btnStokHareket.Click
        StokHareket.ShowDialog()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTarih.Text = DateTime.Now.Date()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Tanimlar.ShowDialog()

    End Sub
End Class