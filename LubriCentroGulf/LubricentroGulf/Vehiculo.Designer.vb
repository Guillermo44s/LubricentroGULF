<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vehiculo
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtModeloV = New System.Windows.Forms.TextBox()
        Me.txtarray = New System.Windows.Forms.TextBox()
        Me.Modelo = New System.Windows.Forms.Label()
        Me.grillaVehiculo = New System.Windows.Forms.DataGridView()
        Me.barra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.grillaVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cargar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(48, 186)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(48, 234)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtModeloV
        '
        Me.txtModeloV.Location = New System.Drawing.Point(48, 92)
        Me.txtModeloV.Name = "txtModeloV"
        Me.txtModeloV.Size = New System.Drawing.Size(100, 20)
        Me.txtModeloV.TabIndex = 3
        '
        'txtarray
        '
        Me.txtarray.Location = New System.Drawing.Point(48, 34)
        Me.txtarray.Name = "txtarray"
        Me.txtarray.Size = New System.Drawing.Size(54, 20)
        Me.txtarray.TabIndex = 4
        Me.txtarray.Visible = False
        '
        'Modelo
        '
        Me.Modelo.AutoSize = True
        Me.Modelo.Location = New System.Drawing.Point(45, 76)
        Me.Modelo.Name = "Modelo"
        Me.Modelo.Size = New System.Drawing.Size(42, 13)
        Me.Modelo.TabIndex = 6
        Me.Modelo.Text = "Modelo"
        '
        'grillaVehiculo
        '
        Me.grillaVehiculo.AllowUserToAddRows = False
        Me.grillaVehiculo.AllowUserToDeleteRows = False
        Me.grillaVehiculo.AllowUserToResizeRows = False
        Me.grillaVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaVehiculo.Location = New System.Drawing.Point(227, 92)
        Me.grillaVehiculo.Name = "grillaVehiculo"
        Me.grillaVehiculo.ReadOnly = True
        Me.grillaVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaVehiculo.Size = New System.Drawing.Size(240, 223)
        Me.grillaVehiculo.TabIndex = 7
        '
        'barra
        '
        Me.barra.Location = New System.Drawing.Point(227, 51)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(240, 20)
        Me.barra.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(308, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Buscar Vehiculo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Location = New System.Drawing.Point(516, 208)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(279, 49)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "LUBRICENTRO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LubricentroGulf.My.Resources.Resources._660px_Gulf_logo
        Me.PictureBox1.Location = New System.Drawing.Point(592, 92)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'Vehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 506)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.grillaVehiculo)
        Me.Controls.Add(Me.Modelo)
        Me.Controls.Add(Me.txtarray)
        Me.Controls.Add(Me.txtModeloV)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Vehiculo"
        Me.Text = "Vehiculo"
        CType(Me.grillaVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtModeloV As TextBox
    Friend WithEvents txtarray As TextBox
    Friend WithEvents Modelo As Label
    Friend WithEvents grillaVehiculo As DataGridView
    Friend WithEvents barra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
