Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Console.WriteLine("Humano ingresa un palindromo")
        Dim texto = Console.ReadLine()
        Dim textoCopia = texto
        If texto IsNot Nothing Then
            texto = texto.ToLower()
            texto = texto.Replace(" ", "")
            Dim longitud = texto.Length
            Dim igual = True
            Dim cont = 0
            For indice = longitud - 1 To 0 Step -1
                If (texto(indice) <> texto(cont)) Then
                    igual = False
                    Exit For
                End If
                cont = cont + 1
            Next
            If igual = True Then
                Console.WriteLine("Felicidades humano el texto " & textoCopia & " si es palindromo")
            Else
                Console.WriteLine("Humano estupido el texto " & textoCopia & " no es palindromo")
            End If
        Else
            Console.WriteLine("humano estupido te pedi que ingresarar un palindo y no escribiste nada")
        End If
        Console.Read()
    End Sub
End Module
