Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Console.WriteLine("Humano cuantas filas tiene tu matriz")
        Dim fil = Integer.Parse(Console.ReadLine())
        Console.WriteLine("Humano cuantas columnas tiene tu matriz")
        Dim col = Integer.Parse(Console.ReadLine())
        Dim matriz = New Integer(fil - 1, col - 1) {}
        For i = 0 To fil - 1
            For j = 0 To col - 1
                Console.WriteLine("Matriz(" & i + 1 & "," & j + 1 & ")")
                matriz(i, j) = Integer.Parse(Console.ReadLine())
            Next
        Next
        Dim sumaFil = 0
        Dim sumaCol = 0
        For i = 0 To fil - 1
            sumaFil = 0
            For j = 0 To col - 1
                sumaFil = sumaFil + matriz(i, j)
            Next
            Console.WriteLine("Suma fila " & i + 1 & "=" & sumaFil)
        Next
        Console.WriteLine()
        For j = 0 To fil - 1
            sumaCol = 0
            For i = 0 To col - 1
                sumaCol = sumaCol + matriz(i, j)
            Next
            Console.WriteLine("Suma Columna " & j + 1 & "=" & sumaCol)
        Next
        Console.Read()
    End Sub
End Module
