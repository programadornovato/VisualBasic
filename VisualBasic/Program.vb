Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim entro = False
        Console.WriteLine("Humano ingresa un numero entre 1 y 999:")
        Dim num = Integer.Parse(Console.ReadLine())
        If num >= 1 And num <= 9 Then
            Console.WriteLine("Humano tu numero " & num & " es de tipo unidad")
            entro = True
        Else
            If num >= 10 And num <= 99 Then
                Console.WriteLine("Humano tu numero " & num & " es de tipo decena")
                entro = True
            Else
                If num >= 100 And num <= 999 Then
                    Console.WriteLine("Humano tu numero " & num & " es de tipo centena")
                    entro = True
                End If
            End If
        End If
        If entro = False Then
            Console.WriteLine("Humano estupido tu numero no esta en el rango de 1 y 999")
        End If
        Console.Read()
    End Sub
End Module
