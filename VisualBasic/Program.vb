Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim c1 = New MiClase()
        Dim c2 = New MiClase()
        Console.WriteLine("c1.normal=" & c1.normal)
        Console.WriteLine("c2.normal=" & c2.normal)
        c1.normal = "C1 modificado"
        Console.WriteLine("c1.normal=" & c1.normal)
        Console.WriteLine("c2.normal=" & c2.normal)
        Console.WriteLine("c1.estatico=" & c1.estatico)
        Console.WriteLine("c2.estatico=" & c2.estatico)
        c2.estatico = "Estatico modificado"
        Console.WriteLine("c1.estatico=" & c1.estatico)
        Console.WriteLine("c2.estatico=" & c2.estatico)
        MiClase.estatico = "Estatico modificado desde la clase"
        Console.WriteLine("c1.estatico=" & c1.estatico)
        Console.WriteLine("c2.estatico=" & c2.estatico)

        Console.Read()
    End Sub
End Module
