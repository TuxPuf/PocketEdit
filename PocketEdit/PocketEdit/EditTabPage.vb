Imports System.IO

Public Class EditTabPage
    Inherits TabPage

    Public TextBox As New FastColoredTextBoxNS.FastColoredTextBox

    Private savedfile As String = ""

    Public Sub New()
        InitialiseComponents()
    End Sub

    Public Sub New(ByVal filename As String)
        InitialiseComponents()
        Me.Text = Path.GetFileName(filename)
        Try
            If File.Exists(filename) Then
                Dim f As TextReader = New StreamReader(filename)
                TextBox.Text = f.ReadToEnd
                f.Dispose()
                f.Close()
            End If
        Catch
            MsgBox("Could not open file " & filename & "!")
        End Try
    End Sub

    Private Sub InitialiseComponents()
        Me.Text = "Untitled"
        TextBox.Dock = DockStyle.Fill
        TextBox.Text = ""
        TextBox.Language = FastColoredTextBoxNS.Language.Custom
        TextBox.WordWrap = True
        Me.Controls.Add(TextBox)
        TextBox.ContextMenu = Form1.ContextMenu1
    End Sub

    Public Sub Save()
        Try
            If savedfile = "" Then
                Dim sfd As New SaveFileDialog
                sfd.Filter = "All files (*.*)|*.*"
                sfd.ShowDialog()
                savedfile = sfd.FileName
                Me.Text = Path.GetFileName(savedfile)
                Dim f As TextWriter = New StreamWriter(savedfile)
                f.Write(TextBox.Text)
                f.Dispose()
                f.Close()
            Else
                Dim f As TextWriter = New StreamWriter(savedfile)
                f.Write(TextBox.Text)
                f.Dispose()
                f.Close()
            End If
        Catch ex As Exception
            MsgBox("Could not save file!")
        End Try
    End Sub
End Class
