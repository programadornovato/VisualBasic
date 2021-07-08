Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Try
            Console.WriteLine("Por favor humano ingresa un NUMERO:")
            Dim numeroS = Console.ReadLine()
            Dim numeroI = Integer.Parse(numeroS)
            Dim cuadrado = numeroI * numeroI
            Console.WriteLine("Humano el numero " & numeroI & " al cuadrado es:" & cuadrado)
        Catch ex As Exception
            Console.WriteLine("Humano estupido te pedi un NUMERO " & ex.ToString())
        Finally
            Console.WriteLine("Se ejecuto Finally")
        End Try

        Console.Read()
    End Sub
End Module
