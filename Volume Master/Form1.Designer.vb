Imports DevExpress.XtraEditors

Partial Public Class Form1
    Inherits DevExpress.XtraEditors.XtraForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TrackBarLabel1 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
        Dim TrackBarLabel2 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label_d1 = New System.Windows.Forms.Label()
        Me.label_d2 = New System.Windows.Forms.Label()
        Me.but_Reset = New DevExpress.XtraEditors.SimpleButton()
        Me.but_Open = New DevExpress.XtraEditors.SimpleButton()
        Me.but_OpenSettings = New DevExpress.XtraEditors.SimpleButton()
        Me.timer_Startup = New System.Windows.Forms.Timer(Me.components)
        Me.label_Loading = New System.Windows.Forms.Label()
        Me.dropdown_Device2 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dropdown_Device1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.tb_Device2_Volume = New DevExpress.XtraEditors.TrackBarControl()
        Me.tb_Device1_Volume = New DevExpress.XtraEditors.TrackBarControl()
        Me.timer_Deselect = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dropdown_Device2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dropdown_Device1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_Device2_Volume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_Device2_Volume.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_Device1_Volume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_Device1_Volume.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Device 1: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Device 2: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'label_d1
        '
        Me.label_d1.Location = New System.Drawing.Point(231, 57)
        Me.label_d1.Name = "label_d1"
        Me.label_d1.Size = New System.Drawing.Size(158, 13)
        Me.label_d1.TabIndex = 3
        Me.label_d1.Text = "100%"
        Me.label_d1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label_d2
        '
        Me.label_d2.Location = New System.Drawing.Point(231, 113)
        Me.label_d2.Name = "label_d2"
        Me.label_d2.Size = New System.Drawing.Size(158, 13)
        Me.label_d2.TabIndex = 3
        Me.label_d2.Text = "100%"
        Me.label_d2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'but_Reset
        '
        Me.but_Reset.AllowFocus = False
        Me.but_Reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.but_Reset.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_Reset.Appearance.Options.UseFont = True
        Me.but_Reset.Location = New System.Drawing.Point(347, 161)
        Me.but_Reset.Name = "but_Reset"
        Me.but_Reset.Size = New System.Drawing.Size(50, 35)
        Me.but_Reset.TabIndex = 7
        Me.but_Reset.Text = "Reset"
        '
        'but_Open
        '
        Me.but_Open.AllowFocus = False
        Me.but_Open.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.but_Open.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.but_Open.Appearance.Options.UseFont = True
        Me.but_Open.Location = New System.Drawing.Point(229, 130)
        Me.but_Open.Name = "but_Open"
        Me.but_Open.Size = New System.Drawing.Size(168, 25)
        Me.but_Open.TabIndex = 5
        Me.but_Open.Text = "Volume Mixer Classic"
        '
        'but_OpenSettings
        '
        Me.but_OpenSettings.AllowFocus = False
        Me.but_OpenSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.but_OpenSettings.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_OpenSettings.Appearance.Options.UseFont = True
        Me.but_OpenSettings.Location = New System.Drawing.Point(229, 161)
        Me.but_OpenSettings.Name = "but_OpenSettings"
        Me.but_OpenSettings.Size = New System.Drawing.Size(112, 35)
        Me.but_OpenSettings.TabIndex = 6
        Me.but_OpenSettings.Text = "Volume Mixer"
        '
        'timer_Startup
        '
        Me.timer_Startup.Interval = 1500
        '
        'label_Loading
        '
        Me.label_Loading.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.label_Loading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label_Loading.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.label_Loading.Location = New System.Drawing.Point(0, 0)
        Me.label_Loading.Name = "label_Loading"
        Me.label_Loading.Size = New System.Drawing.Size(409, 208)
        Me.label_Loading.TabIndex = 8
        Me.label_Loading.Text = "Loading ..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please Wait"
        Me.label_Loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dropdown_Device2
        '
        Me.dropdown_Device2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.dropdown_Device2.Location = New System.Drawing.Point(12, 89)
        Me.dropdown_Device2.Name = "dropdown_Device2"
        Me.dropdown_Device2.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.[True]
        Me.dropdown_Device2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropdown_Device2.Properties.Appearance.Options.UseFont = True
        Me.dropdown_Device2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dropdown_Device2.Properties.Sorted = True
        Me.dropdown_Device2.Size = New System.Drawing.Size(213, 28)
        Me.dropdown_Device2.TabIndex = 3
        '
        'dropdown_Device1
        '
        Me.dropdown_Device1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.dropdown_Device1.Location = New System.Drawing.Point(12, 33)
        Me.dropdown_Device1.Name = "dropdown_Device1"
        Me.dropdown_Device1.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.[True]
        Me.dropdown_Device1.Properties.AllowFocused = False
        Me.dropdown_Device1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropdown_Device1.Properties.Appearance.Options.UseFont = True
        Me.dropdown_Device1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dropdown_Device1.Properties.Sorted = True
        Me.dropdown_Device1.Size = New System.Drawing.Size(213, 28)
        Me.dropdown_Device1.TabIndex = 1
        '
        'tb_Device2_Volume
        '
        Me.tb_Device2_Volume.EditValue = Nothing
        Me.tb_Device2_Volume.Location = New System.Drawing.Point(231, 81)
        Me.tb_Device2_Volume.Name = "tb_Device2_Volume"
        Me.tb_Device2_Volume.Properties.AllowFocused = False
        Me.tb_Device2_Volume.Properties.LabelAppearance.Options.UseTextOptions = True
        Me.tb_Device2_Volume.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        TrackBarLabel1.Label = ""
        Me.tb_Device2_Volume.Properties.Labels.AddRange(New DevExpress.XtraEditors.Repository.TrackBarLabel() {TrackBarLabel1})
        Me.tb_Device2_Volume.Properties.Maximum = 100
        Me.tb_Device2_Volume.Properties.TickStyle = System.Windows.Forms.TickStyle.None
        Me.tb_Device2_Volume.Size = New System.Drawing.Size(158, 45)
        Me.tb_Device2_Volume.TabIndex = 4
        '
        'tb_Device1_Volume
        '
        Me.tb_Device1_Volume.EditValue = Nothing
        Me.tb_Device1_Volume.Location = New System.Drawing.Point(231, 25)
        Me.tb_Device1_Volume.Name = "tb_Device1_Volume"
        Me.tb_Device1_Volume.Properties.AllowFocused = False
        Me.tb_Device1_Volume.Properties.LabelAppearance.Options.UseTextOptions = True
        Me.tb_Device1_Volume.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        TrackBarLabel2.Label = ""
        Me.tb_Device1_Volume.Properties.Labels.AddRange(New DevExpress.XtraEditors.Repository.TrackBarLabel() {TrackBarLabel2})
        Me.tb_Device1_Volume.Properties.Maximum = 100
        Me.tb_Device1_Volume.Properties.TickStyle = System.Windows.Forms.TickStyle.None
        Me.tb_Device1_Volume.Size = New System.Drawing.Size(158, 45)
        Me.tb_Device1_Volume.TabIndex = 2
        '
        'timer_Deselect
        '
        Me.timer_Deselect.Enabled = True
        Me.timer_Deselect.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 208)
        Me.Controls.Add(Me.label_Loading)
        Me.Controls.Add(Me.but_OpenSettings)
        Me.Controls.Add(Me.dropdown_Device2)
        Me.Controls.Add(Me.dropdown_Device1)
        Me.Controls.Add(Me.but_Open)
        Me.Controls.Add(Me.but_Reset)
        Me.Controls.Add(Me.label_d2)
        Me.Controls.Add(Me.label_d1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_Device2_Volume)
        Me.Controls.Add(Me.tb_Device1_Volume)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Image = Global.Volume_Master.My.Resources.Resources.icons8_voice_96
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Volume Control"
        CType(Me.dropdown_Device2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dropdown_Device1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_Device2_Volume.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_Device2_Volume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_Device1_Volume.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_Device1_Volume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_Device1_Volume As DevExpress.XtraEditors.TrackBarControl
    Friend WithEvents tb_Device2_Volume As DevExpress.XtraEditors.TrackBarControl
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents label_d1 As Label
    Friend WithEvents label_d2 As Label
    Friend WithEvents but_Reset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents but_Open As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dropdown_Device1 As ComboBoxEdit
    Friend WithEvents dropdown_Device2 As ComboBoxEdit
    Friend WithEvents but_OpenSettings As SimpleButton
    Friend WithEvents timer_Startup As Timer
    Friend WithEvents label_Loading As Label
    Friend WithEvents timer_Deselect As Timer

#End Region

End Class
