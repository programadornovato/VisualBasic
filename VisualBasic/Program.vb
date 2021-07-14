Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim arreglo = New Integer() {5, 8, 3, 7, 4, 1}
        Console.WriteLine("El elemento en la posicion 4 es " & arreglo(3))
        Console.WriteLine("El tamaño es " & arreglo.Length)
        For i = 0 To arreglo.Length - 1
            Console.WriteLine("El valor del elemento " & i + 1 & " es " & arreglo(i))
        Next
        Console.Read()
    End Sub
End Module
