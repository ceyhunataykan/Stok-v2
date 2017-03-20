Imports System.Data.Entity.SqlServer

Public Class CariHesap
    Dim db As New StokEntities()
    Private Sub CariHesap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele()
    End Sub
    Private Sub CariHesap_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub dgFisListe_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListe.CellClick
        If gizleSecFirma = True Then
            btnSec.Enabled = True
        Else
            btnSec.Enabled = False
        End If
        lblid.Text = dgListe.CurrentRow.Cells("Firma_ID").Value
    End Sub
    Private Sub listele()
        dgListe.DataSource = (From f In db.Cari_Detay Select f.Detay_ID, f.Firma_ID, firmaKodu = f.Cari.Firma_Kodu, firmaAdi = f.Cari.Firma_Adi, f.Bakiye).ToList()
        dgDuzenle()
    End Sub

    Private Sub dgDuzenle()
        dgListe.Columns("Detay_ID").Visible = False
        dgListe.Columns("Firma_ID").Visible = False
        dgListe.Columns("firmaKodu").HeaderText = "Firma Kodu"
        dgListe.Columns("firmaAdi").HeaderText = "Firma Adı"
        dgListe.Columns("Bakiye").HeaderText = "Bakiye"
    End Sub

    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        CariHesapEkle.ShowDialog()
    End Sub

    Private Sub btnDetay_Click(sender As Object, e As EventArgs) Handles btnDetay.Click

    End Sub

    Private Sub btnDuzenle_Click(sender As Object, e As EventArgs) Handles btnDuzenle.Click
        If lblid.Text = "" Then
            MsgBox("Düzenleme işlemi yapabilmek için kayıt seçiniz", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If
        CariHesapDuzenle.Show()
        CariHesapDuzenle.lblid.Text = Convert.ToString(dgListe.CurrentRow.Cells("Firma_ID").Value)
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If lblid.Text = "" Then
            MsgBox("Silme işlemi yapabilmek için kayıt seçiniz", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If
        Dim id As Integer = Convert.ToInt32(lblid.Text)
        Dim silHesapDetay = db.Cari_Detay.Where(Function(c) c.Firma_ID = id).FirstOrDefault()
        If silHesapDetay.Bakiye > 0 Then
            MsgBox("Firmanın" & " " & silHesapDetay.Bakiye.ToString() & " TL " & " bakiyesi bulunmaktadır. Firmayı silebilmek için bakiye düzenlemesi yapılmalıdır.", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If
        If MsgBox("Firmayı Silmek İstiyor musunuz?", MsgBoxStyle.YesNo, "Uyarı") = MsgBoxResult.No Then
            Return
        End If
        db.Cari_Detay.Remove(silHesapDetay)
        db.SaveChanges()
        Dim silHesap = db.Cari.Where(Function(c) c.Firma_ID = id).FirstOrDefault()
        db.Cari.Remove(silHesap)
        db.SaveChanges()
        MsgBox("Silme İşlemi Başarılı", MsgBoxStyle.Information, "Bilgi")
        listele()
    End Sub

    Private Sub btnSec_Click(sender As Object, e As EventArgs) Handles btnSec.Click

    End Sub

    Private Sub cmbDepo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDurum.SelectedIndexChanged
        If cmbDurum.SelectedItem = "Tümü" Then
            listele()
        ElseIf cmbDurum.SelectedItem = "Aktif Hesaplar" Then
            dgListe.DataSource = (From f In db.Cari_Detay Where f.Cari.Durum = True Select f.Detay_ID, f.Firma_ID, firmaKodu = f.Cari.Firma_Kodu, firmaAdi = f.Cari.Firma_Adi, f.Bakiye).ToList()
            dgDuzenle()
        ElseIf cmbDurum.SelectedItem = "Pasif Hesaplar" Then
            dgListe.DataSource = (From f In db.Cari_Detay Where f.Cari.Durum = False Select f.Detay_ID, f.Firma_ID, firmaKodu = f.Cari.Firma_Kodu, firmaAdi = f.Cari.Firma_Adi, f.Bakiye).ToList()
            dgDuzenle()
        End If
    End Sub

    Private Sub txtAra_TextChanged(sender As Object, e As EventArgs) Handles txtAra.TextChanged
        Try
            Dim kod As Integer = Convert.ToInt32(txtAra.Text)
            dgListe.DataSource = (From f In db.Cari_Detay
                                  Where f.Cari.Firma_Adi.Contains(kod.ToString())
                                  Select f.Detay_ID, f.Firma_ID, firmaKodu = f.Cari.Firma_Kodu, firmaAdi = f.Cari.Firma_Adi, f.Bakiye).ToList()
            dgDuzenle()
        Catch
            listele()
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            dgListe.DataSource = (From f In db.Cari_Detay
                                  Where f.Bakiye > 0
                                  Select f.Detay_ID, f.Firma_ID, firmaKodu = f.Cari.Firma_Kodu, firmaAdi = f.Cari.Firma_Adi, f.Bakiye).ToList()
            dgDuzenle()
        ElseIf CheckBox1.Checked = False Then
            listele()
        End If
    End Sub
End Class