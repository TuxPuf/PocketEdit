<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem21)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        '
        'MenuItem21
        '
        Me.MenuItem21.Text = "&New"
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.MenuItem2)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem3)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem6)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem7)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem11)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem12)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem13)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem14)
        Me.MenuItem1.Text = "&Menu"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "E&xit"
        '
        'MenuItem3
        '
        Me.MenuItem3.Text = "-"
        '
        'MenuItem6
        '
        Me.MenuItem6.Text = "&About..."
        '
        'MenuItem7
        '
        Me.MenuItem7.MenuItems.Add(Me.MenuItem8)
        Me.MenuItem7.MenuItems.Add(Me.MenuItem9)
        Me.MenuItem7.MenuItems.Add(Me.MenuItem10)
        Me.MenuItem7.Text = "&Edit"
        '
        'MenuItem8
        '
        Me.MenuItem8.Text = "&Cut"
        '
        'MenuItem9
        '
        Me.MenuItem9.Text = "&Copy"
        '
        'MenuItem10
        '
        Me.MenuItem10.Text = "&Paste"
        '
        'MenuItem11
        '
        Me.MenuItem11.Text = "-"
        '
        'MenuItem12
        '
        Me.MenuItem12.Text = "&Save"
        '
        'MenuItem13
        '
        Me.MenuItem13.Text = "&Open"
        '
        'MenuItem14
        '
        Me.MenuItem14.Text = "&Close"
        '
        'TabControl1
        '
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(240, 268)
        Me.TabControl1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "All files (*.*)|*.*"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.Add(Me.MenuItem15)
        Me.ContextMenu1.MenuItems.Add(Me.MenuItem16)
        Me.ContextMenu1.MenuItems.Add(Me.MenuItem17)
        Me.ContextMenu1.MenuItems.Add(Me.MenuItem22)
        Me.ContextMenu1.MenuItems.Add(Me.MenuItem23)
        '
        'MenuItem15
        '
        Me.MenuItem15.Text = "&Cut"
        '
        'MenuItem16
        '
        Me.MenuItem16.Text = "&Copy"
        '
        'MenuItem17
        '
        Me.MenuItem17.Text = "&Paste"
        '
        'MenuItem22
        '
        Me.MenuItem22.Text = "-"
        '
        'MenuItem23
        '
        Me.MenuItem23.Text = "&Save"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = "PocketEdit"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem

End Class
