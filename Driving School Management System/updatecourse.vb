Imports System.Data.SqlClient

Public Class updatecourse
    Dim con As New SqlConnection("Data Source=BIPLOV\MSSQLSERVER04;Initial Catalog=DSM_OCEM;Integrated Security=True")

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Close()
    End Sub

    Public Sub loadCOurseData()

        RichTextBox1.Text = courseForm.Guna2DataGridView1.SelectedRows(0).Cells(1).Value
        Guna2ComboBox2.SelectedItem = courseForm.Guna2DataGridView1.SelectedRows(0).Cells(2).Value
        Guna2ComboBox1.SelectedItem = courseForm.Guna2DataGridView1.SelectedRows(0).Cells(3).Value
        Guna2TextBox1.Text = courseForm.Guna2DataGridView1.SelectedRows(0).Cells(4).Value
        Guna2TextBox2.Text = courseForm.Guna2DataGridView1.SelectedRows(0).Cells(5).Value
        Guna2DateTimePicker1.Value = courseForm.Guna2DataGridView1.SelectedRows(0).Cells(6).Value
    End Sub
    Private Sub updatecourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCOurseData()
    End Sub
End Class