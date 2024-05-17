<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbDigitalGames = New System.Windows.Forms.RadioButton()
        Me.rbBoardGame = New System.Windows.Forms.RadioButton()
        Me.rbStartersets = New System.Windows.Forms.RadioButton()
        Me.rbTabletops = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbAfrica = New System.Windows.Forms.CheckBox()
        Me.cbSouthAmerica = New System.Windows.Forms.CheckBox()
        Me.cbPasific = New System.Windows.Forms.CheckBox()
        Me.cbEurope = New System.Windows.Forms.CheckBox()
        Me.cbNorthAmerica = New System.Windows.Forms.CheckBox()
        Me.cbAsia = New System.Windows.Forms.CheckBox()
        Me.dateRelase = New System.Windows.Forms.DateTimePicker()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Controls.Add(Me.rbDigitalGames)
        Me.GroupBox1.Controls.Add(Me.rbBoardGame)
        Me.GroupBox1.Controls.Add(Me.rbStartersets)
        Me.GroupBox1.Controls.Add(Me.rbTabletops)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(210, 74)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(425, 123)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type"
        '
        'rbDigitalGames
        '
        Me.rbDigitalGames.AutoSize = True
        Me.rbDigitalGames.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDigitalGames.Location = New System.Drawing.Point(191, 63)
        Me.rbDigitalGames.Margin = New System.Windows.Forms.Padding(4)
        Me.rbDigitalGames.Name = "rbDigitalGames"
        Me.rbDigitalGames.Size = New System.Drawing.Size(154, 29)
        Me.rbDigitalGames.TabIndex = 5
        Me.rbDigitalGames.TabStop = True
        Me.rbDigitalGames.Text = "Digital Games"
        Me.rbDigitalGames.UseVisualStyleBackColor = True
        '
        'rbBoardGame
        '
        Me.rbBoardGame.AutoSize = True
        Me.rbBoardGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBoardGame.Location = New System.Drawing.Point(191, 34)
        Me.rbBoardGame.Margin = New System.Windows.Forms.Padding(4)
        Me.rbBoardGame.Name = "rbBoardGame"
        Me.rbBoardGame.Size = New System.Drawing.Size(153, 29)
        Me.rbBoardGame.TabIndex = 4
        Me.rbBoardGame.TabStop = True
        Me.rbBoardGame.Text = "Board Games"
        Me.rbBoardGame.UseVisualStyleBackColor = True
        '
        'rbStartersets
        '
        Me.rbStartersets.AutoSize = True
        Me.rbStartersets.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbStartersets.Location = New System.Drawing.Point(25, 63)
        Me.rbStartersets.Margin = New System.Windows.Forms.Padding(4)
        Me.rbStartersets.Name = "rbStartersets"
        Me.rbStartersets.Size = New System.Drawing.Size(127, 29)
        Me.rbStartersets.TabIndex = 3
        Me.rbStartersets.TabStop = True
        Me.rbStartersets.Text = "Startersets"
        Me.rbStartersets.UseVisualStyleBackColor = True
        '
        'rbTabletops
        '
        Me.rbTabletops.AutoSize = True
        Me.rbTabletops.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTabletops.Location = New System.Drawing.Point(25, 34)
        Me.rbTabletops.Margin = New System.Windows.Forms.Padding(4)
        Me.rbTabletops.Name = "rbTabletops"
        Me.rbTabletops.Size = New System.Drawing.Size(120, 29)
        Me.rbTabletops.TabIndex = 2
        Me.rbTabletops.TabStop = True
        Me.rbTabletops.Text = "Tabletops"
        Me.rbTabletops.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Controls.Add(Me.cbAfrica)
        Me.GroupBox2.Controls.Add(Me.cbSouthAmerica)
        Me.GroupBox2.Controls.Add(Me.cbPasific)
        Me.GroupBox2.Controls.Add(Me.cbEurope)
        Me.GroupBox2.Controls.Add(Me.cbNorthAmerica)
        Me.GroupBox2.Controls.Add(Me.cbAsia)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(210, 243)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(425, 150)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Region"
        '
        'cbAfrica
        '
        Me.cbAfrica.AutoSize = True
        Me.cbAfrica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAfrica.Location = New System.Drawing.Point(205, 95)
        Me.cbAfrica.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAfrica.Name = "cbAfrica"
        Me.cbAfrica.Size = New System.Drawing.Size(84, 29)
        Me.cbAfrica.TabIndex = 7
        Me.cbAfrica.Text = "Africa"
        Me.cbAfrica.UseVisualStyleBackColor = True
        '
        'cbSouthAmerica
        '
        Me.cbSouthAmerica.AutoSize = True
        Me.cbSouthAmerica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSouthAmerica.Location = New System.Drawing.Point(205, 66)
        Me.cbSouthAmerica.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSouthAmerica.Name = "cbSouthAmerica"
        Me.cbSouthAmerica.Size = New System.Drawing.Size(163, 29)
        Me.cbSouthAmerica.TabIndex = 6
        Me.cbSouthAmerica.Text = "South America"
        Me.cbSouthAmerica.UseVisualStyleBackColor = True
        '
        'cbPasific
        '
        Me.cbPasific.AutoSize = True
        Me.cbPasific.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPasific.Location = New System.Drawing.Point(205, 38)
        Me.cbPasific.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPasific.Name = "cbPasific"
        Me.cbPasific.Size = New System.Drawing.Size(91, 29)
        Me.cbPasific.TabIndex = 5
        Me.cbPasific.Text = "Pacific"
        Me.cbPasific.UseVisualStyleBackColor = True
        '
        'cbEurope
        '
        Me.cbEurope.AutoSize = True
        Me.cbEurope.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEurope.Location = New System.Drawing.Point(25, 95)
        Me.cbEurope.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEurope.Name = "cbEurope"
        Me.cbEurope.Size = New System.Drawing.Size(97, 29)
        Me.cbEurope.TabIndex = 4
        Me.cbEurope.Text = "Europe"
        Me.cbEurope.UseVisualStyleBackColor = True
        '
        'cbNorthAmerica
        '
        Me.cbNorthAmerica.AutoSize = True
        Me.cbNorthAmerica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNorthAmerica.Location = New System.Drawing.Point(25, 66)
        Me.cbNorthAmerica.Margin = New System.Windows.Forms.Padding(4)
        Me.cbNorthAmerica.Name = "cbNorthAmerica"
        Me.cbNorthAmerica.Size = New System.Drawing.Size(158, 29)
        Me.cbNorthAmerica.TabIndex = 3
        Me.cbNorthAmerica.Text = "North America"
        Me.cbNorthAmerica.UseVisualStyleBackColor = True
        '
        'cbAsia
        '
        Me.cbAsia.AutoSize = True
        Me.cbAsia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAsia.Location = New System.Drawing.Point(25, 38)
        Me.cbAsia.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAsia.Name = "cbAsia"
        Me.cbAsia.Size = New System.Drawing.Size(73, 29)
        Me.cbAsia.TabIndex = 2
        Me.cbAsia.Text = "Asia"
        Me.cbAsia.UseVisualStyleBackColor = True
        '
        'dateRelase
        '
        Me.dateRelase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateRelase.Location = New System.Drawing.Point(210, 205)
        Me.dateRelase.Margin = New System.Windows.Forms.Padding(4)
        Me.dateRelase.Name = "dateRelase"
        Me.dateRelase.Size = New System.Drawing.Size(420, 30)
        Me.dateRelase.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(210, 36)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(425, 30)
        Me.txtName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(66, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(62, 208)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Release Date"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.txtprice)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.dateRelase)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(171, 251)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(715, 469)
        Me.Panel1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Maroon
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(67, 402)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 25)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Price ($)"
        '
        'txtprice
        '
        Me.txtprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Location = New System.Drawing.Point(210, 401)
        Me.txtprice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(425, 30)
        Me.txtprice.TabIndex = 19
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.Maroon
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.Location = New System.Drawing.Point(531, 102)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(170, 40)
        Me.btnCreate.TabIndex = 12
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'btnRead
        '
        Me.btnRead.BackColor = System.Drawing.Color.Maroon
        Me.btnRead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRead.ForeColor = System.Drawing.Color.White
        Me.btnRead.Location = New System.Drawing.Point(720, 102)
        Me.btnRead.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(166, 40)
        Me.btnRead.TabIndex = 13
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(16, 16)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 34)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Log Out"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources.back
        Me.PictureBox3.Location = New System.Drawing.Point(16, 66)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(147, 654)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.up1
        Me.PictureBox1.Location = New System.Drawing.Point(169, 160)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(717, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.logo
        Me.PictureBox2.Location = New System.Drawing.Point(179, 5)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(245, 147)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(438, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(448, 74)
        Me.Panel2.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(240, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 25)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Dashboard Admin"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(914, 735)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDigitalGames As System.Windows.Forms.RadioButton
    Friend WithEvents rbBoardGame As System.Windows.Forms.RadioButton
    Friend WithEvents rbStartersets As System.Windows.Forms.RadioButton
    Friend WithEvents rbTabletops As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbAfrica As System.Windows.Forms.CheckBox
    Friend WithEvents cbSouthAmerica As System.Windows.Forms.CheckBox
    Friend WithEvents cbPasific As System.Windows.Forms.CheckBox
    Friend WithEvents cbEurope As System.Windows.Forms.CheckBox
    Friend WithEvents cbNorthAmerica As System.Windows.Forms.CheckBox
    Friend WithEvents cbAsia As System.Windows.Forms.CheckBox
    Friend WithEvents dateRelase As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
End Class
