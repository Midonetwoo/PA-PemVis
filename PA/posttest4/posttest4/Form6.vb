Imports MySql.Data.MySqlClient
Public Class Form6
    Dim jk, id As String
    Dim idcount As Integer

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Form3.Show()
        Me.Close()
    End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If inputcheck() Then
            ambiljeniskelamin()
            hitung_user()
            Form3.txtUsername.Text = txtUsername.Text
            Form3.txtPassword.Text = txtpassword.Text
            CMD = New MySqlCommand("INSERT INTO tbl_user (id_user, username, password, alamat_user, nama_user, jk_user, umur_user, tipe_user) 
VALUES (CONCAT('customer" & id & "'), '" & txtUsername.Text & "', '" & txtpassword.Text & "', '" & txtAlamat.Text & "', '" & txtnama.Text & "', '" & jk & "', '" & txtUmur.Text & "', 'customer');", CONN)
            CMD.ExecuteNonQuery()
            Form3.Show()
            Me.Close()
        End If
    End Sub
    Public Function inputcheck() As Boolean
        If txtUsername.Text = "" Or txtpassword.Text = "" Or txtAlamat.Text = "" Or txtUmur.Text = "" Then
            lblNotif.Text = "Data cannot be empty"
            Return False
        ElseIf txtpassword.Text <> txtconfirmpassword.Text Then
            lblNotif.Text = "Confirm the password correctly"
            Return False
        ElseIf Not rblakilaki.Checked And Not rbperempuan.Checked Then
            lblNotif.Text = "Data cannot be empty"
            Return False
        Else
            If CheckBox1.Checked Then
                Return True
            End If
            lblNotif.Text = "You must agree to the terms of service"
        End If
    End Function
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub
    Sub hitung_user()
        CMD = New MySqlCommand("select * from tbl_user", CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            id = RD("id_user")
        End While
        id = Replace(id, "customer", "")
        idcount = CInt(id)
        idcount = idcount + 1
        id = CStr(idcount)
        RD.Close()
    End Sub
    Sub hidepassword()
        If cbPassword.Checked Then
            txtpassword.PasswordChar = ""
            txtconfirmpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "*"
            txtconfirmpassword.PasswordChar = "*"
        End If
    End Sub
    Private Sub cbPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbPassword.CheckedChanged
        hidepassword()
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
    Private Sub txtnama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnama.KeyPress
        HanyaHuruf(e)
    End Sub
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        HanyaAngka(e)
    End Sub
End Class