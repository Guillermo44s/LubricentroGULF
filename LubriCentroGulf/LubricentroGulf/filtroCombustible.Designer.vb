<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class filtroCombustible
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
        Me.txtarray = New System.Windows.Forms.TextBox()
        Me.txtFiltroCombustible = New System.Windows.Forms.TextBox()
        Me.grillaFiltroCombustible = New System.Windows.Forms.DataGridView()
        Me.btncargar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.barra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.grillaFiltroCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtarray
        '
        Me.txtarray.Location = New System.Drawing.Point(125, 124)
        Me.txtarray.Name = "txtarray"
        Me.txtarray.Size = New System.Drawing.Size(100, 20)
        Me.txtarray.TabIndex = 0
        Me.txtarray.Visible = False
        '
        'txtFiltroCombustible
        '
        Me.txtFiltroCombustible.Location = New System.Drawing.Point(125, 183)
        Me.txtFiltroCombustible.Name = "txtFiltroCombustible"
        Me.txtFiltroCombustible.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltroCombustible.TabIndex = 1
        '
        'grillaFiltroCombustible
        '
        Me.grillaFiltroCombustible.AllowUserToAddRows = False
        Me.grillaFiltroCombustible.AllowUserToDeleteRows = False
        Me.grillaFiltroCombustible.AllowUserToOrderColumns = True
        Me.grillaFiltroCombustible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaFiltroCombustible.Location = New System.Drawing.Point(263, 124)
        Me.grillaFiltroCombustible.Name = "grillaFiltroCombustible"
        Me.grillaFiltroCombustible.ReadOnly = True
        Me.grillaFiltroCombustible.Size = New System.Drawing.Size(240, 225)
        Me.grillaFiltroCombustible.TabIndex = 2
        '
        'btncargar
        '
        Me.btncargar.Location = New System.Drawing.Point(125, 234)
        Me.btncargar.Name = "btncargar"
        Me.btncargar.Size = New System.Drawing.Size(75, 23)
        Me.btncargar.TabIndex = 3
        Me.btncargar.Text = "Cargar"
        Me.btncargar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(125, 276)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificar.TabIndex = 4
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(125, 326)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 5
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(122, 167)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(44, 13)
        Me.Nombre.TabIndex = 6
        Me.Nombre.Text = "Nombre"
        '
        'barra
        '
        Me.barra.Location = New System.Drawing.Point(263, 98)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(240, 20)
        Me.barra.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(345, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar Filtro"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Location = New System.Drawing.Point(518, 198)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(279, 49)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "LUBRICENTRO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LubricentroGulf.My.Resources.Resources._660px_Gulf_logo
        Me.PictureBox1.Location = New System.Drawing.Point(594, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'filtroCombustible
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btncargar)
        Me.Controls.Add(Me.grillaFiltroCombustible)
        Me.Controls.Add(Me.txtFiltroCombustible)
        Me.Controls.Add(Me.txtarray)
        Me.Name = "filtroCombustible"
        Me.Text = "filtroCombustible"
        CType(Me.grillaFiltroCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtarray As TextBox
    Friend WithEvents txtFiltroCombustible As TextBox
    Friend WithEvents grillaFiltroCombustible As DataGridView
    Friend WithEvents btncargar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents Nombre As Label
    Friend WithEvents barra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
