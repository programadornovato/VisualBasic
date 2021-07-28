Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim p1 = New Persona("Juan", 1)
        'p1.inicializar("Juan", 1)
        p1.mostrar()
        Dim p2 = New Persona("Pepe", 2)
        p2.mostrar()
        Console.Read()
    End Sub
End Module
