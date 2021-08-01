Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim c = New Carro(3) {}
        c(0) = New Carro("654654", "Nissan", 2015)
        c(1) = New TipoTurismo("TT65464", "Nissan", 2010, 3)
        c(2) = New TipoDeportivo("DD6549/7", "Nissan", 2020, 8)
        c(3) = New TipoFurgoneta("FFF54", "Nissan", 2021, 500)
        For Each elemnto In c
            Console.WriteLine(elemnto.retornarDatos)
        Next
        Console.Read()
    End Sub
End Module
