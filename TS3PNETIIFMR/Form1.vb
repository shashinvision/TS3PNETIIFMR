Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim formHijo As New Form2
        formHijo.MdiParent = Me
        formHijo.Show()
    End Sub
End Class
