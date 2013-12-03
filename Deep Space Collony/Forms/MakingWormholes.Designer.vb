<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MakingWormholes
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
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Discription = New System.Windows.Forms.Label()
        Me.Display = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(12, 140)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(115, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Close"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Discription
        '
        Me.Discription.AutoEllipsis = True
        Me.Discription.BackColor = System.Drawing.Color.SeaShell
        Me.Discription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Discription.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Discription.Location = New System.Drawing.Point(137, 12)
        Me.Discription.Margin = New System.Windows.Forms.Padding(3)
        Me.Discription.MaximumSize = New System.Drawing.Size(355, 150)
        Me.Discription.MinimumSize = New System.Drawing.Size(355, 150)
        Me.Discription.Name = "Discription"
        Me.Discription.Size = New System.Drawing.Size(355, 150)
        Me.Discription.TabIndex = 4
        '
        'Display
        '
        Me.Display.AutoScroll = True
        Me.Display.BackColor = System.Drawing.Color.IndianRed
        Me.Display.Location = New System.Drawing.Point(12, 12)
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(115, 122)
        Me.Display.TabIndex = 3
        '
        'ClosingWormholes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(506, 179)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Discription)
        Me.Controls.Add(Me.Display)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClosingWormholes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClosingWormholes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Discription As System.Windows.Forms.Label
    Friend WithEvents Display As System.Windows.Forms.Panel
End Class
