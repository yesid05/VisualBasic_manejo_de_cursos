Public Class VentanaMySQLPrueba

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
        pregunta1 = "1. Las relaciones que pueden existir entre las tablas son:"
        rPregunta1_1 = "Cero a uno, uno a varios, varios a varios."
        rPregunta1_2 = "Uno a uno, uno a varios, varios a varios."
        rPregunta1_3 = "Uno a uno, uno a varios, otros a otros."

    End Sub

    Private Sub cargarPreguntaM1_2()
        pregunta2 = "2.	La instrucción para leer datos es:"
        rPregunta2_1 = "SELECT"
        rPregunta2_2 = "INSERT."
        rPregunta2_3 = "UPDATE."

    End Sub
    Private Sub cargarPreguntaM1_3()
        pregunta3 = "3.	Para leer todos los ampos la tabla persona se utiliza la instrucción:"
        rPregunta3_1 = "SELECT * FROM Persona."
        rPregunta3_2 = "UPDATE * FROM Persona."
        rPregunta3_3 = "DELETE * FROM Persona."

    End Sub
    Private Sub cargarPreguntaM1_4()
        pregunta4 = "4.	La instrucción que permite insertar datos en una tabla es:"
        rPregunta4_1 = "UPDATE."
        rPregunta4_2 = "DELETE."
        rPregunta4_3 = "INSERT."

    End Sub
    Private Sub cargarPreguntaM1_5()
        pregunta5 = "5.	Para insertar datos en la tabla persona se debe utilizar la instrucción:"
        rPregunta5_1 = "UPDATE INTO Persona (nombre, apellidos, edad) values (‘Luis’,’López’ 25)."
        rPregunta5_2 = "INSERT INTO Persona (nombre, apellidos, edad) values (‘Luis’,’López’, 25)."
        rPregunta5_3 = "INSERT INTO Persona (nombre, apellidos edad) values (‘Luis’,’López’, 25)."

    End Sub
    Private Sub cargarPreguntaM1_6()
        pregunta6 = "6.	La instrucción que permite filtrar datos es:"
        rPregunta6_1 = "WHERE."
        rPregunta6_2 = "LIKE."
        rPregunta6_3 = "BETWEEN."

    End Sub
    Private Sub cargarPreguntaM1_7()
        pregunta7 = "7.	El operador <> significa:"
        rPregunta7_1 = "Igualdad."
        rPregunta7_2 = "Diferencia."
        rPregunta7_3 = "Ninguna de las anteriores."

    End Sub
    Private Sub cargarPreguntaM1_8()
        pregunta8 = "8.	El operador < significa:"
        rPregunta8_1 = "Menor que."
        rPregunta8_2 = "Mayor que."
        rPregunta8_3 = "Igual a."
    End Sub
    Private Sub cargarPreguntaM1_9()
        pregunta9 = "9.	El resultado de BETWEEN Valor 1 AND Valor2 es:"
        rPregunta9_1 = "Filtra primero Valor1 y después Valor2"
        rPregunta9_2 = "Filtra todos los valores que no estén entre Valor1 y Valor2."
        rPregunta9_3 = "Filtra los valores que estén entre Valor1 y Valor2."
    End Sub
    Private Sub cargarPreguntaM1_10()
        pregunta10 = "10. La instrucción SELECT * FROM Persona WHERE nombre NOT LIKE ‘%u%’ AND edad BETWEEN 20 AND 25 da como resultado:"
        rPregunta10_1 = "Todas las personas entre 20 a 25 años."
        rPregunta10_2 = "Todas las personas que tengan una u en su apellido y la edad este entre 20 a 25 años."
        rPregunta10_3 = "Todas las personas que no tengan una u en su apellido y la edad este entre 20 a 25 años."
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
        pregunta1 = "1.	La función BIN(n) retorna:"
        rPregunta1_1 = "La representación hexadecimal de n."
        rPregunta1_2 = "La representación binaria de n."
        rPregunta1_3 = "Ninguna de las anteriores."

    End Sub

    Private Sub cargarPreguntaM2_2()
        pregunta2 = "2.	La función UCASE(str) retorna:"
        rPregunta2_1 = "Devuelve la cadena str en mayúsculas."
        rPregunta2_2 = "Devuelve la cadena str con la primera letra en mayúsculas y las demás en minúsculas, de cada palabra."
        rPregunta2_3 = "Devuelve la cadena str en minúsculas."

    End Sub
    Private Sub cargarPreguntaM2_3()
        pregunta3 = "3.	La función CONCAT(cadena1,cadena2) retorna:"
        rPregunta3_1 = "Cadena1 reemplazando a cadena2."
        rPregunta3_2 = "Cadena2 concatenado o unido a cadena1."
        rPregunta3_3 = "Cadena1 concatenado o unido con cadena2."

    End Sub
    Private Sub cargarPreguntaM2_4()
        pregunta4 = "4.	La función ACOS(x) retorna:"
        rPregunta4_1 = "Coseno de x. x son radianes."
        rPregunta4_2 = "Arco coseno de x. x son radianes."
        rPregunta4_3 = "No retorna nada."

    End Sub
    Private Sub cargarPreguntaM2_5()
        pregunta5 = "5.	La función DIV retorna:"
        rPregunta5_1 = "El resultado de una división entera."
        rPregunta5_2 = "El resto de una división."
        rPregunta5_3 = "Divide un número en partes iguales."

    End Sub
    Private Sub cargarPreguntaM2_6()
        pregunta6 = "6.	La función COS(x) retorna:"
        rPregunta6_1 = "Devuelve la cosecante de x. x son radianes."
        rPregunta6_2 = "Devuelve el coseno de x. x son radianes."
        rPregunta6_3 = "Ninguna de las anteriores."

    End Sub
    Private Sub cargarPreguntaM2_7()
        pregunta7 = "7.	La función CURRENT_DATE retorna:"
        rPregunta7_1 = "Devuelve la fecha actual en formato ‘YYYY-M-D’."
        rPregunta7_2 = "Devuelve la fecha actual en formato ‘YYYY-MM-DD’."
        rPregunta7_3 = "Devuelve la fecha actual en formato ‘YYYY-MM-DD HH:MM:SS’."

    End Sub
    Private Sub cargarPreguntaM2_8()
        pregunta8 = "8.	La función YEAR(date) retorna:"
        rPregunta8_1 = "La fecha en formato ‘YYYY-MM-DD’."
        rPregunta8_2 = "La fecha y la hora en formato ‘YYYY-MM-DD HH:MM:SS’."
        rPregunta8_3 = "El año de la fecha."
    End Sub
    Private Sub cargarPreguntaM2_9()
        pregunta9 = "9.	La función DAYOFWEEK(date) retorna:"
        rPregunta9_1 = "Devuelve el nombre en inglés del día de la fecha date."
        rPregunta9_2 = "Devuelve el número del día de la fecha date 1 para domingo, 7 para sábado."
        rPregunta9_3 = "Devuelve el número de día de la fecha date 0 para domingo, 6 para sábado."
    End Sub
    Private Sub cargarPreguntaM2_10()
        pregunta10 = "10.	La funcion LTRIM(strim) retorna:"
        rPregunta10_1 = "Devuelve la cadena str sin espacios a la derecha."
        rPregunta10_2 = "Devuelve la cadena str sin espacios a la izquierda."
        rPregunta10_3 = "Devuelve la cadena str sin espacios a la derecha ni a la izquierda."
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
                If rdbPregunta1_2.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta2_1.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta3_1.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta4_3.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta5_2.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta6_1.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta7_2.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta8_1.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta9_3.Checked = True Then
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

                If rdbPregunta5_1.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta6_2.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta7_2.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta8_3.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta9_2.Checked = True Then
                    nota += 1
                End If

                If rdbPregunta10_2.Checked = True Then
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

    Private Sub MenúPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenúPrincipalToolStripMenuItem.Click
        Dim VC As New VentanaCursos()
        VC.Show()
        Dispose()
    End Sub

    Private Sub VentanaMySQLPrueba_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim VMySQL As New VentanaMySQL()
        VMySQL.Show()
        Dispose()
    End Sub
End Class