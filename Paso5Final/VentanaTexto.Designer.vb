<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaTexto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaTexto))
        Me.DocumentoPDF = New AxAcroPDFLib.AxAcroPDF()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenúPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DocumentoPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DocumentoPDF
        '
        Me.DocumentoPDF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentoPDF.Enabled = True
        Me.DocumentoPDF.Location = New System.Drawing.Point(0, 24)
        Me.DocumentoPDF.Name = "DocumentoPDF"
        Me.DocumentoPDF.OcxState = CType(resources.GetObject("DocumentoPDF.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DocumentoPDF.Size = New System.Drawing.Size(553, 499)
        Me.DocumentoPDF.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúPrincipalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(553, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenúPrincipalToolStripMenuItem
        '
        Me.MenúPrincipalToolStripMenuItem.Name = "MenúPrincipalToolStripMenuItem"
        Me.MenúPrincipalToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.MenúPrincipalToolStripMenuItem.Text = "Menú principal"
        '
        'VentanaTexto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 523)
        Me.Controls.Add(Me.DocumentoPDF)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VentanaTexto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VentanaTexto"
        CType(Me.DocumentoPDF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DocumentoPDF As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenúPrincipalToolStripMenuItem As ToolStripMenuItem
End Class
