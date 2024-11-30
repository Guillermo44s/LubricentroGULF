<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.txt_idcambio = New System.Windows.Forms.TextBox()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.txt_kmini = New System.Windows.Forms.TextBox()
        Me.txt_proximocambio = New System.Windows.Forms.TextBox()
        Me.txt_caja = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Patente = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgb_grilla = New System.Windows.Forms.DataGridView()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_cargar = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_consultarxnom = New System.Windows.Forms.Button()
        Me.cbo_patente = New System.Windows.Forms.ComboBox()
        Me.cbo_vehiculo = New System.Windows.Forms.ComboBox()
        Me.cbo_filtrocombustible = New System.Windows.Forms.ComboBox()
        Me.cbo_filtroaceite = New System.Windows.Forms.ComboBox()
        Me.cbo_filtroaire = New System.Windows.Forms.ComboBox()
        Me.cbo_lubricante = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_barra = New System.Windows.Forms.TextBox()
        CType(Me.dgb_grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_idcambio
        '
        Me.txt_idcambio.Location = New System.Drawing.Point(96, 63)
        Me.txt_idcambio.Name = "txt_idcambio"
        Me.txt_idcambio.Size = New System.Drawing.Size(101, 20)
        Me.txt_idcambio.TabIndex = 0
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(96, 111)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(101, 20)
        Me.txt_fecha.TabIndex = 2
        '
        'txt_kmini
        '
        Me.txt_kmini.Location = New System.Drawing.Point(95, 266)
        Me.txt_kmini.Name = "txt_kmini"
        Me.txt_kmini.Size = New System.Drawing.Size(101, 20)
        Me.txt_kmini.TabIndex = 7
        '
        'txt_proximocambio
        '
        Me.txt_proximocambio.Location = New System.Drawing.Point(95, 292)
        Me.txt_proximocambio.Name = "txt_proximocambio"
        Me.txt_proximocambio.Size = New System.Drawing.Size(101, 20)
        Me.txt_proximocambio.TabIndex = 8
        '
        'txt_caja
        '
        Me.txt_caja.Location = New System.Drawing.Point(95, 318)
        Me.txt_caja.Name = "txt_caja"
        Me.txt_caja.Size = New System.Drawing.Size(101, 20)
        Me.txt_caja.TabIndex = 9
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(95, 344)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(101, 20)
        Me.txt_total.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Vehiculo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "FiltroCombustible"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "FiltroAire"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "FiltroAceite"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Revision Caja"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "KM_Iniciales"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Proximo Cambio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(50, 344)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "TOTAL"
        '
        'Patente
        '
        Me.Patente.AutoSize = True
        Me.Patente.Location = New System.Drawing.Point(33, 89)
        Me.Patente.Name = "Patente"
        Me.Patente.Size = New System.Drawing.Size(57, 13)
        Me.Patente.TabIndex = 20
        Me.Patente.Text = "PATENTE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(70, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "ID"
        '
        'dgb_grilla
        '
        Me.dgb_grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgb_grilla.Location = New System.Drawing.Point(247, 68)
        Me.dgb_grilla.Name = "dgb_grilla"
        Me.dgb_grilla.ReadOnly = True
        Me.dgb_grilla.RowHeadersWidth = 51
        Me.dgb_grilla.Size = New System.Drawing.Size(1267, 265)
        Me.dgb_grilla.TabIndex = 22
        '
        'btn_consultar
        '
        Me.btn_consultar.Location = New System.Drawing.Point(202, 59)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(28, 23)
        Me.btn_consultar.TabIndex = 23
        Me.btn_consultar.Text = "..."
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(525, 342)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 24
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(444, 342)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_modificar.TabIndex = 25
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_cargar
        '
        Me.btn_cargar.Location = New System.Drawing.Point(363, 342)
        Me.btn_cargar.Name = "btn_cargar"
        Me.btn_cargar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cargar.TabIndex = 26
        Me.btn_cargar.Text = "Cargar"
        Me.btn_cargar.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.Location = New System.Drawing.Point(444, 381)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(75, 42)
        Me.btn_reset.TabIndex = 27
        Me.btn_reset.Text = "Reset " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tabla"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'btn_consultarxnom
        '
        Me.btn_consultarxnom.Location = New System.Drawing.Point(202, 84)
        Me.btn_consultarxnom.Name = "btn_consultarxnom"
        Me.btn_consultarxnom.Size = New System.Drawing.Size(28, 21)
        Me.btn_consultarxnom.TabIndex = 28
        Me.btn_consultarxnom.Text = "..."
        Me.btn_consultarxnom.UseVisualStyleBackColor = True
        '
        'cbo_patente
        '
        Me.cbo_patente.FormattingEnabled = True
        Me.cbo_patente.Location = New System.Drawing.Point(94, 86)
        Me.cbo_patente.Margin = New System.Windows.Forms.Padding(2)
        Me.cbo_patente.Name = "cbo_patente"
        Me.cbo_patente.Size = New System.Drawing.Size(102, 21)
        Me.cbo_patente.TabIndex = 29
        '
        'cbo_vehiculo
        '
        Me.cbo_vehiculo.FormattingEnabled = True
        Me.cbo_vehiculo.Location = New System.Drawing.Point(96, 135)
        Me.cbo_vehiculo.Margin = New System.Windows.Forms.Padding(2)
        Me.cbo_vehiculo.Name = "cbo_vehiculo"
        Me.cbo_vehiculo.Size = New System.Drawing.Size(102, 21)
        Me.cbo_vehiculo.TabIndex = 30
        '
        'cbo_filtrocombustible
        '
        Me.cbo_filtrocombustible.FormattingEnabled = True
        Me.cbo_filtrocombustible.Location = New System.Drawing.Point(95, 186)
        Me.cbo_filtrocombustible.Margin = New System.Windows.Forms.Padding(2)
        Me.cbo_filtrocombustible.Name = "cbo_filtrocombustible"
        Me.cbo_filtrocombustible.Size = New System.Drawing.Size(102, 21)
        Me.cbo_filtrocombustible.TabIndex = 31
        '
        'cbo_filtroaceite
        '
        Me.cbo_filtroaceite.FormattingEnabled = True
        Me.cbo_filtroaceite.Location = New System.Drawing.Point(97, 212)
        Me.cbo_filtroaceite.Margin = New System.Windows.Forms.Padding(2)
        Me.cbo_filtroaceite.Name = "cbo_filtroaceite"
        Me.cbo_filtroaceite.Size = New System.Drawing.Size(102, 21)
        Me.cbo_filtroaceite.TabIndex = 32
        '
        'cbo_filtroaire
        '
        Me.cbo_filtroaire.FormattingEnabled = True
        Me.cbo_filtroaire.Location = New System.Drawing.Point(94, 241)
        Me.cbo_filtroaire.Margin = New System.Windows.Forms.Padding(2)
        Me.cbo_filtroaire.Name = "cbo_filtroaire"
        Me.cbo_filtroaire.Size = New System.Drawing.Size(102, 21)
        Me.cbo_filtroaire.TabIndex = 33
        '
        'cbo_lubricante
        '
        Me.cbo_lubricante.FormattingEnabled = True
        Me.cbo_lubricante.Location = New System.Drawing.Point(96, 162)
        Me.cbo_lubricante.Margin = New System.Windows.Forms.Padding(2)
        Me.cbo_lubricante.Name = "cbo_lubricante"
        Me.cbo_lubricante.Size = New System.Drawing.Size(102, 21)
        Me.cbo_lubricante.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(34, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Lubricante"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Location = New System.Drawing.Point(296, 7)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(279, 49)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "LUBRICENTRO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(552, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'txt_barra
        '
        Me.txt_barra.Location = New System.Drawing.Point(697, 344)
        Me.txt_barra.Name = "txt_barra"
        Me.txt_barra.Size = New System.Drawing.Size(695, 20)
        Me.txt_barra.TabIndex = 38
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1526, 450)
        Me.Controls.Add(Me.txt_barra)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbo_lubricante)
        Me.Controls.Add(Me.cbo_filtroaire)
        Me.Controls.Add(Me.cbo_filtroaceite)
        Me.Controls.Add(Me.cbo_filtrocombustible)
        Me.Controls.Add(Me.cbo_vehiculo)
        Me.Controls.Add(Me.cbo_patente)
        Me.Controls.Add(Me.btn_consultarxnom)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_cargar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_consultar)
        Me.Controls.Add(Me.dgb_grilla)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Patente)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_caja)
        Me.Controls.Add(Me.txt_proximocambio)
        Me.Controls.Add(Me.txt_kmini)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.txt_idcambio)
        Me.Name = "Form2"
        Me.Text = "SERVICIO"
        CType(Me.dgb_grilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_idcambio As TextBox
    Friend WithEvents txt_fecha As TextBox
    Friend WithEvents txt_kmini As TextBox
    Friend WithEvents txt_proximocambio As TextBox
    Friend WithEvents txt_caja As TextBox
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Patente As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dgb_grilla As DataGridView
    Friend WithEvents btn_consultar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_cargar As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_consultarxnom As Button
    Friend WithEvents cbo_patente As ComboBox
    Friend WithEvents cbo_vehiculo As ComboBox
    Friend WithEvents cbo_filtrocombustible As ComboBox
    Friend WithEvents cbo_filtroaceite As ComboBox
    Friend WithEvents cbo_filtroaire As ComboBox
    Friend WithEvents cbo_lubricante As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_barra As TextBox
End Class
