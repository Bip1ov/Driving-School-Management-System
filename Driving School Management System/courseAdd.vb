Imports System.Data.SqlClient

Public Class courseAdd
    Dim con As New SqlConnection("Data Source=BIPLOV\MSSQLSERVER04;Initial Catalog=DSM_OCEM;Integrated Security=True")

    Public Sub addCourse()
        Try
            Dim query As String = "insert into course values(@a,@b,@c,@d,@e,@f)"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@a", RichTextBox1.Text)
            cmd.Parameters.AddWithValue("@b", Guna2ComboBox2.SelectedItem)
            cmd.Parameters.AddWithValue("@c", Guna2ComboBox1.SelectedItem)
            cmd.Parameters.AddWithValue("@d", Guna2TextBox1.Text)
            cmd.Parameters.AddWithValue("@e", Guna2TextBox2.Text)
            cmd.Parameters.AddWithValue("@f", Guna2DateTimePicker1.Value)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        addCourse()
        courseForm.loadCourseData()
    End Sub
    Public Sub loadInstructorForCourse()
        Guna2ComboBox2.Items.Clear()
        Dim query As String = "select instName from instructor"
        Dim cmd As New SqlCommand(query, con)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        For i As Integer = 0 To dt.Rows.Count - 1
            Guna2ComboBox2.Items.Add(dt.Rows(i)(0))
        Next
    End Sub

    Private Sub courseAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadInstructorForCourse()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
    End Sub
End Class