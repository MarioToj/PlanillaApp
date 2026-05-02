<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCargos
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
        Me.TxtNombreCargo = New System.Windows.Forms.TextBox()
        Me.LblNombreCargo = New System.Windows.Forms.Label()
        Me.LblSueldoBase = New System.Windows.Forms.Label()
        Me.TxtSueldoBase = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.DgvCargos = New System.Windows.Forms.DataGridView()
        CType(Me.DgvCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNombreCargo
        '
        Me.TxtNombreCargo.Location = New System.Drawing.Point(199, 199)
        Me.TxtNombreCargo.Name = "TxtNombreCargo"
        Me.TxtNombreCargo.Size = New System.Drawing.Size(184, 26)
        Me.TxtNombreCargo.TabIndex = 0
        '
        'LblNombreCargo
        '
        Me.LblNombreCargo.AutoSize = True
        Me.LblNombreCargo.Location = New System.Drawing.Point(222, 176)
        Me.LblNombreCargo.Name = "LblNombreCargo"
        Me.LblNombreCargo.Size = New System.Drawing.Size(137, 20)
        Me.LblNombreCargo.TabIndex = 1
        Me.LblNombreCargo.Text = "Nombre del Cargo"
        '
        'LblSueldoBase
        '
        Me.LblSueldoBase.AutoSize = True
        Me.LblSueldoBase.Location = New System.Drawing.Point(487, 176)
        Me.LblSueldoBase.Name = "LblSueldoBase"
        Me.LblSueldoBase.Size = New System.Drawing.Size(100, 20)
        Me.LblSueldoBase.TabIndex = 3
        Me.LblSueldoBase.Text = "Sueldo Base"
        '
        'TxtSueldoBase
        '
        Me.TxtSueldoBase.Location = New System.Drawing.Point(446, 199)
        Me.TxtSueldoBase.Name = "TxtSueldoBase"
        Me.TxtSueldoBase.Size = New System.Drawing.Size(184, 26)
        Me.TxtSueldoBase.TabIndex = 2
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(339, 242)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(151, 38)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'DgvCargos
        '
        Me.DgvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCargos.Location = New System.Drawing.Point(134, 288)
        Me.DgvCargos.Name = "DgvCargos"
        Me.DgvCargos.RowHeadersWidth = 62
        Me.DgvCargos.RowTemplate.Height = 28
        Me.DgvCargos.Size = New System.Drawing.Size(577, 150)
        Me.DgvCargos.TabIndex = 5
        '
        'FrmCargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DgvCargos)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.LblSueldoBase)
        Me.Controls.Add(Me.TxtSueldoBase)
        Me.Controls.Add(Me.LblNombreCargo)
        Me.Controls.Add(Me.TxtNombreCargo)
        Me.Name = "FrmCargos"
        Me.Text = "Cargos"
        CType(Me.DgvCargos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombreCargo As TextBox
    Friend WithEvents LblNombreCargo As Label
    Friend WithEvents LblSueldoBase As Label
    Friend WithEvents TxtSueldoBase As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents DgvCargos As DataGridView
End Class
