Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim rdn = New Random()
        Dim aleatorio = rdn.Next(1, 6)
        Console.WriteLine("Humano por favor ingresa un numero aleatorio entre 1 y 5")
        Dim numero = Integer.Parse(Console.ReadLine())
        While aleatorio <> numero
            Console.WriteLine("Humano estupido el numero que estaba pensando era el " & aleatorio & " intantalo de nuevo o escribe 0 ")
            numero = Integer.Parse(Console.ReadLine())
            If numero = 0 Then
                Exit While
            End If
            aleatorio = rdn.Next(1, 6)
        End While
        If numero = 0 Then
            Console.WriteLine("Humano ademas de ser estupido eres olgasan el numero que estaba pensano era el " & aleatorio)
        Else
            Console.WriteLine("Felicidades humano le atinaste al numero")
        End If
        Console.Read()
    End Sub
End Module
