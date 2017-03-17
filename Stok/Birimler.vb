Public Class Birimler
    Dim db As New StokEntities
    Private Sub Birimler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele()
    End Sub

    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        If txtBirAd.Text = "" Then
            MsgBox("Bilgiler Boş olamaz", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If
        Dim birimEkle As New Birim
        birimEkle.Birim_Adi = txtBirAd.Text
        db.Birim.Add(birimEkle)
        db.SaveChanges()
        MsgBox("Birim Ekleme Başarılı", MsgBoxStyle.Information, "Bilgi")
        temizle()
        listele()
    End Sub
    Private Sub dgBirListe_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBirListe.CellClick
        lblid.Text = dgBirListe.CurrentRow.Cells("Birim_ID").Value
        txtBirAd.Text = dgBirListe.CurrentRow.Cells("Birim_Adi").Value
    End Sub
    Private Sub btnDuzenle_Click(sender As Object, e As EventArgs) Handles btnDuzenle.Click
        If lblid.Text = "" Then
            MsgBox("Düzenleme işlemi yapabilmek için kayıt seçiniz", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If
        If txtBirAd.Text = "" Then
            MsgBox("Bilgiler Boş olamaz", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If
        Dim id As Integer = Convert.ToInt32(lblid.Text)
        Dim birimDuzenle = db.Birim.Where(Function(b) b.Birim_ID = id).First()
        birimDuzenle.Birim_Adi = txtBirAd.Text
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
        Dim birimSil = db.Birim.Where(Function(b) b.Birim_ID = id).First()
        db.Birim.Remove(birimSil)
        db.SaveChanges()
        MsgBox("Kategori Silme Başarılı", MsgBoxStyle.Information, "Bilgi")
        temizle()
        listele()
    End Sub

    Private Sub btnTemizle_Click(sender As Object, e As EventArgs) Handles btnTemizle.Click
        temizle()
    End Sub
    Private Sub listele()
        dgBirListe.DataSource = db.Birim.ToList()
        dgBirListe.Columns("Birim_ID").Visible = False
        dgBirListe.Columns("Birim_Adi").HeaderText = "Birim Adi"
        dgBirListe.Columns("Urun").Visible = False
    End Sub
    Private Sub temizle()
        lblid.Text = ""
        txtBirAd.Text = ""
    End Sub
    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub
End Class