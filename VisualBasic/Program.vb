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
        Dim pos = 0
        Dim bandera = False
        While pos < listaNumeros.Length And bandera = False
            If listaNumeros(pos) = numeroBuscar Then
                bandera = True
                Exit While
            End If
            pos = pos + 1
        End While
        If bandera = True Then
            Console.WriteLine("Humano el valor " & numeroBuscar & " estaba en la posicion " & pos + 1)
        Else
            Console.WriteLine("Humano estupido el numero " & numeroBuscar & " no esta en la lista")
        End If
        Console.Read()
    End Sub
End Module
