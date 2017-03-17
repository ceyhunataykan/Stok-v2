Imports System.Data.Entity.SqlServer
Imports System.Data.Linq.SqlClient
Imports System.Drawing.Imaging
Public Class StokKart
    Dim db As StokEntities = New StokEntities()
    Private Sub StokKart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele()
    End Sub
    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        StokKartEkle.ShowDialog()
    End Sub
    Private Sub listele()
        Try
            Dim urunListe = (From u In db.Urun
                             Select
                                 stokID = u.Urun_ID,
                                 stokKodu = u.Stok_Kodu,
                                 stokAdi = u.Stok_Adi,
                                 stokMiktar = u.Stok_Miktar,
                                 stokBirim = u.Birim.Birim_Adi,
                                 stokTseviye = u.Stok_TSeviye).ToList()
            dgListe.DataSource = urunListe
            dgListe.Columns("stokID").Visible = False
            dgListe.Columns("stokKodu").HeaderText = "Stok Kodu"
            dgListe.Columns("stokAdi").HeaderText = "Stok Adı"
            dgListe.Columns("stokMiktar").HeaderText = "Miktar"
            dgListe.Columns("stokBirim").HeaderText = "Birim"
            dgListe.Columns("stokTseviye").Visible = False
        Catch
        End Try
        renklendir()
    End Sub
    Private Sub renklendir()
        For i = 0 To dgListe.Rows.Count - 1 Step 1
            Application.DoEvents()
            Dim renk As DataGridViewCellStyle = New DataGridViewCellStyle()
            If dgListe.Rows(i).Cells("stokMiktar").Value > dgListe.Rows(i).Cells("stokTseviye").Value Then
                renk.BackColor = Color.YellowGreen
                renk.ForeColor = Color.White
            ElseIf dgListe.Rows(i).Cells("stokMiktar").Value < dgListe.Rows(i).Cells("stokTseviye").Value Then
                renk.BackColor = Color.Orange
                renk.ForeColor = Color.White
            ElseIf dgListe.Rows(i).Cells("stokMiktar").Value = 0 Then
                renk.BackColor = Color.DarkRed
                renk.ForeColor = Color.White
            End If
            dgListe.Rows(i).DefaultCellStyle = renk
        Next
    End Sub
    Private Sub cmbDurum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDurum.SelectedIndexChanged
        If cmbDurum.SelectedItem = "Tümü" Then
            listele()
            renklendir()
        ElseIf cmbDurum.SelectedItem = "Aktif" Then
            Dim urunListe = (From u In db.Urun
                             Where u.Durum = True
                             Select
                                 stokID = u.Urun_ID,
                                 stokKodu = u.Stok_Kodu,
                                 stokAdi = u.Stok_Adi,
                                 stokMiktar = u.Stok_Miktar,
                                 stokBirim = u.Birim.Birim_Adi,
                                 stokTseviye = u.Stok_TSeviye).ToList()
            dgListe.DataSource = urunListe
            dgListe.Columns("stokID").Visible = False
            dgListe.Columns("stokKodu").HeaderText = "Stok Kodu"
            dgListe.Columns("stokAdi").HeaderText = "Stok Adı"
            dgListe.Columns("stokMiktar").HeaderText = "Miktar"
            dgListe.Columns("stokBirim").HeaderText = "Birim"
            dgListe.Columns("stokTseviye").Visible = False
            renklendir()
        ElseIf cmbDurum.SelectedItem = "Pasif" Then
            Dim urunListe = (From u In db.Urun
                             Where u.Durum = False
                             Select
                                 stokID = u.Urun_ID,
                                 stokKodu = u.Stok_Kodu,
                                 stokAdi = u.Stok_Adi,
                                 stokMiktar = u.Stok_Miktar,
                                 stokBirim = u.Birim.Birim_Adi,
                                 stokTseviye = u.Stok_TSeviye).ToList()
            dgListe.DataSource = urunListe
            dgListe.Columns("stokID").Visible = False
            dgListe.Columns("stokKodu").HeaderText = "Stok Kodu"
            dgListe.Columns("stokAdi").HeaderText = "Stok Adı"
            dgListe.Columns("stokMiktar").HeaderText = "Miktar"
            dgListe.Columns("stokBirim").HeaderText = "Birim"
            dgListe.Columns("stokTseviye").Visible = False
            renklendir()
        End If
    End Sub
    Private Sub txtAra_TextChanged(sender As Object, e As EventArgs) Handles txtAra.TextChanged
        Try
            Dim kod As Integer = Convert.ToInt32(txtAra.Text)

            Dim urunListe = (From u In db.Urun
                             Where SqlFunctions.StringConvert(u.Stok_Kodu).Contains(kod.ToString())
                             Select
                                 stokID = u.Urun_ID,
                                 stokKodu = u.Stok_Kodu,
                                 stokAdi = u.Stok_Adi,
                                 stokMiktar = u.Stok_Miktar,
                                 stokBirim = u.Birim.Birim_Adi,
                                 stokTseviye = u.Stok_TSeviye).ToList()
            dgListe.DataSource = urunListe
            dgListe.Columns("stokID").Visible = False
            dgListe.Columns("stokKodu").HeaderText = "Stok Kodu"
            dgListe.Columns("stokAdi").HeaderText = "Stok Adı"
            dgListe.Columns("stokMiktar").HeaderText = "Miktar"
            dgListe.Columns("stokBirim").HeaderText = "Birim"
            dgListe.Columns("stokTseviye").Visible = False
            renklendir()
        Catch
            listele()
            renklendir()
        End Try
    End Sub
    Private Sub txtAra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAra.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub StokKart_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
    Private Sub btnSec_Click(sender As Object, e As EventArgs) Handles btnSec.Click
        Dim uID As Integer = Convert.ToInt32(dgListe.CurrentRow.Cells(0).Value)
        Dim urunSec = (From u In db.Urun
                       Join b In db.Birim On u.Birim_ID Equals b.Birim_ID
                       Where u.Urun_ID = uID
                       Select
                                 stokID = u.Urun_ID,
                                 stokKodu = u.Stok_Kodu,
                                 stokAdi = u.Stok_Adi,
                                 stokMiktar = u.Stok_Miktar,
                                 stokBirim_ID = b.Birim_ID,
                                 stokBirimAdi = b.Birim_Adi,
                                 stokBfiyat = u.Stok_SFiyati,
                                 stokTseviye = u.Stok_TSeviye).FirstOrDefault()
        If giris = True Then
            Me.Hide()
            StokGiris.Show()
            StokGiris.lblid.Text = urunSec.stokID
            StokGiris.txtStokKodu.Text = urunSec.stokKodu
            StokGiris.txtStokAdi.Text = urunSec.stokAdi
            StokGiris.txtBirim.Text = urunSec.stokBirimAdi
            StokGiris.txtBirimFiyat.Text = urunSec.stokBfiyat
            giris = False
        ElseIf girisDuzenle = True Then
            Me.Hide()
            StokGirisDuzenle.Show()
            StokGirisDuzenle.lblid.Text = urunSec.stokID
            StokGirisDuzenle.txtStokKodu.Text = urunSec.stokKodu
            StokGirisDuzenle.txtStokAdi.Text = urunSec.stokAdi
            StokGirisDuzenle.txtBirim.Text = urunSec.stokBirimAdi
            StokGirisDuzenle.txtBirimFiyat.Text = urunSec.stokBfiyat
            girisDuzenle = False
        ElseIf cikis = True Then
            Me.Hide()
            StokCikis.Show()
            StokCikis.lblid.Text = urunSec.stokID
            StokCikis.txtStokKodu.Text = urunSec.stokKodu
            StokCikis.txtStokAdi.Text = urunSec.stokAdi
            StokCikis.txtBirim.Text = urunSec.stokBirimAdi
            StokCikis.txtBirimFiyat.Text = urunSec.stokBfiyat
            cikis = False
        ElseIf cikisDuzenle = True Then
            Me.Hide()
            StokCikisDuzenle.Show()
            StokCikisDuzenle.lblid.Text = urunSec.stokID
            StokCikisDuzenle.txtStokKodu.Text = urunSec.stokKodu
            StokCikisDuzenle.txtStokAdi.Text = urunSec.stokAdi
            StokCikisDuzenle.txtBirim.Text = urunSec.stokBirimAdi
            StokCikisDuzenle.txtBirimFiyat.Text = urunSec.stokBfiyat
            cikisDuzenle = False
        End If
    End Sub
    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If MsgBox("Ürünü Silmek İstiyor musunuz?", MsgBoxStyle.YesNo, "Uyarı") = MsgBoxResult.No Then
            Return
        End If
        Try
            If dgListe.Rows.Count > 0 Then
                Dim uID As Integer = Convert.ToInt32(dgListe.CurrentRow.Cells("stokID").Value)
                Dim sil = db.Urun.Where(Function(u) u.Urun_ID = uID).FirstOrDefault()
                db.Urun.Remove(sil)
                db.SaveChanges()
            End If
        Catch
            MsgBox("Ürünle ilişkili Fiş Mevcut. Ürünü kaldırmak için önce stok hareketlerinizi düzenleyiniz.", MsgBoxStyle.Exclamation, "Uyarı")
        End Try
        listele()
    End Sub
    Private Sub btnYenile_Click(sender As Object, e As EventArgs) Handles btnYenile.Click
        listele()
    End Sub

    Private Sub dgListe_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgListe.CellClick
        If gizleSec = True Then
            btnSec.Enabled = True
        Else
            btnSec.Enabled = False
        End If
    End Sub

    Private Sub btnDuzenle_Click(sender As Object, e As EventArgs) Handles btnDuzenle.Click
        Dim id As Integer = Convert.ToInt32(dgListe.CurrentRow.Cells("stokID").Value)
        Dim guncelle = db.Urun.Where(Function(u) u.Urun_ID = id).FirstOrDefault()
        StokKartDuzenle.Show()
        If guncelle.Durum = True Then
            StokKartDuzenle.ckbAktif.Checked = True
        Else
            StokKartDuzenle.ckbAktif.Checked = False
        End If
        StokKartDuzenle.lblUrunID.Text = guncelle.Urun_ID
        StokKartDuzenle.DateTimePicker1.Value = guncelle.Stok_KayitTarihi
        StokKartDuzenle.txtSk.Text = guncelle.Stok_Kodu
        StokKartDuzenle.txtBarkod.Text = guncelle.Stok_Barkod
        StokKartDuzenle.txtStokAdi.Text = guncelle.Stok_Adi
        StokKartDuzenle.cmbKategori.SelectedValue = guncelle.Kategori_ID
        StokKartDuzenle.nudMiktar.Value = guncelle.Stok_Miktar
        StokKartDuzenle.nudTSeviye.Value = guncelle.Stok_TSeviye
        StokKartDuzenle.cmbBirim.SelectedValue = guncelle.Birim_ID
        StokKartDuzenle.cmbDepo.SelectedValue = guncelle.Depo_ID
        StokKartDuzenle.txtAlisFiyati.Text = guncelle.Stok_AFiyati
        StokKartDuzenle.txtSatisFiyati.Text = guncelle.Stok_SFiyati
        StokKartDuzenle.txtKdv.Text = guncelle.Stok_Kdv
        StokKartDuzenle.PictureBox1.Image = Nothing

    End Sub
End Class
