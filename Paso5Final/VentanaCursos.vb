Public Class VentanaCursos

    Public Const VENTANA_MYSQL As Integer = 0
    Public Const VENTANA_PYTHON As Integer = 1
    Public Const VENTANA_SCRUM As Integer = 2

    Private usuario As String

    Public Sub New(unUsuario As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        usuario = unUsuario
    End Sub
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        usuario = ""
    End Sub

    Private Sub AbrirVentanaMySQL()
        Dim vMySQL As New VentanaMySQL()
        vMySQL.Show()
        Hide()
    End Sub
    Private Sub AbrirVentanaScrum()
        Dim vScrum As New VentanaScrum()
        vScrum.Show()
        Hide()
    End Sub
    Private Sub AbrirVentanaPython()
        Dim vPython As New VentanaPython()
        vPython.Show()
        Hide()
    End Sub
    Private Sub Salir()
        Application.ExitThread()
    End Sub

    Private Sub MySQLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MySQLToolStripMenuItem.Click
        AbrirVentanaMySQL()
    End Sub

    Private Sub PythonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PythonToolStripMenuItem.Click
        AbrirVentanaPython()
    End Sub

    Private Sub ScrumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScrumToolStripMenuItem.Click
        AbrirVentanaScrum()
    End Sub

    Private Sub VentanaCursos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Salir()
    End Sub

    Private Sub VentanaCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "Bienvenido " & usuario
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Salir()
    End Sub
End Class