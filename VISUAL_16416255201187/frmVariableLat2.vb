Public Class frmVariableLat2

    Private Sub bt_keliling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_keliling.Click
        Dim jarijari, keliling, luas, hasil, phi As Double
        phi = 22 / 7


        If tb_jarijari.TextLength > 0 Then
            jarijari = tb_jarijari.Text

            luas = phi * (jarijari * jarijari)
            keliling = 2 * phi * jarijari

            lbl_keliling.Text = keliling
            lbl_luas.Text = 0
        Else
            MessageBox.Show("Jari-jari tidak boleh kosong !")
        End If


        
    End Sub

    Private Sub bt_luas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_luas.Click
        Dim jarijari, keliling, luas, hasil, phi As Double
        phi = 22 / 7

        If tb_jarijari.TextLength > 0 Then
            jarijari = tb_jarijari.Text

            luas = phi * (jarijari * jarijari)
            keliling = 2 * phi * jarijari

            lbl_keliling.Text = 0
            lbl_luas.Text = luas
        Else
            MessageBox.Show("Jari-jari tidak boleh kosong !")
        End If
        
    End Sub

    Private Sub bt_all_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_all.Click
        Dim jarijari, keliling, luas, hasil, phi As Double
        phi = 22 / 7

        If tb_jarijari.TextLength > 0 Then
            jarijari = tb_jarijari.Text

            luas = phi * (jarijari * jarijari)
            keliling = 2 * phi * jarijari

            lbl_keliling.Text = keliling
            lbl_luas.Text = luas
        Else
            MessageBox.Show("Jari-jari tidak boleh kosong !")
        End If
        
    End Sub

    Private Sub bt_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_reset.Click
        lbl_keliling.Text = 0
        lbl_luas.Text = 0
        tb_jarijari.Text = ""
    End Sub
End Class