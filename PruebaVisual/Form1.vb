Public Class Form1
    Dim px, py As Integer
    Dim mover As Boolean

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Dispose()

    End Sub

    Private Sub btnMensaje_Click(sender As Object, e As EventArgs) Handles btnMensaje.Click
        lblMensaje.Text = "Hola Mani"
    End Sub

    Private Sub btnCambiar2_Click(sender As Object, e As EventArgs) Handles btnCambiar2.Click
        lblMensaje2.Text = "Hola Tío, ya no vayas :v"
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs)
        px = e.X
        py = e.Y
        mover = True

    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs)
        mover = False
    End Sub

<<<<<<< HEAD
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblMensaje.Text = "Menú nuevo"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cargar.Increment(1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Timer1.Stop()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cargar.Increment(-100)
        Timer1.Start()
    End Sub



    Private Sub PictureBox1_Move(sender As Object, e As EventArgs)
=======
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Move(sender As Object, e As EventArgs) Handles PictureBox1.Move
>>>>>>> origin/master
        If mover Then
            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - px, Me.MousePosition.Y - Me.Location.Y - py))

        End If
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        txtResultado.Text = Integer.Parse(txtNum1.Text) + Integer.Parse(txtNum2.Text)
    End Sub
End Class
