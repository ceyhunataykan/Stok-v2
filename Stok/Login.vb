Public Class Login
    Dim db As New StokEntities
    Dim i As Integer
    Private Sub btnGirisYap_Click(sender As Object, e As EventArgs) Handles btnGirisYap.Click
        If txtKullanciAdi.Text = "" Or txtParola.Text = "" Then
            MsgBox("Lütfen Bilgileri Doldurun ve Tekrar Deneyin.", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If

        Dim k_Adi As String = txtKullanciAdi.Text.Trim()
        Dim k_Parola As String = txtParola.Text.Trim()
        Try
            Dim login = db.Kullanici.Where(Function(k) k.KullaniciAdi = k_Adi And k.Parola = k_Parola).FirstOrDefault()
            If login.KullaniciAdi = k_Adi And login.Parola = k_Parola Then
                If login.Rol_ID = 1 Then
                    Admin.Show()
                ElseIf login.Rol_ID = 3 Then
                    Dashboard.Show()
                End If
            Else
                MsgBox("Hatalı Giriş. Tekrar Deneyiniz", MsgBoxStyle.Critical, "Hata")
                i = i + 1
                If (i > 3) Then
                    MsgBox("Lütfen Program Yöneticiniz ile iletişime Geçiniz.", MsgBoxStyle.Critical, "Hata")
                    Application.Exit()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class