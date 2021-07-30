Public Class Alumnos
    Private nombre As String
    Private aula As Char
    Private calificacion As Double
    Public Sub New(_nombre As String, _aula As Char, _calificacion As Double)
        nombre = _nombre
        aula = _aula
        If _calificacion > 10 Then
            calificacion = 10
        ElseIf _calificacion < 0 Then
            calificacion = 0
        Else
            calificacion = _calificacion
        End If
    End Sub
    Function getNombre()
        Return nombre
    End Function
    Function getCalificacion()
        Return calificacion
    End Function
    Function getAula()
        Return aula
    End Function
End Class
