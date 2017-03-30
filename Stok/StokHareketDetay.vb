Public Class StokHareketDetay
    Dim db As New StokEntities()
    Private Sub StokHareketDetay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnTum_Click(sender As Object, e As EventArgs) Handles btnTum.Click
        StokHareketRapor_ResultBindingSource.DataSource = db.StokHareketRapor(dtpBasTarih.Value, dtpBitTarih.Value).ToList()
        ReportViewer1.RefreshReport()
    End Sub
End Class