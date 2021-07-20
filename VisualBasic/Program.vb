Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim listaNumeros = New Integer(4) {}
        For i = 0 To listaNumeros.Length - 1
            Console.WriteLine("Humano, ingresa el elemento " & (i + 1))
            listaNumeros(i) = Integer.Parse(Console.ReadLine())
        Next
        Dim menor = 0
        Dim pos = 0
        Dim tem = 0
        For i = 0 To listaNumeros.Length - 2
            menor = listaNumeros(i)
            pos = i
            For j = i + 1 To listaNumeros.Length - 1
                If listaNumeros(j) < menor Then
                    menor = listaNumeros(j)
                    pos = j
                End If
            Next
            If pos <> i Then
                tem = listaNumeros(i)
                listaNumeros(i) = listaNumeros(pos)
                listaNumeros(pos) = tem
            End If
        Next
        Console.WriteLine("Humano aqui esta tu pinche lista de numeros ordenado de forma acendente")
        For i = 0 To listaNumeros.Length - 1
            Console.WriteLine(listaNumeros(i))
        Next
        Console.WriteLine("Humano aqui esta tu pinche lista de numeros ordenado de forma decndente")
        For i = listaNumeros.Length - 1 To 0 Step -1
            Console.WriteLine(listaNumeros(i))
        Next
        Console.Read()
    End Sub
End Module
