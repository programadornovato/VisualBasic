Public Class Personas
    Private nombre As String
    Private apellido As String
    Private edad As Integer
    Public Sub New(_nombre As String, _apellido As String, _edad As Integer)
        nombre = _nombre
        apellido = _apellido
        edad = _edad
    End Sub
    Public Function getNombre()
        Return nombre
    End Function
    Public Function getApellido()
        Return apellido
    End Function
    Public Function getEdad()
        Return edad
    End Function
End Class
