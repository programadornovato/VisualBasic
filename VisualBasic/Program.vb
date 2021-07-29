Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim e1 = New Empleado()
        e1.setEdad(40)
        e1.setNombre("Juan")
        Console.WriteLine("Nombre=" & e1.getNombre & " Edad=" & e1.getEdad)
        Console.Read()
    End Sub
End Module
