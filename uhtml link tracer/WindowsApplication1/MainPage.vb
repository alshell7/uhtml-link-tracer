Imports System.Text.RegularExpressions
Imports MetroFramework

Public Class MainPage
    Inherits MetroFramework.Forms.MetroForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StyleManager = MetroStyleManager1
        Me.MetroStyleExtender1.StyleManager = MetroStyleManager1
        ' WebBrowser1.Navigate(Environment.GetFolderPath(Environment.SpecialFolder.NetworkShortcuts))
        WebBrowser1.Navigate("http:\\www.msdn.com\")

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Spinner1.Visible = True
        OpenFileDialog1.Filter = _
                "Uhtml files (*.uhtml)|*.uhtml|" & _
                "All files|*.*"
        Try
            
            OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Recent)
        Catch ex As Exception
        End Try
        If MetroMessageBox.Show(Me, "Do you wish to select multiple saved pages ?", "Loading .uhtml files in ...", MessageBoxButtons.YesNo, MessageBoxIcon.None) = Windows.Forms.DialogResult.Yes Then

            OpenFileDialog1.Multiselect = True
        Else
            OpenFileDialog1.Multiselect = False
        End If
        OpenFileDialog1.ShowDialog()

        FilesListBox1.DataSource = OpenFileDialog1.FileNames
        
        Spinner1.Visible = False
        MetroButton3.Enabled = True

    End Sub

    Private Sub FilesListBox1_DoubleClick(sender As Object, e As EventArgs) Handles FilesListBox1.DoubleClick
        Try
            Process.Start(System.IO.Path.GetDirectoryName(FilesListBox1.SelectedItem))
        Catch ex As Exception
        End Try
    End Sub


    Private Sub FilesListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilesListBox1.SelectedIndexChanged
        Try

            Dim fInfo As New System.IO.FileInfo(FilesListBox1.SelectedItem)
            NameMetroLabel1.Text = System.IO.Path.GetFileNameWithoutExtension(FilesListBox1.SelectedItem) & vbCrLf & fInfo.LastWriteTimeUtc.ToString

            ExtMetroLabel2.Text = String.Format("Extension : {0}", System.IO.Path.GetExtension(FilesListBox1.SelectedItem))
        Catch ex As Exception

        End Try
        'ExtMetroLabel2.Text = String.Format("Extension : {0}", fInfo.CreationTime.ToString)
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click        
        Dim Downloadfile As String = Nothing
        Dim objListViewItem As New ListViewItem
        Try

            For Each objListViewItem In ListView1.Items
                Downloadfile = objListViewItem.SubItems(1).Text
                My.Computer.Network.DownloadFile(Downloadfile, "C:\Users\" & Environment.UserName & "\Desktop\" & objListViewItem.Text)
                MetroMessageBox.Show(Me, "Downloaded and saved on desktop - " & Downloadfile, "Downloading completing !", MessageBoxButtons.OK, MessageBoxIcon.None)
            Next
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.None)
        End Try
    End Sub

    Dim LPos As Integer = 0
    Dim SPos As Integer = 34 - 1
    Dim Anime As New MetroFramework.Animation.ExpandAnimation
    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Me.Cursor = Cursors.AppStarting
        Me.Opacity = 0.8F

        MetroButton4.Enabled = True
        
        dass.Start(PictureBox1, New Point(520, 260), Animation.TransitionType.EaseInQuad, 30)

        ListView1.Visible = False
        ListView1.Size = New Size(280, 0)
        
        If ListView1.Items.Count = 0 Then
        Else
            If MetroMessageBox.Show(Me, "Do you wish to over-write the current extracted data to the enumerated field ?", "Over - write data ", MessageBoxButtons.YesNo, MessageBoxIcon.None) = Windows.Forms.DialogResult.Yes Then
            Else
                ListView1.Items.Clear()
            End If
        End If
        Dim rtf As New Windows.Forms.RichTextBox
        Dim expression As New Regex("") 'Ole object,. not visible.

        For Each file In FilesListBox1.Items
            'check the valid file extension
            If System.IO.Path.GetExtension(file) = ".uhtml" Then

                If JavaRadioButton1.Checked = True Then
                    SPos = 34 - 5
                End If
                'load new uhtml
                rtf.LoadFile(file, RichTextBoxStreamType.PlainText)
                Dim m As Match = expression.Match(rtf.Text)
                'Note the value of last character minus 1, to get exact location
                If m.Success Then
                    LPos = m.Index - 1
                End If
                'Select/extract the link from specified index's
                rtf.Select(SPos, LPos)
                Dim ExtractedLink As String = rtf.SelectedText
                'Save the extracted link

                Dim objListViewItem As New ListViewItem
                objListViewItem.Text = System.IO.Path.GetFileNameWithoutExtension(file)
                If String.IsNullOrEmpty(ExtractedLink) = True Then
                    objListViewItem.SubItems.Add("---Corrupted File/Link---")
                Else
                    If JavaRadioButton1.Checked = True Then
                        objListViewItem.SubItems.Add(ExtractedLink.Remove(ExtractedLink.Length - 31, 31))
                    Else
                        objListViewItem.SubItems.Add(ExtractedLink.Remove(ExtractedLink.Length - 33, 33))
                    End If

                End If

                ListView1.Items.Add(objListViewItem)
                ListView1.Refresh()
                ListView1.Update()
                ' Threading.Thread.Sleep(100)
                ExtProcLabel1.Text = String.Format("Proccessing - {0} out of {1}." & vbCrLf & objListViewItem.Text, ListView1.Items.Count, FilesListBox1.Items.Count)
                Me.Refresh()
                'InitializeComponent()
                LPos = 0
                SPos = 34 - 1
            Else
                ListView1.Items.Add("Invalid .uhtml file !")
            End If
        Next
        ExtProcLabel1.Text = String.Format("Proccessing - {0} out of {1}." & vbCrLf & "Done !", ListView1.Items.Count, FilesListBox1.Items.Count)
        ListView1.Visible = True
        Anime.Start(ListView1, New Size(570, 240), Animation.TransitionType.EaseInCubic, 30)

       
        Me.Cursor = Cursors.Arrow
        Me.Opacity = 1.0F
        'MetroFramework.Forms.MetroTaskWindow.ShowTaskWindow(Me, "Extraction completed !", New Panel, 3)

        MsgBox("Extraction Completed !", MsgBoxStyle.Information, Title:=".uhtml link tracer")

        If MetroMessageBox.Show(Me, "Do you wish to save the extracted data to a text file ?", "Save ... ", MessageBoxButtons.YesNo, MessageBoxIcon.None) = Windows.Forms.DialogResult.Yes Then
            Save()
        Else
            'ListView1.Items.Clear()
        End If
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click

        Save()

    End Sub

    Public Sub Save()
        Try
            SaveFileDialog1.Filter = _
                "Text files (*.txt)|*.txt|" & _
                "All files|*.*"

            SaveFileDialog1.ShowDialog()
            SaveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Dim Data As String = Nothing
            Dim objListViewItem As New ListViewItem
            For Each objListViewItem In ListView1.Items

                'Dim absString = Nothing

                'absString = objListViewItem.SubItems(1).Text.Remove(objListViewItem.SubItems(1).Text.Length - 33, 33)

                Data = Data & String.Format("{0}" & vbCrLf & "{1}" & vbCrLf & vbCrLf, ">> " & objListViewItem.Text.ToUpper(), objListViewItem.SubItems(1).Text)

            Next
            Dim CompleteData As String = ".uhtml extracted links - " & Date.Now.ToString() & vbCrLf & vbCrLf & Data & vbCrLf & vbCrLf & "-      alshell7 corporation."
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, CompleteData, False)
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Try
            Dim objlistvwitm As New ListViewItem
            objlistvwitm = ListView1.SelectedItems.Item(0)
            'MsgBox(objlistvwitm.SubItems(1).Text, MsgBoxStyle.Information)

            Process.Start(objlistvwitm.SubItems(1).Text)
        Catch ex As Exception

        End Try

    End Sub
    Dim dass As New MetroFramework.Animation.MoveAnimation
	
    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        MetroButton3.Enabled = False

        '  ListView1.Size = New Size(0, 280)
        FilesListBox1.DataSource = Nothing
        'Me.Controls.Clear()
        'InitializeComponent()
        'Me.Refresh()
        ExtProcLabel1.Text = "--Extraction Status"
        NameMetroLabel1.Text = "--Selection"
        ExtMetroLabel2.Text = "-- Extension Found"
        ListView1.Items.Clear()
        Anime.Start(ListView1, New Size(570, 40), Animation.TransitionType.EaseInExpo, 30)

        dass.Start(PictureBox1, New Point(280, 170), Animation.TransitionType.EaseOutCubic, 10)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MetroMessageBox.Show(Me, My.Application.Info.ProductName & vbCrLf & My.Application.Info.Version.ToString() & vbCrLf & "Created by Alshell7 Corporation" & vbCrLf & vbCrLf & Environment.CurrentDirectory & vbCrLf, "About", MessageBoxButtons.OK, MessageBoxIcon.None)

    End Sub

    Private Sub CopyLinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyLinkToolStripMenuItem.Click
        Try
            Dim objlistvwitm As New ListViewItem
            objlistvwitm = ListView1.SelectedItems.Item(0)
            'MsgBox(objlistvwitm.SubItems(1).Text, MsgBoxStyle.Information)

            My.Computer.Clipboard.SetText(objlistvwitm.SubItems(1).Text)
        Catch ex As Exception

        End Try
    End Sub

  
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            Dim objlistvwitm As New ListViewItem
            objlistvwitm = ListView1.SelectedItems.Item(0)            
            Process.Start(objlistvwitm.SubItems(1).Text)

        Catch ex As Exception

        End Try
    End Sub
    
    Private Sub SaveAllToFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAllToFileToolStripMenuItem.Click
        Save()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ListView1.Items.Clear()
        Anime.Start(ListView1, New Size(570, 40), Animation.TransitionType.EaseInExpo, 10)

        dass.Start(PictureBox1, New Point(280, 170), Animation.TransitionType.EaseOutCubic, 30)
    End Sub

    Private Sub AscendingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AscendingToolStripMenuItem.Click
        ListView1.Sorting = SortOrder.Ascending

    End Sub

    Private Sub DescendingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescendingToolStripMenuItem.Click
        ListView1.Sorting = SortOrder.Descending
    End Sub
  
    Private Sub PreviewLinkWithInBuiltBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviewLinkWithInBuiltBrowserToolStripMenuItem.Click
        Try
            Dim objlistvwitm As New ListViewItem
            objlistvwitm = ListView1.SelectedItems.Item(0)
            'MsgBox(objlistvwitm.SubItems(1).Text, MsgBoxStyle.Information)
            WebBrowser1.Navigate(objlistvwitm.SubItems(1).Text)
            MetroToggle1.Checked = True

            SlidePanel1.Visible = True
            'dass.Start(SlidePanel1, New Point(812, 84), Animation.TransitionType.EaseInQuad, 30) 'to 16, 99
            dass.Start(SlidePanel1, New Point(16, 98), Animation.TransitionType.EaseInQuad, 30) 'to 16, 99

        Catch ex As Exception

        End Try
    End Sub

    Private Sub MetroToggle1_CheckedChanged(sender As Object, e As EventArgs) Handles MetroToggle1.CheckedChanged
        SlidePanel1.Visible = True
        If SlidePanel1.Location.X = 16 Then
            dass.Start(SlidePanel1, New Point(830, 98), Animation.TransitionType.EaseInOutCubic, 30) 'to 16, 99
        ElseIf SlidePanel1.Location.X = 830 Then
            dass.Start(SlidePanel1, New Point(16, 98), Animation.TransitionType.EaseInOutQuad, 30) 'to 16, 99
            MetroToggle1.Checked = True
        End If
    End Sub

End Class
Public Class Taskcontrol
    Inherits UserControl
    
End Class
