Public Class VentanaVideo

    Dim valor As Integer

    Public Sub New(i As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        valor = i
    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub VentanaVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case valor
            Case VentanaCursos.VENTANA_MYSQL
                ReproductorVideo.URL = "c:\JoseRodrigoRomero\video\SubConsultas.mp4"
            Case VentanaCursos.VENTANA_PYTHON
                ReproductorVideo.URL = "c:\JoseRodrigoRomero\video\python.mp4"
            Case VentanaCursos.VENTANA_SCRUM
                ReproductorVideo.URL = "c:\JoseRodrigoRomero\video\Scrum.mp4"
        End Select
    End Sub

    Private Sub VentanaVideo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case valor
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

    Private Sub MenúPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenúPrincipalToolStripMenuItem.Click
        Dim VC As New VentanaCursos()
        VC.Show()
        Dispose()
    End Sub
End Class