Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.IO

Public Class kef

    '=========================================================
    '=            GC NÉLKÜL ZABÁLJA A MEMÓRIÁT               =
    '=========================================================

    Dim s As Screen
    Dim gr As Graphics
    Dim img As Bitmap
    Dim monitorokSzama As Integer
    Dim aktMoncsi As Integer = 0
    Dim frissitesMs As Integer = 1000
    Dim minoseg As Integer = 0 ' 0 = Fast - 1 = Quality
    Dim kepMentese As Integer = 0 ' 0 = nem 1 = igen
    Dim lekertKepkockak As Integer = 0
    Dim formX As Integer
    Dim formY As Integer
    Dim newPoint As New System.Drawing.Point()
    Dim helyiMegjelenites As Integer = 1

    '----------------------------------------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Hide()
        monitorokSzama = Screen.AllScreens.Length
        tmrFPS.Interval = frissitesMs
        tmrFPS.Enabled = False
        btnMon2.Enabled = False
        btnMon3.Enabled = False
        btnMon4.Enabled = False

        If monitorokSzama = 2 Then

            btnMon2.Enabled = Enabled

        ElseIf monitorokSzama = 3 Then

            btnMon3.Enabled = Enabled

        ElseIf monitorokSzama = 4 Then

            btnMon4.Enabled = Enabled

        End If

        cbMinoseg.SelectedIndex = 0 'alacsony => HighSpeed + 24 bpp
        ddlFps.SelectedIndex = 1 '1 FPS
        cbMentes.SelectedIndex = 0 ' nincs mentés
        combHelyiMegjelenites.SelectedIndex = 1 'van helyi megjelenítés
        Me.Show()

    End Sub

    '----------------------------------------------------------
    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click

        If btnStartStop.Text = "Start" Then

            btnStartStop.Text = "Stop"
            lekertKepkockak = 0
            tmrFPS.Start()

        ElseIf btnStartStop.Text = "Stop" Then

            btnStartStop.Text = "Start"
            cbMentes.SelectedIndex = 0
            kepMentese = 0
            tmrFPS.Stop()

        End If

    End Sub

    '----------------------------------------------------------
    Private Sub btnMon1_Click(sender As Object, e As EventArgs) Handles btnMon1.Click
        aktMoncsi = 0
    End Sub

    '----------------------------------------------------------
    Private Sub btnMon2_Click(sender As Object, e As EventArgs) Handles btnMon2.Click
        aktMoncsi = 1
    End Sub

    '----------------------------------------------------------
    Private Sub btnMon3_Click(sender As Object, e As EventArgs) Handles btnMon3.Click
        aktMoncsi = 2
    End Sub

    '----------------------------------------------------------
    Private Sub btnMon4_Click(sender As Object, e As EventArgs) Handles btnMon4.Click
        aktMoncsi = 3
    End Sub

    '----------------------------------------------------------
    Private Sub tmrFPS_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles tmrFPS.Elapsed

        tmrFPS.Stop()

        Try
            memoriaFelszab(img)
            memoriaFelszab(gr)
            Call MsPringles(aktMoncsi)
            'Call OhRay(aktMoncsi)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        tmrFPS.Start()

    End Sub

    '----------------------------------------------------------
    Private Function OhRay(ByVal moncsiSzama As Integer) As Integer ' As Bitmap

        s = Screen.AllScreens(moncsiSzama)

        If minoseg = 0 Then

            img = New Bitmap(s.Bounds.Width, s.Bounds.Height, Imaging.PixelFormat.Format16bppRgb555)
            img.SetResolution(72, 72)

        ElseIf minoseg = 1 Then

            img = New Bitmap(s.Bounds.Width, s.Bounds.Height, Imaging.PixelFormat.Format32bppArgb)
            img.SetResolution(150, 150)

        End If

        gr = Graphics.FromImage(img)
        gr.CompositingMode = Drawing2D.CompositingMode.SourceCopy

        If minoseg = 0 Then

            gr.CompositingQuality = Drawing2D.CompositingQuality.HighSpeed
            gr.SmoothingMode = Drawing2D.SmoothingMode.None

        ElseIf minoseg = 1 Then

            gr.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
            gr.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        End If

        gr.CopyFromScreen(s.Bounds.Location, Point.Empty, s.Bounds.Size)

        If helyiMegjelenites = 1 Then

            Me.kepernyoPb.Image = img

        ElseIf helyiMegjelenites = 0 Then

            Me.kepernyoPb.Image = Nothing

        End If

        If kepMentese = 1 Then

            lekertKepkockak += 1

            Dim mentesiMappa As String = Application.StartupPath & "\captured\"

            If Not Directory.Exists(mentesiMappa) Then

                Try
                    Directory.CreateDirectory(mentesiMappa)
                Catch ex As Exception
                    MessageBox.Show("Hiba a képernyőkép mentéskor! Engedély? Írási jog?", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

            End If


            If minoseg = 0 Then

                Dim fajlNev As String = mentesiMappa & "\sc_" & lekertKepkockak.ToString("0000000000") & ".jpg"
                img.Save(fajlNev, Imaging.ImageFormat.Jpeg)

            ElseIf minoseg = 1 Then

                Dim fajlNev As String = mentesiMappa & "\sc_" & lekertKepkockak.ToString("0000000000") & ".png"
                img.Save(fajlNev, Imaging.ImageFormat.Png)

            End If
        End If

        Return 0 'img

    End Function

    '----------------------------------------------------------
    Sub MsPringles(ByVal moncsiSzama As Integer)

        s = Screen.AllScreens(moncsiSzama)

        If minoseg = 0 Then

            img = New Bitmap(s.Bounds.Width, s.Bounds.Height, Imaging.PixelFormat.Format16bppRgb555)
            img.SetResolution(72, 72)

        ElseIf minoseg = 1 Then

            img = New Bitmap(s.Bounds.Width, s.Bounds.Height, Imaging.PixelFormat.Format32bppArgb)
            img.SetResolution(150, 150)

        End If

        gr = Graphics.FromImage(img)
        gr.CompositingMode = Drawing2D.CompositingMode.SourceCopy

        If minoseg = 0 Then

            gr.CompositingQuality = Drawing2D.CompositingQuality.HighSpeed
            gr.SmoothingMode = Drawing2D.SmoothingMode.None

        ElseIf minoseg = 1 Then

            gr.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
            gr.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        End If

        gr.CopyFromScreen(s.Bounds.Location, Point.Empty, s.Bounds.Size)

        If helyiMegjelenites = 1 Then

            Me.kepernyoPb.Image = img

        ElseIf helyiMegjelenites = 0 Then

            Me.kepernyoPb.Image = Nothing

        End If


        If kepMentese = 1 Then

            lekertKepkockak += 1

            Dim mentesiMappa As String = Application.StartupPath & "\captured"

            If Not Directory.Exists(mentesiMappa) Then

                Try
                    Directory.CreateDirectory(mentesiMappa)
                Catch ex As Exception
                    MessageBox.Show("Hiba a képernyőkép mentéskor! Engedély? Írási jog?", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

            End If


            If minoseg = 0 Then

                Dim fajlNev As String = mentesiMappa & "\sc_" & lekertKepkockak.ToString("0000000000") & ".jpg"
                img.Save(fajlNev, Imaging.ImageFormat.Jpeg)

            ElseIf minoseg = 1 Then

                Dim fajlNev As String = mentesiMappa & "\sc_" & lekertKepkockak.ToString("0000000000") & ".png"
                img.Save(fajlNev, Imaging.ImageFormat.Png)

            End If
        End If

    End Sub

    '----------------------------------------------------------
    Private Sub memoriaFelszab(ByVal obj As Object)

        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try

    End Sub

    '----------------------------------------------------------
    Private Sub kepernyoPb_DoubleClick(sender As Object, e As EventArgs) Handles kepernyoPb.DoubleClick

        If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable Then

            formX = Me.Location.X
            formY = Me.Location.Y
            gombsavPanel.Hide()
            Me.WindowState = FormWindowState.Normal
            Me.ShowIcon = True
            Me.ShowInTaskbar = True
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(formX, formY)
            Me.WindowState = FormWindowState.Maximized
            pbPanel.Size = Me.Size

        ElseIf Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then

            gombsavPanel.Show()
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Normal
            Me.ShowIcon = True
            Me.ShowInTaskbar = True

        End If

    End Sub

    '-------------------------------------------------------------------------
    ' 0.5 - 1 - 2 - 3 - 4 - 5 - 7.5 - 10 - 12.5 - 15 - 20 - 25 FPS
    '-------------------------------------------------------------------------
    Private Sub ddlFps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlFps.SelectedIndexChanged

        Select Case ddlFps.SelectedIndex

            Case 0
                '0.5 FPS
                frissitesMs = CInt(1000 / 0.5)
                tmrFPS.Interval = frissitesMs

            Case 1
                '1 FPS
                frissitesMs = 1000
                tmrFPS.Interval = frissitesMs

            Case 2
                '2 FPS
                frissitesMs = CInt(1000 / 2)
                tmrFPS.Interval = frissitesMs

            Case 3
                '3 FPS
                frissitesMs = CInt(1000 / 3)
                tmrFPS.Interval = frissitesMs

            Case 4
                '4 FPS
                frissitesMs = CInt(1000 / 4)
                tmrFPS.Interval = frissitesMs

            Case 5
                '5 FPS
                frissitesMs = CInt(1000 / 5)
                tmrFPS.Interval = frissitesMs

            Case 6
                '7.5 FPS
                frissitesMs = CInt(1000 / 7.5)
                tmrFPS.Interval = frissitesMs

            Case 7
                '10 FPS
                frissitesMs = CInt(1000 / 10)
                tmrFPS.Interval = frissitesMs

            Case 8
                '12.5 FPS
                frissitesMs = CInt(1000 / 12.5)
                tmrFPS.Interval = frissitesMs

            Case 9
                '15 FPS
                frissitesMs = CInt(1000 / 15)
                tmrFPS.Interval = frissitesMs

            Case 10
                '20 FPS
                frissitesMs = CInt(1000 / 20)
                tmrFPS.Interval = frissitesMs

            Case 11
                '25 FPS
                frissitesMs = CInt(1000 / 25)
                tmrFPS.Interval = frissitesMs

            Case Else
                '15 FPS
                frissitesMs = CInt(1000 / 15)
                tmrFPS.Interval = frissitesMs

        End Select

    End Sub

    '----------------------------------------------------------
    Private Sub cbMinoseg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMinoseg.SelectedIndexChanged

        If cbMinoseg.SelectedIndex = 0 Then

            minoseg = 0

        ElseIf cbMinoseg.SelectedIndex = 1 Then

            minoseg = 1

        End If

    End Sub

    '----------------------------------------------------------
    Private Sub cbMentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMentes.SelectedIndexChanged

        If cbMentes.SelectedIndex = 0 Then

            kepMentese = 0

        ElseIf cbMentes.SelectedIndex = 1 Then

            kepMentese = 1

        End If

    End Sub

    '----------------------------------------------------------
    Private Sub combHelyiMegjelenites_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combHelyiMegjelenites.SelectedIndexChanged

        If combHelyiMegjelenites.SelectedIndex = 0 Then

            helyiMegjelenites = 0

        ElseIf combHelyiMegjelenites.SelectedIndex = 1 Then

            helyiMegjelenites = 1

        End If

    End Sub

    '----------------------------------------------------------
    Private Sub kef_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        formX = Control.MousePosition.X - Me.Location.X
        formY = Control.MousePosition.Y - Me.Location.Y

    End Sub

    '----------------------------------------------------------
    'Form egéresemény - mozgatás
    Private Sub kef_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If e.Button = MouseButtons.Left Then

            newPoint = Control.MousePosition
            newPoint.X = newPoint.X - (formX)
            newPoint.Y = newPoint.Y - (formY)
            Me.Location = newPoint

        End If

    End Sub

    '----------------------------------------------------------
    Private Sub kepernyoPb_MouseDown(sender As Object, e As MouseEventArgs) Handles kepernyoPb.MouseDown

        formX = Control.MousePosition.X - Me.Location.X
        formY = Control.MousePosition.Y - Me.Location.Y

    End Sub

    '----------------------------------------------------------
    Private Sub kepernyoPb_MouseMove(sender As Object, e As MouseEventArgs) Handles kepernyoPb.MouseMove

        If e.Button = MouseButtons.Left Then

            newPoint = Control.MousePosition
            newPoint.X = newPoint.X - (formX)
            newPoint.Y = newPoint.Y - (formY)
            Me.Location = newPoint

        End If

    End Sub

    '----------------------------------------------------------

End Class
