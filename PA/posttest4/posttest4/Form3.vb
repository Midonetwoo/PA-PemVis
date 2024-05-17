Imports MySql.Data.MySqlClient

Public Class Form3
    Dim loginstatus As Boolean
    Dim jenis_user As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        CMD = New MySqlCommand("select * from tbl_user", CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            If txtUsername.Text = RD("username") Then
                If txtUsername.Text = RD("password") Then
                    loginstatus = True
                    jenis_user = RD("tipe_user")
                End If
            End If
        End While
        RD.Close()
        login()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        kosong()
    End Sub

    Private Sub btnregis_Click(sender As Object, e As EventArgs) Handles btnregis.Click
        Form6.Show()
        Me.Hide()
    End Sub
    Sub login()
        If loginstatus Then
            If jenis_user = "customer" Then
                usernamelogin = txtUsername.Text
                CMD = New MySqlCommand("select id_user from tbl_user where username = '" & usernamelogin & "'", CONN)
                RD = CMD.ExecuteReader()
                RD.Read()
                idlogin = RD("id_user")
                RD.Close()
                Form4.Show()
                Me.Hide()
            ElseIf jenis_user = "admin" Then
                Form1.Show()
                Me.Hide()
            End If
        End If
    End Sub
    Sub kosong()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub
    Sub hidepassword()
        If cbPassword.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub
    Private Sub cbPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbPassword.CheckedChanged
        hidepassword()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class