Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Console.WriteLine("Humano ingresa un texto")
        Dim texto = Console.ReadLine
        If texto <> "" Then
            Dim longitud = texto.Length
            Dim contador = 0
            Dim caracteres = New Char(longitud - 1) {}
            For i = longitud - 1 To 0 Step -1
                caracteres(contador) = texto(i)
                contador = contador + 1
            Next
            'For Each caracter In caracteres
            '    Console.Write(caracter)
            'Next
            Console.WriteLine(caracteres)
        Else
            Console.WriteLine("Humano flojo tu texto no tiene texto")
        End If
        Console.Read()
    End Sub
End Module
