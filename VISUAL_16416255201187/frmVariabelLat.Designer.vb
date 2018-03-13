<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVariabelLat
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tb_bil1 = New System.Windows.Forms.TextBox
        Me.tb_bil2 = New System.Windows.Forms.TextBox
        Me.lbl_hasil = New System.Windows.Forms.Label
        Me.bt_tambah = New System.Windows.Forms.Button
        Me.bt_ambil = New System.Windows.Forms.Button
        Me.bt_kali = New System.Windows.Forms.Button
        Me.bt_bagi = New System.Windows.Forms.Button
        Me.bt_keluar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bilangan 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bilangan 2"
        '
        'tb_bil1
        '
        Me.tb_bil1.Location = New System.Drawing.Point(77, 13)
        Me.tb_bil1.Name = "tb_bil1"
        Me.tb_bil1.Size = New System.Drawing.Size(103, 20)
        Me.tb_bil1.TabIndex = 2
        '
        'tb_bil2
        '
        Me.tb_bil2.Location = New System.Drawing.Point(77, 40)
        Me.tb_bil2.Name = "tb_bil2"
        Me.tb_bil2.Size = New System.Drawing.Size(103, 20)
        Me.tb_bil2.TabIndex = 3
        '
        'lbl_hasil
        '
        Me.lbl_hasil.AutoSize = True
        Me.lbl_hasil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_hasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hasil.Location = New System.Drawing.Point(197, 13)
        Me.lbl_hasil.Name = "lbl_hasil"
        Me.lbl_hasil.Padding = New System.Windows.Forms.Padding(16)
        Me.lbl_hasil.Size = New System.Drawing.Size(150, 73)
        Me.lbl_hasil.TabIndex = 4
        Me.lbl_hasil.Text = "HASIL"
        '
        'bt_tambah
        '
        Me.bt_tambah.Location = New System.Drawing.Point(15, 66)
        Me.bt_tambah.Name = "bt_tambah"
        Me.bt_tambah.Size = New System.Drawing.Size(23, 23)
        Me.bt_tambah.TabIndex = 5
        Me.bt_tambah.Text = "+"
        Me.bt_tambah.UseVisualStyleBackColor = True
        '
        'bt_ambil
        '
        Me.bt_ambil.Location = New System.Drawing.Point(44, 66)
        Me.bt_ambil.Name = "bt_ambil"
        Me.bt_ambil.Size = New System.Drawing.Size(23, 23)
        Me.bt_ambil.TabIndex = 9
        Me.bt_ambil.Text = "-"
        Me.bt_ambil.UseVisualStyleBackColor = True
        '
        'bt_kali
        '
        Me.bt_kali.Location = New System.Drawing.Point(73, 66)
        Me.bt_kali.Name = "bt_kali"
        Me.bt_kali.Size = New System.Drawing.Size(23, 23)
        Me.bt_kali.TabIndex = 10
        Me.bt_kali.Text = "x"
        Me.bt_kali.UseVisualStyleBackColor = True
        '
        'bt_bagi
        '
        Me.bt_bagi.Location = New System.Drawing.Point(102, 66)
        Me.bt_bagi.Name = "bt_bagi"
        Me.bt_bagi.Size = New System.Drawing.Size(23, 23)
        Me.bt_bagi.TabIndex = 11
        Me.bt_bagi.Text = "/"
        Me.bt_bagi.UseVisualStyleBackColor = True
        '
        'bt_keluar
        '
        Me.bt_keluar.Location = New System.Drawing.Point(20, 103)
        Me.bt_keluar.Name = "bt_keluar"
        Me.bt_keluar.Size = New System.Drawing.Size(327, 23)
        Me.bt_keluar.TabIndex = 12
        Me.bt_keluar.Text = "KELUAR"
        Me.bt_keluar.UseVisualStyleBackColor = True
        '
        'frmVariabelLat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 148)
        Me.Controls.Add(Me.bt_keluar)
        Me.Controls.Add(Me.bt_bagi)
        Me.Controls.Add(Me.bt_kali)
        Me.Controls.Add(Me.bt_ambil)
        Me.Controls.Add(Me.bt_tambah)
        Me.Controls.Add(Me.lbl_hasil)
        Me.Controls.Add(Me.tb_bil2)
        Me.Controls.Add(Me.tb_bil1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmVariabelLat"
        Me.Text = "frmVariabelLat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_bil1 As System.Windows.Forms.TextBox
    Friend WithEvents tb_bil2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_hasil As System.Windows.Forms.Label
    Friend WithEvents bt_tambah As System.Windows.Forms.Button
    Friend WithEvents bt_ambil As System.Windows.Forms.Button
    Friend WithEvents bt_kali As System.Windows.Forms.Button
    Friend WithEvents bt_bagi As System.Windows.Forms.Button
    Friend WithEvents bt_keluar As System.Windows.Forms.Button
End Class
