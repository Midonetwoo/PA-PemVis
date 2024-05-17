Imports System.Net
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class Form5
    Dim idproduct, idcart, idtransaksi As String
    Dim idcount As Integer
    Dim tgltransaksi As DateTime
    Dim font As New Font("Courier New", 10)
    Dim black As SolidBrush = New SolidBrush(Color.Black)
    Dim total_temp As Double
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Form4.Show()
        Me.Close()
    End Sub
    Sub TampilData()
        DataGridViewCart.Rows.Clear()
        CMD = New MySqlCommand("SELECT p.*, j.*, c.* FROM tbl_product p JOIN tbl_jenis j ON p.id_jenis = j.id_jenis JOIN tbl_cart c ON p.id_product = c.id_product where id_user = '" & idlogin & "' ", CONN)
        RD = CMD.ExecuteReader()
        Dim i As Integer
        i = 0
        While RD.Read()
            Dim row As New DataGridViewRow()
            row.CreateCells(DataGridViewCart)
            row.Cells(0).Value = RD("id_product")
            row.Cells(1).Value = RD("nama_product")
            row.Cells(2).Value = RD("jenis_product")
            row.Cells(3).Value = RD("tanggalrilis_product")
            row.Cells(4).Value = RD("region_product")
            row.Cells(5).Value = RD("harga_product")
            row.Cells(6).Value = "Delete"
            DataGridViewCart.Rows.Add(row)
            i = i + 1
        End While
        RD.Close()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        TampilData()
    End Sub
    Private Sub DataGridViewCart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCart.CellContentClick
        If e.ColumnIndex = DataGridViewCart.Columns("column7").Index AndAlso e.RowIndex >= 0 Then
            idproduct = DataGridViewCart.Rows(e.RowIndex).Cells(0).Value
            ambilidCart()
            CMD = New MySqlCommand("DELETE FROM tbl_cart WHERE id_cart = '" & idcart & "';", CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Product Deleted")
            TampilData()
        End If
    End Sub
    Private Sub btncheckout_Click(sender As Object, e As EventArgs) Handles btncheckout.Click
        Dim agree = UserAgreement()
        If agree Then
            MsgBox("checkout successful")
            tambahtransaksi()
            ButtonPrint_Click()
            TampilData()
        End If
    End Sub
    Sub ambilidCart()
        CMD = New MySqlCommand("select id_cart from tbl_cart where id_product = '" & idproduct & "' and id_user = '" & idlogin & "'", CONN)
        RD = CMD.ExecuteReader()
        RD.Read()
        idcart = RD("id_cart")
        RD.Close()
    End Sub
    Sub clearcart()
        CMD = New MySqlCommand("delete from tbl_cart where id_user = '" & idlogin & "'", CONN)
        CMD.ExecuteNonQuery()
    End Sub
    Dim struk, struk_temp As String
    Public Sub New()
        InitializeComponent()
        AddHandler PrintDocument1.PrintPage, AddressOf Me.PrintDocument1_PrintPage
        PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("Struk", 215, 469)
    End Sub
    Private Sub ButtonPrint_Click()
        struk_temp = ""
        total_temp = 0
        For Each row As DataGridViewRow In DataGridViewCart.Rows
            If Not row.IsNewRow Then
                Dim cellValueColumn2 As String = row.Cells(1).Value.ToString()
                Dim cellValueColumn6 As String = row.Cells(5).Value.ToString()
                If cellValueColumn2.Length > 10 Then
                    cellValueColumn2 = cellValueColumn2.Substring(0, 10) & "..."
                End If
                Dim baris = cellValueColumn2 & " : " & cellValueColumn6 & "$"
                struk_temp &= Environment.NewLine & baris
                total_temp += row.Cells(5).Value
                End If
        Next
        struk = " Dungeons And Dragons " & Environment.NewLine &
                "----------------------" & Environment.NewLine &
                "No. " & idtransaksi & "." & idlogin & Environment.NewLine &
                tgltransaksi & Environment.NewLine &
                struk_temp & Environment.NewLine &
                "----------------------" & Environment.NewLine &
                "Total    : " & total_temp & "$" & Environment.NewLine &
                "----------------------" & Environment.NewLine &
                "  Thank You So Much  "
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim position As Single = 10
        e.Graphics.DrawString(struk, font, black, 10, position)
    End Sub
    Sub tambahtransaksi()
        buatID()
        tgltransaksi = DateTime.Now
        CMD = New MySqlCommand("INSERT INTO tbl_transaksi (id_transaksi, tgl_transaksi, id_user) VALUES('" & idtransaksi & "', '" & tgltransaksi & "', '" & idlogin & "')", CONN)
        CMD.ExecuteNonQuery()
    End Sub
    Sub buatID()
        Dim temp As String
        temp = ""
        CMD = New MySqlCommand("Select id_transaksi from tbl_transaksi", CONN)
        RD = CMD.ExecuteReader
        While RD.Read()
            idtransaksi = RD("id_transaksi")
            If String.Compare(idtransaksi, temp) > 0 Then
                temp = idtransaksi
            End If
        End While
        idtransaksi = temp
        idtransaksi = Replace(idtransaksi, "t", "")
        idcount = CInt(idtransaksi)
        idcount = idcount + 1
        idtransaksi = CStr(idcount)
        idtransaksi = "t" & idtransaksi
        RD.Close()
    End Sub
End Class