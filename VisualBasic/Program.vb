Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Sub Main(args As String())
        Dim num1 As Integer = 1
        Dim num2 As Integer = 1
        Dim suma As Integer = num1 + num2
        Dim num3 As Integer = 1, num4 As Integer = 2, num5 As Integer = 3
        Dim valD1 As Double = 5.5
        Dim valD2 As Double = 6.6
        Dim sumaD As Double = valD1 + valD2
        Dim valFloat As Single = 5.5F
        Dim sumaFD = sumaD + valFloat

        Console.WriteLine(num1 & "+" & num2 & " =" & suma)
        Console.WriteLine(valD1 & "+" & valD2 & " =" & sumaD)
        Console.WriteLine("suma es de tipo " & suma.GetType.ToString())
        Console.WriteLine("sumaFD es del tipo " & sumaFD.GetType.ToString())

        Console.Read()
    End Sub
End Module
