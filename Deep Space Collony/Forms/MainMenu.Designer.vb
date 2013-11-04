<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.btnTutorial = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnEncyclopedia = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNewGame
        '
        Me.btnNewGame.Font = New System.Drawing.Font("Modern No. 20", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewGame.Location = New System.Drawing.Point(450, 271)
        Me.btnNewGame.Margin = New System.Windows.Forms.Padding(20)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(300, 70)
        Me.btnNewGame.TabIndex = 0
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'btnTutorial
        '
        Me.btnTutorial.Font = New System.Drawing.Font("Modern No. 20", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTutorial.Location = New System.Drawing.Point(450, 161)
        Me.btnTutorial.Margin = New System.Windows.Forms.Padding(20)
        Me.btnTutorial.Name = "btnTutorial"
        Me.btnTutorial.Size = New System.Drawing.Size(300, 70)
        Me.btnTutorial.TabIndex = 1
        Me.btnTutorial.Text = "Tutorial"
        Me.btnTutorial.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Modern No. 20", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(450, 491)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(20)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(300, 70)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnEncyclopedia
        '
        Me.btnEncyclopedia.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncyclopedia.Location = New System.Drawing.Point(29, 632)
        Me.btnEncyclopedia.Margin = New System.Windows.Forms.Padding(20)
        Me.btnEncyclopedia.Name = "btnEncyclopedia"
        Me.btnEncyclopedia.Size = New System.Drawing.Size(127, 39)
        Me.btnEncyclopedia.TabIndex = 4
        Me.btnEncyclopedia.Text = "Encyclopedia"
        Me.btnEncyclopedia.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Font = New System.Drawing.Font("Modern No. 20", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(450, 381)
        Me.btnLoad.Margin = New System.Windows.Forms.Padding(20)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(300, 70)
        Me.btnLoad.TabIndex = 5
        Me.btnLoad.Text = "Load Game"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnEncyclopedia)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnTutorial)
        Me.Controls.Add(Me.btnNewGame)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents btnTutorial As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnEncyclopedia As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
End Class
