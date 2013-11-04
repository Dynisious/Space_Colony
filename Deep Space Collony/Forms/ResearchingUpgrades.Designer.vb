<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResearchingUpgrades
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.InfoDisplay = New System.Windows.Forms.Label()
        Me.StartResearch = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.UpgradePanel = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.InfoDisplay)
        Me.Panel1.Location = New System.Drawing.Point(525, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(278, 305)
        Me.Panel1.TabIndex = 0
        '
        'InfoDisplay
        '
        Me.InfoDisplay.AutoSize = True
        Me.InfoDisplay.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoDisplay.Location = New System.Drawing.Point(3, 0)
        Me.InfoDisplay.MaximumSize = New System.Drawing.Size(250, 0)
        Me.InfoDisplay.MinimumSize = New System.Drawing.Size(250, 50)
        Me.InfoDisplay.Name = "InfoDisplay"
        Me.InfoDisplay.Size = New System.Drawing.Size(250, 50)
        Me.InfoDisplay.TabIndex = 0
        '
        'StartResearch
        '
        Me.StartResearch.Font = New System.Drawing.Font("Modern No. 20", 11.0!, System.Drawing.FontStyle.Underline)
        Me.StartResearch.Location = New System.Drawing.Point(16, 290)
        Me.StartResearch.Name = "StartResearch"
        Me.StartResearch.Size = New System.Drawing.Size(134, 27)
        Me.StartResearch.TabIndex = 2
        Me.StartResearch.Text = "Research Upgrade"
        Me.StartResearch.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Font = New System.Drawing.Font("Modern No. 20", 11.0!, System.Drawing.FontStyle.Underline)
        Me.Cancel.Location = New System.Drawing.Point(347, 290)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(89, 27)
        Me.Cancel.TabIndex = 3
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'UpgradePanel
        '
        Me.UpgradePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UpgradePanel.Location = New System.Drawing.Point(16, 12)
        Me.UpgradePanel.Name = "UpgradePanel"
        Me.UpgradePanel.Size = New System.Drawing.Size(470, 272)
        Me.UpgradePanel.TabIndex = 4
        '
        'ResearchingUpgrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 329)
        Me.Controls.Add(Me.UpgradePanel)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.StartResearch)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ResearchingUpgrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ResearchingUpgrades"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents InfoDisplay As System.Windows.Forms.Label
    Friend WithEvents StartResearch As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents UpgradePanel As System.Windows.Forms.Panel
End Class
