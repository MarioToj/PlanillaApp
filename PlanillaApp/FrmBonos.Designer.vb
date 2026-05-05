<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBonos
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
        Me.DgvBonos = New System.Windows.Forms.DataGridView()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.LblMontoBono = New System.Windows.Forms.Label()
        Me.TxtMontoBono = New System.Windows.Forms.TextBox()
        Me.LblNombreBono = New System.Windows.Forms.Label()
        Me.TxtNombreBono = New System.Windows.Forms.TextBox()
        CType(Me.DgvBonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvBonos
        '
        Me.DgvBonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBonos.Location = New System.Drawing.Point(208, 213)
        Me.DgvBonos.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvBonos.Name = "DgvBonos"
        Me.DgvBonos.RowHeadersWidth = 62
        Me.DgvBonos.RowTemplate.Height = 28
        Me.DgvBonos.Size = New System.Drawing.Size(385, 98)
        Me.DgvBonos.TabIndex = 11
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(345, 183)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(101, 25)
        Me.BtnGuardar.TabIndex = 10
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'LblMontoBono
        '
        Me.LblMontoBono.AutoSize = True
        Me.LblMontoBono.Location = New System.Drawing.Point(444, 140)
        Me.LblMontoBono.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblMontoBono.Name = "LblMontoBono"
        Me.LblMontoBono.Size = New System.Drawing.Size(82, 13)
        Me.LblMontoBono.TabIndex = 9
        Me.LblMontoBono.Text = "Monto del Bono"
        '
        'TxtMontoBono
        '
        Me.TxtMontoBono.Location = New System.Drawing.Point(416, 155)
        Me.TxtMontoBono.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtMontoBono.Name = "TxtMontoBono"
        Me.TxtMontoBono.Size = New System.Drawing.Size(124, 20)
        Me.TxtMontoBono.TabIndex = 8
        '
        'LblNombreBono
        '
        Me.LblNombreBono.AutoSize = True
        Me.LblNombreBono.Location = New System.Drawing.Point(267, 140)
        Me.LblNombreBono.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombreBono.Name = "LblNombreBono"
        Me.LblNombreBono.Size = New System.Drawing.Size(89, 13)
        Me.LblNombreBono.TabIndex = 7
        Me.LblNombreBono.Text = "Nombre del Bono"
        '
        'TxtNombreBono
        '
        Me.TxtNombreBono.Location = New System.Drawing.Point(252, 155)
        Me.TxtNombreBono.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombreBono.Name = "TxtNombreBono"
        Me.TxtNombreBono.Size = New System.Drawing.Size(124, 20)
        Me.TxtNombreBono.TabIndex = 6
        '
        'FrmBonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DgvBonos)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.LblMontoBono)
        Me.Controls.Add(Me.TxtMontoBono)
        Me.Controls.Add(Me.LblNombreBono)
        Me.Controls.Add(Me.TxtNombreBono)
        Me.Name = "FrmBonos"
        Me.Text = "FrmBonos"
        CType(Me.DgvBonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvBonos As DataGridView
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents LblMontoBono As Label
    Friend WithEvents TxtMontoBono As TextBox
    Friend WithEvents LblNombreBono As Label
    Friend WithEvents TxtNombreBono As TextBox
End Class
