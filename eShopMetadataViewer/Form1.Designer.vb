<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Viewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Viewer))
        Me.TopScreen = New System.Windows.Forms.Panel()
        Me.T_softTitle_01 = New System.Windows.Forms.Label()
        Me.gameImage = New System.Windows.Forms.PictureBox()
        Me.P_Shadow_00 = New System.Windows.Forms.PictureBox()
        Me.BottomScreen = New System.Windows.Forms.Panel()
        Me.description = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TopScreen.SuspendLayout()
        CType(Me.gameImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P_Shadow_00, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomScreen.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopScreen
        '
        Me.TopScreen.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.TopScreen.Controls.Add(Me.T_softTitle_01)
        Me.TopScreen.Controls.Add(Me.gameImage)
        Me.TopScreen.Controls.Add(Me.P_Shadow_00)
        Me.TopScreen.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopScreen.Font = New System.Drawing.Font("FOT-RodinNTLG Pro DB", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopScreen.Location = New System.Drawing.Point(0, 24)
        Me.TopScreen.Name = "TopScreen"
        Me.TopScreen.Size = New System.Drawing.Size(400, 240)
        Me.TopScreen.TabIndex = 0
        '
        'T_softTitle_01
        '
        Me.T_softTitle_01.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.T_softTitle_01.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.T_softTitle_01.Location = New System.Drawing.Point(67, 16)
        Me.T_softTitle_01.Name = "T_softTitle_01"
        Me.T_softTitle_01.Size = New System.Drawing.Size(274, 42)
        Me.T_softTitle_01.TabIndex = 3
        Me.T_softTitle_01.Text = "Title"
        Me.T_softTitle_01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gameImage
        '
        Me.gameImage.BackColor = System.Drawing.Color.White
        Me.gameImage.Location = New System.Drawing.Point(8, 91)
        Me.gameImage.Name = "gameImage"
        Me.gameImage.Size = New System.Drawing.Size(112, 112)
        Me.gameImage.TabIndex = 1
        Me.gameImage.TabStop = False
        '
        'P_Shadow_00
        '
        Me.P_Shadow_00.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.P_Shadow_00.Image = CType(resources.GetObject("P_Shadow_00.Image"), System.Drawing.Image)
        Me.P_Shadow_00.Location = New System.Drawing.Point(3, 86)
        Me.P_Shadow_00.Name = "P_Shadow_00"
        Me.P_Shadow_00.Size = New System.Drawing.Size(122, 122)
        Me.P_Shadow_00.TabIndex = 0
        Me.P_Shadow_00.TabStop = False
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
        Me.description.Size = New System.Drawing.Size(300, 240)
        Me.description.TabIndex = 0
        Me.description.Text = "N/A"
        Me.description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(400, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(416, 543)
        Me.MinimumSize = New System.Drawing.Size(416, 543)
        Me.Name = "Viewer"
        Me.Text = "eShop Metadata Viewer"
        Me.TopScreen.ResumeLayout(False)
        CType(Me.gameImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P_Shadow_00, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BottomScreen.ResumeLayout(False)
        Me.BottomScreen.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TopScreen As System.Windows.Forms.Panel
    Friend WithEvents BottomScreen As System.Windows.Forms.Panel
    Friend WithEvents gameImage As System.Windows.Forms.PictureBox
    Friend WithEvents P_Shadow_00 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents T_softTitle_01 As Label
    Friend WithEvents description As Label
End Class
