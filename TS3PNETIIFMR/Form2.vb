Public Class Form2
    Private Sub addDiaBtn_Click(sender As Object, e As EventArgs) Handles addDiaBtn.Click

        diasInput.Items.Add(addDiaInput.Text)
        addDiaInput.Text = ""
    End Sub


End Class