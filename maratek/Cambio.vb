Public Class Cambio
    Private Cambio As Decimal?

    Public Sub New(Cambio As Decimal?)
        InitializeComponent()
        Label2.Text = "$" & Cambio ' Establece el texto en el TextBox
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class