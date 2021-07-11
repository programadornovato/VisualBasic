Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Dim rand = New Random()

        Dim numEntero = rand.Next
        Console.WriteLine("numEntero=" & numEntero & " " & numEntero.GetType.ToString)

        Dim numEnteroConUnParametro = rand.Next(7)
        Console.WriteLine("numEnteroConUnParametro=" & numEnteroConUnParametro & " " & numEnteroConUnParametro.GetType.ToString)

        Dim numEnteroConDosParametro = rand.Next(1, 7)
        Console.WriteLine("numEnteroConDosParametro=" & numEnteroConDosParametro & " " & numEnteroConDosParametro.GetType.ToString)

        Dim numeroDouble = rand.NextDouble
        Console.WriteLine("numeroDouble=" & numeroDouble & " " & numeroDouble.GetType.ToString)


        Dim numDoubleConDosParametro = rand.Next(1, 9) / 10
        Console.WriteLine("numDoubleConDosParametro=" & numDoubleConDosParametro & " " & numDoubleConDosParametro.GetType.ToString)


        Console.Read()
    End Sub
End Module
