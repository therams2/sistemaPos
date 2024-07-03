Imports System.Windows
Imports System.Windows.Media.Animation
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim listaCarritos As New ArrayList()
    Dim listaTickets As New List(Of TicketsEnc)()
    ' Crear una instancia del formulario secundario
    Dim ArticulosMain As New Articulos()

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Focus()
        CargarTickets()

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub CargarTickets()
        ' Supongamos que code es una variable que contiene el valor a buscar  
        Dim query As String = "SELECT Id, TotalVenta, Importe, Cambio, Estatus, DATE_FORMAT(Created_At, '%H:%i:%s') AS CreatedAt FROM ing_cat_ventas WHERE Estatus = 'POS' ORDER BY Id DESC"
        Using conexion As MySqlConnection = New ConexionDB().AbrirConexion()
            Using comando As New MySqlCommand(query, conexion)
                Using reader As MySqlDataReader = comando.ExecuteReader()
                    While reader.Read()
                        Dim ticketPos As New TicketsEnc() With {
                        .Id = Convert.ToInt32(reader("Id")),
                        .TotalVenta = Convert.ToDecimal(reader("TotalVenta")),
                        .Importe = Convert.ToDecimal(reader("Importe")),
                        .Cambio = Convert.ToDecimal(reader("Cambio")),
                        .Estatus = Convert.ToString(reader("Estatus")),
                        .Hora = Convert.ToString(reader("CreatedAt"))
                        }
                        listaTickets.Add(ticketPos)
                    End While
                End Using
            End Using
        End Using

        For Each ticket As TicketsEnc In listaTickets
            ' Agregar una fila al DataGridView por cada carrito en la lista
            Dim index As Integer = DataGridView2.Rows.Add(("#" & ticket.Id), "$" & ticket.TotalVenta, "$" & ticket.Importe, ticket.Hora)
            Dim Cargar As New DataGridViewButtonCell()
            DataGridView2.Rows(index).Cells("Cargar") = Cargar
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Sub txtInput_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim code As String = TextBox1.Text

            ' Variable para indicar si se encontró el elemento
            Dim encontrado As Boolean = False

            ' Recorrer la lista de objetos de la clase Carrito
            For Each car As Carrrito In listaCarritos
                If car.Code = code Then
                    If car.IdUnidadTipo <> 2 Then
                        car.Cantidad += 1

                        encontrado = True
                        Exit For
                    Else
                        Dim Form2 As New Form2(car.PrecioKilo)
                        Form2.ShowDialog()
                        Form2.TextBoxTexto.Focus()

                        Dim gramos As Int32 = Form2.TextoIngresado
                        car.Cantidad = gramos
                        car.Precio = car.PrecioKilo * (gramos / 1000)
                        encontrado = True
                        Exit For
                    End If
                    encontrado = False
                End If
            Next

            If encontrado Then

                DataGridView1.Rows.Clear()

                For Each car As Carrrito In listaCarritos
                    Dim index As Integer
                    If car.IdUnidadTipo <> 2 Then
                        index = DataGridView1.Rows.Add(car.Code, car.Nombre & "/" & car.Descripcion, car.Cantidad, car.Precio, car.Cantidad * car.Precio, car.Id)
                    Else
                        index = DataGridView1.Rows.Add(car.Code, car.Nombre & "/" & car.Descripcion, car.Cantidad, car.Precio, car.Precio, car.Id)
                    End If

                    Dim deleteButton As New DataGridViewButtonCell()
                    deleteButton.Value = ChrW(&HF00D)
                    DataGridView1.Rows(index).Cells("Eliminar") = deleteButton
                Next

            Else
                'Creamos la query
                Dim query As String = "SELECT id, nombre, descripcion, cantidad, id_unidad_tipo AS idunidadtipo, precio, code, peso, costo_ini, id_unidad_medida, precio_kilo FROM adq_cat_articulos WHERE code = @code"

                ' Supongamos que code es una variable que contiene el valor a buscar 
                Dim carrito As Carrrito = Nothing
                Using conexion As MySqlConnection = New ConexionDB().AbrirConexion()
                    Using comando As New MySqlCommand(query, conexion)
                        comando.Parameters.AddWithValue("@code", code)
                        Using reader As MySqlDataReader = comando.ExecuteReader()
                            If reader.Read() Then ' Solo obtenemos el primer registro
                                carrito = New Carrrito() With {
                                    .Id = Convert.ToInt32(reader("id")),
                                    .Nombre = reader("nombre").ToString().ToUpper(),
                                    .Descripcion = If(Not IsDBNull(reader("descripcion")), reader("descripcion").ToString().ToUpper(), ""),
                                    .Precio = Convert.ToDecimal(reader("precio")),
                                    .Code = reader("code").ToString(),
                                    .IdUnidadTipo = Convert.ToInt32(reader("idunidadtipo")),
                                    .PrecioKilo = If(Not IsDBNull(reader("precio_kilo")), Convert.ToDecimal(reader("precio_kilo")), 0)
                                }
                            End If
                            'MessageBox.Show("ID" + carrito.Id.ToString, "Título del Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Using
                    End Using
                End Using

                ' Validar si se encontró un registro
                If carrito IsNot Nothing Then

                    ' Agregamos el objeto carrito al ArrayList
                    If carrito.IdUnidadTipo = 2 Then
                        Dim Form2 As New Form2(carrito.PrecioKilo)
                        Form2.ShowDialog()
                        Form2.TextBoxTexto.Focus()

                        If String.IsNullOrEmpty(Form2.TextoIngresado) OrElse Form2.TextoIngresado = "0" Then
                            Return
                        End If

                        Dim gramos As Int32 = Form2.TextoIngresado
                        carrito.Cantidad = gramos
                        carrito.Precio = carrito.PrecioKilo * (gramos / 1000)

                    Else
                        carrito.Cantidad = 1
                    End If


                    listaCarritos.Add(carrito)

                    DataGridView1.Rows.Clear()

                    For Each car As Carrrito In listaCarritos
                        Dim index As Integer
                        If car.IdUnidadTipo <> 2 Then
                            index = DataGridView1.Rows.Add(car.Code, car.Nombre & "/" & car.Descripcion, car.Cantidad, car.Precio, car.Cantidad * car.Precio, car.Id)
                        Else
                            index = DataGridView1.Rows.Add(car.Code, car.Nombre & "/" & car.Descripcion, car.Cantidad, car.Precio, car.Precio, car.Id)
                        End If

                        Dim deleteButton As New DataGridViewButtonCell()
                        deleteButton.Value = ChrW(&HF00D)
                        DataGridView1.Rows(index).Cells("Eliminar") = deleteButton
                    Next
                Else
                    MessageBox.Show("No se encontró ningún registro.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            Dim sumaSubtotal As Decimal = 0

            For Each fila As DataGridViewRow In DataGridView1.Rows
                ' Verifica si la celda de la columna "Subtotal" no está vacía y es un valor numérico
                If Not fila.Cells("Subtotal").Value Is Nothing AndAlso IsNumeric(fila.Cells("Subtotal").Value) Then
                    ' Suma el valor de la celda a la suma total
                    sumaSubtotal += Convert.ToDecimal(fila.Cells("Subtotal").Value)
                    TextBox3.ResetText()
                    TextBox3.AppendText("$ " & sumaSubtotal)

                End If
            Next
            TextBox1.ResetText()
        End If

    End Sub
    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        ' Verificar si la celda actual pertenece a la columna de precio
        If e.ColumnIndex = DataGridView1.Columns("Precio").Index AndAlso e.RowIndex >= 0 Then
            ' Verificar si el valor de la celda es numérico
            Dim precio As Decimal
            If Decimal.TryParse(e.Value.ToString, precio) Then
                ' Formatear el valor numérico con dos dígitos decimales y punto decimal
                e.Value = precio.ToString("N2")
                ' Indicar que el formato ha sido aplicado para evitar la conversión automática del DataGridView
                e.FormattingApplied = True
            End If
        End If
        If e.ColumnIndex = DataGridView1.Columns("Subtotal").Index AndAlso e.RowIndex >= 0 Then
            ' Verificar si el valor de la celda es numérico
            Dim precio As Decimal
            If Decimal.TryParse(e.Value.ToString, precio) Then
                ' Formatear el valor numérico con dos dígitos decimales y punto decimal
                e.Value = precio.ToString("N2")
                ' Indicar que el formato ha sido aplicado para evitar la conversión automática del DataGridView
                e.FormattingApplied = True
            End If
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Verificar si se hizo clic en la columna de eliminar y que el clic fue en un botón
        If e.ColumnIndex = DataGridView1.Columns("Eliminar").Index AndAlso e.RowIndex >= 0 Then
            ' Obtener el ID de la celda eliminada
            Dim idEliminado = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("Id").Value)

            ' Eliminar el elemento correspondiente de la lista listaCarritos
            For Each carrito As Carrrito In listaCarritos
                If carrito.Id = idEliminado Then
                    listaCarritos.Remove(carrito)
                    Exit For ' Salir del bucle una vez que se haya encontrado y eliminado el elemento
                End If
            Next

            ' Eliminar la fila del DataGridView
            DataGridView1.Rows.RemoveAt(e.RowIndex)

            ' Variable para almacenar la suma de los subtotales
            Dim sumaSubtotal As Decimal = 0

            ' Recorre todas las filas del DataGridView
            For Each fila As DataGridViewRow In DataGridView1.Rows
                ' Verifica si la celda de la columna "Subtotal" no está vacía y es un valor numérico
                If Not fila.Cells("Subtotal").Value Is Nothing AndAlso IsNumeric(fila.Cells("Subtotal").Value) Then
                    ' Suma el valor de la celda a la suma total
                    sumaSubtotal += Convert.ToDecimal(fila.Cells("Subtotal").Value)
                End If
            Next

            ' Actualizar el valor de TextBox3 con la suma total
            TextBox3.Text = "$ " & sumaSubtotal.ToString
        End If
    End Sub

    Function calcularPrecioTipo(ByVal texto As String) As Boolean
        If String.IsNullOrEmpty(texto) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        Dim buscarart As String = ComboBox1.Text
        Dim carritos As New List(Of Carrrito)()
        Dim query As String = "SELECT id, nombre, descripcion,code FROM adq_cat_articulos WHERE nombre LIKE @nombre LIMIT 50"

        ' Supongamos que code es una variable que contiene el valor a buscar
        Dim nombre As String = "%" & buscarart & "%" ' Añadir comodines % alrededor del texto para búsqueda flexible

        ' Conexión a la base de datos
        Using conexion As MySqlConnection = New ConexionDB().AbrirConexion()
            Using comando As New MySqlCommand(query, conexion)
                comando.Parameters.AddWithValue("@nombre", nombre)
                Using reader As MySqlDataReader = comando.ExecuteReader()
                    While reader.Read() ' Iteramos sobre todos los registros devueltos
                        Dim carrito As New Carrrito() With {
                        .Id = Convert.ToInt32(reader("id")),
                        .Nombre = reader("nombre").ToString(),
                        .Descripcion = If(Not IsDBNull(reader("descripcion")), reader("descripcion").ToString(), ""),
                        .Code = reader("code").ToString()
                    }
                        carritos.Add(carrito) ' Agregamos el carrito a la lista
                    End While
                End Using
            End Using
        End Using

        ' Guarda la posición actual del cursor
        Dim currentIndex As Integer = ComboBox1.SelectedIndex

        ' Limpia el ComboBox sin mover el cursor
        ComboBox1.Items.Clear()

        ' Restaura la posición del cursor si había una selección anterior
        If currentIndex >= 0 AndAlso currentIndex < ComboBox1.Items.Count Then
            ComboBox1.SelectedIndex = currentIndex
        End If

        ' Mueve el cursor al final del texto
        ComboBox1.SelectionStart = ComboBox1.Text.Length
        ComboBox1.SelectionLength = 0

        ' Agrega los elementos de la lista al ComboBox

    End Sub

    Private Sub VENDER_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VENDER_Click_1(sender As Object, e As EventArgs) Handles VENDER.Click
        Try
            ' Validar que listaCarritos tenga al menos un registro
            If listaCarritos.Count = 0 Then
                MessageBox.Show("No hay ningún artículo en el carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim formularioVenta As New RealVentavb()
            formularioVenta.ShowDialog()
            formularioVenta.TextBox3.Focus()

            Dim Importe As String = formularioVenta.TextoIngresado

            If String.IsNullOrEmpty(Importe) OrElse Importe = "0" Then
                MessageBox.Show("Transaccion cancelada")
                Return
            End If

            Dim TotalVenta As String = TextBox3.Text

            TotalVenta = TotalVenta.Replace("$", "")

            Dim valorDecimalTotal As Decimal
            Dim valorDecimalImporte As Decimal

            ' Intentar convertir los valores a decimales
            Dim conversionTotalExitosa As Boolean = Decimal.TryParse(TotalVenta, valorDecimalTotal)

            Dim conversionImporteExitosa As Boolean = Decimal.TryParse(Importe, valorDecimalImporte)

            If conversionTotalExitosa AndAlso conversionImporteExitosa Then
                If valorDecimalImporte < valorDecimalTotal Then
                    MessageBox.Show("El importe es menor que el Total.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    VENDER_Click_1(VENDER, EventArgs.Empty)
                    Return
                End If
            End If


            ' La conversión fue exitosa, ahora puedes realizar la inserción
            Dim queryInsertVenta As String = "INSERT INTO ing_cat_ventas (TotalVenta, Importe, Cambio, Estatus, created_at, updated_at) VALUES (@TotalVenta, @Importe, @Cambio, @Estatus, @CreatedAt1, @UpdatedAt1); SELECT LAST_INSERT_ID();"

            ' Iniciar una transacción
            Using conexion As MySqlConnection = New ConexionDB().AbrirConexion()
                Using transaccion As MySqlTransaction = conexion.BeginTransaction()
                    Try
                        Dim nuevoId As Integer
                        ' Ejecutar la inserción y obtener el ID generado
                        Using comandoInsertVenta As New MySqlCommand(queryInsertVenta, conexion, transaccion)
                            comandoInsertVenta.Parameters.AddWithValue("@TotalVenta", valorDecimalTotal)
                            comandoInsertVenta.Parameters.AddWithValue("@Importe", valorDecimalImporte)
                            comandoInsertVenta.Parameters.AddWithValue("@Cambio", valorDecimalImporte - valorDecimalTotal)
                            comandoInsertVenta.Parameters.AddWithValue("@Estatus", "REAL")
                            comandoInsertVenta.Parameters.AddWithValue("@CreatedAt1", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) ' Formato compatible con MySQL
                            comandoInsertVenta.Parameters.AddWithValue("@UpdatedAt1", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) ' Formato compatible con MySQL
                            nuevoId = Convert.ToInt32(comandoInsertVenta.ExecuteScalar())
                        End Using

                        Dim queryInsertDetalle As String = "INSERT INTO ing_cat_ventas_det (idcatarticulos, idcatventas, idunidadtipo, idcar,  concepto, code, cantidad, precio, created_at, updated_at) VALUES (@IdCatArticulos, @IdCatVentas, @IdUnidadTipo, @IdCar,   @Concepto, @Code, @Cantidad, @Precio, @CreatedAt, @UpdatedAt)"

                        For Each carrito As Carrrito In listaCarritos
                            Using comando As New MySqlCommand(queryInsertDetalle, conexion, transaccion)
                                comando.Parameters.AddWithValue("@IdCatArticulos", carrito.Id)
                                comando.Parameters.AddWithValue("@IdCatVentas", nuevoId) ' Se utiliza el nuevoId generado en la inserción de la venta
                                comando.Parameters.AddWithValue("@IdUnidadTipo", carrito.IdUnidadTipo)
                                comando.Parameters.AddWithValue("@IdCar", -1)
                                comando.Parameters.AddWithValue("@Concepto", carrito.Nombre & "/" & carrito.Descripcion)
                                comando.Parameters.AddWithValue("@Code", carrito.Code)
                                comando.Parameters.AddWithValue("@Cantidad", carrito.Cantidad)
                                comando.Parameters.AddWithValue("@Precio", carrito.Precio)
                                comando.Parameters.AddWithValue("@CreatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) ' Formato compatible con MySQL
                                comando.Parameters.AddWithValue("@UpdatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) ' Formato compatible con MySQL
                                comando.ExecuteNonQuery()
                            End Using

                            If carrito.IdUnidadTipo = 2 Then
                                ' Actualizamos el stock
                                Dim query As String = "UPDATE adq_cat_articulos SET peso = peso - @LnCantidad WHERE id = @IdArticulo"
                                Using Command As New MySqlCommand(query, conexion, transaccion)
                                    Command.Parameters.AddWithValue("@LnCantidad", carrito.Cantidad / 1000D)
                                    Command.Parameters.AddWithValue("@IdArticulo", carrito.Id)
                                    Dim nuevaCantidad As Decimal = Convert.ToDecimal(Command.ExecuteScalar())

                                End Using
                            Else
                                ' Actualizamos el stock
                                Dim query As String = "UPDATE adq_cat_articulos SET cantidad = cantidad - @LnCantidad WHERE id = @IdArticulo"
                                Using Command As New MySqlCommand(query, conexion, transaccion)
                                    Command.Parameters.AddWithValue("@LnCantidad", carrito.Cantidad)
                                    Command.Parameters.AddWithValue("@IdArticulo", carrito.Id)
                                    Dim nuevaCantidad As Decimal = Convert.ToDecimal(Command.ExecuteScalar())

                                End Using
                            End If

                        Next



                        ' Confirmar la transacción
                        transaccion.Commit()
                        Dim formularioCambio As New Cambio("$" & valorDecimalImporte - valorDecimalTotal)
                        ' Mostrar el formulario Cambio
                        formularioCambio.ShowDialog()
                        TextBox3.Text = "$0.00"
                        listaCarritos.Clear()
                        DataGridView1.Rows.Clear()
                    Catch ex As Exception
                        ' Revertir la transacción en caso de error
                        transaccion.Rollback()
                        Throw ' Lanzar la excepción para que sea manejada en el bloque Catch externo
                    End Try
                End Using
            End Using


        Catch ex As Exception
            ' Mostrar un mensaje de error si ocurre una excepción
            MessageBox.Show("Se produjo un error durante la inserción de datos. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Asegurándose de que el foco regrese a TextBox1 después de completar la transacción
        TextBox1.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub Inventario_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click



    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click

        ArticulosMain.TopLevel = False
        ArticulosMain.AutoScroll = True
        ArticulosMain.FormBorderStyle = FormBorderStyle.None
        ArticulosMain.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Add(ArticulosMain)
        Panel2.Hide()
        ArticulosMain.Show()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        ArticulosMain.Close()
        Dim Articulos As New Articulos()
        ArticulosMain = Articulos
        Panel2.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
