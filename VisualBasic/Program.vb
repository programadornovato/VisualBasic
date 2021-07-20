Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Console.WriteLine("humano ingresa un alista de numero separados por coma")
        Dim texto = Console.ReadLine()
        Dim listaNumerosTexto As String() = texto.Split(",")
        Dim cantidad As Integer = listaNumerosTexto.Length
        Dim listaNumeros As Integer() = New Integer(cantidad - 1) {}
        For i = 0 To cantidad - 1
            listaNumeros(i) = Integer.Parse(listaNumerosTexto(i))
        Next
        Dim tem = 0
        For i = 0 To cantidad - 2
            For j = 0 To cantidad - 2
                If (listaNumeros(j) > listaNumeros(j + 1)) Then
                    tem = listaNumeros(j)
                    listaNumeros(j) = listaNumeros(j + 1)
                    listaNumeros(j + 1) = tem
                End If
            Next
        Next
        Console.WriteLine("Humano aqui esta tu pinche lista de nuemro ordenada de forma acendente")
        For i = 0 To cantidad - 1
            Console.WriteLine(listaNumeros(i))
        Next
        Console.WriteLine("Humano aqui esta tu pinche lista de nuemro ordenada de forma decendente")
        For i = cantidad - 1 To 0 Step -1
            Console.WriteLine(listaNumeros(i))
        Next
        Console.Read()
    End Sub
End Module
