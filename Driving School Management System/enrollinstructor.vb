Imports System.Data.SqlClient

Public Class enrollinstructor

    Dim con As New SqlConnection("Data Source=BIPLOV\MSSQLSERVER04;Initial Catalog=DSM_OCEM;Integrated Security=True")
    Private Sub Guna2ControlBox2_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox2.Click
        Me.Close()
    End Sub

    Public Sub reset()
        Guna2TextBox1.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox6.Clear()

    End Sub

    Public Sub insertData()
        Try
            Dim query As String = "insert into instructor values(@a,@b,@c,@d,@e,@f)"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@a", Guna2TextBox1.Text)
            cmd.Parameters.AddWithValue("@b", Guna2TextBox3.Text)
            cmd.Parameters.AddWithValue("@c", Guna2TextBox4.Text)
            cmd.Parameters.AddWithValue("@d", Guna2TextBox5.Text)
            cmd.Parameters.AddWithValue("@e", Guna2TextBox6.Text)
            cmd.Parameters.AddWithValue("@f", Guna2DateTimePicker1.Value)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        insertData()
        instructorForm.showInstructorData()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        reset()
    End Sub
End Class