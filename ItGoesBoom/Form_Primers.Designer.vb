<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Primers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Primers))
        Me.ComboBox_Company = New System.Windows.Forms.ComboBox()
        Me.Lbl_Company = New System.Windows.Forms.Label()
        Me.ComboBox_Model = New System.Windows.Forms.ComboBox()
        Me.Lbl_Model = New System.Windows.Forms.Label()
        Me.ComboBox_Type = New System.Windows.Forms.ComboBox()
        Me.Lbl_Type = New System.Windows.Forms.Label()
        Me.ComboBox_CupThickness = New System.Windows.Forms.ComboBox()
        Me.Lbl_CupThickness = New System.Windows.Forms.Label()
        Me.ComboBox_Inventory = New System.Windows.Forms.ComboBox()
        Me.Lbl_Inventory = New System.Windows.Forms.Label()
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
        'ComboBox_Type
        '
        Me.ComboBox_Type.FormattingEnabled = True
        Me.ComboBox_Type.Location = New System.Drawing.Point(266, 25)
        Me.ComboBox_Type.Name = "ComboBox_Type"
        Me.ComboBox_Type.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Type.TabIndex = 4
        '
        'Lbl_Type
        '
        Me.Lbl_Type.AutoSize = True
        Me.Lbl_Type.Location = New System.Drawing.Point(263, 9)
        Me.Lbl_Type.Name = "Lbl_Type"
        Me.Lbl_Type.Size = New System.Drawing.Size(31, 13)
        Me.Lbl_Type.TabIndex = 5
        Me.Lbl_Type.Text = "Type"
        '
        'ComboBox_CupThickness
        '
        Me.ComboBox_CupThickness.FormattingEnabled = True
        Me.ComboBox_CupThickness.Location = New System.Drawing.Point(393, 25)
        Me.ComboBox_CupThickness.Name = "ComboBox_CupThickness"
        Me.ComboBox_CupThickness.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_CupThickness.TabIndex = 6
        '
        'Lbl_CupThickness
        '
        Me.Lbl_CupThickness.AutoSize = True
        Me.Lbl_CupThickness.Location = New System.Drawing.Point(390, 9)
        Me.Lbl_CupThickness.Name = "Lbl_CupThickness"
        Me.Lbl_CupThickness.Size = New System.Drawing.Size(78, 13)
        Me.Lbl_CupThickness.TabIndex = 7
        Me.Lbl_CupThickness.Text = "Cup Thickness"
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
        'Form_Primers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lbl_Inventory)
        Me.Controls.Add(Me.ComboBox_Inventory)
        Me.Controls.Add(Me.Lbl_CupThickness)
        Me.Controls.Add(Me.ComboBox_CupThickness)
        Me.Controls.Add(Me.Lbl_Type)
        Me.Controls.Add(Me.ComboBox_Type)
        Me.Controls.Add(Me.Lbl_Model)
        Me.Controls.Add(Me.ComboBox_Model)
        Me.Controls.Add(Me.Lbl_Company)
        Me.Controls.Add(Me.ComboBox_Company)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Primers"
        Me.Text = "It Goes Boom - Primer Library"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox_Company As ComboBox
    Friend WithEvents Lbl_Company As Label
    Friend WithEvents ComboBox_Model As ComboBox
    Friend WithEvents Lbl_Model As Label
    Friend WithEvents ComboBox_Type As ComboBox
    Friend WithEvents Lbl_Type As Label
    Friend WithEvents ComboBox_CupThickness As ComboBox
    Friend WithEvents Lbl_CupThickness As Label
    Friend WithEvents ComboBox_Inventory As ComboBox
    Friend WithEvents Lbl_Inventory As Label
End Class
