<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tutorialWindow
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
        Me.NextInstruction = New System.Windows.Forms.Button()
        Me.PreviousInstruction = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NextInstruction
        '
        Me.NextInstruction.Location = New System.Drawing.Point(275, 231)
        Me.NextInstruction.Name = "NextInstruction"
        Me.NextInstruction.Size = New System.Drawing.Size(75, 23)
        Me.NextInstruction.TabIndex = 1
        Me.NextInstruction.Text = "Next"
        Me.NextInstruction.UseVisualStyleBackColor = True
        '
        'PreviousInstruction
        '
        Me.PreviousInstruction.Location = New System.Drawing.Point(100, 231)
        Me.PreviousInstruction.Name = "PreviousInstruction"
        Me.PreviousInstruction.Size = New System.Drawing.Size(75, 23)
        Me.PreviousInstruction.TabIndex = 2
        Me.PreviousInstruction.Text = "Previous"
        Me.PreviousInstruction.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbl)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 215)
        Me.Panel1.TabIndex = 3
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.BackColor = System.Drawing.SystemColors.Control
        Me.lbl.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(-1, 0)
        Me.lbl.MaximumSize = New System.Drawing.Size(411, 5000)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(45, 18)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "Label"
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tutorialWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 262)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PreviousInstruction)
        Me.Controls.Add(Me.NextInstruction)
        Me.MaximizeBox = False
        Me.Name = "tutorialWindow"
        Me.Text = "Tutorials"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NextInstruction As System.Windows.Forms.Button
    Friend WithEvents PreviousInstruction As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl As System.Windows.Forms.Label
End Class
