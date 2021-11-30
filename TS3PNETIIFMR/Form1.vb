Public Class Form1
    Private Sub MenúToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenúToolStripMenuItem.Click
        Dim formIngresarDieta As New Form2
        formIngresarDieta.MdiParent = Me
        formIngresarDieta.Show()
    End Sub

    Private Sub InformeDeLaDietaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeDeLaDietaToolStripMenuItem.Click
        Dim formInformeDieta As New Form3
        formInformeDieta.MdiParent = Me
        formInformeDieta.Show()
    End Sub
End Class
