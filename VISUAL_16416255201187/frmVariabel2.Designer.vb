<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVariabel2
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
        Me.tb_panjang = New System.Windows.Forms.TextBox
        Me.tb_lebar = New System.Windows.Forms.TextBox
        Me.bt_hitung = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.tb_hasil = New System.Windows.Forms.TextBox
        Me.bt_keluar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Panjang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lebar"
        '
        'tb_panjang
        '
        Me.tb_panjang.Location = New System.Drawing.Point(60, 9)
        Me.tb_panjang.Name = "tb_panjang"
        Me.tb_panjang.Size = New System.Drawing.Size(212, 20)
        Me.tb_panjang.TabIndex = 2
        '
        'tb_lebar
        '
        Me.tb_lebar.Location = New System.Drawing.Point(60, 35)
        Me.tb_lebar.Name = "tb_lebar"
        Me.tb_lebar.Size = New System.Drawing.Size(212, 20)
        Me.tb_lebar.TabIndex = 3
        '
        'bt_hitung
        '
        Me.bt_hitung.Location = New System.Drawing.Point(15, 62)
        Me.bt_hitung.Name = "bt_hitung"
        Me.bt_hitung.Size = New System.Drawing.Size(257, 23)
        Me.bt_hitung.TabIndex = 4
        Me.bt_hitung.Text = "HITUNG"
        Me.bt_hitung.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "HASIL"
        '
        'tb_hasil
        '
        Me.tb_hasil.Location = New System.Drawing.Point(60, 91)
        Me.tb_hasil.Name = "tb_hasil"
        Me.tb_hasil.Size = New System.Drawing.Size(212, 20)
        Me.tb_hasil.TabIndex = 6
        '
        'bt_keluar
        '
        Me.bt_keluar.Location = New System.Drawing.Point(15, 117)
        Me.bt_keluar.Name = "bt_keluar"
        Me.bt_keluar.Size = New System.Drawing.Size(257, 23)
        Me.bt_keluar.TabIndex = 7
        Me.bt_keluar.Text = "KELUAR"
        Me.bt_keluar.UseVisualStyleBackColor = True
        '
        'frmVariabel2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.bt_keluar)
        Me.Controls.Add(Me.tb_hasil)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bt_hitung)
        Me.Controls.Add(Me.tb_lebar)
        Me.Controls.Add(Me.tb_panjang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmVariabel2"
        Me.Text = "frmVariabel2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_panjang As System.Windows.Forms.TextBox
    Friend WithEvents tb_lebar As System.Windows.Forms.TextBox
    Friend WithEvents bt_hitung As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_hasil As System.Windows.Forms.TextBox
    Friend WithEvents bt_keluar As System.Windows.Forms.Button
End Class
