<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.锁定位置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.归位ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.记住位置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.自由门ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WIFI共享ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.P2PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.高级设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.选择网络ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.保存流量数据ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.点击穿透ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ping检测ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.开机启动ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重启ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关闭ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Ping1 = New System.Net.NetworkInformation.Ping()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(368, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 21)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(368, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(56, 21)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gold
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(0, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "↑ 上传速度:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.锁定位置ToolStripMenuItem, Me.归位ToolStripMenuItem, Me.记住位置ToolStripMenuItem, Me.ToolStripSeparator1, Me.自由门ToolStripMenuItem, Me.WIFI共享ToolStripMenuItem, Me.P2PToolStripMenuItem, Me.ToolStripSeparator2, Me.高级设置ToolStripMenuItem, Me.重启ToolStripMenuItem, Me.关闭ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(127, 214)
        '
        '锁定位置ToolStripMenuItem
        '
        Me.锁定位置ToolStripMenuItem.Name = "锁定位置ToolStripMenuItem"
        Me.锁定位置ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.锁定位置ToolStripMenuItem.Text = "锁定位置"
        '
        '归位ToolStripMenuItem
        '
        Me.归位ToolStripMenuItem.Name = "归位ToolStripMenuItem"
        Me.归位ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.归位ToolStripMenuItem.Text = "归零位置"
        '
        '记住位置ToolStripMenuItem
        '
        Me.记住位置ToolStripMenuItem.Name = "记住位置ToolStripMenuItem"
        Me.记住位置ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.记住位置ToolStripMenuItem.Text = "记住位置"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(123, 6)
        '
        '自由门ToolStripMenuItem
        '
        Me.自由门ToolStripMenuItem.Name = "自由门ToolStripMenuItem"
        Me.自由门ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.自由门ToolStripMenuItem.Text = "自由门"
        '
        'WIFI共享ToolStripMenuItem
        '
        Me.WIFI共享ToolStripMenuItem.Name = "WIFI共享ToolStripMenuItem"
        Me.WIFI共享ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.WIFI共享ToolStripMenuItem.Text = "WIFI共享"
        '
        'P2PToolStripMenuItem
        '
        Me.P2PToolStripMenuItem.Name = "P2PToolStripMenuItem"
        Me.P2PToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.P2PToolStripMenuItem.Text = "P2P"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(123, 6)
        '
        '高级设置ToolStripMenuItem
        '
        Me.高级设置ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.选择网络ToolStripMenuItem, Me.保存流量数据ToolStripMenuItem, Me.点击穿透ToolStripMenuItem, Me.Ping检测ToolStripMenuItem, Me.开机启动ToolStripMenuItem})
        Me.高级设置ToolStripMenuItem.Name = "高级设置ToolStripMenuItem"
        Me.高级设置ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.高级设置ToolStripMenuItem.Text = "高级设置"
        '
        '选择网络ToolStripMenuItem
        '
        Me.选择网络ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.选择网络ToolStripMenuItem.Name = "选择网络ToolStripMenuItem"
        Me.选择网络ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.选择网络ToolStripMenuItem.Text = "选择监视网络"
        Me.选择网络ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '保存流量数据ToolStripMenuItem
        '
        Me.保存流量数据ToolStripMenuItem.Name = "保存流量数据ToolStripMenuItem"
        Me.保存流量数据ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.保存流量数据ToolStripMenuItem.Text = "保存流量数据"
        '
        '点击穿透ToolStripMenuItem
        '
        Me.点击穿透ToolStripMenuItem.Name = "点击穿透ToolStripMenuItem"
        Me.点击穿透ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.点击穿透ToolStripMenuItem.Text = "点击穿透"
        '
        'Ping检测ToolStripMenuItem
        '
        Me.Ping检测ToolStripMenuItem.Name = "Ping检测ToolStripMenuItem"
        Me.Ping检测ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.Ping检测ToolStripMenuItem.Text = "Ping检测"
        '
        '开机启动ToolStripMenuItem
        '
        Me.开机启动ToolStripMenuItem.Name = "开机启动ToolStripMenuItem"
        Me.开机启动ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.开机启动ToolStripMenuItem.Text = "开机启动"
        '
        '重启ToolStripMenuItem
        '
        Me.重启ToolStripMenuItem.Name = "重启ToolStripMenuItem"
        Me.重启ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.重启ToolStripMenuItem.Text = "重启"
        '
        '关闭ToolStripMenuItem
        '
        Me.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem"
        Me.关闭ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.关闭ToolStripMenuItem.Text = "关闭"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gold
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(0, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "↓ 下载速度:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Gold
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(0, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "下载总流量："
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "网络监控"
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(166, 72)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Opacity = 0.9R
        Me.ShowInTaskbar = False
        Me.Text = "网速监控"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 重启ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 关闭ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 归位ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 锁定位置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents 自由门ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents P2PToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents WIFI共享ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ping1 As System.Net.NetworkInformation.Ping
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents 记住位置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents 高级设置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 选择网络ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 点击穿透ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ping检测ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 开机启动ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 保存流量数据ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
