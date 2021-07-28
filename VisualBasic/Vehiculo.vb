Public Class Vehiculo
    Private marca As String
    Private modelo As String
    Private sku As String
    Public Sub New(_marca As String, _modelo As String)
        marca = _marca
        modelo = _modelo
    End Sub
    Public Sub New(_sku As String)
        sku = _sku
    End Sub
    Public Sub acelera()
        If marca IsNot Nothing Then
            Console.WriteLine("El vehiculo " & marca & " " & modelo & " esta acelerando")
        Else
            Console.WriteLine("El vehiculo " & sku & " esta acelerando")
        End If

    End Sub
    Public Sub acelera(kmh As Integer)
        If marca IsNot Nothing Then
            Console.WriteLine("El vehiculo " & marca & " " & modelo & " esta acelerando a " & kmh & "km/h")
        Else
            Console.WriteLine("El vehiculo " & sku & " esta acelerando a " & kmh & "km/h")
        End If

    End Sub
End Class
