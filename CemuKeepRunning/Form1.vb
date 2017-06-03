Public Class Form1

    Private Const SW_SHOWDEFAULT As System.Int32 = 10

    <Runtime.InteropServices.DllImport("user32.dll")>
    Public Shared Function ShowWindow(<Runtime.InteropServices.In()> ByVal hWnd As IntPtr, <Runtime.InteropServices.In()> ByVal nCmdShow As System.Int32) As System.Boolean
    End Function

    <Runtime.InteropServices.DllImport("user32.dll")>
    Public Shared Function SetForegroundWindow(<Runtime.InteropServices.In()> ByVal hWnd As IntPtr) As System.Boolean
    End Function

    Dim StopLoop As Boolean = False
    Dim CemuProcess As New Process
    Dim OptionProcess As New Process
    Dim Slowdown As Int16 = 500

    Private Sub Slow()
        Threading.Thread.Sleep(1000)
    End Sub

    Private Sub CloseApp()
        ExportVars()
        Application.Exit()
    End Sub

    Private Sub LaunchCemu()
        Dim CemuArgs As String = "-g " & GamePathText.Text
        If FullscreenEnabled.Checked = True And GPUFenceEnabled.Checked = False Then
            CemuArgs = $"{CemuArgs} -f"
        End If
        If FullscreenEnabled.Checked = False And GPUFenceEnabled.Checked = True Then
            CemuArgs = $"{CemuArgs} -f"
        End If
        CemuProcess.StartInfo.FileName = CemuPathText.Text
        CemuProcess.StartInfo.Arguments = CemuArgs
        CemuProcess.Start()
        If GPUFenceEnabled.Checked = True Then
            'SendKeys()
        End If
    End Sub

    Private Sub LaunchOther()
        If TimeoutEnabled.Checked = True Then
            Dim timeoutInt As Integer = Int(TimeoutText.Text)
            Threading.Thread.Sleep(timeoutInt * 1000)
        End If
        OptionProcess.StartInfo.FileName = OptionPathText.Text
        OptionProcess.StartInfo.Arguments = OptionArgsText.Text
        OptionProcess.Start()
        'SendKeys()
    End Sub

    Private Sub ImportVars()
        CemuPathText.Text = My.Settings.CemuPathSetting
        GamePathText.Text = My.Settings.GamePathSetting
        OptionPathText.Text = My.Settings.OptionPathSetting
        OptionArgsText.Text = My.Settings.OptionArgsSetting
        TimeoutText.Text = My.Settings.TimeoutSetting
        OptionEnabled.Checked = My.Settings.OptionEnabledSetting
        TimeoutEnabled.Checked = My.Settings.TimeoutEnabledSetting
        FullscreenEnabled.Checked = My.Settings.FullscreenSetting
        GPUFenceEnabled.Checked = My.Settings.GPUEnabledSetting
    End Sub

    Private Sub ExportVars()
        My.Settings.CemuPathSetting = CemuPathText.Text
        My.Settings.GamePathSetting = GamePathText.Text
        My.Settings.OptionPathSetting = OptionPathText.Text
        My.Settings.OptionArgsSetting = OptionArgsText.Text
        My.Settings.TimeoutSetting = TimeoutText.Text
        My.Settings.OptionEnabledSetting = OptionEnabled.Checked
        My.Settings.TimeoutEnabledSetting = TimeoutEnabled.Checked
        My.Settings.FullscreenSetting = FullscreenEnabled.Checked
        My.Settings.GPUEnabledSetting = GPUFenceEnabled.Checked
        My.Settings.Save()
    End Sub

    Private Sub OptionEnabler()
        If OptionEnabled.Checked = True Then
            OptionPathButton.Enabled = True
            OptionPathText.Enabled = True
            OptionArgsText.Enabled = True
            TimeoutEnabled.Enabled = True
        Else
            OptionPathButton.Enabled = False
            OptionPathText.Enabled = False
            OptionArgsText.Enabled = False
            TimeoutEnabled.Enabled = False
        End If
    End Sub

    Private Sub OptionEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles OptionEnabled.CheckedChanged
        OptionEnabler()
    End Sub

    Private Sub TimeoutEnabler()
        If TimeoutEnabled.Checked = True Then
            TimeoutText.Enabled = True
        Else
            TimeoutText.Enabled = False
        End If
    End Sub

    Private Sub TimeoutEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles TimeoutEnabled.CheckedChanged
        TimeoutEnabler()
    End Sub

    Private Sub CemuPathButton_Click(sender As Object, e As EventArgs) Handles CemuPathButton.Click
        OpenFileDialog.Filter = "Cemu.exe|cemu.exe"
        OpenFileDialog.Title = "Please locate Cemu.exe"
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            CemuPathText.Text = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub GamePathButton_Click(sender As Object, e As EventArgs) Handles GamePathButton.Click
        OpenFileDialog.Filter = "Cemu Game Files (*.rpx;*.wud;*.wux)|*.rpx;*.wud;*.wux"
        OpenFileDialog.Title = "Please locate your game"
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            GamePathText.Text = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub OptionPathButton_Click(sender As Object, e As EventArgs) Handles OptionPathButton.Click
        OpenFileDialog.Filter = "Executable File|*.exe"
        OpenFileDialog.Title = "Please locate optional program"
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            OptionPathText.Text = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OptionEnabled.Checked = False
        TimeoutEnabled.Checked = False
        FullscreenEnabled.Checked = False
        ImportVars()
        OptionEnabler()
        TimeoutEnabler()
    End Sub

    Private Sub CemuLoop()
        LaunchCemu()
        Do Until StopLoop = True
            CemuCrash()
            If CemuProcess.HasExited Then
                LaunchCemu()
            End If
            Slow()
        Loop
    End Sub

    Private Sub OptionLoop()
        LaunchOther()
        Do Until StopLoop = True
            If OptionProcess.HasExited Then
                LaunchOther()
            End If
            Slow()
        Loop
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        StopLoop = False
        RunningLabel.Visible = True
        Dim Thread1 As New Threading.Thread(AddressOf CemuLoop)
        Thread1.IsBackground = True
        Thread1.Start()
        If OptionEnabled.Checked = True Then
            Dim Thread2 As New Threading.Thread(AddressOf OptionLoop)
            Thread2.IsBackground = True
            Thread2.Start()
        End If
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        StopLoop = True
        RunningLabel.Visible = False
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        CloseApp()
    End Sub

    Private Sub AppClosing(Source As Object, e As EventArgs) Handles Me.Closed
        CloseApp()
    End Sub

    Private Sub CemuCrash()
        For Each WerFaultProcess As Process In Process.GetProcesses()
            If String.Compare(WerFaultProcess.ProcessName, "werfault", True) = 0 Then
                Try
                    WerFaultProcess.Kill()
                Catch e As Exception
                    'CreateObject("Wscript.Shell").Popup(e.Message,1,"Error")
                End Try
            End If
        Next
    End Sub

    Private Sub SendKeys()
        Threading.Thread.Sleep(1000)
        ShowWindow(CemuProcess.MainWindowHandle, SW_SHOWDEFAULT)
        SetForegroundWindow(CemuProcess.MainWindowHandle)
        Threading.Thread.Sleep(1000)
        System.Windows.Forms.SendKeys.SendWait("%o")
        Threading.Thread.Sleep(100)
        System.Windows.Forms.SendKeys.SendWait("{DOWN}")
        Threading.Thread.Sleep(100)
        System.Windows.Forms.SendKeys.SendWait("{DOWN}")
        Threading.Thread.Sleep(100)
        System.Windows.Forms.SendKeys.SendWait("{ENTER}")
    End Sub

    Private Sub GPUFenceEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles GPUFenceEnabled.CheckedChanged
        MsgBox("This check box currently does nothing. To enable, open your gameProfiles folder and edit your game's .ini file with notepad or your favorite text editor to include the line disableGPUFence = True")
        GPUFenceEnabled.Checked = False
    End Sub
End Class
