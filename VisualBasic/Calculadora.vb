Public Class Calculadora
    Public Function suma(num1 As Integer, num2 As Integer) As Integer
        Dim res = 0
        If num1 > 0 And num2 > 0 Then
            res = num1 + num2
        Else
            res = 0
        End If
        Return res
    End Function
    Public Function resta(num1 As Integer, num2 As Integer) As Integer
        Dim res = 0
        If num1 > 0 And num2 > 0 Then
            res = num1 - num2
        Else
            res = 0
        End If
        Return res
    End Function
    Public Function multiplicar(num1 As Integer, num2 As Integer) As Integer
        Dim res = 0
        If num1 > 0 And num2 > 0 Then
            res = num1 * num2
        Else
            res = 0
        End If
        Return res
    End Function
    Public Function divicion(num1 As Integer, num2 As Integer) As Double
        Dim res = 0.0
        If num1 > 0 And num2 > 0 Then
            res = num1 / num2
        Else
            res = 0
        End If
        Return res
    End Function
End Class
