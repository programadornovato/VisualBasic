Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim alumnos = New String(6, 1) {}
        For i = 0 To alumnos.GetLength(0) - 1
            Console.WriteLine("Humano ingresa el NOMBRE del alumno " & i + 1)
            alumnos(i, 0) = Console.ReadLine()
            Console.WriteLine("Humano ingresa el SALON del alumno " & i + 1)
            alumnos(i, 1) = Console.ReadLine()
        Next
        Console.WriteLine("Humano ingresa el SALON de los alumnos que quieres visualizar")
        Dim salon = Console.ReadLine()
        For i = 0 To alumnos.GetLength(0) - 1
            If salon = alumnos(i, 1) Then
                'Console.Write(alumnos(i, 0) & " | " & alumnos(i, 1))
                For j = 0 To alumnos.GetLength(1) - 1
                    Console.Write(alumnos(i, j) & " | ")
                Next
                Console.WriteLine()
            End If
        Next
        Console.Read()
    End Sub
End Module
