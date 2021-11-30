Imports FormControl2 = CS2PNETII.Form1

Public Class Form1
    ' ensamblado 

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim formIngresarDieta As New Form2
        formIngresarDieta.MdiParent = Me
        formIngresarDieta.Show()
    End Sub

    Private Sub EnsambladoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnsambladoToolStripMenuItem.Click
        Dim formControlSemana2 As New FormControl2
        formControlSemana2.MdiParent = Me
        formControlSemana2.Show()
    End Sub
End Class
