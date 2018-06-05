Imports System.Net.NetworkInformation
Imports System.Diagnostics
Imports Microsoft.Win32
Imports System.Drawing.Printing
Imports System.Net

Public Class Form1
    Public savedata As Single = 0
    Public netlist As Short = My.Settings.netselect   '网络适配器选择

#Region "点击穿透API及常量"
    Declare Function SetWindowLongA Lib "user32" (ByVal hwnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    Declare Function GetWindowLongA Lib "user32" (ByVal hwnd As Integer, ByVal nIndex As Integer) As Integer
    Const WS_EX_TRANSPARENT = &H20&
    Const GWL_EXSTYLE = (-20)
    Const WS_EX_LAYERED = &H80000
#End Region


#Region "网速监控"
    Dim Thread1 As New System.Threading.Thread(AddressOf network)
    Dim myNA() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
    Public start As Long           '程序启动时接受到总数据（不变）
    Public middata As Long         '下载流量中间介质

    Sub network()
        Do

            Dim data As IPv4InterfaceStatistics = myNA(netlist).GetIPv4Statistics
            Dim s1 As String = "  ↓ 下载速度：  " + Format((data.BytesReceived - Val(TextBox1.Text)) / 1024, "###0.00") & " KB/s"
            Dim s2 As String = "  ↑ 上传速度：  " + Format((data.BytesSent - Val(TextBox2.Text)) / 1024, "###0.00") & " KB/s"
            If data.BytesReceived = 0 Then
                start = 0
                Exit Sub
            End If
            TextBox1.Text = data.BytesReceived
            TextBox2.Text = data.BytesSent

            '以下为总流量记数
            Label1.Text = s1
            Label2.Text = s2

            Label4.Text = "  下载总流量：  " + Format((data.BytesReceived - start + savedata * 1024 * 1024) / 1024 / 1024, "###0.00") & " MB"

            middata = (data.BytesReceived - start)


            System.Threading.Thread.Sleep(1000)
        Loop

    End Sub



#End Region

    'load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '启动位置
        记住位置ToolStripMenuItem.Checked = My.Settings.savepos

        Me.Left = My.Computer.Screen.Bounds.Width   '1187
        If 记住位置ToolStripMenuItem.Checked = False Then
            Me.Top = My.Computer.Screen.Bounds.Height - 140
        Else
            Me.Top = My.Settings.pos.Y
        End If

        NotifyIcon1.Visible = False
        Me.TransparencyKey = Color.FromArgb(240, 240, 240)
        Me.Show()
        '添加菜单
        For i = 1 To myNA.Length
            选择网络ToolStripMenuItem.DropDownItems.Add(myNA(i - 1).Name)
            AddHandler 选择网络ToolStripMenuItem.DropDownItems(i - 1).Click, AddressOf 选择网络事件

        Next
        选择网络ToolStripMenuItem.DropDownItems(netlist).ForeColor = Color.Red

        Dim data As IPv4InterfaceStatistics = myNA(netlist).GetIPv4Statistics
        start = data.BytesReceived

        Timer2.Enabled = True

        regedit()

        保存流量数据ToolStripMenuItem.Checked = My.Settings.savedata
        If My.Settings.savedata = False Then
            savedata = 0
        Else
            savedata = My.Settings.downdata
        End If

        锁定位置ToolStripMenuItem.Checked = My.Settings.lockpos
        If 锁定位置ToolStripMenuItem.Checked = False Then
            归位ToolStripMenuItem.Enabled = True
        Else
            归位ToolStripMenuItem.Enabled = False
        End If



        Control.CheckForIllegalCrossThreadCalls = False
        Thread1.IsBackground = True
        Thread1.Start()

    End Sub

    '关闭保存
    Private Sub 关闭保存数据(sender As Object, e As EventArgs) Handles Me.FormClosing
        savedate()
        Thread1.Abort()
    End Sub

    Sub savedate()
        Try
            My.Settings.lockpos = 锁定位置ToolStripMenuItem.Checked
            My.Settings.savepos = 记住位置ToolStripMenuItem.Checked
            If 保存流量数据ToolStripMenuItem.Checked = False Then
                My.Settings.savedata = False
                My.Settings.downdata = 0
            Else
                Dim data As String = Label4.Text
                My.Settings.savedata = True
                My.Settings.downdata = Split(data)(1)
            End If
            If 记住位置ToolStripMenuItem.Checked = True Then
                My.Settings.pos = Me.Location
                My.Settings.savepos = True
            Else
                My.Settings.pos = New Point(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height - 160)
                My.Settings.savepos = False
            End If
        Catch ex As Exception
        Finally
            My.Settings.Save()
        End Try
    End Sub

    Private Sub 选择网络事件(sender As Object, e As EventArgs)
        For i = 1 To 选择网络ToolStripMenuItem.DropDownItems.Count
            选择网络ToolStripMenuItem.DropDownItems(i - 1).ForeColor = Color.Black
            If CType(sender, ToolStripItem).Text = 选择网络ToolStripMenuItem.DropDownItems(i - 1).Text Then netlist = i - 1
        Next
        CType(sender, ToolStripItem).ForeColor = Color.Red
        My.Settings.netselect = netlist
        savedate()
        Application.Restart()
    End Sub

    Sub regedit()
        Dim newKey As RegistryKey = My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)

        If newKey.GetValue("快速启动", "-1") = "-1" Then
            开机启动ToolStripMenuItem.Checked = False
        Else
            开机启动ToolStripMenuItem.Checked = True
        End If
    End Sub

