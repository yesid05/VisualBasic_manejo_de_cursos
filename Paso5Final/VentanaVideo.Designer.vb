<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaVideo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaVideo))
        Me.ReproductorVideo = New AxWMPLib.AxWindowsMediaPlayer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenúPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ReproductorVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReproductorVideo
        '
        Me.ReproductorVideo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReproductorVideo.Enabled = True
        Me.ReproductorVideo.Location = New System.Drawing.Point(0, 24)
        Me.ReproductorVideo.Name = "ReproductorVideo"
        Me.ReproductorVideo.OcxState = CType(resources.GetObject("ReproductorVideo.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ReproductorVideo.Size = New System.Drawing.Size(584, 332)
        Me.ReproductorVideo.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúPrincipalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenúPrincipalToolStripMenuItem
        '
        Me.MenúPrincipalToolStripMenuItem.Name = "MenúPrincipalToolStripMenuItem"
        Me.MenúPrincipalToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.MenúPrincipalToolStripMenuItem.Text = "Menú principal"
        '
        'VentanaVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.ReproductorVideo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VentanaVideo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Video"
        CType(Me.ReproductorVideo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReproductorVideo As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenúPrincipalToolStripMenuItem As ToolStripMenuItem
End Class
