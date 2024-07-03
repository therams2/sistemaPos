Public Class RealVentavb
    Public Property TextoIngresado As String

    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        ' Verificar si la tecla presionada es Enter
        If e.KeyCode = Keys.Enter Then
            ' Al hacer clic en el botón "Aceptar", asigna el texto ingresado a la propiedad
            TextoIngresado = TextBox3.Text
            ' Cierra el formulario secundario
            Close()
        End If
    End Sub


    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        ' Verificar si el carácter ingresado no es un número, no es una tecla de control, ni es un punto decimal
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            ' Cancelar la entrada del carácter en el TextBox
            e.Handled = True
        End If
    End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class