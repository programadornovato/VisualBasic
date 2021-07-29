Public Class Empleado
    Private edad As Integer
    Private nombre As String
    Public Sub setEdad(_edad As Integer)
        If _edad > 0 Then
            edad = _edad
        Else
            edad = 1
        End If

    End Sub
    Public Function getEdad()
        Return edad + 1
    End Function
    Public Sub setNombre(_nombre As String)
        If _nombre = "" Then
            nombre = "El nombre no puede estar vacio"
        Else
            nombre = _nombre
        End If
    End Sub
    Public Function getNombre()
        Return nombre.ToUpper
    End Function
End Class
