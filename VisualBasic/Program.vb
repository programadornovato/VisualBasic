Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim a = 6.0
        Dim b = 5.0
        Console.WriteLine("a=" & a & " b=" & b)

        ''a = a + b
        'a += b
        'Console.WriteLine("a=" & a & " b=" & b)

        ''a = a - b
        'a -= b
        'Console.WriteLine("a=" & a & " b=" & b)

        ''a = a * b
        'a *= b
        'Console.WriteLine("a=" & a & " b=" & b)

        ''a = a / b
        'a /= b
        'Console.WriteLine("a=" & a & " b=" & b)

        'a = a mod b
        a = a Mod b
        Console.WriteLine("a=" & a & " b=" & b)

        Console.Read()
    End Sub
End Module
