<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignarOtrosATrabajador
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
        Me.CbTrabajadores = New System.Windows.Forms.ComboBox()
        Me.LblTrabajador = New System.Windows.Forms.Label()
        Me.LblOtros = New System.Windows.Forms.Label()
        Me.ClbOtrosTipos = New System.Windows.Forms.CheckedListBox()
        Me.LblMonto = New System.Windows.Forms.Label()
        Me.NuDContador = New System.Windows.Forms.NumericUpDown()
        Me.LblHorasDias = New System.Windows.Forms.Label()
        Me.RbPorHora = New System.Windows.Forms.RadioButton()
        Me.GbOtros = New System.Windows.Forms.GroupBox()
        Me.RbPorDia = New System.Windows.Forms.RadioButton()
        Me.RbSeguoMedico = New System.Windows.Forms.RadioButton()
        Me.RbPrestamo = New System.Windows.Forms.RadioButton()
        Me.LblPorHora = New System.Windows.Forms.Label()
        Me.LblPorDia = New System.Windows.Forms.Label()
        Me.LblSeguroMedico = New System.Windows.Forms.Label()
        Me.LblPrestamo = New System.Windows.Forms.Label()
        CType(Me.NuDContador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbOtros.SuspendLayout()
        Me.SuspendLayout()
        '
        'CbTrabajadores
        '
        Me.CbTrabajadores.FormattingEnabled = True
        Me.CbTrabajadores.Location = New System.Drawing.Point(168, 169)
        Me.CbTrabajadores.Name = "CbTrabajadores"
        Me.CbTrabajadores.Size = New System.Drawing.Size(188, 21)
        Me.CbTrabajadores.TabIndex = 0
        '
        'LblTrabajador
        '
        Me.LblTrabajador.AutoSize = True
        Me.LblTrabajador.Location = New System.Drawing.Point(228, 141)
        Me.LblTrabajador.Name = "LblTrabajador"
        Me.LblTrabajador.Size = New System.Drawing.Size(61, 13)
        Me.LblTrabajador.TabIndex = 2
        Me.LblTrabajador.Text = "Trabajador "
        '
        'LblOtros
        '
        Me.LblOtros.AutoSize = True
        Me.LblOtros.Location = New System.Drawing.Point(387, 141)
        Me.LblOtros.Name = "LblOtros"
        Me.LblOtros.Size = New System.Drawing.Size(151, 13)
        Me.LblOtros.TabIndex = 3
        Me.LblOtros.Text = "Otro tipo de bono o descuento"
        '
        'ClbOtrosTipos
        '
        Me.ClbOtrosTipos.FormattingEnabled = True
        Me.ClbOtrosTipos.Location = New System.Drawing.Point(84, 281)
        Me.ClbOtrosTipos.Name = "ClbOtrosTipos"
        Me.ClbOtrosTipos.Size = New System.Drawing.Size(120, 94)
        Me.ClbOtrosTipos.TabIndex = 4
        '
        'LblMonto
        '
        Me.LblMonto.AutoSize = True
        Me.LblMonto.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LblMonto.Location = New System.Drawing.Point(697, 172)
        Me.LblMonto.Name = "LblMonto"
        Me.LblMonto.Size = New System.Drawing.Size(37, 13)
        Me.LblMonto.TabIndex = 5
        Me.LblMonto.Text = "Monto"
        '
        'NuDContador
        '
        Me.NuDContador.Location = New System.Drawing.Point(607, 157)
        Me.NuDContador.Name = "NuDContador"
        Me.NuDContador.Size = New System.Drawing.Size(60, 20)
        Me.NuDContador.TabIndex = 6
        '
        'LblHorasDias
        '
        Me.LblHorasDias.AutoSize = True
        Me.LblHorasDias.Location = New System.Drawing.Point(604, 141)
        Me.LblHorasDias.Name = "LblHorasDias"
        Me.LblHorasDias.Size = New System.Drawing.Size(63, 13)
        Me.LblHorasDias.TabIndex = 7
        Me.LblHorasDias.Text = "Horas/Días"
        '
        'RbPorHora
        '
        Me.RbPorHora.AutoSize = True
        Me.RbPorHora.Location = New System.Drawing.Point(6, 16)
        Me.RbPorHora.Name = "RbPorHora"
        Me.RbPorHora.Size = New System.Drawing.Size(67, 17)
        Me.RbPorHora.TabIndex = 8
        Me.RbPorHora.TabStop = True
        Me.RbPorHora.Text = "Por Hora"
        Me.RbPorHora.UseVisualStyleBackColor = True
        '
        'GbOtros
        '
        Me.GbOtros.Controls.Add(Me.LblPorHora)
        Me.GbOtros.Controls.Add(Me.LblPorDia)
        Me.GbOtros.Controls.Add(Me.LblSeguroMedico)
        Me.GbOtros.Controls.Add(Me.LblPrestamo)
        Me.GbOtros.Controls.Add(Me.RbPrestamo)
        Me.GbOtros.Controls.Add(Me.RbSeguoMedico)
        Me.GbOtros.Controls.Add(Me.RbPorDia)
        Me.GbOtros.Controls.Add(Me.RbPorHora)
        Me.GbOtros.Location = New System.Drawing.Point(385, 157)
        Me.GbOtros.Name = "GbOtros"
        Me.GbOtros.Size = New System.Drawing.Size(216, 116)
        Me.GbOtros.TabIndex = 9
        Me.GbOtros.TabStop = False
        Me.GbOtros.Text = "Opciones"
        '
        'RbPorDia
        '
        Me.RbPorDia.AutoSize = True
        Me.RbPorDia.Location = New System.Drawing.Point(5, 39)
        Me.RbPorDia.Name = "RbPorDia"
        Me.RbPorDia.Size = New System.Drawing.Size(62, 17)
        Me.RbPorDia.TabIndex = 9
        Me.RbPorDia.TabStop = True
        Me.RbPorDia.Text = "Por Día"
        Me.RbPorDia.UseVisualStyleBackColor = True
        '
        'RbSeguoMedico
        '
        Me.RbSeguoMedico.AutoSize = True
        Me.RbSeguoMedico.Location = New System.Drawing.Point(6, 62)
        Me.RbSeguoMedico.Name = "RbSeguoMedico"
        Me.RbSeguoMedico.Size = New System.Drawing.Size(97, 17)
        Me.RbSeguoMedico.TabIndex = 10
        Me.RbSeguoMedico.TabStop = True
        Me.RbSeguoMedico.Text = "Seguro Médico"
        Me.RbSeguoMedico.UseVisualStyleBackColor = True
        '
        'RbPrestamo
        '
        Me.RbPrestamo.AutoSize = True
        Me.RbPrestamo.Location = New System.Drawing.Point(6, 85)
        Me.RbPrestamo.Name = "RbPrestamo"
        Me.RbPrestamo.Size = New System.Drawing.Size(69, 17)
        Me.RbPrestamo.TabIndex = 11
        Me.RbPrestamo.TabStop = True
        Me.RbPrestamo.Text = "Préstamo"
        Me.RbPrestamo.UseVisualStyleBackColor = True
        '
        'LblPorHora
        '
        Me.LblPorHora.AutoSize = True
        Me.LblPorHora.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LblPorHora.Location = New System.Drawing.Point(173, 20)
        Me.LblPorHora.Name = "LblPorHora"
        Me.LblPorHora.Size = New System.Drawing.Size(13, 13)
        Me.LblPorHora.TabIndex = 10
        Me.LblPorHora.Text = "+"
        '
        'LblPorDia
        '
        Me.LblPorDia.AutoSize = True
        Me.LblPorDia.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LblPorDia.Location = New System.Drawing.Point(173, 43)
        Me.LblPorDia.Name = "LblPorDia"
        Me.LblPorDia.Size = New System.Drawing.Size(13, 13)
        Me.LblPorDia.TabIndex = 11
        Me.LblPorDia.Text = "+"
        '
        'LblSeguroMedico
        '
        Me.LblSeguroMedico.AutoSize = True
        Me.LblSeguroMedico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblSeguroMedico.Location = New System.Drawing.Point(173, 66)
        Me.LblSeguroMedico.Name = "LblSeguroMedico"
        Me.LblSeguroMedico.Size = New System.Drawing.Size(10, 13)
        Me.LblSeguroMedico.TabIndex = 12
        Me.LblSeguroMedico.Text = "-"
        '
        'LblPrestamo
        '
        Me.LblPrestamo.AutoSize = True
        Me.LblPrestamo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblPrestamo.Location = New System.Drawing.Point(173, 89)
        Me.LblPrestamo.Name = "LblPrestamo"
        Me.LblPrestamo.Size = New System.Drawing.Size(10, 13)
        Me.LblPrestamo.TabIndex = 13
        Me.LblPrestamo.Text = "-"
        '
        'FrmAsignarOtrosATrabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GbOtros)
        Me.Controls.Add(Me.LblHorasDias)
        Me.Controls.Add(Me.NuDContador)
        Me.Controls.Add(Me.LblMonto)
        Me.Controls.Add(Me.ClbOtrosTipos)
        Me.Controls.Add(Me.LblOtros)
        Me.Controls.Add(Me.LblTrabajador)
        Me.Controls.Add(Me.CbTrabajadores)
        Me.Name = "FrmAsignarOtrosATrabajador"
        Me.Text = "FrmAsignarOtrosATrabajador"
        CType(Me.NuDContador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbOtros.ResumeLayout(False)
        Me.GbOtros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CbTrabajadores As ComboBox
    Friend WithEvents LblTrabajador As Label
    Friend WithEvents LblOtros As Label
    Friend WithEvents ClbOtrosTipos As CheckedListBox
    Friend WithEvents LblMonto As Label
    Friend WithEvents NuDContador As NumericUpDown
    Friend WithEvents LblHorasDias As Label
    Friend WithEvents RbPorHora As RadioButton
    Friend WithEvents GbOtros As GroupBox
    Friend WithEvents RbPrestamo As RadioButton
    Friend WithEvents RbSeguoMedico As RadioButton
    Friend WithEvents RbPorDia As RadioButton
    Friend WithEvents LblPorHora As Label
    Friend WithEvents LblPorDia As Label
    Friend WithEvents LblSeguroMedico As Label
    Friend WithEvents LblPrestamo As Label
End Class
