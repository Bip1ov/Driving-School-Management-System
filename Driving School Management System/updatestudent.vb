Imports System.Data.SqlClient
Public Class updatestudent
    Dim con As New SqlConnection("Data Source=BIPLOV\MSSQLSERVER04;Initial Catalog=DSM_OCEM;Integrated Security=True")
    Public Sub loadStudentDataForUpdate()
        Guna2TextBox1.Text = student.Guna2DataGridView1.SelectedRows(0).Cells(1).Value
        Guna2TextBox3.Text = student.Guna2DataGridView1.SelectedRows(0).Cells(2).Value
        Guna2TextBox4.Text = student.Guna2DataGridView1.SelectedRows(0).Cells(3).Value
        Guna2TextBox5.Text = student.Guna2DataGridView1.SelectedRows(0).Cells(4).Value

        Guna2TextBox6.Text = student.Guna2DataGridView1.SelectedRows(0).Cells(6).Value
        Guna2DateTimePicker1.Value = student.Guna2DataGridView1.SelectedRows(0).Cells(7).Value
    End Sub
    Public Sub loadInstructorForStudentUpdate()
        Dim query As String = "select instName from instructor"
        Dim cmd As New SqlCommand(query, con)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        For i As Integer = 0 To dt.Rows.Count - 1
            Guna2ComboBox1.Items.Add(dt.Rows(i)(0))
        Next
    End Sub
    Private Sub updatestudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadStudentDataForUpdate()
        loadInstructorForStudentUpdate()
    End Sub
    Public Sub reset()
        Guna2TextBox1.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox6.Clear()
        Guna2ComboBox1.SelectedIndex = -1
    End Sub
    Public Function fetchInstructorIdForStudentUpdate() As Integer
        Dim query As String = "select instid from instructor where instName = @a"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@a", Guna2ComboBox1.SelectedItem)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)(0)
        End If
    End Function

    Public Sub updateStudent()
        Try
            Dim query As String = "update student set stuName = @a, stuEmail = @b, stuPhone = @c, stuAddress = @d, instid =@e, stuNote = @f, stuDob = @g where stuid =@i"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@a", Guna2TextBox1.Text)
            cmd.Parameters.AddWithValue("@b", Guna2TextBox3.Text)
            cmd.Parameters.AddWithValue("@c", Guna2TextBox4.Text)
            cmd.Parameters.AddWithValue("@d", Guna2TextBox5.Text)
            cmd.Parameters.AddWithValue("@e", fetchInstructorIdForStudentUpdate)
            cmd.Parameters.AddWithValue("@f", Guna2TextBox6.Text)
            cmd.Parameters.AddWithValue("@g", Guna2DateTimePicker1.Value)
            cmd.Parameters.AddWithValue("@i", student.Guna2DataGridView1.SelectedRows(0).Cells(0).Value)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        updateStudent()
        student.loadStudentData()
    End Sub

    Private Sub Guna2ControlBox2_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox2.Click
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If MessageBox.Show("Are you sure to Clear ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            reset()
        End If
    End Sub
End Class