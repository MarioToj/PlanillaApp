<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignacionDeBonosACargos
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
        Me.CbObtenerCargos = New System.Windows.Forms.ComboBox()
        Me.CbObtenerBonos = New System.Windows.Forms.ComboBox()
        Me.LblTitleAsignarBonosACargos = New System.Windows.Forms.Label()
        Me.BtnAsignarBono = New System.Windows.Forms.Button()
        Me.LblCargo = New System.Windows.Forms.Label()
        Me.LblBono = New System.Windows.Forms.Label()
        Me.BtnAsignarCargos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CbObtenerCargos
        '
        Me.CbObtenerCargos.FormattingEnabled = True
        Me.CbObtenerCargos.Location = New System.Drawing.Point(236, 191)
        Me.CbObtenerCargos.Name = "CbObtenerCargos"
        Me.CbObtenerCargos.Size = New System.Drawing.Size(121, 21)
        Me.CbObtenerCargos.TabIndex = 0
        '
        'CbObtenerBonos
        '
        Me.CbObtenerBonos.FormattingEnabled = True
        Me.CbObtenerBonos.Location = New System.Drawing.Point(457, 191)
        Me.CbObtenerBonos.Name = "CbObtenerBonos"
        Me.CbObtenerBonos.Size = New System.Drawing.Size(121, 21)
        Me.CbObtenerBonos.TabIndex = 1
        '
        'LblTitleAsignarBonosACargos
        '
        Me.LblTitleAsignarBonosACargos.AutoSize = True
        Me.LblTitleAsignarBonosACargos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleAsignarBonosACargos.Location = New System.Drawing.Point(320, 116)
        Me.LblTitleAsignarBonosACargos.Name = "LblTitleAsignarBonosACargos"
        Me.LblTitleAsignarBonosACargos.Size = New System.Drawing.Size(190, 24)
        Me.LblTitleAsignarBonosACargos.TabIndex = 2
        Me.LblTitleAsignarBonosACargos.Text = "Asignacion de Bonos"
        '
        'BtnAsignarBono
        '
        Me.BtnAsignarBono.Location = New System.Drawing.Point(374, 320)
        Me.BtnAsignarBono.Name = "BtnAsignarBono"
        Me.BtnAsignarBono.Size = New System.Drawing.Size(75, 23)
        Me.BtnAsignarBono.TabIndex = 3
        Me.BtnAsignarBono.Text = "Asignar"
        Me.BtnAsignarBono.UseVisualStyleBackColor = True
        '
        'LblCargo
        '
        Me.LblCargo.AutoSize = True
        Me.LblCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCargo.Location = New System.Drawing.Point(270, 162)
        Me.LblCargo.Name = "LblCargo"
        Me.LblCargo.Size = New System.Drawing.Size(49, 18)
        Me.LblCargo.TabIndex = 4
        Me.LblCargo.Text = "Cargo"
        '
        'LblBono
        '
        Me.LblBono.AutoSize = True
        Me.LblBono.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBono.Location = New System.Drawing.Point(492, 162)
        Me.LblBono.Name = "LblBono"
        Me.LblBono.Size = New System.Drawing.Size(44, 18)
        Me.LblBono.TabIndex = 5
        Me.LblBono.Text = "Bono"
        '
        'BtnAsignarCargos
        '
        Me.BtnAsignarCargos.Location = New System.Drawing.Point(341, 370)
        Me.BtnAsignarCargos.Name = "BtnAsignarCargos"
        Me.BtnAsignarCargos.Size = New System.Drawing.Size(169, 23)
        Me.BtnAsignarCargos.TabIndex = 6
        Me.BtnAsignarCargos.Text = "Ir a asignacion de cargos"
        Me.BtnAsignarCargos.UseVisualStyleBackColor = True
        '
        'AsignacionDeBonosACargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnAsignarCargos)
        Me.Controls.Add(Me.LblBono)
        Me.Controls.Add(Me.LblCargo)
        Me.Controls.Add(Me.BtnAsignarBono)
        Me.Controls.Add(Me.LblTitleAsignarBonosACargos)
        Me.Controls.Add(Me.CbObtenerBonos)
        Me.Controls.Add(Me.CbObtenerCargos)
        Me.Name = "AsignacionDeBonosACargos"
        Me.Text = "AsignacionDeBonosACargos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CbObtenerCargos As ComboBox
    Friend WithEvents CbObtenerBonos As ComboBox
    Friend WithEvents LblTitleAsignarBonosACargos As Label
    Friend WithEvents BtnAsignarBono As Button
    Friend WithEvents LblCargo As Label
    Friend WithEvents LblBono As Label
    Friend WithEvents BtnAsignarCargos As Button
End Class
