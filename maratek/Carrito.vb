Public Class Carrrito
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property Precio As Decimal
    Public Property Code As String
    Public Property Cantidad As Decimal
    Public Property Peso As Decimal
    Public Property IdUnidadTipo As Integer
    Public Property PrecioKilo As Decimal?
    Public Property IdUnidadMedida As Integer
    Public Property ClaveCategoria As Integer
    Public Property IdCategoria As Integer

    ' Constructor que inicializa las propiedades del artículo
    Public Sub New(ByVal id As Integer, ByVal nombre As String, ByVal descripcion As String, ByVal precio As Decimal, ByVal code As String, ByVal Peso As Decimal, ByVal cantidad As Decimal, ByVal idUnidadTipo As Integer, ByVal precioKilo As Decimal, ByVal idUnidadMedida As Integer, ByVal claveCategoria As Integer, ByVal idCategoria As Integer)
        Me.Id = id
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Precio = precio
        Me.Code = code
        Me.Cantidad = cantidad
        Me.Peso = Peso
        Me.IdUnidadTipo = idUnidadTipo
        Me.PrecioKilo = precioKilo
        Me.IdUnidadMedida = idUnidadMedida
        Me.ClaveCategoria = claveCategoria
        Me.IdCategoria = idCategoria
    End Sub

    Public Sub New()
    End Sub
End Class