Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())

        'Dim i = 1
        'While i <= 10
        '    Console.WriteLine("i=" & i)
        '    i = i + 1
        'End While
        'Dim i = 10
        'While i >= 1
        '    Console.WriteLine("i=" & i)
        '    i = i - 1
        'End While
        Console.WriteLine("Humano por favor ingresa un numero de veces a repetir")
        Dim repetir = Integer.Parse(Console.ReadLine())
        Dim i = 1
        While i <= repetir
            Console.WriteLine("i=" & i)
            i = i + 1
        End While
        Console.Read()
    End Sub
End Module
