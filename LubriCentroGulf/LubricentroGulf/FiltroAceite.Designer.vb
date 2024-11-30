<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FiltroAceite
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
        Me.cargarFiltroAceite = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.grillaFiltroAceite = New System.Windows.Forms.DataGridView()
        Me.Filtro = New System.Windows.Forms.Label()
        Me.barraFiltroAceite = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.array = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.grillaFiltroAceite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cargarFiltroAceite
        '
        Me.cargarFiltroAceite.Location = New System.Drawing.Point(27, 311)
        Me.cargarFiltroAceite.Name = "cargarFiltroAceite"
        Me.cargarFiltroAceite.Size = New System.Drawing.Size(75, 23)
        Me.cargarFiltroAceite.TabIndex = 3
        Me.cargarFiltroAceite.Text = "Cargar"
        Me.cargarFiltroAceite.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(27, 354)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(27, 398)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'grillaFiltroAceite
        '
        Me.grillaFiltroAceite.AllowUserToAddRows = False
        Me.grillaFiltroAceite.AllowUserToDeleteRows = False
        Me.grillaFiltroAceite.AllowUserToOrderColumns = True
        Me.grillaFiltroAceite.AllowUserToResizeColumns = False
        Me.grillaFiltroAceite.AllowUserToResizeRows = False
        Me.grillaFiltroAceite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaFiltroAceite.Location = New System.Drawing.Point(271, 84)
        Me.grillaFiltroAceite.Name = "grillaFiltroAceite"
        Me.grillaFiltroAceite.ReadOnly = True
        Me.grillaFiltroAceite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaFiltroAceite.Size = New System.Drawing.Size(353, 337)
        Me.grillaFiltroAceite.TabIndex = 6
        '
        'Filtro
        '
        Me.Filtro.AutoSize = True
        Me.Filtro.Location = New System.Drawing.Point(24, 59)
        Me.Filtro.Name = "Filtro"
        Me.Filtro.Size = New System.Drawing.Size(42, 13)
        Me.Filtro.TabIndex = 7
        Me.Filtro.Text = "Modelo"
        '
        'barraFiltroAceite
        '
        Me.barraFiltroAceite.Location = New System.Drawing.Point(271, 52)
        Me.barraFiltroAceite.Name = "barraFiltroAceite"
        Me.barraFiltroAceite.Size = New System.Drawing.Size(353, 20)
        Me.barraFiltroAceite.TabIndex = 15
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(27, 94)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(121, 20)
        Me.txtModelo.TabIndex = 16
        '
        'array
        '
        Me.array.Location = New System.Drawing.Point(27, 134)
        Me.array.Name = "array"
        Me.array.Size = New System.Drawing.Size(121, 20)
        Me.array.TabIndex = 17
        Me.array.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Location = New System.Drawing.Point(683, 210)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(279, 49)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "LUBRICENTRO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LubricentroGulf.My.Resources.Resources._660px_Gulf_logo
        Me.PictureBox1.Location = New System.Drawing.Point(759, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'FiltroAceite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 516)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.array)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.barraFiltroAceite)
        Me.Controls.Add(Me.Filtro)
        Me.Controls.Add(Me.grillaFiltroAceite)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cargarFiltroAceite)
        Me.Name = "FiltroAceite"
        Me.Text = "FiltroAceite"
        CType(Me.grillaFiltroAceite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cargarFiltroAceite As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents grillaFiltroAceite As DataGridView
    Friend WithEvents Filtro As Label
    Friend WithEvents barraFiltroAceite As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents array As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
