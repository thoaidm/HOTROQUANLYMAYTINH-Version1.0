
Public Class Form1
    Dim o_dia As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Tiện ích hỗ trợ quản lý máy tính - Mr. Khoa 0907 122 136"
        o_dia = System.IO.Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles))
    End Sub

    Private Sub btnmothumucfont_Click(sender As Object, e As EventArgs) Handles btnmothumucFonts.Click
        Process.Start("explorer.exe", o_dia & "Windows\Fonts")
    End Sub

    Private Sub btnmothumucHost_Click(sender As Object, e As EventArgs) Handles btnmothumucHost.Click
        Process.Start("explorer.exe", o_dia & "Windows\System32\drivers\etc")
    End Sub

    Private Sub btnmoregistry_Click(sender As Object, e As EventArgs) Handles btnmoregistry.Click
        Process.Start("regedit.exe")
    End Sub

    Private Sub btnmoGrouppolicy_Click(sender As Object, e As EventArgs) Handles btnmoGrouppolicy.Click
        Process.Start("gpedit.msc")
    End Sub

    Private Sub btnmoServices_Click(sender As Object, e As EventArgs) Handles btnmoServices.Click
        Process.Start("services.msc")
    End Sub

    Private Sub btnopenMsconfig_Click(sender As Object, e As EventArgs) Handles btnopenMsconfig.Click
        Process.Start("msconfig")
    End Sub

    Private Sub btnmoCmd_Click(sender As Object, e As EventArgs) Handles btnmoCmd.Click
        Dim psi As New ProcessStartInfo()
        psi.Verb = "runas" ' aka run as administrator
        psi.FileName = "cmd.exe"
        Try
            Process.Start(psi) ' <- run the process (user will be prompted to run with administrator access)
        Catch
            ' exception raised if user declines the admin prompt
        End Try
    End Sub

    Private Sub btnmoNetplwiz_Click(sender As Object, e As EventArgs) Handles btnmoNetplwiz.Click
        Process.Start("netplwiz")
    End Sub

    Private Sub btntatwindowsupdate_Click(sender As Object, e As EventArgs) Handles btntatwindowsupdate.Click
        Dim proc = New Process()
        Dim info As New ProcessStartInfo
        info = New ProcessStartInfo("cmd.exe", "/c sc config wuauserv start= disabled")
        info.WindowStyle = ProcessWindowStyle.Hidden
        info.UseShellExecute = True
        info.Verb = "runas"
        proc.StartInfo = info
        proc.Start()
        proc.Dispose()
        MessageBox.Show("Cần khởi động lại máy tính để lệnh có hiệu lực!", "Thông báo")
    End Sub

    Private Sub btnmoDestopIconSettings_Click(sender As Object, e As EventArgs) Handles btnmoDestopIconSettings.Click
        Dim proc = New Process()
        proc.StartInfo = New ProcessStartInfo("rundll32.exe", "shell32.dll, Control_RunDLL desk.cpl,, 0")
        proc.Start()
        proc.Dispose()
    End Sub

    Private Sub btnmoAdapterOptions_Click(sender As Object, e As EventArgs) Handles btnmoAdapterOptions.Click
        Process.Start("ncpa.cpl")
    End Sub

    Private Sub btnmoAdvancedSharingSettings_Click(sender As Object, e As EventArgs) Handles btnmoAdvancedSharingSettings.Click
        Dim proc = New Process()
        proc.StartInfo = New ProcessStartInfo("control.exe", "/name Microsoft.NetworkAndSharingCenter /page Advanced")
        proc.Start()
        proc.Dispose()
    End Sub

    Private Sub btntaiTeamview_Click(sender As Object, e As EventArgs) Handles btntaiTeamViewer.Click
        Process.Start("https://download.teamviewer.com/download/TeamViewerQS.exe")
    End Sub

    Private Sub btnmoDateAndTime_Click(sender As Object, e As EventArgs) Handles btnmoDateAndTime.Click
        Process.Start("timedate.cpl")
    End Sub

    Private Sub btnmoProgramsAndFeatures_Click(sender As Object, e As EventArgs) Handles btnmoProgramsAndFeatures.Click
        Process.Start("appwiz.cpl")
    End Sub

    Private Sub btnmoBanphimAo_Click(sender As Object, e As EventArgs) Handles btnmoBanphimAo.Click
        Process.Start("osk")
    End Sub

    Private Sub btnmoMaytinhMini_Click(sender As Object, e As EventArgs) Handles btnmoMaytinhMini.Click
        Process.Start("calc")
    End Sub

    Private Sub btnmoPerformance_Click(sender As Object, e As EventArgs) Handles btnmoPerformance.Click
        Process.Start("SystemPropertiesPerformance.exe")
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class
