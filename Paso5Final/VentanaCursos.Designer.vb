<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaCursos
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CursosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MySQLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PythonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScrumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CursosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(476, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CursosToolStripMenuItem
        '
        Me.CursosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MySQLToolStripMenuItem, Me.PythonToolStripMenuItem, Me.ScrumToolStripMenuItem})
        Me.CursosToolStripMenuItem.Name = "CursosToolStripMenuItem"
        Me.CursosToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.CursosToolStripMenuItem.Text = "Cursos"
        '
        'MySQLToolStripMenuItem
        '
        Me.MySQLToolStripMenuItem.Name = "MySQLToolStripMenuItem"
        Me.MySQLToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.MySQLToolStripMenuItem.Text = "MySQL"
        '
        'PythonToolStripMenuItem
        '
        Me.PythonToolStripMenuItem.Name = "PythonToolStripMenuItem"
        Me.PythonToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.PythonToolStripMenuItem.Text = "Python"
        '
        'ScrumToolStripMenuItem
        '
        Me.ScrumToolStripMenuItem.Name = "ScrumToolStripMenuItem"
        Me.ScrumToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ScrumToolStripMenuItem.Text = "Scrum"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(196, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cursos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(420, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Universidad Nacional Abierta y a Distancia"
        '
        'VentanaCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 347)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "VentanaCursos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenido"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CursosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MySQLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PythonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScrumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
