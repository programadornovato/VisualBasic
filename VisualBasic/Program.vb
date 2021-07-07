Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim edad = calculaEdad(1970)
        Console.WriteLine("La edad del humano es de " & edad & " años")
        Dim año = añoNacimiento(20)
        Console.WriteLine("El año de nacimiento del humano es de " & año)
        Console.Read()
    End Sub
    Function calculaEdad(ByVal añoNacimiento)
        Dim añoActual = DateTime.Now.Year
        Return añoActual - añoNacimiento
        'Console.WriteLine("La edad del humano que nacio en " & añoNacimiento & " es de " & edad & " años")
        'Console.WriteLine(añoActual.GetType.ToString)
    End Function
    Function añoNacimiento(ByVal edad)
        Dim añoActual = DateTime.Now.Year
        Return añoActual - edad
    End Function
End Module
