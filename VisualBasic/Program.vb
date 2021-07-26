Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Console.WriteLine("Vocho")
        Dim vocho1 = New Auto()
        vocho1.color = "Naranja"
        vocho1.modelo = 1980
        vocho1.marca = "Vocho"
        Console.WriteLine(vocho1.color)
        Console.WriteLine(vocho1.modelo)
        Console.WriteLine(vocho1.marca)
        vocho1.enciende()
        vocho1.acelera()
        vocho1.frena()
        Console.WriteLine("Beatle")
        Dim beattle = New Auto()
        beattle.color = "Gris"
        beattle.modelo = 2010
        beattle.marca = "Beattle"
        Console.WriteLine(beattle.color)
        Console.WriteLine(beattle.modelo)
        Console.WriteLine(beattle.marca)
        beattle.enciende()
        beattle.acelera()
        beattle.frena()
        Console.Read()
    End Sub
    Class Auto
        Public color = ""
        Public modelo = 0
        Public marca = ""
        Public Sub enciende()
            Console.WriteLine("El auto ha encendido run run")
        End Sub
        Public Sub acelera()
            Console.WriteLine("El auto acelera")
        End Sub
        Public Sub frena()
            Console.WriteLine("El auto frena")
        End Sub
    End Class
End Module
