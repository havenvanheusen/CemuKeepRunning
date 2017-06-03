<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.CemuPathButton = New System.Windows.Forms.Button()
        Me.CemuPathText = New System.Windows.Forms.TextBox()
        Me.CemuPathLabel = New System.Windows.Forms.Label()
        Me.GamePathLabel = New System.Windows.Forms.Label()
        Me.GamePathButton = New System.Windows.Forms.Button()
        Me.GamePathText = New System.Windows.Forms.TextBox()
        Me.OptionPathLabel = New System.Windows.Forms.Label()
        Me.OptionPathButton = New System.Windows.Forms.Button()
        Me.OptionPathText = New System.Windows.Forms.TextBox()
        Me.OptionEnabled = New System.Windows.Forms.CheckBox()
        Me.TimeoutLabel = New System.Windows.Forms.Label()
        Me.TimeoutText = New System.Windows.Forms.TextBox()
        Me.TimeoutEnabled = New System.Windows.Forms.CheckBox()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.FullscreenEnabled = New System.Windows.Forms.CheckBox()
        Me.OptionArgsLabel = New System.Windows.Forms.Label()
        Me.OptionArgsText = New System.Windows.Forms.TextBox()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.RunningLabel = New System.Windows.Forms.Label()
        Me.GPUFenceEnabled = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'CemuPathButton
        '
        Me.CemuPathButton.Location = New System.Drawing.Point(12, 25)
        Me.CemuPathButton.Name = "CemuPathButton"
        Me.CemuPathButton.Size = New System.Drawing.Size(30, 23)
        Me.CemuPathButton.TabIndex = 0
        Me.CemuPathButton.Text = ". . ."
        Me.CemuPathButton.UseVisualStyleBackColor = True
        '
        'CemuPathText
        '
        Me.CemuPathText.Location = New System.Drawing.Point(48, 27)
        Me.CemuPathText.Name = "CemuPathText"
        Me.CemuPathText.Size = New System.Drawing.Size(356, 20)
        Me.CemuPathText.TabIndex = 1
        '
        'CemuPathLabel
        '
        Me.CemuPathLabel.AutoSize = True
        Me.CemuPathLabel.Location = New System.Drawing.Point(12, 9)
        Me.CemuPathLabel.Name = "CemuPathLabel"
        Me.CemuPathLabel.Size = New System.Drawing.Size(147, 13)
        Me.CemuPathLabel.TabIndex = 2
        Me.CemuPathLabel.Text = "Path to the Cemu executable:"
        '
        'GamePathLabel
        '
        Me.GamePathLabel.AutoSize = True
        Me.GamePathLabel.Location = New System.Drawing.Point(12, 51)
        Me.GamePathLabel.Name = "GamePathLabel"
        Me.GamePathLabel.Size = New System.Drawing.Size(107, 13)
        Me.GamePathLabel.TabIndex = 3
        Me.GamePathLabel.Text = "Path to the game file:"
        '
        'GamePathButton
        '
        Me.GamePathButton.Location = New System.Drawing.Point(12, 67)
        Me.GamePathButton.Name = "GamePathButton"
        Me.GamePathButton.Size = New System.Drawing.Size(30, 23)
        Me.GamePathButton.TabIndex = 4
        Me.GamePathButton.Text = ". . ."
        Me.GamePathButton.UseVisualStyleBackColor = True
        '
        'GamePathText
        '
        Me.GamePathText.Location = New System.Drawing.Point(48, 69)
        Me.GamePathText.Name = "GamePathText"
        Me.GamePathText.Size = New System.Drawing.Size(356, 20)
        Me.GamePathText.TabIndex = 5
        '
        'OptionPathLabel
        '
        Me.OptionPathLabel.AutoSize = True
        Me.OptionPathLabel.Location = New System.Drawing.Point(12, 92)
        Me.OptionPathLabel.Name = "OptionPathLabel"
        Me.OptionPathLabel.Size = New System.Drawing.Size(167, 13)
        Me.OptionPathLabel.TabIndex = 6
        Me.OptionPathLabel.Text = "Optional program to keep running:"
        '
        'OptionPathButton
        '
        Me.OptionPathButton.Location = New System.Drawing.Point(12, 108)
        Me.OptionPathButton.Name = "OptionPathButton"
        Me.OptionPathButton.Size = New System.Drawing.Size(30, 23)
        Me.OptionPathButton.TabIndex = 7
        Me.OptionPathButton.Text = ". . ."
        Me.OptionPathButton.UseVisualStyleBackColor = True
        '
        'OptionPathText
        '
        Me.OptionPathText.Location = New System.Drawing.Point(48, 110)
        Me.OptionPathText.Name = "OptionPathText"
        Me.OptionPathText.Size = New System.Drawing.Size(356, 20)
        Me.OptionPathText.TabIndex = 8
        '
        'OptionEnabled
        '
        Me.OptionEnabled.AutoSize = True
        Me.OptionEnabled.Location = New System.Drawing.Point(339, 91)
        Me.OptionEnabled.Name = "OptionEnabled"
        Me.OptionEnabled.Size = New System.Drawing.Size(65, 17)
        Me.OptionEnabled.TabIndex = 9
        Me.OptionEnabled.Text = "Enabled"
        Me.OptionEnabled.UseVisualStyleBackColor = True
        '
        'TimeoutLabel
        '
        Me.TimeoutLabel.AutoSize = True
        Me.TimeoutLabel.Location = New System.Drawing.Point(12, 137)
        Me.TimeoutLabel.Name = "TimeoutLabel"
        Me.TimeoutLabel.Size = New System.Drawing.Size(235, 13)
        Me.TimeoutLabel.TabIndex = 10
        Me.TimeoutLabel.Text = "Wait for optional program to launch (in seconds):"
        '
        'TimeoutText
        '
        Me.TimeoutText.Location = New System.Drawing.Point(253, 134)
        Me.TimeoutText.Name = "TimeoutText"
        Me.TimeoutText.Size = New System.Drawing.Size(45, 20)
        Me.TimeoutText.TabIndex = 11
        '
        'TimeoutEnabled
        '
        Me.TimeoutEnabled.AutoSize = True
        Me.TimeoutEnabled.Location = New System.Drawing.Point(339, 136)
        Me.TimeoutEnabled.Name = "TimeoutEnabled"
        Me.TimeoutEnabled.Size = New System.Drawing.Size(65, 17)
        Me.TimeoutEnabled.TabIndex = 12
        Me.TimeoutEnabled.Text = "Enabled"
        Me.TimeoutEnabled.UseVisualStyleBackColor = True
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(12, 202)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 23)
        Me.StartButton.TabIndex = 13
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Location = New System.Drawing.Point(93, 202)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(75, 23)
        Me.StopButton.TabIndex = 14
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'FullscreenEnabled
        '
        Me.FullscreenEnabled.AutoSize = True
        Me.FullscreenEnabled.Location = New System.Drawing.Point(324, 8)
        Me.FullscreenEnabled.Name = "FullscreenEnabled"
        Me.FullscreenEnabled.Size = New System.Drawing.Size(80, 17)
        Me.FullscreenEnabled.TabIndex = 15
        Me.FullscreenEnabled.Text = "Fullscreen?"
        Me.FullscreenEnabled.UseVisualStyleBackColor = True
        '
        'OptionArgsLabel
        '
        Me.OptionArgsLabel.AutoSize = True
        Me.OptionArgsLabel.Location = New System.Drawing.Point(12, 159)
        Me.OptionArgsLabel.Name = "OptionArgsLabel"
        Me.OptionArgsLabel.Size = New System.Drawing.Size(364, 13)
        Me.OptionArgsLabel.TabIndex = 16
        Me.OptionArgsLabel.Text = "Additional arguments for optional program (Leave blank if none are needed):"
        '
        'OptionArgsText
        '
        Me.OptionArgsText.Location = New System.Drawing.Point(12, 176)
        Me.OptionArgsText.Name = "OptionArgsText"
        Me.OptionArgsText.Size = New System.Drawing.Size(392, 20)
        Me.OptionArgsText.TabIndex = 17
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(329, 202)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(75, 23)
        Me.QuitButton.TabIndex = 18
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'RunningLabel
        '
        Me.RunningLabel.AutoSize = True
        Me.RunningLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunningLabel.ForeColor = System.Drawing.Color.Red
        Me.RunningLabel.Location = New System.Drawing.Point(226, 207)
        Me.RunningLabel.Name = "RunningLabel"
        Me.RunningLabel.Size = New System.Drawing.Size(54, 13)
        Me.RunningLabel.TabIndex = 19
        Me.RunningLabel.Text = "Running"
        Me.RunningLabel.Visible = False
        '
        'GPUFenceEnabled
        '
        Me.GPUFenceEnabled.AutoSize = True
        Me.GPUFenceEnabled.Location = New System.Drawing.Point(168, 8)
        Me.GPUFenceEnabled.Name = "GPUFenceEnabled"
        Me.GPUFenceEnabled.Size = New System.Drawing.Size(150, 17)
        Me.GPUFenceEnabled.TabIndex = 20
        Me.GPUFenceEnabled.Text = "Enable GPUFence Hack?"
        Me.GPUFenceEnabled.UseVisualStyleBackColor = True
        Me.GPUFenceEnabled.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 229)
        Me.Controls.Add(Me.GPUFenceEnabled)
        Me.Controls.Add(Me.RunningLabel)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.OptionArgsText)
        Me.Controls.Add(Me.OptionArgsLabel)
        Me.Controls.Add(Me.FullscreenEnabled)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.TimeoutEnabled)
        Me.Controls.Add(Me.TimeoutText)
        Me.Controls.Add(Me.TimeoutLabel)
        Me.Controls.Add(Me.OptionEnabled)
        Me.Controls.Add(Me.OptionPathText)
        Me.Controls.Add(Me.OptionPathButton)
        Me.Controls.Add(Me.OptionPathLabel)
        Me.Controls.Add(Me.GamePathText)
        Me.Controls.Add(Me.GamePathButton)
        Me.Controls.Add(Me.GamePathLabel)
        Me.Controls.Add(Me.CemuPathLabel)
        Me.Controls.Add(Me.CemuPathText)
        Me.Controls.Add(Me.CemuPathButton)
        Me.Name = "Form1"
        Me.Text = "Keep Cemu Running"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CemuPathButton As Button
    Friend WithEvents CemuPathText As TextBox
    Friend WithEvents CemuPathLabel As Label
    Friend WithEvents GamePathLabel As Label
    Friend WithEvents GamePathButton As Button
    Friend WithEvents GamePathText As TextBox
    Friend WithEvents OptionPathLabel As Label
    Friend WithEvents OptionPathButton As Button
    Friend WithEvents OptionPathText As TextBox
    Friend WithEvents OptionEnabled As CheckBox
    Friend WithEvents TimeoutLabel As Label
    Friend WithEvents TimeoutText As TextBox
    Friend WithEvents TimeoutEnabled As CheckBox
    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents FullscreenEnabled As CheckBox
    Friend WithEvents OptionArgsLabel As Label
    Friend WithEvents OptionArgsText As TextBox
    Friend WithEvents QuitButton As Button
    Friend WithEvents RunningLabel As Label
    Friend WithEvents GPUFenceEnabled As CheckBox
End Class
