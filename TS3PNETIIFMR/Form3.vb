Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' posicion  strResumen(0) = dias de un arreglo

        For i As Integer = 0 To strResumen.Count - 1
            Dim value As Dictionary(Of String, String) = strResumen(i)
            If value.ContainsKey("Lunes") Then
                strResumenTextBox.Text += value("Lunes")
            End If

            If value.ContainsKey("Martes") Then
                strResumenTextBox.Text += value("Martes")
            End If

            If value.ContainsKey("Miércoles") Then
                strResumenTextBox.Text += value("Miércoles")
            End If

            If value.ContainsKey("Jueves") Then
                strResumenTextBox.Text += value("Jueves")
            End If


            If value.ContainsKey("Viernes") Then
                strResumenTextBox.Text += value("Viernes")
            End If

            If value.ContainsKey("Sábado") Then
                strResumenTextBox.Text += value("Sábado")
            End If

            If value.ContainsKey("Domingo") Then
                strResumenTextBox.Text += value("Domingo")
            End If


        Next
    End Sub


End Class