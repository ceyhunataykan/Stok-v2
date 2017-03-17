Public Class Kategoriler
    Dim db As New StokEntities
    Private Sub Kategoriler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele()
    End Sub
    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        Dim kategoriEkle As New Kategori
        kategoriEkle.Kategori_Kodu = txtKatKod.Text
        kategoriEkle.Kategori_Adi = txtKatAd.Text
        db.Kategori.Add(kategoriEkle)
        db.SaveChanges()
        MsgBox("Kategori Ekleme Başarılı", MsgBoxStyle.Information, "Bilgi")
        temizle()
        listele()
    End Sub
    Private Sub dgKatListe_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgKatListe.CellClick
        lblid.Text = dgKatListe.CurrentRow.Cells("Kategori_ID").Value
        txtKatKod.Text = dgKatListe.CurrentRow.Cells("Kategori_Kodu").Value
        txtKatAd.Text = dgKatListe.CurrentRow.Cells("Kategori_Adi").Value
    End Sub
    Private Sub btnDuzenle_Click(sender As Object, e As EventArgs) Handles btnDuzenle.Click
        If lblid.Text = "" Then
            MsgBox("Düzenleme işlemi yapabilmek için kayıt seçiniz", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If
        Dim id As Integer = Convert.ToInt32(lblid.Text)
        Dim kategoriDuzenle = db.Kategori.Where(Function(k) k.Kategori_ID = id).First()
        kategoriDuzenle.Kategori_Kodu = txtKatKod.Text
        kategoriDuzenle.Kategori_Adi = txtKatAd.Text
        db.SaveChanges()
        MsgBox("Kategori Düzenleme Başarılı", MsgBoxStyle.Information, "Bilgi")
        temizle()
        listele()
    End Sub
    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If lblid.Text = "" Then
            MsgBox("Silme işlemi yapabilmek için kayıt seçiniz", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If
        Dim id As Integer = Convert.ToInt32(lblid.Text)
        Dim kategoriSil = db.Kategori.Where(Function(k) k.Kategori_ID = id).First()
        db.Kategori.Remove(kategoriSil)
        db.SaveChanges()
        MsgBox("Kategori Silme Başarılı", MsgBoxStyle.Information, "Bilgi")
        temizle()
        listele()
    End Sub
    Private Sub btnTemizle_Click(sender As Object, e As EventArgs) Handles btnTemizle.Click
        temizle()
    End Sub
    Private Sub listele()
        dgKatListe.DataSource = db.Kategori.ToList()
        dgKatListe.Columns("Kategori_ID").Visible = False
        dgKatListe.Columns("Kategori_Kodu").HeaderText = "Kategori Kodu"
        dgKatListe.Columns("Kategori_Adi").HeaderText = "Kategori Adi"
        dgKatListe.Columns("Urun").Visible = False
    End Sub
    Private Sub temizle()
        lblid.Text = ""
        txtKatAd.Text = ""
        txtKatKod.Text = ""
    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub
End Class