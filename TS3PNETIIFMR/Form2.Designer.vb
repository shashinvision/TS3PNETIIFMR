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
        Me.restaurarBtn = New System.Windows.Forms.Button()
        Me.guardarBtn = New System.Windows.Forms.Button()
        Me.ingresarDietaTab = New System.Windows.Forms.TabControl()
        Me.DesayunoTab = New System.Windows.Forms.TabPage()
        Me.addComestibleBtn = New System.Windows.Forms.Button()
        Me.addComestibleInput = New System.Windows.Forms.TextBox()
        Me.addBebestibleBtn = New System.Windows.Forms.Button()
        Me.addBebestibleInput = New System.Windows.Forms.TextBox()
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
        Me.addAcompaniamientoBtn = New System.Windows.Forms.Button()
        Me.addAcompaniamientoInput = New System.Windows.Forms.TextBox()
        Me.addProteinaBtn = New System.Windows.Forms.Button()
        Me.addProteinaInput = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.acompaniamientoListBox = New System.Windows.Forms.ListBox()
        Me.proteinaListBox = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.ingresarDietaTab.SuspendLayout()
        Me.DesayunoTab.SuspendLayout()
        Me.almuerzoTab.SuspendLayout()
        Me.cenaTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.restaurarBtn)
        Me.Panel1.Controls.Add(Me.guardarBtn)
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
        'restaurarBtn
        '
        Me.restaurarBtn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.restaurarBtn.Location = New System.Drawing.Point(387, 598)
        Me.restaurarBtn.Name = "restaurarBtn"
        Me.restaurarBtn.Size = New System.Drawing.Size(261, 23)
        Me.restaurarBtn.TabIndex = 10
        Me.restaurarBtn.Text = "Restaurar"
        Me.restaurarBtn.UseVisualStyleBackColor = False
        '
        'guardarBtn
        '
        Me.guardarBtn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.guardarBtn.Location = New System.Drawing.Point(93, 598)
        Me.guardarBtn.Name = "guardarBtn"
        Me.guardarBtn.Size = New System.Drawing.Size(261, 23)
        Me.guardarBtn.TabIndex = 9
        Me.guardarBtn.Text = "Guardar"
        Me.guardarBtn.UseVisualStyleBackColor = False
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
        Me.DesayunoTab.Controls.Add(Me.Label9)
        Me.DesayunoTab.Controls.Add(Me.Label8)
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
        'addComestibleInput
        '
        Me.addComestibleInput.Location = New System.Drawing.Point(376, 310)
        Me.addComestibleInput.Name = "addComestibleInput"
        Me.addComestibleInput.Size = New System.Drawing.Size(261, 23)
        Me.addComestibleInput.TabIndex = 7
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
        'addBebestibleInput
        '
        Me.addBebestibleInput.Location = New System.Drawing.Point(33, 310)
        Me.addBebestibleInput.Name = "addBebestibleInput"
        Me.addBebestibleInput.Size = New System.Drawing.Size(261, 23)
        Me.addBebestibleInput.TabIndex = 5
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
        Me.almuerzoTab.Controls.Add(Me.Label11)
        Me.almuerzoTab.Controls.Add(Me.Label10)
        Me.almuerzoTab.Controls.Add(Me.addAcompaniamientoBtn)
        Me.almuerzoTab.Controls.Add(Me.addAcompaniamientoInput)
        Me.almuerzoTab.Controls.Add(Me.addProteinaBtn)
        Me.almuerzoTab.Controls.Add(Me.addProteinaInput)
        Me.almuerzoTab.Controls.Add(Me.Label4)
        Me.almuerzoTab.Controls.Add(Me.Label5)
        Me.almuerzoTab.Controls.Add(Me.acompaniamientoListBox)
        Me.almuerzoTab.Controls.Add(Me.proteinaListBox)
        Me.almuerzoTab.Location = New System.Drawing.Point(4, 24)
        Me.almuerzoTab.Name = "almuerzoTab"
        Me.almuerzoTab.Padding = New System.Windows.Forms.Padding(3)
        Me.almuerzoTab.Size = New System.Drawing.Size(683, 404)
        Me.almuerzoTab.TabIndex = 1
        Me.almuerzoTab.Text = "Almuerzo"
        Me.almuerzoTab.UseVisualStyleBackColor = True
        '
        'cenaTab
        '
        Me.cenaTab.Controls.Add(Me.Button3)
        Me.cenaTab.Controls.Add(Me.TextBox3)
        Me.cenaTab.Controls.Add(Me.Button4)
        Me.cenaTab.Controls.Add(Me.TextBox4)
        Me.cenaTab.Controls.Add(Me.Label6)
        Me.cenaTab.Controls.Add(Me.Label7)
        Me.cenaTab.Controls.Add(Me.ListBox3)
        Me.cenaTab.Controls.Add(Me.ListBox4)
        Me.cenaTab.Location = New System.Drawing.Point(4, 24)
        Me.cenaTab.Name = "cenaTab"
        Me.cenaTab.Padding = New System.Windows.Forms.Padding(3)
        Me.cenaTab.Size = New System.Drawing.Size(683, 404)
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
        'addAcompaniamientoBtn
        '
        Me.addAcompaniamientoBtn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.addAcompaniamientoBtn.Location = New System.Drawing.Point(382, 338)
        Me.addAcompaniamientoBtn.Name = "addAcompaniamientoBtn"
        Me.addAcompaniamientoBtn.Size = New System.Drawing.Size(261, 23)
        Me.addAcompaniamientoBtn.TabIndex = 16
        Me.addAcompaniamientoBtn.Text = "Añadir comestible"
        Me.addAcompaniamientoBtn.UseVisualStyleBackColor = False
        '
        'addAcompaniamientoInput
        '
        Me.addAcompaniamientoInput.Location = New System.Drawing.Point(382, 309)
        Me.addAcompaniamientoInput.Name = "addAcompaniamientoInput"
        Me.addAcompaniamientoInput.Size = New System.Drawing.Size(261, 23)
        Me.addAcompaniamientoInput.TabIndex = 15
        '
        'addProteinaBtn
        '
        Me.addProteinaBtn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.addProteinaBtn.Location = New System.Drawing.Point(39, 338)
        Me.addProteinaBtn.Name = "addProteinaBtn"
        Me.addProteinaBtn.Size = New System.Drawing.Size(261, 23)
        Me.addProteinaBtn.TabIndex = 11
        Me.addProteinaBtn.Text = "Añadir proteína"
        Me.addProteinaBtn.UseVisualStyleBackColor = False
        '
        'addProteinaInput
        '
        Me.addProteinaInput.Location = New System.Drawing.Point(39, 309)
        Me.addProteinaInput.Name = "addProteinaInput"
        Me.addProteinaInput.Size = New System.Drawing.Size(261, 23)
        Me.addProteinaInput.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(378, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(301, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "¿No encuentras tu acompañamiento?, añadelo a la lista."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(251, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "¿No encuentras tu proteína?, añadelo a la lista."
        '
        'acompaniamientoListBox
        '
        Me.acompaniamientoListBox.FormattingEnabled = True
        Me.acompaniamientoListBox.ItemHeight = 15
        Me.acompaniamientoListBox.Items.AddRange(New Object() {"Arroz Integral", "Fideos", "Puré", "Papas Cocidas", "Ensalada Surtida", "Legumbres", "Sopa"})
        Me.acompaniamientoListBox.Location = New System.Drawing.Point(378, 44)
        Me.acompaniamientoListBox.Name = "acompaniamientoListBox"
        Me.acompaniamientoListBox.Size = New System.Drawing.Size(265, 214)
        Me.acompaniamientoListBox.TabIndex = 10
        '
        'proteinaListBox
        '
        Me.proteinaListBox.FormattingEnabled = True
        Me.proteinaListBox.ItemHeight = 15
        Me.proteinaListBox.Items.AddRange(New Object() {"Churrasco", "Bistec", "Chuleta", "Costillar", "Pavo", "Pollo", "Salmón", "Atún"})
        Me.proteinaListBox.Location = New System.Drawing.Point(39, 44)
        Me.proteinaListBox.Name = "proteinaListBox"
        Me.proteinaListBox.Size = New System.Drawing.Size(261, 214)
        Me.proteinaListBox.TabIndex = 9
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(382, 338)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(261, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Añadir comestible"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(382, 309)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(261, 23)
        Me.TextBox3.TabIndex = 15
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Location = New System.Drawing.Point(39, 338)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(261, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Añadir bebestible"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(39, 309)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(261, 23)
        Me.TextBox4.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(378, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(265, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "¿No encuentras tu comestible?, añadelo a la lista."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(261, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "¿No encuentras tu bebestible?, añadelo a la lista."
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 15
        Me.ListBox3.Items.AddRange(New Object() {"Tostada integral", "Tostada con mantequilla", "Tostada con Jamón", "Tostada con Palta", "Marraqueta", "Marraqueta con Tomate", "Marraqueta con Salame"})
        Me.ListBox3.Location = New System.Drawing.Point(378, 44)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(265, 214)
        Me.ListBox3.TabIndex = 10
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 15
        Me.ListBox4.Items.AddRange(New Object() {"Té Solo", "Té con leche", "Café solo", "Café con leche", "Café express", "Café cortado", "Capuccino"})
        Me.ListBox4.Location = New System.Drawing.Point(39, 44)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(261, 214)
        Me.ListBox4.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(33, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 15)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Bebestible"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(372, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 15)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Comestible"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(39, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Proteína"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(378, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 15)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Acompañamiento"
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
        Me.almuerzoTab.ResumeLayout(False)
        Me.almuerzoTab.PerformLayout()
        Me.cenaTab.ResumeLayout(False)
        Me.cenaTab.PerformLayout()
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
    Friend WithEvents restaurarBtn As Button
    Friend WithEvents guardarBtn As Button
    Friend WithEvents addAcompaniamientoBtn As Button
    Friend WithEvents addAcompaniamientoInput As TextBox
    Friend WithEvents addProteinaBtn As Button
    Friend WithEvents addProteinaInput As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents acompaniamientoListBox As ListBox
    Friend WithEvents proteinaListBox As ListBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
End Class
