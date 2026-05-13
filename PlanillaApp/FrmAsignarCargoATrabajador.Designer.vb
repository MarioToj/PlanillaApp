<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignarCargoATrabajador
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
        Me.TxtNombreTrabajador = New System.Windows.Forms.TextBox()
        Me.CbCargos = New System.Windows.Forms.ComboBox()
        Me.BtnAsignarCargo = New System.Windows.Forms.Button()
        Me.BtnOtrosTipos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtNombreTrabajador
        '
        Me.TxtNombreTrabajador.Location = New System.Drawing.Point(194, 148)
        Me.TxtNombreTrabajador.Name = "TxtNombreTrabajador"
        Me.TxtNombreTrabajador.Size = New System.Drawing.Size(159, 20)
        Me.TxtNombreTrabajador.TabIndex = 0
        '
        'CbCargos
        '
        Me.CbCargos.FormattingEnabled = True
        Me.CbCargos.Location = New System.Drawing.Point(427, 147)
        Me.CbCargos.Name = "CbCargos"
        Me.CbCargos.Size = New System.Drawing.Size(153, 21)
        Me.CbCargos.TabIndex = 1
        '
        'BtnAsignarCargo
        '
        Me.BtnAsignarCargo.Location = New System.Drawing.Point(335, 203)
        Me.BtnAsignarCargo.Name = "BtnAsignarCargo"
        Me.BtnAsignarCargo.Size = New System.Drawing.Size(121, 44)
        Me.BtnAsignarCargo.TabIndex = 2
        Me.BtnAsignarCargo.Text = "Asignar Cargo"
        Me.BtnAsignarCargo.UseVisualStyleBackColor = True
        '
        'BtnOtrosTipos
        '
        Me.BtnOtrosTipos.Location = New System.Drawing.Point(332, 311)
        Me.BtnOtrosTipos.Name = "BtnOtrosTipos"
        Me.BtnOtrosTipos.Size = New System.Drawing.Size(124, 60)
        Me.BtnOtrosTipos.TabIndex = 3
        Me.BtnOtrosTipos.Text = "Asignación de Otros tipos de bonos"
        Me.BtnOtrosTipos.UseVisualStyleBackColor = True
        '
        'FrmAsignarCargoATrabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnOtrosTipos)
        Me.Controls.Add(Me.BtnAsignarCargo)
        Me.Controls.Add(Me.CbCargos)
        Me.Controls.Add(Me.TxtNombreTrabajador)
        Me.Name = "FrmAsignarCargoATrabajador"
        Me.Text = "FrmAsignarCargoATrabajador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombreTrabajador As TextBox
    Friend WithEvents CbCargos As ComboBox
    Friend WithEvents BtnAsignarCargo As Button
    Friend WithEvents BtnOtrosTipos As Button
End Class
