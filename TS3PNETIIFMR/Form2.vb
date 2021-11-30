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
            comestibleListBox.Items.Remove(bebestibleListBox.SelectedItem)
            verduraListBox.Items.Remove(bebestibleListBox.SelectedItem)
            frutaListBox.Items.Remove(bebestibleListBox.SelectedItem)



        End If

    End Sub
End Class