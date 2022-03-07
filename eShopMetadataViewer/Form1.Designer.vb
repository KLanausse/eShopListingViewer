<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Viewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Viewer))
        Me.BottomScreen = New System.Windows.Forms.Panel()
        Me.description = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FromDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FromXMLFIleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveMetadataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TopScreen = New System.Windows.Forms.Panel()
        Me.P_titeBack_Shadow = New System.Windows.Forms.PictureBox()
        Me.P_StatusBar_Shadow = New System.Windows.Forms.PictureBox()
        Me.P_Shadow_01 = New System.Windows.Forms.PictureBox()
        Me.P_BG_00 = New System.Windows.Forms.PictureBox()
        Me.star_rating = New System.Windows.Forms.PictureBox()
        Me.T_Day_01 = New System.Windows.Forms.Label()
        Me.StatusBar = New System.Windows.Forms.Panel()
        Me.InternetBar = New System.Windows.Forms.PictureBox()
        Me.PlatformLabel = New System.Windows.Forms.Label()
        Me.T_price_00 = New System.Windows.Forms.Label()
        Me.P_rating_00 = New System.Windows.Forms.PictureBox()
        Me.W_BG_00 = New System.Windows.Forms.Panel()
        Me.P_Line_01 = New System.Windows.Forms.PictureBox()
        Me.P_Line_02 = New System.Windows.Forms.PictureBox()
        Me.gameThumbnail = New System.Windows.Forms.PictureBox()
        Me.P_Shadow_00 = New System.Windows.Forms.PictureBox()
        Me.T_Day_00 = New System.Windows.Forms.Label()
        Me.T_star_00 = New System.Windows.Forms.Label()
        Me.T_softTitle_01 = New System.Windows.Forms.Label()
        Me.P_titleBack_00 = New System.Windows.Forms.PictureBox()
        Me.BottomScreen.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TopScreen.SuspendLayout()
        CType(Me.P_titeBack_Shadow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P_StatusBar_Shadow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P_Shadow_01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P_BG_00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.star_rating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusBar.SuspendLayout()
        CType(Me.InternetBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P_rating_00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P_Line_01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P_Line_02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gameThumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P_Shadow_00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P_titleBack_00, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BottomScreen
        '
        Me.BottomScreen.BackColor = System.Drawing.Color.Ivory
        Me.BottomScreen.Controls.Add(Me.description)
        Me.BottomScreen.Font = New System.Drawing.Font("FOT-RodinNTLG Pro DB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BottomScreen.Location = New System.Drawing.Point(40, 264)
        Me.BottomScreen.Name = "BottomScreen"
        Me.BottomScreen.Size = New System.Drawing.Size(320, 240)
        Me.BottomScreen.TabIndex = 1
        '
        'description
        '
        Me.description.AutoSize = True
        Me.description.Font = New System.Drawing.Font("FOT-RodinNTLG Pro DB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.description.Location = New System.Drawing.Point(10, 0)
        Me.description.Margin = New System.Windows.Forms.Padding(0)
        Me.description.MaximumSize = New System.Drawing.Size(312, 0)
        Me.description.MinimumSize = New System.Drawing.Size(300, 240)
        Me.description.Name = "description"
        Me.description.Padding = New System.Windows.Forms.Padding(3)
        Me.description.Size = New System.Drawing.Size(300, 240)
        Me.description.TabIndex = 0
        Me.description.Text = "description"
        Me.description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(400, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveMetadataToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FromDatabaseToolStripMenuItem, Me.FromXMLFIleToolStripMenuItem})
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.OpenToolStripMenuItem.Text = "Load"
        '
        'FromDatabaseToolStripMenuItem
        '
        Me.FromDatabaseToolStripMenuItem.Name = "FromDatabaseToolStripMenuItem"
        Me.FromDatabaseToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.FromDatabaseToolStripMenuItem.Text = "From Database"
        '
        'FromXMLFIleToolStripMenuItem
        '
        Me.FromXMLFIleToolStripMenuItem.Name = "FromXMLFIleToolStripMenuItem"
        Me.FromXMLFIleToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.FromXMLFIleToolStripMenuItem.Text = "From XML FIle"
        '
        'SaveMetadataToolStripMenuItem
        '
        Me.SaveMetadataToolStripMenuItem.Name = "SaveMetadataToolStripMenuItem"
        Me.SaveMetadataToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SaveMetadataToolStripMenuItem.Text = "Save Metadata"
        '
        'TopScreen
        '
        Me.TopScreen.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TopScreen.BackgroundImage = Global.eShopMetadataViewer.My.Resources.Resources.TopScreenBG_ext
        Me.TopScreen.Controls.Add(Me.gameThumbnail)
        Me.TopScreen.Controls.Add(Me.P_Shadow_00)
        Me.TopScreen.Controls.Add(Me.T_Day_01)
        Me.TopScreen.Controls.Add(Me.T_Day_00)
        Me.TopScreen.Controls.Add(Me.P_titeBack_Shadow)
        Me.TopScreen.Controls.Add(Me.P_StatusBar_Shadow)
        Me.TopScreen.Controls.Add(Me.P_Shadow_01)
        Me.TopScreen.Controls.Add(Me.P_BG_00)
        Me.TopScreen.Controls.Add(Me.star_rating)
        Me.TopScreen.Controls.Add(Me.StatusBar)
        Me.TopScreen.Controls.Add(Me.PlatformLabel)
        Me.TopScreen.Controls.Add(Me.T_price_00)
        Me.TopScreen.Controls.Add(Me.P_rating_00)
        Me.TopScreen.Controls.Add(Me.W_BG_00)
        Me.TopScreen.Controls.Add(Me.P_Line_01)
        Me.TopScreen.Controls.Add(Me.P_Line_02)
        Me.TopScreen.Controls.Add(Me.T_star_00)
        Me.TopScreen.Controls.Add(Me.T_softTitle_01)
        Me.TopScreen.Controls.Add(Me.P_titleBack_00)
        Me.TopScreen.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopScreen.Font = New System.Drawing.Font("FOT-RodinNTLG Pro DB", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopScreen.Location = New System.Drawing.Point(0, 24)
        Me.TopScreen.Name = "TopScreen"
        Me.TopScreen.Size = New System.Drawing.Size(400, 240)
        Me.TopScreen.TabIndex = 0
        '
        'P_titeBack_Shadow
        '
        Me.P_titeBack_Shadow.BackColor = System.Drawing.Color.Transparent
        Me.P_titeBack_Shadow.Image = Global.eShopMetadataViewer.My.Resources.Resources.titleBack_Shadow
        Me.P_titeBack_Shadow.Location = New System.Drawing.Point(0, 85)
        Me.P_titeBack_Shadow.Name = "P_titeBack_Shadow"
        Me.P_titeBack_Shadow.Size = New System.Drawing.Size(400, 16)
        Me.P_titeBack_Shadow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.P_titeBack_Shadow.TabIndex = 18
        Me.P_titeBack_Shadow.TabStop = False
        '
        'P_StatusBar_Shadow
        '
        Me.P_StatusBar_Shadow.BackColor = System.Drawing.Color.Transparent
        Me.P_StatusBar_Shadow.Image = Global.eShopMetadataViewer.My.Resources.Resources.shadow_00_color
        Me.P_StatusBar_Shadow.Location = New System.Drawing.Point(0, 19)
        Me.P_StatusBar_Shadow.Name = "P_StatusBar_Shadow"
        Me.P_StatusBar_Shadow.Size = New System.Drawing.Size(400, 8)
        Me.P_StatusBar_Shadow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.P_StatusBar_Shadow.TabIndex = 17
        Me.P_StatusBar_Shadow.TabStop = False
        '
        'P_Shadow_01
        '
        Me.P_Shadow_01.BackColor = System.Drawing.Color.Transparent
        Me.P_Shadow_01.Image = Global.eShopMetadataViewer.My.Resources.Resources.line_01_colored
        Me.P_Shadow_01.Location = New System.Drawing.Point(0, 208)
        Me.P_Shadow_01.Name = "P_Shadow_01"
        Me.P_Shadow_01.Size = New System.Drawing.Size(400, 8)
        Me.P_Shadow_01.TabIndex = 16
        Me.P_Shadow_01.TabStop = False
        '
        'P_BG_00
        '
        Me.P_BG_00.BackColor = System.Drawing.Color.Transparent
        Me.P_BG_00.Image = Global.eShopMetadataViewer.My.Resources.Resources.gradation_00_colored
        Me.P_BG_00.Location = New System.Drawing.Point(0, 216)
        Me.P_BG_00.Name = "P_BG_00"
        Me.P_BG_00.Size = New System.Drawing.Size(400, 25)
        Me.P_BG_00.TabIndex = 15
        Me.P_BG_00.TabStop = False
        '
        'star_rating
        '
        Me.star_rating.BackColor = System.Drawing.Color.Transparent
        Me.star_rating.Image = Global.eShopMetadataViewer.My.Resources.Resources.star_00
        Me.star_rating.ImageLocation = ""
        Me.star_rating.Location = New System.Drawing.Point(126, 128)
        Me.star_rating.Name = "star_rating"
        Me.star_rating.Size = New System.Drawing.Size(144, 24)
        Me.star_rating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.star_rating.TabIndex = 13
        Me.star_rating.TabStop = False
        '
        'T_Day_01
        '
        Me.T_Day_01.BackColor = System.Drawing.Color.Transparent
        Me.T_Day_01.Font = New System.Drawing.Font("FOT-RodinNTLG Pro DB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.T_Day_01.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.T_Day_01.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.T_Day_01.Location = New System.Drawing.Point(234, 197)
        Me.T_Day_01.Margin = New System.Windows.Forms.Padding(0)
        Me.T_Day_01.Name = "T_Day_01"
        Me.T_Day_01.Size = New System.Drawing.Size(106, 15)
        Me.T_Day_01.TabIndex = 12
        Me.T_Day_01.Text = "2011/1/1"
        Me.T_Day_01.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'StatusBar
        '
        Me.StatusBar.BackColor = System.Drawing.Color.White
        Me.StatusBar.Controls.Add(Me.InternetBar)
        Me.StatusBar.Location = New System.Drawing.Point(0, 0)
        Me.StatusBar.Margin = New System.Windows.Forms.Padding(0)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(400, 20)
        Me.StatusBar.TabIndex = 3
        '
        'InternetBar
        '
        Me.InternetBar.BackColor = System.Drawing.Color.Transparent
        Me.InternetBar.Image = Global.eShopMetadataViewer.My.Resources.Resources.P_NetModel_Full
        Me.InternetBar.Location = New System.Drawing.Point(26, 2)
        Me.InternetBar.Name = "InternetBar"
        Me.InternetBar.Size = New System.Drawing.Size(108, 16)
        Me.InternetBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.InternetBar.TabIndex = 0
        Me.InternetBar.TabStop = False
        '
        'PlatformLabel
        '
        Me.PlatformLabel.AutoEllipsis = True
        Me.PlatformLabel.BackColor = System.Drawing.Color.Transparent
        Me.PlatformLabel.Font = New System.Drawing.Font("FOT-RodinNTLG Pro DB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PlatformLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PlatformLabel.Location = New System.Drawing.Point(128, 160)
        Me.PlatformLabel.Name = "PlatformLabel"
        Me.PlatformLabel.Size = New System.Drawing.Size(212, 30)
        Me.PlatformLabel.TabIndex = 8
        Me.PlatformLabel.Text = "Platform"
        Me.PlatformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'T_price_00
        '
        Me.T_price_00.BackColor = System.Drawing.Color.Transparent
        Me.T_price_00.Font = New System.Drawing.Font("FOT-RodinNTLG Pro DB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.T_price_00.Location = New System.Drawing.Point(125, 104)
        Me.T_price_00.Name = "T_price_00"
        Me.T_price_00.Size = New System.Drawing.Size(155, 21)
        Me.T_price_00.TabIndex = 7
        Me.T_price_00.Text = "Free"
        '
        'P_rating_00
        '
        Me.P_rating_00.BackColor = System.Drawing.Color.White
        Me.P_rating_00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.P_rating_00.Location = New System.Drawing.Point(344, 135)
        Me.P_rating_00.Name = "P_rating_00"
        Me.P_rating_00.Size = New System.Drawing.Size(48, 72)
        Me.P_rating_00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P_rating_00.TabIndex = 0
        Me.P_rating_00.TabStop = False
        '
        'W_BG_00
        '
        Me.W_BG_00.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.W_BG_00.BackgroundImage = CType(resources.GetObject("W_BG_00.BackgroundImage"), System.Drawing.Image)
        Me.W_BG_00.Location = New System.Drawing.Point(342, 134)
        Me.W_BG_00.Name = "W_BG_00"
        Me.W_BG_00.Size = New System.Drawing.Size(52, 74)
        Me.W_BG_00.TabIndex = 6
        '
        'P_Line_01
        '
        Me.P_Line_01.BackColor = System.Drawing.Color.Transparent
        Me.P_Line_01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.P_Line_01.Image = Global.eShopMetadataViewer.My.Resources.Resources.line_00_ext
        Me.P_Line_01.Location = New System.Drawing.Point(128, 158)
        Me.P_Line_01.Name = "P_Line_01"
        Me.P_Line_01.Size = New System.Drawing.Size(212, 8)
        Me.P_Line_01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.P_Line_01.TabIndex = 5
        Me.P_Line_01.TabStop = False
        '
        'P_Line_02
        '
        Me.P_Line_02.BackColor = System.Drawing.Color.Transparent
        Me.P_Line_02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.P_Line_02.Image = Global.eShopMetadataViewer.My.Resources.Resources.line_00_ext
        Me.P_Line_02.Location = New System.Drawing.Point(128, 193)
        Me.P_Line_02.Name = "P_Line_02"
        Me.P_Line_02.Size = New System.Drawing.Size(212, 8)
        Me.P_Line_02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.P_Line_02.TabIndex = 4
        Me.P_Line_02.TabStop = False
        '
        'gameThumbnail
        '
        Me.gameThumbnail.BackColor = System.Drawing.Color.White
        Me.gameThumbnail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gameThumbnail.Location = New System.Drawing.Point(8, 98)
        Me.gameThumbnail.Name = "gameThumbnail"
        Me.gameThumbnail.Size = New System.Drawing.Size(112, 112)
        Me.gameThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gameThumbnail.TabIndex = 1
        Me.gameThumbnail.TabStop = False
        '
        'P_Shadow_00
        '
        Me.P_Shadow_00.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.P_Shadow_00.Image = Global.eShopMetadataViewer.My.Resources.Resources.shadow_01_96
        Me.P_Shadow_00.Location = New System.Drawing.Point(3, 93)
        Me.P_Shadow_00.Margin = New System.Windows.Forms.Padding(0)
        Me.P_Shadow_00.Name = "P_Shadow_00"
        Me.P_Shadow_00.Size = New System.Drawing.Size(122, 122)
        Me.P_Shadow_00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P_Shadow_00.TabIndex = 0
        Me.P_Shadow_00.TabStop = False
        '
        'T_Day_00
        '
        Me.T_Day_00.BackColor = System.Drawing.Color.Transparent
        Me.T_Day_00.Font = New System.Drawing.Font("FOT-RodinNTLG Pro DB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.T_Day_00.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.T_Day_00.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.T_Day_00.Location = New System.Drawing.Point(128, 182)
        Me.T_Day_00.Margin = New System.Windows.Forms.Padding(0)
        Me.T_Day_00.Name = "T_Day_00"
        Me.T_Day_00.Size = New System.Drawing.Size(212, 30)
        Me.T_Day_00.TabIndex = 11
        Me.T_Day_00.Text = "Release Date"
        Me.T_Day_00.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'T_star_00
        '
        Me.T_star_00.BackColor = System.Drawing.Color.Transparent
        Me.T_star_00.Font = New System.Drawing.Font("FOT-RodinNTLG Pro DB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.T_star_00.ForeColor = System.Drawing.Color.Gray
        Me.T_star_00.Location = New System.Drawing.Point(267, 133)
        Me.T_star_00.Name = "T_star_00"
        Me.T_star_00.Size = New System.Drawing.Size(76, 14)
        Me.T_star_00.TabIndex = 14
        Me.T_star_00.Text = "(8888888)"
        Me.T_star_00.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'T_softTitle_01
        '
        Me.T_softTitle_01.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.T_softTitle_01.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.T_softTitle_01.Location = New System.Drawing.Point(63, 37)
        Me.T_softTitle_01.Name = "T_softTitle_01"
        Me.T_softTitle_01.Size = New System.Drawing.Size(274, 42)
        Me.T_softTitle_01.TabIndex = 3
        Me.T_softTitle_01.Text = "Title"
        Me.T_softTitle_01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'P_titleBack_00
        '
        Me.P_titleBack_00.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P_titleBack_00.BackColor = System.Drawing.Color.Transparent
        Me.P_titleBack_00.Image = Global.eShopMetadataViewer.My.Resources.Resources.titleBack_00_color
        Me.P_titleBack_00.Location = New System.Drawing.Point(0, 20)
        Me.P_titleBack_00.Margin = New System.Windows.Forms.Padding(0)
        Me.P_titleBack_00.Name = "P_titleBack_00"
        Me.P_titleBack_00.Size = New System.Drawing.Size(400, 78)
        Me.P_titleBack_00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P_titleBack_00.TabIndex = 9
        Me.P_titleBack_00.TabStop = False
        '
        'Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(400, 504)
        Me.Controls.Add(Me.BottomScreen)
        Me.Controls.Add(Me.TopScreen)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(416, 543)
        Me.MinimumSize = New System.Drawing.Size(416, 543)
        Me.Name = "Viewer"
        Me.Text = "eShop Metadata Viewer"
        Me.BottomScreen.ResumeLayout(False)
        Me.BottomScreen.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TopScreen.ResumeLayout(False)
        Me.TopScreen.PerformLayout()
        CType(Me.P_titeBack_Shadow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P_StatusBar_Shadow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P_Shadow_01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P_BG_00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.star_rating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        CType(Me.InternetBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P_rating_00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P_Line_01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P_Line_02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gameThumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P_Shadow_00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P_titleBack_00, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TopScreen As System.Windows.Forms.Panel
    Friend WithEvents BottomScreen As System.Windows.Forms.Panel
    Friend WithEvents gameThumbnail As System.Windows.Forms.PictureBox
    Friend WithEvents P_Shadow_00 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents T_softTitle_01 As Label
    Friend WithEvents description As Label
    Friend WithEvents P_Line_02 As PictureBox
    Friend WithEvents P_Line_01 As PictureBox
    Friend WithEvents W_BG_00 As Panel
    Friend WithEvents P_rating_00 As PictureBox
    Friend WithEvents T_price_00 As Label
    Friend WithEvents PlatformLabel As Label
    Friend WithEvents P_titleBack_00 As PictureBox
    Friend WithEvents StatusBar As Panel
    Friend WithEvents InternetBar As PictureBox
    Friend WithEvents T_Day_00 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents T_Day_01 As Label
    Friend WithEvents FromDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FromXMLFIleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveMetadataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents T_star_00 As Label
    Friend WithEvents star_rating As PictureBox
    Friend WithEvents P_BG_00 As PictureBox
    Friend WithEvents P_Shadow_01 As PictureBox
    Friend WithEvents P_StatusBar_Shadow As PictureBox
    Friend WithEvents P_titeBack_Shadow As PictureBox
End Class
