Imports MySql.Data.MySqlClient

Public Class Form4
    Dim id As String
    Dim idcount As Integer
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Labelselamatdatang.Text = "Good Evening, " & usernamelogin & "!"
        koneksi()
        TampilData()
    End Sub
    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Form3.kosong()
        Form3.Show()
        Form3.txtUsername.Focus()
        Me.Close()
    End Sub
    Sub TampilData()
        DataGridViewUser.Rows.Clear()
        CMD = New MySqlCommand("select p.* , j.* from tbl_product p join tbl_jenis j on p.id_jenis = j.id_jenis", CONN)
        RD = CMD.ExecuteReader()
        Dim i As Integer
        i = 0
        While RD.Read()
            Dim row As New DataGridViewRow()
            row.CreateCells(DataGridViewUser)
            row.Cells(0).Value = RD("id_product")
            row.Cells(1).Value = RD("nama_product")
            row.Cells(2).Value = RD("jenis_product")
            row.Cells(3).Value = RD("tanggalrilis_product")
            row.Cells(4).Value = RD("region_product")
            row.Cells(5).Value = RD("harga_product")
            row.Cells(6).Value = "Add"
            DataGridViewUser.Rows.Add(row)
            i = i + 1
        End While
        RD.Close()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        TextBox1.Text = ""
        If txtsearch.Text <> Nothing Then
            CMD = New MySqlCommand("select p.* , j.* from tbl_product p join tbl_jenis j on p.id_jenis = j.id_jenis where nama_product like '%" & txtsearch.Text & "%'", CONN)
            RD = CMD.ExecuteReader()
            If RD.HasRows Then
                DataGridViewUser.Rows.Clear()
                While RD.Read()
                    Dim row As New DataGridViewRow()
                    row.CreateCells(DataGridViewUser)
                    row.Cells(0).Value = RD("id_product")
                    row.Cells(1).Value = RD("nama_product")
                    row.Cells(2).Value = RD("jenis_product")
                    row.Cells(3).Value = RD("tanggalrilis_product")
                    row.Cells(4).Value = RD("region_product")
                    row.Cells(5).Value = RD("harga_product")
                    row.Cells(6).Value = "Add"
                    DataGridViewUser.Rows.Add(row)
                End While
            Else
                DataGridViewUser.Rows.Clear()
                TextBox1.Text = "Not Found"
            End If
            RD.Close()
        Else
            TampilData()
        End If
    End Sub
    Private Sub DataGridViewUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUser.CellContentClick
        If e.ColumnIndex = DataGridViewUser.Columns("column7").Index AndAlso e.RowIndex >= 0 Then
            buatid()
            CMD = New MySqlCommand("insert into tbl_cart (id_cart, id_user, id_product)
values ('" & id & "','" & idlogin & "', '" & DataGridViewUser.Rows(e.RowIndex).Cells(0).Value & "');", CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Product Added to Cart")
        End If
    End Sub
    Private Sub btncart_Click(sender As Object, e As EventArgs) Handles btncart.Click
        Form5.Show()
        Me.Hide()
    End Sub
    Private Sub btnprofile_Click(sender As Object, e As EventArgs) Handles btnprofile.Click
        Form7.Show()
        Me.Hide()
    End Sub
    Sub buatid()
        Dim temp As String
        temp = ""
        CMD = New MySqlCommand("Select id_cart from tbl_cart", CONN)
        RD = CMD.ExecuteReader
        While RD.Read()
            id = RD("id_cart")
            If String.Compare(id, temp) > 0 Then
                temp = id
            End If
        End While
        id = temp
        id = Replace(id, "c", "")
        idcount = CInt(id)
        idcount = idcount + 1
        id = CStr(idcount)
        id = "c" & id
        RD.Close()
    End Sub
End Class