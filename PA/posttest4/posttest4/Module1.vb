Imports MySql.Data.MySqlClient

Module Module1
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public STR As String
    Public usernamelogin, idlogin As String

    Sub koneksi()
        Try
            Dim STR As String = "server=localhost;userid=root;password=;database=new_data_dnd"
            CONN = New MySqlConnection(STR)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 65) And (tombol <= 90)) Or ((tombol >= 97) And
        (tombol <= 122)) Or (tombol = 8) Or (tombol = 32) Or (tombol = 46)) Then
            e.Handled = True
        End If
    End Sub
    Public Sub HanyaAngka(e As KeyPressEventArgs)
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8) Or (tombol = 46)) Then
            e.Handled = True
        End If
    End Sub
    Public Function UserAgreement() As Boolean
        Dim response As Integer
        response = MsgBox("Are you sure??", vbYesNo + vbQuestion, "User Agreement")
        If response = vbYes Then
            UserAgreement = True
        Else
            UserAgreement = False
        End If
    End Function

End Module
