Imports System

'Autor: Programador Novato
'Fecha: 01/01/2021
'Este modulo sirve para enseñar como funciona Visual Basic.NET
Module Program
    'Este codigo escribe un texto en amarillo con fondo azul
    Sub Main(args As String())
        Dim miPagina = "ProgramadorNovato.com"
        'miPagina = miPagina.ToUpper()
        'miPagina = miPagina.ToLower()
        miPagina = miPagina.Replace(".com", ".mx")
        Dim miPresentacion = "Esta es mi pagina web: "
        Console.WriteLine(miPresentacion & miPagina)
        Console.Read()
    End Sub
End Module
