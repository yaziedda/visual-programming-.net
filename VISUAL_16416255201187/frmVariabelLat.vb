Public Class frmVariabelLat

    Private Sub AndikaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmVariabel1.Show()

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_hasil.Click

    End Sub

    Private Sub bt_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_tambah.Click
        Dim bil1, bil2, hasil As Double
        bil1 = tb_bil1.Text
        bil2 = tb_bil2.Text

        hasil = bil1 + bil2

        lbl_hasil.Text = hasil
    End Sub

    Private Sub bt_ambil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ambil.Click
        Dim bil1, bil2, hasil As Double
        bil1 = tb_bil1.Text
        bil2 = tb_bil2.Text

        hasil = bil1 - bil2

        lbl_hasil.Text = hasil
    End Sub

    Private Sub bt_kali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_kali.Click
        Dim bil1, bil2, hasil As Double
        bil1 = tb_bil1.Text
        bil2 = tb_bil2.Text

        hasil = bil1 * bil2

        lbl_hasil.Text = hasil
    End Sub

    Private Sub bt_bagi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_bagi.Click
        Dim bil1, bil2, hasil As Double
        bil1 = tb_bil1.Text
        bil2 = tb_bil2.Text

        hasil = bil1 / bil2

        lbl_hasil.Text = hasil
    End Sub

    Private Sub bt_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_keluar.Click
        Me.Close()
    End Sub
End Class