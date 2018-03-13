Public Class frmVariabel2

    Private Sub bt_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_keluar.Click
        Me.Close()

    End Sub

    Private Sub bt_hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_hitung.Click
        Dim panjang, lebar, hasil As Double
        panjang = tb_panjang.Text
        lebar = tb_lebar.Text

        hasil = panjang * lebar

        tb_hasil.Text = hasil
    End Sub
End Class