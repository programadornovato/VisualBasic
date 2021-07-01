Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        saluda()
        Dim nombre = "Juan", apellido = "Peres"
        Dim nombreCompleto = nombre + " " + apellido
        Console.WriteLine(nombreCompleto)
        apellido = "Perez"
        nombreCompleto = nombre + " " + apellido
        Console.WriteLine(nombreCompleto)
        Console.Read()
    End Sub
    Sub saluda()
        Console.WriteLine("Hola humano")
    End Sub
End Module
