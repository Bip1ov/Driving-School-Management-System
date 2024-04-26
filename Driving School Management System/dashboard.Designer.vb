<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(dashboard))
        Panel1 = New Panel()
        Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Label2 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        PictureBox1 = New PictureBox()
        dashboard_btn = New Button()
        instructor_btn = New Button()
        student_btn = New Button()
        course_btn = New Button()
        parentPanel = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        parentPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(27), CByte(38), CByte(62))
        Panel1.Controls.Add(Guna2ControlBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1942, 55)
        Panel1.TabIndex = 0
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges3
        Guna2ControlBox1.FillColor = SystemColors.Highlight
        Guna2ControlBox1.HoverState.FillColor = Color.White
        Guna2ControlBox1.HoverState.IconColor = Color.MidnightBlue
        Guna2ControlBox1.IconColor = Color.White
        Guna2ControlBox1.Location = New Point(1874, 9)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2ControlBox1.Size = New Size(56, 36)
        Guna2ControlBox1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(816, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(432, 29)
        Label2.TabIndex = 2
        Label2.Text = "Driving School Management System"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.FromArgb(CByte(27), CByte(38), CByte(62))
        FlowLayoutPanel1.Controls.Add(PictureBox1)
        FlowLayoutPanel1.Controls.Add(dashboard_btn)
        FlowLayoutPanel1.Controls.Add(instructor_btn)
        FlowLayoutPanel1.Controls.Add(student_btn)
        FlowLayoutPanel1.Controls.Add(course_btn)
        FlowLayoutPanel1.Dock = DockStyle.Left
        FlowLayoutPanel1.Location = New Point(0, 55)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(270, 1047)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), Image)
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(276, 154)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' dashboard_btn
        ' 
        dashboard_btn.FlatAppearance.BorderColor = Color.MidnightBlue
        dashboard_btn.FlatAppearance.BorderSize = 0
        dashboard_btn.FlatStyle = FlatStyle.Flat
        dashboard_btn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        dashboard_btn.ForeColor = Color.White
        dashboard_btn.ImageAlign = ContentAlignment.MiddleLeft
        dashboard_btn.Location = New Point(0, 154)
        dashboard_btn.Margin = New Padding(0)
        dashboard_btn.Name = "dashboard_btn"
        dashboard_btn.Size = New Size(276, 83)
        dashboard_btn.TabIndex = 5
        dashboard_btn.Text = "Dashboard"
        dashboard_btn.UseVisualStyleBackColor = True
        ' 
        ' instructor_btn
        ' 
        instructor_btn.FlatAppearance.BorderColor = Color.MidnightBlue
        instructor_btn.FlatAppearance.BorderSize = 0
        instructor_btn.FlatStyle = FlatStyle.Flat
        instructor_btn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        instructor_btn.ForeColor = Color.White
        instructor_btn.ImageAlign = ContentAlignment.MiddleLeft
        instructor_btn.Location = New Point(0, 237)
        instructor_btn.Margin = New Padding(0)
        instructor_btn.Name = "instructor_btn"
        instructor_btn.Size = New Size(276, 83)
        instructor_btn.TabIndex = 3
        instructor_btn.Text = "Instructor"
        instructor_btn.UseVisualStyleBackColor = True
        ' 
        ' student_btn
        ' 
        student_btn.FlatAppearance.BorderColor = Color.MidnightBlue
        student_btn.FlatAppearance.BorderSize = 0
        student_btn.FlatStyle = FlatStyle.Flat
        student_btn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        student_btn.ForeColor = Color.White
        student_btn.ImageAlign = ContentAlignment.MiddleLeft
        student_btn.Location = New Point(0, 320)
        student_btn.Margin = New Padding(0)
        student_btn.Name = "student_btn"
        student_btn.Size = New Size(276, 83)
        student_btn.TabIndex = 2
        student_btn.Text = "Student"
        student_btn.UseVisualStyleBackColor = True
        ' 
        ' course_btn
        ' 
        course_btn.FlatAppearance.BorderColor = Color.MidnightBlue
        course_btn.FlatAppearance.BorderSize = 0
        course_btn.FlatStyle = FlatStyle.Flat
        course_btn.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        course_btn.ForeColor = Color.White
        course_btn.ImageAlign = ContentAlignment.MiddleLeft
        course_btn.Location = New Point(0, 403)
        course_btn.Margin = New Padding(0)
        course_btn.Name = "course_btn"
        course_btn.Size = New Size(276, 83)
        course_btn.TabIndex = 4
        course_btn.Text = "Course"
        course_btn.UseVisualStyleBackColor = True
        ' 
        ' parentPanel
        ' 
        parentPanel.BackColor = Color.White
        parentPanel.Controls.Add(Label4)
        parentPanel.Controls.Add(Label3)
        parentPanel.Controls.Add(Label1)
        parentPanel.Dock = DockStyle.Fill
        parentPanel.Location = New Point(270, 55)
        parentPanel.Margin = New Padding(0)
        parentPanel.MaximumSize = New Size(1672, 1047)
        parentPanel.MinimumSize = New Size(1672, 1047)
        parentPanel.Name = "parentPanel"
        parentPanel.Size = New Size(1672, 1047)
        parentPanel.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.MidnightBlue
        Label4.Location = New Point(328, 649)
        Label4.Name = "Label4"
        Label4.Size = New Size(722, 82)
        Label4.TabIndex = 2
        Label4.Text = "Driving School Management"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.Desktop
        Label3.Location = New Point(785, 590)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 53)
        Label3.TabIndex = 1
        Label3.Text = "to"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(546, 579)
        Label1.Name = "Label1"
        Label1.Size = New Size(250, 70)
        Label1.TabIndex = 0
        Label1.Text = "Welcome !"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1942, 1102)
        Controls.Add(parentPanel)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(1942, 1102)
        MinimumSize = New Size(1918, 1018)
        Name = "dashboard"
        Text = "dashboard"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        parentPanel.ResumeLayout(False)
        parentPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents student_btn As Button
    Friend WithEvents instructor_btn As Button
    Friend WithEvents course_btn As Button
    Friend WithEvents dashboard_btn As Button
    Friend WithEvents parentPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
