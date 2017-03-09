Imports System.Data.Entity.SqlServer
Imports System.Data.Linq.SqlClient

Public Class StokKart
    Dim db As StokEntities = New StokEntities()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele()

    End Sub

    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        StokKartEkle.ShowDialog()
    End Sub

    Private Sub listele()
        Try
            Dim urunListe = (From u In db.Urun
                             Join b In db.Birim On u.Birim_ID Equals b.Birim_ID
                             Select
                                 stokID = u.Urun_ID,
                                 stokKodu = u.Stok_Kodu,
                                 stokAdi = u.Stok_Adi,
                                 stokMiktar = u.Stok_Miktar,
                                 stokBirim = b.Birim_Adi,
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
        Try
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
        Catch

        End Try

    End Sub

    Private Sub cmbDurum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDurum.SelectedIndexChanged
        If cmbDurum.SelectedItem = "Tümü" Then
            listele()
            renklendir()
        ElseIf cmbDurum.SelectedItem = "Aktif" Then
            Dim urunListe = (From u In db.Urun
                             Join b In db.Birim On u.Birim_ID Equals b.Birim_ID
                             Where u.Durum = True
                             Select
                                 stokID = u.Urun_ID,
                                 stokKodu = u.Stok_Kodu,
                                 stokAdi = u.Stok_Adi,
                                 stokMiktar = u.Stok_Miktar,
                                 stokBirim = b.Birim_Adi,
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
                             Join b In db.Birim On u.Birim_ID Equals b.Birim_ID
                             Where u.Durum = False
                             Select
                                 stokID = u.Urun_ID,
                                 stokKodu = u.Stok_Kodu,
                                 stokAdi = u.Stok_Adi,
                                 stokMiktar = u.Stok_Miktar,
                                 stokBirim = b.Birim_Adi,
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
                             Join b In db.Birim On u.Birim_ID Equals b.Birim_ID
                             Where SqlFunctions.StringConvert(u.Stok_Kodu).Contains(kod.ToString())
                             Select
                                 stokID = u.Urun_ID,
                                 stokKodu = u.Stok_Kodu,
                                 stokAdi = u.Stok_Adi,
                                 stokMiktar = u.Stok_Miktar,
                                 stokBirim = b.Birim_Adi,
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

    Private Sub StokKart_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed

    End Sub

    Private Sub StokKart_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub dgListe_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListe.CellClick
        If gizleSec = True Then
            btnSec.Enabled = True
        Else
            btnSec.Enabled = False
        End If
    End Sub
    Private Sub btnSec_Click(sender As Object, e As EventArgs) Handles btnSec.Click
        If giris = True Then

            Dim sg As StokGiris = New StokGiris()
            sg.Show()
            Dim uID As Integer = Convert.ToInt32(dgListe.CurrentRow.Cells(0).Value)
            Dim urunSec = (From u In db.Urun
                           Join b In db.Birim On u.Birim_ID Equals b.Birim_ID
                           Where u.Urun_ID = uID
                           Select
                                 stokID = u.Urun_ID,
                                 stokKodu = u.Stok_Kodu,
                                 stokAdi = u.Stok_Adi,
                                 stokMiktar = u.Stok_Miktar,
                                 stokBirim = b.Birim_Adi,
                                 stokTseviye = u.Stok_TSeviye).FirstOrDefault()
            sg.txtStokKodu.Text = urunSec.stokKodu
        ElseIf cikis = True Then

            Dim sc As StokGiris = New StokGiris()
            uID = Convert.ToString(dgListe.CurrentRow.Cells(0).Value)
            sc.lblid.Text = uID
            Me.Close()
        End If

    End Sub
End Class
