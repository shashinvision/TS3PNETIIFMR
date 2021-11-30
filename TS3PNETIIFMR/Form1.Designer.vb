<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.IngresarDietaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenúToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeDeLaDietaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnsambladoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarDietaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IngresarDietaToolStripMenuItem
        '
        Me.IngresarDietaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúToolStripMenuItem, Me.InformeDeLaDietaToolStripMenuItem, Me.EnsambladoToolStripMenuItem})
        Me.IngresarDietaToolStripMenuItem.Name = "IngresarDietaToolStripMenuItem"
        Me.IngresarDietaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.IngresarDietaToolStripMenuItem.Text = "Menú"
        '
        'MenúToolStripMenuItem
        '
        Me.MenúToolStripMenuItem.Name = "MenúToolStripMenuItem"
        Me.MenúToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MenúToolStripMenuItem.Text = "Ingresar Dieta"
        '
        'InformeDeLaDietaToolStripMenuItem
        '
        Me.InformeDeLaDietaToolStripMenuItem.Name = "InformeDeLaDietaToolStripMenuItem"
        Me.InformeDeLaDietaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InformeDeLaDietaToolStripMenuItem.Text = "Informe de la Dieta"
        '
        'EnsambladoToolStripMenuItem
        '
        Me.EnsambladoToolStripMenuItem.Name = "EnsambladoToolStripMenuItem"
        Me.EnsambladoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EnsambladoToolStripMenuItem.Text = "Ensamblado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TS3PNETIIFMR.My.Resources.Resources.dieta
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Nutricionista Experto - Felipe Mancilla"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IngresarDietaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformeDeLaDietaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnsambladoToolStripMenuItem As ToolStripMenuItem
End Class
