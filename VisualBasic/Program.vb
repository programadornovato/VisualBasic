Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim matriz = New Integer(4, 4) {}
        Dim dato = 1
        For i = 0 To matriz.GetLength(0) - 1
            For j = 0 To matriz.GetLength(1) - 1
                matriz(i, j) = dato
                dato = dato + 1
            Next
        Next
        For i = 0 To matriz.GetLength(0) - 1
            For j = 0 To matriz.GetLength(1) - 1
                Console.Write(matriz(i, j) & vbTab)
            Next
            Console.WriteLine()
        Next
        Dim diagonalPrincipal = New Integer(matriz.GetLength(0) - 1) {}
        Dim diagonalSecundaria = New Integer(matriz.GetLength(0) - 1) {}
        For i = 0 To matriz.GetLength(0) - 1
            For j = 0 To matriz.GetLength(1) - 1
                If i = j Then
                    diagonalPrincipal(i) = matriz(i, j)
                End If
                If (i + j) = matriz.GetLength(0) - 1 Then
                    diagonalSecundaria(i) = matriz(i, j)
                End If
            Next
        Next
        Dim suma = 0
        Console.WriteLine()
        Console.WriteLine("Diagonal principal")
        For Each numero In diagonalPrincipal
            Console.Write(numero & vbTab)
            suma = suma + numero
        Next
        Console.WriteLine(" = " & suma)
        suma = 0
        Console.WriteLine()
        Console.WriteLine("Diagonal secundaria")
        For Each numero In diagonalSecundaria
            Console.Write(numero & vbTab)
            suma = suma + numero
        Next
        Console.WriteLine(" = " & suma)
        Console.Read()
    End Sub
End Module