#Region "移动窗体"
    Public X, Y As Integer
    Public moveflag As Boolean = True
    Private Sub Form1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown, Label2.MouseDown, Label4.MouseDown

        If moveflag = False Then Exit Sub
        X = e.X : Y = e.Y
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove, Label2.MouseMove, Label4.MouseMove
        If moveflag = False Then Exit Sub
        If X = e.X And Y = e.Y Then Exit Sub
        If e.Button = Windows.Forms.MouseButtons.Left Then

            Me.Left = Me.Left + e.X - X
            Me.Top = Me.Top + e.Y - Y

        End If
    End Sub
#End Region

#Region "右击菜单设置"
    Private Sub 右击弹出菜单(sender As Object, e As MouseEventArgs) Handles Label1.MouseClick, Label2.MouseClick, Label4.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Label1, -ContextMenuStrip1.Size.Width - 2, 70 - ContextMenuStrip1.Size.Height)
        End If
    End Sub

    Private Sub 重启(sender As Object, e As EventArgs) Handles 重启ToolStripMenuItem.Click
        savedate()
        Application.Restart()
    End Sub

    Private Sub 关闭(sender As Object, e As EventArgs) Handles 关闭ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub 归位(sender As Object, e As EventArgs) Handles 归位ToolStripMenuItem.Click
        Me.Left = My.Computer.Screen.Bounds.Width - Label1.Width   '1187
        Me.Top = My.Computer.Screen.Bounds.Height - 140
    End Sub

    Private Sub 锁定位置button(sender As Object, e As EventArgs) Handles 锁定位置ToolStripMenuItem.Click
        锁定位置ToolStripMenuItem.Checked = Not 锁定位置ToolStripMenuItem.Checked
        If 锁定位置ToolStripMenuItem.Checked = True Then
            moveflag = False
        Else
            moveflag = True
        End If
    End Sub

    Private Sub 点击穿透ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 点击穿透ToolStripMenuItem.Click
        点击穿透ToolStripMenuItem.Checked = Not 点击穿透ToolStripMenuItem.Checked
        If 点击穿透ToolStripMenuItem.Checked = True Then
            SetWindowLongA(Me.Handle, GWL_EXSTYLE, GetWindowLongA(Me.Handle, GWL_EXSTYLE) Or WS_EX_LAYERED Or WS_EX_TRANSPARENT)
            NotifyIcon1.Visible = True
        Else
            SetWindowLongA(Me.Handle, GWL_EXSTYLE, 0 Or WS_EX_LAYERED)
            NotifyIcon1.Visible = False
        End If
    End Sub

    Private Sub 开机启动(sender As Object, e As EventArgs) Handles 开机启动ToolStripMenuItem.Click
        开机启动ToolStripMenuItem.Checked = Not 开机启动ToolStripMenuItem.Checked
        Dim newKey As RegistryKey = My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        If 开机启动ToolStripMenuItem.Checked = True Then
            Try
                newKey.SetValue("快速启动", Application.ExecutablePath, RegistryValueKind.String)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            Try
                newKey.DeleteValue("快速启动")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub 自由门ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 自由门ToolStripMenuItem.Click
        Try
            Shell("D:\Program File\自由门\goagent\local\goagent.exe", AppWinStyle.Hide)

        Catch ex As Exception
            MsgBox(ex.Message, 64, "提示信息!")
        End Try
    End Sub

    Private Sub P2PToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles P2PToolStripMenuItem.Click
        Try
            Shell("D:\备份\我的程序\P2PSearchers6.3.0.exe", AppWinStyle.NormalFocus)

        Catch ex As Exception
            MsgBox(ex.Message, 64, "提示信息!")
        End Try
    End Sub

    Private Sub WIFI共享ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WIFI共享ToolStripMenuItem.Click
        Try
            Process.Start("D:\Program File\PCMaster\magicwifi.exe")
        Catch ex As Exception
            MsgBox(ex.Message, 64, "提示信息!")
        End Try

    End Sub

    Private Sub 保存流量数据(sender As Object, e As EventArgs) Handles 保存流量数据ToolStripMenuItem.Click
        保存流量数据ToolStripMenuItem.Checked = Not 保存流量数据ToolStripMenuItem.Checked
    End Sub

    Private Sub 记住位置ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 记住位置ToolStripMenuItem.Click
        记住位置ToolStripMenuItem.Checked = Not 记住位置ToolStripMenuItem.Checked
    End Sub
