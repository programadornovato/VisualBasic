Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        'For i = 1 To 5 Step 2
        '    Console.WriteLine("i=" & i)
        'Next

        'Dim i = 1
        'While i <= 5
        '    Console.WriteLine("i=" & i)
        '    i = i + 2
        'End While

        'For i = 5 To 1 Step -2
        '    Console.WriteLine("i=" & i)
        'Next

        Console.WriteLine("Humano ingresa el numero de repeticiones")
        Dim repeticion As Integer
        Try
            repeticion = Integer.Parse(Console.ReadLine)
            For i = 1 To repeticion
                Console.WriteLine("i=" & i)
            Next
        Catch ex As Exception
            Console.WriteLine("Humano estupido te pedi un numero")
        End Try

        Console.Read()
    End Sub
End Module
