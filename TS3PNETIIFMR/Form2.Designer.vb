<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ingresarDietaTab = New System.Windows.Forms.TabControl()
        Me.DesayunoTab = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comestibleListBox = New System.Windows.Forms.ListBox()
        Me.bebestibleListBox = New System.Windows.Forms.ListBox()
        Me.almuerzoTab = New System.Windows.Forms.TabPage()
        Me.cenaTab = New System.Windows.Forms.TabPage()
        Me.addDiaBtn = New System.Windows.Forms.Button()
        Me.addDiaInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.diasInput = New System.Windows.Forms.ComboBox()
        Me.addBebestibleInput = New System.Windows.Forms.TextBox()
        Me.addBebestibleBtn = New System.Windows.Forms.Button()
        Me.addComestibleInput = New System.Windows.Forms.TextBox()
        Me.addComestibleBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.ingresarDietaTab.SuspendLayout()
        Me.DesayunoTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ingresarDietaTab)
        Me.Panel1.Controls.Add(Me.addDiaBtn)
        Me.Panel1.Controls.Add(Me.addDiaInput)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.diasInput)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 687)
        Me.Panel1.TabIndex = 0
        '
        'ingresarDietaTab
        '
        Me.ingresarDietaTab.Controls.Add(Me.DesayunoTab)
        Me.ingresarDietaTab.Controls.Add(Me.almuerzoTab)
        Me.ingresarDietaTab.Controls.Add(Me.cenaTab)
        Me.ingresarDietaTab.Location = New System.Drawing.Point(30, 146)
        Me.ingresarDietaTab.Name = "ingresarDietaTab"
        Me.ingresarDietaTab.SelectedIndex = 0
        Me.ingresarDietaTab.Size = New System.Drawing.Size(691, 432)
        Me.ingresarDietaTab.TabIndex = 4
        '
        'DesayunoTab
        '
        Me.DesayunoTab.Controls.Add(Me.addComestibleBtn)
        Me.DesayunoTab.Controls.Add(Me.addComestibleInput)
        Me.DesayunoTab.Controls.Add(Me.addBebestibleBtn)
        Me.DesayunoTab.Controls.Add(Me.addBebestibleInput)
        Me.DesayunoTab.Controls.Add(Me.Label3)
        Me.DesayunoTab.Controls.Add(Me.Label2)
        Me.DesayunoTab.Controls.Add(Me.comestibleListBox)
        Me.DesayunoTab.Controls.Add(Me.bebestibleListBox)
        Me.DesayunoTab.Location = New System.Drawing.Point(4, 24)
        Me.DesayunoTab.Name = "DesayunoTab"
        Me.DesayunoTab.Padding = New System.Windows.Forms.Padding(3)
        Me.DesayunoTab.Size = New System.Drawing.Size(683, 404)
        Me.DesayunoTab.TabIndex = 0
        Me.DesayunoTab.Text = "Desayuno"
        Me.DesayunoTab.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(372, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "¿No encuentras tu comestible?, añadelo a la lista."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "¿No encuentras tu bebestible?, añadelo a la lista."
        '
        'comestibleListBox
        '
        Me.comestibleListBox.FormattingEnabled = True
        Me.comestibleListBox.ItemHeight = 15
        Me.comestibleListBox.Items.AddRange(New Object() {"Tostada integral", "Tostada con mantequilla", "Tostada con Jamón", "Tostada con Palta", "Marraqueta", "Marraqueta con Tomate", "Marraqueta con Salame"})
        Me.comestibleListBox.Location = New System.Drawing.Point(372, 45)
        Me.comestibleListBox.Name = "comestibleListBox"
        Me.comestibleListBox.Size = New System.Drawing.Size(265, 214)
        Me.comestibleListBox.TabIndex = 1
        '
        'bebestibleListBox
        '
        Me.bebestibleListBox.FormattingEnabled = True
        Me.bebestibleListBox.ItemHeight = 15
        Me.bebestibleListBox.Items.AddRange(New Object() {"Té Solo", "Té con leche", "Café solo", "Café con leche", "Café express", "Café cortado", "Capuccino"})
        Me.bebestibleListBox.Location = New System.Drawing.Point(33, 45)
        Me.bebestibleListBox.Name = "bebestibleListBox"
        Me.bebestibleListBox.Size = New System.Drawing.Size(261, 214)
        Me.bebestibleListBox.TabIndex = 0
        '
        'almuerzoTab
        '
        Me.almuerzoTab.Location = New System.Drawing.Point(4, 24)
        Me.almuerzoTab.Name = "almuerzoTab"
        Me.almuerzoTab.Padding = New System.Windows.Forms.Padding(3)
        Me.almuerzoTab.Size = New System.Drawing.Size(683, 368)
        Me.almuerzoTab.TabIndex = 1
        Me.almuerzoTab.Text = "Almuerzo"
        Me.almuerzoTab.UseVisualStyleBackColor = True
        '
        'cenaTab
        '
        Me.cenaTab.Location = New System.Drawing.Point(4, 24)
        Me.cenaTab.Name = "cenaTab"
        Me.cenaTab.Padding = New System.Windows.Forms.Padding(3)
        Me.cenaTab.Size = New System.Drawing.Size(683, 368)
        Me.cenaTab.TabIndex = 2
        Me.cenaTab.Text = "Cena"
        Me.cenaTab.UseVisualStyleBackColor = True
        '
        'addDiaBtn
        '
        Me.addDiaBtn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.addDiaBtn.Location = New System.Drawing.Point(192, 104)
        Me.addDiaBtn.Name = "addDiaBtn"
        Me.addDiaBtn.Size = New System.Drawing.Size(75, 23)
        Me.addDiaBtn.TabIndex = 3
        Me.addDiaBtn.Text = "Añadir día"
        Me.addDiaBtn.UseVisualStyleBackColor = False
        '
        'addDiaInput
        '
        Me.addDiaInput.Location = New System.Drawing.Point(30, 104)
        Me.addDiaInput.Name = "addDiaInput"
        Me.addDiaInput.Size = New System.Drawing.Size(144, 23)
        Me.addDiaInput.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "¿No encuentras tu día?, añada un nuevo día."
        '
        'diasInput
        '
        Me.diasInput.FormattingEnabled = True
        Me.diasInput.Items.AddRange(New Object() {"Lunes", "Martes", "Miércoles"})
        Me.diasInput.Location = New System.Drawing.Point(30, 34)
        Me.diasInput.Name = "diasInput"
        Me.diasInput.Size = New System.Drawing.Size(144, 23)
        Me.diasInput.TabIndex = 0
        Me.diasInput.Text = "-- Seleccione un día --"
        '
        'addBebestibleInput
        '
        Me.addBebestibleInput.Location = New System.Drawing.Point(33, 310)
        Me.addBebestibleInput.Name = "addBebestibleInput"
        Me.addBebestibleInput.Size = New System.Drawing.Size(261, 23)
        Me.addBebestibleInput.TabIndex = 5
        '
        'addBebestibleBtn
        '
        Me.addBebestibleBtn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.addBebestibleBtn.Location = New System.Drawing.Point(33, 339)
        Me.addBebestibleBtn.Name = "addBebestibleBtn"
        Me.addBebestibleBtn.Size = New System.Drawing.Size(261, 23)
        Me.addBebestibleBtn.TabIndex = 5
        Me.addBebestibleBtn.Text = "Añadir bebestible"
        Me.addBebestibleBtn.UseVisualStyleBackColor = False
        '
        'addComestibleInput
        '
        Me.addComestibleInput.Location = New System.Drawing.Point(376, 310)
        Me.addComestibleInput.Name = "addComestibleInput"
        Me.addComestibleInput.Size = New System.Drawing.Size(261, 23)
        Me.addComestibleInput.TabIndex = 7
        '
        'addComestibleBtn
        '
        Me.addComestibleBtn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.addComestibleBtn.Location = New System.Drawing.Point(376, 339)
        Me.addComestibleBtn.Name = "addComestibleBtn"
        Me.addComestibleBtn.Size = New System.Drawing.Size(261, 23)
        Me.addComestibleBtn.TabIndex = 8
        Me.addComestibleBtn.Text = "Añadir comestible"
        Me.addComestibleBtn.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 689)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar Dieta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ingresarDietaTab.ResumeLayout(False)
        Me.DesayunoTab.ResumeLayout(False)
        Me.DesayunoTab.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents diasInput As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents addDiaBtn As Button
    Friend WithEvents addDiaInput As TextBox
    Friend WithEvents ingresarDietaTab As TabControl
    Friend WithEvents DesayunoTab As TabPage
    Friend WithEvents almuerzoTab As TabPage
    Friend WithEvents cenaTab As TabPage
    Friend WithEvents comestibleListBox As ListBox
    Friend WithEvents bebestibleListBox As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents addBebestibleBtn As Button
    Friend WithEvents addBebestibleInput As TextBox
    Friend WithEvents addComestibleBtn As Button
    Friend WithEvents addComestibleInput As TextBox
End Class
