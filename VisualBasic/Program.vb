Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        saluda()
        despide("Adios novato")
        Console.Read()
    End Sub
    Private Sub saluda()
        Console.WriteLine("Hola humano como estas?")
    End Sub
    Sub despide(ByVal texto)
        Console.WriteLine(texto)
    End Sub
End Module
