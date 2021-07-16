Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Console.WriteLine("Humano ingresa dos pinches numeros")
        Console.WriteLine("Ingresa el valor de a")
        Dim a = Integer.Parse(Console.ReadLine())
        Console.WriteLine("Ingresa el valor de b")
        Dim b = Integer.Parse(Console.ReadLine())
        Dim tem = a
        a = b
        b = tem
        Console.WriteLine("a=" & a)
        Console.WriteLine("b=" & b)

        Console.Read()
    End Sub
End Module
