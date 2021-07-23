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
        If fil = col Then
            Dim matriz = New Integer(fil - 1, col - 1) {}
            For i = 0 To fil - 1
                For j = 0 To col - 1
                    Console.WriteLine("Matriz(" & i + 1 & "," & j + 1 & ")")
                    matriz(i, j) = Integer.Parse(Console.ReadLine())
                Next
            Next
            Dim esSimetrica = True
            For i = 0 To fil - 1
                For j = 0 To col - 1
                    If matriz(i, j) <> matriz(j, i) Then
                        esSimetrica = False
                        Exit For
                    End If
                Next
                If esSimetrica = False Then
                    Exit For
                End If
            Next
            If esSimetrica = True Then
                Console.WriteLine("Felicidades humano tu matriz si es simetrica")
            Else
                Console.WriteLine("Humano estupido tu matriz no es simetrica")
            End If
        Else
            Console.WriteLine("Humano las filas y las columnas deben ser iguales tambien")
        End If
        Console.Read()
    End Sub
End Module
