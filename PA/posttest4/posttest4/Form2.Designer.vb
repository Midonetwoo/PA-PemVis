<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.proID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proRelease_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proRegion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Labelform2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbAfrica = New System.Windows.Forms.CheckBox()
        Me.cbSouthAmerica = New System.Windows.Forms.CheckBox()
        Me.cbPasific = New System.Windows.Forms.CheckBox()
        Me.cbEurope = New System.Windows.Forms.CheckBox()
        Me.cbNorthAmerica = New System.Windows.Forms.CheckBox()
        Me.cbAsia = New System.Windows.Forms.CheckBox()
        Me.dateRelase = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbDigitalGames = New System.Windows.Forms.RadioButton()
        Me.rbBoardGame = New System.Windows.Forms.RadioButton()
        Me.rbStartersets = New System.Windows.Forms.RadioButton()
        Me.rbTabletops = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btncart = New System.Windows.Forms.Button()
        Me.lblnotif = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.logo
        Me.PictureBox2.Location = New System.Drawing.Point(647, 11)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(275, 151)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Maroon
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.proID, Me.proName, Me.proType, Me.proRelease_Date, Me.proRegion, Me.Price})
        Me.DataGridView1.Location = New System.Drawing.Point(33, 283)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(886, 167)
        Me.DataGridView1.TabIndex = 12
        '
        'proID
        '
        Me.proID.HeaderText = "ID"
        Me.proID.MinimumWidth = 6
        Me.proID.Name = "proID"
        Me.proID.ReadOnly = True
        Me.proID.Width = 80
        '
        'proName
        '
        Me.proName.HeaderText = "Name"
        Me.proName.MinimumWidth = 6
        Me.proName.Name = "proName"
        Me.proName.ReadOnly = True
        Me.proName.Width = 200
        '
        'proType
        '
        Me.proType.HeaderText = "Type"
        Me.proType.MinimumWidth = 6
        Me.proType.Name = "proType"
        Me.proType.ReadOnly = True
        Me.proType.Width = 125
        '
        'proRelease_Date
        '
        Me.proRelease_Date.HeaderText = "Release Date"
        Me.proRelease_Date.MinimumWidth = 6
        Me.proRelease_Date.Name = "proRelease_Date"
        Me.proRelease_Date.ReadOnly = True
        Me.proRelease_Date.Width = 125
        '
        'proRegion
        '
        Me.proRegion.HeaderText = "Region"
        Me.proRegion.MinimumWidth = 6
        Me.proRegion.Name = "proRegion"
        Me.proRegion.ReadOnly = True
        Me.proRegion.Width = 200
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.MinimumWidth = 6
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 125
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.up1
        Me.PictureBox1.Location = New System.Drawing.Point(33, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(614, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Labelform2
        '
        Me.Labelform2.AutoSize = True
        Me.Labelform2.BackColor = System.Drawing.Color.Gray
        Me.Labelform2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelform2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Labelform2.Location = New System.Drawing.Point(352, 48)
        Me.Labelform2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelform2.Name = "Labelform2"
        Me.Labelform2.Size = New System.Drawing.Size(0, 25)
        Me.Labelform2.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(22, 13)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 25)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Search Data"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(26, 49)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(497, 30)
        Me.txtSearch.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.Labelform2)
        Me.Panel1.Location = New System.Drawing.Point(32, 185)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(888, 101)
        Me.Panel1.TabIndex = 20
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.White
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Maroon
        Me.btnUpdate.Location = New System.Drawing.Point(641, 48)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(99, 29)
        Me.btnUpdate.TabIndex = 25
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Maroon
        Me.btnDelete.Location = New System.Drawing.Point(756, 48)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(99, 29)
        Me.btnDelete.TabIndex = 24
        Me.btnDelete.Text = "Delate"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtprice)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.dateRelase)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtID)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(33, 472)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(888, 298)
        Me.Panel2.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Maroon
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(437, 238)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Price ($)"
        '
        'txtprice
        '
        Me.txtprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Location = New System.Drawing.Point(546, 235)
        Me.txtprice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(285, 30)
        Me.txtprice.TabIndex = 23
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
        Me.GroupBox2.Location = New System.Drawing.Point(450, 76)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(381, 141)
        Me.GroupBox2.TabIndex = 22
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
        Me.dateRelase.Location = New System.Drawing.Point(479, 21)
        Me.dateRelase.Margin = New System.Windows.Forms.Padding(4)
        Me.dateRelase.Name = "dateRelase"
        Me.dateRelase.Size = New System.Drawing.Size(352, 30)
        Me.dateRelase.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Maroon
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(330, 25)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 25)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Release Date"
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
        Me.GroupBox1.Location = New System.Drawing.Point(35, 129)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(362, 111)
        Me.GroupBox1.TabIndex = 19
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(31, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(115, 26)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(156, 30)
        Me.txtID.TabIndex = 16
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(115, 76)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(282, 30)
        Me.txtName.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(30, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 25)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(316, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 25)
        Me.Label2.TabIndex = 14
        '
        'btncart
        '
        Me.btncart.BackColor = System.Drawing.Color.Maroon
        Me.btncart.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncart.ForeColor = System.Drawing.Color.White
        Me.btncart.Location = New System.Drawing.Point(45, 25)
        Me.btncart.Margin = New System.Windows.Forms.Padding(4)
        Me.btncart.Name = "btncart"
        Me.btncart.Size = New System.Drawing.Size(66, 34)
        Me.btncart.TabIndex = 22
        Me.btncart.Text = "Back"
        Me.btncart.UseVisualStyleBackColor = False
        '
        'lblnotif
        '
        Me.lblnotif.AutoSize = True
        Me.lblnotif.BackColor = System.Drawing.Color.Maroon
        Me.lblnotif.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnotif.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblnotif.Location = New System.Drawing.Point(432, 353)
        Me.lblnotif.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnotif.Name = "lblnotif"
        Me.lblnotif.Size = New System.Drawing.Size(0, 20)
        Me.lblnotif.TabIndex = 26
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(960, 803)
        Me.Controls.Add(Me.lblnotif)
        Me.Controls.Add(Me.btncart)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Labelform2 As System.Windows.Forms.Label
    Friend WithEvents proID As DataGridViewTextBoxColumn
    Friend WithEvents proName As DataGridViewTextBoxColumn
    Friend WithEvents proType As DataGridViewTextBoxColumn
    Friend WithEvents proRelease_Date As DataGridViewTextBoxColumn
    Friend WithEvents proRegion As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbDigitalGames As RadioButton
    Friend WithEvents rbBoardGame As RadioButton
    Friend WithEvents rbStartersets As RadioButton
    Friend WithEvents rbTabletops As RadioButton
    Friend WithEvents dateRelase As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbAfrica As CheckBox
    Friend WithEvents cbSouthAmerica As CheckBox
    Friend WithEvents cbPasific As CheckBox
    Friend WithEvents cbEurope As CheckBox
    Friend WithEvents cbNorthAmerica As CheckBox
    Friend WithEvents cbAsia As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btncart As Button
    Friend WithEvents lblnotif As Label
End Class
