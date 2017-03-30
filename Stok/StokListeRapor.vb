Public Class StokListeRapor
    Dim db As New StokEntities()
    Private Sub StokListeRapor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnTum_Click(sender As Object, e As EventArgs) Handles btnTum.Click
        stokListe_ResultBindingSource.DataSource = db.stokListe(NumericUpDown1.Value).ToList()
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub StokListeRapor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        stokListe_ResultBindingSource.Clear()
        NumericUpDown1.Value = 0
    End Sub
End Class