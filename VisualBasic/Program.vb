Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim rand = New Random()
        Dim d1 = rand.Next(1, 7)
        Dim d2 = rand.Next(1, 7)
        Dim d3 = rand.Next(1, 7)
        Console.WriteLine("d1=" & d1)
        Console.WriteLine("d2=" & d2)
        Console.WriteLine("d3=" & d3)
        If d1 = 6 And d2 = 6 And d3 = 6 Then
            Console.WriteLine("Excelnte")
        Else
            If (d1 = 6 And d2 = 6) Or (d1 = 6 And d3 = 6) Or (d2 = 6 And d3 = 6) Then
                Console.WriteLine("Muy bien")
            Else
                If d1 = 6 Or d2 = 6 Or d3 = 6 Then
                    Console.WriteLine("Regular")
                Else
                    Console.WriteLine("Pesimo")
                End If
            End If
        End If
        Console.Read()
    End Sub
End Module
