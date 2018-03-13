<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVariabel1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bt_hitung = New System.Windows.Forms.Button
        Me.lbl_tambah = New System.Windows.Forms.Label
        Me.lbl_kali = New System.Windows.Forms.Label
        Me.lbl_kurang = New System.Windows.Forms.Label
        Me.lbl_bagi = New System.Windows.Forms.Label
        Me.bt_close = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'bt_hitung
        '
        Me.bt_hitung.Location = New System.Drawing.Point(13, 13)
        Me.bt_hitung.Name = "bt_hitung"
        Me.bt_hitung.Size = New System.Drawing.Size(259, 23)
        Me.bt_hitung.TabIndex = 0
        Me.bt_hitung.Text = "HITUNG"
        Me.bt_hitung.UseVisualStyleBackColor = True
        '
        'lbl_tambah
        '
        Me.lbl_tambah.AutoSize = True
        Me.lbl_tambah.Location = New System.Drawing.Point(13, 43)
        Me.lbl_tambah.Name = "lbl_tambah"
        Me.lbl_tambah.Size = New System.Drawing.Size(46, 13)
        Me.lbl_tambah.TabIndex = 1
        Me.lbl_tambah.Text = "Tambah"
        '
        'lbl_kali
        '
        Me.lbl_kali.AutoSize = True
        Me.lbl_kali.Location = New System.Drawing.Point(246, 43)
        Me.lbl_kali.Name = "lbl_kali"
        Me.lbl_kali.Size = New System.Drawing.Size(24, 13)
        Me.lbl_kali.TabIndex = 2
        Me.lbl_kali.Text = "Kali"
        '
        'lbl_kurang
        '
        Me.lbl_kurang.AutoSize = True
        Me.lbl_kurang.Location = New System.Drawing.Point(13, 60)
        Me.lbl_kurang.Name = "lbl_kurang"
        Me.lbl_kurang.Size = New System.Drawing.Size(41, 13)
        Me.lbl_kurang.TabIndex = 3
        Me.lbl_kurang.Text = "Kurang"
        '
        'lbl_bagi
        '
        Me.lbl_bagi.AutoSize = True
        Me.lbl_bagi.Location = New System.Drawing.Point(242, 60)
        Me.lbl_bagi.Name = "lbl_bagi"
        Me.lbl_bagi.Size = New System.Drawing.Size(28, 13)
        Me.lbl_bagi.TabIndex = 4
        Me.lbl_bagi.Text = "Bagi"
        '
        'bt_close
        '
        Me.bt_close.Location = New System.Drawing.Point(16, 77)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.Size = New System.Drawing.Size(254, 23)
        Me.bt_close.TabIndex = 5
        Me.bt_close.Text = "KELUAR"
        Me.bt_close.UseVisualStyleBackColor = True
        '
        'frmVariabel1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.bt_close)
        Me.Controls.Add(Me.lbl_bagi)
        Me.Controls.Add(Me.lbl_kurang)
        Me.Controls.Add(Me.lbl_kali)
        Me.Controls.Add(Me.lbl_tambah)
        Me.Controls.Add(Me.bt_hitung)
        Me.Name = "frmVariabel1"
        Me.Text = "frmVariabel1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_hitung As System.Windows.Forms.Button
    Friend WithEvents lbl_tambah As System.Windows.Forms.Label
    Friend WithEvents lbl_kali As System.Windows.Forms.Label
    Friend WithEvents lbl_kurang As System.Windows.Forms.Label
    Friend WithEvents lbl_bagi As System.Windows.Forms.Label
    Friend WithEvents bt_close As System.Windows.Forms.Button
End Class
