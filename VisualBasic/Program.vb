Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Try
            Dim p1 = 0.0
            Dim p2 = 0.0
            Dim p3 = 0.0
            Console.WriteLine("Cajero ingresa el valor del producto 1")
            p1 = Double.Parse(Console.ReadLine())
            Console.WriteLine("Cajero ingresa el valor del producto 2")
            p2 = Double.Parse(Console.ReadLine())
            Console.WriteLine("Cajero ingresa el valor del producto 3")
            p3 = Double.Parse(Console.ReadLine())
            Dim suma As Double = p1 + p2 + p3
            Console.WriteLine("Humano deseas redondear tus centavos (S/N)")
            Dim res = Console.ReadLine()
            If res = "S" Or res = "s" Then
                Dim sumaRedondeada As Double = Math.Ceiling(suma)
                Dim redondeo As Double = sumaRedondeada - suma
                Console.WriteLine("Muchas gracias humano por redondear " & String.Format("{0:C}", redondeo))
            Else
                Console.WriteLine("Pinche humano micerable")
            End If
        Catch ex As Exception
            Console.WriteLine("Cajero estupido escribiste un valor no debido " & ex.ToString)
        End Try

        Console.Read()
    End Sub
End Module
