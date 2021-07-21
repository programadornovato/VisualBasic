Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Console.WriteLine("Humano ingresa el valor objetivo")
        Dim numeroBuscar = Integer.Parse(Console.ReadLine())
        Dim listaNumeros = New Integer(6) {}
        For i = 0 To listaNumeros.Length - 1
            Console.WriteLine("Humano ingresa el valor del elemento " & i + 1)
            listaNumeros(i) = Integer.Parse(Console.ReadLine())
        Next
        Dim n = listaNumeros.Length
        Dim inf = 0
        Dim centro = 0
        Dim sup = n - 1
        Dim bandera = False
        Dim cont = 0
        While inf <= sup
            centro = (sup + inf) / 2
            If listaNumeros(centro) = numeroBuscar Then
                bandera = True
                Exit While
            ElseIf numeroBuscar < listaNumeros(centro) Then
                sup = centro - 1
            ElseIf numeroBuscar > listaNumeros(centro) Then
                inf = centro + 1
            End If
            cont = cont + 1
        End While
        If bandera = True Then
            Console.WriteLine("El numero " & numeroBuscar & " se encuentra en la posicion " & centro + 1)
        Else
            Console.WriteLine("Humano estupi el numero no se encuentra en la lista")
        End If
        Console.WriteLine("Vueltas = " & cont)
        Console.Read()
    End Sub
End Module
