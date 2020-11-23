<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CartItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        '   Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
     '   Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Delete = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ClumsyProofV7.My.Resources.Resources.iphone_11_PNG42

        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(223, 80)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(359, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(73, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Price"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ComboBox1.Location = New System.Drawing.Point(462, 3)
        Me.ComboBox1.MaxLength = 2
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(38, 21)
        Me.ComboBox1.TabIndex = 2
        '
        ''ShapeContainer1
        ''
        'Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        'Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        'Me.ShapeContainer1.Name = "ShapeContainer1"
        'Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        'Me.ShapeContainer1.Size = New System.Drawing.Size(518, 98)
        'Me.ShapeContainer1.TabIndex = 3
        'Me.ShapeContainer1.TabStop = False
        ''
        ''LineShape1
        ''
        'Me.LineShape1.BorderColor = System.Drawing.Color.LightGray
        'Me.LineShape1.Name = "LineShape1"
        'Me.LineShape1.X1 = 0
        'Me.LineShape1.X2 = 518
        'Me.LineShape1.Y1 = 0
        'Me.LineShape1.Y2 = 0
        '
        'Delete
        '
        Me.Delete.AutoSize = True
        Me.Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Delete.Location = New System.Drawing.Point(113, 82)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(38, 13)
        Me.Delete.TabIndex = 4
        Me.Delete.Text = "Delete"
        '
        'CartItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        ' Me.Controls.Add(Me.ShapeContainer1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "CartItem"
        Me.Size = New System.Drawing.Size(518, 98)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    '    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    '  Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents Delete As Label
End Class
