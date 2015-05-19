<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnZoomIn = New System.Windows.Forms.Button()
        Me.btnZoomOut = New System.Windows.Forms.Button()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.timerCommands = New System.Windows.Forms.Timer(Me.components)
        Me.sliderOpacity = New System.Windows.Forms.TrackBar()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnDonate = New System.Windows.Forms.Button()
        CType(Me.sliderOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUp
        '
        Me.btnUp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUp.BackColor = System.Drawing.Color.White
        Me.btnUp.BackgroundImage = CType(resources.GetObject("btnUp.BackgroundImage"), System.Drawing.Image)
        Me.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUp.Location = New System.Drawing.Point(69, 7)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(86, 66)
        Me.btnUp.TabIndex = 2
        Me.btnUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'btnRight
        '
        Me.btnRight.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRight.BackColor = System.Drawing.Color.White
        Me.btnRight.BackgroundImage = CType(resources.GetObject("btnRight.BackgroundImage"), System.Drawing.Image)
        Me.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRight.Location = New System.Drawing.Point(130, 79)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(88, 64)
        Me.btnRight.TabIndex = 3
        Me.btnRight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRight.UseVisualStyleBackColor = False
        '
        'btnLeft
        '
        Me.btnLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLeft.BackColor = System.Drawing.Color.White
        Me.btnLeft.BackgroundImage = CType(resources.GetObject("btnLeft.BackgroundImage"), System.Drawing.Image)
        Me.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeft.Location = New System.Drawing.Point(6, 79)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(88, 64)
        Me.btnLeft.TabIndex = 4
        Me.btnLeft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLeft.UseVisualStyleBackColor = False
        '
        'btnDown
        '
        Me.btnDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDown.BackColor = System.Drawing.Color.White
        Me.btnDown.BackgroundImage = CType(resources.GetObject("btnDown.BackgroundImage"), System.Drawing.Image)
        Me.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDown.Location = New System.Drawing.Point(69, 149)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(86, 66)
        Me.btnDown.TabIndex = 5
        Me.btnDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'btnZoomIn
        '
        Me.btnZoomIn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnZoomIn.BackColor = System.Drawing.Color.White
        Me.btnZoomIn.BackgroundImage = CType(resources.GetObject("btnZoomIn.BackgroundImage"), System.Drawing.Image)
        Me.btnZoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZoomIn.Location = New System.Drawing.Point(100, 79)
        Me.btnZoomIn.Name = "btnZoomIn"
        Me.btnZoomIn.Size = New System.Drawing.Size(24, 29)
        Me.btnZoomIn.TabIndex = 6
        Me.btnZoomIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnZoomIn.UseVisualStyleBackColor = False
        '
        'btnZoomOut
        '
        Me.btnZoomOut.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnZoomOut.BackColor = System.Drawing.Color.White
        Me.btnZoomOut.BackgroundImage = CType(resources.GetObject("btnZoomOut.BackgroundImage"), System.Drawing.Image)
        Me.btnZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZoomOut.Location = New System.Drawing.Point(100, 114)
        Me.btnZoomOut.Name = "btnZoomOut"
        Me.btnZoomOut.Size = New System.Drawing.Size(24, 29)
        Me.btnZoomOut.TabIndex = 7
        Me.btnZoomOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnZoomOut.UseVisualStyleBackColor = False
        '
        'btnMove
        '
        Me.btnMove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMove.BackColor = System.Drawing.Color.White
        Me.btnMove.BackgroundImage = CType(resources.GetObject("btnMove.BackgroundImage"), System.Drawing.Image)
        Me.btnMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMove.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMove.Location = New System.Drawing.Point(161, 53)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(20, 20)
        Me.btnMove.TabIndex = 8
        Me.btnMove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnMove.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(187, 58)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(15, 15)
        Me.btnClose.TabIndex = 9
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'timerCommands
        '
        Me.timerCommands.Interval = 20
        '
        'sliderOpacity
        '
        Me.sliderOpacity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sliderOpacity.AutoSize = False
        Me.sliderOpacity.LargeChange = 1
        Me.sliderOpacity.Location = New System.Drawing.Point(155, 27)
        Me.sliderOpacity.Maximum = 100
        Me.sliderOpacity.Minimum = 30
        Me.sliderOpacity.Name = "sliderOpacity"
        Me.sliderOpacity.Size = New System.Drawing.Size(70, 25)
        Me.sliderOpacity.TabIndex = 10
        Me.sliderOpacity.TabStop = False
        Me.sliderOpacity.TickStyle = System.Windows.Forms.TickStyle.None
        Me.sliderOpacity.Value = 75
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.BackColor = System.Drawing.Color.White
        Me.btnHelp.BackgroundImage = CType(resources.GetObject("btnHelp.BackgroundImage"), System.Drawing.Image)
        Me.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Location = New System.Drawing.Point(187, 149)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(15, 15)
        Me.btnHelp.TabIndex = 11
        Me.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnDonate
        '
        Me.btnDonate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDonate.BackColor = System.Drawing.Color.White
        Me.btnDonate.BackgroundImage = CType(resources.GetObject("btnDonate.BackgroundImage"), System.Drawing.Image)
        Me.btnDonate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDonate.Location = New System.Drawing.Point(161, 149)
        Me.btnDonate.Name = "btnDonate"
        Me.btnDonate.Size = New System.Drawing.Size(20, 20)
        Me.btnDonate.TabIndex = 12
        Me.btnDonate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDonate.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(225, 225)
        Me.Controls.Add(Me.btnDonate)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.btnZoomOut)
        Me.Controls.Add(Me.btnZoomIn)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.sliderOpacity)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.Opacity = 0.75R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "PTZ Camera Controller"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.sliderOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnZoomIn As System.Windows.Forms.Button
    Friend WithEvents btnZoomOut As System.Windows.Forms.Button
    Friend WithEvents btnMove As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents timerCommands As System.Windows.Forms.Timer
    Friend WithEvents sliderOpacity As System.Windows.Forms.TrackBar
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnDonate As System.Windows.Forms.Button

End Class
