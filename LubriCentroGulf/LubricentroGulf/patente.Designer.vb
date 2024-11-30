<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class patente
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
        Me.grillaPatente = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPatente = New System.Windows.Forms.TextBox()
        Me.txtarray = New System.Windows.Forms.TextBox()
        Me.barra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.grillaPatente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncargar
        '
        Me.btncargar.Location = New System.Drawing.Point(104, 184)
        Me.btncargar.Name = "btncargar"
        Me.btncargar.Size = New System.Drawing.Size(75, 23)
        Me.btncargar.TabIndex = 0
        Me.btncargar.Text = "Cargar"
        Me.btncargar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(104, 224)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificar.TabIndex = 1
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(104, 268)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 2
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'grillaPatente
        '
        Me.grillaPatente.AllowUserToAddRows = False
        Me.grillaPatente.AllowUserToDeleteRows = False
        Me.grillaPatente.AllowUserToResizeColumns = False
        Me.grillaPatente.AllowUserToResizeRows = False
        Me.grillaPatente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaPatente.Location = New System.Drawing.Point(260, 141)
        Me.grillaPatente.Name = "grillaPatente"
        Me.grillaPatente.ReadOnly = True
        Me.grillaPatente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaPatente.Size = New System.Drawing.Size(240, 259)
        Me.grillaPatente.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Patente"
        '
        'txtPatente
        '
        Me.txtPatente.Location = New System.Drawing.Point(104, 106)
        Me.txtPatente.Name = "txtPatente"
        Me.txtPatente.Size = New System.Drawing.Size(100, 20)
        Me.txtPatente.TabIndex = 5
        '
        'txtarray
        '
        Me.txtarray.Location = New System.Drawing.Point(104, 22)
        Me.txtarray.Name = "txtarray"
        Me.txtarray.Size = New System.Drawing.Size(100, 20)
        Me.txtarray.TabIndex = 6
        Me.txtarray.Visible = False
        '
        'barra
        '
        Me.barra.Location = New System.Drawing.Point(260, 106)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(240, 20)
        Me.barra.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(341, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Buscar Patente"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LubricentroGulf.My.Resources.Resources._660px_Gulf_logo
        Me.PictureBox1.Location = New System.Drawing.Point(596, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Location = New System.Drawing.Point(520, 141)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(279, 49)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "LUBRICENTRO"
        '
        'patente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 450)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.txtarray)
        Me.Controls.Add(Me.txtPatente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grillaPatente)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btncargar)
        Me.Name = "patente"
        Me.Text = "patente"
        CType(Me.grillaPatente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncargar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents grillaPatente As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPatente As TextBox
    Friend WithEvents txtarray As TextBox
    Friend WithEvents barra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
End Class
