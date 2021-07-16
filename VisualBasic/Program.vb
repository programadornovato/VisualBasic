Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim calificaciones = New Double(3) {}
        Dim semestres = 0
        Dim suma = 0.0
        Dim promedio = 0.0
        Do
            Console.WriteLine("Humano ingresa la calificacion del semestre " & semestres + 1 & " o preciona enter para salir ")
            Dim calificacionString = Console.ReadLine()
            If calificacionString = "" Then
                Exit Do
            Else
                calificaciones(semestres) = Double.Parse(calificacionString)
                semestres = semestres + 1
            End If
        Loop While semestres < 4
        If semestres > 0 Then
            For Each cal In calificaciones
                suma = suma + cal
            Next
            promedio = suma / semestres
            Console.WriteLine("Humano, la calificacion del alumno es " & promedio)
        Else
            Console.WriteLine("Humano flojo te pedi por lo menos una calificacion ")
        End If
        Console.Read()
    End Sub
End Module
