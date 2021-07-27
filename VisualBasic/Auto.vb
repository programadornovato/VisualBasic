Class Auto
    Private color = ""
    Private modelo = 0
    Private marca = ""
    Private acceso = False
    Public Sub meterLlave(llave As String)
        If llave = "123456" Then
            acceso = True
            Console.WriteLine("Llave correcta")
        Else
            acceso = False
            Console.WriteLine("Llave incorrecta")
        End If
    End Sub
    Public Sub mando(accion As String)
        If acceso = True Then
            If accion = "enciende" Then
                enciende()
            End If
            If accion = "acelera" Then
                acelera()
            End If
            If accion = "frena" Then
                frena()
            End If
        Else
            Console.WriteLine("No se puede realizar la accion " & accion & " porque el acceso es falso")
        End If
    End Sub
    Private Sub enciende()
        Console.WriteLine("El auto ha encendido run run")
    End Sub
    Private Sub acelera()
        Console.WriteLine("El auto acelera")
    End Sub
    Private Sub frena()
        Console.WriteLine("El auto frena")
    End Sub
End Class
