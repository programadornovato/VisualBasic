Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim matrizO = New Integer(2, 2) {}
        Dim matrizT = New Integer(2, 2) {}
        For i = 0 To 2
            For j = 0 To 2
                Console.WriteLine("humano ingresa el valor de la matriz original (" & i + 1 & "," & j + 1 & ") ")
                matrizO(i, j) = Integer.Parse(Console.ReadLine())
            Next
        Next
        For i = 0 To 2
            For j = 0 To 2
                matrizT(i, j) = matrizO(j, i)
            Next
        Next
        Console.WriteLine("Humano aqui esta tu pinche matriz original")
        For i = 0 To 2
            For j = 0 To 2
                Console.Write(matrizO(i, j) & " | ")
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()
        Console.WriteLine("Humano aqui esta tu pinche matriz transpuesta")
        For i = 0 To 2
            For j = 0 To 2
                Console.Write(matrizT(i, j) & " | ")
            Next
            Console.WriteLine()
        Next
        Console.Read()
    End Sub
End Module
