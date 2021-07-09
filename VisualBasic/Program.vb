Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Try
            Console.WriteLine("¿Humano con cuantos litros de cerveza te emborrachas?")
            Dim litros = Integer.Parse(Console.ReadLine())
            Dim mililitros = litros * 1000
            Console.WriteLine("¿Humano cual es el diametro de tu vaso?")
            Dim D = Integer.Parse(Console.ReadLine())
            Console.WriteLine("¿Humano cual es la altura de tu vaso?")
            Dim A = Integer.Parse(Console.ReadLine())
            Dim R = D / 2
            Dim V = Math.PI * R * 2 * A
            Dim vasosLimite = mililitros / V

            'Console.WriteLine("V=" & V & "  vasosLimite=" & vasosLimite)
            Console.WriteLine("¿Humano cunatos vasos de cerveza has tomado?")
            Dim vasosTomados = Integer.Parse(Console.ReadLine())
            If vasosTomados <= vasosLimite Then
                Console.WriteLine("Humano te hacen falta " & vasosLimite - vasosTomados & " vasos para estar borracho")
            Else
                Console.WriteLine("Humano ya te exediste con " & vasosTomados - vasosLimite & " vasos YA ESTAS BORRACHO")
            End If
        Catch ex As Exception
            Console.WriteLine("¡¡¡HUMANO YA ESTAS TAN BORRACHO QUE NI PUEDES ESCRIBIR UN NUMERO!!!")
        End Try

        Console.Read()
    End Sub
End Module
