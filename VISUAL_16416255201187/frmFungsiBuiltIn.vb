Public Class frmFungsiBuiltIn

    Private Sub frmFungsiBuiltIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoToolStripMenuItem.Click
        frmVariabel2.MdiParent = Me
        frmVariabel2.Show()
    End Sub

    Private Sub YesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YesToolStripMenuItem.Click

    End Sub

    Private Sub OkeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkeToolStripMenuItem.Click
        frmVariabel1.MdiParent = Me
        frmVariabel1.Show()
    End Sub

    Private Sub VariableLatihanKalkulatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VariableLatihanKalkulatorToolStripMenuItem.Click
        frmVariabelLat.MdiParent = Me
        frmVariabelLat.Show()
    End Sub

    Private Sub VariableLatihan2LingkaranToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VariableLatihan2LingkaranToolStripMenuItem.Click
        frmVariableLat2.MdiParent = Me
        frmVariableLat2.Show()
    End Sub
End Class