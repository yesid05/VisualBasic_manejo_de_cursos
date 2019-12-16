<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaAudio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaAudio))
        Me.ReproductorAudio = New AxWMPLib.AxWindowsMediaPlayer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenúPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ReproductorAudio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReproductorAudio
        '
        Me.ReproductorAudio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReproductorAudio.Enabled = True
        Me.ReproductorAudio.Location = New System.Drawing.Point(0, 24)
        Me.ReproductorAudio.Name = "ReproductorAudio"
        Me.ReproductorAudio.OcxState = CType(resources.GetObject("ReproductorAudio.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ReproductorAudio.Size = New System.Drawing.Size(510, 103)
        Me.ReproductorAudio.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúPrincipalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(510, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenúPrincipalToolStripMenuItem
        '
        Me.MenúPrincipalToolStripMenuItem.Name = "MenúPrincipalToolStripMenuItem"
        Me.MenúPrincipalToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.MenúPrincipalToolStripMenuItem.Text = "Menú principal"
        '
        'VentanaAudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 127)
        Me.Controls.Add(Me.ReproductorAudio)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VentanaAudio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VentanaAudio"
        CType(Me.ReproductorAudio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReproductorAudio As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenúPrincipalToolStripMenuItem As ToolStripMenuItem
End Class
