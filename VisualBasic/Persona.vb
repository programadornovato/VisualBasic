Public Class Persona
    Dim nombre As String
    Dim edad As Integer
    Sub New(_nombre As String, _edad As Integer)
        If _nombre <> "" Then
            nombre = _nombre
        End If
        If _edad > 0 Then
            edad = _edad
        End If
    End Sub
    'Sub inicializar(_nombre As String, _edad As Integer)
    '    If _nombre <> "" Then
    '        nombre = _nombre
    '    End If
    '    If _edad > 0 Then
    '        edad = _edad
    '    End If
    'End Sub
    Sub mostrar()
        Console.WriteLine("Nombre=" & nombre & " Edad=" & edad)
    End Sub
End Class
