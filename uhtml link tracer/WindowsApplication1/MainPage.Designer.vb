<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.PreviewLinkWithInBuiltBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyLinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAllToFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AscendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.ExtMetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.FilesListBox1 = New System.Windows.Forms.ListBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.NameMetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.AndWindRadioButton1 = New MetroFramework.Controls.MetroRadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.JavaRadioButton1 = New MetroFramework.Controls.MetroRadioButton()
        Me.ExtProcLabel1 = New System.Windows.Forms.Label()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.Spinner1 = New MetroFramework.Controls.MetroProgressSpinner()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SlidePanel1 = New MetroFramework.Controls.MetroPanel()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.MetroToggle1 = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroContextMenu1.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SlidePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.MetroStyleExtender1.SetApplyMetroTheme(Me.ListView1, True)
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.ContextMenuStrip = Me.MetroContextMenu1
        Me.ListView1.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HotTracking = True
        Me.ListView1.HoverSelection = True
        Me.ListView1.Location = New System.Drawing.Point(16, 91)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(570, 40)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Qualifier Name"
        Me.ColumnHeader1.Width = 185
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Web Source"
        Me.ColumnHeader2.Width = 550
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroContextMenu1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreviewLinkWithInBuiltBrowserToolStripMenuItem, Me.OpenToolStripMenuItem, Me.CopyLinkToolStripMenuItem, Me.SaveAllToFileToolStripMenuItem, Me.SortToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(251, 136)
        '
        'PreviewLinkWithInBuiltBrowserToolStripMenuItem
        '
        Me.PreviewLinkWithInBuiltBrowserToolStripMenuItem.Name = "PreviewLinkWithInBuiltBrowserToolStripMenuItem"
        Me.PreviewLinkWithInBuiltBrowserToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.PreviewLinkWithInBuiltBrowserToolStripMenuItem.Text = "Preview link with in-built browser"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.OpenToolStripMenuItem.Text = "Open in default browser"
        '
        'CopyLinkToolStripMenuItem
        '
        Me.CopyLinkToolStripMenuItem.Name = "CopyLinkToolStripMenuItem"
        Me.CopyLinkToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.CopyLinkToolStripMenuItem.Text = "Copy link"
        '
        'SaveAllToFileToolStripMenuItem
        '
        Me.SaveAllToFileToolStripMenuItem.Name = "SaveAllToFileToolStripMenuItem"
        Me.SaveAllToFileToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.SaveAllToFileToolStripMenuItem.Text = "Save all to file"
        '
        'SortToolStripMenuItem
        '
        Me.SortToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AscendingToolStripMenuItem, Me.DescendingToolStripMenuItem})
        Me.SortToolStripMenuItem.Name = "SortToolStripMenuItem"
        Me.SortToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.SortToolStripMenuItem.Text = "Sort"
        '
        'AscendingToolStripMenuItem
        '
        Me.AscendingToolStripMenuItem.Name = "AscendingToolStripMenuItem"
        Me.AscendingToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.AscendingToolStripMenuItem.Text = "Ascending"
        '
        'DescendingToolStripMenuItem
        '
        Me.DescendingToolStripMenuItem.Name = "DescendingToolStripMenuItem"
        Me.DescendingToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.DescendingToolStripMenuItem.Text = "Descending"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'MetroButton1
        '
        Me.MetroButton1.Highlight = True
        Me.MetroButton1.Location = New System.Drawing.Point(23, 99)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(158, 23)
        Me.MetroButton1.TabIndex = 0
        Me.MetroButton1.Text = "Open .uhtml files"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.ExtMetroLabel2)
        Me.MetroPanel1.Controls.Add(Me.FilesListBox1)
        Me.MetroPanel1.Controls.Add(Me.MetroButton2)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(23, 128)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(158, 317)
        Me.MetroPanel1.TabIndex = 1
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'ExtMetroLabel2
        '
        Me.ExtMetroLabel2.AutoSize = True
        Me.ExtMetroLabel2.Location = New System.Drawing.Point(14, 249)
        Me.ExtMetroLabel2.Name = "ExtMetroLabel2"
        Me.ExtMetroLabel2.Size = New System.Drawing.Size(120, 19)
        Me.ExtMetroLabel2.TabIndex = 3
        Me.ExtMetroLabel2.Text = "-- Extension Found"
        '
        'FilesListBox1
        '
        Me.FilesListBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FilesListBox1.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.FilesListBox1.FormattingEnabled = True
        Me.FilesListBox1.Location = New System.Drawing.Point(0, 0)
        Me.FilesListBox1.Name = "FilesListBox1"
        Me.FilesListBox1.Size = New System.Drawing.Size(158, 238)
        Me.FilesListBox1.TabIndex = 3
        '
        'MetroButton2
        '
        Me.MetroButton2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroButton2.Location = New System.Drawing.Point(0, 280)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(158, 37)
        Me.MetroButton2.TabIndex = 5
        Me.MetroButton2.Text = "Convert to html"
        Me.MetroButton2.UseSelectable = True
        '
        'NameMetroLabel1
        '
        Me.NameMetroLabel1.AutoSize = True
        Me.NameMetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.NameMetroLabel1.Location = New System.Drawing.Point(23, 51)
        Me.NameMetroLabel1.Name = "NameMetroLabel1"
        Me.NameMetroLabel1.Size = New System.Drawing.Size(73, 19)
        Me.NameMetroLabel1.TabIndex = 2
        Me.NameMetroLabel1.Text = "--Selection"
        Me.NameMetroLabel1.UseStyleColors = True
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.MetroButton5)
        Me.MetroPanel2.Controls.Add(Me.ListView1)
        Me.MetroPanel2.Controls.Add(Me.MetroButton4)
        Me.MetroPanel2.Controls.Add(Me.AndWindRadioButton1)
        Me.MetroPanel2.Controls.Add(Me.PictureBox1)
        Me.MetroPanel2.Controls.Add(Me.JavaRadioButton1)
        Me.MetroPanel2.Controls.Add(Me.ExtProcLabel1)
        Me.MetroPanel2.Controls.Add(Me.MetroButton3)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(196, 99)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(610, 346)
        Me.MetroPanel2.TabIndex = 4
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'MetroButton5
        '
        Me.MetroButton5.Location = New System.Drawing.Point(536, 12)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(59, 31)
        Me.MetroButton5.TabIndex = 6
        Me.MetroButton5.Text = "Reset"
        Me.MetroButton5.UseSelectable = True
        '
        'MetroButton4
        '
        Me.MetroButton4.Enabled = False
        Me.MetroButton4.Highlight = True
        Me.MetroButton4.Location = New System.Drawing.Point(406, 12)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(115, 31)
        Me.MetroButton4.TabIndex = 4
        Me.MetroButton4.Text = "Save to file"
        Me.MetroButton4.UseSelectable = True
        '
        'AndWindRadioButton1
        '
        Me.AndWindRadioButton1.AutoSize = True
        Me.AndWindRadioButton1.Checked = True
        Me.AndWindRadioButton1.Location = New System.Drawing.Point(235, 23)
        Me.AndWindRadioButton1.Name = "AndWindRadioButton1"
        Me.AndWindRadioButton1.Size = New System.Drawing.Size(147, 15)
        Me.AndWindRadioButton1.TabIndex = 3
        Me.AndWindRadioButton1.TabStop = True
        Me.AndWindRadioButton1.Text = "UC - Android/Windows"
        Me.AndWindRadioButton1.UseSelectable = True
        Me.AndWindRadioButton1.UseStyleColors = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.uhtmlLinkTracer.My.Resources.Resources.dragIcon
        Me.PictureBox1.Location = New System.Drawing.Point(280, 170)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'JavaRadioButton1
        '
        Me.JavaRadioButton1.AutoSize = True
        Me.JavaRadioButton1.Location = New System.Drawing.Point(146, 23)
        Me.JavaRadioButton1.Name = "JavaRadioButton1"
        Me.JavaRadioButton1.Size = New System.Drawing.Size(72, 15)
        Me.JavaRadioButton1.TabIndex = 3
        Me.JavaRadioButton1.Text = "UC - Java"
        Me.JavaRadioButton1.UseSelectable = True
        Me.JavaRadioButton1.UseStyleColors = True
        '
        'ExtProcLabel1
        '
        Me.ExtProcLabel1.AutoSize = True
        Me.ExtProcLabel1.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.ExtProcLabel1.ForeColor = System.Drawing.Color.Gray
        Me.ExtProcLabel1.Location = New System.Drawing.Point(16, 56)
        Me.ExtProcLabel1.Name = "ExtProcLabel1"
        Me.ExtProcLabel1.Size = New System.Drawing.Size(92, 13)
        Me.ExtProcLabel1.TabIndex = 8
        Me.ExtProcLabel1.Text = "--Extraction Status"
        '
        'MetroButton3
        '
        Me.MetroButton3.Enabled = False
        Me.MetroButton3.Highlight = True
        Me.MetroButton3.Location = New System.Drawing.Point(16, 12)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(115, 31)
        Me.MetroButton3.TabIndex = 1
        Me.MetroButton3.Text = "Extract the links !"
        Me.MetroButton3.UseSelectable = True
        '
        'Spinner1
        '
        Me.Spinner1.Location = New System.Drawing.Point(758, 22)
        Me.Spinner1.Maximum = 100
        Me.Spinner1.Name = "Spinner1"
        Me.Spinner1.Size = New System.Drawing.Size(58, 48)
        Me.Spinner1.Speed = 2.0!
        Me.Spinner1.TabIndex = 9
        Me.Spinner1.UseSelectable = True
        Me.Spinner1.Value = 20
        Me.Spinner1.Visible = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.AddExtension = False
        Me.SaveFileDialog1.DefaultExt = "txt"
        Me.SaveFileDialog1.SupportMultiDottedExtensions = True
        Me.SaveFileDialog1.Title = "Save extracted links..."
        '
        'SlidePanel1
        '
        Me.SlidePanel1.Controls.Add(Me.WebBrowser1)
        Me.SlidePanel1.HorizontalScrollbarBarColor = True
        Me.SlidePanel1.HorizontalScrollbarHighlightOnWheel = True
        Me.SlidePanel1.HorizontalScrollbarSize = 10
        Me.SlidePanel1.Location = New System.Drawing.Point(830, 98)
        Me.SlidePanel1.Name = "SlidePanel1"
        Me.SlidePanel1.Size = New System.Drawing.Size(791, 350)
        Me.SlidePanel1.TabIndex = 11
        Me.SlidePanel1.UseStyleColors = True
        Me.SlidePanel1.VerticalScrollbarBarColor = True
        Me.SlidePanel1.VerticalScrollbarHighlightOnWheel = False
        Me.SlidePanel1.VerticalScrollbarSize = 10
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(791, 350)
        Me.WebBrowser1.TabIndex = 2
        '
        'MetroToggle1
        '
        Me.MetroToggle1.AutoSize = True
        Me.MetroToggle1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroToggle1.Location = New System.Drawing.Point(726, 76)
        Me.MetroToggle1.Name = "MetroToggle1"
        Me.MetroToggle1.Size = New System.Drawing.Size(80, 17)
        Me.MetroToggle1.TabIndex = 7
        Me.MetroToggle1.Text = "Off"
        Me.MetroToggle1.ThreeState = True
        Me.MetroToggle1.UseSelectable = True
        Me.MetroToggle1.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.Location = New System.Drawing.Point(674, 74)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel1.TabIndex = 14
        Me.MetroLabel1.Text = "Browser"
        Me.MetroLabel1.UseStyleColors = True
        '
        'MainPage
        '
        Me.AcceptButton = Me.MetroButton1
        Me.ApplyImageInvert = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(830, 465)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroToggle1)
        Me.Controls.Add(Me.SlidePanel1)
        Me.Controls.Add(Me.NameMetroLabel1)
        Me.Controls.Add(Me.Spinner1)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.MetroButton1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(830, 465)
        Me.Name = "MainPage"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Style = MetroFramework.MetroColorStyle.[Default]
        Me.Text = ".uhtml Link Tracer"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SlidePanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FilesListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents NameMetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ExtMetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ExtProcLabel1 As System.Windows.Forms.Label
    Friend WithEvents Spinner1 As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents AndWindRadioButton1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents JavaRadioButton1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MetroButton5 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyLinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAllToFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SortToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AscendingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescendingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents PreviewLinkWithInBuiltBrowserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SlidePanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents MetroToggle1 As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel

End Class
