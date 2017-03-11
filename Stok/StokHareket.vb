Public Class StokHareket
    Dim db As StokEntities = New StokEntities()

    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        StokGiris.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        StokCikis.ShowDialog()
    End Sub

    Private Sub StokHareket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim depoListe As IList(Of Depo) = db.Depo.ToList()
        cmbDepo.DataSource = depoListe
        cmbDepo.DisplayMember = "Depo_Adi"
        cmbDepo.ValueMember = "Depo_ID"

        Dim bolumListe As IList(Of Bolum) = db.Bolum.ToList()
        cmbBolum.DataSource = bolumListe
        cmbBolum.DisplayMember = "Bolum_Adi"
        cmbBolum.ValueMember = "Bolum_ID"

        listele()
    End Sub

    Private Sub listele()
        Dim fisListe = (From f In db.Fis
                        Select
                            fisID = f.Fis_ID,
                            fisNo = f.Fis_No,
                            fisTur = f.Fis_Türü,
                            fisTarih = f.Fis_Tarih,
                            fisDepo = f.Depo.Depo_Adi,
                            fisBolum = f.Bolum.Bolum_Adi,
                            fisUrun = f.Stok_Adi).ToList()
        dgFisListe.DataSource = fisListe
        dgFisListe.Columns("fisID").Visible = False
        dgFisListe.Columns("fisNo").HeaderText = "Fiş No"
        dgFisListe.Columns("fisTur").HeaderText = "Fiş Türü"
        dgFisListe.Columns("fisTarih").HeaderText = "Tarih"
        dgFisListe.Columns("fisDepo").HeaderText = "Depo"
        dgFisListe.Columns("fisBolum").HeaderText = "Bölüm"
        dgFisListe.Columns("fisUrun").HeaderText = "Ürünler"
    End Sub
End Class