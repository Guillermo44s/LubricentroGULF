<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lubricante
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
        Me.txtNombreL = New System.Windows.Forms.TextBox()
        Me.txtarray = New System.Windows.Forms.TextBox()
        Me.btncargarL = New System.Windows.Forms.Button()
        Me.btnmodificarL = New System.Windows.Forms.Button()
        Me.btneliminarL = New System.Windows.Forms.Button()
        Me.grillaLubricante = New System.Windows.Forms.DataGridView()
        Me.barra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.grillaLubricante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombreL
        '
        Me.txtNombreL.Location = New System.Drawing.Point(73, 84)
        Me.txtNombreL.Name = "txtNombreL"
        Me.txtNombreL.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreL.TabIndex = 0
        '
        'txtarray
        '
        Me.txtarray.Location = New System.Drawing.Point(73, 36)
        Me.txtarray.Name = "txtarray"
        Me.txtarray.Size = New System.Drawing.Size(100, 20)
        Me.txtarray.TabIndex = 1
        Me.txtarray.Visible = False
        '
        'btncargarL
        '
        Me.btncargarL.Location = New System.Drawing.Point(73, 152)
        Me.btncargarL.Name = "btncargarL"
        Me.btncargarL.Size = New System.Drawing.Size(75, 23)
        Me.btncargarL.TabIndex = 2
        Me.btncargarL.Text = "Cargar"
        Me.btncargarL.UseVisualStyleBackColor = True
        '
        'btnmodificarL
        '
        Me.btnmodificarL.Location = New System.Drawing.Point(73, 203)
        Me.btnmodificarL.Name = "btnmodificarL"
        Me.btnmodificarL.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificarL.TabIndex = 3
        Me.btnmodificarL.Text = "Modificar"
        Me.btnmodificarL.UseVisualStyleBackColor = True
        '
        'btneliminarL
        '
        Me.btneliminarL.Location = New System.Drawing.Point(73, 247)
        Me.btneliminarL.Name = "btneliminarL"
        Me.btneliminarL.Size = New System.Drawing.Size(75, 23)
        Me.btneliminarL.TabIndex = 4
        Me.btneliminarL.Text = "Eliminar"
        Me.btneliminarL.UseVisualStyleBackColor = True
        '
        'grillaLubricante
        '
        Me.grillaLubricante.AllowUserToAddRows = False
        Me.grillaLubricante.AllowUserToDeleteRows = False
        Me.grillaLubricante.AllowUserToOrderColumns = True
        Me.grillaLubricante.AllowUserToResizeColumns = False
        Me.grillaLubricante.AllowUserToResizeRows = False
        Me.grillaLubricante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaLubricante.Location = New System.Drawing.Point(283, 84)
        Me.grillaLubricante.Name = "grillaLubricante"
        Me.grillaLubricante.ReadOnly = True
        Me.grillaLubricante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaLubricante.Size = New System.Drawing.Size(240, 234)
        Me.grillaLubricante.TabIndex = 5
        '
        'barra
        '
        Me.barra.Location = New System.Drawing.Point(283, 46)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(240, 20)
        Me.barra.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(356, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Buscar Lubricante"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Location = New System.Drawing.Point(551, 183)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(279, 49)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "LUBRICENTRO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LubricentroGulf.My.Resources.Resources._660px_Gulf_logo
        Me.PictureBox1.Location = New System.Drawing.Point(623, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'Lubricante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 450)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.grillaLubricante)
        Me.Controls.Add(Me.btneliminarL)
        Me.Controls.Add(Me.btnmodificarL)
        Me.Controls.Add(Me.btncargarL)
        Me.Controls.Add(Me.txtarray)
        Me.Controls.Add(Me.txtNombreL)
        Me.Name = "Lubricante"
        Me.Text = "Lubricante"
        CType(Me.grillaLubricante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombreL As TextBox
    Friend WithEvents txtarray As TextBox
    Friend WithEvents btncargarL As Button
    Friend WithEvents btnmodificarL As Button
    Friend WithEvents btneliminarL As Button
    Friend WithEvents grillaLubricante As DataGridView
    Friend WithEvents barra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
