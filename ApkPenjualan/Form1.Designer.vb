<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.listKodeBrng = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.namaBrng = New System.Windows.Forms.TextBox
        Me.hargaBrng = New System.Windows.Forms.TextBox
        Me.jmlBrg = New System.Windows.Forms.TextBox
        Me.totalPembelian = New System.Windows.Forms.TextBox
        Me.diskon = New System.Windows.Forms.TextBox
        Me.TotalBayar = New System.Windows.Forms.TextBox
        Me.clearHistory = New System.Windows.Forms.Button
        Me.lv = New System.Windows.Forms.ListView
        Me.saveSale = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'listKodeBrng
        '
        Me.listKodeBrng.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listKodeBrng.FormattingEnabled = True
        Me.listKodeBrng.Location = New System.Drawing.Point(212, 36)
        Me.listKodeBrng.Name = "listKodeBrng"
        Me.listKodeBrng.Size = New System.Drawing.Size(359, 32)
        Me.listKodeBrng.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Jumlah Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Total Harga Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 24)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Diskon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 24)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Total Bayar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 24)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Harga Barang"
        '
        'namaBrng
        '
        Me.namaBrng.Enabled = False
        Me.namaBrng.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namaBrng.Location = New System.Drawing.Point(212, 74)
        Me.namaBrng.Name = "namaBrng"
        Me.namaBrng.ReadOnly = True
        Me.namaBrng.Size = New System.Drawing.Size(359, 32)
        Me.namaBrng.TabIndex = 2
        '
        'hargaBrng
        '
        Me.hargaBrng.Enabled = False
        Me.hargaBrng.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hargaBrng.Location = New System.Drawing.Point(212, 112)
        Me.hargaBrng.Name = "hargaBrng"
        Me.hargaBrng.ReadOnly = True
        Me.hargaBrng.Size = New System.Drawing.Size(359, 32)
        Me.hargaBrng.TabIndex = 2
        '
        'jmlBrg
        '
        Me.jmlBrg.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jmlBrg.Location = New System.Drawing.Point(212, 150)
        Me.jmlBrg.Name = "jmlBrg"
        Me.jmlBrg.Size = New System.Drawing.Size(359, 32)
        Me.jmlBrg.TabIndex = 2
        '
        'totalPembelian
        '
        Me.totalPembelian.Enabled = False
        Me.totalPembelian.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalPembelian.Location = New System.Drawing.Point(212, 209)
        Me.totalPembelian.Name = "totalPembelian"
        Me.totalPembelian.ReadOnly = True
        Me.totalPembelian.Size = New System.Drawing.Size(359, 32)
        Me.totalPembelian.TabIndex = 2
        '
        'diskon
        '
        Me.diskon.Enabled = False
        Me.diskon.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diskon.Location = New System.Drawing.Point(212, 247)
        Me.diskon.Name = "diskon"
        Me.diskon.ReadOnly = True
        Me.diskon.Size = New System.Drawing.Size(359, 32)
        Me.diskon.TabIndex = 2
        '
        'TotalBayar
        '
        Me.TotalBayar.Enabled = False
        Me.TotalBayar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalBayar.Location = New System.Drawing.Point(212, 285)
        Me.TotalBayar.Name = "TotalBayar"
        Me.TotalBayar.ReadOnly = True
        Me.TotalBayar.Size = New System.Drawing.Size(359, 32)
        Me.TotalBayar.TabIndex = 2
        '
        'clearHistory
        '
        Me.clearHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearHistory.Location = New System.Drawing.Point(425, 323)
        Me.clearHistory.Name = "clearHistory"
        Me.clearHistory.Size = New System.Drawing.Size(146, 44)
        Me.clearHistory.TabIndex = 3
        Me.clearHistory.Text = "Kosongkan"
        Me.clearHistory.UseVisualStyleBackColor = True
        '
        'lv
        '
        Me.lv.Location = New System.Drawing.Point(590, 36)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(376, 339)
        Me.lv.TabIndex = 4
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'saveSale
        '
        Me.saveSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveSale.Location = New System.Drawing.Point(15, 323)
        Me.saveSale.Name = "saveSale"
        Me.saveSale.Size = New System.Drawing.Size(404, 44)
        Me.saveSale.TabIndex = 5
        Me.saveSale.Text = "Simpan"
        Me.saveSale.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 400)
        Me.Controls.Add(Me.saveSale)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.clearHistory)
        Me.Controls.Add(Me.TotalBayar)
        Me.Controls.Add(Me.diskon)
        Me.Controls.Add(Me.totalPembelian)
        Me.Controls.Add(Me.jmlBrg)
        Me.Controls.Add(Me.hargaBrng)
        Me.Controls.Add(Me.namaBrng)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listKodeBrng)
        Me.Name = "Form1"
        Me.Text = "Aplikasi Penjualan | @dharma_situmorang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listKodeBrng As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents namaBrng As System.Windows.Forms.TextBox
    Friend WithEvents hargaBrng As System.Windows.Forms.TextBox
    Friend WithEvents jmlBrg As System.Windows.Forms.TextBox
    Friend WithEvents totalPembelian As System.Windows.Forms.TextBox
    Friend WithEvents diskon As System.Windows.Forms.TextBox
    Friend WithEvents TotalBayar As System.Windows.Forms.TextBox
    Friend WithEvents clearHistory As System.Windows.Forms.Button
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents saveSale As System.Windows.Forms.Button

End Class
