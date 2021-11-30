Public Class Form2
    Private Sub addDiaBtn_Click(sender As Object, e As EventArgs) Handles addDiaBtn.Click

        Select Case addDiaInput.Text
            Case "Jueves", "Viernes", "Sábado", "Domingo"
                diasInput.Items.Add(addDiaInput.Text)
                addDiaInput.Text = ""
            Case Else
                MessageBox.Show("El valor de los dias de la semana deben ser:  Jueves, Viernes, Sábado, Domingo")
        End Select
    End Sub

    Private Sub addBebestibleBtn_Click(sender As Object, e As EventArgs) Handles addBebestibleBtn.Click

        Dim existe = False

        ' Recorro el listado para saber si existe un valor que coincida
        For i = 0 To bebestibleListBox.Items.Count - 1

            If addBebestibleInput.Text = bebestibleListBox.Items(i).ToString Then
                MessageBox.Show("No puede añadir un bebestible que ya se encuentra en la lista")
                existe = True
                addBebestibleInput.Text = ""
            End If
        Next

        ' Si no coincide se añade un nuevo elemento
        If existe = False Then
            bebestibleListBox.Items.Add(addBebestibleInput.Text)
            addBebestibleInput.Text = ""
        End If




    End Sub

    Private Sub addComestibleBtn_Click(sender As Object, e As EventArgs) Handles addComestibleBtn.Click

        Dim existe = False

        ' Recorro el listado para saber si existe un valor que coincida
        For i = 0 To comestibleListBox.Items.Count - 1

            If addComestibleInput.Text = comestibleListBox.Items(i).ToString Then
                MessageBox.Show("No puede añadir un comestible que ya se encuentra en la lista")
                existe = True
                addComestibleInput.Text = ""
            End If
        Next

        ' Si no coincide se añade un nuevo elemento
        If existe = False Then
            comestibleListBox.Items.Add(addComestibleInput.Text)
            addComestibleInput.Text = ""
        End If


    End Sub

    Private Sub addProteinaBtn_Click(sender As Object, e As EventArgs) Handles addProteinaBtn.Click

        Dim existe = False

        ' Recorro el listado para saber si existe un valor que coincida
        For i = 0 To proteinaListBox.Items.Count - 1

            If addProteinaInput.Text = proteinaListBox.Items(i).ToString Then
                MessageBox.Show("No puede añadir un Proteina que ya se encuentra en la lista")
                existe = True
                addProteinaInput.Text = ""
            End If
        Next

        ' Si no coincide se añade un nuevo elemento
        If existe = False Then
            proteinaListBox.Items.Add(addProteinaInput.Text)
            addProteinaInput.Text = ""
        End If

    End Sub

    Private Sub addAcompaniamientoBtn_Click(sender As Object, e As EventArgs) Handles addAcompaniamientoBtn.Click
        Dim existe = False

        ' Recorro el listado para saber si existe un valor que coincida
        For i = 0 To acompaniamientoListBox.Items.Count - 1

            If addAcompaniamientoInput.Text = acompaniamientoListBox.Items(i).ToString Then
                MessageBox.Show("No puede añadir un Acompaniamiento que ya se encuentra en la lista")
                existe = True
                addAcompaniamientoInput.Text = ""
            End If
        Next

        ' Si no coincide se añade un nuevo elemento
        If existe = False Then
            acompaniamientoListBox.Items.Add(addAcompaniamientoInput.Text)
            addAcompaniamientoInput.Text = ""
        End If
    End Sub

    Private Sub guardarBtn_Click(sender As Object, e As EventArgs) Handles guardarBtn.Click

        If diasInput.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un día para la dieta.")
        ElseIf bebestibleListBox.SelectedIndex = -1 Or comestibleListBox.SelectedIndex = -1 Or proteinaListBox.SelectedIndex = -1 Or verduraListBox.SelectedIndex = -1 Or frutaListBox.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una combinación completa de Desayuno, Almuerzo y Cena")
        Else

            ' se usa un diccionario para crear un arreglo asociativo por día, dentro de cada diccionario se usa un arreglo o lista con la data por día 
            ' de esta forma se crea un arreglo multidimensional 
            strResumen.Add(New Dictionary(Of String, String)() From {
                 {
                 diasInput.Text,
                  vbCrLf + "- Día " + diasInput.Text + vbCrLf
                  }
            })

            strResumen.Add(New Dictionary(Of String, String)() From {
                {
                diasInput.Text, " Desayuno:  " + bebestibleListBox.SelectedItem.ToString + " con " + comestibleListBox.SelectedItem.ToString + vbCrLf
                 }
           })

            strResumen.Add(New Dictionary(Of String, String)() From {
                {
                diasInput.Text, " Almuerzo:  " + proteinaListBox.SelectedItem.ToString + " con " + acompaniamientoListBox.SelectedItem.ToString + vbCrLf
                 }
           })

            strResumen.Add(New Dictionary(Of String, String)() From {
               {
               diasInput.Text, " Cena:  " + verduraListBox.SelectedItem.ToString + " con " + frutaListBox.SelectedItem.ToString + vbCrLf +
                "******************" +
                vbCrLf
                }
          })

            MessageBox.Show("Felicidades su menú se añadio al informe de la Dieta por día")

            ' Eliminación de registros ya guardados en informe de dieta

            diasInput.Items.Remove(diasInput.SelectedItem)
            bebestibleListBox.Items.Remove(bebestibleListBox.SelectedItem)
            comestibleListBox.Items.Remove(comestibleListBox.SelectedItem)

            proteinaListBox.Items.Remove(proteinaListBox.SelectedItem)
            acompaniamientoListBox.Items.Remove(acompaniamientoListBox.SelectedItem)

            verduraListBox.Items.Remove(verduraListBox.SelectedItem)
            frutaListBox.Items.Remove(frutaListBox.SelectedItem)

        End If

    End Sub

    Private Sub restaurarBtn_Click(sender As Object, e As EventArgs) Handles restaurarBtn.Click

        ' clear de data

        ' Dias 
        diasInput.Items.Clear()
        diasInput.Items.Add(diasBackup(0))
        diasInput.Items.Add(diasBackup(1))
        diasInput.Items.Add(diasBackup(2))

        ' Desayuno - Bebestibles
        bebestibleListBox.Items.Clear()
        bebestibleListBox.Items.Add(bebestibleBackup(0))
        bebestibleListBox.Items.Add(bebestibleBackup(1))
        bebestibleListBox.Items.Add(bebestibleBackup(2))
        bebestibleListBox.Items.Add(bebestibleBackup(3))
        bebestibleListBox.Items.Add(bebestibleBackup(4))
        bebestibleListBox.Items.Add(bebestibleBackup(5))
        bebestibleListBox.Items.Add(bebestibleBackup(6))

        ' Desayuno - Comestibles
        comestibleListBox.Items.Clear()
        comestibleListBox.Items.Add(comestibleBackup(0))
        comestibleListBox.Items.Add(comestibleBackup(1))
        comestibleListBox.Items.Add(comestibleBackup(2))
        comestibleListBox.Items.Add(comestibleBackup(3))
        comestibleListBox.Items.Add(comestibleBackup(4))
        comestibleListBox.Items.Add(comestibleBackup(5))
        comestibleListBox.Items.Add(comestibleBackup(6))

        ' Almuerzo - Proteína
        proteinaListBox.Items.Clear()
        proteinaListBox.Items.Add(proteinaBackup(0))
        proteinaListBox.Items.Add(proteinaBackup(1))
        proteinaListBox.Items.Add(proteinaBackup(2))
        proteinaListBox.Items.Add(proteinaBackup(3))
        proteinaListBox.Items.Add(proteinaBackup(4))
        proteinaListBox.Items.Add(proteinaBackup(5))
        proteinaListBox.Items.Add(proteinaBackup(6))
        proteinaListBox.Items.Add(proteinaBackup(7))

        ' Almuerzo - Acompañiamientos
        acompaniamientoListBox.Items.Clear()
        acompaniamientoListBox.Items.Add(acompaniamientoBackup(0))
        acompaniamientoListBox.Items.Add(acompaniamientoBackup(1))
        acompaniamientoListBox.Items.Add(acompaniamientoBackup(2))
        acompaniamientoListBox.Items.Add(acompaniamientoBackup(3))
        acompaniamientoListBox.Items.Add(acompaniamientoBackup(4))
        acompaniamientoListBox.Items.Add(acompaniamientoBackup(5))
        acompaniamientoListBox.Items.Add(acompaniamientoBackup(6))

        ' Cena - Verduras
        verduraListBox.Items.Clear()
        verduraListBox.Items.Add(verdurasBackup(0))
        verduraListBox.Items.Add(verdurasBackup(1))
        verduraListBox.Items.Add(verdurasBackup(2))
        verduraListBox.Items.Add(verdurasBackup(3))
        verduraListBox.Items.Add(verdurasBackup(4))
        verduraListBox.Items.Add(verdurasBackup(5))


        ' Cena - Frutas
        frutaListBox.Items.Clear()
        frutaListBox.Items.Add(frutasBackup(0))
        frutaListBox.Items.Add(frutasBackup(1))
        frutaListBox.Items.Add(frutasBackup(2))
        frutaListBox.Items.Add(frutasBackup(3))
        frutaListBox.Items.Add(frutasBackup(4))
        frutaListBox.Items.Add(frutasBackup(5))
        frutaListBox.Items.Add(frutasBackup(6))
        frutaListBox.Items.Add(frutasBackup(7))

        ' Limpieza de informe de dieta 

        strResumen.Clear()

        MessageBox.Show("Se restablece toda la información al modo inicial")

    End Sub
End Class