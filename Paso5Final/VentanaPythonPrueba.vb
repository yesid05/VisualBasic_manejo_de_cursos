Public Class VentanaPythonPrueba

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
        pregunta1 = "1. Los lenguajes de programación se clasifican en:"
        rPregunta1_1 = "Medio nivel bajo nivel."
        rPregunta1_2 = "Alto nivel y medio nivel."
        rPregunta1_3 = "Alto nivel y bajo nivel."

    End Sub

    Private Sub cargarPreguntaM1_2()
        pregunta2 = "2.	Python es un lenguaje de:"
        rPregunta2_1 = "Alto nivel."
        rPregunta2_2 = "Medio nivel."
        rPregunta2_3 = "Bajo nivel."

    End Sub
    Private Sub cargarPreguntaM1_3()
        pregunta3 = "3.	Los lenguajes de bajo nivel también son conocidos como:"
        rPregunta3_1 = "Lenguajes PC."
        rPregunta3_2 = "Lenguajes máquina."
        rPregunta3_3 = "Ninguna de las anteriores."

    End Sub
    Private Sub cargarPreguntaM1_4()
        pregunta4 = "4.	Las computadoras solo entienden el lenguaje de:"
        rPregunta4_1 = "Alto nivel."
        rPregunta4_2 = "Medio nivel."
        rPregunta4_3 = "Bajo nivel."

    End Sub
    Private Sub cargarPreguntaM1_5()
        pregunta5 = "5.	Es necesario traducir los lenguajes de programación de alto nivel a bajo nivel:"
        rPregunta5_1 = "Si."
        rPregunta5_2 = "No."
        rPregunta5_3 = "Depende del programador."

    End Sub
    Private Sub cargarPreguntaM1_6()
        pregunta6 = "6.	Los tipos de traducción que existen:"
        rPregunta6_1 = "Traductor y compilador."
        rPregunta6_2 = "Compilador e intérprete."
        rPregunta6_3 = "Traductor e intérprete."

    End Sub
    Private Sub cargarPreguntaM1_7()
        pregunta7 = "7.	Python es un lenguaje:"
        rPregunta7_1 = "Compilado."
        rPregunta7_2 = "Traducido."
        rPregunta7_3 = "Interpretado."

    End Sub
    Private Sub cargarPreguntaM1_8()
        pregunta8 = "8.	El compilador consiste en:"
        rPregunta8_1 = "Traduce todo al mismo tiempo."
        rPregunta8_2 = "Traduce línea por línea."
        rPregunta8_3 = "No hace nada"
    End Sub
    Private Sub cargarPreguntaM1_9()
        pregunta9 = "9.	El intérprete consiste en:"
        rPregunta9_1 = "Traduce todo al mismo tiempo."
        rPregunta9_2 = "Traduce línea por línea."
        rPregunta9_3 = "No hace nada."
    End Sub
    Private Sub cargarPreguntaM1_10()
        pregunta10 = "10. Un lenguaje de programación puede utilizar el compilador y el intérprete:"
        rPregunta10_1 = "Si."
        rPregunta10_2 = "No."
        rPregunta10_3 = "De vez en cuando."
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
        pregunta1 = "1.	Cuantas palabras reservadas tiene Python:"
        rPregunta1_1 = "27"
        rPregunta1_2 = "28"
        rPregunta1_3 = "29"

    End Sub

    Private Sub cargarPreguntaM2_2()
        pregunta2 = "2.	Cuáles de las siguientes palabras reservadas son reservadas:"
        rPregunta2_1 = "And, def, if."
        rPregunta2_2 = "Dim, as, sub."
        rPregunta2_3 = "Red, Green, Blue."

    End Sub
    Private Sub cargarPreguntaM2_3()
        pregunta3 = "3.	El tipo de dato binario es un:"
        rPregunta3_1 = "Float."
        rPregunta3_2 = "Str."
        rPregunta3_3 = "int."

    End Sub
    Private Sub cargarPreguntaM2_4()
        pregunta4 = "4.	Con el operador aritmético (**) se realiza la operación:"
        rPregunta4_1 = "Multiplicación."
        rPregunta4_2 = "Exponenciación."
        rPregunta4_3 = "Doble multiplicación."

    End Sub
    Private Sub cargarPreguntaM2_5()
        pregunta5 = "5.	El símbolo (//):"
        rPregunta5_1 = "Un comentario."
        rPregunta5_2 = "Una división."
        rPregunta5_3 = "Una división entera."

    End Sub
    Private Sub cargarPreguntaM2_6()
        pregunta6 = "6.	Operador aritmético (+) en objetos de tipo (str) es:"
        rPregunta6_1 = "Concatenación."
        rPregunta6_2 = "Repetición."
        rPregunta6_3 = "Ninguna de las anteriores."

    End Sub
    Private Sub cargarPreguntaM2_7()
        pregunta7 = "7.	El operador de relación:"
        rPregunta7_1 = "Menor o igual."
        rPregunta7_2 = "Mayor o igual."
        rPregunta7_3 = "Ninguna de las anteriores."

    End Sub
    Private Sub cargarPreguntaM2_8()
        pregunta8 = "8.	El operador de bits (^) es:"
        rPregunta8_1 = "OR."
        rPregunta8_2 = "XOR."
        rPregunta8_3 = "AND."
    End Sub
    Private Sub cargarPreguntaM2_9()
        pregunta9 = "9.	Numericamente true equivale a:"
        rPregunta9_1 = "1"
        rPregunta9_2 = "0"
        rPregunta9_3 = "Ninguna de las anteriores."
    End Sub
    Private Sub cargarPreguntaM2_10()
        pregunta10 = "10. El número (12.) es un número de tipo:"
        rPregunta10_1 = "Flotante."
        rPregunta10_2 = "Entero."
        rPregunta10_3 = "Ninguna de las anteriores."
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
                If rdbPregunta1_3.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta2_1.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta3_2.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta4_3.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta5_1.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta6_2.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta7_3.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta8_1.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta9_2.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta10_1.Checked = True Then
                    nota += 1
                End If

                If nota < 6 Then

                    nota = 0
                    MessageBox.Show("No aprobó el módulo 1 vuelva a intentarlo.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else

                    MessageBox.Show("Aprobó el módulo 1 con una nota " + CStr(nota) + " felicitaciones.")
                    LimpiarRespuesta()
                    nota = 0
                    cargarModulo2()
                End If

            Case 1
                If rdbPregunta1_2.Checked = True Then
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

                If rdbPregunta9_1.Checked = True Then
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

    Private Sub VentanaPythonPrueba_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim VP As New VentanaPython()
        VP.Show()
        Dispose()
    End Sub

    Private Sub MenúPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenúPrincipalToolStripMenuItem.Click
        Dim VC As New VentanaCursos()
        VC.Show()
        Dispose()
    End Sub
End Class