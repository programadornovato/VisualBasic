Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Sub Main(args As String())
        Dim numString1 = "10.22"
        Dim numString2 = "20.15"
        'Dim numInt1 = Integer.Parse(numString1)
        'Dim numInt2 = Integer.Parse(numString2)
        'Dim resultado = numInt1 + numInt2

        'Dim numFloat1 = Single.Parse(numString1)
        'Dim numFloat2 = Single.Parse(numString2)
        'Dim resultado = numFloat1 + numFloat1

        Dim numDoble1 = Single.Parse(numString1)
        Dim numDoble2 = Single.Parse(numString2)
        Dim resultado = numDoble1 + numDoble1

        Console.WriteLine(resultado)


        Console.Read()
    End Sub
End Module
