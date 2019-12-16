Public Class VentanaScrumPrueba
    Dim modulo As Integer
    Dim tiempo As Integer
    Dim nota As Integer

    ' Pregunta 1
    Dim pregunta1 As String
    Dim rPregunta1_1 As String
    Dim rPregunta1_2 As String
    Dim rPregunta1_3 As String

    ' Pregnta 2
    Dim pregunta2 As String
    Dim rPregunta2_1 As String
    Dim rPregunta2_2 As String
    Dim rPregunta2_3 As String

    ' Pregunta 3
    Dim pregunta3 As String
    Dim rPregunta3_1 As String
    Dim rPregunta3_2 As String
    Dim rPregunta3_3 As String

    ' Pregunta 4
    Dim pregunta4 As String
    Dim rPregunta4_1 As String
    Dim rPregunta4_2 As String
    Dim rPregunta4_3 As String

    ' Pregunta 5
    Dim pregunta5 As String
    Dim rPregunta5_1 As String
    Dim rPregunta5_2 As String
    Dim rPregunta5_3 As String

    ' Pregunta 6
    Dim pregunta6 As String
    Dim rPregunta6_1 As String
    Dim rPregunta6_2 As String
    Dim rPregunta6_3 As String

    ' Pregunta 7
    Dim pregunta7 As String
    Dim rPregunta7_1 As String
    Dim rPregunta7_2 As String
    Dim rPregunta7_3 As String

    ' Pregunta 8
    Dim pregunta8 As String
    Dim rPregunta8_1 As String
    Dim rPregunta8_2 As String
    Dim rPregunta8_3 As String

    ' Pregunta 9
    Dim pregunta9 As String
    Dim rPregunta9_1 As String
    Dim rPregunta9_2 As String
    Dim rPregunta9_3 As String

    ' Pregunta 10
    Dim pregunta10 As String
    Dim rPregunta10_1 As String
    Dim rPregunta10_2 As String
    Dim rPregunta10_3 As String

    ' Modulo 1
    Private Sub cargarPreguntaM1_1()
        pregunta1 = "1.	Scrum es considerado una metodología:"
        rPregunta1_1 = "Agil."
        rPregunta1_2 = "Espiral."
        rPregunta1_3 = "Prototipo."

    End Sub

    Private Sub cargarPreguntaM1_2()
        pregunta2 = "2.	Scrum puede ser utilizado por grandes y pequeñas empresas:"
        rPregunta2_1 = "Si."
        rPregunta2_2 = "No."
        rPregunta2_3 = "Solo sirve para grandes empresas."

    End Sub
    Private Sub cargarPreguntaM1_3()
        pregunta3 = "3.	Scrum sirve para desarrollar productos y servicios:"
        rPregunta3_1 = "Solo productos."
        rPregunta3_2 = "Solo servicios."
        rPregunta3_3 = "Productos y servicios."

    End Sub
    Private Sub cargarPreguntaM1_4()
        pregunta4 = "4.	Scrum permite el trabajo en paralelo:"
        rPregunta4_1 = "Si."
        rPregunta4_2 = "No."
        rPregunta4_3 = "Trabaja de forma lineal."

    End Sub
    Private Sub cargarPreguntaM1_5()
        pregunta5 = "5.	El desarrollo ágil consiste en:"
        rPregunta5_1 = "Entrega de mejoras continuas en el desarrollo del producto."
        rPregunta5_2 = "Desarrollo del producto en un mes."
        rPregunta5_3 = "Escribir rápido."

    End Sub
    Private Sub cargarPreguntaM1_6()
        pregunta6 = "6.	Scrum permite el intercambio de roles:"
        rPregunta6_1 = "Los roles son permanentes en scrum."
        rPregunta6_2 = "Scrum no tiene roles."
        rPregunta6_3 = "Scrum si permite el intercambio de roles."

    End Sub
    Private Sub cargarPreguntaM1_7()
        pregunta7 = "7.	Las entregas de proyecto rápidas permite:"
        rPregunta7_1 = "Ahorrar costos, identificar errores, adaptación a cambios."
        rPregunta7_2 = "Ahorrar costos, entregar rápido el producto."
        rPregunta7_3 = "Entregar rápido el producto, Identificar errores."

    End Sub
    Private Sub cargarPreguntaM1_8()
        pregunta8 = "8.	Los roles en Scrum son:"
        rPregunta8_1 = "Clientes, usuario, equipo."
        rPregunta8_2 = "Dueño del producto, scrum master, equipo."
        rPregunta8_3 = "Equipo, cliente, scrum master."
    End Sub
    Private Sub cargarPreguntaM1_9()
        pregunta9 = "9.	La función de scrum master es:"
        rPregunta9_1 = "Coordinar y facilitar los requisitos en un ciclo sprint."
        rPregunta9_2 = "Solo se comunica con el cliente."
        rPregunta9_3 = "Solo vigila que el equipo trabaje."
    End Sub
    Private Sub cargarPreguntaM1_10()
        pregunta10 = "10. Cuánto tiempo se recomienda que dure un ciclo:"
        rPregunta10_1 = "Un año."
        rPregunta10_2 = "Seis meses."
        rPregunta10_3 = "De dos a tres semanas."
    End Sub
    Private Sub cargarModulo1()

        modulo = 0

        cargarPreguntaM1_1()
        cargarPreguntaM1_2()
        cargarPreguntaM1_3()
        cargarPreguntaM1_4()
        cargarPreguntaM1_5()
        cargarPreguntaM1_6()
        cargarPreguntaM1_7()
        cargarPreguntaM1_8()
        cargarPreguntaM1_9()
        cargarPreguntaM1_10()

        lblPregunta1.Text = pregunta1
        rdbPregunta1_1.Text = rPregunta1_1
        rdbPregunta1_2.Text = rPregunta1_2
        rdbPregunta1_3.Text = rPregunta1_3

        lblPregunta2.Text = pregunta2
        rdbPregunta2_1.Text = rPregunta2_1
        rdbPregunta2_2.Text = rPregunta2_2
        rdbPregunta2_3.Text = rPregunta2_3

        lblPregunta3.Text = pregunta3
        rdbPregunta3_1.Text = rPregunta3_1
        rdbPregunta3_2.Text = rPregunta3_2
        rdbPregunta3_3.Text = rPregunta3_3

        lblPregunta4.Text = pregunta4
        rdbPregunta4_1.Text = rPregunta4_1
        rdbPregunta4_2.Text = rPregunta4_2
        rdbPregunta4_3.Text = rPregunta4_3

        lblPregunta5.Text = pregunta5
        rdbPregunta5_1.Text = rPregunta5_1
        rdbPregunta5_2.Text = rPregunta5_2
        rdbPregunta5_3.Text = rPregunta5_3

        lblPregunta6.Text = pregunta6
        rdbPregunta6_1.Text = rPregunta6_1
        rdbPregunta6_2.Text = rPregunta6_2
        rdbPregunta6_3.Text = rPregunta6_3

        lblPregunta7.Text = pregunta7
        rdbPregunta7_1.Text = rPregunta7_1
        rdbPregunta7_2.Text = rPregunta7_2
        rdbPregunta7_3.Text = rPregunta7_3

        lblPregunta8.Text = pregunta8
        rdbPregunta8_1.Text = rPregunta8_1
        rdbPregunta8_2.Text = rPregunta8_2
        rdbPregunta8_3.Text = rPregunta8_3

        lblPregunta9.Text = pregunta9
        rdbPregunta9_1.Text = rPregunta9_1
        rdbPregunta9_2.Text = rPregunta9_2
        rdbPregunta9_3.Text = rPregunta9_3

        lblPregunta10.Text = pregunta10
        rdbPregunta10_1.Text = rPregunta10_1
        rdbPregunta10_2.Text = rPregunta10_2
        rdbPregunta10_3.Text = rPregunta10_3
    End Sub
    ' Fin modulo 1

    ' Modulo 2
    Private Sub cargarPreguntaM2_1()
        pregunta1 = "1.	Backlog está compuesto por:"
        rPregunta1_1 = "Historias de usuario."
        rPregunta1_2 = "Casos de uso."
        rPregunta1_3 = "Requerimientos no funcionales."

    End Sub

    Private Sub cargarPreguntaM2_2()
        pregunta2 = "2.	En scrum que es un sprint:"
        rPregunta2_1 = "Un ciclo de desarrollo del producto."
        rPregunta2_2 = "Un rol en scrum."
        rPregunta2_3 = "Ninguna de las anteriores."

    End Sub
    Private Sub cargarPreguntaM2_3()
        pregunta3 = "3.	Las historias de usuario se pueden entender como:"
        rPregunta3_1 = "Historias del producto."
        rPregunta3_2 = "Versiones anteriores del producto."
        rPregunta3_3 = "Requisitos funcionales."

    End Sub
    Private Sub cargarPreguntaM2_4()
        pregunta4 = "4.	La forma correcta de redactar una historia de usuario es:"
        rPregunta4_1 = "El sistema debe permitir ____."
        rPregunta4_2 = "El usuario debe ____."
        rPregunta4_3 = "El producto realiza ____."

    End Sub
    Private Sub cargarPreguntaM2_5()
        pregunta5 = "5.	Que es el Backlog de liberación:"
        rPregunta5_1 = "Es igual al Backlog del producto."
        rPregunta5_2 = "Se realiza antes del Backlog del producto."
        rPregunta5_3 = "Contiene las historias de usuario a ser desarrolladas."

    End Sub
    Private Sub cargarPreguntaM2_6()
        pregunta6 = "6.	Las historias de usuario se pueden dividir en porciones de tiempo:"
        rPregunta6_1 = "Si."
        rPregunta6_2 = "No."
        rPregunta6_3 = "Scrum no lo permite."

    End Sub
    Private Sub cargarPreguntaM2_7()
        pregunta7 = "7.	Que es el Bordown Chart en Scrum:"
        rPregunta7_1 = "Un sistema de gráficos."
        rPregunta7_2 = "Medición de trabajo día a día."
        rPregunta7_3 = "Ninguna de las anteriores."

    End Sub
    Private Sub cargarPreguntaM2_8()
        pregunta8 = "8.	Que es el Bordown Velocity:"
        rPregunta8_1 = "Velocidad de trabajo."
        rPregunta8_2 = "Tasa de productividad promedio de cada dia."
        rPregunta8_3 = "Tiempo en que se desarrolla el producto."
    End Sub
    Private Sub cargarPreguntaM2_9()
        pregunta9 = "9.	Cada cuanto se debe realizar reuniones en scrum:"
        rPregunta9_1 = "Cada tres días."
        rPregunta9_2 = "Cada dos días."
        rPregunta9_3 = "Cada día."
    End Sub
    Private Sub cargarPreguntaM2_10()
        pregunta10 = "10. Cuanto debe ser el tiempo de las reuniones:"
        rPregunta10_1 = "Quince minutos."
        rPregunta10_2 = "Treinta minutos."
        rPregunta10_3 = "Una hora."
    End Sub
    Private Sub cargarModulo2()

        modulo = 1

        cargarPreguntaM2_1()
        cargarPreguntaM2_2()
        cargarPreguntaM2_3()
        cargarPreguntaM2_4()
        cargarPreguntaM2_5()
        cargarPreguntaM2_6()
        cargarPreguntaM2_7()
        cargarPreguntaM2_8()
        cargarPreguntaM2_9()
        cargarPreguntaM2_10()

        lblPregunta1.Text = pregunta1
        rdbPregunta1_1.Text = rPregunta1_1
        rdbPregunta1_2.Text = rPregunta1_2
        rdbPregunta1_3.Text = rPregunta1_3

        lblPregunta2.Text = pregunta2
        rdbPregunta2_1.Text = rPregunta2_1
        rdbPregunta2_2.Text = rPregunta2_2
        rdbPregunta2_3.Text = rPregunta2_3

        lblPregunta3.Text = pregunta3
        rdbPregunta3_1.Text = rPregunta3_1
        rdbPregunta3_2.Text = rPregunta3_2
        rdbPregunta3_3.Text = rPregunta3_3

        lblPregunta4.Text = pregunta4
        rdbPregunta4_1.Text = rPregunta4_1
        rdbPregunta4_2.Text = rPregunta4_2
        rdbPregunta4_3.Text = rPregunta4_3

        lblPregunta5.Text = pregunta5
        rdbPregunta5_1.Text = rPregunta5_1
        rdbPregunta5_2.Text = rPregunta5_2
        rdbPregunta5_3.Text = rPregunta5_3

        lblPregunta6.Text = pregunta6
        rdbPregunta6_1.Text = rPregunta6_1
        rdbPregunta6_2.Text = rPregunta6_2
        rdbPregunta6_3.Text = rPregunta6_3

        lblPregunta7.Text = pregunta7
        rdbPregunta7_1.Text = rPregunta7_1
        rdbPregunta7_2.Text = rPregunta7_2
        rdbPregunta7_3.Text = rPregunta7_3

        lblPregunta8.Text = pregunta8
        rdbPregunta8_1.Text = rPregunta8_1
        rdbPregunta8_2.Text = rPregunta8_2
        rdbPregunta8_3.Text = rPregunta8_3

        lblPregunta9.Text = pregunta9
        rdbPregunta9_1.Text = rPregunta9_1
        rdbPregunta9_2.Text = rPregunta9_2
        rdbPregunta9_3.Text = rPregunta9_3

        lblPregunta10.Text = pregunta10
        rdbPregunta10_1.Text = rPregunta10_1
        rdbPregunta10_2.Text = rPregunta10_2
        rdbPregunta10_3.Text = rPregunta10_3
    End Sub
    Private Sub LimpiarRespuesta()
        rdbPregunta1_1.Checked = False
        rdbPregunta1_2.Checked = False
        rdbPregunta1_3.Checked = False

        rdbPregunta2_1.Checked = False
        rdbPregunta2_2.Checked = False
        rdbPregunta2_3.Checked = False

        rdbPregunta3_1.Checked = False
        rdbPregunta3_2.Checked = False
        rdbPregunta3_3.Checked = False

        rdbPregunta4_1.Checked = False
        rdbPregunta4_2.Checked = False
        rdbPregunta4_3.Checked = False

        rdbPregunta5_1.Checked = False
        rdbPregunta5_2.Checked = False
        rdbPregunta5_3.Checked = False

        rdbPregunta6_1.Checked = False
        rdbPregunta6_2.Checked = False
        rdbPregunta6_3.Checked = False

        rdbPregunta7_1.Checked = False
        rdbPregunta7_2.Checked = False
        rdbPregunta7_3.Checked = False

        rdbPregunta8_1.Checked = False
        rdbPregunta8_2.Checked = False
        rdbPregunta8_3.Checked = False

        rdbPregunta9_1.Checked = False
        rdbPregunta9_2.Checked = False
        rdbPregunta9_3.Checked = False

        rdbPregunta10_1.Checked = False
        rdbPregunta10_2.Checked = False
        rdbPregunta10_3.Checked = False

    End Sub

    'Fin modulo 2

    ' Evaluar resultado
    Private Sub evaluarResultado()
        Select Case modulo
            Case 0
                If rdbPregunta1_1.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta2_1.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta3_3.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta4_1.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta5_1.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta6_3.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta7_1.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta8_2.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta9_1.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta10_3.Checked = True Then
                    nota += 1
                End If

                If nota < 6 Then

                    nota = 0
                    MessageBox.Show("No aprobó el módulo 1 vuelva a intentarlo.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else

                    MessageBox.Show("Aprobó el módulo 1 con una nota" + CStr(nota) + " felicitaciones.")
                    LimpiarRespuesta()
                    nota = 0
                    cargarModulo2()
                End If

            Case 1
                If rdbPregunta1_1.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta2_1.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta3_3.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta4_2.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta5_3.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta6_1.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta7_2.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta8_2.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta9_3.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta10_1.Checked = True Then
                    nota += 1
                End If

                If nota < 6 Then

                    nota = 0
                    MessageBox.Show("No aprobó el módulo 2 vuelva a intentarlo.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else

                    MessageBox.Show("Aprobó el módulo 2 con una nota " + CStr(nota) + " felicitaciones.")
                    nota = 0

                End If
        End Select
    End Sub

    Private Sub VentanaMySQLPrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nota = 0
        cargarModulo1()
        tiempo = 120
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ObjTiempo.Start()
    End Sub

    Private Sub ObjTiempo_Tick(sender As Object, e As EventArgs) Handles ObjTiempo.Tick
        tiempo = tiempo - 1
        lblTiempo.Text = "Tiempo para que la prueba termine: " + CStr(tiempo)
        If tiempo = 0 Then
            ObjTiempo.Enabled = False
            MsgBox("Tiempo terminado")
            btnTerminar.Enabled = False
            evaluarResultado()
        End If
    End Sub

    Private Sub btnTerminar_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click
        evaluarResultado()
    End Sub
    Private Sub VentanaScrumPrueba_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim VS As New VentanaScrum()
        VS.Show()
        Dispose()
    End Sub

    Private Sub MenúPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenúPrincipalToolStripMenuItem.Click
        Dim VC As New VentanaCursos()
        VC.Show()
        Dispose()
    End Sub
End Class