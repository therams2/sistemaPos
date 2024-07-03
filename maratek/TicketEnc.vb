Public Class TicketsEnc
    Public Property Id As Integer
    Public Property TotalVenta As Decimal
    Public Property Importe As Decimal
    Public Property Cambio As Decimal
    Public Property Estatus As String
    Public Property CreatedAt As DateTime
    Public Property Hora As String

    ' Constructor vacío
    Public Sub New()
    End Sub

    ' Constructor con parámetros
    Public Sub New(ByVal id As Integer, ByVal totalVenta As Decimal, ByVal importe As Decimal, ByVal cambio As Decimal, ByVal estatus As String, ByVal createdAt As DateTime, ByVal hora As String)
        Me.Id = id
        Me.TotalVenta = totalVenta
        Me.Importe = importe
        Me.Cambio = cambio
        Me.Estatus = estatus
        Me.CreatedAt = createdAt
        Me.Hora = hora
    End Sub

End Class