#End Region

    Private Sub 双击ping(sender As Object, e As EventArgs) Handles Label4.MouseDoubleClick, Ping检测ToolStripMenuItem.Click

        If My.Computer.Network.IsAvailable = True Then
            Dim 百度 As String
            百度 = Ping1.Send("www.baidu.com", 1000).RoundtripTime.ToString & " ms"

            Dim 新浪 As String
            新浪 = Ping1.Send("www.sina.com", 1000).RoundtripTime.ToString & " ms"

            Dim 斗鱼 As String
            斗鱼 = Ping1.Send("www.douyutv.com", 1000).RoundtripTime.ToString & " ms"

            Dim CSDN As String
            CSDN = Ping1.Send("www.csdn.net", 1000).RoundtripTime.ToString & " ms"

            Dim acfun As String
            acfun = Ping1.Send("www.acfun.tv", 1000).RoundtripTime.ToString & " ms"

            Dim sum As String = "百度   Ping:     " + 百度 + vbCrLf + "新浪   Ping:     " + 新浪 + vbCrLf + "斗鱼   Ping:     " + 斗鱼 + vbCrLf + "A站    Ping:     " + acfun

            If NotifyIcon1.Visible = True Then NotifyIcon1.ShowBalloonTip(2000, "Ping检测", sum, ToolTipIcon.Info) : Exit Sub
            ToolTip1.Show(sum, Label4, 13, -135, 2500)
        Else
            If NotifyIcon1.Visible = True Then NotifyIcon1.ShowBalloonTip(2000, "Ping检测", "网络未连接！", ToolTipIcon.Info) : Exit Sub

            ToolTip1.Show("网络未连接！", Label4, 39, -90, 2500)
        End If

    End Sub

    Private Sub 滑动显示(sender As Object, e As EventArgs) Handles Timer2.Tick
        If 记住位置ToolStripMenuItem.Checked = True Then
            If Me.Left <= My.Settings.pos.X Then Timer2.Enabled = False : Me.Left = My.Settings.pos.Y : Exit Sub
            Me.Left -= 2
        Else
            If Me.Left <= My.Computer.Screen.Bounds.Width - Label1.Width Then Timer2.Enabled = False : Me.Left = My.Computer.Screen.Bounds.Width - Label1.Width : Exit Sub
            Me.Left -= 2
        End If
    End Sub

    Private Sub 边缘吸附(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp, Label2.MouseUp
        If Me.Left + Me.Width > My.Computer.Screen.Bounds.Width - 25 Then
            Me.Left = My.Computer.Screen.Bounds.Width - Me.Width
        End If
    End Sub



End Class

