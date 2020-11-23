<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ItemLayout
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
        Me.components = New System.ComponentModel.Container()
        Me.FlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel
        '
        Me.FlowLayoutPanel.Controls.Add(Me.PictureBox)
        Me.FlowLayoutPanel.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.FlowLayoutPanel.Location = New System.Drawing.Point(10, 0)
        Me.FlowLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel.Name = "FlowLayoutPanel"
        Me.FlowLayoutPanel.Size = New System.Drawing.Size(324, 521)
        Me.FlowLayoutPanel.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 309)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(224, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "$00.00"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 352)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Title"
        Me.ToolTip1.SetToolTip(Me.Label2, "Title")
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 388)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(224, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Description"
        Me.ToolTip1.SetToolTip(Me.Label3, "description")
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 420)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(224, 48)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Button
        '
        Me.Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button.FlatAppearance.BorderSize = 0
        Me.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button.ForeColor = System.Drawing.Color.White
        Me.Button.Location = New System.Drawing.Point(13, 0)
        Me.Button.Margin = New System.Windows.Forms.Padding(0)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(198, 48)
        Me.Button.TabIndex = 0
        Me.Button.Text = "Add to Cart"
        Me.Button.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Item"
        '
        'PictureBox
        '
        Me.PictureBox.Image = Global.ClumsyProofV7.My.Resources.Resources.iphone_11_PNG42
        Me.PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(304, 301)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox.TabIndex = 0
        Me.PictureBox.TabStop = False
        '
        'ItemLayout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.FlowLayoutPanel)
        Me.Margin = New System.Windows.Forms.Padding(3, 3, 3, 29)
        Me.Name = "ItemLayout"
        Me.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Size = New System.Drawing.Size(333, 531)
        Me.FlowLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents FlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button As Button
End Class

