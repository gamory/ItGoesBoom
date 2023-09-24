<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BulletLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrassLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PowderLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrimerLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1256, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BulletLibraryToolStripMenuItem, Me.BrassLibraryToolStripMenuItem, Me.PowderLibraryToolStripMenuItem, Me.PrimerLibraryToolStripMenuItem, Me.LoadLibraryToolStripMenuItem, Me.LogsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'BulletLibraryToolStripMenuItem
        '
        Me.BulletLibraryToolStripMenuItem.Name = "BulletLibraryToolStripMenuItem"
        Me.BulletLibraryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BulletLibraryToolStripMenuItem.Text = "Bullet Library"
        '
        'BrassLibraryToolStripMenuItem
        '
        Me.BrassLibraryToolStripMenuItem.Name = "BrassLibraryToolStripMenuItem"
        Me.BrassLibraryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BrassLibraryToolStripMenuItem.Text = "Brass Library"
        '
        'PowderLibraryToolStripMenuItem
        '
        Me.PowderLibraryToolStripMenuItem.Name = "PowderLibraryToolStripMenuItem"
        Me.PowderLibraryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PowderLibraryToolStripMenuItem.Text = "Powder Library"
        '
        'PrimerLibraryToolStripMenuItem
        '
        Me.PrimerLibraryToolStripMenuItem.Name = "PrimerLibraryToolStripMenuItem"
        Me.PrimerLibraryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrimerLibraryToolStripMenuItem.Text = "Primer Library"
        '
        'LoadLibraryToolStripMenuItem
        '
        Me.LoadLibraryToolStripMenuItem.Name = "LoadLibraryToolStripMenuItem"
        Me.LoadLibraryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LoadLibraryToolStripMenuItem.Text = "Load Library"
        '
        'LogsToolStripMenuItem
        '
        Me.LogsToolStripMenuItem.Name = "LogsToolStripMenuItem"
        Me.LogsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogsToolStripMenuItem.Text = "Logs"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 635)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1256, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 657)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form_Main"
        Me.Text = "It Goes Boom - Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BulletLibraryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BrassLibraryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PowderLibraryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrimerLibraryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadLibraryToolStripMenuItem As ToolStripMenuItem
End Class
