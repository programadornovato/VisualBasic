Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim mat = New Trigonometria.Matematicas(5, 6)
        Console.WriteLine(mat.suma())
        Dim matAlgebra = New Algebra.Matematicas(5, 6)
        Console.WriteLine(mat.suma())
        Console.Read()
    End Sub
End Module
