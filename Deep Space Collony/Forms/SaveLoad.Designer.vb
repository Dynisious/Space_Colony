<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveLoad
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSaveLoad = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSave3 = New System.Windows.Forms.Label()
        Me.lblSave2 = New System.Windows.Forms.Label()
        Me.lblSave1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(334, 273)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(246, 53)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSaveLoad
        '
        Me.btnSaveLoad.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveLoad.Location = New System.Drawing.Point(12, 273)
        Me.btnSaveLoad.Name = "btnSaveLoad"
        Me.btnSaveLoad.Size = New System.Drawing.Size(246, 53)
        Me.btnSaveLoad.TabIndex = 1
        Me.btnSaveLoad.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblSave3)
        Me.Panel1.Controls.Add(Me.lblSave2)
        Me.Panel1.Controls.Add(Me.lblSave1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 232)
        Me.Panel1.TabIndex = 2
        '
        'lblSave3
        '
        Me.lblSave3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSave3.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSave3.Location = New System.Drawing.Point(157, 167)
        Me.lblSave3.Name = "lblSave3"
        Me.lblSave3.Size = New System.Drawing.Size(260, 40)
        Me.lblSave3.TabIndex = 2
        Me.lblSave3.Text = "Save File 3"
        Me.lblSave3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSave2
        '
        Me.lblSave2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSave2.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSave2.Location = New System.Drawing.Point(157, 95)
        Me.lblSave2.Name = "lblSave2"
        Me.lblSave2.Size = New System.Drawing.Size(260, 40)
        Me.lblSave2.TabIndex = 1
        Me.lblSave2.Text = "Save File 2"
        Me.lblSave2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSave1
        '
        Me.lblSave1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSave1.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSave1.Location = New System.Drawing.Point(157, 18)
        Me.lblSave1.Name = "lblSave1"
        Me.lblSave1.Size = New System.Drawing.Size(260, 40)
        Me.lblSave1.TabIndex = 0
        Me.lblSave1.Text = "Save File 1"
        Me.lblSave1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(188, 247)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(217, 23)
        Me.lblName.TabIndex = 3
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SaveLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 338)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSaveLoad)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SaveLoad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SaveLoad"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSaveLoad As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblSave3 As System.Windows.Forms.Label
    Friend WithEvents lblSave2 As System.Windows.Forms.Label
    Friend WithEvents lblSave1 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
End Class
