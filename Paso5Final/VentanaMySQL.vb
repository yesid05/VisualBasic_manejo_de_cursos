Public Class VentanaMySQL
    Private Sub AbrirVentanaVideo()
        Dim vv As New VentanaVideo(VentanaCursos.VENTANA_MYSQL)
        vv.Show()
        Dispose()
    End Sub

    Private Sub AbrirVentanaAudio()
        Dim va As New VentanaAudio(VentanaCursos.VENTANA_MYSQL)
        va.Show()
        Dispose()
    End Sub


    Private Sub AbrirVentanaTexto()
        Dim vt As New VentanaTexto(VentanaCursos.VENTANA_MYSQL)
        vt.Show()
        Dispose()
    End Sub

    Private Sub AbrirVentanaImagen()
        Dim vi As New VentanaImagen(VentanaCursos.VENTANA_MYSQL)
        vi.Show()
        Dispose()
    End Sub
    Private Sub Salir()
        Dim VC As New VentanaCursos()
        VC.Show()
        Dispose()
    End Sub
    ' Ventana Video
    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        AbrirVentanaVideo()
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        AbrirVentanaVideo()
    End Sub

    Private Sub Label1_MouseClick(sender As Object, e As MouseEventArgs) Handles Label1.MouseClick
        AbrirVentanaVideo()
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        Cursor = Cursors.Hand
    End Sub

    ' Ventana Audio
    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick
        AbrirVentanaAudio()
    End Sub

    Private Sub PictureBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseClick
        AbrirVentanaAudio()
    End Sub

    Private Sub Label2_MouseClick(sender As Object, e As MouseEventArgs) Handles Label2.MouseClick
        AbrirVentanaAudio()
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        Cursor = Cursors.Hand
    End Sub

    ' Ventana Texto
    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        AbrirVentanaTexto()
    End Sub

    Private Sub PictureBox3_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseClick
        AbrirVentanaTexto()
    End Sub

    Private Sub Label3_MouseClick(sender As Object, e As MouseEventArgs) Handles Label3.MouseClick
        AbrirVentanaTexto()
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        Cursor = Cursors.Hand
    End Sub

    'Ventana Imagen
    Private Sub Panel4_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel4.MouseClick
        AbrirVentanaImagen()
    End Sub

    Private Sub PictureBox4_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseClick
        AbrirVentanaImagen()
    End Sub

    Private Sub Label4_MouseClick(sender As Object, e As MouseEventArgs) Handles Label4.MouseClick
        AbrirVentanaImagen()
    End Sub

    Private Sub Panel4_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel4.MouseMove
        Cursor = Cursors.Hand
    End Sub

    ' Mouse por defecto en toda la ventana
    Private Sub VentanaMySQL_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Cursor = Cursors.Default
    End Sub

    Private Sub VentanaMySQL_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        salir()
    End Sub

    Private Sub MenúPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenúPrincipalToolStripMenuItem.Click
        salir()
    End Sub

    Private Sub RealizarPruebaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RealizarPruebaToolStripMenuItem.Click
        Dim VMP As New VentanaMySQLPrueba()
        VMP.Show()
        Dispose()
    End Sub
End Class