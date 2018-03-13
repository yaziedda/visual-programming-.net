<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVariableLat2
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
        Me.tb_jarijari = New System.Windows.Forms.TextBox
        Me.bt_keliling = New System.Windows.Forms.Button
        Me.bt_luas = New System.Windows.Forms.Button
        Me.bt_all = New System.Windows.Forms.Button
        Me.lbl_keliling = New System.Windows.Forms.Label
        Me.lbl_luas = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.bt_reset = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jari-Jari"
        '
        'tb_jarijari
        '
        Me.tb_jarijari.Location = New System.Drawing.Point(61, 12)
        Me.tb_jarijari.Name = "tb_jarijari"
        Me.tb_jarijari.Size = New System.Drawing.Size(100, 20)
        Me.tb_jarijari.TabIndex = 1
        '
        'bt_keliling
        '
        Me.bt_keliling.Location = New System.Drawing.Point(16, 39)
        Me.bt_keliling.Name = "bt_keliling"
        Me.bt_keliling.Size = New System.Drawing.Size(256, 23)
        Me.bt_keliling.TabIndex = 2
        Me.bt_keliling.Text = "Keliling Lingkaran"
        Me.bt_keliling.UseVisualStyleBackColor = True
        '
        'bt_luas
        '
        Me.bt_luas.Location = New System.Drawing.Point(16, 69)
        Me.bt_luas.Name = "bt_luas"
        Me.bt_luas.Size = New System.Drawing.Size(256, 23)
        Me.bt_luas.TabIndex = 3
        Me.bt_luas.Text = "Luas Lingkaran"
        Me.bt_luas.UseVisualStyleBackColor = True
        '
        'bt_all
        '
        Me.bt_all.Location = New System.Drawing.Point(16, 99)
        Me.bt_all.Name = "bt_all"
        Me.bt_all.Size = New System.Drawing.Size(256, 23)
        Me.bt_all.TabIndex = 4
        Me.bt_all.Text = "Luas & Keliling Lingkaran"
        Me.bt_all.UseVisualStyleBackColor = True
        '
        'lbl_keliling
        '
        Me.lbl_keliling.AutoSize = True
        Me.lbl_keliling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_keliling.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_keliling.Location = New System.Drawing.Point(16, 148)
        Me.lbl_keliling.Name = "lbl_keliling"
        Me.lbl_keliling.Padding = New System.Windows.Forms.Padding(16)
        Me.lbl_keliling.Size = New System.Drawing.Size(70, 73)
        Me.lbl_keliling.TabIndex = 5
        Me.lbl_keliling.Text = "0"
        '
        'lbl_luas
        '
        Me.lbl_luas.AutoSize = True
        Me.lbl_luas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_luas.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_luas.Location = New System.Drawing.Point(202, 148)
        Me.lbl_luas.Name = "lbl_luas"
        Me.lbl_luas.Padding = New System.Windows.Forms.Padding(16)
        Me.lbl_luas.Size = New System.Drawing.Size(70, 73)
        Me.lbl_luas.TabIndex = 6
        Me.lbl_luas.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Keliling : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(199, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Luas : "
        '
        'bt_reset
        '
        Me.bt_reset.Location = New System.Drawing.Point(16, 225)
        Me.bt_reset.Name = "bt_reset"
        Me.bt_reset.Size = New System.Drawing.Size(256, 23)
        Me.bt_reset.TabIndex = 9
        Me.bt_reset.Text = "RESET ALL"
        Me.bt_reset.UseVisualStyleBackColor = True
        '
        'frmVariableLat2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.bt_reset)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_luas)
        Me.Controls.Add(Me.lbl_keliling)
        Me.Controls.Add(Me.bt_all)
        Me.Controls.Add(Me.bt_luas)
        Me.Controls.Add(Me.bt_keliling)
        Me.Controls.Add(Me.tb_jarijari)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmVariableLat2"
        Me.Text = "frmVariableLat2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_jarijari As System.Windows.Forms.TextBox
    Friend WithEvents bt_keliling As System.Windows.Forms.Button
    Friend WithEvents bt_luas As System.Windows.Forms.Button
    Friend WithEvents bt_all As System.Windows.Forms.Button
    Friend WithEvents lbl_keliling As System.Windows.Forms.Label
    Friend WithEvents lbl_luas As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bt_reset As System.Windows.Forms.Button
End Class
