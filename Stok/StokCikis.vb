Public Class StokCikis
    Dim db As StokEntities = New StokEntities()

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Close()
    End Sub

    Private Sub btnStokKart_Click(sender As Object, e As EventArgs) Handles btnStokKart.Click
        gizleSec = True
        cikis = True
        StokKart.ShowDialog()
    End Sub

    Private Sub StokCikis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class