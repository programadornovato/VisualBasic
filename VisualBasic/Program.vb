Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim a = New Integer(4) {}
        Dim b = New Integer(4) {}
        Dim c = New Integer(9) {}
        For i = 0 To 4
            Console.WriteLine("Humano ingresa el valor de a(" & i + 1 & ")")
            a(i) = Integer.Parse(Console.ReadLine())
        Next
        For i = 0 To 4
            Console.WriteLine("Humano ingresa el valor de b(" & i + 1 & ")")
            b(i) = Integer.Parse(Console.ReadLine())
        Next
        Dim j = 0
        For i = 0 To 4
            c(j) = a(i)
            j = j + 1
            c(j) = b(i)
            j = j + 1
        Next
        For Each elemento In c
            Console.Write(elemento & "-")
        Next
        Console.Read()
    End Sub
End Module
