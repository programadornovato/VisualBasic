Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        'Dim matriz = New Integer(1, 2) {}
        'Console.WriteLine("Filas=" & matriz.GetLength(0))
        'Console.WriteLine("Columnas=" & matriz.GetLength(1))
        'Console.WriteLine("Humano ingresa el tamaño de las filas de tu matriz")
        'Dim filas = Integer.Parse(Console.ReadLine())
        'Console.WriteLine("Humano ingresa el tamaño de las columnas de tu matriz")
        'Dim columnas = Integer.Parse(Console.ReadLine())
        'Dim matriz = New Integer(filas - 1, columnas - 1) {}
        'For i = 0 To filas - 1
        '    For j = 0 To columnas - 1
        '        Console.WriteLine("matriz(" & i + 1 & "," & j + 1 & ")")
        '        matriz(i, j) = Integer.Parse(Console.ReadLine())
        '    Next
        'Next
        'Console.WriteLine("Humano aqui esta tu pinche matriz")
        'For i = 0 To filas - 1
        '    For j = 0 To columnas - 1
        '        Console.Write(matriz(i, j) & ",")
        '    Next
        '    Console.WriteLine()
        'Next
        Dim matriz = New Integer(0, 1, 2) {}
        Console.WriteLine("x=" & matriz.GetLength(0))
        Console.WriteLine("y=" & matriz.GetLength(1))
        Console.WriteLine("z=" & matriz.GetLength(2))
        Console.Read()
    End Sub
End Module
