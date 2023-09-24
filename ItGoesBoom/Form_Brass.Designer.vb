<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Brass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Brass))
        Me.ComboBox_Company = New System.Windows.Forms.ComboBox()
        Me.Lbl_Company = New System.Windows.Forms.Label()
        Me.ComboBox_Model = New System.Windows.Forms.ComboBox()
        Me.Lbl_Model = New System.Windows.Forms.Label()
        Me.ComboBox_Mass = New System.Windows.Forms.ComboBox()
        Me.Lbl_Mass = New System.Windows.Forms.Label()
        Me.ComboBox_Volume = New System.Windows.Forms.ComboBox()
        Me.Lbl_Volume = New System.Windows.Forms.Label()
        Me.ComboBox_Inventory = New System.Windows.Forms.ComboBox()
        Me.Lbl_Inventory = New System.Windows.Forms.Label()
        Me.LV_Selection = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'ComboBox_Company
        '
        Me.ComboBox_Company.FormattingEnabled = True
        Me.ComboBox_Company.Location = New System.Drawing.Point(12, 25)
        Me.ComboBox_Company.Name = "ComboBox_Company"
        Me.ComboBox_Company.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Company.TabIndex = 0
        '
        'Lbl_Company
        '
        Me.Lbl_Company.AutoSize = True
        Me.Lbl_Company.Location = New System.Drawing.Point(9, 9)
        Me.Lbl_Company.Name = "Lbl_Company"
        Me.Lbl_Company.Size = New System.Drawing.Size(51, 13)
        Me.Lbl_Company.TabIndex = 1
        Me.Lbl_Company.Text = "Company"
        '
        'ComboBox_Model
        '
        Me.ComboBox_Model.FormattingEnabled = True
        Me.ComboBox_Model.Location = New System.Drawing.Point(139, 25)
        Me.ComboBox_Model.Name = "ComboBox_Model"
        Me.ComboBox_Model.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Model.TabIndex = 2
        '
        'Lbl_Model
        '
        Me.Lbl_Model.AutoSize = True
        Me.Lbl_Model.Location = New System.Drawing.Point(136, 9)
        Me.Lbl_Model.Name = "Lbl_Model"
        Me.Lbl_Model.Size = New System.Drawing.Size(36, 13)
        Me.Lbl_Model.TabIndex = 3
        Me.Lbl_Model.Text = "Model"
        '
        'ComboBox_Mass
        '
        Me.ComboBox_Mass.FormattingEnabled = True
        Me.ComboBox_Mass.Location = New System.Drawing.Point(266, 25)
        Me.ComboBox_Mass.Name = "ComboBox_Mass"
        Me.ComboBox_Mass.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Mass.TabIndex = 4
        '
        'Lbl_Mass
        '
        Me.Lbl_Mass.AutoSize = True
        Me.Lbl_Mass.Location = New System.Drawing.Point(263, 9)
        Me.Lbl_Mass.Name = "Lbl_Mass"
        Me.Lbl_Mass.Size = New System.Drawing.Size(32, 13)
        Me.Lbl_Mass.TabIndex = 5
        Me.Lbl_Mass.Text = "Mass"
        '
        'ComboBox_Volume
        '
        Me.ComboBox_Volume.FormattingEnabled = True
        Me.ComboBox_Volume.Location = New System.Drawing.Point(393, 25)
        Me.ComboBox_Volume.Name = "ComboBox_Volume"
        Me.ComboBox_Volume.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Volume.TabIndex = 6
        '
        'Lbl_Volume
        '
        Me.Lbl_Volume.AutoSize = True
        Me.Lbl_Volume.Location = New System.Drawing.Point(390, 9)
        Me.Lbl_Volume.Name = "Lbl_Volume"
        Me.Lbl_Volume.Size = New System.Drawing.Size(42, 13)
        Me.Lbl_Volume.TabIndex = 7
        Me.Lbl_Volume.Text = "Volume"
        '
        'ComboBox_Inventory
        '
        Me.ComboBox_Inventory.FormattingEnabled = True
        Me.ComboBox_Inventory.Location = New System.Drawing.Point(520, 25)
        Me.ComboBox_Inventory.Name = "ComboBox_Inventory"
        Me.ComboBox_Inventory.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Inventory.TabIndex = 8
        '
        'Lbl_Inventory
        '
        Me.Lbl_Inventory.AutoSize = True
        Me.Lbl_Inventory.Location = New System.Drawing.Point(517, 9)
        Me.Lbl_Inventory.Name = "Lbl_Inventory"
        Me.Lbl_Inventory.Size = New System.Drawing.Size(51, 13)
        Me.Lbl_Inventory.TabIndex = 9
        Me.Lbl_Inventory.Text = "Inventory"
        '
        'LV_Selection
        '
        Me.LV_Selection.HideSelection = False
        Me.LV_Selection.Location = New System.Drawing.Point(12, 52)
        Me.LV_Selection.Name = "LV_Selection"
        Me.LV_Selection.Size = New System.Drawing.Size(121, 527)
        Me.LV_Selection.TabIndex = 10
        Me.LV_Selection.UseCompatibleStateImageBehavior = False
        '
        'Form_Brass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 591)
        Me.Controls.Add(Me.LV_Selection)
        Me.Controls.Add(Me.Lbl_Inventory)
        Me.Controls.Add(Me.ComboBox_Inventory)
        Me.Controls.Add(Me.Lbl_Volume)
        Me.Controls.Add(Me.ComboBox_Volume)
        Me.Controls.Add(Me.Lbl_Mass)
        Me.Controls.Add(Me.ComboBox_Mass)
        Me.Controls.Add(Me.Lbl_Model)
        Me.Controls.Add(Me.ComboBox_Model)
        Me.Controls.Add(Me.Lbl_Company)
        Me.Controls.Add(Me.ComboBox_Company)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Brass"
        Me.Text = "It Goes Boom - Brass Library"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox_Company As ComboBox
    Friend WithEvents Lbl_Company As Label
    Friend WithEvents ComboBox_Model As ComboBox
    Friend WithEvents Lbl_Model As Label
    Friend WithEvents ComboBox_Mass As ComboBox
    Friend WithEvents Lbl_Mass As Label
    Friend WithEvents ComboBox_Volume As ComboBox
    Friend WithEvents Lbl_Volume As Label
    Friend WithEvents ComboBox_Inventory As ComboBox
    Friend WithEvents Lbl_Inventory As Label
    Friend WithEvents LV_Selection As ListView
End Class
