Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Text
Imports WindowsInput.Native
Imports WindowsInput
Imports DevExpress.XtraEditors

Partial Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub

#Region " Declarations"

#Region " Drawing"

    <DllImport("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal wMsg As Int32, ByVal wParam As Boolean, ByVal lParam As Int32) As Integer
    End Function
    Private Const WM_SETREDRAW As Integer = 11

    Public Shared Sub SuspendDrawing(ByVal parent As Control)
        SendMessage(parent.Handle, WM_SETREDRAW, False, 0)
    End Sub

    Public Shared Sub ResumeDrawing(ByVal parent As Control)
        SendMessage(parent.Handle, WM_SETREDRAW, True, 0)
        parent.Refresh()
    End Sub

#End Region

    Dim Device_1 As AudioSwitcher.AudioApi.CoreAudio.CoreAudioDevice
    Dim Device_2 As AudioSwitcher.AudioApi.CoreAudio.CoreAudioDevice

#End Region

#Region " Form Load/Close"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Try
            WindowsFormsSettings.AllowRoundedWindowCorners = DevExpress.Utils.DefaultBoolean.True
        Catch ex As Exception
        End Try



        Me.Location = My.Settings.Location
        Try
            SuspendDrawing(Me)
        Catch ex As Exception

        End Try


        timer_Startup.Start()
    End Sub
    Private Sub timer_Startup_Tick(sender As Object, e As EventArgs) Handles timer_Startup.Tick
        Dim thread As New Threading.Thread(
            Sub()
                LoadVolumes(0)
            End Sub
            )
        thread.Start

        timer_Startup.Stop()
    End Sub


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Location = Me.Location
        My.Settings.Save()
    End Sub


#End Region


    Public Sub LoadVolumes(ByVal DeviceDropDown As Integer)

        Select Case DeviceDropDown
            Case 0  ' First Time Setup / Reset
                For Each device As AudioSwitcher.AudioApi.CoreAudio.CoreAudioDevice In (New AudioSwitcher.AudioApi.CoreAudio.CoreAudioController().GetPlaybackDevices)
                    If device.IsPlaybackDevice Then
                        dropdown_Device1.Properties.Items.Add(String.Format("{0}", device.FullName))
                        dropdown_Device2.Properties.Items.Add(String.Format("{0}", device.FullName))
                    End If
                Next
                Device_1 = New AudioSwitcher.AudioApi.CoreAudio.CoreAudioController().DefaultPlaybackDevice
                Device_2 = New AudioSwitcher.AudioApi.CoreAudio.CoreAudioController().DefaultPlaybackCommunicationsDevice
                dropdown_Device1.Text = Device_1.FullName
                dropdown_Device2.Text = Device_2.FullName


            Case 1  ' Device 1
                For Each d As AudioSwitcher.AudioApi.CoreAudio.CoreAudioDevice In (New AudioSwitcher.AudioApi.CoreAudio.CoreAudioController().GetPlaybackDevices)
                    If d.IsPlaybackDevice Then
                        If d.FullName = dropdown_Device1.SelectedText Then

                            Device_1 = d
                        End If
                    End If
                Next


            Case 2  ' Device 2
                For Each d As AudioSwitcher.AudioApi.CoreAudio.CoreAudioDevice In (New AudioSwitcher.AudioApi.CoreAudio.CoreAudioController().GetPlaybackDevices)
                    If d.IsPlaybackDevice Then
                        If d.FullName = dropdown_Device2.SelectedText Then

                            Device_2 = d
                        End If
                    End If
                Next



        End Select


        tb_Device1_Volume.Value = CInt(Device_1.Volume)
        tb_Device2_Volume.Value = CInt(Device_2.Volume)

        label_Loading.Visible = False
        Try
            ResumeDrawing(Me)
        Catch ex As Exception

        End Try

    End Sub



#Region " Trackbars"

    Private Sub TrackBarControl1_EditValueChanged(sender As Object, e As EventArgs) Handles tb_Device1_Volume.EditValueChanged
        Device_1.Volume = tb_Device1_Volume.Value
        label_d1.Text = tb_Device1_Volume.Value & "%"
    End Sub

    Private Sub tb_Device2_Volume_EditValueChanged(sender As Object, e As EventArgs) Handles tb_Device2_Volume.EditValueChanged
        Device_2.Volume = tb_Device2_Volume.Value
        label_d2.Text = tb_Device2_Volume.Value & "%"
    End Sub

#End Region

#Region " Buttons"

    Private Sub OpenSettings_Click(sender As Object, e As EventArgs) Handles but_OpenSettings.Click
        Dim keyboard As New InputSimulator
        keyboard.Keyboard.KeyPress(VirtualKeyCode.LWIN)
        System.Threading.Thread.Sleep(200)
        SendKeys.Send("volume mixer")
        System.Threading.Thread.Sleep(200)
        keyboard.Keyboard.KeyPress(VirtualKeyCode.RETURN)
    End Sub

    Private Sub but_Reset_Click(sender As Object, e As EventArgs) Handles but_Reset.Click
        LoadVolumes(0)
    End Sub

    Private Sub but_Open_Click(sender As Object, e As EventArgs) Handles but_Open.Click
        Process.Start("C:\Windows\System32\control.exe", "/name Microsoft.Sound")
    End Sub

#End Region

#Region " Dropdown Menus"

    Private Sub dropdown_Device1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropdown_Device1.SelectedIndexChanged
        LoadVolumes(1)
    End Sub

    Private Sub dropdown_Device2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropdown_Device2.SelectedIndexChanged
        LoadVolumes(2)
    End Sub

    Private Sub dropdown_Devices_Click(sender As Object, e As EventArgs) Handles dropdown_Device1.Click, dropdown_Device2.Click
        sender.ShowPopup()
    End Sub

    Private Sub timer_Deselect_Tick(sender As Object, e As EventArgs) Handles timer_Deselect.Tick

        Try
            dropdown_Device1.SelectionLength = 0
            ' dropdown_Device1.Cursor = Cursors.Arrow
        Catch ex As Exception
        End Try
        Try
            dropdown_Device2.SelectionLength = 0
            'dropdown_Device2.Cursor = Cursors.Arrow
        Catch ex As Exception
        End Try
    End Sub

#End Region


End Class
