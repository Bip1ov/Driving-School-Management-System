Imports System.Data.SqlClient
Public Class enrollStudent
    Dim con As New SqlConnection("Data Source=BIPLOV\MSSQLSERVER04;Initial Catalog=DSM_OCEM;Integrated Security=True")
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Hide()
    End Sub
    Public Sub reset()
        Guna2TextBox1.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox6.Clear()
        Guna2ComboBox1.SelectedIndex = -1
    End Sub
    Public Sub loadInstructorName()
        Dim query As String = "select instName from instructor"
        Dim cmd As New SqlCommand(query, con)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        For i As Integer = 0 To dt.Rows.Count - 1
            Guna2ComboBox1.Items.Add(dt.Rows(i)(0))
        Next
    End Sub
    Private Sub enrollStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadInstructorName()
    End Sub

    Public Function fetchInstructorId() As Integer
        Dim query As String = "select instid from instructor where instName = @a"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@a", Guna2ComboBox1.SelectedItem.ToString)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        If dt.Rows.Count > 0 Then
            Return CInt(dt.Rows(0)(0))
        End If
    End Function

    Public Sub insertStudentData()
        Try
            Dim query As String = "insert into student values(@a,@b,@c,@d,@e,@f,@g)"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@a", Guna2TextBox1.Text)
            cmd.Parameters.AddWithValue("@b", Guna2TextBox3.Text)
            cmd.Parameters.AddWithValue("@c", Guna2TextBox4.Text)
            cmd.Parameters.AddWithValue("@d", Guna2TextBox5.Text)
            cmd.Parameters.AddWithValue("@e", fetchInstructorId())
            cmd.Parameters.AddWithValue("@f", Guna2TextBox6.Text)
            cmd.Parameters.AddWithValue("@g", Guna2DateTimePicker1.Value)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            reset()
            MsgBox("successfully Inserted")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        insertStudentData()
        student.loadStudentData()
    End Sub
End Class