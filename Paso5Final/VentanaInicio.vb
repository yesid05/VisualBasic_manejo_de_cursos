Imports System.Data
Imports System.Data.OleDb
Public Class VentanaInicio

    Dim conexion As New OleDbConnection
    Dim sqlAdaptador As New OleDbDataAdapter
    Dim datosSet As New DataSet
    Dim sql As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If txtUsuario.Text = "admin" And txtContrasena.Text = "12345" Then
            ' Si el usuario es administrador
            Dim VC As New VentanaCursos("Administrador")
            Hide()
            VC.Show()

        ElseIf txtUsuario.Text <> "" And txtContrasena.Text <> "" Then
            ' Si el usuario es un estudiante
            Try
                conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\paso5.mdb"
                conexion.Open()
                sql = "Select usuario from usuario where usuario = '" & txtUsuario.Text & "' and contrasena = '" & txtContrasena.Text & "'"
                sqlAdaptador = New OleDbDataAdapter(sql, conexion)

                sqlAdaptador.Fill(datosSet, "usuario")


                If datosSet.Tables("usuario").Rows.Count <> 0 Then
                    ' Si existe el usuario
                    conexion.Close()

                    Dim usuario As String = datosSet.Tables("usuario").Rows(0).Item("usuario")
                    Dim VC As New VentanaCursos(usuario)
                    Hide()
                    VC.Show()

                Else
                    ' Si no existe el usuario
                    conexion.Close()
                    MsgBox("El usuario no existe", vbInformation, "Error")
                End If

            Catch ex As Exception
                MsgBox(ex.ToString, vbExclamation, "Error")
            End Try
        Else
            MsgBox("Debe ingresar un usuario y una contraseña.", vbInformation, "")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        Hide()
        Dim vr As New VentanaRegistro()
        vr.Show()
    End Sub

    Private Sub VentanaInicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.ExitThread()
    End Sub
End Class
