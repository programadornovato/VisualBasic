Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        'Dim a = New Automotores()
        'a.llantas()
        Dim m = New Motocicletas()
        m.llantas()
        Dim a = New Autos()
        a.llantas()
        Dim c = New Camiones()
        c.llantas()
        Console.Read()
    End Sub
End Module
