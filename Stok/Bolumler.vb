Public Class Bolumler
    Dim db As New StokEntities
    Private Sub Bolumler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele()
    End Sub

    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        If txtBolAd.Text = "" Then
            MsgBox("Bilgiler Boş olamaz", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If
        Dim bolumEkle As New Bolum
        bolumEkle.Bolum_Adi = txtBolAd.Text
        db.Bolum.Add(bolumEkle)
        db.SaveChanges()
        MsgBox("Bölüm Ekleme Başarılı", MsgBoxStyle.Information, "Bilgi")
        temizle()
        listele()
    End Sub
    Private Sub dgBolListe_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBolListe.CellClick
        lblid.Text = dgBolListe.CurrentRow.Cells("Bolum_ID").Value
        txtBolAd.Text = dgBolListe.CurrentRow.Cells("Bolum_Adi").Value
    End Sub
    Private Sub btnDuzenle_Click(sender As Object, e As EventArgs) Handles btnDuzenle.Click
        If lblid.Text = "" Then
            MsgBox("Düzenleme işlemi yapabilmek için kayıt seçiniz", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If
        Dim id As Integer = Convert.ToInt32(lblid.Text)
        Dim bolumDuzenle = db.Bolum.Where(Function(b) b.Bolum_ID = id).First()
        bolumDuzenle.Bolum_Adi = txtBolAd.Text
        db.SaveChanges()
        MsgBox("Birim Düzenleme Başarılı", MsgBoxStyle.Information, "Bilgi")
        temizle()
        listele()
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If lblid.Text = "" Then
            MsgBox("Silme işlemi yapabilmek için kayıt seçiniz", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If
        Dim id As Integer = Convert.ToInt32(lblid.Text)
        Dim bolumSil = db.Bolum.Where(Function(b) b.Bolum_ID = id).First()
        db.Bolum.Remove(bolumSil)
        db.SaveChanges()
        MsgBox("Kategori Silme Başarılı", MsgBoxStyle.Information, "Bilgi")
        temizle()
        listele()
    End Sub
    Private Sub listele()
        dgBolListe.DataSource = db.Bolum.ToList()
        dgBolListe.Columns("Bolum_ID").Visible = False
        dgBolListe.Columns("Bolum_Adi").HeaderText = "Birim Adi"
        dgBolListe.Columns("Fis").Visible = False
    End Sub
    Private Sub temizle()
        lblid.Text = ""
        txtBolAd.Text = ""
    End Sub
    Private Sub btnTemizle_Click(sender As Object, e As EventArgs) Handles btnTemizle.Click
        temizle()
    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub
End Class