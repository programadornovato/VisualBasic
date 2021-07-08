Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Console.WriteLine("Humano por favor ingrese un numero entre 1 y 7")
        Dim dia = Integer.Parse(Console.ReadLine())
        Select Case dia
            Case 1
                Console.WriteLine("Humano seleccionaste el lunes")
            Case 2
                Console.WriteLine("Humano seleccionaste el martes")
            Case 3
                Console.WriteLine("Humano seleccionaste el miercoles")
            Case 4
                Console.WriteLine("Humano seleccionaste el jueves")
            Case 5
                Console.WriteLine("Humano seleccionaste el viernes")
            Case 6
                Console.WriteLine("Humano seleccionaste el sabado")
            Case 7
                Console.WriteLine("Humano seleccionaste el domingo")
            Case Else
                Console.WriteLine("Humano estupido te pedi un NUMERO ENTRE 1 y 7")
        End Select
        Console.Read()
    End Sub
End Module
