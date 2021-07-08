Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Console.WriteLine("Humano, por favor, ingresa un numero entre 0 y 10")
        Dim cal = Double.Parse(Console.ReadLine())
        Dim calRedondeada = Convert.ToInt32(Math.Round(cal))
        If (calRedondeada >= 0) AndAlso (calRedondeada < 6) Then
            Console.WriteLine("El alumno se chingo")
        ElseIf calRedondeada >= 6 AndAlso calRedondeada <= 9 Then
            Console.WriteLine("El alumno YA chingo")
        ElseIf calRedondeada = 10 Then
            Console.WriteLine("El alumno es una v3rg4")
        Else
            Console.WriteLine("Humano estupido te pedi un numero entre 0 y 10 y me entragas un " & calRedondeada)
        End If
        Console.Read()
    End Sub
End Module
