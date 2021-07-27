Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim cal = New Calculadora()
        Dim res = 0
        Dim n1 = 1
        Dim n2 = 2
        Console.WriteLine("n1=" & n1 & vbLf & "n2=" & n2)
        res = cal.suma(n1, n2)
        Console.WriteLine("Suma=" & res)
        res = cal.resta(n1, n2)
        Console.WriteLine("Resta=" & res)
        res = cal.multiplicar(n1, n2)
        Console.WriteLine("Multiplicar=" & res)
        Dim resD = cal.divicion(n1, n2)
        Console.WriteLine("Divicion=" & resD)
        Console.Read()
    End Sub
End Module
