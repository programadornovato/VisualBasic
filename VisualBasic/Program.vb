Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Sub Main(args As String())
        REM Este es otro comentario
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.BackgroundColor = ConsoleColor.Blue
        Console.Clear()
        Console.WriteLine("Hola mundo!")
        'Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("Hola novato")
        Console.Read()
    End Sub
End Module
