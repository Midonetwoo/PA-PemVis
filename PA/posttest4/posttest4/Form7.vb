Imports MySql.Data.MySqlClient

Public Class Form7
    Dim id, jk As String
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub btncart_Click(sender As Object, e As EventArgs) Handles btncart.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ambiljeniskelamin()
        Dim update As String = "update tbl_user set alamat_user = '" & txtAlamat.Text & "', nama_user = '" & txtnama.Text & "', jk_user = '" & jk & "', umur_user = '" & txtUmur.Text & "' where id_user = '" & id & "'"
        CMD = New MySqlCommand(update, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Data berhasil di Simpan")
    End Sub
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        ambiljeniskelamin()
        CMD = New MySqlCommand("select * from tbl_user where username = '" & usernamelogin & "'", CONN)
        RD = CMD.ExecuteReader()
        RD.Read()
        id = RD("id_user")
        txtUsername.Text = usernamelogin
        If IsDBNull(RD("nama_user")) Then
            txtnama.Text = ""
        Else
            txtnama.Text = RD("nama_user")
        End If
        If IsDBNull(RD("alamat_user")) Then
            txtAlamat.Text = ""
        Else
            txtAlamat.Text = RD("alamat_user")
        End If
        txtUmur.Text = RD("umur_user")
        If IsDBNull(RD("jk_user")) Then
            jk = ""
        Else
            If RD("jk_user") = "L" Then
                rblakilaki.Checked = True
                rbperempuan.Checked = False
            ElseIf RD("jk_user") = "P" Then
                rbperempuan.Checked = True
                rblakilaki.Checked = False
            End If
        End If
        RD.Close()
    End Sub
    Sub ambiljeniskelamin()
        If rblakilaki.Checked Then
            jk = "L"
        ElseIf rbperempuan.Checked Then
            jk = "P"
        Else
            jk = ""
        End If
    End Sub
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        HanyaAngka(e)
    End Sub
    Private Sub txtnama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnama.KeyPress
        HanyaHuruf(e)
    End Sub
End Class