Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Console.WriteLine("Math.PI=" & Math.PI)
        Console.WriteLine("Math.E=" & Math.E)
        Console.WriteLine("Math.Min(5.5,3.5)=" & Math.Min(5.5, 3.5))
        Console.WriteLine("Math.Max(5.5,3.5)=" & Math.Max(5.5, 3.5))
        Console.WriteLine("Math.Round(5.5)=" & Math.Round(5.5))
        Console.WriteLine("Math.Round(-5.5)=" & Math.Round(-5.5))
        Console.WriteLine("Math.Ceiling(5.5)=" & Math.Ceiling(5.5))
        Console.WriteLine("Math.Ceiling(-5.5)=" & Math.Ceiling(-5.5))
        Console.WriteLine("Math.Floor(5.5)=" & Math.Floor(5.5))
        Console.WriteLine("Math.Floor(-5.5)=" & Math.Floor(-5.5))
        Console.WriteLine("Math.Truncate(-5.5)=" & Math.Truncate(-5.5))
        Console.WriteLine("Math.Abs(-5.5)=" & Math.Abs(-5.5))
        Console.WriteLine("Math.Abs(5.5)=" & Math.Abs(5.5))
        Console.WriteLine("Math.Sign(-5.5)=" & Math.Sign(-5.5))
        Console.WriteLine("Math.Sign(5.5)=" & Math.Sign(5.5))
        Console.WriteLine("Math.Pow(3,3)=" & Math.Pow(3, 3))
        Console.WriteLine("Math.Sqrt(9)=" & Math.Sqrt(9))
        Console.Read()
    End Sub
End Module
