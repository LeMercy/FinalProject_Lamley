<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlS8A1 = New System.Windows.Forms.Panel()
        Me.cboSortBy = New System.Windows.Forms.ComboBox()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.radEight = New System.Windows.Forms.RadioButton()
        Me.radTen = New System.Windows.Forms.RadioButton()
        Me.radFour = New System.Windows.Forms.RadioButton()
        Me.lblSortBy = New System.Windows.Forms.Label()
        Me.btnS8A1 = New System.Windows.Forms.Button()
        Me.tt1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnS8A2 = New System.Windows.Forms.Button()
        Me.btnS8A3 = New System.Windows.Forms.Button()
        Me.btnS8A4 = New System.Windows.Forms.Button()
        Me.btnS8A5 = New System.Windows.Forms.Button()
        Me.btnS8A7 = New System.Windows.Forms.Button()
        Me.btnS8A6 = New System.Windows.Forms.Button()
        Me.btnS8A8 = New System.Windows.Forms.Button()
        Me.pnlS8A2 = New System.Windows.Forms.Panel()
        Me.pnlS8A3 = New System.Windows.Forms.Panel()
        Me.pnlS8A4 = New System.Windows.Forms.Panel()
        Me.pnlS8A5 = New System.Windows.Forms.Panel()
        Me.pnlS8A6 = New System.Windows.Forms.Panel()
        Me.pnlS8A7 = New System.Windows.Forms.Panel()
        Me.pnlS8A8 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.pnlS8A8)
        Me.Panel1.Controls.Add(Me.pnlS8A7)
        Me.Panel1.Controls.Add(Me.pnlS8A6)
        Me.Panel1.Controls.Add(Me.pnlS8A5)
        Me.Panel1.Controls.Add(Me.pnlS8A4)
        Me.Panel1.Controls.Add(Me.pnlS8A3)
        Me.Panel1.Controls.Add(Me.pnlS8A2)
        Me.Panel1.Controls.Add(Me.btnS8A8)
        Me.Panel1.Controls.Add(Me.btnS8A6)
        Me.Panel1.Controls.Add(Me.btnS8A7)
        Me.Panel1.Controls.Add(Me.btnS8A5)
        Me.Panel1.Controls.Add(Me.btnS8A4)
        Me.Panel1.Controls.Add(Me.btnS8A3)
        Me.Panel1.Controls.Add(Me.btnS8A2)
        Me.Panel1.Controls.Add(Me.pnlS8A1)
        Me.Panel1.Controls.Add(Me.cboSortBy)
        Me.Panel1.Controls.Add(Me.lblHome)
        Me.Panel1.Controls.Add(Me.radEight)
        Me.Panel1.Controls.Add(Me.radTen)
        Me.Panel1.Controls.Add(Me.radFour)
        Me.Panel1.Controls.Add(Me.lblSortBy)
        Me.Panel1.Controls.Add(Me.btnS8A1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(859, 461)
        Me.Panel1.TabIndex = 0
        '
        'pnlS8A1
        '
        Me.pnlS8A1.Location = New System.Drawing.Point(52, 86)
        Me.pnlS8A1.Name = "pnlS8A1"
        Me.pnlS8A1.Size = New System.Drawing.Size(121, 146)
        Me.pnlS8A1.TabIndex = 7
        Me.pnlS8A1.Visible = False
        '
        'cboSortBy
        '
        Me.cboSortBy.BackColor = System.Drawing.Color.White
        Me.cboSortBy.Enabled = False
        Me.cboSortBy.FormattingEnabled = True
        Me.cboSortBy.Items.AddRange(New Object() {"-None-", "Most Recent", "Alphabetical", "Size", "Least Recent"})
        Me.cboSortBy.Location = New System.Drawing.Point(271, 415)
        Me.cboSortBy.Name = "cboSortBy"
        Me.cboSortBy.Size = New System.Drawing.Size(121, 21)
        Me.cboSortBy.TabIndex = 6
        Me.tt1.SetToolTip(Me.cboSortBy, "Sorts your notes by...")
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.BackColor = System.Drawing.Color.Transparent
        Me.lblHome.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome.ForeColor = System.Drawing.Color.Maroon
        Me.lblHome.Location = New System.Drawing.Point(351, 21)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(98, 47)
        Me.lblHome.TabIndex = 5
        Me.lblHome.Text = "Home"
        '
        'radEight
        '
        Me.radEight.AutoSize = True
        Me.radEight.BackColor = System.Drawing.Color.Transparent
        Me.radEight.Checked = True
        Me.radEight.Enabled = False
        Me.radEight.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.radEight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEight.ForeColor = System.Drawing.Color.Maroon
        Me.radEight.Location = New System.Drawing.Point(163, 418)
        Me.radEight.Name = "radEight"
        Me.radEight.Size = New System.Drawing.Size(31, 17)
        Me.radEight.TabIndex = 4
        Me.radEight.TabStop = True
        Me.radEight.Text = "8"
        Me.tt1.SetToolTip(Me.radEight, "Sorts by 8 notes per page")
        Me.radEight.UseVisualStyleBackColor = False
        '
        'radTen
        '
        Me.radTen.AutoSize = True
        Me.radTen.BackColor = System.Drawing.Color.Transparent
        Me.radTen.Enabled = False
        Me.radTen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.radTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTen.ForeColor = System.Drawing.Color.Maroon
        Me.radTen.Location = New System.Drawing.Point(204, 418)
        Me.radTen.Name = "radTen"
        Me.radTen.Size = New System.Drawing.Size(38, 17)
        Me.radTen.TabIndex = 3
        Me.radTen.Text = "10"
        Me.tt1.SetToolTip(Me.radTen, "Sorts by 10 notes per page")
        Me.radTen.UseVisualStyleBackColor = False
        '
        'radFour
        '
        Me.radFour.AutoSize = True
        Me.radFour.BackColor = System.Drawing.Color.Transparent
        Me.radFour.Enabled = False
        Me.radFour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.radFour.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFour.ForeColor = System.Drawing.Color.Maroon
        Me.radFour.Location = New System.Drawing.Point(122, 418)
        Me.radFour.Name = "radFour"
        Me.radFour.Size = New System.Drawing.Size(31, 17)
        Me.radFour.TabIndex = 2
        Me.radFour.Text = "4"
        Me.tt1.SetToolTip(Me.radFour, "Sorts by 4 notes per page")
        Me.radFour.UseVisualStyleBackColor = False
        '
        'lblSortBy
        '
        Me.lblSortBy.AutoSize = True
        Me.lblSortBy.BackColor = System.Drawing.Color.Transparent
        Me.lblSortBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSortBy.ForeColor = System.Drawing.Color.Maroon
        Me.lblSortBy.Location = New System.Drawing.Point(47, 418)
        Me.lblSortBy.Name = "lblSortBy"
        Me.lblSortBy.Size = New System.Drawing.Size(69, 18)
        Me.lblSortBy.TabIndex = 1
        Me.lblSortBy.Text = "Sort By:"
        '
        'btnS8A1
        '
        Me.btnS8A1.BackColor = System.Drawing.Color.Transparent
        Me.btnS8A1.FlatAppearance.BorderSize = 2
        Me.btnS8A1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnS8A1.Font = New System.Drawing.Font("Bernard MT Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnS8A1.ForeColor = System.Drawing.Color.Maroon
        Me.btnS8A1.Location = New System.Drawing.Point(50, 84)
        Me.btnS8A1.Name = "btnS8A1"
        Me.btnS8A1.Size = New System.Drawing.Size(125, 150)
        Me.btnS8A1.TabIndex = 0
        Me.btnS8A1.Text = "+"
        Me.tt1.SetToolTip(Me.btnS8A1, "Add a new post")
        Me.btnS8A1.UseVisualStyleBackColor = False
        '
        'btnS8A2
        '
        Me.btnS8A2.BackColor = System.Drawing.Color.Transparent
        Me.btnS8A2.FlatAppearance.BorderSize = 2
        Me.btnS8A2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnS8A2.Font = New System.Drawing.Font("Bernard MT Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnS8A2.ForeColor = System.Drawing.Color.Maroon
        Me.btnS8A2.Location = New System.Drawing.Point(236, 84)
        Me.btnS8A2.Name = "btnS8A2"
        Me.btnS8A2.Size = New System.Drawing.Size(125, 150)
        Me.btnS8A2.TabIndex = 8
        Me.btnS8A2.Text = "+"
        Me.tt1.SetToolTip(Me.btnS8A2, "Add a new post")
        Me.btnS8A2.UseVisualStyleBackColor = False
        Me.btnS8A2.Visible = False
        '
        'btnS8A3
        '
        Me.btnS8A3.BackColor = System.Drawing.Color.Transparent
        Me.btnS8A3.FlatAppearance.BorderSize = 2
        Me.btnS8A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnS8A3.Font = New System.Drawing.Font("Bernard MT Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnS8A3.ForeColor = System.Drawing.Color.Maroon
        Me.btnS8A3.Location = New System.Drawing.Point(467, 84)
        Me.btnS8A3.Name = "btnS8A3"
        Me.btnS8A3.Size = New System.Drawing.Size(125, 150)
        Me.btnS8A3.TabIndex = 9
        Me.btnS8A3.Text = "+"
        Me.tt1.SetToolTip(Me.btnS8A3, "Add a new post")
        Me.btnS8A3.UseVisualStyleBackColor = False
        Me.btnS8A3.Visible = False
        '
        'btnS8A4
        '
        Me.btnS8A4.BackColor = System.Drawing.Color.Transparent
        Me.btnS8A4.FlatAppearance.BorderSize = 2
        Me.btnS8A4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnS8A4.Font = New System.Drawing.Font("Bernard MT Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnS8A4.ForeColor = System.Drawing.Color.Maroon
        Me.btnS8A4.Location = New System.Drawing.Point(672, 84)
        Me.btnS8A4.Name = "btnS8A4"
        Me.btnS8A4.Size = New System.Drawing.Size(125, 150)
        Me.btnS8A4.TabIndex = 10
        Me.btnS8A4.Text = "+"
        Me.tt1.SetToolTip(Me.btnS8A4, "Add a new post")
        Me.btnS8A4.UseVisualStyleBackColor = False
        Me.btnS8A4.Visible = False
        '
        'btnS8A5
        '
        Me.btnS8A5.BackColor = System.Drawing.Color.Transparent
        Me.btnS8A5.FlatAppearance.BorderSize = 2
        Me.btnS8A5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnS8A5.Font = New System.Drawing.Font("Bernard MT Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnS8A5.ForeColor = System.Drawing.Color.Maroon
        Me.btnS8A5.Location = New System.Drawing.Point(48, 245)
        Me.btnS8A5.Name = "btnS8A5"
        Me.btnS8A5.Size = New System.Drawing.Size(125, 150)
        Me.btnS8A5.TabIndex = 11
        Me.btnS8A5.Text = "+"
        Me.tt1.SetToolTip(Me.btnS8A5, "Add a new post")
        Me.btnS8A5.UseVisualStyleBackColor = False
        Me.btnS8A5.Visible = False
        '
        'btnS8A7
        '
        Me.btnS8A7.BackColor = System.Drawing.Color.Transparent
        Me.btnS8A7.FlatAppearance.BorderSize = 2
        Me.btnS8A7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnS8A7.Font = New System.Drawing.Font("Bernard MT Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnS8A7.ForeColor = System.Drawing.Color.Maroon
        Me.btnS8A7.Location = New System.Drawing.Point(467, 245)
        Me.btnS8A7.Name = "btnS8A7"
        Me.btnS8A7.Size = New System.Drawing.Size(125, 150)
        Me.btnS8A7.TabIndex = 12
        Me.btnS8A7.Text = "+"
        Me.tt1.SetToolTip(Me.btnS8A7, "Add a new post")
        Me.btnS8A7.UseVisualStyleBackColor = False
        Me.btnS8A7.Visible = False
        '
        'btnS8A6
        '
        Me.btnS8A6.BackColor = System.Drawing.Color.Transparent
        Me.btnS8A6.FlatAppearance.BorderSize = 2
        Me.btnS8A6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnS8A6.Font = New System.Drawing.Font("Bernard MT Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnS8A6.ForeColor = System.Drawing.Color.Maroon
        Me.btnS8A6.Location = New System.Drawing.Point(236, 245)
        Me.btnS8A6.Name = "btnS8A6"
        Me.btnS8A6.Size = New System.Drawing.Size(125, 150)
        Me.btnS8A6.TabIndex = 13
        Me.btnS8A6.Text = "+"
        Me.tt1.SetToolTip(Me.btnS8A6, "Add a new post")
        Me.btnS8A6.UseVisualStyleBackColor = False
        '
        'btnS8A8
        '
        Me.btnS8A8.BackColor = System.Drawing.Color.Transparent
        Me.btnS8A8.FlatAppearance.BorderSize = 2
        Me.btnS8A8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnS8A8.Font = New System.Drawing.Font("Bernard MT Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnS8A8.ForeColor = System.Drawing.Color.Maroon
        Me.btnS8A8.Location = New System.Drawing.Point(672, 245)
        Me.btnS8A8.Name = "btnS8A8"
        Me.btnS8A8.Size = New System.Drawing.Size(125, 150)
        Me.btnS8A8.TabIndex = 14
        Me.btnS8A8.Text = "+"
        Me.tt1.SetToolTip(Me.btnS8A8, "Add a new post")
        Me.btnS8A8.UseVisualStyleBackColor = False
        Me.btnS8A8.Visible = False
        '
        'pnlS8A2
        '
        Me.pnlS8A2.Location = New System.Drawing.Point(238, 86)
        Me.pnlS8A2.Name = "pnlS8A2"
        Me.pnlS8A2.Size = New System.Drawing.Size(121, 146)
        Me.pnlS8A2.TabIndex = 8
        Me.pnlS8A2.Visible = False
        '
        'pnlS8A3
        '
        Me.pnlS8A3.Location = New System.Drawing.Point(469, 86)
        Me.pnlS8A3.Name = "pnlS8A3"
        Me.pnlS8A3.Size = New System.Drawing.Size(121, 146)
        Me.pnlS8A3.TabIndex = 9
        Me.pnlS8A3.Visible = False
        '
        'pnlS8A4
        '
        Me.pnlS8A4.Location = New System.Drawing.Point(674, 86)
        Me.pnlS8A4.Name = "pnlS8A4"
        Me.pnlS8A4.Size = New System.Drawing.Size(121, 146)
        Me.pnlS8A4.TabIndex = 9
        Me.pnlS8A4.Visible = False
        '
        'pnlS8A5
        '
        Me.pnlS8A5.Location = New System.Drawing.Point(50, 246)
        Me.pnlS8A5.Name = "pnlS8A5"
        Me.pnlS8A5.Size = New System.Drawing.Size(121, 146)
        Me.pnlS8A5.TabIndex = 8
        Me.pnlS8A5.Visible = False
        '
        'pnlS8A6
        '
        Me.pnlS8A6.Location = New System.Drawing.Point(238, 247)
        Me.pnlS8A6.Name = "pnlS8A6"
        Me.pnlS8A6.Size = New System.Drawing.Size(121, 146)
        Me.pnlS8A6.TabIndex = 9
        Me.pnlS8A6.Visible = False
        '
        'pnlS8A7
        '
        Me.pnlS8A7.Location = New System.Drawing.Point(469, 247)
        Me.pnlS8A7.Name = "pnlS8A7"
        Me.pnlS8A7.Size = New System.Drawing.Size(121, 146)
        Me.pnlS8A7.TabIndex = 10
        Me.pnlS8A7.Visible = False
        '
        'pnlS8A8
        '
        Me.pnlS8A8.Location = New System.Drawing.Point(674, 247)
        Me.pnlS8A8.Name = "pnlS8A8"
        Me.pnlS8A8.Size = New System.Drawing.Size(121, 146)
        Me.pnlS8A8.TabIndex = 10
        Me.pnlS8A8.Visible = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 461)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnS8A1 As Button
    Friend WithEvents lblSortBy As Label
    Friend WithEvents radEight As RadioButton
    Friend WithEvents radTen As RadioButton
    Friend WithEvents radFour As RadioButton
    Friend WithEvents lblHome As Label
    Friend WithEvents tt1 As ToolTip
    Friend WithEvents cboSortBy As ComboBox
    Friend WithEvents pnlS8A1 As Panel
    Friend WithEvents btnS8A8 As Button
    Friend WithEvents btnS8A6 As Button
    Friend WithEvents btnS8A7 As Button
    Friend WithEvents btnS8A5 As Button
    Friend WithEvents btnS8A4 As Button
    Friend WithEvents btnS8A3 As Button
    Friend WithEvents btnS8A2 As Button
    Friend WithEvents pnlS8A8 As Panel
    Friend WithEvents pnlS8A7 As Panel
    Friend WithEvents pnlS8A6 As Panel
    Friend WithEvents pnlS8A5 As Panel
    Friend WithEvents pnlS8A4 As Panel
    Friend WithEvents pnlS8A3 As Panel
    Friend WithEvents pnlS8A2 As Panel
End Class
