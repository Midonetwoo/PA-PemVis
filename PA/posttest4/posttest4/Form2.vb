Imports MySql.Data.MySqlClient

Public Class Form2
    Dim txttypeid As String
    Dim txtregion As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        TampilData()
        kosong()
    End Sub
    Sub kosong()
        txtID.Clear()
        txtName.Clear()
        txtprice.Clear()
        dateRelase.Refresh()
        rbBoardGame.Checked = False
        rbDigitalGames.Checked = False
        rbStartersets.Checked = False
        rbTabletops.Checked = False
        cbAsia.Checked = False
        cbAfrica.Checked = False
        cbEurope.Checked = False
        cbPasific.Checked = False
        cbSouthAmerica.Checked = False
        cbNorthAmerica.Checked = False
        txtID.Focus()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            If row.Index < DataGridView1.RowCount - 1 And row.Index >= 0 Then
                txtID.Text = row.Cells(0).Value
                txtName.Text = row.Cells(1).Value
                txtprice.Text = row.Cells(5).Value
            End If
        End If
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        lblnotif.Text = ""
        If txtSearch.Text <> Nothing Then
            CMD = New MySqlCommand("select p.* , j.* from tbl_product p join tbl_jenis j on p.id_jenis = j.id_jenis where nama_product like '%" & txtSearch.Text & "%'", CONN)
            RD = CMD.ExecuteReader()
            If RD.HasRows Then
                DataGridView1.Rows.Clear()
                Dim i As Integer
                i = 0
                While RD.Read()
                    Dim row As New DataGridViewRow()
                    row.CreateCells(DataGridView1)
                    row.Cells(0).Value = RD("id_product")
                    row.Cells(1).Value = RD("nama_product")
                    row.Cells(2).Value = RD("jenis_product")
                    row.Cells(3).Value = RD("tanggalrilis_product")
                    row.Cells(4).Value = RD("region_product")
                    row.Cells(5).Value = RD("harga_product")
                    DataGridView1.Rows.Add(row)
                    i = i + 1
                End While
                RD.Close()
            Else
                DataGridView1.Rows.Clear()
                lblnotif.Text = "Not Found"
            End If
            RD.Close()
        Else
            TampilData()
        End If
    End Sub
    Sub TampilData()
        DataGridView1.Rows.Clear()
        CMD = New MySqlCommand("select p.* , j.* from tbl_product p join tbl_jenis j on p.id_jenis = j.id_jenis", CONN)
        RD = CMD.ExecuteReader()
        Dim i As Integer
        i = 0
        While RD.Read()
            Dim row As New DataGridViewRow()
            row.CreateCells(DataGridView1)
            row.Cells(0).Value = RD("id_product")
            row.Cells(1).Value = RD("nama_product")
            row.Cells(2).Value = RD("jenis_product")
            row.Cells(3).Value = RD("tanggalrilis_product")
            row.Cells(4).Value = RD("region_product")
            row.Cells(5).Value = RD("harga_product")
            DataGridView1.Rows.Add(row)
            i = i + 1
        End While
        RD.Close()
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ambilType()
        txtregion = ""
        ambilRegion()
        If txtID.Text = Nothing Or txtName.Text = Nothing Or txttypeid = "" Or txtregion = "" Then
            MsgBox("Data must be complete")
            txtID.Focus()
        Else
            CMD = New MySqlCommand("Select * from tbl_product where id_product = '" & txtID.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                RD.Close()
                Dim update As String = "update tbl_product set nama_product = '" & txtName.Text & "', id_jenis = '" & txttypeid & "', tanggalrilis_product = '" & dateRelase.Value & "', region_product = '" & txtregion & "', harga_product = '" & txtprice.Text & "' where id_product = '" & txtID.Text & "'"
                CMD = New MySqlCommand(update, CONN)
                CMD.ExecuteNonQuery()
                TampilData()
                kosong()
                MsgBox("Product Successfully Updated")
                txtID.Focus()
            Else
                RD.Close()
                MsgBox("Can't Find ID")
            End If
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtID.Text = Nothing Then
            MsgBox("Enter ID first")
            txtID.Focus()
        Else
            CMD = New MySqlCommand("Select * from tbl_product where id_product = '" & txtID.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                RD.Close()
                Dim hapus As String = "delete from tbl_cart where id_product = '" & txtID.Text & "'"
                CMD = New MySqlCommand(hapus, CONN)
                CMD.ExecuteNonQuery()
                hapus = "delete from tbl_product where id_product = '" & txtID.Text & "'"
                CMD = New MySqlCommand(hapus, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Product Successfully Deleted")
                TampilData()
            Else
                RD.Close()
                MsgBox("Can't Find ID")
            End If
        End If
    End Sub
    Sub ambilType()
        If rbTabletops.Checked Then
            txttypeid = "101"
        ElseIf rbStartersets.Checked Then
            txttypeid = "102"
        ElseIf rbDigitalGames.Checked Then
            txttypeid = "103"
        ElseIf rbBoardGame.Checked Then
            txttypeid = "104"
        Else
            txttypeid = ""
        End If
        Return
    End Sub
    Sub ambilRegion()
        If cbAsia.Checked Then
            txtregion &= "Asia, "
        End If
        If cbAfrica.Checked Then
            txtregion &= "Africa, "
        End If
        If cbEurope.Checked Then
            txtregion &= "Europe, "
        End If
        If cbNorthAmerica.Checked Then
            txtregion &= "North America, "
        End If
        If cbPasific.Checked Then
            txtregion &= "Pacific, "
        End If
        If cbSouthAmerica.Checked Then
            txtregion &= "South America, "
        End If
        Return
    End Sub

    Private Sub btncart_Click(sender As Object, e As EventArgs) Handles btncart.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub txtprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprice.KeyPress
        HanyaAngka(e)
    End Sub
End Class