Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        'Console.WriteLine("Humano por favor escribe alguno de estos textos " & vbLf & "acceso" & vbLf & "configuraciones" & vbLf & "salir")
        'Dim seleccion = Console.ReadLine()
        'Select Case seleccion.ToLower
        '    Case "acceso"
        '        Console.WriteLine("Humano seleccionaste acceso")
        '    Case "configuraciones"
        '        Console.WriteLine("Humano seleccionaste configuraciones")
        '    Case "salir"
        '        Console.WriteLine("Humano seleccionaste salir")
        '    Case Else
        '        Console.WriteLine("Humano estupido te pedi que escribieras alguna de las opciones")
        'End Select
        Console.WriteLine("Humano por favor saludame con un hola")
        Dim saludo = Console.ReadLine()
        If saludo.ToLower = "hola" Then
            Console.WriteLine("Hola humano")
        Else
            Console.WriteLine("No te entiendo humano")
        End If
        Console.Read()
    End Sub
End Module
