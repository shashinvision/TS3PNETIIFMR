Public Class Form2
    Private Sub addDiaBtn_Click(sender As Object, e As EventArgs) Handles addDiaBtn.Click

        diasInput.Items.Add(addDiaInput.Text)
        addDiaInput.Text = ""
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
End Class