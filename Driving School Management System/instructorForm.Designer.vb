﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class instructorForm
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(instructorForm))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        delete_btn = New Guna.UI2.WinForms.Guna2Button()
        Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Panel2 = New Panel()
        Label11 = New Label()
        Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        update_btn = New Guna.UI2.WinForms.Guna2Button()
        search_btn = New Guna.UI2.WinForms.Guna2Button()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2Panel6.SuspendLayout()
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.Location = New Point(598, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(230, 54)
        Label1.TabIndex = 28
        Label1.Text = "Instructor"
        ' 
        ' delete_btn
        ' 
        delete_btn.CustomizableEdges = CustomizableEdges1
        delete_btn.DisabledState.BorderColor = Color.DarkGray
        delete_btn.DisabledState.CustomBorderColor = Color.DarkGray
        delete_btn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        delete_btn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        delete_btn.FillColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        delete_btn.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        delete_btn.ForeColor = Color.White
        delete_btn.Image = CType(resources.GetObject("delete_btn.Image"), Image)
        delete_btn.Location = New Point(1395, 97)
        delete_btn.Name = "delete_btn"
        delete_btn.PressedColor = Color.Silver
        delete_btn.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        delete_btn.Size = New Size(52, 45)
        delete_btn.TabIndex = 27
        ' 
        ' Guna2Panel6
        ' 
        Guna2Panel6.Controls.Add(Guna2DataGridView1)
        Guna2Panel6.CustomizableEdges = CustomizableEdges3
        Guna2Panel6.Location = New Point(13, 199)
        Guna2Panel6.Name = "Guna2Panel6"
        Guna2Panel6.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Panel6.Size = New Size(1434, 764)
        Guna2Panel6.TabIndex = 26
        ' 
        ' Guna2DataGridView1
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Guna2DataGridView1.ColumnHeadersHeight = 22
        Guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Guna2DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Guna2DataGridView1.Dock = DockStyle.Fill
        Guna2DataGridView1.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.Location = New Point(0, 0)
        Guna2DataGridView1.Name = "Guna2DataGridView1"
        Guna2DataGridView1.RowHeadersVisible = False
        Guna2DataGridView1.RowHeadersWidth = 51
        Guna2DataGridView1.RowTemplate.Height = 29
        Guna2DataGridView1.Size = New Size(1434, 764)
        Guna2DataGridView1.TabIndex = 0
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White
        Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 22
        Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Column1
        ' 
        Column1.DataPropertyName = "instid"
        Column1.HeaderText = "Id"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.DataPropertyName = "instName"
        Column2.HeaderText = "Name"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.DataPropertyName = "instEmail"
        Column3.HeaderText = "Email"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.DataPropertyName = "instPhone"
        Column4.HeaderText = "Phone"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.DataPropertyName = "instAddress"
        Column5.HeaderText = "Address"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.DataPropertyName = "instNote"
        Column6.HeaderText = "Note"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        ' 
        ' Column7
        ' 
        Column7.DataPropertyName = "instDob"
        Column7.HeaderText = "Date of Birth"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightGray
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Guna2Button4)
        Panel2.Location = New Point(1071, 97)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(318, 45)
        Panel2.TabIndex = 25
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(58, 5)
        Label11.Name = "Label11"
        Label11.Size = New Size(146, 25)
        Label11.TabIndex = 13
        Label11.Text = "Enroll Instructor"
        ' 
        ' Guna2Button4
        ' 
        Guna2Button4.CustomizableEdges = CustomizableEdges5
        Guna2Button4.DisabledState.BorderColor = Color.DarkGray
        Guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button4.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button4.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button4.FillColor = Color.LightSteelBlue
        Guna2Button4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2Button4.ForeColor = Color.White
        Guna2Button4.Image = CType(resources.GetObject("Guna2Button4.Image"), Image)
        Guna2Button4.Location = New Point(265, 0)
        Guna2Button4.Name = "Guna2Button4"
        Guna2Button4.PressedColor = Color.Silver
        Guna2Button4.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Button4.Size = New Size(52, 45)
        Guna2Button4.TabIndex = 12
        ' 
        ' update_btn
        ' 
        update_btn.CustomizableEdges = CustomizableEdges7
        update_btn.DisabledState.BorderColor = Color.DarkGray
        update_btn.DisabledState.CustomBorderColor = Color.DarkGray
        update_btn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        update_btn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        update_btn.FillColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        update_btn.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        update_btn.ForeColor = Color.White
        update_btn.Image = My.Resources.Resources.icons8_update_50
        update_btn.Location = New Point(359, 97)
        update_btn.Name = "update_btn"
        update_btn.PressedColor = Color.Silver
        update_btn.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        update_btn.Size = New Size(52, 45)
        update_btn.TabIndex = 24
        ' 
        ' search_btn
        ' 
        search_btn.CustomizableEdges = CustomizableEdges9
        search_btn.DisabledState.BorderColor = Color.DarkGray
        search_btn.DisabledState.CustomBorderColor = Color.DarkGray
        search_btn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        search_btn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        search_btn.FillColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        search_btn.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        search_btn.ForeColor = Color.White
        search_btn.Image = CType(resources.GetObject("search_btn.Image"), Image)
        search_btn.Location = New Point(301, 97)
        search_btn.Name = "search_btn"
        search_btn.PressedColor = SystemColors.ButtonHighlight
        search_btn.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        search_btn.Size = New Size(52, 45)
        search_btn.TabIndex = 23
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.CustomizableEdges = CustomizableEdges11
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Location = New Point(30, 97)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderText = "Search..."
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2TextBox1.Size = New Size(265, 45)
        Guna2TextBox1.TabIndex = 22
        ' 
        ' instructorForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.White
        ClientSize = New Size(1522, 1047)
        Controls.Add(Label1)
        Controls.Add(delete_btn)
        Controls.Add(Guna2Panel6)
        Controls.Add(Panel2)
        Controls.Add(update_btn)
        Controls.Add(search_btn)
        Controls.Add(Guna2TextBox1)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(1672, 1047)
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "instructorForm"
        Text = "instructorForm"
        WindowState = FormWindowState.Maximized
        Guna2Panel6.ResumeLayout(False)
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents delete_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents update_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents search_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
