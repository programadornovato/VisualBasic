Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim v1 = New Vehiculo("Nissan", "2010")
        v1.acelera()
        Dim v2 = New Vehiculo("sku654HH")
        v2.acelera(20)
        Console.Read()
    End Sub
End Module
