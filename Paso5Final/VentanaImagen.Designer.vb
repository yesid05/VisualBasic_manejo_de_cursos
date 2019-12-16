<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaImagen
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaImagen))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Imagen = New System.Windows.Forms.PictureBox()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.ListaImagenMySQL = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenúPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaImagenPython = New System.Windows.Forms.ImageList(Me.components)
        Me.ListaImagenScrum = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 24)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(66, 24)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Label1"
        '
        'Imagen
        '
        Me.Imagen.Location = New System.Drawing.Point(12, 51)
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Size = New System.Drawing.Size(245, 230)
        Me.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Imagen.TabIndex = 1
        Me.Imagen.TabStop = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(263, 51)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguiente.TabIndex = 2
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(263, 80)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(75, 23)
        Me.btnAnterior.TabIndex = 3
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'ListaImagenMySQL
        '
        Me.ListaImagenMySQL.ImageStream = CType(resources.GetObject("ListaImagenMySQL.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListaImagenMySQL.TransparentColor = System.Drawing.Color.Transparent
        Me.ListaImagenMySQL.Images.SetKeyName(0, "relacion_uno_a_uno.png")
        Me.ListaImagenMySQL.Images.SetKeyName(1, "relacion_uno_a_muchos.png")
        Me.ListaImagenMySQL.Images.SetKeyName(2, "relacion_muchos_a_muchos.png")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúPrincipalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(349, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenúPrincipalToolStripMenuItem
        '
        Me.MenúPrincipalToolStripMenuItem.Name = "MenúPrincipalToolStripMenuItem"
        Me.MenúPrincipalToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.MenúPrincipalToolStripMenuItem.Text = "Menú principal"
        '
        'ListaImagenPython
        '
        Me.ListaImagenPython.ImageStream = CType(resources.GetObject("ListaImagenPython.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListaImagenPython.TransparentColor = System.Drawing.Color.Transparent
        Me.ListaImagenPython.Images.SetKeyName(0, "python1.jpg")
        Me.ListaImagenPython.Images.SetKeyName(1, "python2.jpg")
        Me.ListaImagenPython.Images.SetKeyName(2, "python3.png")
        '
        'ListaImagenScrum
        '
        Me.ListaImagenScrum.ImageStream = CType(resources.GetObject("ListaImagenScrum.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListaImagenScrum.TransparentColor = System.Drawing.Color.Transparent
        Me.ListaImagenScrum.Images.SetKeyName(0, "scrum1.png")
        Me.ListaImagenScrum.Images.SetKeyName(1, "scrum2.png")
        Me.ListaImagenScrum.Images.SetKeyName(2, "scrum3.png")
        '
        'VentanaImagen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 292)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.Imagen)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "VentanaImagen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VentanaImagen"
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents Imagen As PictureBox
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents ListaImagenMySQL As ImageList
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenúPrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaImagenPython As ImageList
    Friend WithEvents ListaImagenScrum As ImageList
End Class
