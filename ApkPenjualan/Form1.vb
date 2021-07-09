Public Class Form1

    Sub MakeTable()
        With lv.Columns
            .Add("Kode Barang", 120, HorizontalAlignment.Left)
            .Add("Nama Barang", 120, HorizontalAlignment.Left)
            .Add("Harga", 120, HorizontalAlignment.Left)
            .Add("Jumlah", 120, HorizontalAlignment.Left)
            .Add("Total", 120, HorizontalAlignment.Left)
        End With
        lv.GridLines = True
        lv.View = View.Details
        lv.FullRowSelect = True
    End Sub

    Sub MakeListItems()
        With listKodeBrng.Items
            .Add("B001")
            .Add("B002")
            .Add("B003")
            .Add("B004")
            .Add("B005")
        End With
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakeListItems()
        MakeTable()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listKodeBrng.SelectedIndexChanged
        Dim name As String = ""
        Dim harga As Double

        Select Case listKodeBrng.Text
            Case "B001"
                name = "Laptop"
                harga = 7500000
            Case "B002"
                name = "Headset"
                harga = 250000
            Case "B003"
                name = "Keyboard"
                harga = 2500000
            Case "B004"
                name = "External HDD"
                harga = 500000
            Case "B005"
                name = "Speaker Full Bass"
                harga = 100000
        End Select

        namaBrng.Text = name
        hargaBrng.Text = harga
    End Sub

    Private Sub jmlBrg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jmlBrg.TextChanged
        totalPembelian.Text = Val(jmlBrg.Text) * Val(hargaBrng.Text)

        ' Cek jumlah barang untuk dapat diskon 
        Dim BanyakDiskon As Double = 0.0
        If Val(jmlBrg.Text) >= 5 Then
            ' Diskon 10%
            BanyakDiskon = 0.1
        ElseIf Val(jmlBrg.Text) >= 3 Then
            ' Diskon 5%
            BanyakDiskon = 0.05
        End If

        diskon.Text = Val(totalPembelian.Text) * BanyakDiskon
        TotalBayar.Text = Val(totalPembelian.Text) - Val(diskon.Text)
    End Sub

    Private Sub clearHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearHistory.Click
        namaBrng.Clear()
        hargaBrng.Clear()
        totalPembelian.Clear()
        TotalBayar.Clear()
        diskon.Clear()
        listKodeBrng.ResetText()
        jmlBrg.Clear()
    End Sub

    Private Sub saveSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveSale.Click
        Dim isi As New ListViewItem
        isi.Text = listKodeBrng.Text
        With isi.SubItems
            .Add(namaBrng.Text)
            .Add(hargaBrng.Text)
            .Add(jmlBrg.Text)
            .Add(totalPembelian.Text)
        End With
        lv.Items.Add(isi)
        clearHistory_Click(sender, e)
    End Sub
End Class

