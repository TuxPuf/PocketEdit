Public Class Form1

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim r = MsgBox("Are you sure you want to close PocketEdit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Question")
        If r = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        AboutDialog.ShowDialog()
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tp As New EditTabPage
        TabControl1.TabPages.Add(tp)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tp As New EditTabPage
        TabControl1.TabPages.Add(tp)
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        Dim tp As New EditTabPage
        TabControl1.TabPages.Add(tp)
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Dim r = MsgBox("Are you sure you want to close the file?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Question")
        Try
            If r = MsgBoxResult.Yes Then
                TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)
            End If
        Catch
            MessageBox.Show("Cannot close tabs: tabcontrol is empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        OpenFileDialog1.ShowDialog()
        Dim tp As New EditTabPage(OpenFileDialog1.FileName)
        TabControl1.TabPages.Add(tp)
    End Sub

    Private Sub MenuItem12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        Try
            Dim stp As EditTabPage = CType(TabControl1.TabPages(TabControl1.SelectedIndex), EditTabPage)
            stp.Save()
        Catch ex As Exception
            MsgBox("Could not save file!")
        End Try
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        Try
            Dim stp As EditTabPage = CType(TabControl1.TabPages(TabControl1.SelectedIndex), EditTabPage)
            stp.Save()
        Catch ex As Exception
            MsgBox("Could not save file!")
        End Try
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        TextPaste()
    End Sub

    Sub TextPaste()
        Try
            Dim stp As EditTabPage = CType(TabControl1.TabPages(TabControl1.SelectedIndex), EditTabPage)
            stp.TextBox.Paste()
        Catch ex As Exception
        End Try
    End Sub

    Sub TextCopy()
        Try
            Dim stp As EditTabPage = CType(TabControl1.TabPages(TabControl1.SelectedIndex), EditTabPage)
            stp.TextBox.Copy()
        Catch ex As Exception
        End Try
    End Sub

    Sub TextCut()
        Try
            Dim stp As EditTabPage = CType(TabControl1.TabPages(TabControl1.SelectedIndex), EditTabPage)
            stp.TextBox.Cut()
        Catch ex As Exception
        End Try
    End Sub

    Sub TextSelAll()
        Try
            Dim stp As EditTabPage = CType(TabControl1.TabPages(TabControl1.SelectedIndex), EditTabPage)
            stp.TextBox.SelectAll()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        TextCopy()
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        TextCut()
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        TextCut()
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        TextCopy()
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        TextPaste()
    End Sub
End Class
