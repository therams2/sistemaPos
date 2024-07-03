Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private precioKilo As Decimal?

    Public Sub New(precioKilo As Decimal?)
        InitializeComponent()
        TextBox2.Text = "$" & precioKilo ' Establece el texto en el TextBox
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub


    Public Property TextoIngresado As String


    Private Sub TextBoxTexto_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTexto.TextChanged

    End Sub
    Private Sub TextBoxTexto_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxTexto.KeyDown
        ' Verificar si la tecla presionada es Enter
        If e.KeyCode = Keys.Enter Then
            ' Al hacer clic en el botón "Aceptar", asigna el texto ingresado a la propiedad
            TextoIngresado = TextBoxTexto.Text
            ' Cierra el formulario secundario
            Me.Close()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBoxTexto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTexto.KeyPress
        ' Verificar si el carácter ingresado no es un número, no es una tecla de control, ni es un punto decimal
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            ' Cancelar la entrada del carácter en el TextBox
            e.Handled = True
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class