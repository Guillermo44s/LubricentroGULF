<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgregarVehiculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarLubricanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarFiltroCombustibleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarFiltroAceiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarFiltroAireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPatenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarVehiculoToolStripMenuItem, Me.AgregarLubricanteToolStripMenuItem, Me.AgregarFiltroCombustibleToolStripMenuItem, Me.AgregarFiltroAceiteToolStripMenuItem, Me.AgregarFiltroAireToolStripMenuItem, Me.ServiciosToolStripMenuItem, Me.AgregarPatenteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(989, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgregarVehiculoToolStripMenuItem
        '
        Me.AgregarVehiculoToolStripMenuItem.Name = "AgregarVehiculoToolStripMenuItem"
        Me.AgregarVehiculoToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.AgregarVehiculoToolStripMenuItem.Text = "Agregar Vehiculo"
        '
        'AgregarLubricanteToolStripMenuItem
        '
        Me.AgregarLubricanteToolStripMenuItem.Name = "AgregarLubricanteToolStripMenuItem"
        Me.AgregarLubricanteToolStripMenuItem.Size = New System.Drawing.Size(120, 20)
        Me.AgregarLubricanteToolStripMenuItem.Text = "Agregar Lubricante"
        '
        'AgregarFiltroCombustibleToolStripMenuItem
        '
        Me.AgregarFiltroCombustibleToolStripMenuItem.Name = "AgregarFiltroCombustibleToolStripMenuItem"
        Me.AgregarFiltroCombustibleToolStripMenuItem.Size = New System.Drawing.Size(162, 20)
        Me.AgregarFiltroCombustibleToolStripMenuItem.Text = "Agregar Filtro Combustible"
        '
        'AgregarFiltroAceiteToolStripMenuItem
        '
        Me.AgregarFiltroAceiteToolStripMenuItem.Name = "AgregarFiltroAceiteToolStripMenuItem"
        Me.AgregarFiltroAceiteToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.AgregarFiltroAceiteToolStripMenuItem.Text = "Agregar Filtro Aceite"
        '
        'AgregarFiltroAireToolStripMenuItem
        '
        Me.AgregarFiltroAireToolStripMenuItem.Name = "AgregarFiltroAireToolStripMenuItem"
        Me.AgregarFiltroAireToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.AgregarFiltroAireToolStripMenuItem.Text = "Agregar Filtro Aire"
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ServiciosToolStripMenuItem.Text = "Servicios"
        '
        'AgregarPatenteToolStripMenuItem
        '
        Me.AgregarPatenteToolStripMenuItem.Name = "AgregarPatenteToolStripMenuItem"
        Me.AgregarPatenteToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.AgregarPatenteToolStripMenuItem.Text = "Agregar Patente"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AgregarVehiculoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarLubricanteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarFiltroCombustibleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarFiltroAceiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarFiltroAireToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarPatenteToolStripMenuItem As ToolStripMenuItem
End Class
