Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Console.WriteLine("Vocho")
        Dim vocho1 = New Auto()
        vocho1.meterLlave("123456")
        vocho1.mando("enciende")
        Console.WriteLine("Beatle")
        Dim beattle = New Auto()
        beattle.meterLlave("123456")
        beattle.mando("enciende")
        beattle.mando("acelera")
        Console.Read()
    End Sub
End Module
