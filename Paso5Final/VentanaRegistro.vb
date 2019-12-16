Imports System.Data
Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class VentanaRegistro

    Dim conexion As New OleDbConnection
    Dim sql As New OleDbCommand

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click

        ' Validar nombre
        If txtNombre.Text = "" Then
            ErrorMSG.SetError(txtNombre, "Escriba un nombre.")
            Return
        End If
        ErrorMSG.SetError(txtNombre, "")

        Dim expresionCadena As String = "^[a-zA-Z]*$"
        If Not Regex.IsMatch(txtNombre.Text, expresionCadena) Then
            ErrorMSG.SetError(txtNombre, "Escriba un nombre valido.")
            Return
        End If
        ErrorMSG.SetError(txtNombre, "")

        ' Validar apellido 
        If txtApellido.Text = "" Then
            ErrorMSG.SetError(txtApellido, "Escriba un apellido.")
            Return
        End If
        ErrorMSG.SetError(txtApellido, "")

        If Not Regex.IsMatch(txtApellido.Text, expresionCadena) Then
            ErrorMSG.SetError(txtApellido, "Escriba un apellido valido.")
            Return
        End If
        ErrorMSG.SetError(txtApellido, "")

        ' Validar cedula
        If txtCedula.Text = "" Then
            ErrorMSG.SetError(txtCedula, "Escriba una cedula.")
            Return
        End If
        ErrorMSG.SetError(txtCedula, "")

        Dim expresionCedula As String = "^[0-9]*$"
        If Not Regex.IsMatch(txtCedula.Text, expresionCedula) Then
            ErrorMSG.SetError(txtCedula, "Escriba una cedula valida.")
            Return
        End If
        ErrorMSG.SetError(txtCedula, "")

        ' Validar usuario
        If txtUsuario.Text = "" Then
            ErrorMSG.SetError(txtUsuario, "Escriba un usuario.")
            Return
        End If
        ErrorMSG.SetError(txtUsuario, "")

        ' Validar contraseña
        If txtContrasena.Text = "" Then
            ErrorMSG.SetError(txtContrasena, "Escriba una contraseña.")
            Return
        End If
        ErrorMSG.SetError(txtContrasena, "")

        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=.\paso5.mdb"
            conexion.Open()

            sql = New OleDbCommand("Insert into usuario(nombre,apellido,cedula,usuario,contrasena)" &
                                   "values(txtNombre,txtApellido,txtCedula,txtUsuario,txtContrasena)", conexion)

            sql.Parameters.AddWithValue("@nombre", txtNombre.Text)
            sql.Parameters.AddWithValue("@apellido", txtApellido.Text)
            sql.Parameters.AddWithValue("@cedula", txtCedula.Text)
            sql.Parameters.AddWithValue("@usuario", txtUsuario.Text)
            sql.Parameters.AddWithValue("@contrasena", txtContrasena.Text)
            sql.ExecuteNonQuery()

            MsgBox("Registrado exitosamente.", vbInformation, "")
            Salir()


        Catch ex As Exception
            MsgBox(ex.ToString, vbExclamation, "Error")
        End Try

        conexion.Close()

    End Sub

    Private Sub Salir()
        Dispose()
        Dim vi As New VentanaInicio()
        vi.Show()
    End Sub

    Private Sub VentanaRegistro_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Salir()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Salir()
    End Sub
End Class