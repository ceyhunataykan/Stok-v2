Public Class StokGiris

    Dim db As StokEntities = New StokEntities()

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Close()
    End Sub

    Private Sub btnStokKart_Click(sender As Object, e As EventArgs) Handles btnStokKart.Click
        StokKart.Show()
        gizleSec = True
        giris = True
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click

    End Sub

    Private Sub btnListeEkle_Click(sender As Object, e As EventArgs) Handles btnListeEkle.Click
        dgFisListe.Rows.Add()
    End Sub

    Private Sub StokGiris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim brmListe As IList(Of Birim) = db.Birim.ToList()
        cmbBirim.DataSource = brmListe
        cmbBirim.DisplayMember = "Birim_Adi"
        cmbBirim.ValueMember = "Birim_ID"

        Dim depoListe As IList(Of Depo) = db.Depo.ToList()
        cmbDepo.DataSource = depoListe
        cmbDepo.DisplayMember = "Depo_Adi"
        cmbDepo.ValueMember = "Depo_ID"

        Dim bolumListe As IList(Of Bolum) = db.Bolum.ToList()
        cmbBolum.DataSource = bolumListe
        cmbBolum.DisplayMember = "Bolum_Adi"
        cmbBolum.ValueMember = "Bolum_ID"
    End Sub
End Class