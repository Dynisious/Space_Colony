<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddingShipsStep2
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
        Me.NumFighters = New System.Windows.Forms.NumericUpDown()
        Me.NumDestroyers = New System.Windows.Forms.NumericUpDown()
        Me.NumFrigates = New System.Windows.Forms.NumericUpDown()
        Me.NumBombers = New System.Windows.Forms.NumericUpDown()
        Me.NumCruisers = New System.Windows.Forms.NumericUpDown()
        Me.NumDreadnoughts = New System.Windows.Forms.NumericUpDown()
        Me.lblFighters = New System.Windows.Forms.Label()
        Me.lblDestroyers = New System.Windows.Forms.Label()
        Me.lblFrigates = New System.Windows.Forms.Label()
        Me.lblBombers = New System.Windows.Forms.Label()
        Me.lblCruisers = New System.Windows.Forms.Label()
        Me.lblDreadnoughts = New System.Windows.Forms.Label()
        Me.lblCosts = New System.Windows.Forms.Label()
        Me.Accept = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        CType(Me.NumFighters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDestroyers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumFrigates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumBombers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCruisers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDreadnoughts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumFighters
        '
        Me.NumFighters.Location = New System.Drawing.Point(19, 19)
        Me.NumFighters.Margin = New System.Windows.Forms.Padding(10)
        Me.NumFighters.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumFighters.Name = "NumFighters"
        Me.NumFighters.Size = New System.Drawing.Size(77, 20)
        Me.NumFighters.TabIndex = 0
        '
        'NumDestroyers
        '
        Me.NumDestroyers.Location = New System.Drawing.Point(19, 139)
        Me.NumDestroyers.Margin = New System.Windows.Forms.Padding(10)
        Me.NumDestroyers.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumDestroyers.Name = "NumDestroyers"
        Me.NumDestroyers.Size = New System.Drawing.Size(77, 20)
        Me.NumDestroyers.TabIndex = 1
        '
        'NumFrigates
        '
        Me.NumFrigates.Location = New System.Drawing.Point(19, 99)
        Me.NumFrigates.Margin = New System.Windows.Forms.Padding(10)
        Me.NumFrigates.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumFrigates.Name = "NumFrigates"
        Me.NumFrigates.Size = New System.Drawing.Size(77, 20)
        Me.NumFrigates.TabIndex = 2
        '
        'NumBombers
        '
        Me.NumBombers.Location = New System.Drawing.Point(19, 59)
        Me.NumBombers.Margin = New System.Windows.Forms.Padding(10)
        Me.NumBombers.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumBombers.Name = "NumBombers"
        Me.NumBombers.Size = New System.Drawing.Size(77, 20)
        Me.NumBombers.TabIndex = 3
        '
        'NumCruisers
        '
        Me.NumCruisers.Location = New System.Drawing.Point(19, 179)
        Me.NumCruisers.Margin = New System.Windows.Forms.Padding(10)
        Me.NumCruisers.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumCruisers.Name = "NumCruisers"
        Me.NumCruisers.Size = New System.Drawing.Size(77, 20)
        Me.NumCruisers.TabIndex = 4
        '
        'NumDreadnoughts
        '
        Me.NumDreadnoughts.Location = New System.Drawing.Point(19, 219)
        Me.NumDreadnoughts.Margin = New System.Windows.Forms.Padding(10)
        Me.NumDreadnoughts.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumDreadnoughts.Name = "NumDreadnoughts"
        Me.NumDreadnoughts.Size = New System.Drawing.Size(77, 20)
        Me.NumDreadnoughts.TabIndex = 5
        '
        'lblFighters
        '
        Me.lblFighters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFighters.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFighters.Location = New System.Drawing.Point(109, 17)
        Me.lblFighters.Name = "lblFighters"
        Me.lblFighters.Size = New System.Drawing.Size(163, 20)
        Me.lblFighters.TabIndex = 6
        Me.lblFighters.Text = "Fighters: 0"
        Me.lblFighters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDestroyers
        '
        Me.lblDestroyers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDestroyers.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestroyers.Location = New System.Drawing.Point(109, 137)
        Me.lblDestroyers.Name = "lblDestroyers"
        Me.lblDestroyers.Size = New System.Drawing.Size(163, 20)
        Me.lblDestroyers.TabIndex = 7
        Me.lblDestroyers.Text = "Destroyers: 0"
        Me.lblDestroyers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFrigates
        '
        Me.lblFrigates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFrigates.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrigates.Location = New System.Drawing.Point(109, 97)
        Me.lblFrigates.Name = "lblFrigates"
        Me.lblFrigates.Size = New System.Drawing.Size(163, 20)
        Me.lblFrigates.TabIndex = 8
        Me.lblFrigates.Text = "Frigates: 0"
        Me.lblFrigates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBombers
        '
        Me.lblBombers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBombers.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBombers.Location = New System.Drawing.Point(109, 57)
        Me.lblBombers.Name = "lblBombers"
        Me.lblBombers.Size = New System.Drawing.Size(163, 20)
        Me.lblBombers.TabIndex = 9
        Me.lblBombers.Text = "Bombers: 0"
        Me.lblBombers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCruisers
        '
        Me.lblCruisers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCruisers.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCruisers.Location = New System.Drawing.Point(109, 179)
        Me.lblCruisers.Name = "lblCruisers"
        Me.lblCruisers.Size = New System.Drawing.Size(163, 20)
        Me.lblCruisers.TabIndex = 10
        Me.lblCruisers.Text = "Cruisers: 0"
        Me.lblCruisers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDreadnoughts
        '
        Me.lblDreadnoughts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDreadnoughts.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDreadnoughts.Location = New System.Drawing.Point(109, 217)
        Me.lblDreadnoughts.Name = "lblDreadnoughts"
        Me.lblDreadnoughts.Size = New System.Drawing.Size(163, 20)
        Me.lblDreadnoughts.TabIndex = 11
        Me.lblDreadnoughts.Text = "Dreadnoughts: 0"
        Me.lblDreadnoughts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCosts
        '
        Me.lblCosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCosts.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCosts.Location = New System.Drawing.Point(19, 249)
        Me.lblCosts.Name = "lblCosts"
        Me.lblCosts.Size = New System.Drawing.Size(253, 71)
        Me.lblCosts.TabIndex = 12
        Me.lblCosts.Text = "Resource: 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gas: 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ships: 0"
        Me.lblCosts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Accept
        '
        Me.Accept.Location = New System.Drawing.Point(34, 323)
        Me.Accept.Name = "Accept"
        Me.Accept.Size = New System.Drawing.Size(96, 23)
        Me.Accept.TabIndex = 13
        Me.Accept.Text = "Accept"
        Me.Accept.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(158, 323)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(96, 23)
        Me.Cancel.TabIndex = 14
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'AddingShipsStep2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 352)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Accept)
        Me.Controls.Add(Me.lblCosts)
        Me.Controls.Add(Me.lblDreadnoughts)
        Me.Controls.Add(Me.lblCruisers)
        Me.Controls.Add(Me.lblBombers)
        Me.Controls.Add(Me.lblFrigates)
        Me.Controls.Add(Me.lblDestroyers)
        Me.Controls.Add(Me.lblFighters)
        Me.Controls.Add(Me.NumDreadnoughts)
        Me.Controls.Add(Me.NumCruisers)
        Me.Controls.Add(Me.NumBombers)
        Me.Controls.Add(Me.NumFrigates)
        Me.Controls.Add(Me.NumDestroyers)
        Me.Controls.Add(Me.NumFighters)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddingShipsStep2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddingShipsStep2"
        CType(Me.NumFighters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDestroyers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumFrigates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumBombers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumCruisers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDreadnoughts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NumFighters As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumDestroyers As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumFrigates As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumBombers As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumCruisers As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumDreadnoughts As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblFighters As System.Windows.Forms.Label
    Friend WithEvents lblDestroyers As System.Windows.Forms.Label
    Friend WithEvents lblFrigates As System.Windows.Forms.Label
    Friend WithEvents lblBombers As System.Windows.Forms.Label
    Friend WithEvents lblCruisers As System.Windows.Forms.Label
    Friend WithEvents lblDreadnoughts As System.Windows.Forms.Label
    Friend WithEvents lblCosts As System.Windows.Forms.Label
    Friend WithEvents Accept As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
End Class
