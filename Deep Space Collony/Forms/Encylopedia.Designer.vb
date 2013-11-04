<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Encylopedia
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
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.Ships = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblShips = New System.Windows.Forms.Label()
        Me.Environments = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblEnvironments = New System.Windows.Forms.Label()
        Me.Factions = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblFactions = New System.Windows.Forms.Label()
        Me.Tabs.SuspendLayout()
        Me.Ships.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Environments.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Factions.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.Ships)
        Me.Tabs.Controls.Add(Me.Environments)
        Me.Tabs.Controls.Add(Me.Factions)
        Me.Tabs.Location = New System.Drawing.Point(10, 10)
        Me.Tabs.Margin = New System.Windows.Forms.Padding(1)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(564, 392)
        Me.Tabs.TabIndex = 0
        '
        'Ships
        '
        Me.Ships.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Ships.Controls.Add(Me.Panel1)
        Me.Ships.Location = New System.Drawing.Point(4, 22)
        Me.Ships.Name = "Ships"
        Me.Ships.Padding = New System.Windows.Forms.Padding(3)
        Me.Ships.Size = New System.Drawing.Size(556, 366)
        Me.Ships.TabIndex = 0
        Me.Ships.Text = "Ships"
        Me.Ships.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblShips)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(540, 350)
        Me.Panel1.TabIndex = 0
        '
        'lblShips
        '
        Me.lblShips.AutoSize = True
        Me.lblShips.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShips.Location = New System.Drawing.Point(-1, 0)
        Me.lblShips.MaximumSize = New System.Drawing.Size(521, 0)
        Me.lblShips.Name = "lblShips"
        Me.lblShips.Size = New System.Drawing.Size(55, 21)
        Me.lblShips.TabIndex = 0
        Me.lblShips.Text = "Label"
        '
        'Environments
        '
        Me.Environments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Environments.Controls.Add(Me.Panel2)
        Me.Environments.Location = New System.Drawing.Point(4, 22)
        Me.Environments.Name = "Environments"
        Me.Environments.Padding = New System.Windows.Forms.Padding(3)
        Me.Environments.Size = New System.Drawing.Size(556, 366)
        Me.Environments.TabIndex = 1
        Me.Environments.Text = "Environmets"
        Me.Environments.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblEnvironments)
        Me.Panel2.Location = New System.Drawing.Point(6, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(540, 350)
        Me.Panel2.TabIndex = 1
        '
        'lblEnvironments
        '
        Me.lblEnvironments.AutoSize = True
        Me.lblEnvironments.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnvironments.Location = New System.Drawing.Point(0, 0)
        Me.lblEnvironments.MaximumSize = New System.Drawing.Size(521, 5000)
        Me.lblEnvironments.Name = "lblEnvironments"
        Me.lblEnvironments.Size = New System.Drawing.Size(55, 21)
        Me.lblEnvironments.TabIndex = 1
        Me.lblEnvironments.Text = "Label"
        '
        'Factions
        '
        Me.Factions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Factions.Controls.Add(Me.Panel3)
        Me.Factions.Location = New System.Drawing.Point(4, 22)
        Me.Factions.Name = "Factions"
        Me.Factions.Padding = New System.Windows.Forms.Padding(3)
        Me.Factions.Size = New System.Drawing.Size(556, 366)
        Me.Factions.TabIndex = 2
        Me.Factions.Text = "Factions"
        Me.Factions.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblFactions)
        Me.Panel3.Location = New System.Drawing.Point(6, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(540, 350)
        Me.Panel3.TabIndex = 1
        '
        'lblFactions
        '
        Me.lblFactions.AutoSize = True
        Me.lblFactions.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactions.Location = New System.Drawing.Point(-1, 0)
        Me.lblFactions.MaximumSize = New System.Drawing.Size(521, 0)
        Me.lblFactions.Name = "lblFactions"
        Me.lblFactions.Size = New System.Drawing.Size(55, 21)
        Me.lblFactions.TabIndex = 0
        Me.lblFactions.Text = "Label"
        '
        'Encylopedia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 412)
        Me.Controls.Add(Me.Tabs)
        Me.MaximizeBox = False
        Me.Name = "Encylopedia"
        Me.Text = "Encylopedia"
        Me.Tabs.ResumeLayout(False)
        Me.Ships.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Environments.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Factions.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tabs As System.Windows.Forms.TabControl
    Friend WithEvents Ships As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblShips As System.Windows.Forms.Label
    Friend WithEvents Environments As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblEnvironments As System.Windows.Forms.Label
    Friend WithEvents Factions As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblFactions As System.Windows.Forms.Label
End Class
