Public Class Cuadrilatero
    Private lado1 As Double
    Private lado2 As Double
    Public Sub New(_lado1 As Double)
        lado1 = _lado1
        lado2 = _lado1
    End Sub
    Public Sub New(_lado1 As Double, _lado2 As Double)
        lado1 = _lado1
        lado2 = _lado2
    End Sub
    Public Function perimetro()
        Return (lado1 + lado2) * 2
    End Function
    Public Function area()
        Return lado1 * lado2
    End Function
End Class
