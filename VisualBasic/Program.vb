Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim a = New Animal()
        a.comer()
        a.correr()
        Dim h = New Humano()
        h.comer()
        h.correr()
        Dim p = New Perro()
        p.comer()
        p.correr()
        Dim pa = New Pajaro()
        pa.comer()
        pa.vuelan()
        pa.correr()
        Console.Read()
    End Sub
End Module
