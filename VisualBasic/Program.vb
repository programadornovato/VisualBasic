Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Public Sub Main(args As String())
        Try
            Console.WriteLine("Hola humano, bienvenido al banco pn")
            Console.WriteLine("Selecciona alguna de las siguientes opciones")
            Console.WriteLine("1.- Ver saldo")
            Console.WriteLine("2.- Ingresar dinero")
            Console.WriteLine("3.- Sacar dinero")
            Console.WriteLine("4.- Salir")
            Dim opcion = Integer.Parse(Console.ReadLine())
            Dim saldoInicial = 100.0
            Select Case opcion
                Case 1
                    Console.WriteLine("Humano tu saldo es de " & saldoInicial)
                Case 2
                    Console.WriteLine("Humano cuanto dinero quieres ingresar")
                    Dim ingresar = Double.Parse(Console.ReadLine())
                    saldoInicial = saldoInicial + ingresar
                    Console.WriteLine("Humano haz ingresado " & ingresar & " tu saldo es de " & saldoInicial)
                Case 3
                    Console.WriteLine("Humano cuanto dinero quieres sacar")
                    Dim sacar = Double.Parse(Console.ReadLine())
                    If sacar > saldoInicial Then
                        Console.WriteLine("Humano pillin no cuentas con saldo suficiente")
                    Else
                        saldoInicial = saldoInicial - sacar
                        Console.WriteLine("Humano haz sacado " & sacar & " tu saldo es de " & saldoInicial)
                    End If
                Case 4
                    Console.WriteLine("Adios humano gracias por usr el pn")
                Case Else
                    Console.WriteLine("Humano estupido te pedi que seleccionar alguna de las opciones")

            End Select

        Catch ex As Exception
            Console.WriteLine("Humano te pedi un numero valido " & ex.ToString)
        End Try

        Console.Read()
    End Sub
End Module
