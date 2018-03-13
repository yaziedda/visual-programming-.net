<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFungsiBuiltIn
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.YesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OkeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VariableLatihanKalkulatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AwwToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AwawawToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VariableLatihan2LingkaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YesToolStripMenuItem, Me.AwwToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(713, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'YesToolStripMenuItem
        '
        Me.YesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OkeToolStripMenuItem, Me.NoToolStripMenuItem, Me.VariableLatihanKalkulatorToolStripMenuItem, Me.VariableLatihan2LingkaranToolStripMenuItem})
        Me.YesToolStripMenuItem.Name = "YesToolStripMenuItem"
        Me.YesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.YesToolStripMenuItem.Text = "Variable"
        '
        'OkeToolStripMenuItem
        '
        Me.OkeToolStripMenuItem.Name = "OkeToolStripMenuItem"
        Me.OkeToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.OkeToolStripMenuItem.Text = "Variable 1"
        '
        'NoToolStripMenuItem
        '
        Me.NoToolStripMenuItem.Name = "NoToolStripMenuItem"
        Me.NoToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.NoToolStripMenuItem.Text = "Variable 2"
        '
        'VariableLatihanKalkulatorToolStripMenuItem
        '
        Me.VariableLatihanKalkulatorToolStripMenuItem.Name = "VariableLatihanKalkulatorToolStripMenuItem"
        Me.VariableLatihanKalkulatorToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.VariableLatihanKalkulatorToolStripMenuItem.Text = "Variable Latihan ( Kalkulator )"
        '
        'AwwToolStripMenuItem
        '
        Me.AwwToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LalToolStripMenuItem, Me.AwawawToolStripMenuItem})
        Me.AwwToolStripMenuItem.Name = "AwwToolStripMenuItem"
        Me.AwwToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.AwwToolStripMenuItem.Text = "Aww"
        '
        'LalToolStripMenuItem
        '
        Me.LalToolStripMenuItem.Name = "LalToolStripMenuItem"
        Me.LalToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.LalToolStripMenuItem.Text = "Lal"
        '
        'AwawawToolStripMenuItem
        '
        Me.AwawawToolStripMenuItem.Name = "AwawawToolStripMenuItem"
        Me.AwawawToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.AwawawToolStripMenuItem.Text = "Awawaw"
        '
        'VariableLatihan2LingkaranToolStripMenuItem
        '
        Me.VariableLatihan2LingkaranToolStripMenuItem.Name = "VariableLatihan2LingkaranToolStripMenuItem"
        Me.VariableLatihan2LingkaranToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.VariableLatihan2LingkaranToolStripMenuItem.Text = "Variable Latihan 2 ( Lingkaran )"
        '
        'frmFungsiBuiltIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 413)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmFungsiBuiltIn"
        Me.Text = "frmFungsiBuiltIn"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents YesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OkeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AwwToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AwawawToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VariableLatihanKalkulatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VariableLatihan2LingkaranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
