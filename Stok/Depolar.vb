Imports System.Data.Entity.SqlServer

Public Class Depolar
    Dim db As New StokEntities()
    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        DepoEkle.ShowDialog()
    End Sub
    Private Sub btnDuzenle_Click(sender As Object, e As EventArgs) Handles btnDuzenle.Click
        If lblId.Text = "" Then
            MsgBox("Düzenleme işlemi yapabilmek için kayıt seçiniz", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If
        DepoDuzenle.Show()
        If dgDepoListe.CurrentRow.Cells("Durum").Value = True Then
            DepoDuzenle.ckbAktif.Checked = True
        Else
            DepoDuzenle.ckbAktif.Checked = False
        End If
        DepoDuzenle.lblid.Text = dgDepoListe.CurrentRow.Cells("Depo_ID").Value
        DepoDuzenle.txtDepoKod.Text = dgDepoListe.CurrentRow.Cells("Depo_Kodu").Value
        DepoDuzenle.txtDepoAd.Text = dgDepoListe.CurrentRow.Cells("Depo_Adi").Value
        DepoDuzenle.txtDepoAdres.Text = dgDepoListe.CurrentRow.Cells("Depo_Adres").Value
        DepoDuzenle.cmbIlce.SelectedValue = dgDepoListe.CurrentRow.Cells("ilce_ID").Value
        DepoDuzenle.cmbIl.SelectedValue = dgDepoListe.CurrentRow.Cells("il_ID").Value
        DepoDuzenle.txtAdSoyad.Text = dgDepoListe.CurrentRow.Cells("Depo_Yetkili").Value
        DepoDuzenle.txtTel.Text = dgDepoListe.CurrentRow.Cells("Depo_Tel").Value
        DepoDuzenle.txtFax.Text = dgDepoListe.CurrentRow.Cells("Depo_Fax").Value
        DepoDuzenle.txtMail.Text = dgDepoListe.CurrentRow.Cells("Depo_Mail").Value
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If lblId.Text = "" Then
            MsgBox("Silme işlemi yapabilmek için kayıt seçiniz", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If
        If MsgBox("Kaydı silmek istiyor musunuz?", MsgBoxStyle.YesNo, "Uyarı") = MsgBoxResult.No Then
            Return
        End If
        Dim id As Integer = Convert.ToInt32(dgDepoListe.CurrentRow.Cells("Depo_ID").Value)
        Dim depoSil = db.Depo.Where(Function(d) d.Depo_ID = id).First()
        db.Depo.Remove(depoSil)
        db.SaveChanges()
        lblId.Text = ""
        listele()
    End Sub
    Private Sub Depolar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele()
    End Sub
    Private Sub cmbDurum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDurum.SelectedIndexChanged
        If cmbDurum.SelectedText = "Tümü" Then
            listele()
        ElseIf cmbDurum.SelectedText = "Aktif" Then
            dgDepoListe.DataSource = db.Depo.Where(Function(d) d.Durum = True).ToList()
            dgDuzenle()
        ElseIf cmbDurum.SelectedText = "Pasif" Then
            dgDepoListe.DataSource = db.Depo.Where(Function(d) d.Durum = False).ToList()
            dgDuzenle()
        End If
    End Sub
    Private Sub txtAra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAra.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtAra_TextChanged(sender As Object, e As EventArgs) Handles txtAra.TextChanged
        Try
            Dim kod As Integer = Convert.ToInt32(txtAra.Text)
            Dim depoListe = (From d In db.Depo Where SqlFunctions.StringConvert(d.Depo_Kodu).Contains(kod.ToString()) Select d).ToList()
            dgDepoListe.DataSource = depoListe
            dgDuzenle()
        Catch
            listele()
        End Try
    End Sub
    Private Sub listele()
        dgDepoListe.DataSource = db.Depo.ToList()
        dgDuzenle()
    End Sub
    Private Sub dgDuzenle()
        dgDepoListe.Columns("Depo_ID").Visible = False
        dgDepoListe.Columns("Depo_Kodu").HeaderText = "Depo Kodu"
        dgDepoListe.Columns("Depo_Adi").HeaderText = "Depo Adı"
        dgDepoListe.Columns("Depo_Adres").Visible = False
        dgDepoListe.Columns("ilce").Visible = False
        dgDepoListe.Columns("ilce_ID").Visible = False
        dgDepoListe.Columns("il").Visible = False
        dgDepoListe.Columns("il_ID").Visible = False
        dgDepoListe.Columns("Depo_Yetkili").HeaderText = "Yetkili"
        dgDepoListe.Columns("Depo_Tel").HeaderText = "Telefon"
        dgDepoListe.Columns("Depo_Fax").Visible = False
        dgDepoListe.Columns("Depo_Mail").Visible = False
        dgDepoListe.Columns("Durum").Visible = False
        dgDepoListe.Columns("Fis").Visible = False
        dgDepoListe.Columns("Urun").Visible = False
        dgDepoListe.Columns("Aktarim_Fis").Visible = False
        dgDepoListe.Columns("Aktarim_Fis1").Visible = False
    End Sub

    Private Sub dgDepoListe_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDepoListe.CellClick
        lblId.Text = dgDepoListe.CurrentRow.Cells("Depo_ID").Value
    End Sub

    Private Sub Depolar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class