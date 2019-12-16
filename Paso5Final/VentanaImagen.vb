Public Class VentanaImagen
    Dim Valor As Integer
    Dim Contador As Integer

    Public Sub New(i As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Valor = i
    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub ActualizarImagen()
        Select Case Valor
            Case VentanaCursos.VENTANA_MYSQL
                lblTitulo.Text = "Relación entre tablas."
                Imagen.Image = ListaImagenMySQL.Images(Contador)
            Case VentanaCursos.VENTANA_PYTHON
                lblTitulo.Text = "Python."
                Imagen.Image = ListaImagenPython.Images(Contador)
            Case VentanaCursos.VENTANA_SCRUM
                lblTitulo.Text = "Scrum"
                Imagen.Image = ListaImagenScrum.Images(Contador)
        End Select
    End Sub

    Private Sub VentanaImagen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case Valor
            Case VentanaCursos.VENTANA_MYSQL
                Dim vMySQL As New VentanaMySQL()
                vMySQL.Show()
                Dispose()
            Case VentanaCursos.VENTANA_PYTHON
                Dim vPython As New VentanaPython()
                vPython.Show()
                Dispose()
            Case VentanaCursos.VENTANA_SCRUM
                Dim vScrum As New VentanaScrum()
                vScrum.Show()
                Dispose()
        End Select
    End Sub

    Private Sub VentanaImagen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Contador = 0
        ActualizarImagen()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Contador = Contador + 1
        If Contador > 2 Then
            Contador = 0
        End If
        ActualizarImagen()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Contador = Contador - 1
        If Contador < 0 Then
            Contador = 2
        End If
        ActualizarImagen()
    End Sub

    Private Sub MenúPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenúPrincipalToolStripMenuItem.Click
        Dim VC As New VentanaCursos()
        VC.Show()
        Dispose()
    End Sub
End Class