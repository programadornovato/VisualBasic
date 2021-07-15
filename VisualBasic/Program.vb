Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim perros = New String() {"Monte", "Chupacabras", "Mikey", "Solovino", "El chiquito"}
        Console.WriteLine("CON FOR")
        For i = 0 To perros.Length - 1
            Console.WriteLine("El perro " & i & " es " & perros(i))
        Next
        Console.WriteLine("CON FOR EACH")
        Dim j = 0
        For Each perro In perros
            Console.WriteLine("El perro " & j & " es " & perro)
            j = j + 1
        Next
        Console.Read()
    End Sub
End Module
