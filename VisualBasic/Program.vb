Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        'Console.WriteLine("Hola humano por favor ingresa una de las siguientes opciones")
        'Console.WriteLine("1.- Acceso")
        'Console.WriteLine("2.- Configuracion")
        'Console.WriteLine("3.- Salir")
        'Dim opcion = Integer.Parse(Console.ReadLine())
        'While opcion <> 3
        '    Select Case opcion
        '        Case 1
        '            Console.WriteLine("Seleccionaste el acceso")
        '        Case 2
        '            Console.WriteLine("Seleccionaste el configuracion")
        '        Case 3
        '            Console.WriteLine("Adios humano, te voy a extrañar")
        '        Case Else
        '            Console.WriteLine("Humano estupido te pedi que ingresara 1 o 2 o 3")
        '    End Select
        '    Console.WriteLine("Hola humano por favor ingresa una de las siguientes opciones")
        '    Console.WriteLine("1.- Acceso")
        '    Console.WriteLine("2.- Configuracion")
        '    Console.WriteLine("3.- Salir")
        '    opcion = Integer.Parse(Console.ReadLine())
        'End While
        'If opcion = 3 Then
        '    Console.WriteLine("Adios humano, te voy a extrañar")
        'End If
        Dim opcion = 0
        Do
            Console.WriteLine("Hola humano por favor ingresa una de las siguientes opciones")
            Console.WriteLine("1.- Acceso")
            Console.WriteLine("2.- Configuracion")
            Console.WriteLine("3.- Salir")
            opcion = Integer.Parse(Console.ReadLine())
            Select Case opcion
                Case 1
                    Console.WriteLine("Seleccionaste el acceso")
                Case 2
                    Console.WriteLine("Seleccionaste el configuracion")
                Case 3
                    Console.WriteLine("Adios humano, te voy a extrañar")
                Case Else
                    Console.WriteLine("Humano estupido te pedi que ingresara 1 o 2 o 3")
            End Select
        Loop While opcion <> 3

        Console.Read()
    End Sub
End Module
