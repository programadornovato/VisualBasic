Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Console.WriteLine("Humano ingresa la cantidad de alumnos")
        Dim cantidadAlumnos = Integer.Parse(Console.ReadLine())
        Dim a = New Alumnos(cantidadAlumnos - 1) {}
        For i = 0 To cantidadAlumnos - 1
            Console.WriteLine("Humano ingresa el NOMBRE del alumno " & (i + 1))
            Dim nombre = Console.ReadLine()
            Console.WriteLine("Humano ingresa el AULA del alumno " & (i + 1))
            Dim aula = Console.ReadLine()(0)
            Console.WriteLine("Humano ingresa el CALIFICACION del alumno " & (i + 1))
            Dim cal = Double.Parse(Console.ReadLine())
            a(i) = New Alumnos(nombre, aula, cal)
        Next
        Dim suma = 0.0
        Dim promedio = 0.0
        Dim cantidadAlumnosSalon = 0
        Console.WriteLine("Humano ingresa el salon del que quieres obtener el promedio")
        Dim salon = Console.ReadLine()(0)
        For i = 0 To cantidadAlumnos - 1
            If salon = a(i).getAula Then
                suma = suma + a(i).getCalificacion
                cantidadAlumnosSalon = cantidadAlumnosSalon + 1
            End If
        Next
        promedio = suma / cantidadAlumnosSalon
        Console.WriteLine("El promedio del salon " & salon & " es " & promedio)
        Console.Read()
    End Sub
End Module
