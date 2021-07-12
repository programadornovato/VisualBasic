Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        'Dim i = 11
        'Do
        '    Console.WriteLine("i=" & i)
        '    i = i + 1
        'Loop While i <= 10

        'Dim i = -10
        'Do
        '    Console.WriteLine("i=" & i)
        '    i = i - 1
        'Loop While i >= 1

        Dim rand = New Random()
        Dim aleatorio = rand.Next(1, 7)
        Console.WriteLine("aleatorio=" & aleatorio)
        Dim i = 10
        Do
            Console.WriteLine("i=" & i)
            i = i + 1
        Loop While i <= aleatorio
        Console.Read()
    End Sub
End Module
