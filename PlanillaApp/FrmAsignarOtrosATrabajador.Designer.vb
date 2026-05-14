<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAsignarOtrosATrabajador
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CbTrabajadores = New System.Windows.Forms.ComboBox()
        Me.LblTrabajador = New System.Windows.Forms.Label()
        Me.LblOtros = New System.Windows.Forms.Label()
        Me.LblMonto = New System.Windows.Forms.Label()
        Me.NuDHoras = New System.Windows.Forms.NumericUpDown()
        Me.LblHorasDias = New System.Windows.Forms.Label()
        Me.LblPorHora = New System.Windows.Forms.Label()
        Me.LblPorDia = New System.Windows.Forms.Label()
        Me.LblFijo = New System.Windows.Forms.Label()
        Me.LblPorcentajeSueldo = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.ChkPorHora = New System.Windows.Forms.CheckBox()
        Me.ChkPorDia = New System.Windows.Forms.CheckBox()
        Me.ChkFijo = New System.Windows.Forms.CheckBox()
        Me.ChkPorcentajeSueldo = New System.Windows.Forms.CheckBox()
        Me.LblDias = New System.Windows.Forms.Label()
        Me.NuDias = New System.Windows.Forms.NumericUpDown()
        Me.LblTitleMonto = New System.Windows.Forms.Label()
        Me.ClbCargoBonos = New System.Windows.Forms.CheckedListBox()
        Me.LblTitleBonos = New System.Windows.Forms.Label()
        Me.LblTotalBonos = New System.Windows.Forms.Label()
        Me.BtnCalcularTotal = New System.Windows.Forms.Button()
        Me.LblSueldo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.NuDHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuDias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CbTrabajadores
        '
        Me.CbTrabajadores.FormattingEnabled = True
        Me.CbTrabajadores.Location = New System.Drawing.Point(21, 89)
        Me.CbTrabajadores.Name = "CbTrabajadores"
        Me.CbTrabajadores.Size = New System.Drawing.Size(188, 21)
        Me.CbTrabajadores.TabIndex = 0
        '
        'LblTrabajador
        '
        Me.LblTrabajador.AutoSize = True
        Me.LblTrabajador.Location = New System.Drawing.Point(81, 61)
        Me.LblTrabajador.Name = "LblTrabajador"
        Me.LblTrabajador.Size = New System.Drawing.Size(61, 13)
        Me.LblTrabajador.TabIndex = 2
        Me.LblTrabajador.Text = "Trabajador "
        '
        'LblOtros
        '
        Me.LblOtros.AutoSize = True
        Me.LblOtros.Location = New System.Drawing.Point(240, 182)
        Me.LblOtros.Name = "LblOtros"
        Me.LblOtros.Size = New System.Drawing.Size(151, 13)
        Me.LblOtros.TabIndex = 3
        Me.LblOtros.Text = "Otro tipo de bono o descuento"
        '
        'LblMonto
        '
        Me.LblMonto.AutoSize = True
        Me.LblMonto.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LblMonto.Location = New System.Drawing.Point(377, 364)
        Me.LblMonto.Name = "LblMonto"
        Me.LblMonto.Size = New System.Drawing.Size(37, 13)
        Me.LblMonto.TabIndex = 5
        Me.LblMonto.Text = "Monto"
        '
        'NuDHoras
        '
        Me.NuDHoras.BackColor = System.Drawing.SystemColors.HotTrack
        Me.NuDHoras.Location = New System.Drawing.Point(407, 198)
        Me.NuDHoras.Name = "NuDHoras"
        Me.NuDHoras.Size = New System.Drawing.Size(60, 20)
        Me.NuDHoras.TabIndex = 6
        '
        'LblHorasDias
        '
        Me.LblHorasDias.AutoSize = True
        Me.LblHorasDias.BackColor = System.Drawing.SystemColors.Highlight
        Me.LblHorasDias.Location = New System.Drawing.Point(473, 200)
        Me.LblHorasDias.Name = "LblHorasDias"
        Me.LblHorasDias.Size = New System.Drawing.Size(35, 13)
        Me.LblHorasDias.TabIndex = 7
        Me.LblHorasDias.Text = "Horas"
        '
        'LblPorHora
        '
        Me.LblPorHora.AutoSize = True
        Me.LblPorHora.BackColor = System.Drawing.SystemColors.Highlight
        Me.LblPorHora.Location = New System.Drawing.Point(387, 203)
        Me.LblPorHora.Name = "LblPorHora"
        Me.LblPorHora.Size = New System.Drawing.Size(13, 13)
        Me.LblPorHora.TabIndex = 8
        Me.LblPorHora.Text = "+"
        '
        'LblPorDia
        '
        Me.LblPorDia.AutoSize = True
        Me.LblPorDia.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblPorDia.Location = New System.Drawing.Point(387, 226)
        Me.LblPorDia.Name = "LblPorDia"
        Me.LblPorDia.Size = New System.Drawing.Size(13, 13)
        Me.LblPorDia.TabIndex = 9
        Me.LblPorDia.Text = "+"
        '
        'LblFijo
        '
        Me.LblFijo.AutoSize = True
        Me.LblFijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblFijo.Location = New System.Drawing.Point(387, 242)
        Me.LblFijo.Name = "LblFijo"
        Me.LblFijo.Size = New System.Drawing.Size(13, 13)
        Me.LblFijo.TabIndex = 10
        Me.LblFijo.Text = "+"
        '
        'LblPorcentajeSueldo
        '
        Me.LblPorcentajeSueldo.AutoSize = True
        Me.LblPorcentajeSueldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblPorcentajeSueldo.Location = New System.Drawing.Point(387, 264)
        Me.LblPorcentajeSueldo.Name = "LblPorcentajeSueldo"
        Me.LblPorcentajeSueldo.Size = New System.Drawing.Size(13, 13)
        Me.LblPorcentajeSueldo.TabIndex = 11
        Me.LblPorcentajeSueldo.Text = "+"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(369, 286)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(31, 13)
        Me.LblTotal.TabIndex = 12
        Me.LblTotal.Text = "Total"
        '
        'ChkPorHora
        '
        Me.ChkPorHora.AutoSize = True
        Me.ChkPorHora.Location = New System.Drawing.Point(243, 199)
        Me.ChkPorHora.Name = "ChkPorHora"
        Me.ChkPorHora.Size = New System.Drawing.Size(68, 17)
        Me.ChkPorHora.TabIndex = 13
        Me.ChkPorHora.Text = "Por Hora"
        Me.ChkPorHora.UseVisualStyleBackColor = True
        '
        'ChkPorDia
        '
        Me.ChkPorDia.AutoSize = True
        Me.ChkPorDia.Location = New System.Drawing.Point(243, 218)
        Me.ChkPorDia.Name = "ChkPorDia"
        Me.ChkPorDia.Size = New System.Drawing.Size(145, 17)
        Me.ChkPorDia.TabIndex = 14
        Me.ChkPorDia.Text = "Biaticos por dia Q.120.00"
        Me.ChkPorDia.UseVisualStyleBackColor = True
        '
        'ChkFijo
        '
        Me.ChkFijo.AutoSize = True
        Me.ChkFijo.Location = New System.Drawing.Point(243, 238)
        Me.ChkFijo.Name = "ChkFijo"
        Me.ChkFijo.Size = New System.Drawing.Size(97, 17)
        Me.ChkFijo.TabIndex = 15
        Me.ChkFijo.Text = "Seguro medico"
        Me.ChkFijo.UseVisualStyleBackColor = True
        '
        'ChkPorcentajeSueldo
        '
        Me.ChkPorcentajeSueldo.AutoSize = True
        Me.ChkPorcentajeSueldo.Location = New System.Drawing.Point(243, 260)
        Me.ChkPorcentajeSueldo.Name = "ChkPorcentajeSueldo"
        Me.ChkPorcentajeSueldo.Size = New System.Drawing.Size(70, 17)
        Me.ChkPorcentajeSueldo.TabIndex = 16
        Me.ChkPorcentajeSueldo.Text = "Prestamo"
        Me.ChkPorcentajeSueldo.UseVisualStyleBackColor = True
        '
        'LblDias
        '
        Me.LblDias.AutoSize = True
        Me.LblDias.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LblDias.Location = New System.Drawing.Point(473, 223)
        Me.LblDias.Name = "LblDias"
        Me.LblDias.Size = New System.Drawing.Size(28, 13)
        Me.LblDias.TabIndex = 18
        Me.LblDias.Text = "Dias"
        '
        'NuDias
        '
        Me.NuDias.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.NuDias.Location = New System.Drawing.Point(407, 221)
        Me.NuDias.Name = "NuDias"
        Me.NuDias.Size = New System.Drawing.Size(60, 20)
        Me.NuDias.TabIndex = 17
        '
        'LblTitleMonto
        '
        Me.LblTitleMonto.AutoSize = True
        Me.LblTitleMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblTitleMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleMonto.Location = New System.Drawing.Point(229, 360)
        Me.LblTitleMonto.Name = "LblTitleMonto"
        Me.LblTitleMonto.Size = New System.Drawing.Size(119, 18)
        Me.LblTitleMonto.TabIndex = 19
        Me.LblTitleMonto.Text = "Sueldo Líquido"
        '
        'ClbCargoBonos
        '
        Me.ClbCargoBonos.FormattingEnabled = True
        Me.ClbCargoBonos.Location = New System.Drawing.Point(243, 41)
        Me.ClbCargoBonos.Name = "ClbCargoBonos"
        Me.ClbCargoBonos.Size = New System.Drawing.Size(143, 94)
        Me.ClbCargoBonos.TabIndex = 20
        '
        'LblTitleBonos
        '
        Me.LblTitleBonos.AutoSize = True
        Me.LblTitleBonos.BackColor = System.Drawing.SystemColors.Info
        Me.LblTitleBonos.Location = New System.Drawing.Point(404, 41)
        Me.LblTitleBonos.Name = "LblTitleBonos"
        Me.LblTitleBonos.Size = New System.Drawing.Size(79, 13)
        Me.LblTitleBonos.TabIndex = 21
        Me.LblTitleBonos.Text = "Total de Bonos"
        '
        'LblTotalBonos
        '
        Me.LblTotalBonos.AutoSize = True
        Me.LblTotalBonos.BackColor = System.Drawing.SystemColors.Info
        Me.LblTotalBonos.Location = New System.Drawing.Point(505, 41)
        Me.LblTotalBonos.Name = "LblTotalBonos"
        Me.LblTotalBonos.Size = New System.Drawing.Size(59, 13)
        Me.LblTotalBonos.TabIndex = 22
        Me.LblTotalBonos.Text = "total bonos"
        '
        'BtnCalcularTotal
        '
        Me.BtnCalcularTotal.BackColor = System.Drawing.Color.Lime
        Me.BtnCalcularTotal.Location = New System.Drawing.Point(295, 333)
        Me.BtnCalcularTotal.Name = "BtnCalcularTotal"
        Me.BtnCalcularTotal.Size = New System.Drawing.Size(105, 24)
        Me.BtnCalcularTotal.TabIndex = 23
        Me.BtnCalcularTotal.Text = "CalcularTotal"
        Me.BtnCalcularTotal.UseVisualStyleBackColor = False
        '
        'LblSueldo
        '
        Me.LblSueldo.AutoSize = True
        Me.LblSueldo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblSueldo.Location = New System.Drawing.Point(137, 263)
        Me.LblSueldo.Name = "LblSueldo"
        Me.LblSueldo.Size = New System.Drawing.Size(40, 13)
        Me.LblSueldo.TabIndex = 24
        Me.LblSueldo.Text = "Sueldo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 283)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Total deducciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Sueldo Base"
        '
        'FrmAsignarOtrosATrabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblSueldo)
        Me.Controls.Add(Me.BtnCalcularTotal)
        Me.Controls.Add(Me.LblTotalBonos)
        Me.Controls.Add(Me.LblTitleBonos)
        Me.Controls.Add(Me.ClbCargoBonos)
        Me.Controls.Add(Me.LblTitleMonto)
        Me.Controls.Add(Me.LblDias)
        Me.Controls.Add(Me.NuDias)
        Me.Controls.Add(Me.ChkPorcentajeSueldo)
        Me.Controls.Add(Me.ChkFijo)
        Me.Controls.Add(Me.ChkPorDia)
        Me.Controls.Add(Me.ChkPorHora)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.LblPorcentajeSueldo)
        Me.Controls.Add(Me.LblFijo)
        Me.Controls.Add(Me.LblPorDia)
        Me.Controls.Add(Me.LblPorHora)
        Me.Controls.Add(Me.LblHorasDias)
        Me.Controls.Add(Me.NuDHoras)
        Me.Controls.Add(Me.LblMonto)
        Me.Controls.Add(Me.LblOtros)
        Me.Controls.Add(Me.LblTrabajador)
        Me.Controls.Add(Me.CbTrabajadores)
        Me.Name = "FrmAsignarOtrosATrabajador"
        Me.Text = "FrmAsignarOtrosATrabajador"
        CType(Me.NuDHoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuDias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CbTrabajadores As ComboBox
    Friend WithEvents LblTrabajador As Label
    Friend WithEvents LblOtros As Label
    Friend WithEvents LblMonto As Label
    Friend WithEvents NuDHoras As NumericUpDown
    Friend WithEvents LblHorasDias As Label
    Friend WithEvents LblPorHora As Label
    Friend WithEvents LblPorDia As Label
    Friend WithEvents LblFijo As Label
    Friend WithEvents LblPorcentajeSueldo As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents ChkPorHora As CheckBox
    Friend WithEvents ChkPorDia As CheckBox
    Friend WithEvents ChkFijo As CheckBox
    Friend WithEvents ChkPorcentajeSueldo As CheckBox
    Friend WithEvents LblDias As Label
    Friend WithEvents NuDias As NumericUpDown
    Friend WithEvents LblTitleMonto As Label
    Friend WithEvents ClbCargoBonos As CheckedListBox
    Friend WithEvents LblTitleBonos As Label
    Friend WithEvents LblTotalBonos As Label
    Friend WithEvents BtnCalcularTotal As Button
    Friend WithEvents LblSueldo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
