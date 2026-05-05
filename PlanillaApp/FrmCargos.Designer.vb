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
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DgvCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNombreCargo
        '
        Me.TxtNombreCargo.Location = New System.Drawing.Point(133, 129)
        Me.TxtNombreCargo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtNombreCargo.Name = "TxtNombreCargo"
        Me.TxtNombreCargo.Size = New System.Drawing.Size(124, 20)
        Me.TxtNombreCargo.TabIndex = 0
        '
        'LblNombreCargo
        '
        Me.LblNombreCargo.AutoSize = True
        Me.LblNombreCargo.Location = New System.Drawing.Point(148, 114)
        Me.LblNombreCargo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombreCargo.Name = "LblNombreCargo"
        Me.LblNombreCargo.Size = New System.Drawing.Size(92, 13)
        Me.LblNombreCargo.TabIndex = 1
        Me.LblNombreCargo.Text = "Nombre del Cargo"
        '
        'LblSueldoBase
        '
        Me.LblSueldoBase.AutoSize = True
        Me.LblSueldoBase.Location = New System.Drawing.Point(325, 114)
        Me.LblSueldoBase.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSueldoBase.Name = "LblSueldoBase"
        Me.LblSueldoBase.Size = New System.Drawing.Size(67, 13)
        Me.LblSueldoBase.TabIndex = 3
        Me.LblSueldoBase.Text = "Sueldo Base"
        '
        'TxtSueldoBase
        '
        Me.TxtSueldoBase.Location = New System.Drawing.Point(297, 129)
        Me.TxtSueldoBase.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtSueldoBase.Name = "TxtSueldoBase"
        Me.TxtSueldoBase.Size = New System.Drawing.Size(124, 20)
        Me.TxtSueldoBase.TabIndex = 2
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(226, 157)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(101, 25)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'DgvCargos
        '
        Me.DgvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCargos.Location = New System.Drawing.Point(89, 187)
        Me.DgvCargos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DgvCargos.Name = "DgvCargos"
        Me.DgvCargos.RowHeadersWidth = 62
        Me.DgvCargos.RowTemplate.Height = 28
        Me.DgvCargos.Size = New System.Drawing.Size(385, 98)
        Me.DgvCargos.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(242, 316)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Ir a Bonos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmCargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 400)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DgvCargos)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.LblSueldoBase)
        Me.Controls.Add(Me.TxtSueldoBase)
        Me.Controls.Add(Me.LblNombreCargo)
        Me.Controls.Add(Me.TxtNombreCargo)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
    Friend WithEvents Button1 As Button
End Class
