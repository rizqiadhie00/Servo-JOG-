<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
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
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BasicButton5 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton2 = New AdvancedHMIControls.BasicButton()
        Me.PilotLight3 = New AdvancedHMIControls.PilotLight()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PilotLight1 = New AdvancedHMIControls.PilotLight()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BasicButton7 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton6 = New AdvancedHMIControls.BasicButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.BasicButton4 = New AdvancedHMIControls.BasicButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BasicButton3 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 659)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "For Development Source Code Visit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.advancedhmi.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(413, 540)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 26.0!)
        Me.Label2.Location = New System.Drawing.Point(4, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(400, 50)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "SERVO CONTROL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(261, 512)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "STATUS"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(261, 540)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 30)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "DISCONNECT"
        '
        'Timer1
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(52, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 23)
        Me.Label3.TabIndex = 316
        Me.Label3.Text = "REVERSE JOG"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(15, -158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 23)
        Me.Label5.TabIndex = 317
        Me.Label5.Text = "RISING EDGE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(477, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 23)
        Me.Label7.TabIndex = 321
        Me.Label7.Text = "FORWARD JOG"
        '
        'BasicButton5
        '
        Me.BasicButton5.BackColor = System.Drawing.Color.Black
        Me.BasicButton5.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicButton5.ForeColor = System.Drawing.Color.Black
        Me.BasicButton5.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton5.Highlight = False
        Me.BasicButton5.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton5.Location = New System.Drawing.Point(68, 202)
        Me.BasicButton5.MaximumHoldTime = 3000
        Me.BasicButton5.MinimumHoldTime = 500
        Me.BasicButton5.Name = "BasicButton5"
        Me.BasicButton5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton5.PLCAddressClick = "Dev01.Button2"
        Me.BasicButton5.SelectTextAlternate = False
        Me.BasicButton5.Size = New System.Drawing.Size(112, 37)
        Me.BasicButton5.TabIndex = 326
        Me.BasicButton5.Text = "ON"
        Me.BasicButton5.TextAlternate = Nothing
        Me.BasicButton5.UseVisualStyleBackColor = True
        Me.BasicButton5.ValueToWrite = 0
        '
        'BasicButton2
        '
        Me.BasicButton2.BackColor = System.Drawing.Color.Black
        Me.BasicButton2.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicButton2.ForeColor = System.Drawing.Color.Black
        Me.BasicButton2.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton2.Highlight = False
        Me.BasicButton2.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton2.Location = New System.Drawing.Point(499, 202)
        Me.BasicButton2.MaximumHoldTime = 3000
        Me.BasicButton2.MinimumHoldTime = 500
        Me.BasicButton2.Name = "BasicButton2"
        Me.BasicButton2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton2.PLCAddressClick = "Dev01.Button1"
        Me.BasicButton2.SelectTextAlternate = False
        Me.BasicButton2.Size = New System.Drawing.Size(118, 41)
        Me.BasicButton2.TabIndex = 324
        Me.BasicButton2.Text = "ON"
        Me.BasicButton2.TextAlternate = Nothing
        Me.BasicButton2.UseVisualStyleBackColor = True
        Me.BasicButton2.ValueToWrite = 0
        '
        'PilotLight3
        '
        Me.PilotLight3.Blink = False
        Me.PilotLight3.ComComponent = Me.EthernetIPforCLXCom1
        Me.PilotLight3.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight3.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight3.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight3.Location = New System.Drawing.Point(509, 61)
        Me.PilotLight3.Name = "PilotLight3"
        Me.PilotLight3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight3.PLCAddressClick = ""
        Me.PilotLight3.PLCAddressText = ""
        Me.PilotLight3.PLCAddressValue = ""
        Me.PilotLight3.PLCAddressVisible = ""
        Me.PilotLight3.Size = New System.Drawing.Size(92, 135)
        Me.PilotLight3.TabIndex = 322
        Me.PilotLight3.Value = False
        Me.PilotLight3.ValueToWrite = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(155, 517)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 23)
        Me.Label12.TabIndex = 374
        Me.Label12.Text = "PORT"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(159, 540)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(96, 30)
        Me.TextBox4.TabIndex = 373
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(12, 517)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 23)
        Me.Label8.TabIndex = 372
        Me.Label8.Text = "IP ADDRESS"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 540)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(144, 30)
        Me.TextBox3.TabIndex = 371
        '
        'PilotLight1
        '
        Me.PilotLight1.Blink = False
        Me.PilotLight1.ComComponent = Me.EthernetIPforCLXCom1
        Me.PilotLight1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight1.Location = New System.Drawing.Point(80, 61)
        Me.PilotLight1.Name = "PilotLight1"
        Me.PilotLight1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight1.PLCAddressClick = ""
        Me.PilotLight1.PLCAddressText = ""
        Me.PilotLight1.PLCAddressValue = ""
        Me.PilotLight1.PLCAddressVisible = ""
        Me.PilotLight1.Size = New System.Drawing.Size(92, 135)
        Me.PilotLight1.TabIndex = 375
        Me.PilotLight1.Value = False
        Me.PilotLight1.ValueToWrite = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(259, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 376
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.PilotLight1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.PilotLight3)
        Me.Panel1.Controls.Add(Me.BasicButton2)
        Me.Panel1.Controls.Add(Me.BasicButton5)
        Me.Panel1.Location = New System.Drawing.Point(12, 195)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(659, 281)
        Me.Panel1.TabIndex = 379
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel2.Controls.Add(Me.BasicButton7)
        Me.Panel2.Controls.Add(Me.BasicButton6)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TextBox6)
        Me.Panel2.Controls.Add(Me.BasicButton4)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TextBox5)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.BasicButton3)
        Me.Panel2.Controls.Add(Me.BasicButton1)
        Me.Panel2.Location = New System.Drawing.Point(14, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(657, 127)
        Me.Panel2.TabIndex = 380
        '
        'BasicButton7
        '
        Me.BasicButton7.BackColor = System.Drawing.Color.Black
        Me.BasicButton7.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicButton7.ForeColor = System.Drawing.Color.Black
        Me.BasicButton7.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton7.Highlight = False
        Me.BasicButton7.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton7.Location = New System.Drawing.Point(247, 87)
        Me.BasicButton7.MaximumHoldTime = 3000
        Me.BasicButton7.MinimumHoldTime = 500
        Me.BasicButton7.Name = "BasicButton7"
        Me.BasicButton7.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton7.PLCAddressClick = "Dev01.Button2"
        Me.BasicButton7.SelectTextAlternate = False
        Me.BasicButton7.Size = New System.Drawing.Size(72, 28)
        Me.BasicButton7.TabIndex = 389
        Me.BasicButton7.Text = "OFF"
        Me.BasicButton7.TextAlternate = Nothing
        Me.BasicButton7.UseVisualStyleBackColor = True
        Me.BasicButton7.ValueToWrite = 0
        '
        'BasicButton6
        '
        Me.BasicButton6.BackColor = System.Drawing.Color.Black
        Me.BasicButton6.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicButton6.ForeColor = System.Drawing.Color.Black
        Me.BasicButton6.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton6.Highlight = False
        Me.BasicButton6.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton6.Location = New System.Drawing.Point(247, 29)
        Me.BasicButton6.MaximumHoldTime = 3000
        Me.BasicButton6.MinimumHoldTime = 500
        Me.BasicButton6.Name = "BasicButton6"
        Me.BasicButton6.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton6.PLCAddressClick = "Dev01.Button2"
        Me.BasicButton6.SelectTextAlternate = False
        Me.BasicButton6.Size = New System.Drawing.Size(72, 28)
        Me.BasicButton6.TabIndex = 388
        Me.BasicButton6.Text = "OFF"
        Me.BasicButton6.TextAlternate = Nothing
        Me.BasicButton6.UseVisualStyleBackColor = True
        Me.BasicButton6.ValueToWrite = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(334, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 23)
        Me.Label11.TabIndex = 387
        Me.Label11.Text = "JOG SPEED"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(334, 87)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(144, 30)
        Me.TextBox6.TabIndex = 386
        '
        'BasicButton4
        '
        Me.BasicButton4.BackColor = System.Drawing.Color.Black
        Me.BasicButton4.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicButton4.ForeColor = System.Drawing.Color.Black
        Me.BasicButton4.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton4.Highlight = False
        Me.BasicButton4.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton4.Location = New System.Drawing.Point(500, 87)
        Me.BasicButton4.MaximumHoldTime = 3000
        Me.BasicButton4.MinimumHoldTime = 500
        Me.BasicButton4.Name = "BasicButton4"
        Me.BasicButton4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton4.PLCAddressClick = "Dev01.Button2"
        Me.BasicButton4.SelectTextAlternate = False
        Me.BasicButton4.Size = New System.Drawing.Size(72, 28)
        Me.BasicButton4.TabIndex = 385
        Me.BasicButton4.Text = "SET"
        Me.BasicButton4.TextAlternate = Nothing
        Me.BasicButton4.UseVisualStyleBackColor = True
        Me.BasicButton4.ValueToWrite = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(3, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 23)
        Me.Label10.TabIndex = 384
        Me.Label10.Text = "SERVO"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(3, 87)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(144, 30)
        Me.TextBox5.TabIndex = 383
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(3, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 23)
        Me.Label9.TabIndex = 382
        Me.Label9.Text = "PLC"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(3, 29)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(144, 30)
        Me.TextBox2.TabIndex = 381
        '
        'BasicButton3
        '
        Me.BasicButton3.BackColor = System.Drawing.Color.Black
        Me.BasicButton3.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicButton3.ForeColor = System.Drawing.Color.Black
        Me.BasicButton3.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton3.Highlight = False
        Me.BasicButton3.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton3.Location = New System.Drawing.Point(169, 87)
        Me.BasicButton3.MaximumHoldTime = 3000
        Me.BasicButton3.MinimumHoldTime = 500
        Me.BasicButton3.Name = "BasicButton3"
        Me.BasicButton3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton3.PLCAddressClick = "Dev01.Button2"
        Me.BasicButton3.SelectTextAlternate = False
        Me.BasicButton3.Size = New System.Drawing.Size(72, 28)
        Me.BasicButton3.TabIndex = 380
        Me.BasicButton3.Text = "ON"
        Me.BasicButton3.TextAlternate = Nothing
        Me.BasicButton3.UseVisualStyleBackColor = True
        Me.BasicButton3.ValueToWrite = 0
        '
        'BasicButton1
        '
        Me.BasicButton1.BackColor = System.Drawing.Color.Black
        Me.BasicButton1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.Location = New System.Drawing.Point(169, 29)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton1.PLCAddressClick = "Dev01.Button2"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(72, 28)
        Me.BasicButton1.TabIndex = 379
        Me.BasicButton1.Text = "ON"
        Me.BasicButton1.TextAlternate = Nothing
        Me.BasicButton1.UseVisualStyleBackColor = True
        Me.BasicButton1.ValueToWrite = 0
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "192.168.0.10"
        Me.EthernetIPforCLXCom1.PollRateOverride = 500
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(683, 582)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SERVO JOG"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PilotLight3 As AdvancedHMIControls.PilotLight
    Friend WithEvents Label7 As Label
    Friend WithEvents BasicButton2 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton5 As AdvancedHMIControls.BasicButton
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PilotLight1 As AdvancedHMIControls.PilotLight
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BasicButton3 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents BasicButton4 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton7 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton6 As AdvancedHMIControls.BasicButton
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
End Class
