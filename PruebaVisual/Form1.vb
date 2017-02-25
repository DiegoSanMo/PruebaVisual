Public Class Form1
    Dim px, py As Integer
    Dim mover As Boolean

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Dispose()

    End Sub

    Private Sub btnMensaje_Click(sender As Object, e As EventArgs) Handles btnMensaje.Click
        lblMensaje.Text = "Hola Mani"
    End Sub

    Private Sub btnCambiar2_Click(sender As Object, e As EventArgs) Handles btnCambiar2.Click
        lblMensaje2.Text = "Hola Tío, ya no vayas :v"
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        px = e.X
        py = e.Y
        mover = True

    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        mover = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Move(sender As Object, e As EventArgs) Handles PictureBox1.Move
        If mover Then
            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - px, Me.MousePosition.Y - Me.Location.Y - py))

        End If
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        txtResultado.Text = Integer.Parse(txtNum1.Text) + Integer.Parse(txtNum2.Text)
    End Sub
End Class
