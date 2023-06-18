<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kef
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(kef))
        Me.pbPanel = New System.Windows.Forms.Panel()
        Me.kepernyoPb = New System.Windows.Forms.PictureBox()
        Me.gombsavPanel = New System.Windows.Forms.Panel()
        Me.combHelyiMegjelenites = New System.Windows.Forms.ComboBox()
        Me.cbMentes = New System.Windows.Forms.ComboBox()
        Me.cbMinoseg = New System.Windows.Forms.ComboBox()
        Me.ddlFps = New System.Windows.Forms.ComboBox()
        Me.btnMon1 = New System.Windows.Forms.Button()
        Me.btnMon2 = New System.Windows.Forms.Button()
        Me.btnMon3 = New System.Windows.Forms.Button()
        Me.btnMon4 = New System.Windows.Forms.Button()
        Me.btnStartStop = New System.Windows.Forms.Button()
        Me.tmrFPS = New System.Timers.Timer()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.pbPanel.SuspendLayout()
        CType(Me.kepernyoPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gombsavPanel.SuspendLayout()
        CType(Me.tmrFPS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbPanel
        '
        Me.pbPanel.Controls.Add(Me.kepernyoPb)
        Me.pbPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbPanel.Location = New System.Drawing.Point(0, 0)
        Me.pbPanel.Name = "pbPanel"
        Me.pbPanel.Size = New System.Drawing.Size(964, 587)
        Me.pbPanel.TabIndex = 0
        '
        'kepernyoPb
        '
        Me.kepernyoPb.BackColor = System.Drawing.Color.Black
        Me.kepernyoPb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kepernyoPb.Location = New System.Drawing.Point(0, 0)
        Me.kepernyoPb.Name = "kepernyoPb"
        Me.kepernyoPb.Size = New System.Drawing.Size(964, 587)
        Me.kepernyoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.kepernyoPb.TabIndex = 1
        Me.kepernyoPb.TabStop = False
        '
        'gombsavPanel
        '
        Me.gombsavPanel.BackColor = System.Drawing.Color.Black
        Me.gombsavPanel.Controls.Add(Me.Splitter1)
        Me.gombsavPanel.Controls.Add(Me.combHelyiMegjelenites)
        Me.gombsavPanel.Controls.Add(Me.cbMentes)
        Me.gombsavPanel.Controls.Add(Me.cbMinoseg)
        Me.gombsavPanel.Controls.Add(Me.ddlFps)
        Me.gombsavPanel.Controls.Add(Me.btnMon1)
        Me.gombsavPanel.Controls.Add(Me.btnMon2)
        Me.gombsavPanel.Controls.Add(Me.btnMon3)
        Me.gombsavPanel.Controls.Add(Me.btnMon4)
        Me.gombsavPanel.Controls.Add(Me.btnStartStop)
        Me.gombsavPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gombsavPanel.Location = New System.Drawing.Point(0, 561)
        Me.gombsavPanel.Name = "gombsavPanel"
        Me.gombsavPanel.Size = New System.Drawing.Size(964, 26)
        Me.gombsavPanel.TabIndex = 0
        '
        'combHelyiMegjelenites
        '
        Me.combHelyiMegjelenites.BackColor = System.Drawing.Color.Black
        Me.combHelyiMegjelenites.Dock = System.Windows.Forms.DockStyle.Right
        Me.combHelyiMegjelenites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combHelyiMegjelenites.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.combHelyiMegjelenites.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combHelyiMegjelenites.ForeColor = System.Drawing.Color.Gainsboro
        Me.combHelyiMegjelenites.FormattingEnabled = True
        Me.combHelyiMegjelenites.Items.AddRange(New Object() {"Helyi ki", "Helyi be"})
        Me.combHelyiMegjelenites.Location = New System.Drawing.Point(4, 0)
        Me.combHelyiMegjelenites.MaxDropDownItems = 5
        Me.combHelyiMegjelenites.Name = "combHelyiMegjelenites"
        Me.combHelyiMegjelenites.Size = New System.Drawing.Size(149, 26)
        Me.combHelyiMegjelenites.TabIndex = 9
        '
        'cbMentes
        '
        Me.cbMentes.BackColor = System.Drawing.Color.Black
        Me.cbMentes.Dock = System.Windows.Forms.DockStyle.Right
        Me.cbMentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbMentes.ForeColor = System.Drawing.Color.Gainsboro
        Me.cbMentes.FormattingEnabled = True
        Me.cbMentes.Items.AddRange(New Object() {"Mentés kikapcsolva", "Mentés bekapcsolva"})
        Me.cbMentes.Location = New System.Drawing.Point(153, 0)
        Me.cbMentes.MaxDropDownItems = 5
        Me.cbMentes.Name = "cbMentes"
        Me.cbMentes.Size = New System.Drawing.Size(180, 26)
        Me.cbMentes.TabIndex = 10
        '
        'cbMinoseg
        '
        Me.cbMinoseg.BackColor = System.Drawing.Color.Black
        Me.cbMinoseg.Dock = System.Windows.Forms.DockStyle.Right
        Me.cbMinoseg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMinoseg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMinoseg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbMinoseg.ForeColor = System.Drawing.Color.Gainsboro
        Me.cbMinoseg.FormattingEnabled = True
        Me.cbMinoseg.Items.AddRange(New Object() {"alacsonyabb minőség", "magas minőség"})
        Me.cbMinoseg.Location = New System.Drawing.Point(333, 0)
        Me.cbMinoseg.MaxDropDownItems = 5
        Me.cbMinoseg.Name = "cbMinoseg"
        Me.cbMinoseg.Size = New System.Drawing.Size(202, 26)
        Me.cbMinoseg.TabIndex = 11
        '
        'ddlFps
        '
        Me.ddlFps.BackColor = System.Drawing.Color.Black
        Me.ddlFps.Dock = System.Windows.Forms.DockStyle.Right
        Me.ddlFps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlFps.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ddlFps.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ddlFps.ForeColor = System.Drawing.Color.Gainsboro
        Me.ddlFps.FormattingEnabled = True
        Me.ddlFps.Items.AddRange(New Object() {"0.5", "1", "2", "3", "4", "5", "7.5", "10", "12.5", "15", "20", "25"})
        Me.ddlFps.Location = New System.Drawing.Point(535, 0)
        Me.ddlFps.MaxDropDownItems = 5
        Me.ddlFps.Name = "ddlFps"
        Me.ddlFps.Size = New System.Drawing.Size(85, 26)
        Me.ddlFps.TabIndex = 12
        '
        'btnMon1
        '
        Me.btnMon1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnMon1.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMon1.ForeColor = System.Drawing.Color.Silver
        Me.btnMon1.Location = New System.Drawing.Point(620, 0)
        Me.btnMon1.Name = "btnMon1"
        Me.btnMon1.Size = New System.Drawing.Size(63, 26)
        Me.btnMon1.TabIndex = 0
        Me.btnMon1.Text = "Mon #1"
        Me.btnMon1.UseVisualStyleBackColor = False
        '
        'btnMon2
        '
        Me.btnMon2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnMon2.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMon2.ForeColor = System.Drawing.Color.Silver
        Me.btnMon2.Location = New System.Drawing.Point(683, 0)
        Me.btnMon2.Name = "btnMon2"
        Me.btnMon2.Size = New System.Drawing.Size(63, 26)
        Me.btnMon2.TabIndex = 1
        Me.btnMon2.Text = "Mon #2"
        Me.btnMon2.UseVisualStyleBackColor = False
        '
        'btnMon3
        '
        Me.btnMon3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnMon3.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMon3.ForeColor = System.Drawing.Color.Silver
        Me.btnMon3.Location = New System.Drawing.Point(746, 0)
        Me.btnMon3.Name = "btnMon3"
        Me.btnMon3.Size = New System.Drawing.Size(63, 26)
        Me.btnMon3.TabIndex = 2
        Me.btnMon3.Text = "Mon #3"
        Me.btnMon3.UseVisualStyleBackColor = False
        '
        'btnMon4
        '
        Me.btnMon4.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnMon4.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMon4.ForeColor = System.Drawing.Color.Silver
        Me.btnMon4.Location = New System.Drawing.Point(809, 0)
        Me.btnMon4.Name = "btnMon4"
        Me.btnMon4.Size = New System.Drawing.Size(63, 26)
        Me.btnMon4.TabIndex = 3
        Me.btnMon4.Text = "Mon #4"
        Me.btnMon4.UseVisualStyleBackColor = False
        '
        'btnStartStop
        '
        Me.btnStartStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnStartStop.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnStartStop.ForeColor = System.Drawing.Color.Silver
        Me.btnStartStop.Location = New System.Drawing.Point(872, 0)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(92, 26)
        Me.btnStartStop.TabIndex = 4
        Me.btnStartStop.Text = "Start"
        Me.btnStartStop.UseVisualStyleBackColor = False
        '
        'tmrFPS
        '
        Me.tmrFPS.Interval = 1000.0R
        Me.tmrFPS.SynchronizingObject = Me
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 26)
        Me.Splitter1.TabIndex = 13
        Me.Splitter1.TabStop = False
        '
        'kef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 587)
        Me.Controls.Add(Me.gombsavPanel)
        Me.Controls.Add(Me.pbPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(980, 625)
        Me.Name = "kef"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Screen Capture - by C2H5Cl, Aethyl-chloride"
        Me.pbPanel.ResumeLayout(False)
        CType(Me.kepernyoPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gombsavPanel.ResumeLayout(False)
        CType(Me.tmrFPS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbPanel As System.Windows.Forms.Panel
    Friend WithEvents gombsavPanel As System.Windows.Forms.Panel
    Friend WithEvents btnMon2 As System.Windows.Forms.Button
    Friend WithEvents btnMon3 As System.Windows.Forms.Button
    Friend WithEvents btnMon4 As System.Windows.Forms.Button
    Friend WithEvents btnStartStop As System.Windows.Forms.Button
    Friend WithEvents kepernyoPb As System.Windows.Forms.PictureBox
    Friend WithEvents tmrFPS As System.Timers.Timer
    Friend WithEvents btnMon1 As System.Windows.Forms.Button
    Friend WithEvents combHelyiMegjelenites As System.Windows.Forms.ComboBox
    Friend WithEvents cbMentes As System.Windows.Forms.ComboBox
    Friend WithEvents cbMinoseg As System.Windows.Forms.ComboBox
    Friend WithEvents ddlFps As System.Windows.Forms.ComboBox
    Friend WithEvents Splitter1 As Splitter
End Class
