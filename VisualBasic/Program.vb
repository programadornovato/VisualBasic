Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Sub Main(args As String())
        Dim stringExplicita As String = "Hola mundo"
        Dim stringImplicita = "Hola mundo"
        Console.WriteLine("stringExplicita=" & stringExplicita.GetType.ToString())
        Console.WriteLine("stringImplicita=" & stringImplicita.GetType.ToString())

        Dim intExplicita As Integer = 5
        Dim intImplicita = 5
        Console.WriteLine("intExplicita=" & intExplicita.GetType.ToString())
        Console.WriteLine("intImplicita=" & intImplicita.GetType.ToString())

        Dim floatExplicita As Single = 5
        Dim floatImplicita = 5.0F
        Console.WriteLine("floatExplicita=" & floatExplicita.GetType.ToString())
        Console.WriteLine("floatImplicita=" & floatImplicita.GetType.ToString())

        Dim doubleImplicita = 5.0
        Console.WriteLine("doubleImplicita=" & doubleImplicita.GetType.ToString())
        Console.Read()
    End Sub
End Module
