Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Console.WriteLine("Humano que quieres calcular " & vbLf & "1.- Cuadrado " & vbLf & "2.- Rectangulo")
        Dim opcion = Integer.Parse(Console.ReadLine())
        Dim c As Cuadrilatero
        If opcion = 1 Then
            Console.WriteLine("Humano ingresa el lado de tu cuadrado ")
            Dim lado = Double.Parse(Console.ReadLine())
            c = New Cuadrilatero(lado)
        ElseIf opcion = 2 Then
            Console.WriteLine("Humano por favor ingresa el lado 1 de tu rectangulo")
            Dim lado1 = Double.Parse(Console.ReadLine())
            Console.WriteLine("Humano por favor ingresa el lado 2 de tu rectangulo")
            Dim lado2 = Double.Parse(Console.ReadLine())
            c = New Cuadrilatero(lado1, lado2)
        Else
            Console.WriteLine("Humano estupido esa opcion no existe")
            Exit Sub
        End If
        Console.WriteLine("el perimetro es " & c.perimetro.ToString & " y el area es " & c.area.ToString)
        Console.Read()
    End Sub
End Module
