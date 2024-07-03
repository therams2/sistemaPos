Imports MySql.Data.MySqlClient


Public Class Articulos
    Private numeroPagina As Integer = 1 ' Estado de la página actual
    Private idSelected As Integer = 0 ' Estado de la página actual
    Private isEdit As Integer = 0 ' Estado de la página actual
    Private pageSize As Integer = 23 ' Tamaño de la página
    Dim listaCarritos As New List(Of Carrrito)()

    Private Sub TabPage2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCarritos.CellContentClick

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint




    End Sub
    Private Sub Articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
        Dim items As New List(Of KeyValuePair(Of Integer, String))()
        items.Add(New KeyValuePair(Of Integer, String)(1, "PIEZA"))
        items.Add(New KeyValuePair(Of Integer, String)(2, "PESO"))
        items.Add(New KeyValuePair(Of Integer, String)(3, "CAJA"))
        items.Add(New KeyValuePair(Of Integer, String)(4, "PAQUETE"))

        ComboBox2.DataSource = New BindingSource(items, Nothing)
        ComboBox2.DisplayMember = "Value"
        ComboBox2.ValueMember = "Key"

        Dim items1 As New List(Of KeyValuePair(Of Integer, String))()
        items1.Add(New KeyValuePair(Of Integer, String)(1, "KG"))
        items1.Add(New KeyValuePair(Of Integer, String)(2, "GR"))

        ComboBox3.DataSource = New BindingSource(items1, Nothing)
        ComboBox3.DisplayMember = "Value"
        ComboBox3.ValueMember = "Key"


        Dim items2 As New List(Of KeyValuePair(Of Integer, String))()
        items2.Add(New KeyValuePair(Of Integer, String)(20, "ABARROTES"))
        items2.Add(New KeyValuePair(Of Integer, String)(21, "LACTEOS"))
        items2.Add(New KeyValuePair(Of Integer, String)(22, "DULCES"))
        items2.Add(New KeyValuePair(Of Integer, String)(23, "REFRESCOS Y BEBIDAS"))
        items2.Add(New KeyValuePair(Of Integer, String)(24, "BEBIDAS ALCOHOLICAS"))
        items2.Add(New KeyValuePair(Of Integer, String)(25, "FRUTAS, VERDURAS Y LEGUMBRES"))
        items2.Add(New KeyValuePair(Of Integer, String)(26, "PLASTICOS"))
        items2.Add(New KeyValuePair(Of Integer, String)(27, "LIMPIEZA"))
        items2.Add(New KeyValuePair(Of Integer, String)(28, "ARTICULOS PERSONALES"))
        items2.Add(New KeyValuePair(Of Integer, String)(29, "MEDICAMENTOS"))
        items2.Add(New KeyValuePair(Of Integer, String)(30, "CARNES FRIAS"))
        items2.Add(New KeyValuePair(Of Integer, String)(31, "SABRITAS Y CHURROS"))
        items2.Add(New KeyValuePair(Of Integer, String)(32, "PAN, GALLETAS Y PANQUESITOS"))

        ComboBox1.DataSource = New BindingSource(items2, Nothing)
        ComboBox1.DisplayMember = "Value"
        ComboBox1.ValueMember = "Key"

    End Sub

    Private Sub CargarDatos()
        ' Calcular el índice de inicio según la página actual
        Dim startIndex As Integer = (numeroPagina - 1) * pageSize
        ' Construir la consulta SQL con paginación
        Dim query As String = "SELECT id, nombre, descripcion, cantidad, id_unidad_tipo AS idunidadtipo, precio, code, peso, costo_ini, id_unidad_medida, precio_kilo FROM adq_cat_articulos ORDER BY id DESC LIMIT " & pageSize & " OFFSET " & startIndex

        ' Limpiar la lista de carritos antes de cargar nuevos datos
        listaCarritos.Clear()

        Using conexion As MySqlConnection = New ConexionDB().AbrirConexion()
            Using comando As New MySqlCommand(query, conexion)
                Using reader As MySqlDataReader = comando.ExecuteReader()
                    While reader.Read()
                        Dim carrito As New Carrrito() With {
                            .Id = Convert.ToInt32(reader("id")),
                            .Nombre = reader("nombre").ToString().ToUpper(),
                            .Descripcion = If(Not IsDBNull(reader("descripcion")), reader("descripcion").ToString().ToUpper(), ""),
                            .Precio = Convert.ToDecimal(reader("precio")),
                            .Code = reader("code").ToString(),
                            .Cantidad = If(Not IsDBNull(reader("cantidad")), Convert.ToDecimal(reader("cantidad")), 0),
                            .IdUnidadTipo = Convert.ToInt32(reader("idunidadtipo")),
                            .Peso = If(Not IsDBNull(reader("Peso")), Convert.ToDecimal(reader("Peso")), 0),
                            .PrecioKilo = If(Not IsDBNull(reader("precio_kilo")), Convert.ToDecimal(reader("precio_kilo")), 0),
                            .IdUnidadMedida = If(Not IsDBNull(reader("id_unidad_medida")), Convert.ToInt32(reader("id_unidad_medida")), 0)
                        }
                        listaCarritos.Add(carrito)
                    End While
                End Using
            End Using
        End Using

        ' Limpia cualquier dato existente en el DataGridView
        dgvCarritos.Rows.Clear()

        ' Inserta cada carrito en el DataGridView
        For Each carrito As Carrrito In listaCarritos
            dgvCarritos.Rows.Add(carrito.Id, carrito.Code, carrito.Nombre, carrito.Descripcion, carrito.Cantidad, carrito.Precio, carrito.Peso)

        Next
        ' Actualizar la interfaz de usuario con los nuevos datos cargados
        ActualizarInterfazUsuario()
    End Sub

    Private Sub ActualizarInterfazUsuario()
        ' Aquí puedes actualizar la interfaz de usuario según los datos cargados, por ejemplo:
        ' - Mostrar los datos en un DataGridView
        ' - Actualizar etiquetas, controles de paginación, etc.
    End Sub
    Private Sub btnPaginaAnterior1_Click(sender As Object, e As EventArgs) Handles btnPaginaAnterior1.Click
        If numeroPagina > 1 Then
            ' Ir a la página anterior si no estamos en la primera página
            numeroPagina -= 1
            CargarDatos()
        End If
    End Sub

    Private Sub btnPaginaSiguiente1_Click(sender As Object, e As EventArgs) Handles btnPaginaSiguiente1.Click
        ' Incrementar la página actual y cargar los datos de la siguiente página
        numeroPagina += 1
        CargarDatos()
    End Sub
    Private Sub dgvCarritos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCarritos.CellFormatting
        ' Verificar si la celda actual pertenece a la columna de precio
        If e.ColumnIndex = dgvCarritos.Columns("Precio").Index AndAlso e.RowIndex >= 0 Then
            ' Verificar si el valor de la celda es numérico
            Dim precio As Decimal
            If Decimal.TryParse(e.Value.ToString(), precio) Then
                ' Formatear el valor numérico con dos dígitos decimales y punto decimal
                e.Value = precio.ToString("N2")
                ' Indicar que el formato ha sido aplicado para evitar la conversión automática del DataGridView
                e.FormattingApplied = True
            End If
        End If

    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        If dgvCarritos.SelectedRows.Count > 0 Then
            Button1.Text = "GUARDAR"
            Label12.Text = "EDITAR"
            isEdit = 1
            Dim cell As DataGridViewCell = dgvCarritos.SelectedRows(0).Cells("ID")


            If cell IsNot Nothing AndAlso cell.Value IsNot Nothing Then

                Dim id As Integer = Convert.ToInt32(cell.Value)
                Dim query As String = "SELECT a.id, a.nombre, a.descripcion, a.cantidad, a.id_unidad_tipo AS idunidadtipo, a.precio, a.code, a.peso, a.costo_ini, a.id_unidad_medida, a.id_categoria,a.precio_kilo, c.clave AS clave_categoria " &
                      "FROM adq_cat_articulos a " &
                      "INNER JOIN adq_cat_categorias c ON a.id_categoria = c.id " &
                      "WHERE a.id = @idBuscado"
                ' Limpiar la lista de carritos antes de cargar nuevos datos
                listaCarritos.Clear()

                Using conexion As MySqlConnection = New ConexionDB().AbrirConexion()
                    Using comando As New MySqlCommand(query, conexion)
                        comando.Parameters.AddWithValue("@idBuscado", id) ' Agrega el parámetro para el ID buscado
                        Using reader As MySqlDataReader = comando.ExecuteReader()
                            While reader.Read()
                                Dim carrito As New Carrrito() With {
                               .Id = Convert.ToInt32(reader("id")),
                                    .Nombre = reader("nombre").ToString().ToUpper(),
                                    .Descripcion = If(Not IsDBNull(reader("descripcion")), reader("descripcion").ToString().ToUpper(), ""),
                                    .Precio = If(Not IsDBNull(reader("precio")), Convert.ToDecimal(reader("precio")), 0),
                                    .Peso = If(Not IsDBNull(reader("peso")), Convert.ToDecimal(reader("peso")), 0),
                                    .Code = reader("code").ToString(),
                                    .Cantidad = If(Not IsDBNull(reader("cantidad")), Convert.ToDecimal(reader("cantidad")), 0),
                                    .IdUnidadTipo = If(Not IsDBNull(reader("idunidadtipo")), Convert.ToInt32(reader("idunidadtipo")), 0),
                                    .PrecioKilo = If(Not IsDBNull(reader("precio_kilo")), Convert.ToDecimal(reader("precio_kilo")), 0),
                                    .IdUnidadMedida = If(Not IsDBNull(reader("id_unidad_medida")), Convert.ToInt32(reader("id_unidad_medida")), 0),
                                    .ClaveCategoria = If(Not IsDBNull(reader("clave_categoria")), Convert.ToInt32(reader("clave_categoria")), 0),
                                    .IdCategoria = If(Not IsDBNull(reader("id_categoria")), Convert.ToInt32(reader("id_categoria")), 0)
                                }

                                LimpiarYHabilitarElementos()
                                If carrito.IdUnidadTipo = 2 Then
                                    Panel1.Visible = True
                                Else
                                    Panel1.Hide()
                                End If
                                idSelected = carrito.Id
                                TextBox1.Text = carrito.Code
                                TextBox2.Text = carrito.Nombre
                                TextBox3.Text = carrito.Descripcion
                                TextBox4.Text = carrito.Cantidad
                                TextBox5.Text = carrito.Peso
                                TextBox6.Text = carrito.Precio
                                TextBox7.Text = carrito.PrecioKilo
                                ComboBox2.SelectedIndex = carrito.IdUnidadTipo - 1
                                ComboBox1.SelectedIndex = carrito.ClaveCategoria - 1
                                ComboBox3.SelectedIndex = carrito.IdUnidadMedida - 1

                            End While
                        End Using
                    End Using
                End Using
            End If
        Else
            MessageBox.Show("Selecciona una fila de la lista")
        End If

    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ' Verificar si el índice seleccionado es igual a 2
        If ComboBox2.SelectedIndex = 1 Then
            Panel1.Visible = True
            TextBox6.Enabled = False
            TextBox4.Enabled = False
            TextBox6.Text = ""
            TextBox4.Text = ""
        Else
            Panel1.Hide()
            TextBox6.Enabled = True
            TextBox4.Enabled = True
        End If
    End Sub
    Private Function validarCampos() As Boolean
        Dim camposVacios As Boolean = False ' Variable para verificar si hay campos vacíos


        If String.IsNullOrEmpty(TextBox2.Text) Then
            camposVacios = True ' Indica que hay al menos un campo vacío
        End If

        If String.IsNullOrEmpty(TextBox3.Text) Then
            camposVacios = True ' Indica que hay al menos un campo vacío
        End If

        If String.IsNullOrEmpty(TextBox4.Text) Then
            camposVacios = True ' Indica que hay al menos un campo vacío
        End If

        If String.IsNullOrEmpty(TextBox6.Text) Then
            camposVacios = True ' Indica que hay al menos un campo vacío
        End If


        If ComboBox2.SelectedIndex < 0 Then
            camposVacios = True ' Indica que hay al menos un campo vacío
        End If

        If ComboBox1.SelectedIndex < 0 Then
            camposVacios = True ' Indica que hay al menos un campo vacío
        End If


        ' Verifica si se encontraron campos vacíos y muestra un mensaje de advertencia

        Return camposVacios

    End Function
    Private Function validarCamposPeso() As Boolean
        Dim camposVacios As Boolean = False ' Variable para verificar si hay campos vacíos



        If String.IsNullOrEmpty(TextBox3.Text) Then
            camposVacios = True ' Indica que hay al menos un campo vacío
        End If



        If String.IsNullOrEmpty(TextBox5.Text) Then
            camposVacios = True ' Indica que hay al menos un campo vacío
        End If

        If String.IsNullOrEmpty(TextBox7.Text) Then
            camposVacios = True ' Indica que hay al menos un campo vacío
        End If

        If ComboBox2.SelectedIndex < 0 Then
            camposVacios = True ' Indica que hay al menos un campo vacío
        End If

        If ComboBox1.SelectedIndex < 0 Then
            camposVacios = True ' Indica que hay al menos un campo vacío
        End If

        If ComboBox3.SelectedIndex < 0 Then
            camposVacios = True ' Indica que hay al menos un campo vacío
        End If

        ' Verifica si se encontraron campos vacíos y muestra un mensaje de advertencia

        Return camposVacios

    End Function
    Private Sub LimpiarYHabilitarElementos()
        CheckBox1.Enabled = True
        TextBox1.Text = "" ' Limpia el texto del TextBox1
        TextBox1.Enabled = True ' Habilita el TextBox1

        TextBox2.Text = "" ' Limpia el texto del TextBox2
        TextBox2.Enabled = True ' Habilita el TextBox2

        TextBox3.Text = "" ' Limpia el texto del TextBox3
        TextBox3.Enabled = True ' Habilita el TextBox3

        TextBox4.Text = "" ' Limpia el texto del TextBox4
        TextBox4.Enabled = True ' Habilita el TextBox4

        TextBox5.Text = "" ' Limpia el texto del TextBox5
        TextBox5.Enabled = True ' Habilita el TextBox5

        TextBox6.Text = "" ' Limpia el texto del TextBox6
        TextBox6.Enabled = True ' Habilita el TextBox6

        TextBox7.Text = "" ' Limpia el texto del TextBox7
        TextBox7.Enabled = True ' Habilita el TextBox7

        CheckBox1.Checked = False ' Desmarca el CheckBox1
        CheckBox1.Enabled = True ' Habilita el CheckBox1

        ComboBox1.SelectedIndex = -1 ' Restablece la selección del ComboBox1
        ComboBox1.Enabled = True ' Habilita el ComboBox1

        ComboBox2.SelectedIndex = -1 ' Restablece la selección del ComboBox2
        ComboBox2.Enabled = True ' Habilita el ComboBox2

        ComboBox3.SelectedIndex = -1 ' Restablece la selección del ComboBox3
        ComboBox3.Enabled = True ' Habilita el ComboBox3

        Button1.Enabled = True ' Habilita el Button1
    End Sub
    Private Sub LimpiarYDeshabilitarElementos()
        CheckBox1.Enabled = False
        TextBox1.Text = "" ' Limpia el texto del TextBox1
        TextBox1.Enabled = False ' Habilita el TextBox1

        TextBox2.Text = "" ' Limpia el texto del TextBox2
        TextBox2.Enabled = False ' Habilita el TextBox2

        TextBox3.Text = "" ' Limpia el texto del TextBox3
        TextBox3.Enabled = False ' Habilita el TextBox3 
        TextBox4.Text = "" ' Limpia el texto del TextBox4
        TextBox4.Enabled = False ' Habilita el TextBox4

        TextBox5.Text = "" ' Limpia el texto del TextBox5
        TextBox5.Enabled = False ' Habilita el TextBox5

        TextBox6.Text = "" ' Limpia el texto del TextBox6
        TextBox6.Enabled = False ' Habilita el TextBox6

        TextBox7.Text = "" ' Limpia el texto del TextBox7
        TextBox7.Enabled = False ' Habilita el TextBox7

        CheckBox1.Checked = False ' Desmarca el CheckBox1
        CheckBox1.Enabled = False ' Habilita el CheckBox1

        ComboBox1.SelectedIndex = -1 ' Restablece la selección del ComboBox1
        ComboBox1.Enabled = False ' Habilita el ComboBox1

        ComboBox2.SelectedIndex = -1 ' Restablece la selección del ComboBox2
        ComboBox2.Enabled = False ' Habilita el ComboBox2

        ComboBox3.SelectedIndex = -1 ' Restablece la selección del ComboBox3
        ComboBox3.Enabled = False ' Habilita el ComboBox3

        Button1.Enabled = False ' Habilita el Button1
    End Sub
    Private Sub LimpiarElementos()
        TextBox1.Text = "" ' Limpia el texto del TextBox1
        TextBox2.Text = "" ' Limpia el texto del TextBox2
        TextBox3.Text = "" ' Limpia el texto del TextBox3
        TextBox4.Text = "" ' Limpia el texto del TextBox4
        TextBox5.Text = "" ' Limpia el texto del TextBox5
        TextBox6.Text = "" ' Limpia el texto del TextBox6
        TextBox7.Text = "" ' Limpia el texto del TextBox7
        ComboBox1.SelectedIndex = -1 ' Restablece la selección del ComboBox1
        ComboBox2.SelectedIndex = -1 ' Restablece la selección del ComboBox2
        ComboBox3.SelectedIndex = -1 ' Restablece la selección del ComboBox3
    End Sub
    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Button1.Text = "AÑADIR"
        Label12.Text = "NUEVO"
        isEdit = 0
        LimpiarYHabilitarElementos()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim indiceS As Int32 = 0
        Dim claveCat As String = ""
        If CheckBox1.Checked Then
            Dim queryC As String = "SELECT clave FROM adq_cat_categorias WHERE id = @id"
            Dim clave As Int32 = 0
            Using conexion As MySqlConnection = New ConexionDB().AbrirConexion()
                Using comando2 As New MySqlCommand(queryC, conexion)
                    comando2.Parameters.AddWithValue("@id", DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of Integer, String)).Key)

                    Using reader As MySqlDataReader = comando2.ExecuteReader()
                        If reader.Read() Then
                            clave = Convert.ToInt32(reader("clave"))
                        Else
                            MessageBox.Show("No se encontró ninguna fila con el ID proporcionado.")
                            Return ' Salir del método si no se encuentra ninguna fila
                        End If
                    End Using
                    claveCat = clave.ToString().PadLeft(3, "0"c)
                    Dim index As String = "INDEX" & clave
                    Dim queryCC As String = "SELECT " & index & " FROM adq_indices_categorias"
                    Using comando3 As New MySqlCommand(queryCC, conexion)
                        Using reader1 As MySqlDataReader = comando3.ExecuteReader()
                            If reader1.Read() Then
                                indiceS = Convert.ToInt32(reader1(index)) + 1
                                conexion.Close()
                                Using conexion2 As MySqlConnection = New ConexionDB().AbrirConexion()
                                    Dim query4 As String = "UPDATE adq_indices_categorias SET " & index & " = @indiceS"
                                    Using comando4 As New MySqlCommand(query4, conexion2)
                                        comando4.Parameters.AddWithValue("@indiceS", indiceS)
                                        comando4.ExecuteNonQuery()
                                        conexion2.Close()
                                    End Using
                                End Using
                            End If
                        End Using
                    End Using
                End Using
            End Using
        Else
            indiceS = 0
        End If
        If (isEdit = 1) Then
            Dim query As String
            'Validamos si es por peso

            query = "UPDATE adq_cat_articulos SET nombre = @nombre, descripcion = @descripcion, precio = @precio, peso = @peso, code = @code, cantidad = @cantidad, id_unidad_tipo = @idunidadtipo, precio_kilo = @precio_kilo, id_unidad_medida = @id_unidad_medida, id_categoria = @clave_categoria WHERE id = @id"

            Using conexion As MySqlConnection = New ConexionDB().AbrirConexion()
                If (ComboBox2.SelectedIndex + 1 = 2) Then
                    If (validarCamposPeso() = False) Then
                        Using comando As New MySqlCommand(query, conexion)
                            comando.Parameters.AddWithValue("@nombre", TextBox2.Text.ToUpper())
                            comando.Parameters.AddWithValue("@descripcion", TextBox3.Text.ToUpper())
                            comando.Parameters.AddWithValue("@precio", 0)
                            comando.Parameters.AddWithValue("@peso", Convert.ToDecimal(TextBox5.Text))
                            If indiceS > 0 Then
                                comando.Parameters.AddWithValue("@code", claveCat + "" + indiceS.ToString().PadLeft(3, "0"c))
                            Else
                                comando.Parameters.AddWithValue("@code", TextBox1.Text)
                            End If
                            comando.Parameters.AddWithValue("@cantidad", 0)
                            comando.Parameters.AddWithValue("@idunidadtipo", 2)
                            comando.Parameters.AddWithValue("@precio_kilo", Convert.ToDecimal(TextBox7.Text))
                            comando.Parameters.AddWithValue("@id_unidad_medida", ComboBox3.SelectedIndex + 1)
                            comando.Parameters.AddWithValue("@clave_categoria", DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of Integer, String)).Key)
                            comando.Parameters.AddWithValue("@id", idSelected)

                            Dim rowsAffected As Integer = comando.ExecuteNonQuery()
                            conexion.Close()

                            If rowsAffected > 0 Then
                                MessageBox.Show("Articulo actualizado correctamente")
                                LimpiarYDeshabilitarElementos()
                                CargarDatos()
                                Label12.Text = "EDICIÓN"
                            Else
                                MessageBox.Show("Error al actualizar el articulo")
                            End If


                        End Using
                    Else
                        MessageBox.Show("Debes de llenar todos los campos")
                        conexion.Close()
                    End If
                Else
                    If (validarCampos() = False) Then

                        Using comando As New MySqlCommand(query, conexion)
                            comando.Parameters.AddWithValue("@nombre", TextBox2.Text.ToUpper())
                            comando.Parameters.AddWithValue("@descripcion", TextBox3.Text.ToUpper())
                            comando.Parameters.AddWithValue("@precio", Convert.ToDecimal(TextBox6.Text))
                            comando.Parameters.AddWithValue("@peso", DBNull.Value)
                            If indiceS > 0 Then
                                comando.Parameters.AddWithValue("@code", claveCat + "" + indiceS.ToString().PadLeft(3, "0"c))
                            Else
                                comando.Parameters.AddWithValue("@code", TextBox1.Text)
                            End If
                            comando.Parameters.AddWithValue("@cantidad", Convert.ToDecimal(TextBox4.Text))
                            comando.Parameters.AddWithValue("@idunidadtipo", ComboBox2.SelectedIndex + 1)
                            comando.Parameters.AddWithValue("@precio_kilo", DBNull.Value)
                            comando.Parameters.AddWithValue("@id_unidad_medida", DBNull.Value)
                            comando.Parameters.AddWithValue("@clave_categoria", DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of Integer, String)).Key)
                            comando.Parameters.AddWithValue("@id", idSelected)
                            Dim rowsAffected As Integer = comando.ExecuteNonQuery()
                            conexion.Close()

                            If rowsAffected > 0 Then
                                MessageBox.Show("Articulo actualizado correctamente")
                                LimpiarYDeshabilitarElementos()
                                CargarDatos()
                                Label12.Text = "EDICIÓN"
                            Else
                                MessageBox.Show("Error al actualizar el articulo")
                            End If
                        End Using
                    Else
                        MessageBox.Show("Debes de llenar todos los campos")
                        conexion.Close()
                    End If

                End If
            End Using

        Else


            Dim query As String = "INSERT INTO adq_cat_articulos (nombre, descripcion, precio, peso, code, cantidad, id_unidad_tipo, precio_kilo, id_unidad_medida, id_categoria) VALUES (@nombre, @descripcion, @precio, @peso, @code, @cantidad, @idunidadtipo, @precio_kilo, @id_unidad_medida, @clave_categoria)"

            Using conexion As MySqlConnection = New ConexionDB().AbrirConexion()
                If (ComboBox2.SelectedIndex + 1 = 2) Then
                    If (validarCamposPeso() = False) Then
                        Using comando As New MySqlCommand(query, conexion)
                            comando.Parameters.AddWithValue("@nombre", TextBox2.Text.ToUpper())
                            comando.Parameters.AddWithValue("@descripcion", TextBox3.Text.ToUpper())
                            comando.Parameters.AddWithValue("@precio", 0)
                            comando.Parameters.AddWithValue("@peso", Convert.ToDecimal(TextBox5.Text))
                            If indiceS > 0 Then
                                comando.Parameters.AddWithValue("@code", claveCat + "" + indiceS.ToString().PadLeft(3, "0"c))
                            Else
                                comando.Parameters.AddWithValue("@code", TextBox1.Text)
                            End If
                            comando.Parameters.AddWithValue("@cantidad", 0)
                            comando.Parameters.AddWithValue("@idunidadtipo", 2)
                            comando.Parameters.AddWithValue("@precio_kilo", Convert.ToDecimal(TextBox7.Text))
                            comando.Parameters.AddWithValue("@id_unidad_medida", ComboBox3.SelectedIndex + 1)
                            comando.Parameters.AddWithValue("@clave_categoria", DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of Integer, String)).Key)

                            Dim rowsAffected As Integer = comando.ExecuteNonQuery()
                            conexion.Close()

                            If rowsAffected > 0 Then
                                MessageBox.Show("Articulo creado correctamente")
                                LimpiarElementos()
                                CargarDatos()
                                Label12.Text = "NUEVO"
                            Else
                                MessageBox.Show("Error al crear nuevo articulo")
                            End If
                        End Using
                    Else
                        MessageBox.Show("Debes de llenar todos los campos")
                        conexion.Close()
                    End If
                Else
                    If (validarCampos() = False) Then
                        Using comando As New MySqlCommand(query, conexion)
                            comando.Parameters.AddWithValue("@nombre", TextBox2.Text.ToUpper())
                            comando.Parameters.AddWithValue("@descripcion", TextBox3.Text.ToUpper())
                            comando.Parameters.AddWithValue("@precio", Convert.ToDecimal(TextBox6.Text))
                            comando.Parameters.AddWithValue("@peso", DBNull.Value)
                            If indiceS > 0 Then
                                comando.Parameters.AddWithValue("@code", claveCat + "" + indiceS.ToString().PadLeft(3, "0"c))
                            Else
                                comando.Parameters.AddWithValue("@code", TextBox1.Text)
                            End If
                            comando.Parameters.AddWithValue("@cantidad", Convert.ToDecimal(TextBox4.Text))
                            comando.Parameters.AddWithValue("@idunidadtipo", ComboBox2.SelectedIndex + 1)
                            comando.Parameters.AddWithValue("@precio_kilo", DBNull.Value)
                            comando.Parameters.AddWithValue("@id_unidad_medida", DBNull.Value)
                            comando.Parameters.AddWithValue("@clave_categoria", DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of Integer, String)).Key)
                            Dim rowsAffected As Integer = comando.ExecuteNonQuery()
                            conexion.Close()
                            If rowsAffected > 0 Then
                                MessageBox.Show("Articulo creado correctamente")
                                LimpiarElementos()
                                CargarDatos()
                                Label12.Text = "NUEVO"
                            Else
                                MessageBox.Show("Error al crear nuevo articulo")
                            End If
                        End Using
                    Else
                        MessageBox.Show("Debes de llenar todos los campos")
                        conexion.Close()
                    End If
                End If

            End Using
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ' El CheckBox1 está marcado 
            TextBox1.Enabled = False
        Else
            ' El CheckBox1 no está marcado 
            TextBox1.Enabled = True
        End If
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If dgvCarritos.SelectedRows.Count > 0 Then

            Dim cell As DataGridViewCell = dgvCarritos.SelectedRows(0).Cells("ID")


            If cell IsNot Nothing AndAlso cell.Value IsNot Nothing Then

                Dim id As Integer = Convert.ToInt32(cell.Value)
                Dim queryDelete As String = "DELETE FROM adq_cat_articulos WHERE id = @id"

                Using conexion As MySqlConnection = New ConexionDB().AbrirConexion()
                    Using comandoDelete As New MySqlCommand(queryDelete, conexion)
                        comandoDelete.Parameters.AddWithValue("@id", id)
                        Dim rowsAffected As Integer = comandoDelete.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Articulo borrado correctamente")
                            LimpiarElementos()
                            CargarDatos()
                            Label12.Text = "NUEVO"
                        Else
                            MessageBox.Show("No se encontró ningún artículo con el ID " & id.ToString() & ".")
                        End If
                    End Using
                End Using
            End If
        Else
            MessageBox.Show("Selecciona una fila de la lista")
        End If
    End Sub
End Class