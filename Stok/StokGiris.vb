Public Class StokGiris

    Dim db As StokEntities = New StokEntities()

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Close()
    End Sub

    Private Sub btnStokKart_Click(sender As Object, e As EventArgs) Handles btnStokKart.Click
        gizleSec = True
        giris = True
        StokKart.ShowDialog()
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        gizleSec = False
    End Sub

    Private Sub btnListeEkle_Click(sender As Object, e As EventArgs) Handles btnListeEkle.Click
        dgFisListe.Rows.Add()
    End Sub

    Private Sub StokGiris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class