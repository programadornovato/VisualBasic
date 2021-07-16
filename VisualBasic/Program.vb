Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Console.WriteLine("humano ingresa un alista de numero separados por coma")
        Dim tex = Console.ReadLine()
        Dim mayor = 0
        Dim listaNumerosString = tex.Split(",")
        Dim tamaño = listaNumerosString.Length
        Dim lisitaNumeros = New Integer(tamaño) {}
        For i = 0 To tamaño - 1
            lisitaNumeros(i) = Integer.Parse(listaNumerosString(i))
        Next
        For Each num In lisitaNumeros
            If num > mayor Then
                mayor = num
            End If
        Next
        Console.WriteLine("Humano tu pinche numero mayor es " & mayor)
        Console.Read()
    End Sub
End Module
