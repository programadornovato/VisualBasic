Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Console.WriteLine("Humano cual es tu fecha de nacimiento en formato dd/MM/yyyy")
        Dim fechaNacimientoString = Console.ReadLine()
        'Dim fechaNacimientoDate As DateTime
        Try
            Dim fechaNacimientoDate = DateTime.ParseExact(fechaNacimientoString, "dd/MM/yyyy", Nothing)
            Dim fechaHoy = DateTime.Now
            Dim diferencia = fechaHoy - fechaNacimientoDate
            Dim dias = diferencia.TotalDays
            Dim años = Math.Floor(dias / 365)
            Console.WriteLine("Humano tu tienes " & años & " años")
        Catch ex As Exception
            Console.WriteLine("Humano estupido te pedi una fecha en formato dd/MM/yyyy")
        End Try
        Console.Read()
    End Sub
End Module
