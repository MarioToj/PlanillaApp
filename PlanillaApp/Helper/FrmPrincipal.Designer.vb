<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuCatalogos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuCargos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuBonos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAsignarBonos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuCargoBonos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuTrabajadores = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAsignarOtros = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPlanilla = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuVerPlanillas = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuCatalogos, Me.MenuAsignarBonos, Me.MenuPlanilla})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuCatalogos
        '
        Me.MenuCatalogos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuCargos, Me.MenuBonos})
        Me.MenuCatalogos.Name = "MenuCatalogos"
        Me.MenuCatalogos.Size = New System.Drawing.Size(72, 20)
        Me.MenuCatalogos.Text = "Catálogos"
        '
        'MenuCargos
        '
        Me.MenuCargos.Name = "MenuCargos"
        Me.MenuCargos.Size = New System.Drawing.Size(180, 22)
        Me.MenuCargos.Text = "Menú Cargos"
        '
        'MenuBonos
        '
        Me.MenuBonos.Name = "MenuBonos"
        Me.MenuBonos.Size = New System.Drawing.Size(180, 22)
        Me.MenuBonos.Text = "Menú Bonos"
        '
        'MenuAsignarBonos
        '
        Me.MenuAsignarBonos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuCargoBonos, Me.MenuTrabajadores, Me.MenuAsignarOtros})
        Me.MenuAsignarBonos.Name = "MenuAsignarBonos"
        Me.MenuAsignarBonos.Size = New System.Drawing.Size(92, 20)
        Me.MenuAsignarBonos.Text = "Asignaciones "
        '
        'MenuCargoBonos
        '
        Me.MenuCargoBonos.Name = "MenuCargoBonos"
        Me.MenuCargoBonos.Size = New System.Drawing.Size(214, 22)
        Me.MenuCargoBonos.Text = " Cargo - Bono "
        '
        'MenuTrabajadores
        '
        Me.MenuTrabajadores.Name = "MenuTrabajadores"
        Me.MenuTrabajadores.Size = New System.Drawing.Size(180, 22)
        Me.MenuTrabajadores.Text = "Trabajadores"
        '
        'MenuAsignarOtros
        '
        Me.MenuAsignarOtros.Name = "MenuAsignarOtros"
        Me.MenuAsignarOtros.Size = New System.Drawing.Size(214, 22)
        Me.MenuAsignarOtros.Text = "Asignar Otros a Trabajador"
        '
        'MenuPlanilla
        '
        Me.MenuPlanilla.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuVerPlanillas})
        Me.MenuPlanilla.Name = "MenuPlanilla"
        Me.MenuPlanilla.Size = New System.Drawing.Size(57, 20)
        Me.MenuPlanilla.Text = "Planilla"
        '
        'MenuVerPlanillas
        '
        Me.MenuVerPlanillas.Name = "MenuVerPlanillas"
        Me.MenuVerPlanillas.Size = New System.Drawing.Size(136, 22)
        Me.MenuVerPlanillas.Text = "Ver Planillas"
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 24)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(800, 426)
        Me.PanelContenedor.TabIndex = 1
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.Text = "FrmPrincipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuCatalogos As ToolStripMenuItem
    Friend WithEvents MenuCargos As ToolStripMenuItem
    Friend WithEvents MenuBonos As ToolStripMenuItem
    Friend WithEvents MenuAsignarBonos As ToolStripMenuItem
    Friend WithEvents MenuCargoBonos As ToolStripMenuItem
    Friend WithEvents MenuTrabajadores As ToolStripMenuItem
    Friend WithEvents MenuAsignarOtros As ToolStripMenuItem
    Friend WithEvents MenuPlanilla As ToolStripMenuItem
    Friend WithEvents MenuVerPlanillas As ToolStripMenuItem
    Friend WithEvents PanelContenedor As Panel
End Class
