Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Console.WriteLine("Humano que altura va atener tu escalera")
        Dim altura = Integer.Parse(Console.ReadLine)
        For i = 1 To altura
            For j = 1 To i
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
        Console.Read()
    End Sub
End Module
