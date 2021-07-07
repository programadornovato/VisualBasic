Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        calculaEdad(1970)
        Console.Read()
    End Sub
    Sub calculaEdad(ByVal añoNacimiento)
        Dim añoActual = DateTime.Now.Year
        Dim edad = añoActual - añoNacimiento
        Console.WriteLine("La edad del humano que nacio en " & añoNacimiento & " es de " & edad & " años")
        'Console.WriteLine(añoActual.GetType.ToString)
    End Sub
End Module
