<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
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
        Me.MenuStrip1.Size = New System.Drawing.Size(778, 24)
        Me.MenuStrip1.TabIndex = 0
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
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 689)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
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
