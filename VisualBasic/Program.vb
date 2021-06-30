Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Sub Main(args As String())
        Dim num1 = 5
        Dim num2 = 3

        Dim suma = num1 + num2
        Console.WriteLine("suma=" & suma)

        Dim resta = num1 - num2
        Console.WriteLine("resta=" & resta)

        Dim divicion = num1 / num2
        Console.WriteLine("divicion=" & divicion & " " & divicion.GetType.ToString)

        Dim residio = num1 Mod num2
        Console.WriteLine("residio=" & residio)

        Dim mul = num1 * num2
        Console.WriteLine("mul=" & residio)


        Console.Read()
    End Sub
End Module
