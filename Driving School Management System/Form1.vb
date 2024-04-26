Imports System.Data.SqlClient

Public Class Form1


    Dim con As New SqlConnection("Data Source=BIPLOV\MSSQLSERVER04;Initial Catalog=DSM_OCEM;Integrated Security=True")

    Public Sub checkLogin()
        Dim query As String = "select userName , userPassword from userLogin where userName = @a and userPassword = @b"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@a", Guna2TextBox1.Text)
        cmd.Parameters.AddWithValue("@b", Guna2TextBox2.Text)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        If dt.Rows.Count > 0 Then
            Me.Hide()
            dashboard.Show()
        Else
            MsgBox("Incorrect Email and Password ")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2TextBox2.UseSystemPasswordChar = Not Guna2CheckBox1.Checked
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged

        Guna2TextBox2.UseSystemPasswordChar = Not Guna2CheckBox1.Checked

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        checkLogin()
    End Sub
End Class
