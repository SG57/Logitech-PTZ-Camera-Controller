Imports PTZ
Imports System.Reflection

Public Class Main

    Public ReadOnly Property DEVICE_NAME As String
        Get
            Return "BCC950 ConferenceCam"
        End Get
    End Property



    Public Enum Command
        None = -1
        PanLeft = Keys.Left
        PanRight = Keys.Right
        PanUp = Keys.Up
        PanDown = Keys.Down
        ZoomIn = Keys.Home
        ZoomOut = Keys.End
    End Enum



    Public Property CurrentCommand As Command = Command.None

    Public Property Dragging As Boolean = False
    Public Property StartX As Integer
    Public Property StartY As Integer



    Private Sub Main_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Left = My.Settings.Left
        Me.Top = My.Settings.Top
        Me.Opacity = My.Settings.Opacity
        Me.sliderOpacity.Value = Me.Opacity * 100
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Left = Me.Left
        My.Settings.Top = Me.Top
        My.Settings.Opacity = Me.Opacity
        My.Settings.Save()
    End Sub



    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MessageBox.Show("Freeware created out of necessity, this little guy allows you to control the Pan-Tilt-Zoom of a Logitech " & DEVICE_NAME & " using on-screen buttons or the arrow-keys & home-end (for zoom)" & Environment.NewLine & Environment.NewLine & "Copyright 2015 - SG57productions.com", "About Logitech PTZ Camera Controller v" & Assembly.GetExecutingAssembly().GetName().Version.ToString, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnDonate_Click(sender As Object, e As EventArgs) Handles btnDonate.Click
        Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=JordanSg57%40gmail%2ecom&lc=US&item_name=Freelance%20Developer&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHosted")
    End Sub



    Private Sub sliderOpacity_Scroll(sender As Object, e As EventArgs) Handles sliderOpacity.Scroll
        Me.Opacity = sliderOpacity.Value / 100.0
    End Sub



    Private Sub btn_Down(sender As Object, e As EventArgs) Handles btnUp.MouseDown, btnDown.MouseDown, btnLeft.MouseDown, btnRight.MouseDown, btnZoomIn.MouseDown, btnZoomOut.MouseDown
        If sender Is btnUp Then
            CurrentCommand = Command.PanUp
        ElseIf sender Is btnDown Then
            CurrentCommand = Command.PanDown
        ElseIf sender Is btnLeft Then
            CurrentCommand = Command.PanLeft
        ElseIf sender Is btnRight Then
            CurrentCommand = Command.PanRight
        ElseIf sender Is btnZoomIn Then
            CurrentCommand = Command.ZoomIn
        ElseIf sender Is btnZoomOut Then
            CurrentCommand = Command.ZoomOut
        End If

        Me.timerCommands.Start()
    End Sub

    Private Sub btn_Up(sender As Object, e As EventArgs) Handles btnUp.MouseUp, btnDown.MouseUp, btnLeft.MouseUp, btnRight.MouseUp, btnZoomIn.MouseUp, btnZoomOut.MouseUp
        Me.timerCommands.Stop()
    End Sub


    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, keyData As System.Windows.Forms.Keys) As Boolean
        For Each cmd In System.Enum.GetValues(GetType(Command))
            If cmd = keyData Then
                CurrentCommand = cmd
                ProcessCommand(CurrentCommand)
                Return True ' suppress default handling of arrow keys and stuff
            End If
        Next

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function



    Private Sub btnMove_MouseDown(sender As Object, e As MouseEventArgs) Handles btnMove.MouseDown
        Dragging = True
        StartX = Windows.Forms.Cursor.Position.X - Me.Left
        StartY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub btnMove_MouseUp(sender As Object, e As MouseEventArgs) Handles btnMove.MouseUp
        Dragging = False
    End Sub

    Private Sub btnMove_MouseMove(sender As Object, e As MouseEventArgs) Handles btnMove.MouseMove
        If Dragging Then
            Me.Left = Windows.Forms.Cursor.Position.X - StartX
            Me.Top = Windows.Forms.Cursor.Position.Y - StartY
        End If
    End Sub



    Private Sub timerCommands_Tick(sender As Object, e As EventArgs) Handles timerCommands.Tick
        ProcessCommand(CurrentCommand)
    End Sub



    Private Sub ProcessCommand(ByVal cmd As Command)
        Select Case cmd
            Case Command.PanDown
                PTZDevice.GetDevice(DEVICE_NAME, PTZType.Relative).Move(0, -1)
            Case Command.PanUp
                PTZDevice.GetDevice(DEVICE_NAME, PTZType.Relative).Move(0, 1)
            Case Command.PanRight
                PTZDevice.GetDevice(DEVICE_NAME, PTZType.Relative).Move(1, 0)
            Case Command.PanLeft
                PTZDevice.GetDevice(DEVICE_NAME, PTZType.Relative).Move(-1, 0)
            Case Command.ZoomIn
                PTZDevice.GetDevice(DEVICE_NAME, PTZType.Relative).Zoom(1)
            Case Command.ZoomOut
                PTZDevice.GetDevice(DEVICE_NAME, PTZType.Relative).Zoom(-1)
        End Select
    End Sub
End Class
