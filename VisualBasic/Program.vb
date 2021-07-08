Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Console.WriteLine("¿Humano cual es tu nombre?")
        Dim nombre = Console.ReadLine()
        Console.WriteLine("¿" & nombre & " en que año naciste?")
        Dim añoNacimiento = Integer.Parse(Console.ReadLine())
        Dim edad = DateTime.Now.Year - añoNacimiento
        Console.WriteLine("¿Humano cuanto dinero ganas?")
        Dim sueldo = Single.Parse(Console.ReadLine())
        Console.WriteLine("Pobre " & nombre & " a tus " & edad & " años solo ganas " & sueldo & " pesitos")
    End Sub
End Module
