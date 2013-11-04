<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddingShipsStep1
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
        Me.Discription = New System.Windows.Forms.Label()
        Me.Display = New System.Windows.Forms.Panel()
        Me.NewFleet = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Discription
        '
        Me.Discription.AutoEllipsis = True
        Me.Discription.BackColor = System.Drawing.Color.SeaShell
        Me.Discription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Discription.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Discription.Location = New System.Drawing.Point(147, 10)
        Me.Discription.Margin = New System.Windows.Forms.Padding(3)
        Me.Discription.MaximumSize = New System.Drawing.Size(355, 150)
        Me.Discription.Name = "Discription"
        Me.Discription.Size = New System.Drawing.Size(343, 150)
        Me.Discription.TabIndex = 3
        '
        'Display
        '
        Me.Display.AutoScroll = True
        Me.Display.BackColor = System.Drawing.Color.IndianRed
        Me.Display.Location = New System.Drawing.Point(10, 10)
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(131, 117)
        Me.Display.TabIndex = 2
        '
        'NewFleet
        '
        Me.NewFleet.Location = New System.Drawing.Point(10, 133)
        Me.NewFleet.Name = "NewFleet"
        Me.NewFleet.Size = New System.Drawing.Size(66, 27)
        Me.NewFleet.TabIndex = 4
        Me.NewFleet.Text = "New Fleet"
        Me.NewFleet.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(84, 133)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(57, 27)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'AddingShipsStep1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(500, 170)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.NewFleet)
        Me.Controls.Add(Me.Discription)
        Me.Controls.Add(Me.Display)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddingShipsStep1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddingShips"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Discription As System.Windows.Forms.Label
    Friend WithEvents Display As System.Windows.Forms.Panel
    Friend WithEvents NewFleet As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
End Class
