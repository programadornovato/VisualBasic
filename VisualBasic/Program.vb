Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        'listaNormal()
        listaDinamica()
        Console.Read()
    End Sub
    Public Sub listaNormal()
        Console.WriteLine("Humano por favor ingresa la cantidad de elementos")
        Dim cantidad = Integer.Parse(Console.ReadLine())
        Dim lista = New String(cantidad - 1) {}
        For i = 0 To cantidad - 1
            Console.WriteLine("Humano por favor ingresa el elemnto de la lista " & i + 1)
            lista(i) = Console.ReadLine()
        Next
        For Each elemento In lista
            Console.WriteLine(elemento)
        Next
    End Sub
    Public Sub listaDinamica()
        Dim lista = New ArrayList()
        Dim respuesta As Char
        Dim i = 0
        Do
            Console.WriteLine("Humano por favor ingresa el elemnto de la lista " & i + 1)
            lista.Add(Console.ReadLine())
            Console.WriteLine("Humano, quieres ingresar otro elemnto? s/n")
            respuesta = Console.ReadLine()(0)
            i = i + 1
        Loop While (respuesta = "s" Or respuesta = "S")
        For Each elemento In lista
            Console.WriteLine(elemento)
        Next
    End Sub
End Module
