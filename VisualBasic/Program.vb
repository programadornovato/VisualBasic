Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Try
            Dim contador = 0
            Dim calificacion = 0.0
            Dim suma = 0.0
            Dim promedio = 0.0
            Dim texto = ""
            Do
                Console.WriteLine("Humano por favor ingresa la calificacion del semestre " & (contador + 1) & " para terminar solo preciona enter")
                texto = Console.ReadLine()
                If texto <> "" Then
                    calificacion = Double.Parse(texto)
                    suma = suma + calificacion
                    contador = contador + 1
                End If
            Loop While texto <> ""
            If contador > 0 Then
                promedio = suma / contador
                Console.WriteLine("Humano tu promedio es de " & promedio)
            Else
                Console.WriteLine("Humano ademas de ser burro eres olgazan no ingresate ninguna calificacion")
            End If
        Catch ex As Exception
            Console.WriteLine("Humano estupido eso no es un numero " & ex.ToString)
        End Try

        Console.Read()
    End Sub
End Module
