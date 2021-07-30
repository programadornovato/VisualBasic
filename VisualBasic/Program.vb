Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim p = New Personas("Juan", "Perez", 30)
        Console.WriteLine("Nombre=" & p.getNombre & " Apellido=" & p.getApellido & " Edad=" & p.getEdad)
        Dim e = New Estudiantes("Pepe", "Perez", 20, "PPP333", 9.5, "A")
        Console.WriteLine("Nombre=" & e.getNombre & " Apellido=" & e.getApellido & " Edad=" & e.getEdad & " Codigo estudiante=" & e.getCodigoEstudiante & " Calificacion=" & e.getCalificacion & " Salon=" & e.getSalon)
        Console.Read()
    End Sub
End Module
