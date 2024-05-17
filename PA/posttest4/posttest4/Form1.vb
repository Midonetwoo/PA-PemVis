Imports MySql.Data.MySqlClient
Public Class Form1
    Dim txttypeid, id As String
    Dim txtregion As String
    Dim idcount As Integer
    Dim datatypeArray(100) As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        kosong()
    End Sub
    Sub kosong()
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
        txtName.Focus()
    End Sub
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ambilType()
        txtregion = ""
        ambilRegion()
        If txtName.Text = Nothing Or txttypeid = "" Or txtregion = "" Then
            MsgBox("Data Harus Lengkap")
            txtName.Focus()
        Else
            buatID()
            CMD = New MySqlCommand("insert into tbl_product values ('" & id & "', '" & txtName.Text & "', '" & txttypeid & "', '" & dateRelase.Value & "', '" & txtregion & "', '" & txtprice.Text & "')", CONN)
            CMD.ExecuteNonQuery()
            kosong()
            MsgBox("Data Berhasil Disimpan")
            txtName.Focus()
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
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.kosong()
        Form3.Show()
        Form3.txtUsername.Focus()
        Me.Hide()
    End Sub
    Sub buatID()
        Dim temp As String
        temp = ""
        CMD = New MySqlCommand("Select id_product from tbl_product", CONN)
        RD = CMD.ExecuteReader
        While RD.Read()
            id = RD("id_product")
            If String.Compare(id, temp) > 0 Then
                temp = id
            End If
        End While
        id = temp
        id = Replace(id, "p", "")
        idcount = CInt(id)
        idcount = idcount + 1
        id = CStr(idcount)
        id = "p" & id
        RD.Close()
    End Sub
    Private Sub txtprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprice.KeyPress
        HanyaAngka(e)
    End Sub
End Class
