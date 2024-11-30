<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class filtroAire
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
        Me.btncargar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.txtFiltroAire = New System.Windows.Forms.TextBox()
        Me.txtarray = New System.Windows.Forms.TextBox()
        Me.grillaFiltroAire = New System.Windows.Forms.DataGridView()
        Me.barra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.grillaFiltroAire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncargar
        '
        Me.btncargar.Location = New System.Drawing.Point(77, 222)
        Me.btncargar.Name = "btncargar"
        Me.btncargar.Size = New System.Drawing.Size(75, 23)
        Me.btncargar.TabIndex = 0
        Me.btncargar.Text = "Cargar"
        Me.btncargar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(77, 275)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificar.TabIndex = 1
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(77, 330)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 2
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'txtFiltroAire
        '
        Me.txtFiltroAire.Location = New System.Drawing.Point(77, 152)
        Me.txtFiltroAire.Name = "txtFiltroAire"
        Me.txtFiltroAire.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltroAire.TabIndex = 3
        '
        'txtarray
        '
        Me.txtarray.Location = New System.Drawing.Point(77, 99)
        Me.txtarray.Name = "txtarray"
        Me.txtarray.Size = New System.Drawing.Size(100, 20)
        Me.txtarray.TabIndex = 4
        Me.txtarray.Visible = False
        '
        'grillaFiltroAire
        '
        Me.grillaFiltroAire.AllowUserToAddRows = False
        Me.grillaFiltroAire.AllowUserToDeleteRows = False
        Me.grillaFiltroAire.AllowUserToResizeColumns = False
        Me.grillaFiltroAire.AllowUserToResizeRows = False
        Me.grillaFiltroAire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaFiltroAire.Location = New System.Drawing.Point(270, 95)
        Me.grillaFiltroAire.Name = "grillaFiltroAire"
        Me.grillaFiltroAire.ReadOnly = True
        Me.grillaFiltroAire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaFiltroAire.Size = New System.Drawing.Size(234, 258)
        Me.grillaFiltroAire.TabIndex = 5
        '
        'barra
        '
        Me.barra.Location = New System.Drawing.Point(270, 69)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(234, 20)
        Me.barra.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(347, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Buscar Filtro Aire"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Modelo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Location = New System.Drawing.Point(516, 185)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(279, 49)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "LUBRICENTRO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LubricentroGulf.My.Resources.Resources._660px_Gulf_logo
        Me.PictureBox1.Location = New System.Drawing.Point(592, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'filtroAire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.grillaFiltroAire)
        Me.Controls.Add(Me.txtarray)
        Me.Controls.Add(Me.txtFiltroAire)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btncargar)
        Me.Name = "filtroAire"
        Me.Text = "filtroAire"
        CType(Me.grillaFiltroAire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncargar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents txtFiltroAire As TextBox
    Friend WithEvents txtarray As TextBox
    Friend WithEvents grillaFiltroAire As DataGridView
    Friend WithEvents barra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
