Public Class Faturalar
    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        SatisFaturasi.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GirisFaturasi.ShowDialog()
    End Sub
End Class